using CoreAdc.NitroApi.Configuration.Ns.NsLicense;
using CoreAdc.NitroInterfaces;

namespace CoreAdc.NitroCommands.Configuration.Ns.NsVersion
{
    public class NsVersionGetCommand : NitroCommand<NsLicenseGetResponse>
    {
        public NsVersionGetCommand(INitroClient nitroClient, INitroRequest nitroRequest) : base(nitroClient, nitroRequest) { }
    }
}
