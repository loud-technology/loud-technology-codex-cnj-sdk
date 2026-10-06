#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface ISituacaoFaseProcessualClient
    {
        /// <summary>
        /// Consulta o extrato da situação processual de um processo<br/>
        /// Esse endpoint consulta o extrato da situação processual de um processo. Proxy do endpoint do serviço situacao-processual: api/processos/{numeroProcesso}/situacoes
        /// </summary>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RecuperarExtratoSituacaoProcessualAsync(
            string numeroProcesso,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Consulta o extrato da situação processual de um processo<br/>
        /// Esse endpoint consulta o extrato da situação processual de um processo. Proxy do endpoint do serviço situacao-processual: api/processos/{numeroProcesso}/situacoes
        /// </summary>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<string>> RecuperarExtratoSituacaoProcessualAsResponseAsync(
            string numeroProcesso,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}