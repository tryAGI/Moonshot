
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Image search settings. Only effective when `search_content_types` includes `image`.
    /// </summary>
    public sealed partial class ResponsesWebSearchToolImageSettings
    {
        /// <summary>
        /// Maximum number of images to return.<br/>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_results")]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Whether to generate a caption for each image.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("caption")]
        public bool? Caption { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesWebSearchToolImageSettings" /> class.
        /// </summary>
        /// <param name="maxResults">
        /// Maximum number of images to return.<br/>
        /// Default Value: 3
        /// </param>
        /// <param name="caption">
        /// Whether to generate a caption for each image.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesWebSearchToolImageSettings(
            int? maxResults,
            bool? caption)
        {
            this.MaxResults = maxResults;
            this.Caption = caption;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesWebSearchToolImageSettings" /> class.
        /// </summary>
        public ResponsesWebSearchToolImageSettings()
        {
        }

    }
}