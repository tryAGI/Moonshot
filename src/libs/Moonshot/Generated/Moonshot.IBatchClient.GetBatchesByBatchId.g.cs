#nullable enable

namespace Moonshot
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Retrieve Batch<br/>
        /// Retrieve the status and details of a specific batch task.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.BatchObject> GetBatchesByBatchIdAsync(
            string batchId,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retrieve Batch<br/>
        /// Retrieve the status and details of a specific batch task.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.AutoSDKHttpResponse<global::Moonshot.BatchObject>> GetBatchesByBatchIdAsResponseAsync(
            string batchId,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}