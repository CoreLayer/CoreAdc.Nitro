using System.Net.Http;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Api.Configuration.Ns.NsLicense
{
    public class NsLicenseGetRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Get;
        public sealed override string ResourcePath => "/nitro/v1/config/nslicense";
        public sealed override INitroRequestDataRoot DataRoot => new NsLicenseGetRequestDataRoot();
        public sealed override INitroRequestOptions Options { get; set; } = new NsLicenseGetRequestOptions();
    }
}
