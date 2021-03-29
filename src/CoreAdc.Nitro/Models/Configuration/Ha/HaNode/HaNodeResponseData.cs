using System.Text.Json.Serialization;

namespace CoreAdc.Nitro.Models.Configuration.Ha.HaNode
{
    // Documentation at https://developer-docs.citrix.com/projects/citrix-adc-nitro-api-reference/en/latest/configuration/ha/hanode/#add
    public class HaNodeResponseData
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } // Double

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("ipaddress")]
        public string IpAddress { get; set; }

        [JsonPropertyName("flags")]
        public string Flags { get; set; } // Double

        [JsonPropertyName("hastatus")]
        public string HaStatus { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }

        [JsonPropertyName("hasync")]
        public string HaSynchronization { get; set; }

        [JsonPropertyName("haprop")]
        public string HaPropagation { get; set; }

        [JsonPropertyName("enaifaces")]
        public string EnabledInterfaces { get; set; }

        [JsonPropertyName("disifaces")]
        public string DisabledInterfaces { get; set; }

        [JsonPropertyName("hamonifaces")]
        public string HaMonitoringInterfaces { get; set; }

        [JsonPropertyName("haheartbeatifaces")]
        public string HaHeartbeatInterfaces { get; set; }

        [JsonPropertyName("pfifaces")]
        public string PartialFailureInterfaces { get; set; }

        [JsonPropertyName("ifaces")]
        public string Interfaces { get; set; }

        [JsonPropertyName("netmask")]
        public string Netmask { get; set; }

        [JsonPropertyName("inc")]
        public string IndependentNetworkConfiguration { get; set; }

        [JsonPropertyName("ssl2")]
        public string SslCardStatus { get; set; }

        [JsonPropertyName("hellointerval")]
        public double HelloInterval { get; set; }

        [JsonPropertyName("deadinterval")]
        public double DeadInterval { get; set; }

        [JsonPropertyName("masterstatetime")]
        public double MasterStateTime { get; set; }

        [JsonPropertyName("failsafe")]
        public string Failsafe { get; set; }

        [JsonPropertyName("routemonitor")]
        public string RouteMonitor { get; set; }

        [JsonPropertyName("maxflips")]
        public string MaxFlips { get; set; } // Double

        [JsonPropertyName("maxfliptime")]
        public string MaxFlipTime { get; set; } // Double

        [JsonPropertyName("curflips")]
        public string CurrentFlips { get; set; } // Double

        [JsonPropertyName("completedfliptime")]
        public string CompletedFlipTime { get; set; } // Double

        [JsonPropertyName("syncvlan")]
        public double SynchronizationVlan { get; set; }

        [JsonPropertyName("routemonitorstate")]
        public string RouteMonitorState { get; set; }

        [JsonPropertyName("hasyncfailurereason")]
        public string HaSynchronizationFailureReason { get; set; }

        [JsonPropertyName("syncstatusstrictmode")]
        public string SynchronizationStrictModeStatus { get; set; }
    }
    
    public enum IndependentNetworkConfigurationStatus
    {
        Enabled,
        Disabled
    }

    public enum HighAvailabilityMode
    {
        Enabled,
        StayPrimary,
        StaySecondary,
        Disabled
    }

    public enum HaSynchronizationStatus
    {
        Enabled,
        Disabled
    }

    public enum HaPropagationStatus
    {
        Enabled,
        Disabled
    }

    public enum SslCardStatus
    {
        Up,
        Down,
        NotPresent,
        Unknown
    }

    public enum RouteMonitorStatus
    {
        Up,
        Down
    }
    
    public enum SynchronizationStrictModeStatus
    {
        Enabled,
        Disabled
    }
}