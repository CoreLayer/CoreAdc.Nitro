using System.Text.Json.Serialization;
using CoreAdc.Nitro.Models.Configuration.System.SystemCmdPolicy;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyGetResponse : NitroResponse
    {
        [JsonPropertyName("SystemCmdPolicy")]
        public SystemCmdPolicyResponseData[] SystemCmdPolicys { get; set; }
    }
}