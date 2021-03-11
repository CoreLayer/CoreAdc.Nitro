using System.Text.Json.Serialization;
using CoreAdc.Nitro.Models.Configuration.Ns.NsLicense;

namespace CoreAdc.Nitro.Api.Configuration.Ns.NsLicense
{
    public class NsLicenseGetResponse : NitroResponse
    {
        [JsonPropertyName("nslicense")]
        public NsLicenseResponseData NsLicenseResponse { get; set; }
    }
}
