using System.Text.Json.Serialization;
using CoreAdc.Nitro.Models.Configuration.System.SystemBackup;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemBackup
{
    public class SystemBackupGetResponse : NitroResponse
    {
        [JsonPropertyName("systembackup")]
        public SystemBackupResponseData[] SystemBackups { get; set; }
    }
}