using System.Text.Json.Serialization;
using CoreAdc.NitroModel.Configuration.System.SystemCmdPolicy;

namespace CoreAdc.NitroApi.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyAddResponse : NitroResponse
    {
        [JsonPropertyName("systemcmdpolicy")]
        public SystemCmdPolicyResponseData[] SystemCmdPolicy { get; set; }
    }
}
