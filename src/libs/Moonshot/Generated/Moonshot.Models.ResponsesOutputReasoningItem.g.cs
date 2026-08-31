
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Reasoning content produced by the model.
    /// </summary>
    public sealed partial class ResponsesOutputReasoningItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesOutputReasoningItemTypeJsonConverter))]
        public global::Moonshot.ResponsesOutputReasoningItemType? Type { get; set; }

        /// <summary>
        /// Example: rs_68f0c1c2d3e4f5a6b7c8d9e0
        /// </summary>
        /// <example>rs_68f0c1c2d3e4f5a6b7c8d9e0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// The reasoning content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputReasoningItemSummaryItem>? Summary { get; set; }

        /// <summary>
        /// Always `null`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        public string? EncryptedContent { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesOutputReasoningItemStatusJsonConverter))]
        public global::Moonshot.ResponsesOutputReasoningItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesOutputReasoningItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id">
        /// Example: rs_68f0c1c2d3e4f5a6b7c8d9e0
        /// </param>
        /// <param name="summary">
        /// The reasoning content.
        /// </param>
        /// <param name="encryptedContent">
        /// Always `null`.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesOutputReasoningItem(
            global::Moonshot.ResponsesOutputReasoningItemType? type,
            string? id,
            global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputReasoningItemSummaryItem>? summary,
            string? encryptedContent,
            global::Moonshot.ResponsesOutputReasoningItemStatus? status)
        {
            this.Type = type;
            this.Id = id;
            this.Summary = summary;
            this.EncryptedContent = encryptedContent;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesOutputReasoningItem" /> class.
        /// </summary>
        public ResponsesOutputReasoningItem()
        {
        }

    }
}