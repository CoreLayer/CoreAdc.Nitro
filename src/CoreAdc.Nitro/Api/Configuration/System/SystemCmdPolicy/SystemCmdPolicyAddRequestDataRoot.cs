using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.System.SystemCmdPolicy;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemCmdPolicy
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