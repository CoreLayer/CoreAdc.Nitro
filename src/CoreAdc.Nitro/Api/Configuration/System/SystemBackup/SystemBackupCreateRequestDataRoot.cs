using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.System.SystemBackup;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemBackup
{
    public class SystemBackupCreateRequestDataRoot : INitroRequestDataRoot
    {
        public SystemBackupCreateRequestData[] SystemBackup { get; }


        public SystemBackupCreateRequestDataRoot() { }
        
        public SystemBackupCreateRequestDataRoot(SystemBackupCreateRequestData systemBackupCreateRequestData)
        {
            SystemBackup = new[] { systemBackupCreateRequestData };
        }
        
        public SystemBackupCreateRequestDataRoot(SystemBackupCreateRequestData[] systemBackupCreateRequestDatas)
        {
            SystemBackup = systemBackupCreateRequestDatas;
        }
    }
}