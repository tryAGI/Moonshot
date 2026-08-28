
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesTool
    {
        /// <summary>
        /// Tool type, may be omitted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesToolTypeJsonConverter))]
        public global::Moonshot.MessagesToolType? Type { get; set; }

        /// <summary>
        /// Tool name. Must match the regular expression: ^[a-zA-Z_][a-zA-Z0-9-_]{0,127}$
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of what the tool does
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// JSON Schema for the tool input; the top-level `type` must be `object`. Must conform to the [MFJS (Moonshot Flavored JSON Schema) specification](https://github.com/MoonshotAI/walle/blob/main/docs/mfjs-spec.md).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input_schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object InputSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesTool" /> class.
        /// </summary>
        /// <param name="name">
        /// Tool name. Must match the regular expression: ^[a-zA-Z_][a-zA-Z0-9-_]{0,127}$
        /// </param>
        /// <param name="inputSchema">
        /// JSON Schema for the tool input; the top-level `type` must be `object`. Must conform to the [MFJS (Moonshot Flavored JSON Schema) specification](https://github.com/MoonshotAI/walle/blob/main/docs/mfjs-spec.md).
        /// </param>
        /// <param name="type">
        /// Tool type, may be omitted
        /// </param>
        /// <param name="description">
        /// Description of what the tool does
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesTool(
            string name,
            object inputSchema,
            global::Moonshot.MessagesToolType? type,
            string? description)
        {
            this.Type = type;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.InputSchema = inputSchema ?? throw new global::System.ArgumentNullException(nameof(inputSchema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesTool" /> class.
        /// </summary>
        public MessagesTool()
        {
        }

    }
}