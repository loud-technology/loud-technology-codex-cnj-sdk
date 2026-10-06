#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface ISaneamentoClient
    {
        /// <summary>
        /// Consulta o arquivo de saneamento de um processo<br/>
        /// Esse endpoint consulta o arquivo de saneamento de um processo.
        /// </summary>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RecuperarArquivoDeSaneamentoDeProcessoAsync(
            string numeroProcesso,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Consulta o arquivo de saneamento de um processo<br/>
        /// Esse endpoint consulta o arquivo de saneamento de um processo.
        /// </summary>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<string>> RecuperarArquivoDeSaneamentoDeProcessoAsResponseAsync(
            string numeroProcesso,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}