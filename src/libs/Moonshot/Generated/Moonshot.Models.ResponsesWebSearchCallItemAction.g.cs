
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ResponsesWebSearchCallItemAction
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesWebSearchCallItemActionTypeJsonConverter))]
        public global::Moonshot.ResponsesWebSearchCallItemActionType? Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesWebSearchCallItemAction" /> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="query"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesWebSearchCallItemAction(
            global::Moonshot.ResponsesWebSearchCallItemActionType? type,
            string? query)
        {
            this.Type = type;
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesWebSearchCallItemAction" /> class.
        /// </summary>
        public ResponsesWebSearchCallItemAction()
        {
        }

    }
}