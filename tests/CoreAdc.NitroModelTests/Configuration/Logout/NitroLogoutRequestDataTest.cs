using System.Collections.Generic;
using System.Text.Json;
using CoreAdc.NitroCommon;
using CoreAdc.NitroModel.Configuration.Logout;
using Xunit;

namespace CoreAdc.NitroModelTests.Configuration.Logout
{
    public class NitroLogoutRequestDataTest
    {
        [Theory]
        [ClassData(typeof(NitroLogoutRequestDataTestEnumerator))]
        public void ModelTest(NitroLogoutRequestData nitroLogoutRequestData, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(nitroLogoutRequestData, typeof(NitroLogoutRequestData), NitroSerializerOptions.JsonSerializerOptions));
        }
    }
}
