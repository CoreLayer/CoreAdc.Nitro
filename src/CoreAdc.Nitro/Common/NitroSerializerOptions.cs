using System.Text.Json;

namespace CoreAdc.Nitro.Common
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
