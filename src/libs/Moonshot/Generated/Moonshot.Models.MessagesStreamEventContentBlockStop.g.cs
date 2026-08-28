
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesStreamEventContentBlockStop
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesStreamEventContentBlockStopTypeJsonConverter))]
        public global::Moonshot.MessagesStreamEventContentBlockStopType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventContentBlockStop" /> class.
        /// </summary>
        /// <param name="index"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesStreamEventContentBlockStop(
            int index,
            global::Moonshot.MessagesStreamEventContentBlockStopType type)
        {
            this.Type = type;
            this.Index = index;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventContentBlockStop" /> class.
        /// </summary>
        public MessagesStreamEventContentBlockStop()
        {
        }

    }
}