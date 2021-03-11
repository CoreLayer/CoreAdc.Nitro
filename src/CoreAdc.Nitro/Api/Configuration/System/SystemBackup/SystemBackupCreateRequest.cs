using System.Net.Http;
using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.System.SystemBackup;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemBackup
{
    public class SystemBackupCreateRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Post;
        public sealed override string ResourcePath => "/nitro/v1/config/systembackup";
        public sealed override INitroRequestOptions Options { get; set; } = new SystemBackupCreateRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot { get; } = new SystemBackupCreateRequestDataRoot();


        public SystemBackupCreateRequest() { }

        public SystemBackupCreateRequest(SystemBackupCreateRequestData systemBackupCreateRequestData)
        {
            DataRoot = new SystemBackupCreateRequestDataRoot(systemBackupCreateRequestData);
        }
    }
}
