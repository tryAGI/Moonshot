
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class KimiK31ProChatRequestVariant2
    {
        /// <summary>
        /// Model ID<br/>
        /// Default Value: kimi-k3.1-pro
        /// </summary>
        /// <default>global::Moonshot.KimiK31ProChatRequestVariant2Model.KimiK31Pro</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.KimiK31ProChatRequestVariant2ModelJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.KimiK31ProChatRequestVariant2Model Model { get; set; } = global::Moonshot.KimiK31ProChatRequestVariant2Model.KimiK31Pro;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK31ProChatRequestVariant2" /> class.
        /// </summary>
        /// <param name="model">
        /// Model ID<br/>
        /// Default Value: kimi-k3.1-pro
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KimiK31ProChatRequestVariant2(
            global::Moonshot.KimiK31ProChatRequestVariant2Model model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK31ProChatRequestVariant2" /> class.
        /// </summary>
        public KimiK31ProChatRequestVariant2()
        {
        }

    }
}