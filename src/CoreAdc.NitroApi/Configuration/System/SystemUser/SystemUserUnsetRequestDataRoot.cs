using CoreAdc.NitroInterfaces;
using CoreAdc.NitroModel.Configuration.System.SystemUser;

namespace CoreAdc.NitroApi.Configuration.System.SystemUser
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