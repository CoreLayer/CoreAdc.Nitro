using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CoreAdc.Nitro.Interfaces
{
    public interface INitroCommand<T>
    {
        INitroClient NitroClient { get; }
        INitroRequest NitroRequest { get; }
        Task<HttpResponseMessage> GetHttpResponseAsync(CancellationToken cancellationToken);
        Task<T> GetNitroResponseAsync(CancellationToken cancellationToken);
    }
}
