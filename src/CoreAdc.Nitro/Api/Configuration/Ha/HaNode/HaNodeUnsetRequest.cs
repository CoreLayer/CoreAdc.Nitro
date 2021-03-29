using System.Net.Http;
using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.Ha.HaNode;

namespace CoreAdc.Nitro.Api.Configuration.Ha.HaNode
{
    public class HaNodeUnsetRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Post;
        public sealed override string ResourcePath => "/nitro/v1/config/hanode";
        public sealed override INitroRequestOptions Options => new HaNodeUnsetRequestOptions();
        public sealed override INitroRequestDataRoot DataRoot { get; }


        public HaNodeUnsetRequest(HaNodeUnsetRequestData haNodeUnsetRequestData)
        {
            DataRoot = new HaNodeUnsetRequestDataRoot(haNodeUnsetRequestData);
        }
    }
}
