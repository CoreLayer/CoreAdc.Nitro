using System.Net.Http;
using CoreAdc.NitroInterfaces;
using CoreAdc.NitroModel.Configuration.System.SystemUserSystemCmdPolicyBinding;

namespace CoreAdc.NitroApi.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingAddRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Put;
        public sealed override string ResourcePath => "/nitro/v1/config/systemuser_systemcmdpolicy_binding";
        public sealed override INitroRequestOptions Options => new SystemUserSystemCmdPolicyBindingAddRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot { get; }


        public SystemUserSystemCmdPolicyBindingAddRequest(SystemUserSystemCmdPolicyBindingAddRequestData systemCmdPolicyAddRequestData)
        {
            DataRoot = new SystemUserSystemCmdPolicyBindingAddRequestDataRoot(systemCmdPolicyAddRequestData);
        }
    }
}
