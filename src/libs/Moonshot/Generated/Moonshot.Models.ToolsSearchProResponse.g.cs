
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ToolsSearchProResponse
    {
        /// <summary>
        /// List of search results; an empty array when nothing matches.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("search_results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Moonshot.ToolsSearchProResult> SearchResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSearchProResponse" /> class.
        /// </summary>
        /// <param name="searchResults">
        /// List of search results; an empty array when nothing matches.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolsSearchProResponse(
            global::System.Collections.Generic.IList<global::Moonshot.ToolsSearchProResult> searchResults)
        {
            this.SearchResults = searchResults ?? throw new global::System.ArgumentNullException(nameof(searchResults));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolsSearchProResponse" /> class.
        /// </summary>
        public ToolsSearchProResponse()
        {
        }

    }
}