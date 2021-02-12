using CoreAdc.NitroApi.Configuration.System.SystemFile;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemFile
{
    public class SystemFileAddCommand : NitroCommand<SystemFileAddResponse>
    {
        public SystemFileAddCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
