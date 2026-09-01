#nullable enable

namespace Moonshot
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create Chat Completion<br/>
        /// Creates a completion for the chat message. Supports standard chat, Partial Mode, and Tool Use (Function Calling).
        /// </summary>
        /// <param name="xMshRequestNonce">
        /// Example: 7d929748-0ae6-41c2-ab5d-a186498ad721
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.ChatCompletionResponse> CreateChatCompletionsAsync(

            global::Moonshot.CreateChatCompletionsRequest request,
            string? xMshRequestNonce = default,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Chat Completion<br/>
        /// Creates a completion for the chat message. Supports standard chat, Partial Mode, and Tool Use (Function Calling).
        /// </summary>
        /// <param name="xMshRequestNonce">
        /// Example: 7d929748-0ae6-41c2-ab5d-a186498ad721
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.AutoSDKHttpResponse<global::Moonshot.ChatCompletionResponse>> CreateChatCompletionsAsResponseAsync(

            global::Moonshot.CreateChatCompletionsRequest request,
            string? xMshRequestNonce = default,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Chat Completion<br/>
        /// Creates a completion for the chat message. Supports standard chat, Partial Mode, and Tool Use (Function Calling).
        /// </summary>
        /// <param name="xMshRequestNonce">
        /// Example: 7d929748-0ae6-41c2-ab5d-a186498ad721
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.ChatCompletionResponse> CreateChatCompletionsAsync(
            string? xMshRequestNonce = default,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}