
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesStreamEventContentBlockStart
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockStartTypeJsonConverter))]
        public global::Moonshot.MessagesStreamEventContentBlockStartType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_block")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<global::Moonshot.MessagesStreamEventContentBlockStartContentBlockThinking, global::Moonshot.MessagesStreamEventContentBlockStartContentBlockText, global::Moonshot.MessagesStreamEventContentBlockStartContentBlockToolUse>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.OneOf<global::Moonshot.MessagesStreamEventContentBlockStartContentBlockThinking, global::Moonshot.MessagesStreamEventContentBlockStartContentBlockText, global::Moonshot.MessagesStreamEventContentBlockStartContentBlockToolUse> ContentBlock { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventContentBlockStart" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="contentBlock"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesStreamEventContentBlockStart(
            int index,
            global::Moonshot.OneOf<global::Moonshot.MessagesStreamEventContentBlockStartContentBlockThinking, global::Moonshot.MessagesStreamEventContentBlockStartContentBlockText, global::Moonshot.MessagesStreamEventContentBlockStartContentBlockToolUse> contentBlock,
            global::Moonshot.MessagesStreamEventContentBlockStartType type)
        {
            this.Type = type;
            this.Index = index;
            this.ContentBlock = contentBlock;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventContentBlockStart" /> class.
        /// </summary>
        public MessagesStreamEventContentBlockStart()
        {
        }

    }
}