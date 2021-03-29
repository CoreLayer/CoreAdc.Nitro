using CoreAdc.Nitro.Api.Configuration.Ha.HaNode;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Commands.Configuration.Ha.HaNode
{
    public class HaNodeDeleteCommand : NitroCommand<HaNodeDeleteResponse>
    {
        public HaNodeDeleteCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}