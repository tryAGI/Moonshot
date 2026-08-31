
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Reasoning configuration.
    /// </summary>
    public sealed partial class ResponsesRequestReasoning
    {
        /// <summary>
        /// Reasoning depth. Higher levels reason more thoroughly, which usually also increases latency and reasoning token usage.<br/>
        /// Default Value: max
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesRequestReasoningEffortJsonConverter))]
        public global::Moonshot.ResponsesRequestReasoningEffort? Effort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestReasoning" /> class.
        /// </summary>
        /// <param name="effort">
        /// Reasoning depth. Higher levels reason more thoroughly, which usually also increases latency and reasoning token usage.<br/>
        /// Default Value: max
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesRequestReasoning(
            global::Moonshot.ResponsesRequestReasoningEffort? effort)
        {
            this.Effort = effort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestReasoning" /> class.
        /// </summary>
        public ResponsesRequestReasoning()
        {
        }

    }
}