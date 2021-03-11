using CoreAdc.Nitro.Api.Configuration.System.SystemUserSystemCmdPolicyBinding;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Commands.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingAddCommand : NitroCommand<SystemUserSystemCmdPolicyBindingAddResponse>
    {
        public SystemUserSystemCmdPolicyBindingAddCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
