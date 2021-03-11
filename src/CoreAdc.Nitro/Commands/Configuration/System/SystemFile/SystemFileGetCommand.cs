using CoreAdc.Nitro.Api.Configuration.System.SystemFile;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Commands.Configuration.System.SystemFile
{
    public class SystemFileGetCommand : NitroCommand<SystemFileGetResponse>
    {
        public SystemFileGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
