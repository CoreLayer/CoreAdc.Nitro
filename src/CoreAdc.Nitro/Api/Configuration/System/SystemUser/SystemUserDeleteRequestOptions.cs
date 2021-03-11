namespace CoreAdc.Nitro.Api.Configuration.System.SystemUser
{
    public class SystemUserDeleteRequestOptions : NitroDeleteRequestOptions
    {
        public SystemUserDeleteRequestOptions() { }
        public SystemUserDeleteRequestOptions(string username) : base(username) { }
    }
}