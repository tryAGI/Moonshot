#nullable enable

namespace Moonshot
{
    public partial interface IToolsClient
    {
        /// <summary>
        /// Web Search Pro<br/>
        /// Web Search Basic with site and time-range constraints, plus structured content chunks (`chunks`) for each result. You are charged once per successful call that returns at least one result; failed or empty-result calls are free. See [WebSearch Pricing](/pricing/tools).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.ToolsSearchProResponse> CreateToolsSearchProAsync(

            global::Moonshot.ToolsSearchProRequest request,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Web Search Pro<br/>
        /// Web Search Basic with site and time-range constraints, plus structured content chunks (`chunks`) for each result. You are charged once per successful call that returns at least one result; failed or empty-result calls are free. See [WebSearch Pricing](/pricing/tools).
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.AutoSDKHttpResponse<global::Moonshot.ToolsSearchProResponse>> CreateToolsSearchProAsResponseAsync(

            global::Moonshot.ToolsSearchProRequest request,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Web Search Pro<br/>
        /// Web Search Basic with site and time-range constraints, plus structured content chunks (`chunks`) for each result. You are charged once per successful call that returns at least one result; failed or empty-result calls are free. See [WebSearch Pricing](/pricing/tools).
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
        /// <param name="sites">
        /// Restrict results to the given sites. Multiple sites are OR'd, up to 5 entries; each entry must be non-empty and must not contain whitespace or parentheses.
        /// </param>
        /// <param name="timeWindow">
        /// Time-window constraint on result dates. start and end are each normalized to the first day of their period before comparison; start must not be later than end.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Moonshot.ToolsSearchProResponse> CreateToolsSearchProAsync(
            string textQuery,
            int? timeoutSeconds = default,
            int? limit = default,
            global::System.Collections.Generic.IList<string>? sites = default,
            global::Moonshot.ToolsSearchTimeWindow? timeWindow = default,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}