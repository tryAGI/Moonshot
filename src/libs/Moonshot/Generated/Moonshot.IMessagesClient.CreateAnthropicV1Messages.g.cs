#nullable enable

namespace Moonshot
{
    public partial interface IMessagesClient
    {
        /// <summary>
        /// Messages API<br/>
        /// Call Kimi models with an Anthropic Messages API compatible format, supporting streaming, tool use, image input, thinking, and structured output.
        /// </summary>
        /// <param name="xMshRequestNonce">
        /// Example: 7d929748-0ae6-41c2-ab5d-a186498ad721
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.MessagesResponse> CreateAnthropicV1MessagesAsync(

            global::Moonshot.MessagesRequest request,
            string? xMshRequestNonce = default,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Messages API<br/>
        /// Call Kimi models with an Anthropic Messages API compatible format, supporting streaming, tool use, image input, thinking, and structured output.
        /// </summary>
        /// <param name="xMshRequestNonce">
        /// Example: 7d929748-0ae6-41c2-ab5d-a186498ad721
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.AutoSDKHttpResponse<global::Moonshot.MessagesResponse>> CreateAnthropicV1MessagesAsResponseAsync(

            global::Moonshot.MessagesRequest request,
            string? xMshRequestNonce = default,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Messages API<br/>
        /// Call Kimi models with an Anthropic Messages API compatible format, supporting streaming, tool use, image input, thinking, and structured output.
        /// </summary>
        /// <param name="xMshRequestNonce">
        /// Example: 7d929748-0ae6-41c2-ab5d-a186498ad721
        /// </param>
        /// <param name="model">
        /// Model ID<br/>
        /// Default Value: kimi-k3
        /// </param>
        /// <param name="messages">
        /// The conversation messages. If the last message is from the assistant, the model continues from that content (Partial Mode).
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate, required. If the limit is reached before the model finishes, `stop_reason` is `max_tokens`.
        /// </param>
        /// <param name="system">
        /// System prompt, either a string or an array of text blocks
        /// </param>
        /// <param name="stopSequences">
        /// Stop sequences. Generation stops on an exact match; the matched sequence itself is not output. Up to 5 entries, each at most 32 bytes.
        /// </param>
        /// <param name="tools">
        /// List of tools the model may call
        /// </param>
        /// <param name="toolChoice">
        /// Controls whether the model calls tools. `auto` (default): the model decides; `any`: force a call to any tool; `none`: do not call tools.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="outputConfig">
        /// Output configuration: reasoning effort and structured output
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.MessagesResponse> CreateAnthropicV1MessagesAsync(
            global::System.Collections.Generic.IList<global::Moonshot.MessagesMessageParam> messages,
            int maxTokens,
            string? xMshRequestNonce = default,
            global::Moonshot.MessagesRequestModel model = global::Moonshot.MessagesRequestModel.KimiK3,
            global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.MessagesTextBlockParam>>? system = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            global::System.Collections.Generic.IList<global::Moonshot.MessagesTool>? tools = default,
            global::Moonshot.MessagesToolChoice? toolChoice = default,
            global::Moonshot.MessagesRequestMetadata? metadata = default,
            global::Moonshot.MessagesRequestOutputConfig? outputConfig = default,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}