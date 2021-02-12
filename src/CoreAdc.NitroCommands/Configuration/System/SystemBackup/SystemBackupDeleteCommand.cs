using CoreAdc.NitroApi.Configuration.System.SystemBackup;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemBackup
{
    public class SystemBackupDeleteCommand : NitroCommand<SystemBackupDeleteResponse>
    {
        public SystemBackupDeleteCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
