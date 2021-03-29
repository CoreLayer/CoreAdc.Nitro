using System.Net.Http;
using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.Ha.HaNode;

namespace CoreAdc.Nitro.Api.Configuration.Ha.HaNode
{
    public class HaNodeUpdateRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Put;
        public sealed override string ResourcePath => "/nitro/v1/config/hanode";
        public sealed override INitroRequestOptions Options => new HaNodeUpdateRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot { get; }


        public HaNodeUpdateRequest(HaNodeUpdateRequestData haNodeUpdateRequestData)
        {
            DataRoot = new HaNodeUpdateRequestDataRoot(haNodeUpdateRequestData);
        }
    }
}
