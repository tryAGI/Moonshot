
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Controls whether thinking is enabled for the kimi-k2.6 model, and whether to fully preserve reasoning_content across multi-turn conversations. Optional parameter. Default value is {"type": "enabled"}.
    /// </summary>
    public sealed partial class KimiK26ChatRequestVariant2Thinking
    {
        /// <summary>
        /// Enable or disable thinking capability
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.KimiK26ChatRequestVariant2ThinkingTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.KimiK26ChatRequestVariant2ThinkingType Type { get; set; }

        /// <summary>
        /// Controls whether reasoning_content from previous turns is preserved across a multi-turn conversation, i.e. whether to enable Preserved Thinking. Defaults to `null`, meaning historical thinking is NOT preserved.<br/>
        /// - `null` (default) or omitted: The server ignores reasoning_content from historical turns.<br/>
        /// - `"all"`: Preserves reasoning_content from historical turns and provides it to the model as part of the context, enabling Preserved Thinking. When using this, keep the reasoning_content from every historical assistant message in messages as-is. Recommended to use together with `type: "enabled"`.<br/>
        /// - Note: This parameter only affects reasoning_content from historical turns; it does not change whether the model produces/outputs thinking within the current turn (that is controlled by `type`). For best practices, see [Preserved Thinking](/guide/use-kimi-k2-thinking-model#preserved-thinking).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.KimiK26ChatRequestVariant2ThinkingKeepJsonConverter))]
        public global::Moonshot.KimiK26ChatRequestVariant2ThinkingKeep? Keep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK26ChatRequestVariant2Thinking" /> class.
        /// </summary>
        /// <param name="type">
        /// Enable or disable thinking capability
        /// </param>
        /// <param name="keep">
        /// Controls whether reasoning_content from previous turns is preserved across a multi-turn conversation, i.e. whether to enable Preserved Thinking. Defaults to `null`, meaning historical thinking is NOT preserved.<br/>
        /// - `null` (default) or omitted: The server ignores reasoning_content from historical turns.<br/>
        /// - `"all"`: Preserves reasoning_content from historical turns and provides it to the model as part of the context, enabling Preserved Thinking. When using this, keep the reasoning_content from every historical assistant message in messages as-is. Recommended to use together with `type: "enabled"`.<br/>
        /// - Note: This parameter only affects reasoning_content from historical turns; it does not change whether the model produces/outputs thinking within the current turn (that is controlled by `type`). For best practices, see [Preserved Thinking](/guide/use-kimi-k2-thinking-model#preserved-thinking).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KimiK26ChatRequestVariant2Thinking(
            global::Moonshot.KimiK26ChatRequestVariant2ThinkingType type,
            global::Moonshot.KimiK26ChatRequestVariant2ThinkingKeep? keep)
        {
            this.Type = type;
            this.Keep = keep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK26ChatRequestVariant2Thinking" /> class.
        /// </summary>
        public KimiK26ChatRequestVariant2Thinking()
        {
        }
    }
}