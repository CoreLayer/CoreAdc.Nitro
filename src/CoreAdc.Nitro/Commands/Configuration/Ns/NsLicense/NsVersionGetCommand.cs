using CoreAdc.Nitro.Api.Configuration.Ns.NsLicense;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Commands.Configuration.Ns.NsLicense
{
    public class NsLicenseGetCommand : NitroCommand<NsLicenseGetResponse>
    {
        public NsLicenseGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
