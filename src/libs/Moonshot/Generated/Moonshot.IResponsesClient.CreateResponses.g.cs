#nullable enable

namespace Moonshot
{
    public partial interface IResponsesClient
    {
        /// <summary>
        /// Create a model response<br/>
        /// Creates a model response. Provide text or image inputs to generate text or JSON outputs. Have the model call the function tools you define. When `stream` is `true`, the response is delivered as a stream of SSE events.
        /// </summary>
        /// <param name="xMshRequestNonce">
        /// Example: 7d929748-0ae6-41c2-ab5d-a186498ad721
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.ResponsesResponse> CreateResponsesAsync(

            global::Moonshot.ResponsesRequest request,
            string? xMshRequestNonce = default,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a model response<br/>
        /// Creates a model response. Provide text or image inputs to generate text or JSON outputs. Have the model call the function tools you define. When `stream` is `true`, the response is delivered as a stream of SSE events.
        /// </summary>
        /// <param name="xMshRequestNonce">
        /// Example: 7d929748-0ae6-41c2-ab5d-a186498ad721
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.AutoSDKHttpResponse<global::Moonshot.ResponsesResponse>> CreateResponsesAsResponseAsync(

            global::Moonshot.ResponsesRequest request,
            string? xMshRequestNonce = default,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a model response<br/>
        /// Creates a model response. Provide text or image inputs to generate text or JSON outputs. Have the model call the function tools you define. When `stream` is `true`, the response is delivered as a stream of SSE events.
        /// </summary>
        /// <param name="xMshRequestNonce">
        /// Example: 7d929748-0ae6-41c2-ab5d-a186498ad721
        /// </param>
        /// <param name="model">
        /// ID of the model to use. This endpoint currently supports `kimi-k3`.<br/>
        /// Example: kimi-k3
        /// </param>
        /// <param name="input">
        /// Input for this request. A string is equivalent to a single user message. An array holds ordered typed items and may contain conversation history, tool calls, and tool results.
        /// </param>
        /// <param name="instructions">
        /// Top-level system instructions, applied ahead of every input item.
        /// </param>
        /// <param name="maxOutputTokens">
        /// Maximum number of tokens to generate for this response. For `kimi-k3` it defaults to 131072 and can be set up to 1048576. This refers to the length of tokens you expect us to return, not the total length of input plus output. When the limit is reached, `status` is `incomplete` and `incomplete_details.reason` is `max_output_tokens`.
        /// </param>
        /// <param name="reasoning">
        /// Reasoning configuration.
        /// </param>
        /// <param name="text">
        /// Output text configuration.
        /// </param>
        /// <param name="tools">
        /// List of tools the model may call.
        /// </param>
        /// <param name="toolChoice">
        /// Controls tool-calling behavior. With `auto`, the model decides whether to call a tool.
        /// </param>
        /// <param name="promptCacheKey">
        /// Context cache identifier. Reusing the same value across a session improves cache hit rate.
        /// </param>
        /// <param name="safetyIdentifier">
        /// A stable identifier used to help detect users of your application that may be violating usage policies. The ID should be a string that uniquely identifies each user. It is recommended to hash the username or email address to avoid sending any identifying information
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.ResponsesResponse> CreateResponsesAsync(
            string model,
            global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.ResponsesInputItem>> input,
            string? xMshRequestNonce = default,
            string? instructions = default,
            int? maxOutputTokens = default,
            global::Moonshot.ResponsesRequestReasoning? reasoning = default,
            global::Moonshot.ResponsesRequestText? text = default,
            global::System.Collections.Generic.IList<global::Moonshot.ResponsesTool>? tools = default,
            global::Moonshot.ResponsesToolChoice? toolChoice = default,
            string? promptCacheKey = default,
            string? safetyIdentifier = default,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}