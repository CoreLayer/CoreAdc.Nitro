using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.System.SystemFile;

namespace CoreAdc.Nitro.Api.Configuration.System.SystemFile
{
    internal class SystemFileAddRequestDataRoot : INitroRequestDataRoot
    {
        public SystemFileAddRequestData[] SystemFile { get; set; }


        public SystemFileAddRequestDataRoot(SystemFileAddRequestData systemFileAddRequestData)
        {
            SystemFile = new [] {systemFileAddRequestData};
        }

        public SystemFileAddRequestDataRoot(SystemFileAddRequestData[] systemFileAddRequestDatas)
        {
            SystemFile = systemFileAddRequestDatas;
        }

        public override string ToString()
        {
            var result = "";

            foreach (var dataItem in SystemFile)
            {
                result += dataItem.ToString();
            }
            return result.ToString();
        }
    }
}