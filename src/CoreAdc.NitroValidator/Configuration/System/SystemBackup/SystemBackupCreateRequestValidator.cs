using System.Threading;
using System.Threading.Tasks;
using CoreAdc.Nitro.Api.Configuration.System.SystemBackup;
using CoreAdc.Nitro.Commands.Configuration.System.SystemBackup;
using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.System.SystemBackup;
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

            var result = await command.GetNitroResponseAsync(cancellationToken);
            return result.SystemBackups == null;
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