
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesStreamEventContentBlockDelta
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockDeltaTypeJsonConverter))]
        public global::Moonshot.MessagesStreamEventContentBlockDeltaType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.MessagesStreamEventContentBlockDeltaDelta Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventContentBlockDelta" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="delta"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesStreamEventContentBlockDelta(
            int index,
            global::Moonshot.MessagesStreamEventContentBlockDeltaDelta delta,
            global::Moonshot.MessagesStreamEventContentBlockDeltaType type)
        {
            this.Type = type;
            this.Index = index;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventContentBlockDelta" /> class.
        /// </summary>
        public MessagesStreamEventContentBlockDelta()
        {
        }

    }
}