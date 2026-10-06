#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface IProcessosDatalakeInternoClient
    {
        /// <summary>
        /// Busca de processos através de filtros<br/>
        /// Busca para registros de dados mínimos de processos através de filtros para os campos indexados.
        /// </summary>
        /// <param name="cpfCnpj"></param>
        /// <param name="jtr"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.TramiteInfoProcessoOpenSearchMinimo>> ConsultaDadosMinimosAsync(
            string numeroProcesso,
            string? cpfCnpj = default,
            string? jtr = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Busca de processos através de filtros<br/>
        /// Busca para registros de dados mínimos de processos através de filtros para os campos indexados.
        /// </summary>
        /// <param name="cpfCnpj"></param>
        /// <param name="jtr"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.TramiteInfoProcessoOpenSearchMinimo>>> ConsultaDadosMinimosAsResponseAsync(
            string numeroProcesso,
            string? cpfCnpj = default,
            string? jtr = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}