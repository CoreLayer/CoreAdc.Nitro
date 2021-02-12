﻿using System.Collections.Generic;
using System.Text.Json;
using CoreAdc.NitroCommon;
using CoreAdc.NitroModel.Configuration.System.SystemFile;
using Xunit;

namespace CoreAdc.NitroModelTests.Configuration.System
{
    public class SystemFileResponseDataTest
    {
        [Theory]
        [ClassData(typeof(SystemFileResponseDataTestEnumerator))]
        public void ModelTest(SystemFileResponseData systemFileResponseData, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(systemFileResponseData, typeof(SystemFileResponseData), NitroSerializerOptions.JsonSerializerOptions));
        }
    }
}
