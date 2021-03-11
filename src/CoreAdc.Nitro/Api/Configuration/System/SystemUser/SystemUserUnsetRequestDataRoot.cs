using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.System.SystemUser;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemUser
{
    internal class SystemUserUnsetRequestDataRoot : INitroRequestDataRoot
    {
        public SystemUserUnsetRequestData[] SystemUser { get; set; }


        public SystemUserUnsetRequestDataRoot(SystemUserUnsetRequestData SystemUserUnsetRequestData)
        {
            SystemUser = new[] { SystemUserUnsetRequestData };
        }

        public SystemUserUnsetRequestDataRoot(SystemUserUnsetRequestData[] SystemUserUnsetRequestDatas)
        {
            SystemUser = SystemUserUnsetRequestDatas;
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