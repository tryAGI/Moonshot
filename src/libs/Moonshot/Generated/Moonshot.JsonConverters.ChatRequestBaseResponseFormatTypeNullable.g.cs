#nullable enable

namespace Moonshot.JsonConverters
{
    /// <inheritdoc />
    public sealed class ChatRequestBaseResponseFormatTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Moonshot.ChatRequestBaseResponseFormatType?>
    {
        /// <inheritdoc />
        public override global::Moonshot.ChatRequestBaseResponseFormatType? Read(
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
                        return global::Moonshot.ChatRequestBaseResponseFormatTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Moonshot.ChatRequestBaseResponseFormatType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Moonshot.ChatRequestBaseResponseFormatType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Moonshot.ChatRequestBaseResponseFormatType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Moonshot.ChatRequestBaseResponseFormatTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
