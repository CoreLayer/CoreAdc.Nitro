using System.Text.Json.Serialization;
using CoreAdc.Nitro.Models.Configuration.Ns.NsVersion;

namespace CoreAdc.Nitro.Api.Configuration.Ns.NsVersion
{
    public class NsLicenseGetResponse : NitroResponse
    {
        [JsonPropertyName("nsversion")]
        public NsVersionResponseData NsVersionResponse { get; set; }
    }
}
