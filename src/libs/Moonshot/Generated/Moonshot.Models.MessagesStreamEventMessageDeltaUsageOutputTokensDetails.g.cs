
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesStreamEventMessageDeltaUsageOutputTokensDetails
    {
        /// <summary>
        /// The portion of output tokens used for reasoning
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking_tokens")]
        public int? ThinkingTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventMessageDeltaUsageOutputTokensDetails" /> class.
        /// </summary>
        /// <param name="thinkingTokens">
        /// The portion of output tokens used for reasoning
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesStreamEventMessageDeltaUsageOutputTokensDetails(
            int? thinkingTokens)
        {
            this.ThinkingTokens = thinkingTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesStreamEventMessageDeltaUsageOutputTokensDetails" /> class.
        /// </summary>
        public MessagesStreamEventMessageDeltaUsageOutputTokensDetails()
        {
        }

    }
}