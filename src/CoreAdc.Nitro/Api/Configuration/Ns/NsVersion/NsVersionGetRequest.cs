using System.Net.Http;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Api.Configuration.Ns.NsVersion
{
    public class NsVersionGetRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Get;
        public sealed override string ResourcePath => "/nitro/v1/config/nsversion";
        public sealed override INitroRequestDataRoot DataRoot => new NsVersionGetRequestDataRoot();
        public sealed override INitroRequestOptions Options { get; set; } = new NsLicenseGetRequestOptions();
    }
}
