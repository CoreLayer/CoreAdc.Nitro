using System.Text.Json;

namespace CoreAdc.Nitro.Api
{
    public static class NitroResponseDeserializer
    {
        public static T DeserializeIntoObject<T>(string jsonText)
        {
            // TODO DeserializeAsync
            return (T)JsonSerializer.Deserialize(jsonText, typeof(T), NitroDeserializerOptions.DeserializerOptions);
        }
    }
}
