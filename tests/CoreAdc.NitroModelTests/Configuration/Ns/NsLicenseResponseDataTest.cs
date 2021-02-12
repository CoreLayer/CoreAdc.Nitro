using System.Collections.Generic;
using System.Text.Json;
using CoreAdc.NitroCommon;
using CoreAdc.NitroModel.Configuration.Ns.NsLicense;
using Xunit;

namespace CoreAdc.NitroModelTests.Configuration.Ns
{
    public class NsLicenseResponseDataTest
    {
        [Theory]
        [ClassData(typeof(NsLicenseResponseDataTestEnumerator))]
        public void ModelTest(NsLicenseResponseData nsLicenseResponseData, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(nsLicenseResponseData, typeof(NsLicenseResponseData), NitroSerializerOptions.JsonSerializerOptions));
        }
    }
}
