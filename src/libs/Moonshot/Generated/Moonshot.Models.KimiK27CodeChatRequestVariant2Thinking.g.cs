
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Controls thinking for the kimi-k2.7-code model, and whether to fully preserve reasoning_content across multi-turn conversations. Optional parameter. Default value is {"type": "enabled"}.<br/>
    /// Differences from kimi-k2.6:<br/>
    /// - `type` only accepts `"enabled"`. Unlike kimi-k2.6, `"disabled"` is NOT supported — passing it returns an error. Thinking is always on for this model.<br/>
    /// - `keep` only accepts the valid value `"all"`; omitting it or passing `"all"` is treated as `"all"` on the server, while any other invalid value returns an error. Preserved Thinking is therefore always enabled for this model.
    /// </summary>
    public sealed partial class KimiK27CodeChatRequestVariant2Thinking
    {
        /// <summary>
        /// Enable thinking capability. For kimi-k2.7-code, only `"enabled"` is accepted; passing `"disabled"` returns an error. This differs from kimi-k2.6, which also supports `"disabled"`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.KimiK27CodeChatRequestVariant2ThinkingTypeJsonConverter))]
        public global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingType Type { get; set; }

        /// <summary>
        /// Controls whether reasoning_content from previous turns is preserved across a multi-turn conversation, i.e. whether to enable Preserved Thinking.<br/>
        /// - For kimi-k2.7-code this parameter only accepts the valid value `"all"`: passing `"all"`, passing `null`, or omitting it all behave identically and are treated as `"all"` on the server — reasoning_content from historical turns is always preserved; passing any other invalid value returns an error. This differs from kimi-k2.6, whose default is `null` (historical thinking NOT preserved unless you explicitly set `"all"`).<br/>
        /// - Because Preserved Thinking is always on, keep the reasoning_content from every historical assistant message in messages as-is.<br/>
        /// - Note: This parameter only affects reasoning_content from historical turns; it does not change whether the model produces/outputs thinking within the current turn (that is controlled by `type`). For best practices, see [Preserved Thinking](/guide/use-kimi-k2-thinking-model#preserved-thinking).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("keep")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.KimiK27CodeChatRequestVariant2ThinkingKeepJsonConverter))]
        public global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeep? Keep { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK27CodeChatRequestVariant2Thinking" /> class.
        /// </summary>
        /// <param name="type">
        /// Enable thinking capability. For kimi-k2.7-code, only `"enabled"` is accepted; passing `"disabled"` returns an error. This differs from kimi-k2.6, which also supports `"disabled"`.
        /// </param>
        /// <param name="keep">
        /// Controls whether reasoning_content from previous turns is preserved across a multi-turn conversation, i.e. whether to enable Preserved Thinking.<br/>
        /// - For kimi-k2.7-code this parameter only accepts the valid value `"all"`: passing `"all"`, passing `null`, or omitting it all behave identically and are treated as `"all"` on the server — reasoning_content from historical turns is always preserved; passing any other invalid value returns an error. This differs from kimi-k2.6, whose default is `null` (historical thinking NOT preserved unless you explicitly set `"all"`).<br/>
        /// - Because Preserved Thinking is always on, keep the reasoning_content from every historical assistant message in messages as-is.<br/>
        /// - Note: This parameter only affects reasoning_content from historical turns; it does not change whether the model produces/outputs thinking within the current turn (that is controlled by `type`). For best practices, see [Preserved Thinking](/guide/use-kimi-k2-thinking-model#preserved-thinking).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KimiK27CodeChatRequestVariant2Thinking(
            global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingType type,
            global::Moonshot.KimiK27CodeChatRequestVariant2ThinkingKeep? keep)
        {
            this.Type = type;
            this.Keep = keep;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK27CodeChatRequestVariant2Thinking" /> class.
        /// </summary>
        public KimiK27CodeChatRequestVariant2Thinking()
        {
        }

    }
}