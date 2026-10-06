#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface IMtdClient
    {
        /// <summary>
        /// Consulta o modelo de transferência de dados (MTD) de um processo<br/>
        /// Esse endpoint consulta o modelo de transferência de dados (MTD) de um processo. Proxy do endpoint do serviço MTD: api/processos/{numeroProcesso}/mtd
        /// </summary>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> RecuperarMTDDeProcessoValidadorAsync(
            string numeroProcesso,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Consulta o modelo de transferência de dados (MTD) de um processo<br/>
        /// Esse endpoint consulta o modelo de transferência de dados (MTD) de um processo. Proxy do endpoint do serviço MTD: api/processos/{numeroProcesso}/mtd
        /// </summary>
        /// <param name="numeroProcesso"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<string>> RecuperarMTDDeProcessoValidadorAsResponseAsync(
            string numeroProcesso,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}