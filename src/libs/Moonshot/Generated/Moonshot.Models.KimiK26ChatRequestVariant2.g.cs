
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KimiK26ChatRequestVariant2
    {
        /// <summary>
        /// Model ID<br/>
        /// Default Value: kimi-k2.6
        /// </summary>
        /// <default>global::Moonshot.KimiK26ChatRequestVariant2Model.KimiK26</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.KimiK26ChatRequestVariant2ModelJsonConverter))]
        public global::Moonshot.KimiK26ChatRequestVariant2Model Model { get; set; } = global::Moonshot.KimiK26ChatRequestVariant2Model.KimiK26;

        /// <summary>
        /// Controls whether thinking is enabled for the kimi-k2.6 model, and whether to fully preserve reasoning_content across multi-turn conversations. Optional parameter. Default value is {"type": "enabled"}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public global::Moonshot.KimiK26ChatRequestVariant2Thinking? Thinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK26ChatRequestVariant2" /> class.
        /// </summary>
        /// <param name="thinking">
        /// Controls whether thinking is enabled for the kimi-k2.6 model, and whether to fully preserve reasoning_content across multi-turn conversations. Optional parameter. Default value is {"type": "enabled"}.
        /// </param>
        /// <param name="model">
        /// Model ID<br/>
        /// Default Value: kimi-k2.6
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KimiK26ChatRequestVariant2(
            global::Moonshot.KimiK26ChatRequestVariant2Thinking? thinking,
            global::Moonshot.KimiK26ChatRequestVariant2Model model = global::Moonshot.KimiK26ChatRequestVariant2Model.KimiK26)
        {
            this.Model = model;
            this.Thinking = thinking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK26ChatRequestVariant2" /> class.
        /// </summary>
        public KimiK26ChatRequestVariant2()
        {
        }

    }
}