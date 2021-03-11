using CoreAdc.Nitro.Api.Configuration.System.SystemBackup;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Commands.Configuration.System.SystemBackup
{
    public class SystemBackupDeleteCommand : NitroCommand<SystemBackupDeleteResponse>
    {
        public SystemBackupDeleteCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
