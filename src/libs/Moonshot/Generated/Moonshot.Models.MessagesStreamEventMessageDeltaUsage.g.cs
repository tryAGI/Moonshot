
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesStreamEventMessageDeltaUsage
    {
        /// <summary>
        /// Input tokens (excluding cache hits)
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_details")]
        public global::Moonshot.MessagesStreamEventMessageDeltaUsageOutputTokensDetails? OutputTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventMessageDeltaUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// Input tokens (excluding cache hits)
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
        /// <param name="outputTokensDetails"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesStreamEventMessageDeltaUsage(
            int? inputTokens,
            int? outputTokens,
            int? cacheReadInputTokens,
            int? cacheCreationInputTokens,
            global::Moonshot.MessagesStreamEventMessageDeltaUsageOutputTokensDetails? outputTokensDetails)
        {
            this.InputTokens = inputTokens;
            this.OutputTokens = outputTokens;
            this.CacheReadInputTokens = cacheReadInputTokens;
            this.CacheCreationInputTokens = cacheCreationInputTokens;
            this.OutputTokensDetails = outputTokensDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventMessageDeltaUsage" /> class.
        /// </summary>
        public MessagesStreamEventMessageDeltaUsage()
        {
        }

    }
}