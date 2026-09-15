
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolsSearchRequest
    {
        /// <summary>
        /// Search query text. Must not be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TextQuery { get; set; }

        /// <summary>
        /// Search timeout in seconds, from 1 to 60. If omitted, no per-request timeout is applied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeout_seconds")]
        public int? TimeoutSeconds { get; set; }

        /// <summary>
        /// Maximum number of results to return, from 1 to 20. Defaults to 5.<br/>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Whether to return full page content in each result's `text` field. Defaults to false.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_content")]
        public bool? IncludeContent { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSearchRequest" /> class.
        /// </summary>
        /// <param name="textQuery">
        /// Search query text. Must not be empty.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Search timeout in seconds, from 1 to 60. If omitted, no per-request timeout is applied.
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return, from 1 to 20. Defaults to 5.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="includeContent">
        /// Whether to return full page content in each result's `text` field. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsSearchRequest(
            string textQuery,
            int? timeoutSeconds,
            int? limit,
            bool? includeContent)
        {
            this.TextQuery = textQuery ?? throw new global::System.ArgumentNullException(nameof(textQuery));
            this.TimeoutSeconds = timeoutSeconds;
            this.Limit = limit;
            this.IncludeContent = includeContent;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSearchRequest" /> class.
        /// </summary>
        public ToolsSearchRequest()
        {
        }

    }
}