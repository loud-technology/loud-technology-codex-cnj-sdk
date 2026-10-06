#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface ICompetenciasCodexClient
    {
        /// <summary>
        /// Recupera lista de Competência por competenciaLocalId<br/>
        /// Recupera lista de Competência filtrada por competenciaLocalId. Proxy do endpoint do serviço Codex: /rest/competenciaLocal/{id}
        /// </summary>
        /// <param name="competenciaLocalId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ConsultarCompetenciaLocalAsync(
            string competenciaLocalId,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recupera lista de Competência por competenciaLocalId<br/>
        /// Recupera lista de Competência filtrada por competenciaLocalId. Proxy do endpoint do serviço Codex: /rest/competenciaLocal/{id}
        /// </summary>
        /// <param name="competenciaLocalId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<string>> ConsultarCompetenciaLocalAsResponseAsync(
            string competenciaLocalId,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}