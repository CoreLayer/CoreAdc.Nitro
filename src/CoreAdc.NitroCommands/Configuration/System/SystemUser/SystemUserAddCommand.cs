using CoreAdc.NitroApi.Configuration.System.SystemUser;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemUser
{
    public class SystemUserAddCommand : NitroCommand<SystemUserAddResponse>
    {
        public SystemUserAddCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
