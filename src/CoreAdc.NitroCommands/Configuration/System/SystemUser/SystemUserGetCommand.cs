using CoreAdc.NitroApi.Configuration.System.SystemUser;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemUser
{
    public class SystemUserGetCommand : NitroCommand<SystemUserGetResponse>
    {
        public SystemUserGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
