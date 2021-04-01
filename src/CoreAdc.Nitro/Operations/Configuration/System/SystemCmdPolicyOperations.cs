using System.Threading;
using System.Threading.Tasks;
using CoreAdc.Nitro.Api.Configuration.System.SystemCmdPolicy;
using CoreAdc.Nitro.Commands;
using CoreAdc.Nitro.Commands.Configuration.System.SystemCmdPolicy;
using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.System.SystemCmdPolicy;

namespace CoreAdc.Nitro.Operations.Configuration.System
{
    public static class SystemCmdPolicyOperations
    {
        public static async Task<SystemCmdPolicyAddResponse> CreateSystemCmdPolicyAsync(INitroClient nitroClient, string name, SystemCmdPolicyAction action, string specification, CancellationToken cancellationToken)
        {
            var systemCmdPolicyAddCommand =
                NitroCommandFactory.Create<SystemCmdPolicyAddCommand>(
                    nitroClient, 
                    new SystemCmdPolicyAddRequestData(
                        name, 
                        SystemCmdPolicyAction.Allow,
                        specification)
                    );
            return await systemCmdPolicyAddCommand.GetNitroResponseAsync(cancellationToken).ConfigureAwait(false);
        }

        public static async Task<SystemCmdPolicyDeleteResponse> DeleteSystemCmdPolicyAsync(INitroClient nitroClient, string name, CancellationToken cancellationToken)
        {
            var systemCmdPolicyDeleteCommand =
                NitroCommandFactory.Create<SystemCmdPolicyDeleteCommand>(
                    nitroClient,
                    name
                    );
            return await systemCmdPolicyDeleteCommand.GetNitroResponseAsync(cancellationToken).ConfigureAwait(false);
        }

        public static async Task<SystemCmdPolicyUpdateResponse> UpdateSystemCmdPolicyAsync(INitroClient nitroClient, string name, SystemCmdPolicyAction action, string policySpecification, CancellationToken cancellationToken)
        {
            var systemCmdPolicyUpdateCommand =
                NitroCommandFactory.Create<SystemCmdPolicyUpdateCommand>(
                    nitroClient,
                    new SystemCmdPolicyUpdateRequestData(
                        name,
                        action,
                        policySpecification)
                    );
            return await systemCmdPolicyUpdateCommand.GetNitroResponseAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}