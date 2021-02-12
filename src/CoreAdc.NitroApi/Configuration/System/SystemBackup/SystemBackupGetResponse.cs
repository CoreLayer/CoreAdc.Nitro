using System.Text.Json.Serialization;
using CoreAdc.NitroModel.Configuration.System.SystemBackup;

namespace CoreAdc.NitroApi.Configuration.System.SystemBackup
{
    public class SystemBackupGetResponse : NitroResponse
    {
        [JsonPropertyName("systembackup")]
        public SystemBackupResponseData[] SystemBackups { get; set; }
    }
}