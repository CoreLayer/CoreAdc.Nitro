using System.Text.Json.Serialization;
using CoreAdc.NitroModel.Configuration.System.SystemUser;

namespace CoreAdc.NitroApi.Configuration.System.SystemUser
{
    public class SystemUserGetResponse : NitroResponse
    {
        [JsonPropertyName("systemuser")]
        public SystemUserResponseData[] SystemUser { get; set; }
    }
}