using System.Collections.Generic;

namespace CoreAdc.NitroApi.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingDeleteRequestOptions : NitroDeleteRequestOptions
    {
        public SystemUserSystemCmdPolicyBindingDeleteRequestOptions() { }

        public SystemUserSystemCmdPolicyBindingDeleteRequestOptions(string username, string policyName) : base(username)
        {
            Arguments = new Dictionary<string, string> {{"policyname", policyName}};
        }
    }
}