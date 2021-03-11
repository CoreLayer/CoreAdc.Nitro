using CoreAdc.Nitro.Api.Configuration.System.SystemUser;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Commands.Configuration.System.SystemUser
{
    public class SystemUserUnsetCommand : NitroCommand<SystemUserUnsetResponse>
    {
        public SystemUserUnsetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
