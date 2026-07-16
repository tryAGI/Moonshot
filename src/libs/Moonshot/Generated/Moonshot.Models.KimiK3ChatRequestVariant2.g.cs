
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KimiK3ChatRequestVariant2
    {
        /// <summary>
        /// Model ID<br/>
        /// Default Value: kimi-k3
        /// </summary>
        /// <default>global::Moonshot.KimiK3ChatRequestVariant2Model.KimiK3</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.KimiK3ChatRequestVariant2ModelJsonConverter))]
        public global::Moonshot.KimiK3ChatRequestVariant2Model Model { get; set; } = global::Moonshot.KimiK3ChatRequestVariant2Model.KimiK3;

        /// <summary>
        /// A list of Kimi K3 conversation messages. In addition to standard messages, you can insert a {"role": "system", "tools": [...]} message at any conversation position to dynamically load tools. A dynamic tool message omits content and only affects subsequent conversation turns.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("messages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Moonshot.KimiK3Message> Messages { get; set; }

        /// <summary>
        /// Kimi K3 always enables thinking with Preserved Thinking. Thinking effort only supports max.<br/>
        /// Default Value: max
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reasoning_effort")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.KimiK3ChatRequestVariant2ReasoningEffortJsonConverter))]
        public global::Moonshot.KimiK3ChatRequestVariant2ReasoningEffort? ReasoningEffort { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK3ChatRequestVariant2" /> class.
        /// </summary>
        /// <param name="messages">
        /// A list of Kimi K3 conversation messages. In addition to standard messages, you can insert a {"role": "system", "tools": [...]} message at any conversation position to dynamically load tools. A dynamic tool message omits content and only affects subsequent conversation turns.
        /// </param>
        /// <param name="reasoningEffort">
        /// Kimi K3 always enables thinking with Preserved Thinking. Thinking effort only supports max.<br/>
        /// Default Value: max
        /// </param>
        /// <param name="model">
        /// Model ID<br/>
        /// Default Value: kimi-k3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KimiK3ChatRequestVariant2(
            global::System.Collections.Generic.IList<global::Moonshot.KimiK3Message> messages,
            global::Moonshot.KimiK3ChatRequestVariant2ReasoningEffort? reasoningEffort,
            global::Moonshot.KimiK3ChatRequestVariant2Model model = global::Moonshot.KimiK3ChatRequestVariant2Model.KimiK3)
        {
            this.Model = model;
            this.Messages = messages ?? throw new global::System.ArgumentNullException(nameof(messages));
            this.ReasoningEffort = reasoningEffort;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK3ChatRequestVariant2" /> class.
        /// </summary>
        public KimiK3ChatRequestVariant2()
        {
        }

    }
}