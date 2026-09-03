
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// A custom tool that takes free-form text input. Only the custom tool named `apply_patch` is supported, and it must define a `grammar` + `lark` format; when the model calls it, a `custom_tool_call` item is returned in the output.
    /// </summary>
    public sealed partial class ResponsesCustomTool
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesCustomToolTypeJsonConverter))]
        public global::Moonshot.ResponsesCustomToolType Type { get; set; }

        /// <summary>
        /// Tool name. Only `apply_patch` is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesCustomToolNameJsonConverter))]
        public global::Moonshot.ResponsesCustomToolName Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Input format constraint. Only the `grammar` type with `lark` syntax is supported.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.ResponsesCustomToolFormat Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesCustomTool" /> class.
        /// </summary>
        /// <param name="format">
        /// Input format constraint. Only the `grammar` type with `lark` syntax is supported.
        /// </param>
        /// <param name="type"></param>
        /// <param name="name">
        /// Tool name. Only `apply_patch` is supported.
        /// </param>
        /// <param name="description"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesCustomTool(
            global::Moonshot.ResponsesCustomToolFormat format,
            global::Moonshot.ResponsesCustomToolType type,
            global::Moonshot.ResponsesCustomToolName name,
            string? description)
        {
            this.Type = type;
            this.Name = name;
            this.Description = description;
            this.Format = format ?? throw new global::System.ArgumentNullException(nameof(format));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesCustomTool" /> class.
        /// </summary>
        public ResponsesCustomTool()
        {
        }

    }
}