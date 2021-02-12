using CoreAdc.NitroApi.Configuration.System.SystemUserSystemCmdPolicyBinding;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemUserSystemCmdPolicyBinding
{
    public class SystemUserSystemCmdPolicyBindingGetCommand : NitroCommand<SystemUserSystemCmdPolicyBindingGetResponse>
    {
        public SystemUserSystemCmdPolicyBindingGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
