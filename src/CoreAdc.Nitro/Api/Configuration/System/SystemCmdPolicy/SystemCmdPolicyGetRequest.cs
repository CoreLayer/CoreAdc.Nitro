using System.Net.Http;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyGetRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Get;
        public sealed override string ResourcePath => "/nitro/v1/config/systemcmdpolicy";
        public sealed override INitroRequestOptions Options { get; set; } = new SystemCmdPolicyGetRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot => new SystemCmdPolicyGetRequestDataRoot();


        public SystemCmdPolicyGetRequest() { }

        public SystemCmdPolicyGetRequest(string resourceName)
        {
            Options = new SystemCmdPolicyGetRequestOptions(resourceName);
        }
    }
}
