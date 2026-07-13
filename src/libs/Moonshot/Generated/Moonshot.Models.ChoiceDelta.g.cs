
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ChoiceDelta
    {
        /// <summary>
        /// Choice index
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        public int? Index { get; set; }

        /// <summary>
        /// Incremental content object
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public global::Moonshot.ChoiceDeltaDelta? Delta { get; set; }

        /// <summary>
        /// Stop reason, only present in the final chunk
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("finish_reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ChoiceDeltaFinishReasonJsonConverter))]
        public global::Moonshot.ChoiceDeltaFinishReason? FinishReason { get; set; }

        /// <summary>
        /// Token usage statistics (optional)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        public global::Moonshot.ChoiceDeltaUsage? Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceDelta" /> class.
        /// </summary>
        /// <param name="index">
        /// Choice index
        /// </param>
        /// <param name="delta">
        /// Incremental content object
        /// </param>
        /// <param name="finishReason">
        /// Stop reason, only present in the final chunk
        /// </param>
        /// <param name="usage">
        /// Token usage statistics (optional)
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChoiceDelta(
            int? index,
            global::Moonshot.ChoiceDeltaDelta? delta,
            global::Moonshot.ChoiceDeltaFinishReason? finishReason,
            global::Moonshot.ChoiceDeltaUsage? usage)
        {
            this.Index = index;
            this.Delta = delta;
            this.FinishReason = finishReason;
            this.Usage = usage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChoiceDelta" /> class.
        /// </summary>
        public ChoiceDelta()
        {
        }

    }
}