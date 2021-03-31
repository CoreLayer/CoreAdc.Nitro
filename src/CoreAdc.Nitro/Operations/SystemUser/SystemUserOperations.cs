using System.Threading;
using System.Threading.Tasks;
using CoreAdc.Nitro.Api.Configuration.System.SystemUser;
using CoreAdc.Nitro.Api.Configuration.System.SystemUserSystemCmdPolicyBinding;
using CoreAdc.Nitro.Commands;
using CoreAdc.Nitro.Commands.Configuration.System.SystemUser;
using CoreAdc.Nitro.Commands.Configuration.System.SystemUserSystemCmdPolicyBinding;
using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.System.SystemUser;
using CoreAdc.Nitro.Models.Configuration.System.SystemUserSystemCmdPolicyBinding;

namespace CoreAdc.Nitro.Operations.SystemUser
{
    public class SystemUserOperations
    {

        public static async Task<SystemUserAddResponse> AddAsync(INitroClient nitroClient, SystemUserAddOperationData userAddOperationData, CancellationToken cancellationToken)
        {
            var systemUserAddCommand =
                NitroCommandFactory.Create<SystemUserAddCommand>(
                    nitroClient,
                    new SystemUserAddRequestData
                    {
                        Username = userAddOperationData.Username,
                        Password = userAddOperationData.Password,
                        ExternalAuthenticationStatus = userAddOperationData.ExternalAuthenticationStatus.ToString(),
                        LoggingPrivilege = userAddOperationData.LoggingPrivilege.ToString(),
                        CommandLinePrompt = userAddOperationData.CommandLinePrompt,
                        Timeout = userAddOperationData.Timeout,
                        MaximumUserSessions = userAddOperationData.MaximumUserSessions,
                        AllowedManagementInterface = userAddOperationData.AllowedManagementInterface
                    }
                );
            return await systemUserAddCommand.GetNitroResponseAsync(cancellationToken).ConfigureAwait(false);
        }

        public static async Task<SystemUserDeleteResponse> DeleteAsync(INitroClient nitroClient, string username, CancellationToken cancellationToken)
        {
            var systemUserDeleteCommand =
                NitroCommandFactory.Create<SystemUserDeleteCommand>(
                    nitroClient,
                    username
                );
            return await systemUserDeleteCommand.GetNitroResponseAsync(cancellationToken).ConfigureAwait(false);
        }

        public static async Task<SystemUserGetResponse> GetAsync(INitroClient nitroClient, string username, CancellationToken cancellationToken)
        {
            var systemUserGetCommand = NitroCommandFactory.Create<SystemUserGetCommand>(
                nitroClient,
                new SystemUserGetRequestOptions(username)
                );
            return await systemUserGetCommand.GetNitroResponseAsync(cancellationToken).ConfigureAwait(false);
        }

        public static async Task<SystemUserGetResponse> GetAllAsync(INitroClient nitroClient, CancellationToken cancellationToken)
        {
            var systemUserGetCommand = NitroCommandFactory.Create<SystemUserGetCommand>(nitroClient);
            return await systemUserGetCommand.GetNitroResponseAsync(cancellationToken).ConfigureAwait(false);
        }

        public static async Task<SystemUserSystemCmdPolicyBindingAddResponse> BindSystemCmdPolicyAsync(
            INitroClient nitroClient, string username, string policyName, double priority, CancellationToken cancellationToken)
        {
            var systemUserSystemCmdPolicyBindingAddCommand =
                NitroCommandFactory.Create<SystemUserSystemCmdPolicyBindingAddCommand>(
                    nitroClient,
                    new SystemUserSystemCmdPolicyBindingAddRequestData(username, policyName, priority)
                );
            return await systemUserSystemCmdPolicyBindingAddCommand.GetNitroResponseAsync(cancellationToken).ConfigureAwait(false);
        }

        public static async Task<SystemUserSystemCmdPolicyBindingDeleteResponse> UnbindSystemCmdPolicyAsync(
            INitroClient nitroClient, string username, string policyName, CancellationToken cancellationToken)
        {
            var systemUserSystemCmdPolicyBindingDeleteCommand =
                NitroCommandFactory.Create<SystemUserSystemCmdPolicyBindingDeleteCommand>(
                    nitroClient,
                    new SystemUserSystemCmdPolicyBindingDeleteRequestOptions(username, policyName)
                );
            return await systemUserSystemCmdPolicyBindingDeleteCommand.GetNitroResponseAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
