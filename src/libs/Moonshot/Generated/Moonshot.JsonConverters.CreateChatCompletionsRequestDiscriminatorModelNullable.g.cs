#nullable enable

namespace Moonshot.JsonConverters
{
    /// <inheritdoc />
    public sealed class CreateChatCompletionsRequestDiscriminatorModelNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel?>
    {
        /// <inheritdoc />
        public override global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel? Read(
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
                        return global::Moonshot.CreateChatCompletionsRequestDiscriminatorModelExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Moonshot.CreateChatCompletionsRequestDiscriminatorModel? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Moonshot.CreateChatCompletionsRequestDiscriminatorModelExtensions.ToValueString(value.Value));
            }
        }
    }
}
