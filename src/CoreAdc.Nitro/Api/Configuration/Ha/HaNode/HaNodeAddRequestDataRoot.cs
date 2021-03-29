using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.Ha.HaNode;

namespace CoreAdc.Nitro.Api.Configuration.Ha.HaNode
{
    internal class HaNodeAddRequestDataRoot : INitroRequestDataRoot
    {
        public HaNodeAddRequestData[] HaNode { get; set; }


        public HaNodeAddRequestDataRoot(HaNodeAddRequestData haNodeAddRequestData)
        {
            HaNode = new[] { haNodeAddRequestData };
        }

        public HaNodeAddRequestDataRoot(HaNodeAddRequestData[] haNodeAddRequestDatas)
        {
            HaNode = haNodeAddRequestDatas;
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