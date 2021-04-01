using System.Threading;
using System.Threading.Tasks;
using CoreAdc.Nitro.Api.Configuration.Ha.HaNode;
using CoreAdc.Nitro.Commands;
using CoreAdc.Nitro.Commands.Configuration.Ha.HaNode;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Operations.Configuration.Ha
{
    public static class HaNodeOperations
    {
        public static async Task<HaNodeGetResponse> GetAsync(INitroClient nitroClient, CancellationToken cancellationToken)
        {
            var haNodeGetCommand = NitroCommandFactory.Create<HaNodeGetCommand>(nitroClient);
            return await haNodeGetCommand.GetNitroResponseAsync(cancellationToken).ConfigureAwait(false);
        }
        
        public static async Task<HaNodeGetResponse> GetSingleNodeAsync(INitroClient nitroClient, string nodeId, CancellationToken cancellationToken)
        {
            var haNodeGetCommand = NitroCommandFactory.Create<HaNodeGetCommand>(nitroClient, new HaNodeGetRequestOptions(nodeId));
            return await haNodeGetCommand.GetNitroResponseAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}