using System.Text.Json.Serialization;
using CoreAdc.Nitro.Models.Configuration.System.SystemUserSystemCmdPolicyBinding;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingGetResponse : NitroResponse
    {
        [JsonPropertyName("systemuser_systemcmdpolicy_binding")]
        public SystemUserSystemCmdPolicyBindingResponseData[] SystemUserSystemCmdPolicyBinding { get; set; }
    }
}