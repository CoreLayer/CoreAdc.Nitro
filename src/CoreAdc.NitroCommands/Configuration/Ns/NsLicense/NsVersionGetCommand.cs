using CoreAdc.NitroApi.Configuration.Ns.NsLicense;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.Ns.NsLicense
{
    public class NsLicenseGetCommand : NitroCommand<NsLicenseGetResponse>
    {
        public NsLicenseGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
