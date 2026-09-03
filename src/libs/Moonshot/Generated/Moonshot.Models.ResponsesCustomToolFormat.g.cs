
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Input format constraint. Only the `grammar` type with `lark` syntax is supported.
    /// </summary>
    public sealed partial class ResponsesCustomToolFormat
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesCustomToolFormatTypeJsonConverter))]
        public global::Moonshot.ResponsesCustomToolFormatType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("syntax")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesCustomToolFormatSyntaxJsonConverter))]
        public global::Moonshot.ResponsesCustomToolFormatSyntax Syntax { get; set; }

        /// <summary>
        /// The Lark grammar definition.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("definition")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Definition { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesCustomToolFormat" /> class.
        /// </summary>
        /// <param name="definition">
        /// The Lark grammar definition.
        /// </param>
        /// <param name="type"></param>
        /// <param name="syntax"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesCustomToolFormat(
            string definition,
            global::Moonshot.ResponsesCustomToolFormatType type,
            global::Moonshot.ResponsesCustomToolFormatSyntax syntax)
        {
            this.Type = type;
            this.Syntax = syntax;
            this.Definition = definition ?? throw new global::System.ArgumentNullException(nameof(definition));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesCustomToolFormat" /> class.
        /// </summary>
        public ResponsesCustomToolFormat()
        {
        }

    }
}