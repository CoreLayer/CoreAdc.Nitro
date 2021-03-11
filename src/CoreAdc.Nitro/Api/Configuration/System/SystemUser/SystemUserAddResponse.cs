using System.Text.Json.Serialization;
using CoreAdc.Nitro.Models.Configuration.System.SystemUser;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemUser
{
    public class SystemUserAddResponse : NitroResponse
    {
        [JsonPropertyName("systemcmdpolicy")]
        public SystemUserResponseData[] SystemUser { get; set; }
    }
}
