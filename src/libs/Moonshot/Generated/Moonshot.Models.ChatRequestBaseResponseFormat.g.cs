
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Controls the model output format. Default is {"type": "text"} for plain text output. Set to {"type": "json_object"} to enable JSON mode, ensuring output is a valid JSON object (you must guide the model to output JSON in the prompt). Set to {"type": "json_schema"} to enable Structured Output, constraining output to match a specified JSON Schema (recommended, requires the json_schema field). If you encounter schema validation issues, please submit feedback at walle GitHub Issues (https://github.com/MoonshotAI/walle/issues).
    /// </summary>
    public sealed partial class ChatRequestBaseResponseFormat
    {
        /// <summary>
        /// Output format type. text: default, plain text output; json_object: ensures output is a valid JSON object; json_schema: constrains output to match a specified JSON Schema (recommended, requires the json_schema field)
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ChatRequestBaseResponseFormatTypeJsonConverter))]
        public global::Moonshot.ChatRequestBaseResponseFormatType? Type { get; set; }

        /// <summary>
        /// Used when type is json_schema. Defines the JSON Schema that the output should conform to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("json_schema")]
        public global::Moonshot.ChatRequestBaseResponseFormatJsonSchema? JsonSchema { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestBaseResponseFormat" /> class.
        /// </summary>
        /// <param name="type">
        /// Output format type. text: default, plain text output; json_object: ensures output is a valid JSON object; json_schema: constrains output to match a specified JSON Schema (recommended, requires the json_schema field)
        /// </param>
        /// <param name="jsonSchema">
        /// Used when type is json_schema. Defines the JSON Schema that the output should conform to.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestBaseResponseFormat(
            global::Moonshot.ChatRequestBaseResponseFormatType? type,
            global::Moonshot.ChatRequestBaseResponseFormatJsonSchema? jsonSchema)
        {
            this.Type = type;
            this.JsonSchema = jsonSchema;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestBaseResponseFormat" /> class.
        /// </summary>
        public ChatRequestBaseResponseFormat()
        {
        }
    }
}