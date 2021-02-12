using CoreAdc.NitroApi.Configuration.System.SystemCmdPolicy;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyAddCommand : NitroCommand<SystemCmdPolicyAddResponse>
    {
        public SystemCmdPolicyAddCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
