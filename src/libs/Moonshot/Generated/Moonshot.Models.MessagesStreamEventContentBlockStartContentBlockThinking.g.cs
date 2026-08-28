
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesStreamEventContentBlockStartContentBlockThinking
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockStartContentBlockThinkingTypeJsonConverter))]
        public global::Moonshot.MessagesStreamEventContentBlockStartContentBlockThinkingType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Thinking { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        public string? Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventContentBlockStartContentBlockThinking" /> class.
        /// </summary>
        /// <param name="thinking"></param>
        /// <param name="type"></param>
        /// <param name="signature"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesStreamEventContentBlockStartContentBlockThinking(
            string thinking,
            global::Moonshot.MessagesStreamEventContentBlockStartContentBlockThinkingType type,
            string? signature)
        {
            this.Type = type;
            this.Thinking = thinking ?? throw new global::System.ArgumentNullException(nameof(thinking));
            this.Signature = signature;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventContentBlockStartContentBlockThinking" /> class.
        /// </summary>
        public MessagesStreamEventContentBlockStartContentBlockThinking()
        {
        }

    }
}