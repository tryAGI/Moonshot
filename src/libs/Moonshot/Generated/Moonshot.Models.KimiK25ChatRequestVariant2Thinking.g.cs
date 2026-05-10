
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Controls whether thinking is enabled for the model. Optional parameter. Default value is {"type": "enabled"}.
    /// </summary>
    public sealed partial class KimiK25ChatRequestVariant2Thinking
    {
        /// <summary>
        /// Enable or disable thinking capability
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.KimiK25ChatRequestVariant2ThinkingTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.KimiK25ChatRequestVariant2ThinkingType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK25ChatRequestVariant2Thinking" /> class.
        /// </summary>
        /// <param name="type">
        /// Enable or disable thinking capability
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public KimiK25ChatRequestVariant2Thinking(
            global::Moonshot.KimiK25ChatRequestVariant2ThinkingType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="KimiK25ChatRequestVariant2Thinking" /> class.
        /// </summary>
        public KimiK25ChatRequestVariant2Thinking()
        {
        }

    }
}