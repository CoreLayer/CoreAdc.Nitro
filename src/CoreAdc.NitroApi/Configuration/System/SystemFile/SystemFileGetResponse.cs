using System.Text.Json.Serialization;
using CoreAdc.NitroModel.Configuration.System.SystemFile;

namespace CoreAdc.NitroApi.Configuration.System.SystemFile
{
    public class SystemFileGetResponse : NitroResponse
    {
        [JsonPropertyName("systemfile")]
        public SystemFileResponseData[] SystemFiles { get; set; }
    }
}