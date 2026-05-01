#nullable enable

namespace Moonshot
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Cancel Batch<br/>
        /// Cancel an in-progress batch task. The status will change to cancelling and then to cancelled. Only tasks in validating, in_progress, or finalizing status can be cancelled.
        /// </summary>
        /// <param name="batchId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.BatchObject> CreateBatchesByBatchIdCancelAsync(
            string batchId,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}