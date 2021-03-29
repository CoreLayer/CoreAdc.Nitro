using CoreAdc.Nitro.Api.Configuration.Ha.HaNode;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Commands.Configuration.Ha.HaNode
{
    public class HaNodeGetCommand : NitroCommand<HaNodeGetResponse>
    {
        public HaNodeGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
