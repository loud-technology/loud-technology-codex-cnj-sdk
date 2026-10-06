#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface IAuditoriaClient
    {
        /// <summary>
        /// Consultar Auditoria Agregada
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="dataHoraConclusao"></param>
        /// <param name="dataHoraInicio"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AuditoriaAgrupadoDTO> ConsultarAuditoriaAgrupadaAsync(
            string clientId,
            string dataHoraConclusao,
            string dataHoraInicio,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Consultar Auditoria Agregada
        /// </summary>
        /// <param name="clientId"></param>
        /// <param name="dataHoraConclusao"></param>
        /// <param name="dataHoraInicio"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Codex.Cnj.Sdk.AuditoriaAgrupadoDTO>> ConsultarAuditoriaAgrupadaAsResponseAsync(
            string clientId,
            string dataHoraConclusao,
            string dataHoraInicio,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}