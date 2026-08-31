
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// A function call initiated by the model.
    /// </summary>
    public sealed partial class ResponsesOutputFunctionCallItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesOutputFunctionCallItemTypeJsonConverter))]
        public global::Moonshot.ResponsesOutputFunctionCallItemType? Type { get; set; }

        /// <summary>
        /// Example: fc_68f0c1c2d3e4f5a6b7c8d9e0
        /// </summary>
        /// <example>fc_68f0c1c2d3e4f5a6b7c8d9e0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Use this value in `function_call_output` when returning the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Returned for namespace tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// JSON string of the function arguments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesOutputFunctionCallItemStatusJsonConverter))]
        public global::Moonshot.ResponsesOutputFunctionCallItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesOutputFunctionCallItem" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="id">
        /// Example: fc_68f0c1c2d3e4f5a6b7c8d9e0
        /// </param>
        /// <param name="callId">
        /// Use this value in `function_call_output` when returning the result.
        /// </param>
        /// <param name="name"></param>
        /// <param name="namespace">
        /// Returned for namespace tool calls.
        /// </param>
        /// <param name="arguments">
        /// JSON string of the function arguments.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesOutputFunctionCallItem(
            global::Moonshot.ResponsesOutputFunctionCallItemType? type,
            string? id,
            string? callId,
            string? name,
            string? @namespace,
            string? arguments,
            global::Moonshot.ResponsesOutputFunctionCallItemStatus? status)
        {
            this.Type = type;
            this.Id = id;
            this.CallId = callId;
            this.Name = name;
            this.Namespace = @namespace;
            this.Arguments = arguments;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesOutputFunctionCallItem" /> class.
        /// </summary>
        public ResponsesOutputFunctionCallItem()
        {
        }

    }
}