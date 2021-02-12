using CoreAdc.NitroApi.Configuration.System.SystemUserSystemCmdPolicyBinding;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingDeleteCommand : NitroCommand<SystemUserSystemCmdPolicyBindingDeleteResponse>
    {
        public SystemUserSystemCmdPolicyBindingDeleteCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}