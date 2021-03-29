using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.Ha.HaNode;

namespace CoreAdc.Nitro.Api.Configuration.Ha.HaNode
{
    internal class HaNodeUpdateRequestDataRoot : INitroRequestDataRoot
    {
        public HaNodeUpdateRequestData[] HaNode { get; set; }


        public HaNodeUpdateRequestDataRoot(HaNodeUpdateRequestData haNodeUpdateRequestData)
        {
            HaNode = new[] { haNodeUpdateRequestData };
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