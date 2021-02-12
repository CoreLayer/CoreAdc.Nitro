using System.Collections.Generic;

namespace CoreAdc.NitroApi.Configuration.System.SystemFile
{
    public class SystemFileGetRequestOptions : NitroArgumentRequestOptions
    {
        public SystemFileGetRequestOptions() { }

        public SystemFileGetRequestOptions(string fileLocation, string fileName)
        {
            Arguments = new Dictionary<string, string>
            {
                {"FileLocation", fileLocation},
                {"FileName", fileName}
            };
        }
    }
}