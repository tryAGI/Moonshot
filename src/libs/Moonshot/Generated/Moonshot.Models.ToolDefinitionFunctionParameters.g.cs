
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Function parameters as JSON Schema. Must conform to the [MFJS (Moonshot Flavored JSON Schema) specification](https://github.com/MoonshotAI/walle/blob/main/docs/mfjs-spec.md).
    /// </summary>
    public sealed partial class ToolDefinitionFunctionParameters
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}