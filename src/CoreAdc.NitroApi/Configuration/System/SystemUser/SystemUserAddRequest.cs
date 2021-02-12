using System.Net.Http;
using CoreAdc.NitroInterfaces;
using CoreAdc.NitroModel.Configuration.System.SystemUser;

namespace CoreAdc.NitroApi.Configuration.System.SystemUser
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
