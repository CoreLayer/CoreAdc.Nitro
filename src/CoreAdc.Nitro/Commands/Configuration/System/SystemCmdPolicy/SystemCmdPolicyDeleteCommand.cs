using CoreAdc.Nitro.Api.Configuration.System.SystemCmdPolicy;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Commands.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyDeleteCommand : NitroCommand<SystemCmdPolicyDeleteResponse>
    {
        public SystemCmdPolicyDeleteCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}