#nullable enable

namespace Moonshot.JsonConverters
{
    /// <inheritdoc />
    public sealed class MoonshotV1ChatRequestVariant2ModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Moonshot.MoonshotV1ChatRequestVariant2Model?>
    {
        /// <inheritdoc />
        public override global::Moonshot.MoonshotV1ChatRequestVariant2Model? Read(
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
                        return global::Moonshot.MoonshotV1ChatRequestVariant2ModelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Moonshot.MoonshotV1ChatRequestVariant2Model)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Moonshot.MoonshotV1ChatRequestVariant2Model?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Moonshot.MoonshotV1ChatRequestVariant2Model? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Moonshot.MoonshotV1ChatRequestVariant2ModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
