using System.Text.Json.Serialization;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroModel.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyAddRequestData : INitroRequestData
    {
        public string PolicyName { get; set; }
        public string Action { get; }

        [JsonPropertyName("cmdspec")]
        public string CommandSpecification { get; set; }


        public SystemCmdPolicyAddRequestData(string policyName, SystemCmdPolicyAction systemCmdPolicyAction, string commandSpecification)
        {
            PolicyName = policyName;
            Action = systemCmdPolicyAction.ToString();
            CommandSpecification = commandSpecification;
        }
    }
}
