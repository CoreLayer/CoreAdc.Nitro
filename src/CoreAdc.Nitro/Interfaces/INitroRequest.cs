using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace CoreAdc.Nitro.Interfaces
{
    public interface INitroRequest
    {
        HttpMethod Method { get; }
        MediaTypeHeaderValue ContentType { get; }
        string ResourcePath { get; }
        INitroRequestOptions Options { get; set; }

        INitroRequestDataRoot DataRoot { get; }

        //Task<ValidationResult> ValidateAsync();
        Task<HttpRequestMessage> GetHttpRequestMessageAsync();
    }
}
