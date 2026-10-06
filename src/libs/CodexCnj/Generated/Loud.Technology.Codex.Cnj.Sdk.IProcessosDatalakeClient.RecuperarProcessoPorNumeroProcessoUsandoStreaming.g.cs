#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface IProcessosDatalakeClient
    {
        /// <summary>
        /// Em caráter EXPERIMENTAL - Busca detalhes do processo pelo número do processo. O retorno é feito por streaming<br/>
        /// Em caráter EXPERIMENTAL - Busca detalhes do processo pelo número do processo. O retorno é feito por streaming
        /// </summary>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.StreamingResponseBody> RecuperarProcessoPorNumeroProcessoUsandoStreamingAsync(
            string numeroProcesso,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Em caráter EXPERIMENTAL - Busca detalhes do processo pelo número do processo. O retorno é feito por streaming<br/>
        /// Em caráter EXPERIMENTAL - Busca detalhes do processo pelo número do processo. O retorno é feito por streaming
        /// </summary>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Codex.Cnj.Sdk.StreamingResponseBody>> RecuperarProcessoPorNumeroProcessoUsandoStreamingAsResponseAsync(
            string numeroProcesso,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}