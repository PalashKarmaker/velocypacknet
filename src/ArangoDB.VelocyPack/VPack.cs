using ArangoDB.VelocyPack.Converters;
using Newtonsoft.Json;

namespace ArangoDB.VelocyPack;

public static class VPack
{
    private static JsonSerializerSettings SerializerSetting
    {
        get
        {
            var convertes = new List<JsonConverter>
            {
                new TimeSpanConverter()
            };

            return new JsonSerializerSettings
            {
                Converters = convertes
            };
        }
    }

    public static byte[] Serialize(object value)
    {
        using SliceWriter sliceWriter = new();
        var jsonSerializer = JsonSerializer.Create(SerializerSetting);
        jsonSerializer.Serialize(sliceWriter, value);

        return sliceWriter.GetBuffer();
    }

    public static T Deserialize<T>(byte[] buffer)
    {
        using SliceReader sliceReader = new(buffer);
        JsonSerializer jsonSerializer = JsonSerializer.Create(SerializerSetting);
        return jsonSerializer.Deserialize<T>(sliceReader);
    }

    public static object Deserialize(byte[] buffer, Type type)
    {
        using SliceReader sliceReader = new(buffer);
        JsonSerializer jsonSerializer = JsonSerializer.Create(SerializerSetting);
        return jsonSerializer.Deserialize(sliceReader, type);
    }
}
