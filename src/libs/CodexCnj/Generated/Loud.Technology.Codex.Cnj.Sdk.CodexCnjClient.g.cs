
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// Versão: v1.7.30<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class CodexCnjClient : global::Loud.Technology.Codex.Cnj.Sdk.ICodexCnjClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://api-processo.data-lake.pdpj.jus.br/processo-api";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Loud.Technology.Codex.Cnj.Sdk.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif

        /// <inheritdoc/>
        public global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKClientOptions Options { get; }

        internal global::System.Lazy<global::System.Text.Json.Serialization.JsonSerializerContext> JsonSerializerContextProvider { get; set; } = new(() => global::Loud.Technology.Codex.Cnj.Sdk.SourceGenerationContext.Default);

        /// <summary>
        /// 
        /// </summary>
        public global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext
        {
            get => JsonSerializerContextProvider.Value;
            set => JsonSerializerContextProvider = new(() => value);
        }


        /// <summary>
        /// Auditoria Controller.
        /// </summary>
        public AuditoriaClient Auditoria => new AuditoriaClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Competencia Codex Controller.
        /// </summary>
        public CompetenciasCodexClient CompetenciasCodex => new CompetenciasCodexClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Indicadores Controller.
        /// </summary>
        public IndicadoresClient Indicadores => new IndicadoresClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Metrica Controller.
        /// </summary>
        public MetricasDatalakeClient MetricasDatalake => new MetricasDatalakeClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Mtd Controller.
        /// </summary>
        public MtdClient Mtd => new MtdClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Precedente Controller.
        /// </summary>
        public PrecedentesClient Precedentes => new PrecedentesClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Processo Controller.
        /// </summary>
        public ProcessosDatalakeClient ProcessosDatalake => new ProcessosDatalakeClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Processo Interno Controller.
        /// </summary>
        public ProcessosDatalakeInternoClient ProcessosDatalakeInterno => new ProcessosDatalakeInternoClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Processo Refinado Controller.
        /// </summary>
        public ProcessosDatalakeRefinadoClient ProcessosDatalakeRefinado => new ProcessosDatalakeRefinadoClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Saneamento Controller.
        /// </summary>
        public SaneamentoClient Saneamento => new SaneamentoClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Situacao Fase Processual Controller.
        /// </summary>
        public SituacaoFaseProcessualClient SituacaoFaseProcessual => new SituacaoFaseProcessualClient(HttpClient, baseUri: null, authorizations: Authorizations, options: Options)
        {
            ReadResponseAsString = ReadResponseAsString,
            JsonSerializerContextProvider = JsonSerializerContextProvider,
        };

        /// <summary>
        /// Creates a new instance of the CodexCnjClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public CodexCnjClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Loud.Technology.Codex.Cnj.Sdk.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri,
                authorizations,
                options: null,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the CodexCnjClient with explicit options but no base URL override.
        /// Skips passing <c>baseUri</c> so the default base URL from the OpenAPI spec applies.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public CodexCnjClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Collections.Generic.List<global::Loud.Technology.Codex.Cnj.Sdk.EndPointAuthorization>? authorizations,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKClientOptions? options,
            bool disposeHttpClient = true) : this(
                httpClient,
                baseUri: null,
                authorizations,
                options,
                disposeHttpClient: disposeHttpClient)
        {
        }

        /// <summary>
        /// Creates a new instance of the CodexCnjClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public CodexCnjClient(
            global::System.Net.Http.HttpClient? httpClient,
            global::System.Uri? baseUri,
            global::System.Collections.Generic.List<global::Loud.Technology.Codex.Cnj.Sdk.EndPointAuthorization>? authorizations,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKClientOptions? options,
            bool disposeHttpClient = true)
        {

            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Loud.Technology.Codex.Cnj.Sdk.EndPointAuthorization>();
            Options = options ?? new global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKClientOptions();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}