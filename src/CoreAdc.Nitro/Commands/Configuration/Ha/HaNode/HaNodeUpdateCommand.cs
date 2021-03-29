using CoreAdc.Nitro.Api.Configuration.Ha.HaNode;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Commands.Configuration.Ha.HaNode
{
    public class HaNodeUpdateCommand : NitroCommand<HaNodeUpdateResponse>
    {
        public HaNodeUpdateCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
