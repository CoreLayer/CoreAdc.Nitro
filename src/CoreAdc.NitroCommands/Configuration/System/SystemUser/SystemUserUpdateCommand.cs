using CoreAdc.NitroApi.Configuration.System.SystemUser;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemUser
{
    public class SystemUserUpdateCommand : NitroCommand<SystemUserUpdateResponse>
    {
        public SystemUserUpdateCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
