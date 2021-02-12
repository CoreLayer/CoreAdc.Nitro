using CoreAdc.NitroInterfaces;
using CoreAdc.NitroModel.Configuration.System.SystemCmdPolicy;

namespace CoreAdc.NitroApi.Configuration.System.SystemCmdPolicy
{
    internal class SystemCmdPolicyAddRequestDataRoot : INitroRequestDataRoot
    {
        public SystemCmdPolicyAddRequestData[] SystemCmdPolicy { get; set; }


        public SystemCmdPolicyAddRequestDataRoot(SystemCmdPolicyAddRequestData systemCmdPolicyAddRequestData)
        {
            SystemCmdPolicy = new[] { systemCmdPolicyAddRequestData };
        }

        public SystemCmdPolicyAddRequestDataRoot(SystemCmdPolicyAddRequestData[] systemCmdPolicyAddRequestDatas)
        {
            SystemCmdPolicy = systemCmdPolicyAddRequestDatas;
        }

        public override string ToString()
        {
            string result = "";

            foreach (var dataItem in SystemCmdPolicy)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}