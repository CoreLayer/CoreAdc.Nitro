using System.Net.Http;
using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.System.SystemCmdPolicy;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyAddRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Post;
        public sealed override string ResourcePath => "/nitro/v1/config/systemcmdpolicy";
        public sealed override INitroRequestOptions Options => new SystemCmdPolicyAddRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot { get; }


        public SystemCmdPolicyAddRequest(SystemCmdPolicyAddRequestData systemCmdPolicyAddRequestData)
        {
            DataRoot = new SystemCmdPolicyAddRequestDataRoot(systemCmdPolicyAddRequestData);
        }
    }
}
