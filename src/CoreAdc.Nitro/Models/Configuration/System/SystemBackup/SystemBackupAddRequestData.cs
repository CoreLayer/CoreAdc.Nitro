using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Models.Configuration.System.SystemBackup
{
    public class SystemBackupAddRequestData : INitroRequestData
    {
        public string FileName { get; }

        public SystemBackupAddRequestData(string fileName)
        {
            FileName = fileName;
        }
    }
}
