using System.Text.Json.Serialization;
using CoreAdc.NitroModel.Configuration.Ns.NsLicense;

namespace CoreAdc.NitroApi.Configuration.Ns.NsLicense
{
    public class NsLicenseGetResponse : NitroResponse
    {
        [JsonPropertyName("nslicense")]
        public NsLicenseResponseData NsLicenseResponse { get; set; }
    }
}
