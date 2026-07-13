
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Force a specific tool call
    /// </summary>
    public sealed partial class ChatRequestBaseToolChoiceEnum2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ChatRequestBaseToolChoiceEnumTypeJsonConverter))]
        public global::Moonshot.ChatRequestBaseToolChoiceEnumType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("function")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.ChatRequestBaseToolChoiceEnumFunction Function { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestBaseToolChoiceEnum2" /> class.
        /// </summary>
        /// <param name="function"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestBaseToolChoiceEnum2(
            global::Moonshot.ChatRequestBaseToolChoiceEnumFunction function,
            global::Moonshot.ChatRequestBaseToolChoiceEnumType type)
        {
            this.Type = type;
            this.Function = function ?? throw new global::System.ArgumentNullException(nameof(function));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestBaseToolChoiceEnum2" /> class.
        /// </summary>
        public ChatRequestBaseToolChoiceEnum2()
        {
        }

    }
}