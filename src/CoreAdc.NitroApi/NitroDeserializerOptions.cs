using System.Text.Json;

namespace CoreAdc.NitroApi
{
    public class NitroDeserializerOptions
    {
        public static JsonSerializerOptions DeserializerOptions => new JsonSerializerOptions()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = true,
            WriteIndented = true
        };
    }
}
