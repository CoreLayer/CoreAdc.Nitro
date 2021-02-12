using System.Collections.Generic;
using System.Text.Json;
using CoreAdc.NitroCommon;
using CoreAdc.NitroModel.Configuration.Ns.NsVersion;
using Xunit;

namespace CoreAdc.NitroModelTests.Configuration.Ns
{
    public class NsVersionResponseDataTest
    {
        [Theory]
        [ClassData(typeof(NsVersionResponseDataTestEnumerator))]
        public void ModelTest(NsVersionResponseData nsVersionResponseData, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(nsVersionResponseData, typeof(NsVersionResponseData), NitroSerializerOptions.JsonSerializerOptions));
            Assert.Equal(expected["Release"], nsVersionResponseData.Release);
            Assert.Equal(expected["Build"], nsVersionResponseData.Build);
            Assert.Equal(expected["ReleaseDate"], nsVersionResponseData.ReleaseDate);
        }
    }
}
