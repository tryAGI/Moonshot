
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolsSearchProRequest
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
        /// Restrict results to the given sites. Multiple sites are OR'd, up to 5 entries; each entry must be non-empty and must not contain whitespace or parentheses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sites")]
        public global::System.Collections.Generic.IList<string>? Sites { get; set; }

        /// <summary>
        /// Time-window constraint on result dates. start and end are each normalized to the first day of their period before comparison; start must not be later than end.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time_window")]
        public global::Moonshot.ToolsSearchTimeWindow? TimeWindow { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSearchProRequest" /> class.
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
        /// <param name="sites">
        /// Restrict results to the given sites. Multiple sites are OR'd, up to 5 entries; each entry must be non-empty and must not contain whitespace or parentheses.
        /// </param>
        /// <param name="timeWindow">
        /// Time-window constraint on result dates. start and end are each normalized to the first day of their period before comparison; start must not be later than end.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsSearchProRequest(
            string textQuery,
            int? timeoutSeconds,
            int? limit,
            global::System.Collections.Generic.IList<string>? sites,
            global::Moonshot.ToolsSearchTimeWindow? timeWindow)
        {
            this.TextQuery = textQuery ?? throw new global::System.ArgumentNullException(nameof(textQuery));
            this.TimeoutSeconds = timeoutSeconds;
            this.Limit = limit;
            this.Sites = sites;
            this.TimeWindow = timeWindow;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSearchProRequest" /> class.
        /// </summary>
        public ToolsSearchProRequest()
        {
        }

    }
}