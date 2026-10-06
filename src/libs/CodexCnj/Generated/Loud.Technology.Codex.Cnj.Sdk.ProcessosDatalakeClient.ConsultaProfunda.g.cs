
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial class ProcessosDatalakeClient
    {


        private static readonly global::Loud.Technology.Codex.Cnj.Sdk.EndPointSecurityRequirement s_ConsultaProfundaSecurityRequirement0 =
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
        private static readonly global::Loud.Technology.Codex.Cnj.Sdk.EndPointSecurityRequirement[] s_ConsultaProfundaSecurityRequirements =
            new global::Loud.Technology.Codex.Cnj.Sdk.EndPointSecurityRequirement[]
            {                s_ConsultaProfundaSecurityRequirement0,
            };
        partial void PrepareConsultaProfundaArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string? campoOrdenacao,
            ref string? cpfCnpjParte,
            ref string? cpfRepresentante,
            ref string? dataHoraAtualizacaoFim,
            ref string? dataHoraAtualizacaoInicio,
            ref string? dataHoraPrimeiroAjuizamentoFim,
            ref string? dataHoraPrimeiroAjuizamentoInicio,
            ref global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaFase? fase,
            ref string? href,
            ref string? id,
            ref string? idAssuntoJudicial,
            ref string? idClasse,
            ref string? idFonteDadosCodex,
            global::System.Collections.Generic.IList<long>? idOrgaoJulgador,
            ref string? instancia,
            ref string? nomeParte,
            ref string? nomeRepresentante,
            ref string? numeroHistorico,
            ref string? numeroProcesso,
            ref string? numeroProcessoSintetico,
            ref string? oabRepresentante,
            ref string? outroNomeParte,
            ref string? poloParte,
            ref string? searchAfter,
            ref global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaSegmentoJustica? segmentoJustica,
            ref global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaSituacaoAtual? situacaoAtual,
            ref string? situacaoParte,
            ref global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaTipoOperacao? tipoOperacao,
            ref string? tribunal);
        partial void PrepareConsultaProfundaRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string? campoOrdenacao,
            string? cpfCnpjParte,
            string? cpfRepresentante,
            string? dataHoraAtualizacaoFim,
            string? dataHoraAtualizacaoInicio,
            string? dataHoraPrimeiroAjuizamentoFim,
            string? dataHoraPrimeiroAjuizamentoInicio,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaFase? fase,
            string? href,
            string? id,
            string? idAssuntoJudicial,
            string? idClasse,
            string? idFonteDadosCodex,
            global::System.Collections.Generic.IList<long>? idOrgaoJulgador,
            string? instancia,
            string? nomeParte,
            string? nomeRepresentante,
            string? numeroHistorico,
            string? numeroProcesso,
            string? numeroProcessoSintetico,
            string? oabRepresentante,
            string? outroNomeParte,
            string? poloParte,
            string? searchAfter,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaSegmentoJustica? segmentoJustica,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaSituacaoAtual? situacaoAtual,
            string? situacaoParte,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaTipoOperacao? tipoOperacao,
            string? tribunal);
        partial void ProcessConsultaProfundaResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessConsultaProfundaResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Busca de processos através de filtros<br/>
        /// Busca para registros de processos através de filtros para os campos indexados. A paginação é sequencial.
        /// </summary>
        /// <param name="campoOrdenacao"></param>
        /// <param name="cpfCnpjParte"></param>
        /// <param name="cpfRepresentante"></param>
        /// <param name="dataHoraAtualizacaoFim"></param>
        /// <param name="dataHoraAtualizacaoInicio"></param>
        /// <param name="dataHoraPrimeiroAjuizamentoFim"></param>
        /// <param name="dataHoraPrimeiroAjuizamentoInicio"></param>
        /// <param name="fase"></param>
        /// <param name="href"></param>
        /// <param name="id"></param>
        /// <param name="idAssuntoJudicial"></param>
        /// <param name="idClasse"></param>
        /// <param name="idFonteDadosCodex"></param>
        /// <param name="idOrgaoJulgador"></param>
        /// <param name="instancia"></param>
        /// <param name="nomeParte"></param>
        /// <param name="nomeRepresentante"></param>
        /// <param name="numeroHistorico"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="numeroProcessoSintetico"></param>
        /// <param name="oabRepresentante"></param>
        /// <param name="outroNomeParte"></param>
        /// <param name="poloParte"></param>
        /// <param name="searchAfter"></param>
        /// <param name="segmentoJustica"></param>
        /// <param name="situacaoAtual"></param>
        /// <param name="situacaoParte"></param>
        /// <param name="tipoOperacao"></param>
        /// <param name="tribunal"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseTramiteInfoProcessoOpenSearch> ConsultaProfundaAsync(
            string? campoOrdenacao = default,
            string? cpfCnpjParte = default,
            string? cpfRepresentante = default,
            string? dataHoraAtualizacaoFim = default,
            string? dataHoraAtualizacaoInicio = default,
            string? dataHoraPrimeiroAjuizamentoFim = default,
            string? dataHoraPrimeiroAjuizamentoInicio = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaFase? fase = default,
            string? href = default,
            string? id = default,
            string? idAssuntoJudicial = default,
            string? idClasse = default,
            string? idFonteDadosCodex = default,
            global::System.Collections.Generic.IList<long>? idOrgaoJulgador = default,
            string? instancia = default,
            string? nomeParte = default,
            string? nomeRepresentante = default,
            string? numeroHistorico = default,
            string? numeroProcesso = default,
            string? numeroProcessoSintetico = default,
            string? oabRepresentante = default,
            string? outroNomeParte = default,
            string? poloParte = default,
            string? searchAfter = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaSegmentoJustica? segmentoJustica = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaSituacaoAtual? situacaoAtual = default,
            string? situacaoParte = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaTipoOperacao? tipoOperacao = default,
            string? tribunal = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await ConsultaProfundaAsResponseAsync(
                campoOrdenacao: campoOrdenacao,
                cpfCnpjParte: cpfCnpjParte,
                cpfRepresentante: cpfRepresentante,
                dataHoraAtualizacaoFim: dataHoraAtualizacaoFim,
                dataHoraAtualizacaoInicio: dataHoraAtualizacaoInicio,
                dataHoraPrimeiroAjuizamentoFim: dataHoraPrimeiroAjuizamentoFim,
                dataHoraPrimeiroAjuizamentoInicio: dataHoraPrimeiroAjuizamentoInicio,
                fase: fase,
                href: href,
                id: id,
                idAssuntoJudicial: idAssuntoJudicial,
                idClasse: idClasse,
                idFonteDadosCodex: idFonteDadosCodex,
                idOrgaoJulgador: idOrgaoJulgador,
                instancia: instancia,
                nomeParte: nomeParte,
                nomeRepresentante: nomeRepresentante,
                numeroHistorico: numeroHistorico,
                numeroProcesso: numeroProcesso,
                numeroProcessoSintetico: numeroProcessoSintetico,
                oabRepresentante: oabRepresentante,
                outroNomeParte: outroNomeParte,
                poloParte: poloParte,
                searchAfter: searchAfter,
                segmentoJustica: segmentoJustica,
                situacaoAtual: situacaoAtual,
                situacaoParte: situacaoParte,
                tipoOperacao: tipoOperacao,
                tribunal: tribunal,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Busca de processos através de filtros<br/>
        /// Busca para registros de processos através de filtros para os campos indexados. A paginação é sequencial.
        /// </summary>
        /// <param name="campoOrdenacao"></param>
        /// <param name="cpfCnpjParte"></param>
        /// <param name="cpfRepresentante"></param>
        /// <param name="dataHoraAtualizacaoFim"></param>
        /// <param name="dataHoraAtualizacaoInicio"></param>
        /// <param name="dataHoraPrimeiroAjuizamentoFim"></param>
        /// <param name="dataHoraPrimeiroAjuizamentoInicio"></param>
        /// <param name="fase"></param>
        /// <param name="href"></param>
        /// <param name="id"></param>
        /// <param name="idAssuntoJudicial"></param>
        /// <param name="idClasse"></param>
        /// <param name="idFonteDadosCodex"></param>
        /// <param name="idOrgaoJulgador"></param>
        /// <param name="instancia"></param>
        /// <param name="nomeParte"></param>
        /// <param name="nomeRepresentante"></param>
        /// <param name="numeroHistorico"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="numeroProcessoSintetico"></param>
        /// <param name="oabRepresentante"></param>
        /// <param name="outroNomeParte"></param>
        /// <param name="poloParte"></param>
        /// <param name="searchAfter"></param>
        /// <param name="segmentoJustica"></param>
        /// <param name="situacaoAtual"></param>
        /// <param name="situacaoParte"></param>
        /// <param name="tipoOperacao"></param>
        /// <param name="tribunal"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseTramiteInfoProcessoOpenSearch>> ConsultaProfundaAsResponseAsync(
            string? campoOrdenacao = default,
            string? cpfCnpjParte = default,
            string? cpfRepresentante = default,
            string? dataHoraAtualizacaoFim = default,
            string? dataHoraAtualizacaoInicio = default,
            string? dataHoraPrimeiroAjuizamentoFim = default,
            string? dataHoraPrimeiroAjuizamentoInicio = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaFase? fase = default,
            string? href = default,
            string? id = default,
            string? idAssuntoJudicial = default,
            string? idClasse = default,
            string? idFonteDadosCodex = default,
            global::System.Collections.Generic.IList<long>? idOrgaoJulgador = default,
            string? instancia = default,
            string? nomeParte = default,
            string? nomeRepresentante = default,
            string? numeroHistorico = default,
            string? numeroProcesso = default,
            string? numeroProcessoSintetico = default,
            string? oabRepresentante = default,
            string? outroNomeParte = default,
            string? poloParte = default,
            string? searchAfter = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaSegmentoJustica? segmentoJustica = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaSituacaoAtual? situacaoAtual = default,
            string? situacaoParte = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaTipoOperacao? tipoOperacao = default,
            string? tribunal = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareConsultaProfundaArguments(
                httpClient: HttpClient,
                campoOrdenacao: ref campoOrdenacao,
                cpfCnpjParte: ref cpfCnpjParte,
                cpfRepresentante: ref cpfRepresentante,
                dataHoraAtualizacaoFim: ref dataHoraAtualizacaoFim,
                dataHoraAtualizacaoInicio: ref dataHoraAtualizacaoInicio,
                dataHoraPrimeiroAjuizamentoFim: ref dataHoraPrimeiroAjuizamentoFim,
                dataHoraPrimeiroAjuizamentoInicio: ref dataHoraPrimeiroAjuizamentoInicio,
                fase: ref fase,
                href: ref href,
                id: ref id,
                idAssuntoJudicial: ref idAssuntoJudicial,
                idClasse: ref idClasse,
                idFonteDadosCodex: ref idFonteDadosCodex,
                idOrgaoJulgador: idOrgaoJulgador,
                instancia: ref instancia,
                nomeParte: ref nomeParte,
                nomeRepresentante: ref nomeRepresentante,
                numeroHistorico: ref numeroHistorico,
                numeroProcesso: ref numeroProcesso,
                numeroProcessoSintetico: ref numeroProcessoSintetico,
                oabRepresentante: ref oabRepresentante,
                outroNomeParte: ref outroNomeParte,
                poloParte: ref poloParte,
                searchAfter: ref searchAfter,
                segmentoJustica: ref segmentoJustica,
                situacaoAtual: ref situacaoAtual,
                situacaoParte: ref situacaoParte,
                tipoOperacao: ref tipoOperacao,
                tribunal: ref tribunal);


            var __authorizations = global::Loud.Technology.Codex.Cnj.Sdk.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_ConsultaProfundaSecurityRequirements,
                operationName: "ConsultaProfundaAsync");

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
                                path: "/api/v1/processos",
                                baseUri: HttpClient.BaseAddress);
                            __pathBuilder
                                .AddOptionalParameter("campoOrdenacao", campoOrdenacao)
                                .AddOptionalParameter("cpfCnpjParte", cpfCnpjParte)
                                .AddOptionalParameter("cpfRepresentante", cpfRepresentante)
                                .AddOptionalParameter("dataHoraAtualizacaoFim", dataHoraAtualizacaoFim)
                                .AddOptionalParameter("dataHoraAtualizacaoInicio", dataHoraAtualizacaoInicio)
                                .AddOptionalParameter("dataHoraPrimeiroAjuizamentoFim", dataHoraPrimeiroAjuizamentoFim)
                                .AddOptionalParameter("dataHoraPrimeiroAjuizamentoInicio", dataHoraPrimeiroAjuizamentoInicio)
                                .AddOptionalParameter("fase", fase?.ToValueString())
                                .AddOptionalParameter("href", href)
                                .AddOptionalParameter("id", id)
                                .AddOptionalParameter("idAssuntoJudicial", idAssuntoJudicial)
                                .AddOptionalParameter("idClasse", idClasse)
                                .AddOptionalParameter("idFonteDadosCodex", idFonteDadosCodex)
                                .AddOptionalParameter("idOrgaoJulgador", idOrgaoJulgador, selector: static x => x.ToString()!, delimiter: ",", explode: true)
                                .AddOptionalParameter("instancia", instancia)
                                .AddOptionalParameter("nomeParte", nomeParte)
                                .AddOptionalParameter("nomeRepresentante", nomeRepresentante)
                                .AddOptionalParameter("numeroHistorico", numeroHistorico)
                                .AddOptionalParameter("numeroProcesso", numeroProcesso)
                                .AddOptionalParameter("numeroProcessoSintetico", numeroProcessoSintetico)
                                .AddOptionalParameter("oabRepresentante", oabRepresentante)
                                .AddOptionalParameter("outroNomeParte", outroNomeParte)
                                .AddOptionalParameter("poloParte", poloParte)
                                .AddOptionalParameter("searchAfter", searchAfter)
                                .AddOptionalParameter("segmentoJustica", segmentoJustica?.ToValueString())
                                .AddOptionalParameter("situacaoAtual", situacaoAtual?.ToValueString())
                                .AddOptionalParameter("situacaoParte", situacaoParte)
                                .AddOptionalParameter("tipoOperacao", tipoOperacao?.ToValueString())
                                .AddOptionalParameter("tribunal", tribunal)
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
                PrepareConsultaProfundaRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    campoOrdenacao: campoOrdenacao,
                    cpfCnpjParte: cpfCnpjParte,
                    cpfRepresentante: cpfRepresentante,
                    dataHoraAtualizacaoFim: dataHoraAtualizacaoFim,
                    dataHoraAtualizacaoInicio: dataHoraAtualizacaoInicio,
                    dataHoraPrimeiroAjuizamentoFim: dataHoraPrimeiroAjuizamentoFim,
                    dataHoraPrimeiroAjuizamentoInicio: dataHoraPrimeiroAjuizamentoInicio,
                    fase: fase,
                    href: href,
                    id: id,
                    idAssuntoJudicial: idAssuntoJudicial,
                    idClasse: idClasse,
                    idFonteDadosCodex: idFonteDadosCodex,
                    idOrgaoJulgador: idOrgaoJulgador,
                    instancia: instancia,
                    nomeParte: nomeParte,
                    nomeRepresentante: nomeRepresentante,
                    numeroHistorico: numeroHistorico,
                    numeroProcesso: numeroProcesso,
                    numeroProcessoSintetico: numeroProcessoSintetico,
                    oabRepresentante: oabRepresentante,
                    outroNomeParte: outroNomeParte,
                    poloParte: poloParte,
                    searchAfter: searchAfter,
                    segmentoJustica: segmentoJustica,
                    situacaoAtual: situacaoAtual,
                    situacaoParte: situacaoParte,
                    tipoOperacao: tipoOperacao,
                    tribunal: tribunal);

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
                                operationId: "ConsultaProfunda",
                                methodName: "ConsultaProfundaAsync",
                                pathTemplate: "\"/api/v1/processos\"",
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
                                operationId: "ConsultaProfunda",
                                methodName: "ConsultaProfundaAsync",
                                pathTemplate: "\"/api/v1/processos\"",
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
                                operationId: "ConsultaProfunda",
                                methodName: "ConsultaProfundaAsync",
                                pathTemplate: "\"/api/v1/processos\"",
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
                ProcessConsultaProfundaResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "ConsultaProfunda",
                                methodName: "ConsultaProfundaAsync",
                                pathTemplate: "\"/api/v1/processos\"",
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
                                operationId: "ConsultaProfunda",
                                methodName: "ConsultaProfundaAsync",
                                pathTemplate: "\"/api/v1/processos\"",
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
                                ProcessConsultaProfundaResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseTramiteInfoProcessoOpenSearch.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseTramiteInfoProcessoOpenSearch>(
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

                                    var __value = await global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseTramiteInfoProcessoOpenSearch.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseTramiteInfoProcessoOpenSearch>(
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