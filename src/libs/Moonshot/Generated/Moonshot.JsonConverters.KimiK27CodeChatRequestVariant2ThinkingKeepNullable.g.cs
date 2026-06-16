#nullable enable

namespace Moonshot.JsonConverters
{
    /// <inheritdoc />
    public sealed class KimiK27CodeChatRequestVariant2ThinkingKeepNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeep?>
    {
        /// <inheritdoc />
        public override global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeep? Read(
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
                        return global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeepExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeep)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeep?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeep? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeepExtensions.ToValueString(value.Value));
            }
        }
    }
}
