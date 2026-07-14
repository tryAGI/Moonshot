#nullable enable

namespace Moonshot
{
    public partial interface ICachingClient
    {
        /// <summary>
        /// Create Cache<br/>
        /// Create a context cache for reuse in subsequent chat requests. Pass the messages you want to cache (usually system prompts or knowledge documents) and tool definitions.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.CacheObject> CreateCachingAsync(

            global::Moonshot.CreateCachingRequest request,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Cache<br/>
        /// Create a context cache for reuse in subsequent chat requests. Pass the messages you want to cache (usually system prompts or knowledge documents) and tool definitions.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.AutoSDKHttpResponse<global::Moonshot.CacheObject>> CreateCachingAsResponseAsync(

            global::Moonshot.CreateCachingRequest request,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Cache<br/>
        /// Create a context cache for reuse in subsequent chat requests. Pass the messages you want to cache (usually system prompts or knowledge documents) and tool definitions.
        /// </summary>
        /// <param name="model">
        /// Model ID
        /// </param>
        /// <param name="messages">
        /// List of messages to cache
        /// </param>
        /// <param name="tools">
        /// List of tool definitions to cache (optional)
        /// </param>
        /// <param name="name">
        /// Business identifier for the cache (optional)
        /// </param>
        /// <param name="ttl">
        /// Cache TTL in seconds, optional. For example, 3600 = 1 hour
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.CacheObject> CreateCachingAsync(
            string model,
            global::System.Collections.Generic.IList<global::Moonshot.Message> messages,
            global::System.Collections.Generic.IList<global::Moonshot.ToolDefinition>? tools = default,
            string? name = default,
            int? ttl = default,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}