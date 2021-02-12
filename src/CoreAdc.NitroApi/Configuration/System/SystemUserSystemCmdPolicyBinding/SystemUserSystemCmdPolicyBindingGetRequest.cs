﻿using System.Net.Http;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroApi.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingGetRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Get;
        public sealed override string ResourcePath => "/nitro/v1/config/systemuser_systemcmdpolicy_binding";
        public sealed override INitroRequestOptions Options { get; set; } = new SystemUserSystemCmdPolicyBindingGetRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot => new SystemUserSystemCmdPolicyBindingGetRequestDataRoot();


        public SystemUserSystemCmdPolicyBindingGetRequest() { }

        public SystemUserSystemCmdPolicyBindingGetRequest(string username)
        {
            Options = new SystemUserSystemCmdPolicyBindingGetRequestOptions(username);
        }
    }
}
