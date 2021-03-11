using CoreAdc.Nitro.Api.Configuration.Ns.NsLicense;
using CoreAdc.Nitro.Interfaces;

namespace CoreAdc.Nitro.Commands.Configuration.Ns.NsVersion
{
    public class NsVersionGetCommand : NitroCommand<NsLicenseGetResponse>
    {
        public NsVersionGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
