#nullable enable

namespace Moonshot.JsonConverters
{
    /// <inheritdoc />
    public sealed class MessagesStreamEventMessageDeltaDeltaStopReasonNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Moonshot.MessagesStreamEventMessageDeltaDeltaStopReason?>
    {
        /// <inheritdoc />
        public override global::Moonshot.MessagesStreamEventMessageDeltaDeltaStopReason? Read(
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
                        return global::Moonshot.MessagesStreamEventMessageDeltaDeltaStopReasonExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Moonshot.MessagesStreamEventMessageDeltaDeltaStopReason)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Moonshot.MessagesStreamEventMessageDeltaDeltaStopReason?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Moonshot.MessagesStreamEventMessageDeltaDeltaStopReason? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Moonshot.MessagesStreamEventMessageDeltaDeltaStopReasonExtensions.ToValueString(value.Value));
            }
        }
    }
}
