
#nullable enable

namespace Moonshot
{
    /// <summary>
    /// Reason the response is `incomplete`.
    /// </summary>
    public sealed partial class ResponsesResponseIncompleteDetails
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Moonshot.JsonConverters.ResponsesResponseIncompleteDetailsReasonJsonConverter))]
        public global::Moonshot.ResponsesResponseIncompleteDetailsReason? Reason { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesResponseIncompleteDetails" /> class.
        /// </summary>
        /// <param name="reason"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponsesResponseIncompleteDetails(
            global::Moonshot.ResponsesResponseIncompleteDetailsReason? reason)
        {
            this.Reason = reason;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponsesResponseIncompleteDetails" /> class.
        /// </summary>
        public ResponsesResponseIncompleteDetails()
        {
        }

    }
}