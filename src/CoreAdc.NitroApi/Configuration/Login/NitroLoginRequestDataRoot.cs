using CoreAdc.NitroInterfaces;
using CoreAdc.NitroModel.Configuration.Login;

namespace CoreAdc.NitroApi.Configuration.Login
{
    internal class NitroLoginRequestDataRoot : INitroRequestDataRoot
    {
        public NitroLoginRequestData Login { get; set; }


        public NitroLoginRequestDataRoot()
        {
            Login = new NitroLoginRequestData("nsroot", "nsroot");
        }

        public NitroLoginRequestDataRoot(NitroLoginRequestData nitroLoginRequestData)
        {
            Login = nitroLoginRequestData;
        }
    }
}
