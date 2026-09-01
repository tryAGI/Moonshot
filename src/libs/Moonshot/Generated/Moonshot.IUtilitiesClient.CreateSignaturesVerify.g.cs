#nullable enable

namespace Moonshot
{
    public partial interface IUtilitiesClient
    {
        /// <summary>
        /// Verify Request Signature<br/>
        /// Verifies a request signature returned in the response headers of the Chat Completions, Responses, or Messages API, proving that the request was handled by the Kimi API for the specified model rather than routed elsewhere. Submit the nonce used in the call, the timestamp from the response headers, the request's model, and the signature; the endpoint returns `valid: true` when the signature matches these three attributes exactly, and `valid: false` otherwise.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.SignatureVerifyResponse> CreateSignaturesVerifyAsync(

            global::Moonshot.SignatureVerifyRequest request,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Verify Request Signature<br/>
        /// Verifies a request signature returned in the response headers of the Chat Completions, Responses, or Messages API, proving that the request was handled by the Kimi API for the specified model rather than routed elsewhere. Submit the nonce used in the call, the timestamp from the response headers, the request's model, and the signature; the endpoint returns `valid: true` when the signature matches these three attributes exactly, and `valid: false` otherwise.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.AutoSDKHttpResponse<global::Moonshot.SignatureVerifyResponse>> CreateSignaturesVerifyAsResponseAsync(

            global::Moonshot.SignatureVerifyRequest request,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Verify Request Signature<br/>
        /// Verifies a request signature returned in the response headers of the Chat Completions, Responses, or Messages API, proving that the request was handled by the Kimi API for the specified model rather than routed elsewhere. Submit the nonce used in the call, the timestamp from the response headers, the request's model, and the signature; the endpoint returns `valid: true` when the signature matches these three attributes exactly, and `valid: false` otherwise.
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
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.SignatureVerifyResponse> CreateSignaturesVerifyAsync(
            string nonce,
            long timestamp,
            string model,
            string signature,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}