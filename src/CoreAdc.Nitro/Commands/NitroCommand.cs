using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CoreAdc.Nitro.Api;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Commands
{
    public abstract class NitroCommand<T> : INitroCommand<T>
    {
        public INitroClient NitroClient { get; }
        public INitroRequest NitroRequest { get; }

        
        protected NitroCommand() { }

        protected NitroCommand(INitroClient nitroClient, INitroRequest nitroRequest)
        {
            NitroClient = nitroClient;
            NitroRequest = nitroRequest;
        }

        public async Task<HttpResponseMessage> GetHttpResponseAsync(CancellationToken cancellationToken)
        {
            return await NitroClient.SendAsync(
                await NitroRequest.GetHttpRequestMessageAsync().ConfigureAwait(false), cancellationToken).ConfigureAwait(false);
        }

        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">The request is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">The number of characters is larger than MaxValue.</exception>
        /// <exception cref="InvalidOperationException">The request message was already sent by the HttpClient instance.</exception>
        /// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout</exception>
        /// <exception cref="ObjectDisposedException">The stream has been disposed.</exception>
        public async Task<T> GetNitroResponseAsync(CancellationToken cancellationToken)
        {
            var httpResponseMessage = await GetHttpResponseAsync(cancellationToken).ConfigureAwait(false);

            await using var httpContentStream = await httpResponseMessage.Content.ReadAsStreamAsync(cancellationToken).ConfigureAwait(false);
            var httpContentStreamReader = new StreamReader(httpContentStream);

            var nitroResponse = await httpContentStreamReader.ReadToEndAsync().ConfigureAwait(false);

            return NitroResponseDeserializer.DeserializeIntoObject<T>(nitroResponse != string.Empty ? nitroResponse : "{ \"errorcode\": 0 }");
        }
    }
}
