
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class MessagesRequestMetadata
    {
        /// <summary>
        /// A stable identifier for the end user or session, used to improve cache hit rate and for abuse detection. Use a hashed value; do not send personally identifiable information. For coding agents, pass the session id and keep it constant for the whole session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestMetadata" /> class.
        /// </summary>
        /// <param name="userId">
        /// A stable identifier for the end user or session, used to improve cache hit rate and for abuse detection. Use a hashed value; do not send personally identifiable information. For coding agents, pass the session id and keep it constant for the whole session.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MessagesRequestMetadata(
            string? userId)
        {
            this.UserId = userId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessagesRequestMetadata" /> class.
        /// </summary>
        public MessagesRequestMetadata()
        {
        }

    }
}