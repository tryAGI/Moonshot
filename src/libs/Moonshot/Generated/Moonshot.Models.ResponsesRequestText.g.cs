
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Output text configuration.
    /// </summary>
    public sealed partial class ResponsesRequestText
    {
        /// <summary>
        /// Constrains the output structure with a JSON Schema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("format")]
        public global::Moonshot.ResponsesRequestTextFormat? Format { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestText" /> class.
        /// </summary>
        /// <param name="format">
        /// Constrains the output structure with a JSON Schema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesRequestText(
            global::Moonshot.ResponsesRequestTextFormat? format)
        {
            this.Format = format;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesRequestText" /> class.
        /// </summary>
        public ResponsesRequestText()
        {
        }

    }
}