using System.Text.Json;

namespace CoreAdc.NitroCommon
{
    public static class NitroSerializerOptions
    {
        public static JsonSerializerOptions JsonSerializerOptions =>
            new JsonSerializerOptions
            {
                PropertyNamingPolicy = new NitroJsonNamingPolicy(),
                IgnoreNullValues = true,
            };
    }
}
