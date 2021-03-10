using System.Threading;
using System.Threading.Tasks;
using CoreAdc.NitroApi.Configuration.System.SystemBackup;
using CoreAdc.NitroCommands.Configuration.System.SystemBackup;
using CoreAdc.NitroInterfaces;
using CoreAdc.NitroModel.Configuration.System.SystemBackup;
using FluentValidation;

namespace CoreAdc.NitroValidator.Configuration.System.SystemBackup
{
    public class SystemBackupCreateRequestDataValidator : AbstractValidator<SystemBackupCreateRequestData>
    {
        public SystemBackupCreateRequestDataValidator(INitroClient nitroClient)
        {
            RuleSet("Data", () =>
            {
                RuleFor(x => x.Filename)
                    .MustAsync(async (filename, cancellation) => await RemoteValidationAsync(nitroClient, filename, new CancellationToken())
                        )
                    .WithMessage("Backup name exists.");
            });
        }
        
        private async Task<bool> RemoteValidationAsync(INitroClient nitroClient, string filename, CancellationToken cancellationToken) {
            var command = new SystemBackupGetCommand(
                nitroClient,
                new SystemBackupGetRequest(filename + ".tgz")
            );

            var result = await command.GetResponse();
            return result.SystemBackups != null;
        }
    }

    public class SystemBackupCreateRequestValidator : AbstractValidator<SystemBackupCreateRequest>
    {
        public SystemBackupCreateRequestValidator(INitroClient nitroClient)
        {
            RuleSet("Data", () =>
            {
                RuleFor(x => (SystemBackupCreateRequestDataRoot) x.DataRoot)
                    .SetValidator(
                        new SystemBackupCreateRequestDataRootValidator(nitroClient), new []
                            {"Data"}
                        );
            });
        }
    }

    public class SystemBackupCreateRequestDataRootValidator : AbstractValidator<SystemBackupCreateRequestDataRoot>
    {
        public SystemBackupCreateRequestDataRootValidator(INitroClient nitroClient)
        {
            RuleSet("Data", () =>
            {
                RuleForEach(x => x.SystemBackup)
                    .SetValidator(
                        new SystemBackupCreateRequestDataValidator(nitroClient), new[] 
                            {"Data"}
                        );
            });
        }
    }
}