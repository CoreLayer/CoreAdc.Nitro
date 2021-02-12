using CoreAdc.NitroApi.Configuration.System.SystemCmdPolicy;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemCmdPolicy
{
    public class SystemCmdPolicyDeleteCommand : NitroCommand<SystemCmdPolicyDeleteResponse>
    {
        public SystemCmdPolicyDeleteCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}