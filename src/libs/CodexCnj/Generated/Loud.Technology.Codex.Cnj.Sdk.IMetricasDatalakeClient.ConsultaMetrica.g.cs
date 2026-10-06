#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface IMetricasDatalakeClient
    {
        /// <summary>
        ///  Busca de processos por situação, fase e quantidade de dias<br/>
        /// Busca para registros de processos através de filtros para os campos indexados. A paginação é sequencial.
        /// </summary>
        /// <param name="anoReferencia"></param>
        /// <param name="fase"></param>
        /// <param name="quantidadeDeDias"></param>
        /// <param name="searchAfter"></param>
        /// <param name="situacaoAtual"></param>
        /// <param name="tribunal"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseTramitacaoMetricaOpenSearch> ConsultaMetricaAsync(
            string quantidadeDeDias,
            string? anoReferencia = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaMetricaFase? fase = default,
            string? searchAfter = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaMetricaSituacaoAtual? situacaoAtual = default,
            string? tribunal = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        ///  Busca de processos por situação, fase e quantidade de dias<br/>
        /// Busca para registros de processos através de filtros para os campos indexados. A paginação é sequencial.
        /// </summary>
        /// <param name="anoReferencia"></param>
        /// <param name="fase"></param>
        /// <param name="quantidadeDeDias"></param>
        /// <param name="searchAfter"></param>
        /// <param name="situacaoAtual"></param>
        /// <param name="tribunal"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseTramitacaoMetricaOpenSearch>> ConsultaMetricaAsResponseAsync(
            string quantidadeDeDias,
            string? anoReferencia = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaMetricaFase? fase = default,
            string? searchAfter = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaMetricaSituacaoAtual? situacaoAtual = default,
            string? tribunal = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}