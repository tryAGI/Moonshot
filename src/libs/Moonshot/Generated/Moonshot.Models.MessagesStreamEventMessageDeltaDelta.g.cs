
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesStreamEventMessageDeltaDelta
    {
        /// <summary>
        /// Stop reason. `end_turn`: finished naturally (including a `stop_sequences` match); `max_tokens`: reached the max_tokens limit; `tool_use`: the model issued a tool call; `refusal`: content safety review was triggered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesStreamEventMessageDeltaDeltaStopReasonJsonConverter))]
        public global::Moonshot.MessagesStreamEventMessageDeltaDeltaStopReason? StopReason { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stop_sequence")]
        public string? StopSequence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventMessageDeltaDelta" /> class.
        /// </summary>
        /// <param name="stopReason">
        /// Stop reason. `end_turn`: finished naturally (including a `stop_sequences` match); `max_tokens`: reached the max_tokens limit; `tool_use`: the model issued a tool call; `refusal`: content safety review was triggered.
        /// </param>
        /// <param name="stopSequence"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesStreamEventMessageDeltaDelta(
            global::Moonshot.MessagesStreamEventMessageDeltaDeltaStopReason? stopReason,
            string? stopSequence)
        {
            this.StopReason = stopReason;
            this.StopSequence = stopSequence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventMessageDeltaDelta" /> class.
        /// </summary>
        public MessagesStreamEventMessageDeltaDelta()
        {
        }

    }
}