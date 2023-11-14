using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace HAN_ASD_ADP.Datasets;

public class PlainObjectConverter : JsonConverter<IReadOnlyCollection<object>>
{
    public override IReadOnlyCollection<object> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var result = new List<object>();

        if (reader.TokenType != JsonTokenType.StartArray)
            throw new JsonException();

        while (reader.Read())
        {
            if (reader.TokenType == JsonTokenType.EndArray)
                return result;

            switch (reader.TokenType)
            {
                case JsonTokenType.Number:
                    if (reader.TryGetInt32(out int intValue))
                    {
                        result.Add(intValue);
                    }
                    else
                    {
                        result.Add(reader.GetDouble());
                    }
                    break;
                case JsonTokenType.String:
                    result.Add(reader.GetString());
                    break;
                default:
                    throw new JsonException();
            }
        }

        throw new JsonException();
    }

    public override void Write(Utf8JsonWriter writer, IReadOnlyCollection<object> value, JsonSerializerOptions options)
        => throw new NotImplementedException();
}