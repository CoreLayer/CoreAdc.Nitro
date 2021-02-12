using CoreAdc.NitroInterfaces;
using CoreAdc.NitroModel.Configuration.System.SystemBackup;

namespace CoreAdc.NitroApi.Configuration.System.SystemBackup
{
    internal class SystemBackupAddRequestDataRoot : INitroRequestDataRoot
    {
        public SystemBackupAddRequestData[] SystemBackup { get; set; }


        public SystemBackupAddRequestDataRoot(SystemBackupAddRequestData systemBackupAddRequestData)
        {
            SystemBackup = new []{ systemBackupAddRequestData };
        }

        public SystemBackupAddRequestDataRoot(SystemBackupAddRequestData[] systemBackupAddRequestDatas)
        {
            SystemBackup = systemBackupAddRequestDatas;
        }

        public override string ToString()
        {
            var result = "";

            foreach (var dataItem in SystemBackup)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}