
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Token usage
    /// </summary>
    public sealed partial class MessagesResponseUsage
    {
        /// <summary>
        /// Input tokens (excluding cache hits and cache writes). Total input = input_tokens + cache_read_input_tokens + cache_creation_input_tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        /// Output tokens (including reasoning tokens)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        /// Input tokens served from cache
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read_input_tokens")]
        public int? CacheReadInputTokens { get; set; }

        /// <summary>
        /// Input tokens written to cache
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation_input_tokens")]
        public int? CacheCreationInputTokens { get; set; }

        /// <summary>
        /// Cache write breakdown by TTL tier
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_creation")]
        public global::Moonshot.MessagesResponseUsageCacheCreation? CacheCreation { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_details")]
        public global::Moonshot.MessagesResponseUsageOutputTokensDetails? OutputTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResponseUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// Input tokens (excluding cache hits and cache writes). Total input = input_tokens + cache_read_input_tokens + cache_creation_input_tokens
        /// </param>
        /// <param name="outputTokens">
        /// Output tokens (including reasoning tokens)
        /// </param>
        /// <param name="cacheReadInputTokens">
        /// Input tokens served from cache
        /// </param>
        /// <param name="cacheCreationInputTokens">
        /// Input tokens written to cache
        /// </param>
        /// <param name="cacheCreation">
        /// Cache write breakdown by TTL tier
        /// </param>
        /// <param name="outputTokensDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesResponseUsage(
            int? inputTokens,
            int? outputTokens,
            int? cacheReadInputTokens,
            int? cacheCreationInputTokens,
            global::Moonshot.MessagesResponseUsageCacheCreation? cacheCreation,
            global::Moonshot.MessagesResponseUsageOutputTokensDetails? outputTokensDetails)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.CacheCreation = cacheCreation;
            this.OutputTokensDetails = outputTokensDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesResponseUsage" /> class.
        /// </summary>
        public MessagesResponseUsage()
        {
        }

    }
}