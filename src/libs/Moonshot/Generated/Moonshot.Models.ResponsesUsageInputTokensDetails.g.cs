
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesUsageInputTokensDetails
    {
        /// <summary>
        /// Number of tokens served from the context cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        public int? CachedTokens { get; set; }

        /// <summary>
        /// Number of tokens written to the context cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write_tokens")]
        public int? CacheWriteTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesUsageInputTokensDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens">
        /// Number of tokens served from the context cache.
        /// </param>
        /// <param name="cacheWriteTokens">
        /// Number of tokens written to the context cache.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesUsageInputTokensDetails(
            int? cachedTokens,
            int? cacheWriteTokens)
        {
            this.CachedTokens = cachedTokens;
            this.CacheWriteTokens = cacheWriteTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesUsageInputTokensDetails" /> class.
        /// </summary>
        public ResponsesUsageInputTokensDetails()
        {
        }

    }
}