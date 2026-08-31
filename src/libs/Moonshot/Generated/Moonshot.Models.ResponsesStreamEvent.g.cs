
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// A single SSE event returned when `stream: true`. Each frame is `event: &lt;type&gt;` followed by `data: &lt;json&gt;`, and the remaining fields of the event body vary by `type`.
    /// </summary>
    public sealed partial class ResponsesStreamEvent
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesStreamEventTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.ResponsesStreamEventType Type { get; set; }

        /// <summary>
        /// Event sequence number, increasing monotonically from 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesStreamEvent" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="sequenceNumber">
        /// Event sequence number, increasing monotonically from 0.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesStreamEvent(
            global::Moonshot.ResponsesStreamEventType type,
            int sequenceNumber)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesStreamEvent" /> class.
        /// </summary>
        public ResponsesStreamEvent()
        {
        }

    }
}