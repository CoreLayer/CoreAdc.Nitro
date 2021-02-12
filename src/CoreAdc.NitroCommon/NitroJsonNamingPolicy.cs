using System.Text.Json;

namespace CoreAdc.NitroCommon
{
    public class NitroJsonNamingPolicy : JsonNamingPolicy
    {
        public override string ConvertName(string name)
        {
            return name.ToLower();
        }
    }
}
