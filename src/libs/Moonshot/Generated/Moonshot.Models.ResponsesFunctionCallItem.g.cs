
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Replays a function call.
    /// </summary>
    public sealed partial class ResponsesFunctionCallItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesFunctionCallItemTypeJsonConverter))]
        public global::Moonshot.ResponsesFunctionCallItemType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Call ID paired with the matching `function_call_output`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string CallId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Namespace the tool belongs to, returned for namespace tool calls.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// JSON string of the function arguments.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Arguments { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesFunctionCallItemStatusJsonConverter))]
        public global::Moonshot.ResponsesFunctionCallItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesFunctionCallItem" /> class.
        /// </summary>
        /// <param name="callId">
        /// Call ID paired with the matching `function_call_output`.
        /// </param>
        /// <param name="name"></param>
        /// <param name="arguments">
        /// JSON string of the function arguments.
        /// </param>
        /// <param name="type"></param>
        /// <param name="id"></param>
        /// <param name="namespace">
        /// Namespace the tool belongs to, returned for namespace tool calls.
        /// </param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesFunctionCallItem(
            string callId,
            string name,
            string arguments,
            global::Moonshot.ResponsesFunctionCallItemType type,
            string? id,
            string? @namespace,
            global::Moonshot.ResponsesFunctionCallItemStatus? status)
        {
            this.Type = type;
            this.Id = id;
            this.CallId = callId ?? throw new global::System.ArgumentNullException(nameof(callId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Namespace = @namespace;
            this.Arguments = arguments ?? throw new global::System.ArgumentNullException(nameof(arguments));
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesFunctionCallItem" /> class.
        /// </summary>
        public ResponsesFunctionCallItem()
        {
        }

    }
}