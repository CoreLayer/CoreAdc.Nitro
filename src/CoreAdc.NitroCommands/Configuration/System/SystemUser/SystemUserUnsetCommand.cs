using CoreAdc.NitroApi.Configuration.System.SystemUser;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemUser
{
    public class SystemUserUnsetCommand : NitroCommand<SystemUserUnsetResponse>
    {
        public SystemUserUnsetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
