#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface IMetricasDatalakeClient
    {
        /// <summary>
        /// Busca de processos por situações, fase e no período de 12 meses anteriores a partir da data atual.<br/>
        /// Filtros: fase: Conhecimento; Período: 12 meses anteriores a partir da data atual; Situações: Pendente, Denúncia/queixa recebida, Distribuído, Execução não criminal iniciada, Recebido pelo Tribunal, Fase processual iniciada, Classe evoluída para ação penal, Liquidação iniciada, Ato infracional iniciado, Classe evoluída para ato infracional.
        /// </summary>
        /// <param name="anoReferencia"></param>
        /// <param name="searchAfter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseProcessoMetricaCasosNovosOpenSearch> ConsultaCasosNovosAsync(
            string? anoReferencia = default,
            string? searchAfter = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Busca de processos por situações, fase e no período de 12 meses anteriores a partir da data atual.<br/>
        /// Filtros: fase: Conhecimento; Período: 12 meses anteriores a partir da data atual; Situações: Pendente, Denúncia/queixa recebida, Distribuído, Execução não criminal iniciada, Recebido pelo Tribunal, Fase processual iniciada, Classe evoluída para ação penal, Liquidação iniciada, Ato infracional iniciado, Classe evoluída para ato infracional.
        /// </summary>
        /// <param name="anoReferencia"></param>
        /// <param name="searchAfter"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseProcessoMetricaCasosNovosOpenSearch>> ConsultaCasosNovosAsResponseAsync(
            string? anoReferencia = default,
            string? searchAfter = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}