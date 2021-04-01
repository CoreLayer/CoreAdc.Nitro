using System.Threading;
using System.Threading.Tasks;
using CoreAdc.Nitro.Api.Configuration.System.SystemBackup;
using CoreAdc.Nitro.Api.Configuration.System.SystemFile;
using CoreAdc.Nitro.Commands;
using CoreAdc.Nitro.Commands.Configuration.System.SystemBackup;
using CoreAdc.Nitro.Commands.Configuration.System.SystemFile;
using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.System.SystemBackup;

namespace CoreAdc.Nitro.Operations.Configuration.System
{
    public static class SystemBackupOperations
    {
        public static async Task<SystemBackupGetResponse> GetAsync(INitroClient nitroClient, string fileName, CancellationToken cancellationToken)
        {
            var systemBackupGetCommand = NitroCommandFactory.Create<SystemBackupGetCommand>(
                nitroClient, 
                new SystemBackupGetRequestOptions(fileName)
                );
            return await systemBackupGetCommand.GetNitroResponseAsync(cancellationToken).ConfigureAwait(false);
        }

        public static async Task<SystemBackupGetResponse> GetAllAsync(INitroClient nitroClient, CancellationToken cancellationToken)
        {
            var systemBackupGetCommand = NitroCommandFactory.Create<SystemBackupGetCommand>(nitroClient);
            return await systemBackupGetCommand.GetNitroResponseAsync(cancellationToken).ConfigureAwait(false);
        }

        public static async Task<SystemBackupCreateResponse> CreateAsync(INitroClient nitroClient, SystemBackupLevel level, string fileName, CancellationToken cancellationToken)
        {
            var systemBackupCreateCommand = NitroCommandFactory.Create<SystemBackupCreateCommand>(
                nitroClient, 
                new SystemBackupCreateRequestData(level, fileName)
                );
            return await systemBackupCreateCommand.GetNitroResponseAsync(cancellationToken).ConfigureAwait(false);
        }

        public static async Task<SystemBackupDeleteResponse> DeleteAsync(INitroClient nitroClient, string fileName, CancellationToken cancellationToken)
        {
            var systemBackupDeleteCommand = NitroCommandFactory.Create<SystemBackupDeleteCommand>(
                nitroClient,
                fileName
                );

            return await systemBackupDeleteCommand.GetNitroResponseAsync(cancellationToken).ConfigureAwait(false);
        }

        public static async Task<SystemFileGetResponse> DownloadAsBase64Async(INitroClient nitroClient, string fileName, CancellationToken cancellationToken)
        {
            var systemFileGetCommand = NitroCommandFactory.Create<SystemFileGetCommand>(
                nitroClient, 
                new SystemFileGetRequestOptions("/var/ns_sys_backup", fileName)
                );

            return await systemFileGetCommand.GetNitroResponseAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
