
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// A web search call executed on the server side. Returned only when the request includes the `web_search` tool and the server decides a search is needed. It appears first in the output array.
    /// </summary>
    public sealed partial class ResponsesOutputWebSearchCallItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesOutputWebSearchCallItemTypeJsonConverter))]
        public global::Moonshot.ResponsesOutputWebSearchCallItemType? Type { get; set; }

        /// <summary>
        /// Example: ws_68f0c1c2d3e4f5a6b7c8d9e0
        /// </summary>
        /// <example>ws_68f0c1c2d3e4f5a6b7c8d9e0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesOutputWebSearchCallItemStatusJsonConverter))]
        public global::Moonshot.ResponsesOutputWebSearchCallItemStatus? Status { get; set; }

        /// <summary>
        /// The action performed by this search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        public global::Moonshot.ResponsesOutputWebSearchCallItemAction? Action { get; set; }

        /// <summary>
        /// Image search results. Returned only when `include` contains `web_search_call.results` and `search_content_types` includes `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputWebSearchCallItemResult>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesOutputWebSearchCallItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id">
        /// Example: ws_68f0c1c2d3e4f5a6b7c8d9e0
        /// </param>
        /// <param name="status"></param>
        /// <param name="action">
        /// The action performed by this search.
        /// </param>
        /// <param name="results">
        /// Image search results. Returned only when `include` contains `web_search_call.results` and `search_content_types` includes `image`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesOutputWebSearchCallItem(
            global::Moonshot.ResponsesOutputWebSearchCallItemType? type,
            string? id,
            global::Moonshot.ResponsesOutputWebSearchCallItemStatus? status,
            global::Moonshot.ResponsesOutputWebSearchCallItemAction? action,
            global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputWebSearchCallItemResult>? results)
        {
            this.Type = type;
            this.Id = id;
            this.Status = status;
            this.Action = action;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesOutputWebSearchCallItem" /> class.
        /// </summary>
        public ResponsesOutputWebSearchCallItem()
        {
        }

    }
}