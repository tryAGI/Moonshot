#nullable enable

namespace Moonshot
{
    public partial interface IChatClient
    {
        /// <summary>
        /// Create Chat Completion<br/>
        /// Creates a completion for the chat message. Supports standard chat, Partial Mode, and Tool Use (Function Calling).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.ChatCompletionResponse> CreateChatCompletionsAsync(

            global::Moonshot.CreateChatCompletionsRequest request,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Chat Completion<br/>
        /// Creates a completion for the chat message. Supports standard chat, Partial Mode, and Tool Use (Function Calling).
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.ChatCompletionResponse> CreateChatCompletionsAsync(
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}