
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesErrorResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.MessagesErrorResponseTypeJsonConverter))]
        public global::Moonshot.MessagesErrorResponseType Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Moonshot.MessagesErrorResponseError Error { get; set; }

        /// <summary>
        /// Request ID; include it when reporting issues
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_id")]
        public string? RequestId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesErrorResponse" /> class.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="type"></param>
        /// <param name="requestId">
        /// Request ID; include it when reporting issues
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesErrorResponse(
            global::Moonshot.MessagesErrorResponseError error,
            global::Moonshot.MessagesErrorResponseType type,
            string? requestId)
        {
            this.Type = type;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.RequestId = requestId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesErrorResponse" /> class.
        /// </summary>
        public MessagesErrorResponse()
        {
        }

    }
}