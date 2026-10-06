#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface IProcessosDatalakeClient
    {
        /// <summary>
        /// Busca o total de registros de processo através de filtros<br/>
        /// Busca o total de registros de processo através de filtros para os campos indexados
        /// </summary>
        /// <param name="cpfCnpjParte"></param>
        /// <param name="cpfRepresentante"></param>
        /// <param name="dataHoraAtualizacaoFim"></param>
        /// <param name="dataHoraAtualizacaoInicio"></param>
        /// <param name="dataHoraPrimeiroAjuizamentoFim"></param>
        /// <param name="dataHoraPrimeiroAjuizamentoInicio"></param>
        /// <param name="href"></param>
        /// <param name="id"></param>
        /// <param name="idAssuntoJudicial"></param>
        /// <param name="idClasse"></param>
        /// <param name="idFonteDadosCodex"></param>
        /// <param name="idOrgaoJulgador"></param>
        /// <param name="instancia"></param>
        /// <param name="nomeParte"></param>
        /// <param name="nomeRepresentante"></param>
        /// <param name="numeroHistorico"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="numeroProcessoSintetico"></param>
        /// <param name="oabRepresentante"></param>
        /// <param name="outroNomeParte"></param>
        /// <param name="poloParte"></param>
        /// <param name="segmentoJustica"></param>
        /// <param name="situacaoParte"></param>
        /// <param name="tribunal"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ContadorProcessosAsync(
            string? cpfCnpjParte = default,
            string? cpfRepresentante = default,
            string? dataHoraAtualizacaoFim = default,
            string? dataHoraAtualizacaoInicio = default,
            string? dataHoraPrimeiroAjuizamentoFim = default,
            string? dataHoraPrimeiroAjuizamentoInicio = default,
            string? href = default,
            string? id = default,
            string? idAssuntoJudicial = default,
            string? idClasse = default,
            string? idFonteDadosCodex = default,
            global::System.Collections.Generic.IList<long>? idOrgaoJulgador = default,
            string? instancia = default,
            string? nomeParte = default,
            string? nomeRepresentante = default,
            string? numeroHistorico = default,
            string? numeroProcesso = default,
            string? numeroProcessoSintetico = default,
            string? oabRepresentante = default,
            string? outroNomeParte = default,
            string? poloParte = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ContadorProcessosSegmentoJustica? segmentoJustica = default,
            string? situacaoParte = default,
            string? tribunal = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Busca o total de registros de processo através de filtros<br/>
        /// Busca o total de registros de processo através de filtros para os campos indexados
        /// </summary>
        /// <param name="cpfCnpjParte"></param>
        /// <param name="cpfRepresentante"></param>
        /// <param name="dataHoraAtualizacaoFim"></param>
        /// <param name="dataHoraAtualizacaoInicio"></param>
        /// <param name="dataHoraPrimeiroAjuizamentoFim"></param>
        /// <param name="dataHoraPrimeiroAjuizamentoInicio"></param>
        /// <param name="href"></param>
        /// <param name="id"></param>
        /// <param name="idAssuntoJudicial"></param>
        /// <param name="idClasse"></param>
        /// <param name="idFonteDadosCodex"></param>
        /// <param name="idOrgaoJulgador"></param>
        /// <param name="instancia"></param>
        /// <param name="nomeParte"></param>
        /// <param name="nomeRepresentante"></param>
        /// <param name="numeroHistorico"></param>
        /// <param name="numeroProcesso"></param>
        /// <param name="numeroProcessoSintetico"></param>
        /// <param name="oabRepresentante"></param>
        /// <param name="outroNomeParte"></param>
        /// <param name="poloParte"></param>
        /// <param name="segmentoJustica"></param>
        /// <param name="situacaoParte"></param>
        /// <param name="tribunal"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<string>> ContadorProcessosAsResponseAsync(
            string? cpfCnpjParte = default,
            string? cpfRepresentante = default,
            string? dataHoraAtualizacaoFim = default,
            string? dataHoraAtualizacaoInicio = default,
            string? dataHoraPrimeiroAjuizamentoFim = default,
            string? dataHoraPrimeiroAjuizamentoInicio = default,
            string? href = default,
            string? id = default,
            string? idAssuntoJudicial = default,
            string? idClasse = default,
            string? idFonteDadosCodex = default,
            global::System.Collections.Generic.IList<long>? idOrgaoJulgador = default,
            string? instancia = default,
            string? nomeParte = default,
            string? nomeRepresentante = default,
            string? numeroHistorico = default,
            string? numeroProcesso = default,
            string? numeroProcessoSintetico = default,
            string? oabRepresentante = default,
            string? outroNomeParte = default,
            string? poloParte = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ContadorProcessosSegmentoJustica? segmentoJustica = default,
            string? situacaoParte = default,
            string? tribunal = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}