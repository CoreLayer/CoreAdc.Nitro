using CoreAdc.Nitro.Interfaces;
using CoreAdc.Nitro.Models.Configuration.Login;

namespace CoreAdc.Nitro.Api.Configuration.Login
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
