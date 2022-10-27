using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using KuduApi.Client.Abstractions.WebJobs.Models;

namespace KuduApi.Client.Abstractions.WebJobs.Serializations
{
    public class KuduWebJobConverter : JsonConverter<KuduWebJob>
    {
        public override KuduWebJob Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.StartObject)
                throw new JsonException();

            using (var jsonDocument = JsonDocument.ParseValue(ref reader))
            {
                if (!jsonDocument.RootElement.TryGetProperty("type", out var typeProperty))
                    throw new JsonException();
            
                var json = jsonDocument.RootElement.GetRawText();
                var typePropertyValue = typeProperty.GetString().ToLower();

                if (typePropertyValue == nameof(KuduWebJobType.Triggered).ToLower())
                    return (KuduTriggeredWebJob)JsonSerializer.Deserialize(json, typeof(KuduTriggeredWebJob), options);

                if (typePropertyValue == nameof(KuduWebJobType.Continuous).ToLower())
                    return (KuduContinuousWebJob)JsonSerializer.Deserialize(json, typeof(KuduContinuousWebJob), options);
            }

            throw new JsonException();
        }

        public override void Write(Utf8JsonWriter writer, KuduWebJob value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case KuduTriggeredWebJob triggered:
                    JsonSerializer.Serialize(writer, triggered);
                    break;
                case KuduContinuousWebJob continuous:
                    JsonSerializer.Serialize(writer, continuous);
                    break;
                default:
                    throw new JsonException();
            }
        }
    }
}