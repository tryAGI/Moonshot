
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SignatureVerifyResponse
    {
        /// <summary>
        /// Whether the signature is valid. `true` means the signature was issued by the Kimi API and matches the submitted nonce, timestamp, and model exactly; otherwise `false`.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("valid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Valid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureVerifyResponse" /> class.
        /// </summary>
        /// <param name="valid">
        /// Whether the signature is valid. `true` means the signature was issued by the Kimi API and matches the submitted nonce, timestamp, and model exactly; otherwise `false`.<br/>
        /// Example: true
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignatureVerifyResponse(
            bool valid)
        {
            this.Valid = valid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureVerifyResponse" /> class.
        /// </summary>
        public SignatureVerifyResponse()
        {
        }

    }
}