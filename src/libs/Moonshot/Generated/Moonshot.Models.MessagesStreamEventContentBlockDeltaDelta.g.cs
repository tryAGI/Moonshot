
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesStreamEventContentBlockDeltaDelta
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockDeltaDeltaTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.MessagesStreamEventContentBlockDeltaDeltaType Type { get; set; }

        /// <summary>
        /// Text fragment for `text_delta`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Reasoning fragment for `thinking_delta`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public string? Thinking { get; set; }

        /// <summary>
        /// Signature for `signature_delta`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// Partial JSON of the tool input for `input_json_delta`; concatenate before parsing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partial_json")]
        public string? PartialJson { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventContentBlockDeltaDelta" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="text">
        /// Text fragment for `text_delta`
        /// </param>
        /// <param name="thinking">
        /// Reasoning fragment for `thinking_delta`
        /// </param>
        /// <param name="signature">
        /// Signature for `signature_delta`
        /// </param>
        /// <param name="partialJson">
        /// Partial JSON of the tool input for `input_json_delta`; concatenate before parsing
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesStreamEventContentBlockDeltaDelta(
            global::Moonshot.MessagesStreamEventContentBlockDeltaDeltaType type,
            string? text,
            string? thinking,
            string? signature,
            string? partialJson)
        {
            this.Type = type;
            this.Text = text;
            this.Thinking = thinking;
            this.Signature = signature;
            this.PartialJson = partialJson;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventContentBlockDeltaDelta" /> class.
        /// </summary>
        public MessagesStreamEventContentBlockDeltaDelta()
        {
        }

    }
}