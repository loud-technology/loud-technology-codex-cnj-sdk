#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface ICompetenciasCodexClient
    {
        /// <summary>
        /// Recupera lista de Competência por jurisdicaoLocalId, classeId e assuntoId<br/>
        /// Recupera lista de Competência filtrada por jurisdicaoLocalId, classeId e assuntoId. Proxy do endpoint do serviço Codex: /rest/competenciaLocal/recuperar/{jurisdicaoLocalId}/{classeId}
        /// </summary>
        /// <param name="assuntoId"></param>
        /// <param name="classeId"></param>
        /// <param name="jurisdicaoLocalId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ConsultarCompetenciaAsync(
            global::System.Collections.Generic.IList<int> assuntoId,
            string classeId,
            string jurisdicaoLocalId,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recupera lista de Competência por jurisdicaoLocalId, classeId e assuntoId<br/>
        /// Recupera lista de Competência filtrada por jurisdicaoLocalId, classeId e assuntoId. Proxy do endpoint do serviço Codex: /rest/competenciaLocal/recuperar/{jurisdicaoLocalId}/{classeId}
        /// </summary>
        /// <param name="assuntoId"></param>
        /// <param name="classeId"></param>
        /// <param name="jurisdicaoLocalId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<string>> ConsultarCompetenciaAsResponseAsync(
            global::System.Collections.Generic.IList<int> assuntoId,
            string classeId,
            string jurisdicaoLocalId,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}