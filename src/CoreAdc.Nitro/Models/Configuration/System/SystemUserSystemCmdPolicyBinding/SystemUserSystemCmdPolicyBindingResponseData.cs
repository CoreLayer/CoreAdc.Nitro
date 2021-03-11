using System.Text.Json.Serialization;

namespace CoreAdc.Nitro.Models.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingResponseData
    {
        [JsonPropertyName("priority")]
        public double Priority { get; set; }

        [JsonPropertyName("policyname")]
        public string PolicyName { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }
    }
}
