using System.Net.Http;
using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.System.SystemUser;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemUser
{
    public class SystemUserAddRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Post;
        public sealed override string ResourcePath => "/nitro/v1/config/systemuser";
        public sealed override INitroRequestOptions Options => new SystemUserAddRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot { get; }


        public SystemUserAddRequest(SystemUserAddRequestData systemCmdPolicyAddRequestData)
        {
            DataRoot = new SystemUserAddRequestDataRoot(systemCmdPolicyAddRequestData);
        }
    }
}
