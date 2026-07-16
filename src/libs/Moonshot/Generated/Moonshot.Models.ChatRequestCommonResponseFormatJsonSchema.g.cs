
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Used when type is json_schema. Defines the JSON Schema that the output should conform to.
    /// </summary>
    public sealed partial class ChatRequestCommonResponseFormatJsonSchema
    {
        /// <summary>
        /// Schema name for identification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Whether to strictly constrain output according to the schema. Defaults to true. When true, the schema must conform to the MFJS specification; non-conforming schemas will return errors or warnings. When false, only guarantees the output is a valid JSON object without enforcing internal structure.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// The JSON Schema object defining the structure the output should conform to. Must conform to MFJS (Moonshot Flavored JSON Schema) specification. You can use the walle CLI tool to validate: go install github.com/moonshotai/walle/cmd/walle@latest &amp;&amp; walle -schema 'your_schema' -level strict
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
        /// Initializes a new instance of the <see cref="ChatRequestCommonResponseFormatJsonSchema" /> class.
        /// </summary>
        /// <param name="name">
        /// Schema name for identification
        /// </param>
        /// <param name="schema">
        /// The JSON Schema object defining the structure the output should conform to. Must conform to MFJS (Moonshot Flavored JSON Schema) specification. You can use the walle CLI tool to validate: go install github.com/moonshotai/walle/cmd/walle@latest &amp;&amp; walle -schema 'your_schema' -level strict
        /// </param>
        /// <param name="strict">
        /// Whether to strictly constrain output according to the schema. Defaults to true. When true, the schema must conform to the MFJS specification; non-conforming schemas will return errors or warnings. When false, only guarantees the output is a valid JSON object without enforcing internal structure.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatRequestCommonResponseFormatJsonSchema(
            string name,
            object schema,
            bool? strict)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Strict = strict;
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatRequestCommonResponseFormatJsonSchema" /> class.
        /// </summary>
        public ChatRequestCommonResponseFormatJsonSchema()
        {
        }

    }
}