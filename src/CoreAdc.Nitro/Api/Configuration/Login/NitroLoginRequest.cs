using System.Net.Http;
using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.Login;

namespace CoreAdc.Nitro.Api.Configuration.Login
{
    public class NitroLoginRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Post;
        public sealed override string ResourcePath => "/nitro/v1/config/login";
        public sealed override INitroRequestOptions Options => new NitroLoginRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot { get; }
        

        public NitroLoginRequest(NitroLoginRequestData nitroLoginRequestData)
        {
            DataRoot = new NitroLoginRequestDataRoot(nitroLoginRequestData);
        }
    }
}
