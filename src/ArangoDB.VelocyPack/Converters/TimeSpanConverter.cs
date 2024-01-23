using Newtonsoft.Json;

namespace ArangoDB.VelocyPack.Converters;

public class TimeSpanConverter : JsonConverter
{
    public override bool CanConvert(Type objectType)
    {
        if (objectType == typeof(TimeSpan) || objectType == typeof(TimeSpan?))
            return true;

        return false;
    }

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => writer.WriteValue((TimeSpan)value);

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer) => TimeSpan.FromTicks((long)reader.Value);
}
