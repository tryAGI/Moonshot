
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemTextTypeJsonConverter))]
        public global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemTextType Type { get; set; }

        /// <summary>
        /// Text content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText" /> class.
        /// </summary>
        /// <param name="text">
        /// Text content
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText(
            string text,
            global::Moonshot.MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemTextType type)
        {
            this.Type = type;
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText" /> class.
        /// </summary>
        public MessagesMessageParamContentVariant2ItemToolResultContentVariant2ItemText()
        {
        }

    }
}