
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KimiK27CodeChatRequestVariant2
    {
        /// <summary>
        /// Model ID<br/>
        /// Default Value: kimi-k2.7-code
        /// </summary>
        /// <default>global::Moonshot.KimiK27CodeChatRequestVariant2Model.KimiK27Code</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.KimiK27CodeChatRequestVariant2ModelJsonConverter))]
        public global::Moonshot.KimiK27CodeChatRequestVariant2Model Model { get; set; } = global::Moonshot.KimiK27CodeChatRequestVariant2Model.KimiK27Code;

        /// <summary>
        /// Controls thinking for the kimi-k2.7-code model, and whether to fully preserve reasoning_content across multi-turn conversations. Optional parameter. Default value is {"type": "enabled", "keep": "all"}.<br/>
        /// Differences from kimi-k2.6:<br/>
        /// - `type` only accepts `"enabled"`. Unlike kimi-k2.6, `"disabled"` is NOT supported — passing it returns an error. Thinking is always on for this model.<br/>
        /// - `keep` only accepts the valid value `"all"`; omitting it or passing `"all"` is treated as `"all"` on the server, while any other invalid value returns an error. Preserved Thinking is therefore always enabled for this model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public global::Moonshot.KimiK27CodeChatRequestVariant2Thinking? Thinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK27CodeChatRequestVariant2" /> class.
        /// </summary>
        /// <param name="thinking">
        /// Controls thinking for the kimi-k2.7-code model, and whether to fully preserve reasoning_content across multi-turn conversations. Optional parameter. Default value is {"type": "enabled", "keep": "all"}.<br/>
        /// Differences from kimi-k2.6:<br/>
        /// - `type` only accepts `"enabled"`. Unlike kimi-k2.6, `"disabled"` is NOT supported — passing it returns an error. Thinking is always on for this model.<br/>
        /// - `keep` only accepts the valid value `"all"`; omitting it or passing `"all"` is treated as `"all"` on the server, while any other invalid value returns an error. Preserved Thinking is therefore always enabled for this model.
        /// </param>
        /// <param name="model">
        /// Model ID<br/>
        /// Default Value: kimi-k2.7-code
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KimiK27CodeChatRequestVariant2(
            global::Moonshot.KimiK27CodeChatRequestVariant2Thinking? thinking,
            global::Moonshot.KimiK27CodeChatRequestVariant2Model model = global::Moonshot.KimiK27CodeChatRequestVariant2Model.KimiK27Code)
        {
            this.Model = model;
            this.Thinking = thinking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK27CodeChatRequestVariant2" /> class.
        /// </summary>
        public KimiK27CodeChatRequestVariant2()
        {
        }

    }
}