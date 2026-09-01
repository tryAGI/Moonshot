
#nullable enable

namespace Moonshot
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SignatureVerifyRequest
    {
        /// <summary>
        /// The nonce sent in the `X-Msh-Request-Nonce` request header of the model call, exactly as sent.<br/>
        /// Example: 7d929748-0ae6-41c2-ab5d-a186498ad721
        /// </summary>
        /// <example>7d929748-0ae6-41c2-ab5d-a186498ad721</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("nonce")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Nonce { get; set; }

        /// <summary>
        /// The Unix millisecond timestamp returned in the `Msh-Request-Timestamp` response header of the model call.<br/>
        /// Example: 1786338000123L
        /// </summary>
        /// <example>1786338000123L</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long Timestamp { get; set; }

        /// <summary>
        /// The `model` value from the request body of the model call, exactly as sent.<br/>
        /// Example: kimi-k2.7-code
        /// </summary>
        /// <example>kimi-k2.7-code</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The signature token returned in the `Msh-Request-Signature` response header of the model call.<br/>
        /// Example: reqsigv1_&lt;opaque-token&gt;
        /// </summary>
        /// <example>reqsigv1_&lt;opaque-token&gt;</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("signature")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Signature { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureVerifyRequest" /> class.
        /// </summary>
        /// <param name="nonce">
        /// The nonce sent in the `X-Msh-Request-Nonce` request header of the model call, exactly as sent.<br/>
        /// Example: 7d929748-0ae6-41c2-ab5d-a186498ad721
        /// </param>
        /// <param name="timestamp">
        /// The Unix millisecond timestamp returned in the `Msh-Request-Timestamp` response header of the model call.<br/>
        /// Example: 1786338000123L
        /// </param>
        /// <param name="model">
        /// The `model` value from the request body of the model call, exactly as sent.<br/>
        /// Example: kimi-k2.7-code
        /// </param>
        /// <param name="signature">
        /// The signature token returned in the `Msh-Request-Signature` response header of the model call.<br/>
        /// Example: reqsigv1_&lt;opaque-token&gt;
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignatureVerifyRequest(
            string nonce,
            long timestamp,
            string model,
            string signature)
        {
            this.Nonce = nonce ?? throw new global::System.ArgumentNullException(nameof(nonce));
            this.Timestamp = timestamp;
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Signature = signature ?? throw new global::System.ArgumentNullException(nameof(signature));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignatureVerifyRequest" /> class.
        /// </summary>
        public SignatureVerifyRequest()
        {
        }

    }
}