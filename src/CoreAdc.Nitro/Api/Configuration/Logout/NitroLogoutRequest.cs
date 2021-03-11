using System.Net.Http;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Api.Configuration.Logout
{
    public class NitroLogoutRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Post;
        public sealed override string ResourcePath => "/nitro/v1/config/logout";
        public sealed override INitroRequestOptions Options => new NitroLogoutRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot => new NitroLogoutRequestDataRoot();
    }
}
