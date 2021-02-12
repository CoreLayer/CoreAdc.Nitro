using System.Net.Http;
using CoreAdc.NitroInterfaces;
using CoreAdc.NitroModel.Configuration.System.SystemFile;

namespace CoreAdc.NitroApi.Configuration.System.SystemFile
{
    public class SystemFileAddRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Post;
        public sealed override string ResourcePath => "/nitro/v1/config/systemfile";
        public sealed override INitroRequestOptions Options => new SystemFileAddRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot { get; }


        public SystemFileAddRequest(SystemFileAddRequestData systemFileAddRequestData)
        {
            DataRoot = new SystemFileAddRequestDataRoot(systemFileAddRequestData);
        }

        public SystemFileAddRequest(SystemFileAddRequestData[] systemFileAddRequestData)
        {
            DataRoot = new SystemFileAddRequestDataRoot(systemFileAddRequestData);
        }
    }
}