using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.Ha.HaNode;

namespace CoreAdc.Nitro.Api.Configuration.Ha.HaNode
{
    internal class HaNodeUnsetRequestDataRoot : INitroRequestDataRoot
    {
        public HaNodeUnsetRequestData[] HaNode { get; set; }


        public HaNodeUnsetRequestDataRoot(HaNodeUnsetRequestData haNodeUnsetRequestData)
        {
            HaNode = new[] { haNodeUnsetRequestData };
        }

        public override string ToString()
        {
            string result = "";

            foreach (var dataItem in HaNode)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}