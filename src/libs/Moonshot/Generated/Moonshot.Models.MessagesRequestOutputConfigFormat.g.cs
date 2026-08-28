
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Structured output. When set, the model outputs JSON that strictly follows the given JSON Schema.
    /// </summary>
    public sealed partial class MessagesRequestOutputConfigFormat
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesRequestOutputConfigFormatTypeJsonConverter))]
        public global::Moonshot.MessagesRequestOutputConfigFormatType Type { get; set; }

        /// <summary>
        /// The JSON Schema the output must follow
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestOutputConfigFormat" /> class.
        /// </summary>
        /// <param name="schema">
        /// The JSON Schema the output must follow
        /// </param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestOutputConfigFormat(
            object schema,
            global::Moonshot.MessagesRequestOutputConfigFormatType type)
        {
            this.Type = type;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestOutputConfigFormat" /> class.
        /// </summary>
        public MessagesRequestOutputConfigFormat()
        {
        }

    }
}