using CoreAdc.NitroApi.Configuration.System.SystemCmdPolicy;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyUpdateCommand : NitroCommand<SystemCmdPolicyUpdateResponse>
    {
        public SystemCmdPolicyUpdateCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
