#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface ICompetenciasCodexClient
    {
        /// <summary>
        /// Esse endpoint recupera lista de jurisdição a partir do id da jurisdição local<br/>
        /// Esse endpoint recupera lista de jurisdição a partir do id da jurisdição local. Proxy do endpoint do serviço Codex: /rest/jurisdicaoLocal/{id}
        /// </summary>
        /// <param name="jurisdicaoLocalId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ConsultarJurisdicaoAsync(
            string jurisdicaoLocalId,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Esse endpoint recupera lista de jurisdição a partir do id da jurisdição local<br/>
        /// Esse endpoint recupera lista de jurisdição a partir do id da jurisdição local. Proxy do endpoint do serviço Codex: /rest/jurisdicaoLocal/{id}
        /// </summary>
        /// <param name="jurisdicaoLocalId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<string>> ConsultarJurisdicaoAsResponseAsync(
            string jurisdicaoLocalId,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}