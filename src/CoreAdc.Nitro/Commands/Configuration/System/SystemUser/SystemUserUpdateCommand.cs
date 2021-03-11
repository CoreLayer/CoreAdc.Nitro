using CoreAdc.Nitro.Api.Configuration.System.SystemUser;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Commands.Configuration.System.SystemUser
{
    public class SystemUserUpdateCommand : NitroCommand<SystemUserUpdateResponse>
    {
        public SystemUserUpdateCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
