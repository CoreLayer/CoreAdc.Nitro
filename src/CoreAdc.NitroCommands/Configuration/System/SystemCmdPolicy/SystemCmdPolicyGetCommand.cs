using CoreAdc.NitroApi.Configuration.System.SystemCmdPolicy;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyGetCommand : NitroCommand<SystemCmdPolicyGetResponse>
    {
        public SystemCmdPolicyGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
