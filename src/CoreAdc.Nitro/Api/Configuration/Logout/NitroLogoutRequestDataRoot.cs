using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.Logout;

namespace CoreAdc.Nitro.Api.Configuration.Logout
{
    internal class NitroLogoutRequestDataRoot : INitroRequestDataRoot
    {
        public NitroLogoutRequestData Logout { get; set; }


        public NitroLogoutRequestDataRoot()
        {
            Logout = new NitroLogoutRequestData();
        }
    }
}
