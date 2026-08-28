
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Controls whether the model calls tools. `auto` (default): the model decides; `any`: force a call to any tool; `none`: do not call tools.
    /// </summary>
    public sealed partial class MessagesToolChoice
    {
        /// <summary>
        /// Default Value: auto
        /// </summary>
        /// <default>global::Moonshot.MessagesToolChoiceType.Auto</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesToolChoiceTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.MessagesToolChoiceType Type { get; set; } = global::Moonshot.MessagesToolChoiceType.Auto;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesToolChoice" /> class.
        /// </summary>
        /// <param name="type">
        /// Default Value: auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesToolChoice(
            global::Moonshot.MessagesToolChoiceType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesToolChoice" /> class.
        /// </summary>
        public MessagesToolChoice()
        {
        }

    }
}