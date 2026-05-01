#nullable enable

namespace Moonshot.JsonConverters
{
    /// <inheritdoc />
    public sealed class ToolDefinitionTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Moonshot.ToolDefinitionType?>
    {
        /// <inheritdoc />
        public override global::Moonshot.ToolDefinitionType? Read(
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
                        return global::Moonshot.ToolDefinitionTypeExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Moonshot.ToolDefinitionType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Moonshot.ToolDefinitionType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Moonshot.ToolDefinitionType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Moonshot.ToolDefinitionTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}
