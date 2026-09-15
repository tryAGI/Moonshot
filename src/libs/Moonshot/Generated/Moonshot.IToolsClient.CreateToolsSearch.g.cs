#nullable enable

namespace Moonshot
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Web Search Basic<br/>
        /// Run a web search and get structured results with title, snippet, site, and URL. You are charged once per successful call that returns at least one result; failed or empty-result calls are free. See [WebSearch Pricing](/pricing/tools).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.ToolsSearchResponse> CreateToolsSearchAsync(

            global::Moonshot.ToolsSearchRequest request,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Web Search Basic<br/>
        /// Run a web search and get structured results with title, snippet, site, and URL. You are charged once per successful call that returns at least one result; failed or empty-result calls are free. See [WebSearch Pricing](/pricing/tools).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.AutoSDKHttpResponse<global::Moonshot.ToolsSearchResponse>> CreateToolsSearchAsResponseAsync(

            global::Moonshot.ToolsSearchRequest request,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Web Search Basic<br/>
        /// Run a web search and get structured results with title, snippet, site, and URL. You are charged once per successful call that returns at least one result; failed or empty-result calls are free. See [WebSearch Pricing](/pricing/tools).
        /// </summary>
        /// <param name="textQuery">
        /// Search query text. Must not be empty.
        /// </param>
        /// <param name="timeoutSeconds">
        /// Search timeout in seconds, from 1 to 60. If omitted, no per-request timeout is applied.
        /// </param>
        /// <param name="limit">
        /// Maximum number of results to return, from 1 to 20. Defaults to 5.<br/>
        /// Default Value: 5
        /// </param>
        /// <param name="includeContent">
        /// Whether to return full page content in each result's `text` field. Defaults to false.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.ToolsSearchResponse> CreateToolsSearchAsync(
            string textQuery,
            int? timeoutSeconds = default,
            int? limit = default,
            bool? includeContent = default,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}