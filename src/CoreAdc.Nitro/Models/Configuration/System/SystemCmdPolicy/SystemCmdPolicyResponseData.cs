using System.Text.Json.Serialization;

namespace CoreAdc.Nitro.Models.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyResponseData
    {
        [JsonPropertyName("policyname")]
        public string PolicyName { get; set; }

        [JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonPropertyName("cmdspec")]
        public string CommandSpecification { get; set; }

        [JsonPropertyName("builtin")]
        public string[] BuiltIn { get; set; }

        [JsonPropertyName("feature")]
        public string Feature { get; set; }
    }
}
