#nullable enable

namespace Moonshot.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType?>
    {
        /// <inheritdoc />
        public override global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType? Read(
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
                        return global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemImageSourceTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
