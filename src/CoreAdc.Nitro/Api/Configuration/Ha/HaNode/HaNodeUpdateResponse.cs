using System.Text.Json.Serialization;
using CoreAdc.Nitro.Models.Configuration.System.SystemUser;

namespace CoreAdc.Nitro.Api.Configuration.Ha.HaNode
{
    public class HaNodeUpdateResponse : NitroResponse
    {
        [JsonPropertyName("hanode")]
        public SystemUserResponseData[] HaNode { get; set; }
    }
}
