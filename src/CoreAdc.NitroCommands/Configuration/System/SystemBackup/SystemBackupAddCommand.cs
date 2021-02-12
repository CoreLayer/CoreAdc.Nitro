using CoreAdc.NitroApi.Configuration.System.SystemBackup;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemBackup
{
    public class SystemBackupAddCommand : NitroCommand<SystemBackupAddResponse>
    {
        public SystemBackupAddCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
