
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// The JSON Schema object defining the structure the output should conform to. Must conform to MFJS (Moonshot Flavored JSON Schema) specification. You can use the walle CLI tool to validate: go install github.com/moonshotai/walle/cmd/walle@latest &amp;&amp; walle -schema 'your_schema' -level strict
    /// </summary>
    public sealed partial class ChatRequestBaseResponseFormatJsonSchemaSchema
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}