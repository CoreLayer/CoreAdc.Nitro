using System.Text.Json.Serialization;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Models.Configuration.System.SystemUser
{
    public class SystemUserUpdateRequestData : INitroRequestData
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; }

        [JsonPropertyName("externalauth")]
        public string ExternalAuthenticationStatus { get; set; } = "DISABLED";

        [JsonPropertyName("promptstring")]
        public string CommandLinePrompt { get; set; }

        [JsonPropertyName("timeout")]
        public double Timeout { get; set; } = 900;

        [JsonPropertyName("logging")]
        public string LoggingPrivilege { get; set; } = "DISABLED";

        [JsonPropertyName("maxsession")]
        public double MaximumUserSessions { get; set; } = 20;

        [JsonPropertyName("allowedmanagementinterface")]
        public string[] AllowedManagementInterface { get; set; } = {"CLI, API"};
    }
}
