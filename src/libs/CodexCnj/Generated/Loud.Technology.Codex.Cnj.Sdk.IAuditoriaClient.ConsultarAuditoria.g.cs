#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface IAuditoriaClient
    {
        /// <summary>
        /// Consultar Auditoria
        /// </summary>
        /// <param name="dataHoraConclusao"></param>
        /// <param name="dataHoraInicio"></param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="size">
        /// Default Value: 5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.CustomPageResponseAuditoriaDTO> ConsultarAuditoriaAsync(
            string? dataHoraConclusao = default,
            string? dataHoraInicio = default,
            int? page = default,
            int? size = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Consultar Auditoria
        /// </summary>
        /// <param name="dataHoraConclusao"></param>
        /// <param name="dataHoraInicio"></param>
        /// <param name="page">
        /// Default Value: 0
        /// </param>
        /// <param name="size">
        /// Default Value: 5
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Codex.Cnj.Sdk.CustomPageResponseAuditoriaDTO>> ConsultarAuditoriaAsResponseAsync(
            string? dataHoraConclusao = default,
            string? dataHoraInicio = default,
            int? page = default,
            int? size = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}