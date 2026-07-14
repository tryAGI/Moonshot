#nullable enable

namespace Moonshot
{
    public partial interface ICachingClient
    {
        /// <summary>
        /// Retrieve Cache Status<br/>
        /// Retrieve the current status and metadata of a specific cache.
        /// </summary>
        /// <param name="cacheId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.CacheObject> GetCachingByCacheIdAsync(
            string cacheId,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Cache Status<br/>
        /// Retrieve the current status and metadata of a specific cache.
        /// </summary>
        /// <param name="cacheId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.AutoSDKHttpResponse<global::Moonshot.CacheObject>> GetCachingByCacheIdAsResponseAsync(
            string cacheId,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}