using System.Text.Json.Serialization;
using CoreAdc.NitroModel.Configuration.Ns.NsVersion;

namespace CoreAdc.NitroApi.Configuration.Ns.NsVersion
{
    public class NsLicenseGetResponse : NitroResponse
    {
        [JsonPropertyName("nsversion")]
        public NsVersionResponseData NsVersionResponse { get; set; }
    }
}
