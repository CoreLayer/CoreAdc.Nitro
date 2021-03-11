using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace CoreAdc.Nitro.Interfaces
{
    public interface INitroCommand<T>
    {
        INitroClient NitroClient { get; }
        INitroRequest NitroRequest { get; }
        // Task<ValidationResult> ValidateAsync(CancellationToken cancellationToken);
        Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken);
        Task<T> GetResponse();
    }
}
