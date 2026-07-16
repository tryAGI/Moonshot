
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Options for streaming responses
    /// </summary>
    public sealed partial class ChatRequestCommonStreamOptions
    {
        /// <summary>
        /// If set, an additional chunk will be streamed before the data: [DONE] message. The usage field on this chunk shows the token usage statistics for the entire request, and the choices field will always be an empty array. All other chunks will also include a usage field, but with a null value. NOTE: If the stream is interrupted, you may not receive the final usage chunk which contains the total token usage for the request<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_usage")]
        public bool? IncludeUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestCommonStreamOptions" /> class.
        /// </summary>
        /// <param name="includeUsage">
        /// If set, an additional chunk will be streamed before the data: [DONE] message. The usage field on this chunk shows the token usage statistics for the entire request, and the choices field will always be an empty array. All other chunks will also include a usage field, but with a null value. NOTE: If the stream is interrupted, you may not receive the final usage chunk which contains the total token usage for the request<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestCommonStreamOptions(
            bool? includeUsage)
        {
            this.IncludeUsage = includeUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestCommonStreamOptions" /> class.
        /// </summary>
        public ChatRequestCommonStreamOptions()
        {
        }

    }
}