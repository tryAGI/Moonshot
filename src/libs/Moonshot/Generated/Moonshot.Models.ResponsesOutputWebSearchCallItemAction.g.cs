
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// The action performed by this search.
    /// </summary>
    public sealed partial class ResponsesOutputWebSearchCallItemAction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesOutputWebSearchCallItemActionTypeJsonConverter))]
        public global::Moonshot.ResponsesOutputWebSearchCallItemActionType? Type { get; set; }

        /// <summary>
        /// The search query actually used.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Web pages the search hit. Returned only when `include` contains `web_search_call.action.sources`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sources")]
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputWebSearchCallItemActionSource>? Sources { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesOutputWebSearchCallItemAction" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="query">
        /// The search query actually used.
        /// </param>
        /// <param name="sources">
        /// Web pages the search hit. Returned only when `include` contains `web_search_call.action.sources`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesOutputWebSearchCallItemAction(
            global::Moonshot.ResponsesOutputWebSearchCallItemActionType? type,
            string? query,
            global::System.Collections.Generic.IList<global::Moonshot.ResponsesOutputWebSearchCallItemActionSource>? sources)
        {
            this.Type = type;
            this.Query = query;
            this.Sources = sources;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesOutputWebSearchCallItemAction" /> class.
        /// </summary>
        public ResponsesOutputWebSearchCallItemAction()
        {
        }

    }
}