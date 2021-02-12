using System.Collections.Generic;
using System.Text.Json;
using CoreAdc.NitroCommon;
using CoreAdc.NitroModel.Configuration.System.SystemBackup;
using Xunit;

namespace CoreAdc.NitroModelTests.Configuration.System
{
    public class SystemBackupCreateRequestDataTest
    {
        [Theory]
        [ClassData(typeof(SystemBackupCreateRequestDataTestEnumerator))]
        public void ModelTest(SystemBackupCreateRequestData systemBackupCreateRequestData, Dictionary<string, string> expected)
        {
            Assert.Equal(expected["ContentString"], JsonSerializer.Serialize(systemBackupCreateRequestData, typeof(SystemBackupCreateRequestData), NitroSerializerOptions.JsonSerializerOptions));
            Assert.Equal(expected["Level"], systemBackupCreateRequestData.Level);
            Assert.Equal(expected["Filename"], systemBackupCreateRequestData.Filename);
            Assert.Equal(expected["Comment"], systemBackupCreateRequestData.Comment);
        }
    }
}
