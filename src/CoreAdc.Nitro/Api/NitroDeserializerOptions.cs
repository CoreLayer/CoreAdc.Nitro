using System.Text.Json;

namespace CoreAdc.Nitro.Api
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
