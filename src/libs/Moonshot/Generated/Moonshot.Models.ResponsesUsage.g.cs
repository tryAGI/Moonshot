
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Token usage for this response.
    /// </summary>
    public sealed partial class ResponsesUsage
    {
        /// <summary>
        /// Number of input tokens, including cached tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens")]
        public int? InputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_tokens_details")]
        public global::Moonshot.ResponsesUsageInputTokensDetails? InputTokensDetails { get; set; }

        /// <summary>
        /// Number of output tokens, including reasoning tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens")]
        public int? OutputTokens { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_tokens_details")]
        public global::Moonshot.ResponsesUsageOutputTokensDetails? OutputTokensDetails { get; set; }

        /// <summary>
        /// Total number of tokens.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        public int? TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesUsage" /> class.
        /// </summary>
        /// <param name="inputTokens">
        /// Number of input tokens, including cached tokens.
        /// </param>
        /// <param name="inputTokensDetails"></param>
        /// <param name="outputTokens">
        /// Number of output tokens, including reasoning tokens.
        /// </param>
        /// <param name="outputTokensDetails"></param>
        /// <param name="totalTokens">
        /// Total number of tokens.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesUsage(
            int? inputTokens,
            global::Moonshot.ResponsesUsageInputTokensDetails? inputTokensDetails,
            int? outputTokens,
            global::Moonshot.ResponsesUsageOutputTokensDetails? outputTokensDetails,
            int? totalTokens)
        {
            this.InputTokens = inputTokens;
            this.InputTokensDetails = inputTokensDetails;
            this.OutputTokens = outputTokens;
            this.OutputTokensDetails = outputTokensDetails;
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesUsage" /> class.
        /// </summary>
        public ResponsesUsage()
        {
        }

    }
}