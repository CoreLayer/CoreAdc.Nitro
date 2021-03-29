using System.Net.Http;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Api.Configuration.Ha.HaNode
{
    public class HaNodeDeleteRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Delete;
        public sealed override string ResourcePath => "/nitro/v1/config/hanode";
        public sealed override INitroRequestOptions Options { get; set; } = new HaNodeDeleteRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot => new HaNodeDeleteRequestDataRoot();


        public HaNodeDeleteRequest() { }

        public HaNodeDeleteRequest(string haNodeId)
        {
            Options = new HaNodeDeleteRequestOptions(haNodeId);
        }
    }
}
