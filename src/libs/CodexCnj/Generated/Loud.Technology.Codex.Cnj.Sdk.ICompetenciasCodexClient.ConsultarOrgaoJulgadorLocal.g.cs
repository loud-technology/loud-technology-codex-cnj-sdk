#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface ICompetenciasCodexClient
    {
        /// <summary>
        /// Esse endpoint recupera lista de orgão julgador local a partir do atributo id do orgão julgador local<br/>
        /// Esse endpoint recupera lista de orgão julgador local a partir do atributo id do orgão julgador local. Proxy do endpoint do serviço Codex: /rest/orgaoJulgadorLocal/{id}
        /// </summary>
        /// <param name="orgaoJulgadorLocalId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ConsultarOrgaoJulgadorLocalAsync(
            string orgaoJulgadorLocalId,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Esse endpoint recupera lista de orgão julgador local a partir do atributo id do orgão julgador local<br/>
        /// Esse endpoint recupera lista de orgão julgador local a partir do atributo id do orgão julgador local. Proxy do endpoint do serviço Codex: /rest/orgaoJulgadorLocal/{id}
        /// </summary>
        /// <param name="orgaoJulgadorLocalId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<string>> ConsultarOrgaoJulgadorLocalAsResponseAsync(
            string orgaoJulgadorLocalId,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}