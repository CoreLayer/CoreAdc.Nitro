using System.Collections.Generic;

namespace CoreAdc.Nitro.Interfaces
{
    public interface INitroRequestOptions
    {
        string ResourceName { get; set; }
        Dictionary<string, string> ResourceFilter { get; set; }
        List<string> PropertyFilter { get; set; }
        string Action { get; }
        bool Count { get; }
        string ToString();
    }
}
