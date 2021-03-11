using System.Text.Json;

namespace CoreAdc.Nitro.Common
{
    public class NitroJsonNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            return name.ToLower();
        }
    }
}
