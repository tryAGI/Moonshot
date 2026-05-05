#nullable enable

namespace Moonshot
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload File<br/>
        /// Uploads a file for extraction, image understanding, or video understanding.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.FileObject> CreateFilesAsync(

            global::Moonshot.CreateFilesRequest request,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File<br/>
        /// Uploads a file for extraction, image understanding, or video understanding.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.AutoSDKHttpResponse<global::Moonshot.FileObject>> CreateFilesAsResponseAsync(

            global::Moonshot.CreateFilesRequest request,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File<br/>
        /// Uploads a file for extraction, image understanding, or video understanding.
        /// </summary>
        /// <param name="file">
        /// The file to upload
        /// </param>
        /// <param name="filename">
        /// The file to upload
        /// </param>
        /// <param name="purpose">
        /// Specifies how the uploaded file will be processed. file-extract: extract file contents; image: upload images for vision understanding; video: upload videos for video understanding; batch: upload JSONL files for batch processing
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.FileObject> CreateFilesAsync(
            byte[] file,
            string filename,
            global::Moonshot.CreateFilesRequestPurpose purpose,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload File<br/>
        /// Uploads a file for extraction, image understanding, or video understanding.
        /// </summary>
        /// <param name="file">
        /// The file to upload
        /// </param>
        /// <param name="filename">
        /// The file to upload
        /// </param>
        /// <param name="purpose">
        /// Specifies how the uploaded file will be processed. file-extract: extract file contents; image: upload images for vision understanding; video: upload videos for video understanding; batch: upload JSONL files for batch processing
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.FileObject> CreateFilesAsync(
            global::System.IO.Stream file,
            string filename,
            global::Moonshot.CreateFilesRequestPurpose purpose,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload File<br/>
        /// Uploads a file for extraction, image understanding, or video understanding.
        /// </summary>
        /// <param name="file">
        /// The file to upload
        /// </param>
        /// <param name="filename">
        /// The file to upload
        /// </param>
        /// <param name="purpose">
        /// Specifies how the uploaded file will be processed. file-extract: extract file contents; image: upload images for vision understanding; video: upload videos for video understanding; batch: upload JSONL files for batch processing
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.AutoSDKHttpResponse<global::Moonshot.FileObject>> CreateFilesAsResponseAsync(
            global::System.IO.Stream file,
            string filename,
            global::Moonshot.CreateFilesRequestPurpose purpose,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}