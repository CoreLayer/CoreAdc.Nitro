using System.Text.Json.Serialization;
using CoreAdc.NitroModel.Configuration.System.SystemCmdPolicy;

namespace CoreAdc.NitroApi.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyGetResponse : NitroResponse
    {
        [JsonPropertyName("SystemCmdPolicy")]
        public SystemCmdPolicyResponseData[] SystemCmdPolicys { get; set; }
    }
}