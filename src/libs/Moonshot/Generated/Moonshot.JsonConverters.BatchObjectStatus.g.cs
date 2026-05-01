#nullable enable

namespace Moonshot.JsonConverters
{
    /// <inheritdoc />
    public sealed class BatchObjectStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Moonshot.BatchObjectStatus>
    {
        /// <inheritdoc />
        public override global::Moonshot.BatchObjectStatus Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Moonshot.BatchObjectStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Moonshot.BatchObjectStatus)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Moonshot.BatchObjectStatus);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Moonshot.BatchObjectStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Moonshot.BatchObjectStatusExtensions.ToValueString(value));
        }
    }
}
