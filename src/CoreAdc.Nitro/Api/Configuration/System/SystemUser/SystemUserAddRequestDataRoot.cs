using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.System.SystemUser;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemUser
{
    internal class SystemUserAddRequestDataRoot : INitroRequestDataRoot
    {
        public SystemUserAddRequestData[] SystemUser { get; set; }


        public SystemUserAddRequestDataRoot(SystemUserAddRequestData systemCmdPolicyAddRequestData)
        {
            SystemUser = new[] { systemCmdPolicyAddRequestData };
        }

        public SystemUserAddRequestDataRoot(SystemUserAddRequestData[] systemCmdPolicyAddRequestDatas)
        {
            SystemUser = systemCmdPolicyAddRequestDatas;
        }

        public override string ToString()
        {
            string result = "";

            foreach (var dataItem in SystemUser)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}