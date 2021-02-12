using CoreAdc.NitroInterfaces;
using CoreAdc.NitroModel.Configuration.Logout;

namespace CoreAdc.NitroApi.Configuration.Logout
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
