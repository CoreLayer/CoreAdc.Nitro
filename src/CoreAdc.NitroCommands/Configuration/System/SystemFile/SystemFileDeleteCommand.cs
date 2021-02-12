using CoreAdc.NitroApi.Configuration.System.SystemFile;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemFile
{
    public class SystemFileDeleteCommand : NitroCommand<SystemFileDeleteResponse>
    {
        public SystemFileDeleteCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
