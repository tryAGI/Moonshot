
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Result of executing a custom tool call.
    /// </summary>
    public sealed partial class ResponsesCustomToolCallOutputItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesCustomToolCallOutputItemTypeJsonConverter))]
        public global::Moonshot.ResponsesCustomToolCallOutputItemType Type { get; set; }

        /// <summary>
        /// Same call ID as the matching `custom_tool_call`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        /// Content returned by the tool.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.OneOfJsonConverter<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputContentPart>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputContentPart>> Output { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesCustomToolCallOutputItemStatusJsonConverter))]
        public global::Moonshot.ResponsesCustomToolCallOutputItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesCustomToolCallOutputItem" /> class.
        /// </summary>
        /// <param name="callId">
        /// Same call ID as the matching `custom_tool_call`.
        /// </param>
        /// <param name="output">
        /// Content returned by the tool.
        /// </param>
        /// <param name="type"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesCustomToolCallOutputItem(
            string callId,
            global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputContentPart>> output,
            global::Moonshot.ResponsesCustomToolCallOutputItemType type,
            global::Moonshot.ResponsesCustomToolCallOutputItemStatus? status)
        {
            this.Type = type;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Output = output;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesCustomToolCallOutputItem" /> class.
        /// </summary>
        public ResponsesCustomToolCallOutputItem()
        {
        }

    }
}