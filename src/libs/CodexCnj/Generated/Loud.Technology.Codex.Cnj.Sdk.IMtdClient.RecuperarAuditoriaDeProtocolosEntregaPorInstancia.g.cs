#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface IMtdClient
    {
        /// <summary>
        /// Consulta a auditoria MTD de protocolos de entrega por instancia<br/>
        /// Consulta a auditoria MTD de protocolos de entrega por instancia
        /// </summary>
        /// <param name="instancia"></param>
        /// <param name="mesReferencia"></param>
        /// <param name="tribunal"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.CustomResponseQuantidadeAuditoriaMTDProtocoloDTO> RecuperarAuditoriaDeProtocolosEntregaPorInstanciaAsync(
            string mesReferencia,
            string tribunal,
            string? instancia = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Consulta a auditoria MTD de protocolos de entrega por instancia<br/>
        /// Consulta a auditoria MTD de protocolos de entrega por instancia
        /// </summary>
        /// <param name="instancia"></param>
        /// <param name="mesReferencia"></param>
        /// <param name="tribunal"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Codex.Cnj.Sdk.CustomResponseQuantidadeAuditoriaMTDProtocoloDTO>> RecuperarAuditoriaDeProtocolosEntregaPorInstanciaAsResponseAsync(
            string mesReferencia,
            string tribunal,
            string? instancia = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}