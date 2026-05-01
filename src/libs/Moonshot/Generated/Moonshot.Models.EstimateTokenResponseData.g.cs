
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EstimateTokenResponseData
    {
        /// <summary>
        /// Estimated total number of tokens<br/>
        /// Example: 80
        /// </summary>
        /// <example>80</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_tokens")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateTokenResponseData" /> class.
        /// </summary>
        /// <param name="totalTokens">
        /// Estimated total number of tokens<br/>
        /// Example: 80
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstimateTokenResponseData(
            int totalTokens)
        {
            this.TotalTokens = totalTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstimateTokenResponseData" /> class.
        /// </summary>
        public EstimateTokenResponseData()
        {
        }
    }
}