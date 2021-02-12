using CoreAdc.NitroInterfaces;
using CoreAdc.NitroModel.Configuration.System.SystemBackup;

namespace CoreAdc.NitroApi.Configuration.System.SystemBackup
{
    internal class SystemBackupCreateRequestDataRoot : INitroRequestDataRoot
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