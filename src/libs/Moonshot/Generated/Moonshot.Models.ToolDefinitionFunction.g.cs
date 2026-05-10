
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ToolDefinitionFunction
    {
        /// <summary>
        /// Function name. Must follow the regex: ^[a-zA-Z_][a-zA-Z0-9-_]{2,63}$
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Description of what the function does
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Function parameters as JSON Schema. Must conform to the MFJS (Moonshot Flavored JSON Schema) specification
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parameters")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Parameters { get; set; }

        /// <summary>
        /// Whether to strictly constrain tool call arguments according to the parameters schema. Defaults to true. When false, only guarantees the output is a valid JSON object without enforcing internal structure.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("strict")]
        public bool? Strict { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolDefinitionFunction" /> class.
        /// </summary>
        /// <param name="name">
        /// Function name. Must follow the regex: ^[a-zA-Z_][a-zA-Z0-9-_]{2,63}$
        /// </param>
        /// <param name="parameters">
        /// Function parameters as JSON Schema. Must conform to the MFJS (Moonshot Flavored JSON Schema) specification
        /// </param>
        /// <param name="description">
        /// Description of what the function does
        /// </param>
        /// <param name="strict">
        /// Whether to strictly constrain tool call arguments according to the parameters schema. Defaults to true. When false, only guarantees the output is a valid JSON object without enforcing internal structure.<br/>
        /// Default Value: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ToolDefinitionFunction(
            string name,
            object parameters,
            string? description,
            bool? strict)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Parameters = parameters ?? throw new global::System.ArgumentNullException(nameof(parameters));
            this.Strict = strict;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolDefinitionFunction" /> class.
        /// </summary>
        public ToolDefinitionFunction()
        {
        }

    }
}