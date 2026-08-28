
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesStreamEventMessageDelta
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesStreamEventMessageDeltaTypeJsonConverter))]
        public global::Moonshot.MessagesStreamEventMessageDeltaType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.MessagesStreamEventMessageDeltaDelta Delta { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Moonshot.MessagesStreamEventMessageDeltaUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventMessageDelta" /> class.
        /// </summary>
        /// <param name="delta"></param>
        /// <param name="type"></param>
        /// <param name="usage"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesStreamEventMessageDelta(
            global::Moonshot.MessagesStreamEventMessageDeltaDelta delta,
            global::Moonshot.MessagesStreamEventMessageDeltaType type,
            global::Moonshot.MessagesStreamEventMessageDeltaUsage? usage)
        {
            this.Type = type;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventMessageDelta" /> class.
        /// </summary>
        public MessagesStreamEventMessageDelta()
        {
        }

    }
}