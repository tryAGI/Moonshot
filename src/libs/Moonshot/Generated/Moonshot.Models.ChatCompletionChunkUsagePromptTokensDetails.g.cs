
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Breakdown of prompt tokens. cached_tokens, cache_write_tokens and the uncached remainder are mutually exclusive and sum to prompt_tokens
    /// </summary>
    public sealed partial class ChatCompletionChunkUsagePromptTokensDetails
    {
        /// <summary>
        /// Number of tokens served from cache
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CachedTokens { get; set; }

        /// <summary>
        /// Number of tokens written to the cache by this request. Billed according to the TTL tier at write time; see prompt_cache_options
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CacheWriteTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkUsagePromptTokensDetails" /> class.
        /// </summary>
        /// <param name="cachedTokens">
        /// Number of tokens served from cache
        /// </param>
        /// <param name="cacheWriteTokens">
        /// Number of tokens written to the cache by this request. Billed according to the TTL tier at write time; see prompt_cache_options
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionChunkUsagePromptTokensDetails(
            int cachedTokens,
            int cacheWriteTokens)
        {
            this.CachedTokens = cachedTokens;
            this.CacheWriteTokens = cacheWriteTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkUsagePromptTokensDetails" /> class.
        /// </summary>
        public ChatCompletionChunkUsagePromptTokensDetails()
        {
        }

    }
}