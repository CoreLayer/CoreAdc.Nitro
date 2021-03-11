using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.System.SystemUser;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemUser
{
    internal class SystemUserUpdateRequestDataRoot : INitroRequestDataRoot
    {
        public SystemUserUpdateRequestData[] SystemUser { get; set; }


        public SystemUserUpdateRequestDataRoot(SystemUserUpdateRequestData SystemUserUpdateRequestData)
        {
            SystemUser = new[] { SystemUserUpdateRequestData };
        }

        public SystemUserUpdateRequestDataRoot(SystemUserUpdateRequestData[] SystemUserUpdateRequestDatas)
        {
            SystemUser = SystemUserUpdateRequestDatas;
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