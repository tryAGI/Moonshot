
#nullable enable

namespace Moonshot
{
    public partial class MessagesClient
    {


        private static readonly global::Moonshot.EndPointSecurityRequirement s_CreateAnthropicV1MessagesAsStreamSecurityRequirement0 =
            new global::Moonshot.EndPointSecurityRequirement
            {
                Authorizations = new global::Moonshot.EndPointAuthorizationRequirement[]
                {                    new global::Moonshot.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Moonshot.EndPointSecurityRequirement[] s_CreateAnthropicV1MessagesAsStreamSecurityRequirements =
            new global::Moonshot.EndPointSecurityRequirement[]
            {                s_CreateAnthropicV1MessagesAsStreamSecurityRequirement0,
            };
        partial void PrepareCreateAnthropicV1MessagesAsStreamArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? xMshRequestNonce,
            global::Moonshot.MessagesRequest request);
        partial void PrepareCreateAnthropicV1MessagesAsStreamRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? xMshRequestNonce,
            global::Moonshot.MessagesRequest request);
        partial void ProcessCreateAnthropicV1MessagesAsStreamResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        /// <summary>
        /// Messages API<br/>
        /// Call Kimi models with an Anthropic Messages API compatible format, supporting streaming, tool use, image input, thinking, and structured output.
        /// </summary>
        /// <param name="xMshRequestNonce">
        /// Example: 7d929748-0ae6-41c2-ab5d-a186498ad721
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Moonshot.ApiException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Moonshot.MessagesStreamEvent> CreateAnthropicV1MessagesAsStreamAsync(

            global::Moonshot.MessagesRequest request,
            string? xMshRequestNonce = default,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            request = new global::Moonshot.MessagesRequest
            {
                Model = request.Model,
                Messages = request.Messages,
                MaxTokens = request.MaxTokens,
                System = request.System,
                Stream = true,
                StopSequences = request.StopSequences,
                Tools = request.Tools,
                ToolChoice = request.ToolChoice,
                Metadata = request.Metadata,
                CacheControl = request.CacheControl,
                OutputConfig = request.OutputConfig,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateAnthropicV1MessagesAsStreamArguments(
                httpClient: HttpClient,
                xMshRequestNonce: ref xMshRequestNonce,
                request: request);


            var __authorizations = global::Moonshot.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateAnthropicV1MessagesAsStreamSecurityRequirements,
                operationName: "CreateAnthropicV1MessagesAsStreamAsync");

            using var __timeoutCancellationTokenSource = global::Moonshot.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Moonshot.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Moonshot.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Moonshot.PathBuilder(
                                path: "/anthropic/v1/messages",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Moonshot.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

                __httpRequest.Headers.TryAddWithoutValidation(
                    "Accept",
                    "text/event-stream");

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            if (xMshRequestNonce != default)
            {
                __httpRequest.Headers.TryAddWithoutValidation("X-Msh-Request-Nonce", xMshRequestNonce.ToString());
            }

                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Moonshot.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateAnthropicV1MessagesAsStreamRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    xMshRequestNonce: xMshRequestNonce,
                    request: request);

                global::Moonshot.AutoSDKHttpRequestOptions.StampAuthorizationOverride(__httpRequest);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Moonshot.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Moonshot.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createAnthropicV1MessagesAsStream",
                                methodName: "CreateAnthropicV1MessagesAsStreamAsync",
                                pathTemplate: "\"/anthropic/v1/messages\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseHeadersRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Moonshot.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Moonshot.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Moonshot.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createAnthropicV1MessagesAsStream",
                                methodName: "CreateAnthropicV1MessagesAsStreamAsync",
                                pathTemplate: "\"/anthropic/v1/messages\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Moonshot.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Moonshot.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Moonshot.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Moonshot.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Moonshot.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createAnthropicV1MessagesAsStream",
                                methodName: "CreateAnthropicV1MessagesAsStreamAsync",
                                pathTemplate: "\"/anthropic/v1/messages\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Moonshot.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateAnthropicV1MessagesAsStreamResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Moonshot.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Moonshot.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createAnthropicV1MessagesAsStream",
                                methodName: "CreateAnthropicV1MessagesAsStreamAsync",
                                pathTemplate: "\"/anthropic/v1/messages\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Moonshot.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Moonshot.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "createAnthropicV1MessagesAsStream",
                                methodName: "CreateAnthropicV1MessagesAsStreamAsync",
                                pathTemplate: "\"/anthropic/v1/messages\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            try
                            {
                                __response.EnsureSuccessStatusCode();
                            }
                            catch (global::System.Net.Http.HttpRequestException __ex)
                            {
                                string? __content = null;
                                try
                                {
                                    __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);
                                }
                                catch (global::System.Exception)
                                {
                                }

                                throw global::Moonshot.ApiException.Create(
                                    statusCode: __response.StatusCode,
                                    message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __ex,
                                    responseBody: __content,
                                    responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value));
                            }

                            using var __stream = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                __effectiveCancellationToken
                #endif
                            ).ConfigureAwait(false);

                            await foreach (var __sseEvent in global::System.Net.ServerSentEvents.SseParser
                                .Create(__stream).EnumerateAsync(__effectiveCancellationToken))
                            {
                                var __content = __sseEvent.Data;
                                if (__content == "[DONE]")
                                {
                                    yield break;
                                }

                                var __streamedResponse = global::Moonshot.MessagesStreamEvent.FromJson(__content, JsonSerializerContext) ??
                                                       throw global::Moonshot.ApiException.Create(
                                                           statusCode: __response.StatusCode,
                                                           message: $"Response deserialization failed for \"{__content}\" ",
                                                           innerException: null,
                                                           responseBody: __content,
                                                           responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                                               __response.Headers,
                                                               h => h.Key,
                                                               h => h.Value));

                                yield return __streamedResponse;
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Messages API<br/>
        /// Call Kimi models with an Anthropic Messages API compatible format, supporting streaming, tool use, image input, thinking, and structured output.
        /// </summary>
        /// <param name="xMshRequestNonce">
        /// Example: 7d929748-0ae6-41c2-ab5d-a186498ad721
        /// </param>
        /// <param name="model">
        /// Model ID<br/>
        /// Default Value: kimi-k3
        /// </param>
        /// <param name="messages">
        /// The conversation messages. If the last message is from the assistant, the model continues from that content (Partial Mode).
        /// </param>
        /// <param name="maxTokens">
        /// Maximum number of tokens to generate, required. If the limit is reached before the model finishes, `stop_reason` is `max_tokens`.
        /// </param>
        /// <param name="system">
        /// System prompt, either a string or an array of text blocks
        /// </param>
        /// <param name="stopSequences">
        /// Stop sequences. Generation stops on an exact match; the matched sequence itself is not output. Up to 5 entries, each at most 32 bytes.
        /// </param>
        /// <param name="tools">
        /// List of tools the model may call
        /// </param>
        /// <param name="toolChoice">
        /// Controls whether the model calls tools. `auto` (default): the model decides; `any`: force a call to any tool; `none`: do not call tools.
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="cacheControl">
        /// Context cache write options. Only effective when passed at the top level; cache_control markers inside the messages array are ignored. When omitted, the request only attempts to read the cache (5m tier) and does not write
        /// </param>
        /// <param name="outputConfig">
        /// Output configuration: reasoning effort and structured output
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Collections.Generic.IAsyncEnumerable<global::Moonshot.MessagesStreamEvent> CreateAnthropicV1MessagesAsStreamAsync(
            global::System.Collections.Generic.IList<global::Moonshot.MessagesMessageParam> messages,
            int maxTokens,
            string? xMshRequestNonce = default,
            global::Moonshot.MessagesRequestModel model = global::Moonshot.MessagesRequestModel.KimiK3,
            global::Moonshot.OneOf<string, global::System.Collections.Generic.IList<global::Moonshot.MessagesTextBlockParam>>? system = default,
            global::System.Collections.Generic.IList<string>? stopSequences = default,
            global::System.Collections.Generic.IList<global::Moonshot.MessagesTool>? tools = default,
            global::Moonshot.MessagesToolChoice? toolChoice = default,
            global::Moonshot.MessagesRequestMetadata? metadata = default,
            global::Moonshot.MessagesRequestCacheControl? cacheControl = default,
            global::Moonshot.MessagesRequestOutputConfig? outputConfig = default,
            global::Moonshot.AutoSDKRequestOptions? requestOptions = default,
            [global::System.Runtime.CompilerServices.EnumeratorCancellation] global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Moonshot.MessagesRequest
            {
                Model = model,
                Messages = messages,
                MaxTokens = maxTokens,
                System = system,
                Stream = true,
                StopSequences = stopSequences,
                Tools = tools,
                ToolChoice = toolChoice,
                Metadata = metadata,
                CacheControl = cacheControl,
                OutputConfig = outputConfig,
            };

            var __enumerable = CreateAnthropicV1MessagesAsStreamAsync(
                xMshRequestNonce: xMshRequestNonce,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);

            await foreach (var __response in __enumerable)
            {
                yield return __response;
            }
        }
    }
}