using CoreAdc.NitroApi.Configuration.System.SystemUserSystemCmdPolicyBinding;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingAddCommand : NitroCommand<SystemUserSystemCmdPolicyBindingAddResponse>
    {
        public SystemUserSystemCmdPolicyBindingAddCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
