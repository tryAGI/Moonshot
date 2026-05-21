#nullable enable

namespace Moonshot
{
    public partial interface IBatchClient
    {
        /// <summary>
        /// Create Batch<br/>
        /// Create a batch task. You need to first upload a JSONL file with purpose="batch" via the Files API, then use the returned file_id to create the task.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.BatchObject> CreateBatchesAsync(

            global::Moonshot.BatchCreateRequest request,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Batch<br/>
        /// Create a batch task. You need to first upload a JSONL file with purpose="batch" via the Files API, then use the returned file_id to create the task.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.AutoSDKHttpResponse<global::Moonshot.BatchObject>> CreateBatchesAsResponseAsync(

            global::Moonshot.BatchCreateRequest request,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create Batch<br/>
        /// Create a batch task. You need to first upload a JSONL file with purpose="batch" via the Files API, then use the returned file_id to create the task.
        /// </summary>
        /// <param name="inputFileId">
        /// ID of the input file, must be a .jsonl file uploaded with purpose="batch"
        /// </param>
        /// <param name="endpoint">
        /// Request endpoint, currently only /v1/chat/completions is supported
        /// </param>
        /// <param name="completionWindow">
        /// Time window for task processing, supports formats like 12h, 1d, 3d, minimum 12h, maximum 7d
        /// </param>
        /// <param name="metadata">
        /// Custom metadata, up to 16 key-value pairs, key max 64 chars, value max 512 chars
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.BatchObject> CreateBatchesAsync(
            string inputFileId,
            string completionWindow,
            global::Moonshot.BatchCreateRequestEndpoint endpoint = default,
            global::System.Collections.Generic.Dictionary<string, string>? metadata = default,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}