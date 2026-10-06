
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// Versão: v1.7.30<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ICodexCnjClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Loud.Technology.Codex.Cnj.Sdk.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// Auditoria Controller.
        /// </summary>
        public AuditoriaClient Auditoria { get; }

        /// <summary>
        /// Competencia Codex Controller.
        /// </summary>
        public CompetenciasCodexClient CompetenciasCodex { get; }

        /// <summary>
        /// Indicadores Controller.
        /// </summary>
        public IndicadoresClient Indicadores { get; }

        /// <summary>
        /// Metrica Controller.
        /// </summary>
        public MetricasDatalakeClient MetricasDatalake { get; }

        /// <summary>
        /// Mtd Controller.
        /// </summary>
        public MtdClient Mtd { get; }

        /// <summary>
        /// Precedente Controller.
        /// </summary>
        public PrecedentesClient Precedentes { get; }

        /// <summary>
        /// Processo Controller.
        /// </summary>
        public ProcessosDatalakeClient ProcessosDatalake { get; }

        /// <summary>
        /// Processo Interno Controller.
        /// </summary>
        public ProcessosDatalakeInternoClient ProcessosDatalakeInterno { get; }

        /// <summary>
        /// Processo Refinado Controller.
        /// </summary>
        public ProcessosDatalakeRefinadoClient ProcessosDatalakeRefinado { get; }

        /// <summary>
        /// Saneamento Controller.
        /// </summary>
        public SaneamentoClient Saneamento { get; }

        /// <summary>
        /// Situacao Fase Processual Controller.
        /// </summary>
        public SituacaoFaseProcessualClient SituacaoFaseProcessual { get; }

    }
}