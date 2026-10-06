#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface IProcessosDatalakeClient
    {
        /// <summary>
        /// Busca LISTA de documentos textual de um processo pelo numeroProcesso e pelo(s) idDocumento(s), limitados a 50 documentos<br/>
        /// Busca LISTA de documentos textual de um processo pelo numeroProcesso e pelo(s) idDocumento(s), limitados a 50 documentos
        /// </summary>
        /// <param name="idDocumento"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RecuperarProcessoComDocumentoTextoAsync(
            string numeroProcesso,
            global::System.Collections.Generic.IList<string>? idDocumento = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Busca LISTA de documentos textual de um processo pelo numeroProcesso e pelo(s) idDocumento(s), limitados a 50 documentos<br/>
        /// Busca LISTA de documentos textual de um processo pelo numeroProcesso e pelo(s) idDocumento(s), limitados a 50 documentos
        /// </summary>
        /// <param name="idDocumento"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<string>> RecuperarProcessoComDocumentoTextoAsResponseAsync(
            string numeroProcesso,
            global::System.Collections.Generic.IList<string>? idDocumento = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}