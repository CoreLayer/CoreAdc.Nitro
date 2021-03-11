using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CoreAdc.Nitro.Interfaces
{
    public interface INitroClient
    {
        Task Login(CancellationToken cancellationToken);
        Task Logout(CancellationToken cancellationToken);

        Task<HttpResponseMessage> SendAsync(HttpRequestMessage httpRequestMessage, CancellationToken cancellationToken);
    }
}
