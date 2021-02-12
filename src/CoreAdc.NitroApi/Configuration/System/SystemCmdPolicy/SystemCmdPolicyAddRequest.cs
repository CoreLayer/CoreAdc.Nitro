using System.Net.Http;
using CoreAdc.NitroInterfaces;
using CoreAdc.NitroModel.Configuration.System.SystemCmdPolicy;

namespace CoreAdc.NitroApi.Configuration.System.SystemCmdPolicy
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
