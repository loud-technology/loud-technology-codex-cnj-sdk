#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface IProcessosDatalakeClient
    {
        /// <summary>
        /// Listar URL's para download dos processos judiciais modificados no dia anterior<br/>
        /// Listar URL's para download dos processos judiciais modificados no dia anterior
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ListarURLsProcessosJudiciaisModificadosNoDiaAnteriorAsync(
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Listar URL's para download dos processos judiciais modificados no dia anterior<br/>
        /// Listar URL's para download dos processos judiciais modificados no dia anterior
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<string>> ListarURLsProcessosJudiciaisModificadosNoDiaAnteriorAsResponseAsync(
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}