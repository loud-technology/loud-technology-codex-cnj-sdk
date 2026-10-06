#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface ICompetenciasCodexClient
    {
        /// <summary>
        /// Esse endpoint recupera lista de jurisdição a partir dos atributos tribunal e instância<br/>
        /// Esse endpoint recupera lista de jurisdição a partir dos atributos tribunal e instância. Proxy do endpoint do serviço Codex: /rest/jurisdicaoLocal/recuperar/{orgaoJusticaId}/{instancia}
        /// </summary>
        /// <param name="classeId"></param>
        /// <param name="instancia"></param>
        /// <param name="orgaoJusticaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ConsultarJurisdicao1Async(
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultarJurisdicao1Instancia instancia,
            string orgaoJusticaId,
            string? classeId = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Esse endpoint recupera lista de jurisdição a partir dos atributos tribunal e instância<br/>
        /// Esse endpoint recupera lista de jurisdição a partir dos atributos tribunal e instância. Proxy do endpoint do serviço Codex: /rest/jurisdicaoLocal/recuperar/{orgaoJusticaId}/{instancia}
        /// </summary>
        /// <param name="classeId"></param>
        /// <param name="instancia"></param>
        /// <param name="orgaoJusticaId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<string>> ConsultarJurisdicao1AsResponseAsync(
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultarJurisdicao1Instancia instancia,
            string orgaoJusticaId,
            string? classeId = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}