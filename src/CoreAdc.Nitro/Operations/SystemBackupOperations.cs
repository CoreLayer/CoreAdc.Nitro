using System.Threading.Tasks;
using CoreAdc.Nitro.Api.Configuration.System.SystemBackup;
using CoreAdc.Nitro.Api.Configuration.System.SystemCmdPolicy;
using CoreAdc.Nitro.Api.Configuration.System.SystemFile;
using CoreAdc.Nitro.Commands;
using CoreAdc.Nitro.Commands.Configuration.System.SystemBackup;
using CoreAdc.Nitro.Commands.Configuration.System.SystemCmdPolicy;
using CoreAdc.Nitro.Commands.Configuration.System.SystemFile;
using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.System.SystemBackup;
using CoreAdc.Nitro.Models.Configuration.System.SystemCmdPolicy;

namespace CoreAdc.Nitro.Operations
{
    public class SystemBackupOperations
    {
        public const string SystemBackupGetCmdPolicySpecification = "(^(show\\s+system\\s+backup))";
        public const string SystemBackupCreateAndDeleteCmdPolicySpecification = "(^(create|rm)\\s+system\\s+backup\\s+.*)";
        public const string SystemBackupDownloadCmdPolicySpecification = "(^show\\ssystem\\sfile\\s[\\w\\.-]+\\s-fileLocation\\s\"/var/ns_sys_backup\")";

        public const string SystemBackupOperationsCmdPolicySpecification =
            SystemBackupGetCmdPolicySpecification + "|" + SystemBackupCreateAndDeleteCmdPolicySpecification + "|" + SystemBackupDownloadCmdPolicySpecification;


        public static async Task<SystemCmdPolicyAddResponse> CreateSystemCmdPolicyAsync(INitroClient nitroClient, string systemCmdPolicyName)
        {
            var systemCmdPolicyAddCommand =
                NitroCommandFactory.Create<SystemCmdPolicyAddCommand>(
                    nitroClient, 
                    new SystemCmdPolicyAddRequestData(
                        systemCmdPolicyName, 
                        SystemCmdPolicyAction.Allow,
                        SystemBackupOperationsCmdPolicySpecification)
                    );
            return await systemCmdPolicyAddCommand.GetResponse();
        }

        public static async Task<SystemCmdPolicyDeleteResponse> DeleteSystemCmdPolicyAsync(INitroClient nitroClient, string systemCmdPolicyName)
        {
            var systemCmdPolicyDeleteCommand =
                NitroCommandFactory.Create<SystemCmdPolicyDeleteCommand>(
                    nitroClient,
                    systemCmdPolicyName
                    );
            return await systemCmdPolicyDeleteCommand.GetResponse();
        }

        public static async Task<SystemBackupGetResponse> GetAsync(INitroClient nitroClient, string fileName)
        {
            var systemBackupGetCommand = NitroCommandFactory.Create<SystemBackupGetCommand>(
                nitroClient, 
                new SystemBackupGetRequestOptions(fileName)
                );
            return await systemBackupGetCommand.GetResponse();
        }

        public static async Task<SystemBackupGetResponse> GetAllAsync(INitroClient nitroClient)
        {
            var systemBackupGetCommand = NitroCommandFactory.Create<SystemBackupGetCommand>(nitroClient);
            return await systemBackupGetCommand.GetResponse();
        }

        public static async Task<SystemBackupCreateResponse> CreateAsync(INitroClient nitroClient, SystemBackupLevel level, string fileName)
        {
            var systemBackupCreateCommand = NitroCommandFactory.Create<SystemBackupCreateCommand>(
                nitroClient, 
                new SystemBackupCreateRequestData(level, fileName)
                );
            return await systemBackupCreateCommand.GetResponse();
        }

        public static async Task<SystemBackupCreateResponse> CreateAsync(INitroClient nitroClient, string fileName)
        {
            var systemBackupCreateCommand = NitroCommandFactory.Create<SystemBackupCreateCommand>(
                nitroClient,
                new SystemBackupCreateRequestData(SystemBackupLevel.Full, fileName)
            );
            return await systemBackupCreateCommand.GetResponse();
        }

        public static async Task<SystemBackupDeleteResponse> DeleteAsync(INitroClient nitroClient, string fileName)
        {
            var systemBackupDeleteCommand = NitroCommandFactory.Create<SystemBackupDeleteCommand>(
                nitroClient,
                fileName
                );

            return await systemBackupDeleteCommand.GetResponse();
        }

        public static async Task<SystemFileGetResponse> DownloadAsBase64Async(INitroClient nitroClient, string fileName)
        {
            var systemFileGetCommand = NitroCommandFactory.Create<SystemFileGetCommand>(
                nitroClient, 
                new SystemFileGetRequestOptions("/var/ns_sys_backup", fileName)
                );

            return await systemFileGetCommand.GetResponse();
        }
    }
}
