namespace CoreAdc.Nitro.Api.Configuration.Ha.HaNode
{
    public class HaNodeDeleteRequestOptions : NitroDeleteRequestOptions
    {
        public HaNodeDeleteRequestOptions() { }
        public HaNodeDeleteRequestOptions(string haNodeId) : base(haNodeId) { }
    }
}