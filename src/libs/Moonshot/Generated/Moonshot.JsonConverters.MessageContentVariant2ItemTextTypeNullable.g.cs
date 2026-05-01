#nullable enable

namespace Moonshot.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessageContentVariant2ItemTextTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Moonshot.MessageContentVariant2ItemTextType?>
    {
        /// <inheritdoc />
        public override global::Moonshot.MessageContentVariant2ItemTextType? Read(
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
                        return global::Moonshot.MessageContentVariant2ItemTextTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Moonshot.MessageContentVariant2ItemTextType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Moonshot.MessageContentVariant2ItemTextType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Moonshot.MessageContentVariant2ItemTextType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Moonshot.MessageContentVariant2ItemTextTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
