﻿using System.Net.Http;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroApi.Configuration.System.SystemFile
{
    public class SystemFileDeleteRequest : NitroRequest
    {
        public sealed override HttpMethod Method => HttpMethod.Delete;
        public sealed override string ResourcePath => "/nitro/v1/config/systemfile";
        public sealed override INitroRequestOptions Options { get; set; } = new SystemFileDeleteRequestOptions(null, null);
        public sealed override INitroRequestDataRoot DataRoot => new SystemFileDeleteRequestDataRoot();

        public SystemFileDeleteRequest() { }

        public SystemFileDeleteRequest(string fileName, string fileLocation)
        {
            Options = new SystemFileDeleteRequestOptions(fileName, fileLocation);
        }
    }
}