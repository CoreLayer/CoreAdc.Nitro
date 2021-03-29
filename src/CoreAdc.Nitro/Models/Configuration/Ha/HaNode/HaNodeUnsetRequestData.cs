using System.Text.Json.Serialization;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Models.Configuration.Ha.HaNode
{
    public class HaNodeUnsetRequestData : INitroRequestData
    {
        [JsonPropertyName("id")]
        public double Id { get; set; }

        [JsonPropertyName("hastatus")]
        public string HaStatus { get; set; }

        [JsonPropertyName("hasync")]
        public string HaSynchronization { get; set; }

        [JsonPropertyName("haprop")]
        public string HaPropagation { get; set; }

        [JsonPropertyName("hellointerval")]
        public double HelloInterval { get; set; }

        [JsonPropertyName("deadinterval")]
        public double DeadInterval { get; set; }

        [JsonPropertyName("failsafe")]
        public string Failsafe { get; set; }

        [JsonPropertyName("maxflips")]
        public string MaxFlips { get; set; } // Double

        [JsonPropertyName("maxfliptime")]
        public string MaxFlipTime { get; set; } // Double

        [JsonPropertyName("syncvlan")]
        public double SynchronizationVlan { get; set; }

        [JsonPropertyName("syncstatusstrictmode")]
        public string SynchronizationStrictModeStatus { get; set; }
    }
}
