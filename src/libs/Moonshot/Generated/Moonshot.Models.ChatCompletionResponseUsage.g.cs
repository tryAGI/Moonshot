
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ChatCompletionResponseUsage
    {
        /// <summary>
        /// Number of tokens in the prompt
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens")]
        public int? PromptTokens { get; set; }

        /// <summary>
        /// Number of tokens in the completion
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("completion_tokens")]
        public int? CompletionTokens { get; set; }

        /// <summary>
        /// Total number of tokens used
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Number of tokens served from cache
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cached_tokens")]
        public int? CachedTokens { get; set; }

        /// <summary>
        /// Breakdown of prompt tokens. cached_tokens, cache_write_tokens and the uncached remainder are mutually exclusive and sum to prompt_tokens
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_tokens_details")]
        public global::Moonshot.ChatCompletionResponseUsagePromptTokensDetails? PromptTokensDetails { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseUsage" /> class.
        /// </summary>
        /// <param name="promptTokens">
        /// Number of tokens in the prompt
        /// </param>
        /// <param name="completionTokens">
        /// Number of tokens in the completion
        /// </param>
        /// <param name="totalTokens">
        /// Total number of tokens used
        /// </param>
        /// <param name="cachedTokens">
        /// Number of tokens served from cache
        /// </param>
        /// <param name="promptTokensDetails">
        /// Breakdown of prompt tokens. cached_tokens, cache_write_tokens and the uncached remainder are mutually exclusive and sum to prompt_tokens
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionResponseUsage(
            int? promptTokens,
            int? completionTokens,
            int? totalTokens,
            int? cachedTokens,
            global::Moonshot.ChatCompletionResponseUsagePromptTokensDetails? promptTokensDetails)
        {
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
            this.CachedTokens = cachedTokens;
            this.PromptTokensDetails = promptTokensDetails;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionResponseUsage" /> class.
        /// </summary>
        public ChatCompletionResponseUsage()
        {
        }

    }
}