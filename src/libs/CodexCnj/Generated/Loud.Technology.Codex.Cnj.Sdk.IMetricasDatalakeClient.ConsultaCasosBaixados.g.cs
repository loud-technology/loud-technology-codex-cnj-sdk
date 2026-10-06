#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface IMetricasDatalakeClient
    {
        /// <summary>
        /// Busca de processos por situações, fase e no período de 12 meses anteriores a partir da data atual.<br/>
        /// "Filtros: fase: Conhecimento; Período: 12 meses anteriores a partir da data atual; Situações: Arquivado definitivamente, Baixado definitivamente, Distribuição cancelada, Remetido,  Execução não criminal, Liquidação iniciada, Fase processual iniciada, Remetido em grau de recurso 
        /// </summary>
        /// <param name="anoReferencia"></param>
        /// <param name="searchAfter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseProcessoMetricaCasosBaixadosOpenSearch> ConsultaCasosBaixadosAsync(
            string? anoReferencia = default,
            string? searchAfter = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Busca de processos por situações, fase e no período de 12 meses anteriores a partir da data atual.<br/>
        /// "Filtros: fase: Conhecimento; Período: 12 meses anteriores a partir da data atual; Situações: Arquivado definitivamente, Baixado definitivamente, Distribuição cancelada, Remetido,  Execução não criminal, Liquidação iniciada, Fase processual iniciada, Remetido em grau de recurso 
        /// </summary>
        /// <param name="anoReferencia"></param>
        /// <param name="searchAfter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseProcessoMetricaCasosBaixadosOpenSearch>> ConsultaCasosBaixadosAsResponseAsync(
            string? anoReferencia = default,
            string? searchAfter = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}