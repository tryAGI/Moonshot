
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KimiK3ChatRequestBaseVariant2
    {
        /// <summary>
        /// A list of conversation messages.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Moonshot.KimiK3Message> Messages { get; set; }

        /// <summary>
        /// Kimi K3-series models always enable thinking with Preserved Thinking. Reasoning effort supports low, high, and max, with max as the default.<br/>
        /// Default Value: max
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.KimiK3ChatRequestBaseVariant2ReasoningEffortJsonConverter))]
        public global::Moonshot.KimiK3ChatRequestBaseVariant2ReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK3ChatRequestBaseVariant2" /> class.
        /// </summary>
        /// <param name="messages">
        /// A list of conversation messages.
        /// </param>
        /// <param name="reasoningEffort">
        /// Kimi K3-series models always enable thinking with Preserved Thinking. Reasoning effort supports low, high, and max, with max as the default.<br/>
        /// Default Value: max
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KimiK3ChatRequestBaseVariant2(
            global::System.Collections.Generic.IList<global::Moonshot.KimiK3Message> messages,
            global::Moonshot.KimiK3ChatRequestBaseVariant2ReasoningEffort? reasoningEffort)
        {
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK3ChatRequestBaseVariant2" /> class.
        /// </summary>
        public KimiK3ChatRequestBaseVariant2()
        {
        }

    }
}