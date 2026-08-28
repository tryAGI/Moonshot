
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesErrorResponseError
    {
        /// <summary>
        /// Error type; see [Errors](/api/errors) for values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Error message describing the cause
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesErrorResponseError" /> class.
        /// </summary>
        /// <param name="type">
        /// Error type; see [Errors](/api/errors) for values
        /// </param>
        /// <param name="message">
        /// Error message describing the cause
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesErrorResponseError(
            string type,
            string message)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesErrorResponseError" /> class.
        /// </summary>
        public MessagesErrorResponseError()
        {
        }

    }
}