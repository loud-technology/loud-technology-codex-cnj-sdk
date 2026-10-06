
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial class MetricasDatalakeClient
    {


        private static readonly global::Loud.Technology.Codex.Cnj.Sdk.EndPointSecurityRequirement s_ConsultaCasosConclusosSecurityRequirement0 =
            new global::Loud.Technology.Codex.Cnj.Sdk.EndPointSecurityRequirement
            {
                Authorizations = new global::Loud.Technology.Codex.Cnj.Sdk.EndPointAuthorizationRequirement[]
                {                    new global::Loud.Technology.Codex.Cnj.Sdk.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyAuthorization",
                        Location = "Header",
                        Name = "Authorization",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::Loud.Technology.Codex.Cnj.Sdk.EndPointSecurityRequirement[] s_ConsultaCasosConclusosSecurityRequirements =
            new global::Loud.Technology.Codex.Cnj.Sdk.EndPointSecurityRequirement[]
            {                s_ConsultaCasosConclusosSecurityRequirement0,
            };
        partial void PrepareConsultaCasosConclusosArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? anoReferencia,
            ref string? searchAfter);
        partial void PrepareConsultaCasosConclusosRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? anoReferencia,
            string? searchAfter);
        partial void ProcessConsultaCasosConclusosResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessConsultaCasosConclusosResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Busca de processos conclusos por situações, fase e no período de 12 meses anteriores a partir da data atual.<br/>
        /// Filtros: fase: Conhecimento; Período: 12 meses anteriores a partir da data atual; Situações: Concluso, Concluso para despacho, Concluso para decisão, Concluso para julgamento, Concluso para admissão recursal.
        /// </summary>
        /// <param name="anoReferencia"></param>
        /// <param name="searchAfter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseProcessoMetricaCasosConclusosOpenSearch> ConsultaCasosConclusosAsync(
            string? anoReferencia = default,
            string? searchAfter = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ConsultaCasosConclusosAsResponseAsync(
                anoReferencia: anoReferencia,
                searchAfter: searchAfter,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Busca de processos conclusos por situações, fase e no período de 12 meses anteriores a partir da data atual.<br/>
        /// Filtros: fase: Conhecimento; Período: 12 meses anteriores a partir da data atual; Situações: Concluso, Concluso para despacho, Concluso para decisão, Concluso para julgamento, Concluso para admissão recursal.
        /// </summary>
        /// <param name="anoReferencia"></param>
        /// <param name="searchAfter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseProcessoMetricaCasosConclusosOpenSearch>> ConsultaCasosConclusosAsResponseAsync(
            string? anoReferencia = default,
            string? searchAfter = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareConsultaCasosConclusosArguments(
                httpClient: HttpClient,
                anoReferencia: ref anoReferencia,
                searchAfter: ref searchAfter);


            var __authorizations = global::Loud.Technology.Codex.Cnj.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ConsultaCasosConclusosSecurityRequirements,
                operationName: "ConsultaCasosConclusosAsync");

            using var __timeoutCancellationTokenSource = global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Loud.Technology.Codex.Cnj.Sdk.PathBuilder(
                                path: "/api/v1/processos/metricas/casos-conclusos",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("anoReferencia", anoReferencia)
                                .AddOptionalParameter("searchAfter", searchAfter)
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

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
                global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareConsultaCasosConclusosRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    anoReferencia: anoReferencia,
                    searchAfter: searchAfter);

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
                    await global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ConsultaCasosConclusos",
                                methodName: "ConsultaCasosConclusosAsync",
                                pathTemplate: "\"/api/v1/processos/metricas/casos-conclusos\"",
                                httpMethod: "GET",
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
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ConsultaCasosConclusos",
                                methodName: "ConsultaCasosConclusosAsync",
                                pathTemplate: "\"/api/v1/processos/metricas/casos-conclusos\"",
                                httpMethod: "GET",
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
                        await global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ConsultaCasosConclusos",
                                methodName: "ConsultaCasosConclusosAsync",
                                pathTemplate: "\"/api/v1/processos/metricas/casos-conclusos\"",
                                httpMethod: "GET",
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
                        await global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
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
                ProcessConsultaCasosConclusosResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ConsultaCasosConclusos",
                                methodName: "ConsultaCasosConclusosAsync",
                                pathTemplate: "\"/api/v1/processos/metricas/casos-conclusos\"",
                                httpMethod: "GET",
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
                    await global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ConsultaCasosConclusos",
                                methodName: "ConsultaCasosConclusosAsync",
                                pathTemplate: "\"/api/v1/processos/metricas/casos-conclusos\"",
                                httpMethod: "GET",
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

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessConsultaCasosConclusosResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseProcessoMetricaCasosConclusosOpenSearch.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseProcessoMetricaCasosConclusosOpenSearch>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Loud.Technology.Codex.Cnj.Sdk.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseProcessoMetricaCasosConclusosOpenSearch.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseProcessoMetricaCasosConclusosOpenSearch>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
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

                                    throw global::Loud.Technology.Codex.Cnj.Sdk.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}