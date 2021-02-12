using System.Net.Http;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroApi.Configuration.System.SystemUser
{
    public class SystemUserDeleteRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Delete;
        public sealed override string ResourcePath => "/nitro/v1/config/systemuser";
        public sealed override INitroRequestOptions Options { get; set; } = new SystemUserDeleteRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot => new SystemUserDeleteRequestDataRoot();


        public SystemUserDeleteRequest() { }

        public SystemUserDeleteRequest(string resourceName)
        {
            Options = new SystemUserDeleteRequestOptions(resourceName);
        }
    }
}
