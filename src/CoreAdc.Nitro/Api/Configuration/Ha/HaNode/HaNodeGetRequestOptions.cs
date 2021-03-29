namespace CoreAdc.Nitro.Api.Configuration.Ha.HaNode
{
    public class HaNodeGetRequestOptions : NitroDefaultRequestOptions
    {
        public HaNodeGetRequestOptions() { }

        public HaNodeGetRequestOptions(string haNodeId): base(haNodeId) { }
    }
}