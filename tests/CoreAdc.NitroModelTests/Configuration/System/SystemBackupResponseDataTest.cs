using System.Collections.Generic;
using System.Text.Json;
using CoreAdc.NitroCommon;
using CoreAdc.NitroModel.Configuration.System.SystemBackup;
using Xunit;

namespace CoreAdc.NitroModelTests.Configuration.System
{
    public class SystemBackupResponseDataTest
    {
        [Theory]
        [ClassData(typeof(SystemBackupResponseDataTestEnumerator))]
        public void ModelTest(SystemBackupResponseData systemBackupResponseData, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(systemBackupResponseData, typeof(SystemBackupResponseData), NitroSerializerOptions.JsonSerializerOptions));
        }
    }
}
