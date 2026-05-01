#nullable enable

namespace Moonshot
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Get File Information<br/>
        /// Retrieves metadata for a specific uploaded file.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.FileObject> GetFilesByFileIdAsync(
            string fileId,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}