using System.Net.Http;
using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.System.SystemBackup;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemBackup
{
    public class SystemBackupAddRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Post;
        public sealed override string ResourcePath => "/nitro/v1/config/systembackup";
        public sealed override INitroRequestOptions Options => new SystemBackupAddRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot { get; }


        public SystemBackupAddRequest(SystemBackupAddRequestData systemBackupAddRequestData)
        {
            DataRoot = new SystemBackupAddRequestDataRoot(systemBackupAddRequestData);
        }
    }
}
