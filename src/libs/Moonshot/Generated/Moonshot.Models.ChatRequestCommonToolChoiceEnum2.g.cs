
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Force a specific tool call
    /// </summary>
    public sealed partial class ChatRequestCommonToolChoiceEnum2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ChatRequestCommonToolChoiceEnumTypeJsonConverter))]
        public global::Moonshot.ChatRequestCommonToolChoiceEnumType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.ChatRequestCommonToolChoiceEnumFunction Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestCommonToolChoiceEnum2" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestCommonToolChoiceEnum2(
            global::Moonshot.ChatRequestCommonToolChoiceEnumFunction function,
            global::Moonshot.ChatRequestCommonToolChoiceEnumType type)
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestCommonToolChoiceEnum2" /> class.
        /// </summary>
        public ChatRequestCommonToolChoiceEnum2()
        {
        }

    }
}