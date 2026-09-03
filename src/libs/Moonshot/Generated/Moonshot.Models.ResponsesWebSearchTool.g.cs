
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// A web search tool executed on the server side. When present, the server first decides from the input whether a search is needed; if so, it runs the search, injects the results into the model context, and returns a `web_search_call` item in the output. At most one `web_search` tool is allowed per request. `search_context_size`, `blocked_domains`, and `filters.blocked_domains` are not supported and return `invalid_request_error`; `user_location`, `external_web_access`, and `indexed_web_access` are ignored.
    /// </summary>
    public sealed partial class ResponsesWebSearchTool
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesWebSearchToolTypeJsonConverter))]
        public global::Moonshot.ResponsesWebSearchToolType Type { get; set; }

        /// <summary>
        /// Search scope filters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filters")]
        public global::Moonshot.ResponsesWebSearchToolFilters? Filters { get; set; }

        /// <summary>
        /// Result types to search for. Defaults to `text` only. Including `image` additionally runs an image search.<br/>
        /// Default Value: [text]
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_content_types")]
        public global::System.Collections.Generic.IList<global::Moonshot.ResponsesWebSearchToolSearchContentType>? SearchContentTypes { get; set; }

        /// <summary>
        /// Image search settings. Only effective when `search_content_types` includes `image`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image_settings")]
        public global::Moonshot.ResponsesWebSearchToolImageSettings? ImageSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesWebSearchTool" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="filters">
        /// Search scope filters.
        /// </param>
        /// <param name="searchContentTypes">
        /// Result types to search for. Defaults to `text` only. Including `image` additionally runs an image search.<br/>
        /// Default Value: [text]
        /// </param>
        /// <param name="imageSettings">
        /// Image search settings. Only effective when `search_content_types` includes `image`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesWebSearchTool(
            global::Moonshot.ResponsesWebSearchToolType type,
            global::Moonshot.ResponsesWebSearchToolFilters? filters,
            global::System.Collections.Generic.IList<global::Moonshot.ResponsesWebSearchToolSearchContentType>? searchContentTypes,
            global::Moonshot.ResponsesWebSearchToolImageSettings? imageSettings)
        {
            this.Type = type;
            this.Filters = filters;
            this.SearchContentTypes = searchContentTypes;
            this.ImageSettings = imageSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesWebSearchTool" /> class.
        /// </summary>
        public ResponsesWebSearchTool()
        {
        }

    }
}