#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    public partial interface IProcessosDatalakeClient
    {
        /// <summary>
        /// Busca de processos através de filtros<br/>
        /// Busca para registros de processos através de filtros para os campos indexados. A paginação é sequencial.
        /// </summary>
        /// <param name="campoOrdenacao"></param>
        /// <param name="cpfCnpjParte"></param>
        /// <param name="cpfRepresentante"></param>
        /// <param name="dataHoraAtualizacaoFim"></param>
        /// <param name="dataHoraAtualizacaoInicio"></param>
        /// <param name="dataHoraPrimeiroAjuizamentoFim"></param>
        /// <param name="dataHoraPrimeiroAjuizamentoInicio"></param>
        /// <param name="fase"></param>
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
        /// <param name="searchAfter"></param>
        /// <param name="segmentoJustica"></param>
        /// <param name="situacaoAtual"></param>
        /// <param name="situacaoParte"></param>
        /// <param name="tipoOperacao"></param>
        /// <param name="tribunal"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseTramiteInfoProcessoOpenSearch> ConsultaProfundaAsync(
            string? campoOrdenacao = default,
            string? cpfCnpjParte = default,
            string? cpfRepresentante = default,
            string? dataHoraAtualizacaoFim = default,
            string? dataHoraAtualizacaoInicio = default,
            string? dataHoraPrimeiroAjuizamentoFim = default,
            string? dataHoraPrimeiroAjuizamentoInicio = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaFase? fase = default,
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
            string? searchAfter = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaSegmentoJustica? segmentoJustica = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaSituacaoAtual? situacaoAtual = default,
            string? situacaoParte = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaTipoOperacao? tipoOperacao = default,
            string? tribunal = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Busca de processos através de filtros<br/>
        /// Busca para registros de processos através de filtros para os campos indexados. A paginação é sequencial.
        /// </summary>
        /// <param name="campoOrdenacao"></param>
        /// <param name="cpfCnpjParte"></param>
        /// <param name="cpfRepresentante"></param>
        /// <param name="dataHoraAtualizacaoFim"></param>
        /// <param name="dataHoraAtualizacaoInicio"></param>
        /// <param name="dataHoraPrimeiroAjuizamentoFim"></param>
        /// <param name="dataHoraPrimeiroAjuizamentoInicio"></param>
        /// <param name="fase"></param>
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
        /// <param name="searchAfter"></param>
        /// <param name="segmentoJustica"></param>
        /// <param name="situacaoAtual"></param>
        /// <param name="situacaoParte"></param>
        /// <param name="tipoOperacao"></param>
        /// <param name="tribunal"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loud.Technology.Codex.Cnj.Sdk.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKHttpResponse<global::Loud.Technology.Codex.Cnj.Sdk.CustomSearchAfterResponseTramiteInfoProcessoOpenSearch>> ConsultaProfundaAsResponseAsync(
            string? campoOrdenacao = default,
            string? cpfCnpjParte = default,
            string? cpfRepresentante = default,
            string? dataHoraAtualizacaoFim = default,
            string? dataHoraAtualizacaoInicio = default,
            string? dataHoraPrimeiroAjuizamentoFim = default,
            string? dataHoraPrimeiroAjuizamentoInicio = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaFase? fase = default,
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
            string? searchAfter = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaSegmentoJustica? segmentoJustica = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaSituacaoAtual? situacaoAtual = default,
            string? situacaoParte = default,
            global::Loud.Technology.Codex.Cnj.Sdk.ConsultaProfundaTipoOperacao? tipoOperacao = default,
            string? tribunal = default,
            global::Loud.Technology.Codex.Cnj.Sdk.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}