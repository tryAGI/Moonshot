
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Search scope filters.
    /// </summary>
    public sealed partial class ResponsesWebSearchToolFilters
    {
        /// <summary>
        /// Restrict the search to these domains, up to 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allowed_domains")]
        public global::System.Collections.Generic.IList<string>? AllowedDomains { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesWebSearchToolFilters" /> class.
        /// </summary>
        /// <param name="allowedDomains">
        /// Restrict the search to these domains, up to 100.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesWebSearchToolFilters(
            global::System.Collections.Generic.IList<string>? allowedDomains)
        {
            this.AllowedDomains = allowedDomains;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesWebSearchToolFilters" /> class.
        /// </summary>
        public ResponsesWebSearchToolFilters()
        {
        }

    }
}