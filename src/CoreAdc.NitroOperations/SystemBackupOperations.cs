﻿using System.Linq;
using System.Threading.Tasks;
using CoreAdc.NitroApi.Configuration.System.SystemBackup;
using CoreAdc.NitroApi.Configuration.System.SystemCmdPolicy;
using CoreAdc.NitroApi.Configuration.System.SystemFile;
using CoreAdc.NitroCommands;
using CoreAdc.NitroCommands.Configuration.System.SystemBackup;
using CoreAdc.NitroCommands.Configuration.System.SystemCmdPolicy;
using CoreAdc.NitroCommands.Configuration.System.SystemFile;
using CoreAdc.NitroInterfaces;
using CoreAdc.NitroModel.Configuration.System.SystemBackup;
using CoreAdc.NitroModel.Configuration.System.SystemCmdPolicy;
using CoreAdc.NitroModel.Configuration.System.SystemFile;

namespace CoreAdc.NitroOperations
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

        public static async Task<SystemBackupDeleteResponse> DeleteAsync(INitroClient nitroClient, string fileName)
        {
            var systemBackupDeleteCommand = NitroCommandFactory.Create<SystemBackupDeleteCommand>(
                nitroClient,
                fileName
                );

            return await systemBackupDeleteCommand.GetResponse();
        }

        public static async Task<SystemFileResponseData> DownloadAsBase64Async(INitroClient nitroClient, string fileName)
        {
            var systemFileGetCommand = NitroCommandFactory.Create<SystemFileGetCommand>(
                nitroClient, 
                new SystemFileGetRequestOptions("/var/ns_sys_backup", fileName)
                );

            var response = await systemFileGetCommand.GetResponse();

            return response.SystemFiles.Single(file => file.FileName.Equals(fileName));
        }
    }
}
