
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK3ChatRequestVariant2" /> class.
        /// </summary>
        /// <param name="model">
        /// Model ID<br/>
        /// Default Value: kimi-k3
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KimiK3ChatRequestVariant2(
            global::Moonshot.KimiK3ChatRequestVariant2Model model = global::Moonshot.KimiK3ChatRequestVariant2Model.KimiK3)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK3ChatRequestVariant2" /> class.
        /// </summary>
        public KimiK3ChatRequestVariant2()
        {
        }

    }
}