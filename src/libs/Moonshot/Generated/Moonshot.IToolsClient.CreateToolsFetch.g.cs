#nullable enable

namespace Moonshot
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// URL Fetch<br/>
        /// Fetch the content of a URL and get the page title and body text in Markdown (text and images concatenated in order). Only http and https URLs are supported. You are charged once per successful call that extracts content; failed or empty-content calls are free. See [WebSearch Pricing](/pricing/tools).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.ToolsFetchResponse> CreateToolsFetchAsync(

            global::Moonshot.ToolsFetchRequest request,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// URL Fetch<br/>
        /// Fetch the content of a URL and get the page title and body text in Markdown (text and images concatenated in order). Only http and https URLs are supported. You are charged once per successful call that extracts content; failed or empty-content calls are free. See [WebSearch Pricing](/pricing/tools).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.AutoSDKHttpResponse<global::Moonshot.ToolsFetchResponse>> CreateToolsFetchAsResponseAsync(

            global::Moonshot.ToolsFetchRequest request,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// URL Fetch<br/>
        /// Fetch the content of a URL and get the page title and body text in Markdown (text and images concatenated in order). Only http and https URLs are supported. You are charged once per successful call that extracts content; failed or empty-content calls are free. See [WebSearch Pricing](/pricing/tools).
        /// </summary>
        /// <param name="url">
        /// URL of the page to fetch. Only http and https are supported.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.ToolsFetchResponse> CreateToolsFetchAsync(
            string url,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}