using System.Text.Json.Serialization;
using CoreAdc.NitroModel.Configuration.System.SystemUserSystemCmdPolicyBinding;

namespace CoreAdc.NitroApi.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("systemuser_systemcmdpolicy_binding")]
        public SystemUserSystemCmdPolicyBindingResponseData[] SystemUserSystemCmdPolicyBinding { get; set; }
    }
}