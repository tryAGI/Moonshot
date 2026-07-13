
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Token usage statistics. Object in the final chunk with usage, null in ordinary chunks
    /// </summary>
    public sealed partial class ChatCompletionChunkUsage
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkUsage" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatCompletionChunkUsage(
            int? promptTokens,
            int? completionTokens,
            int? totalTokens,
            int? cachedTokens)
        {
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.TotalTokens = totalTokens;
            this.CachedTokens = cachedTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatCompletionChunkUsage" /> class.
        /// </summary>
        public ChatCompletionChunkUsage()
        {
        }

    }
}