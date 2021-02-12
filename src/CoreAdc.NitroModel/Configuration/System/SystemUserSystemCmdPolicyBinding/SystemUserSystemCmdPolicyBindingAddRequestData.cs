using System.Text.Json.Serialization;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroModel.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingAddRequestData : INitroRequestData
    {
        [JsonPropertyName("priority")]
        public double Priority { get; set; }

        [JsonPropertyName("policyname")]
        public string PolicyName { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        public SystemUserSystemCmdPolicyBindingAddRequestData(string username, string policyName, double priority)
        {
            Username = username;
            PolicyName = policyName;
            Priority = priority;
        }
    }
}
