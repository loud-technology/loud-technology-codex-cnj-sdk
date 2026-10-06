#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface ICompetenciasCodexClient
    {
        /// <summary>
        /// Esse endpoint recupera lista de Assunto a partir do atributo classe<br/>
        /// Esse endpoint recupera lista de Assunto a partir do atributo classe. Proxy do endpoint do serviço Codex: /rest/assunto/recuperar/{jurisdicaoLocalId}/{classeId}
        /// </summary>
        /// <param name="classeId"></param>
        /// <param name="jurisdicaoLocalId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ConsultarAssuntoAsync(
            string classeId,
            string jurisdicaoLocalId,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Esse endpoint recupera lista de Assunto a partir do atributo classe<br/>
        /// Esse endpoint recupera lista de Assunto a partir do atributo classe. Proxy do endpoint do serviço Codex: /rest/assunto/recuperar/{jurisdicaoLocalId}/{classeId}
        /// </summary>
        /// <param name="classeId"></param>
        /// <param name="jurisdicaoLocalId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<string>> ConsultarAssuntoAsResponseAsync(
            string classeId,
            string jurisdicaoLocalId,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}