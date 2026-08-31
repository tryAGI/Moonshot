
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Constrains the output structure with a JSON Schema.
    /// </summary>
    public sealed partial class ResponsesRequestTextFormat
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesRequestTextFormatTypeJsonConverter))]
        public global::Moonshot.ResponsesRequestTextFormatType Type { get; set; }

        /// <summary>
        /// Schema name. Defaults to `output`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// JSON Schema describing the output structure.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Schema { get; set; }

        /// <summary>
        /// Whether the output must strictly conform to the schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestTextFormat" /> class.
        /// </summary>
        /// <param name="schema">
        /// JSON Schema describing the output structure.
        /// </param>
        /// <param name="type"></param>
        /// <param name="name">
        /// Schema name. Defaults to `output`.
        /// </param>
        /// <param name="strict">
        /// Whether the output must strictly conform to the schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesRequestTextFormat(
            object schema,
            global::Moonshot.ResponsesRequestTextFormatType type,
            string? name,
            bool? strict)
        {
            this.Type = type;
            this.Name = name;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestTextFormat" /> class.
        /// </summary>
        public ResponsesRequestTextFormat()
        {
        }

    }
}