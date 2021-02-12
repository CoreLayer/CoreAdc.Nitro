using CoreAdc.NitroApi.Configuration.System.SystemBackup;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemBackup
{
    public class SystemBackupCreateCommand : NitroCommand<SystemBackupCreateResponse>
    {
        public SystemBackupCreateCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}