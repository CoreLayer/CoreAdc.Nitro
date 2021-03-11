using System.Text.Json.Serialization;
using CoreAdc.Nitro.Models.Configuration.System.SystemCmdPolicy;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyUpdateResponse : NitroResponse
    {
        [JsonPropertyName("systemcmdpolicy")]
        public SystemCmdPolicyResponseData[] SystemCmdPolicy { get; set; }
    }
}
