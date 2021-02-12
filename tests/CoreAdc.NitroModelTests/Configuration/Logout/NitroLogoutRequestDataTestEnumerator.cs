using System.Collections;
using System.Collections.Generic;
using CoreAdc.NitroModel.Configuration.Logout;

namespace CoreAdc.NitroModelTests.Configuration.Logout
{
    public class NitroLogoutRequestDataTestEnumerator : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new NitroLogoutRequestData(),
                new Dictionary<string, string>
                {
                    {"ContentString", "{}"},
                }
            };
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
