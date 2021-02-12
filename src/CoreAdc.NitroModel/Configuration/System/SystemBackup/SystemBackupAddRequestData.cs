using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroModel.Configuration.System.SystemBackup
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
