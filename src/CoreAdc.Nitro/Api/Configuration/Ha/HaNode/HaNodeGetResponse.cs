using System.Text.Json.Serialization;
using CoreAdc.Nitro.Models.Configuration.Ha.HaNode;

namespace CoreAdc.Nitro.Api.Configuration.Ha.HaNode
{
    public class HaNodeGetResponse : NitroResponse
    {
        [JsonPropertyName("hanode")]
        public HaNodeResponseData[] HaNode { get; set; }
    }
}