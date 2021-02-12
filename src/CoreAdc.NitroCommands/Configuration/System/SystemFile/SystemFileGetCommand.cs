using CoreAdc.NitroApi.Configuration.System.SystemFile;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.System.SystemFile
{
    public class SystemFileGetCommand : NitroCommand<SystemFileGetResponse>
    {
        public SystemFileGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
