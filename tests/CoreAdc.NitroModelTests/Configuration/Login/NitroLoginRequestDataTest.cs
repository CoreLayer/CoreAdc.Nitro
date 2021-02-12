using System.Collections.Generic;
using System.Text.Json;
using CoreAdc.NitroCommon;
using CoreAdc.NitroModel.Configuration.Login;
using Xunit;

namespace CoreAdc.NitroModelTests.Configuration.Login
{
    public class NitroLoginRequestDataTest
    {
        [Theory]
        [ClassData(typeof(NitroLoginRequestDataTestEnumerator))]
        public void ModelTest(NitroLoginRequestData nitroLoginRequestData, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(nitroLoginRequestData, typeof(NitroLoginRequestData), NitroSerializerOptions.JsonSerializerOptions));
            Assert.Equal(expected["ToString"], nitroLoginRequestData.ToString());
        }
    }
}
