using CoreAdc.NitroApi.Configuration.System.SystemBackup;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemBackup
{
    public class SystemBackupGetCommand : NitroCommand<SystemBackupGetResponse>
    {
        public SystemBackupGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
