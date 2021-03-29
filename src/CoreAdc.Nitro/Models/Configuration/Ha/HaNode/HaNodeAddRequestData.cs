using System.Text.Json.Serialization;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Models.Configuration.Ha.HaNode
{
    public class HaNodeAddRequestData : INitroRequestData
    {
        [JsonPropertyName("id")]
        public double Id { get; set; }
        
        [JsonPropertyName("ipaddress")]
        public string IpAddress { get; set; }
        
        [JsonPropertyName("inc")]
        public string IndependentNetworkConfiguration { get; set; }

        public HaNodeAddRequestData(double id, string ipAddress, string independentNetworkConfiguration)
        {
            Id = id;
            IpAddress = ipAddress;
            IndependentNetworkConfiguration = independentNetworkConfiguration;
        }
    }
}
