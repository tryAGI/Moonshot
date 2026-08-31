
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Replays reasoning content from a previous turn. `content` takes precedence over `summary`.
    /// </summary>
    public sealed partial class ResponsesReasoningItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesReasoningItemTypeJsonConverter))]
        public global::Moonshot.ResponsesReasoningItemType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesReasoningItemSummaryItem>? Summary { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesReasoningItemContentItem>? Content { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesReasoningItemStatusJsonConverter))]
        public global::Moonshot.ResponsesReasoningItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesReasoningItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="summary"></param>
        /// <param name="content"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesReasoningItem(
            global::Moonshot.ResponsesReasoningItemType type,
            string? id,
            global::System.Collections.Generic.IList<global::Moonshot.ResponsesReasoningItemSummaryItem>? summary,
            global::System.Collections.Generic.IList<global::Moonshot.ResponsesReasoningItemContentItem>? content,
            global::Moonshot.ResponsesReasoningItemStatus? status)
        {
            this.Type = type;
            this.Id = id;
            this.Summary = summary;
            this.Content = content;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesReasoningItem" /> class.
        /// </summary>
        public ResponsesReasoningItem()
        {
        }

    }
}