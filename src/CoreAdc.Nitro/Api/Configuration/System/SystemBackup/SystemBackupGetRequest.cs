using System.Net.Http;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemBackup
{
    public class SystemBackupGetRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Get;
        public sealed override string ResourcePath => "/nitro/v1/config/systembackup";
        public sealed override INitroRequestOptions Options { get; set; } = new SystemBackupGetRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot => new SystemBackupGetRequestDataRoot();


        public SystemBackupGetRequest() { }

        public SystemBackupGetRequest(string resourceName)
        {
            Options = new SystemBackupGetRequestOptions(resourceName);
        }
    }
}
