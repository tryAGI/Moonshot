
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// The model's reasoning. In multi-turn conversations, pass the thinking block from the response (including `signature`) back unchanged inside the assistant message.
    /// </summary>
    public sealed partial class MessagesMessageParamContentVariant2ItemThinking
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesMessageParamContentVariant2ItemThinkingTypeJsonConverter))]
        public global::Moonshot.MessagesMessageParamContentVariant2ItemThinkingType Type { get; set; }

        /// <summary>
        /// Reasoning content
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Thinking { get; set; }

        /// <summary>
        /// Signature of the reasoning content; keep it unchanged when passing back
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentVariant2ItemThinking" /> class.
        /// </summary>
        /// <param name="thinking">
        /// Reasoning content
        /// </param>
        /// <param name="type"></param>
        /// <param name="signature">
        /// Signature of the reasoning content; keep it unchanged when passing back
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesMessageParamContentVariant2ItemThinking(
            string thinking,
            global::Moonshot.MessagesMessageParamContentVariant2ItemThinkingType type,
            string? signature)
        {
            this.Type = type;
            this.Thinking = thinking ?? throw new global::System.ArgumentNullException(nameof(thinking));
            this.Signature = signature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesMessageParamContentVariant2ItemThinking" /> class.
        /// </summary>
        public MessagesMessageParamContentVariant2ItemThinking()
        {
        }

    }
}