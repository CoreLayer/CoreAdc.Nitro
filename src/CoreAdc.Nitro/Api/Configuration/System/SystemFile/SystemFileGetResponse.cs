using System.Text.Json.Serialization;
using CoreAdc.Nitro.Models.Configuration.System.SystemFile;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemFile
{
    public class SystemFileGetResponse : NitroResponse
    {
        [JsonPropertyName("systemfile")]
        public SystemFileResponseData[] SystemFiles { get; set; }
    }
}