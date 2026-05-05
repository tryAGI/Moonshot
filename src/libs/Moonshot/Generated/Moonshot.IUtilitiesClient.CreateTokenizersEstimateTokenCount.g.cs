#nullable enable

namespace Moonshot
{
    public partial interface IUtilitiesClient
    {
        /// <summary>
        /// Estimate Token Count<br/>
        /// Estimates the number of tokens that would be used for a given set of messages and model. The input structure is almost identical to that of chat completion.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.EstimateTokenResponse> CreateTokenizersEstimateTokenCountAsync(

            global::Moonshot.EstimateTokenRequest request,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate Token Count<br/>
        /// Estimates the number of tokens that would be used for a given set of messages and model. The input structure is almost identical to that of chat completion.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.AutoSDKHttpResponse<global::Moonshot.EstimateTokenResponse>> CreateTokenizersEstimateTokenCountAsResponseAsync(

            global::Moonshot.EstimateTokenRequest request,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Estimate Token Count<br/>
        /// Estimates the number of tokens that would be used for a given set of messages and model. The input structure is almost identical to that of chat completion.
        /// </summary>
        /// <param name="model">
        /// Model ID<br/>
        /// Default Value: kimi-k2.5
        /// </param>
        /// <param name="messages">
        /// A list of messages in the conversation so far. Each element has the format {"role": "user", "content": "Hello"}. role supports system, user, or assistant. content must not be empty
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.EstimateTokenResponse> CreateTokenizersEstimateTokenCountAsync(
            global::System.Collections.Generic.IList<global::Moonshot.Message> messages,
            global::Moonshot.EstimateTokenRequestModel model = global::Moonshot.EstimateTokenRequestModel.KimiK25,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}