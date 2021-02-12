using CoreAdc.NitroApi.Configuration.System.SystemUser;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemUser
{
    public class SystemUserDeleteCommand : NitroCommand<SystemUserDeleteResponse>
    {
        public SystemUserDeleteCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}