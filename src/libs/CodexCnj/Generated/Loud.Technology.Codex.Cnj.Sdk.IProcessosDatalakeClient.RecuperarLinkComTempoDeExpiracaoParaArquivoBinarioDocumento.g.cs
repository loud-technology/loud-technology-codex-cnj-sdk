#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface IProcessosDatalakeClient
    {
        /// <summary>
        /// Retorna uma url temporária, para download do documento binario do processo, pelo idProcesso ou numeroProcesso e pelo idDocumento <br/>
        /// Retorna uma url temporária, para download do documento binario do processo, pelo idProcesso ou numeroProcesso e pelo idDocumento. Em cache miss, retorna 202 + Retry-After: o cache esta sendo populado em background, cliente deve re-chamar apos N segundos.
        /// </summary>
        /// <param name="idDocumento"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RecuperarLinkComTempoDeExpiracaoParaArquivoBinarioDocumentoAsync(
            string idDocumento,
            string numeroProcesso,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Retorna uma url temporária, para download do documento binario do processo, pelo idProcesso ou numeroProcesso e pelo idDocumento <br/>
        /// Retorna uma url temporária, para download do documento binario do processo, pelo idProcesso ou numeroProcesso e pelo idDocumento. Em cache miss, retorna 202 + Retry-After: o cache esta sendo populado em background, cliente deve re-chamar apos N segundos.
        /// </summary>
        /// <param name="idDocumento"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<string>> RecuperarLinkComTempoDeExpiracaoParaArquivoBinarioDocumentoAsResponseAsync(
            string idDocumento,
            string numeroProcesso,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}