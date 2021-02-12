using System.Net.Http;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroApi.Configuration.System.SystemFile
{
    public class SystemFileGetRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Get;
        public sealed override string ResourcePath => "/nitro/v1/config/systemfile";
        public sealed override INitroRequestOptions Options { get; set; } = new SystemFileGetRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot => new SystemFileGetRequestDataRoot();

    }
}