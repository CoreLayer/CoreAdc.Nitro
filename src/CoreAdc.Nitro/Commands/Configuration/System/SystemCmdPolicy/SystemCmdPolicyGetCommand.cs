using CoreAdc.Nitro.Api.Configuration.System.SystemCmdPolicy;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Commands.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyGetCommand : NitroCommand<SystemCmdPolicyGetResponse>
    {
        public SystemCmdPolicyGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
