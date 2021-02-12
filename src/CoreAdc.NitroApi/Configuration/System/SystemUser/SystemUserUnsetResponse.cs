using System.Text.Json.Serialization;
using CoreAdc.NitroModel.Configuration.System.SystemUser;

namespace CoreAdc.NitroApi.Configuration.System.SystemUser
{
    public class SystemUserUnsetResponse : NitroResponse
    {
        [JsonPropertyName("systemuser")]
        public SystemUserResponseData[] SystemUser { get; set; }
    }
}
