
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class KimiK25ChatRequestVariant2
    {
        /// <summary>
        /// Model ID<br/>
        /// Default Value: kimi-k2.5
        /// </summary>
        /// <default>global::Moonshot.KimiK25ChatRequestVariant2Model.KimiK25</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.KimiK25ChatRequestVariant2ModelJsonConverter))]
        public global::Moonshot.KimiK25ChatRequestVariant2Model Model { get; set; } = global::Moonshot.KimiK25ChatRequestVariant2Model.KimiK25;

        /// <summary>
        /// Controls whether thinking is enabled for the model. Optional parameter. Default value is {"type": "enabled"}.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("thinking")]
        public global::Moonshot.KimiK25ChatRequestVariant2Thinking? Thinking { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK25ChatRequestVariant2" /> class.
        /// </summary>
        /// <param name="thinking">
        /// Controls whether thinking is enabled for the model. Optional parameter. Default value is {"type": "enabled"}.
        /// </param>
        /// <param name="model">
        /// Model ID<br/>
        /// Default Value: kimi-k2.5
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KimiK25ChatRequestVariant2(
            global::Moonshot.KimiK25ChatRequestVariant2Thinking? thinking,
            global::Moonshot.KimiK25ChatRequestVariant2Model model = global::Moonshot.KimiK25ChatRequestVariant2Model.KimiK25)
        {
            this.Model = model;
            this.Thinking = thinking;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK25ChatRequestVariant2" /> class.
        /// </summary>
        public KimiK25ChatRequestVariant2()
        {
        }

    }
}