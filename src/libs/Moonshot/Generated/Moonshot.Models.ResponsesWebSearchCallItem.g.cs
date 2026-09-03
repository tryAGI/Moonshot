
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Replays a previous web search call. Kept for history only and ignored during conversion; the search results are already carried by the assistant message that follows.
    /// </summary>
    public sealed partial class ResponsesWebSearchCallItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesWebSearchCallItemTypeJsonConverter))]
        public global::Moonshot.ResponsesWebSearchCallItemType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesWebSearchCallItemStatusJsonConverter))]
        public global::Moonshot.ResponsesWebSearchCallItemStatus? Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public global::Moonshot.ResponsesWebSearchCallItemAction? Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesWebSearchCallItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="status"></param>
        /// <param name="action"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesWebSearchCallItem(
            global::Moonshot.ResponsesWebSearchCallItemType type,
            string? id,
            global::Moonshot.ResponsesWebSearchCallItemStatus? status,
            global::Moonshot.ResponsesWebSearchCallItemAction? action)
        {
            this.Type = type;
            this.Id = id;
            this.Status = status;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesWebSearchCallItem" /> class.
        /// </summary>
        public ResponsesWebSearchCallItem()
        {
        }

    }
}