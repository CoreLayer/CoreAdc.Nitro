using System.Text.Json.Serialization;
using CoreAdc.NitroModel.Configuration.System.SystemUser;

namespace CoreAdc.NitroApi.Configuration.System.SystemUser
{
    public class SystemUserAddResponse : NitroResponse
    {
        [JsonPropertyName("systemcmdpolicy")]
        public SystemUserResponseData[] SystemUser { get; set; }
    }
}
