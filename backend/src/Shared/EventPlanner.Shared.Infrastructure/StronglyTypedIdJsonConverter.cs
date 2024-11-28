namespace EventPlanner.Shared.Infrastructure;

public class StronglyTypedIdJsonConverter<T, TValue> : JsonConverter<T>
    where T : StronglyTypedId<TValue>
    where TValue : notnull
{
    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String && typeof(TValue) == typeof(Guid))
        {
            var guid = Guid.Parse(reader.GetString()!);
            return (T)Activator.CreateInstance(typeof(T), guid)!;
        }
        if (reader.TokenType == JsonTokenType.Number && typeof(TValue) == typeof(int))
        {
            var intValue = reader.GetInt32();
            return (T)Activator.CreateInstance(typeof(T), intValue)!;
        }
        if (reader.TokenType == JsonTokenType.Number && typeof(TValue) == typeof(long))
        {
            var longValue = reader.GetInt64();
            return (T)Activator.CreateInstance(typeof(T), longValue)!;
        }
        throw new JsonException("Unsupported type for strongly typed ID.");
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.Value.ToString());
    }
}