using System.Net.Http;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Api.Configuration.Ha.HaNode
{
    public class HaNodeGetRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Get;
        public sealed override string ResourcePath => "/nitro/v1/config/hanode";
        public sealed override INitroRequestOptions Options { get; set; } = new HaNodeGetRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot => new HaNodeGetRequestDataRoot();


        public HaNodeGetRequest() { }

        public HaNodeGetRequest(string haNodeId)
        {
            Options = new HaNodeGetRequestOptions(haNodeId);
        }
    }
}
