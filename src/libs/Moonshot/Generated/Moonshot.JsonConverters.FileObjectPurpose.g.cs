#nullable enable

namespace Moonshot.JsonConverters
{
    /// <inheritdoc />
    public sealed class FileObjectPurposeJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Moonshot.FileObjectPurpose>
    {
        /// <inheritdoc />
        public override global::Moonshot.FileObjectPurpose Read(
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
                        return global::Moonshot.FileObjectPurposeExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Moonshot.FileObjectPurpose)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Moonshot.FileObjectPurpose);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Moonshot.FileObjectPurpose value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Moonshot.FileObjectPurposeExtensions.ToValueString(value));
        }
    }
}
