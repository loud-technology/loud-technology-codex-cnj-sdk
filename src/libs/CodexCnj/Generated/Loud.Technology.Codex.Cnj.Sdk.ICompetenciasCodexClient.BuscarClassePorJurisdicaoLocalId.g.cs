#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface ICompetenciasCodexClient
    {
        /// <summary>
        /// Busca a lista de classes pelo id da jurisdição local<br/>
        /// Esse endpoint recupera lista de Classe a partir do atributo jurisdição. Proxy do endpoint do serviço Codex: /rest/classe/recuperar/{jurisdicaoLocalId}
        /// </summary>
        /// <param name="jurisdicaoLocalId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> BuscarClassePorJurisdicaoLocalIdAsync(
            string jurisdicaoLocalId,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Busca a lista de classes pelo id da jurisdição local<br/>
        /// Esse endpoint recupera lista de Classe a partir do atributo jurisdição. Proxy do endpoint do serviço Codex: /rest/classe/recuperar/{jurisdicaoLocalId}
        /// </summary>
        /// <param name="jurisdicaoLocalId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<string>> BuscarClassePorJurisdicaoLocalIdAsResponseAsync(
            string jurisdicaoLocalId,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}