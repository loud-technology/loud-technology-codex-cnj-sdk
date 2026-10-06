
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TramitacaoOpenSearch
    {
        /// <summary>
        /// Identificador da tramitação na origem. Exemplo: "67890".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idOrigem")]
        public string? IdOrigem { get; set; }

        /// <summary>
        /// Identificador da tramitação no Codex. Exemplo: 12345678.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idCodex")]
        public long? IdCodex { get; set; }

        /// <summary>
        /// Identificador da fonte de dados no Codex. Exemplos: 1; 12; 123; 12345.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idFonteDadosCodex")]
        public long? IdFonteDadosCodex { get; set; }

        /// <summary>
        /// Refere-se à data da última atualização feita no Codex, considerando a sincronização das diferentes tabelas (processo, partes, movimentos, documentos). Exemplo: "2023-01-01T12:00:00". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHoraUltimaAtualizacaoCodex")]
        public string? DataHoraUltimaAtualizacaoCodex { get; set; }

        /// <summary>
        /// Data e hora do ajuizamento da tramitação. Exemplo: "2023-01-01T12:00:00".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHoraAjuizamento")]
        public string? DataHoraAjuizamento { get; set; }

        /// <summary>
        /// Data da baixa da tramitação. Exemplo: "2023-01-01T12:00:00".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataBaixa")]
        public string? DataBaixa { get; set; }

        /// <summary>
        /// Data da distribuição da tramitação. Exemplo: \"2023-01-01T12:00:00\".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataDistribuicao")]
        public string? DataDistribuicao { get; set; }

        /// <summary>
        /// Data da sentença da tramitação. Exemplo: "2023-01-01T12:00:00".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSentenca")]
        public string? DataSentenca { get; set; }

        /// <summary>
        /// Data da suspensão da tramitação. Exemplo: "2023-01-01T12:00:00".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataSuspensao")]
        public string? DataSuspensao { get; set; }

        /// <summary>
        /// Descrição do tipo de justiça em que tramita o processo, podendo assumir um dos seguintes domínios: ‘COMUM’, ’ESPECIAL’ ou ‘INDEFINIDO’.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoJustica")]
        public string? TipoJustica { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tribunal")]
        public global::Loud.Technology.Codex.Cnj.Sdk.TribunalOpenSearch? Tribunal { get; set; }

        /// <summary>
        /// Número histórico que identifica de forma única a tramitação do processo dentro do sistema do Supremo Tribunal Federal (STF). Exemplo: "HC-244185". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroHistorico")]
        public string? NumeroHistorico { get; set; }

        /// <summary>
        /// Identificação da instância do órgão julgador em relação à tramitação do processo. Os domínios podem ser: PRIMEIRO_GRAU (referente à primeira instância dos tribunais), SEGUNDO_GRAU (referente à segunda instância dos Tribunais e Conselho da Justiça Federal), TERCEIRO_GRAU (Tribunais Superiores) e QUARTO_GRAU (Conselho Nacional de Justiça e Supremo Tribunal Federal).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instancia")]
        public string? Instancia { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dadosCompetencia")]
        public global::Loud.Technology.Codex.Cnj.Sdk.CompetenciaOpenSearch? DadosCompetencia { get; set; }

        /// <summary>
        /// Identificação do tipo de processo em relação à tramitação, podendo ser ORIGINÁRIO ou RECURSAL.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoProcesso")]
        public string? TipoProcesso { get; set; }

        /// <summary>
        /// Identificação do tipo de prioridade em relação à tramitação.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoPrioridade")]
        public string? TipoPrioridade { get; set; }

        /// <summary>
        /// Natureza da tramitação. Exemplos: "CRIMINAL", "CÍVEL".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("natureza")]
        public string? Natureza { get; set; }

        /// <summary>
        /// Indica se há liminar. Valores permitidos: true, false. Exemplo: false. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("liminar")]
        public bool? Liminar { get; set; }

        /// <summary>
        /// Indica se há justiça gratuita. Valores permitidos: true, false. Exemplo: true. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("justicaGratuita")]
        public bool? JusticaGratuita { get; set; }

        /// <summary>
        /// Nível de sigilo a ser aplicado à tramitação, devendo ser: 0: públicos, acessíveis a todos os servidores do Judiciário e dos demais órgãos públicos de colaboração na administração da Justiça, assim como aos advogados e a qualquer cidadão; 1: segredo de justiça, acessíveis aos servidores do Judiciário, aos servidores dos órgãos públicos de colaboração na administração da Justiça e às partes do processo; 2: sigilo mínimo, acessível aos servidores do Judiciário e aos demais órgãos públicos de colaboração na administração da Justiça; 3: sigilo médio, acessível aos servidores do órgão em que tramita o processo, à(s) parte(s) que provocou(ram) o incidente e àqueles que forem expressamente incluídos; 4: sigilo intenso, acessível a classes de servidores qualificados (magistrado, diretor de secretaria/escrivão, oficial de gabinete/assessor) do órgão em que tramita o processo, às partes que provocaram o incidente e àqueles que forem expressamente incluídos; 5: sigilo absoluto, acessível apenas ao magistrado do órgão em que tramita, aos servidores e demais usuários por ele indicado e às partes que provocaram o incidente.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nivelSigilo")]
        public long? NivelSigilo { get; set; }

        /// <summary>
        /// Valor da ação. Exemplo: 15000.00. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valorAcao")]
        public double? ValorAcao { get; set; }

        /// <summary>
        /// Valor das custas finais. Exemplo: 15000.00. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custasFinais")]
        public double? CustasFinais { get; set; }

        /// <summary>
        /// Valor das custas inicias. Exemplo: 15000.00. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custasIniciais")]
        public double? CustasIniciais { get; set; }

        /// <summary>
        /// Valor das custas recolhidas. Exemplo: 15000.00. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custasRecolhidas")]
        public double? CustasRecolhidas { get; set; }

        /// <summary>
        /// Valor das custas recursais. Exemplo: 15000.00. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("custasRecursais")]
        public double? CustasRecursais { get; set; }

        /// <summary>
        /// Data e hora da última distribuição. Exemplo: "2023-01-01T12:00:00
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHoraUltimaDistribuicao")]
        public string? DataHoraUltimaDistribuicao { get; set; }

        /// <summary>
        /// Dados da classe processual relacionada ao trâmite. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classe")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.ClasseOpenSearch>? Classe { get; set; }

        /// <summary>
        /// Dados do assunto relacionado ao trâmite. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assunto")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.AssuntoOpenSearch>? Assunto { get; set; }

        /// <summary>
        /// Lista de partes relacionadas ao trâmite. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.PartesOpenSearch>? Partes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jurisdicao")]
        public global::Loud.Technology.Codex.Cnj.Sdk.JurisdicaoOpenSearch? Jurisdicao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgaoJulgador")]
        public global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorOpenSearch? OrgaoJulgador { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgaoJulgadorColegiado")]
        public global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorColegiadoOpenSearch? OrgaoJulgadorColegiado { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ultimoMovimento")]
        public global::Loud.Technology.Codex.Cnj.Sdk.UltimoMovimentoOpenSearch? UltimoMovimento { get; set; }

        /// <summary>
        /// Determina se a tramitação está ativa ou não. Valores permitidos: true, false. Exemplo: "true".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ativo")]
        public bool? Ativo { get; set; }

        /// <summary>
        /// Identificador da fase processual. Exemplos: "CONHECIMENTO", "EXECUCAO", "INVALIDO", "INVESTIGATORIA", "NAO_INFORMADO", "OUTRO", "PRE_PROCESSUAL".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fase")]
        public string? Fase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("situacaoAtual")]
        public global::Loud.Technology.Codex.Cnj.Sdk.SituacaoAtual? SituacaoAtual { get; set; }

        /// <summary>
        /// Ano de eleição.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anoEleicao")]
        public string? AnoEleicao { get; set; }

        /// <summary>
        /// Situação de migração.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("situacaoMigracao")]
        public string? SituacaoMigracao { get; set; }

        /// <summary>
        /// Intervenção MP.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("intervencaoMP")]
        public string? IntervencaoMP { get; set; }

        /// <summary>
        /// Juízo 100 Digital.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("juizo100Digital")]
        public string? Juizo100Digital { get; set; }

        /// <summary>
        /// Lista de magistrados dos movimentos da tramitação.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magistrados")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.MagistradoOpenSearch>? Magistrados { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TramitacaoOpenSearch" /> class.
        /// </summary>
        /// <param name="idOrigem">
        /// Identificador da tramitação na origem. Exemplo: "67890".
        /// </param>
        /// <param name="idCodex">
        /// Identificador da tramitação no Codex. Exemplo: 12345678.
        /// </param>
        /// <param name="idFonteDadosCodex">
        /// Identificador da fonte de dados no Codex. Exemplos: 1; 12; 123; 12345.
        /// </param>
        /// <param name="dataHoraUltimaAtualizacaoCodex">
        /// Refere-se à data da última atualização feita no Codex, considerando a sincronização das diferentes tabelas (processo, partes, movimentos, documentos). Exemplo: "2023-01-01T12:00:00". 
        /// </param>
        /// <param name="dataHoraAjuizamento">
        /// Data e hora do ajuizamento da tramitação. Exemplo: "2023-01-01T12:00:00".
        /// </param>
        /// <param name="dataBaixa">
        /// Data da baixa da tramitação. Exemplo: "2023-01-01T12:00:00".
        /// </param>
        /// <param name="dataDistribuicao">
        /// Data da distribuição da tramitação. Exemplo: \"2023-01-01T12:00:00\".
        /// </param>
        /// <param name="dataSentenca">
        /// Data da sentença da tramitação. Exemplo: "2023-01-01T12:00:00".
        /// </param>
        /// <param name="dataSuspensao">
        /// Data da suspensão da tramitação. Exemplo: "2023-01-01T12:00:00".
        /// </param>
        /// <param name="tipoJustica">
        /// Descrição do tipo de justiça em que tramita o processo, podendo assumir um dos seguintes domínios: ‘COMUM’, ’ESPECIAL’ ou ‘INDEFINIDO’.
        /// </param>
        /// <param name="tribunal"></param>
        /// <param name="numeroHistorico">
        /// Número histórico que identifica de forma única a tramitação do processo dentro do sistema do Supremo Tribunal Federal (STF). Exemplo: "HC-244185". 
        /// </param>
        /// <param name="instancia">
        /// Identificação da instância do órgão julgador em relação à tramitação do processo. Os domínios podem ser: PRIMEIRO_GRAU (referente à primeira instância dos tribunais), SEGUNDO_GRAU (referente à segunda instância dos Tribunais e Conselho da Justiça Federal), TERCEIRO_GRAU (Tribunais Superiores) e QUARTO_GRAU (Conselho Nacional de Justiça e Supremo Tribunal Federal).
        /// </param>
        /// <param name="dadosCompetencia"></param>
        /// <param name="tipoProcesso">
        /// Identificação do tipo de processo em relação à tramitação, podendo ser ORIGINÁRIO ou RECURSAL.
        /// </param>
        /// <param name="tipoPrioridade">
        /// Identificação do tipo de prioridade em relação à tramitação.
        /// </param>
        /// <param name="natureza">
        /// Natureza da tramitação. Exemplos: "CRIMINAL", "CÍVEL".
        /// </param>
        /// <param name="liminar">
        /// Indica se há liminar. Valores permitidos: true, false. Exemplo: false. 
        /// </param>
        /// <param name="justicaGratuita">
        /// Indica se há justiça gratuita. Valores permitidos: true, false. Exemplo: true. 
        /// </param>
        /// <param name="nivelSigilo">
        /// Nível de sigilo a ser aplicado à tramitação, devendo ser: 0: públicos, acessíveis a todos os servidores do Judiciário e dos demais órgãos públicos de colaboração na administração da Justiça, assim como aos advogados e a qualquer cidadão; 1: segredo de justiça, acessíveis aos servidores do Judiciário, aos servidores dos órgãos públicos de colaboração na administração da Justiça e às partes do processo; 2: sigilo mínimo, acessível aos servidores do Judiciário e aos demais órgãos públicos de colaboração na administração da Justiça; 3: sigilo médio, acessível aos servidores do órgão em que tramita o processo, à(s) parte(s) que provocou(ram) o incidente e àqueles que forem expressamente incluídos; 4: sigilo intenso, acessível a classes de servidores qualificados (magistrado, diretor de secretaria/escrivão, oficial de gabinete/assessor) do órgão em que tramita o processo, às partes que provocaram o incidente e àqueles que forem expressamente incluídos; 5: sigilo absoluto, acessível apenas ao magistrado do órgão em que tramita, aos servidores e demais usuários por ele indicado e às partes que provocaram o incidente.
        /// </param>
        /// <param name="valorAcao">
        /// Valor da ação. Exemplo: 15000.00. 
        /// </param>
        /// <param name="custasFinais">
        /// Valor das custas finais. Exemplo: 15000.00. 
        /// </param>
        /// <param name="custasIniciais">
        /// Valor das custas inicias. Exemplo: 15000.00. 
        /// </param>
        /// <param name="custasRecolhidas">
        /// Valor das custas recolhidas. Exemplo: 15000.00. 
        /// </param>
        /// <param name="custasRecursais">
        /// Valor das custas recursais. Exemplo: 15000.00. 
        /// </param>
        /// <param name="dataHoraUltimaDistribuicao">
        /// Data e hora da última distribuição. Exemplo: "2023-01-01T12:00:00
        /// </param>
        /// <param name="classe">
        /// Dados da classe processual relacionada ao trâmite. 
        /// </param>
        /// <param name="assunto">
        /// Dados do assunto relacionado ao trâmite. 
        /// </param>
        /// <param name="partes">
        /// Lista de partes relacionadas ao trâmite. 
        /// </param>
        /// <param name="jurisdicao"></param>
        /// <param name="orgaoJulgador"></param>
        /// <param name="orgaoJulgadorColegiado"></param>
        /// <param name="ultimoMovimento"></param>
        /// <param name="ativo">
        /// Determina se a tramitação está ativa ou não. Valores permitidos: true, false. Exemplo: "true".
        /// </param>
        /// <param name="fase">
        /// Identificador da fase processual. Exemplos: "CONHECIMENTO", "EXECUCAO", "INVALIDO", "INVESTIGATORIA", "NAO_INFORMADO", "OUTRO", "PRE_PROCESSUAL".
        /// </param>
        /// <param name="situacaoAtual"></param>
        /// <param name="anoEleicao">
        /// Ano de eleição.
        /// </param>
        /// <param name="situacaoMigracao">
        /// Situação de migração.
        /// </param>
        /// <param name="intervencaoMP">
        /// Intervenção MP.
        /// </param>
        /// <param name="juizo100Digital">
        /// Juízo 100 Digital.
        /// </param>
        /// <param name="magistrados">
        /// Lista de magistrados dos movimentos da tramitação.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TramitacaoOpenSearch(
            string? idOrigem,
            long? idCodex,
            long? idFonteDadosCodex,
            string? dataHoraUltimaAtualizacaoCodex,
            string? dataHoraAjuizamento,
            string? dataBaixa,
            string? dataDistribuicao,
            string? dataSentenca,
            string? dataSuspensao,
            string? tipoJustica,
            global::Loud.Technology.Codex.Cnj.Sdk.TribunalOpenSearch? tribunal,
            string? numeroHistorico,
            string? instancia,
            global::Loud.Technology.Codex.Cnj.Sdk.CompetenciaOpenSearch? dadosCompetencia,
            string? tipoProcesso,
            string? tipoPrioridade,
            string? natureza,
            bool? liminar,
            bool? justicaGratuita,
            long? nivelSigilo,
            double? valorAcao,
            double? custasFinais,
            double? custasIniciais,
            double? custasRecolhidas,
            double? custasRecursais,
            string? dataHoraUltimaDistribuicao,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.ClasseOpenSearch>? classe,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.AssuntoOpenSearch>? assunto,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.PartesOpenSearch>? partes,
            global::Loud.Technology.Codex.Cnj.Sdk.JurisdicaoOpenSearch? jurisdicao,
            global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorOpenSearch? orgaoJulgador,
            global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorColegiadoOpenSearch? orgaoJulgadorColegiado,
            global::Loud.Technology.Codex.Cnj.Sdk.UltimoMovimentoOpenSearch? ultimoMovimento,
            bool? ativo,
            string? fase,
            global::Loud.Technology.Codex.Cnj.Sdk.SituacaoAtual? situacaoAtual,
            string? anoEleicao,
            string? situacaoMigracao,
            string? intervencaoMP,
            string? juizo100Digital,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.MagistradoOpenSearch>? magistrados)
        {
            this.IdOrigem = idOrigem;
            this.IdCodex = idCodex;
            this.IdFonteDadosCodex = idFonteDadosCodex;
            this.DataHoraUltimaAtualizacaoCodex = dataHoraUltimaAtualizacaoCodex;
            this.DataHoraAjuizamento = dataHoraAjuizamento;
            this.DataBaixa = dataBaixa;
            this.DataDistribuicao = dataDistribuicao;
            this.DataSentenca = dataSentenca;
            this.DataSuspensao = dataSuspensao;
            this.TipoJustica = tipoJustica;
            this.Tribunal = tribunal;
            this.NumeroHistorico = numeroHistorico;
            this.Instancia = instancia;
            this.DadosCompetencia = dadosCompetencia;
            this.TipoProcesso = tipoProcesso;
            this.TipoPrioridade = tipoPrioridade;
            this.Natureza = natureza;
            this.Liminar = liminar;
            this.JusticaGratuita = justicaGratuita;
            this.NivelSigilo = nivelSigilo;
            this.ValorAcao = valorAcao;
            this.CustasFinais = custasFinais;
            this.CustasIniciais = custasIniciais;
            this.CustasRecolhidas = custasRecolhidas;
            this.CustasRecursais = custasRecursais;
            this.DataHoraUltimaDistribuicao = dataHoraUltimaDistribuicao;
            this.Classe = classe;
            this.Assunto = assunto;
            this.Partes = partes;
            this.Jurisdicao = jurisdicao;
            this.OrgaoJulgador = orgaoJulgador;
            this.OrgaoJulgadorColegiado = orgaoJulgadorColegiado;
            this.UltimoMovimento = ultimoMovimento;
            this.Ativo = ativo;
            this.Fase = fase;
            this.SituacaoAtual = situacaoAtual;
            this.AnoEleicao = anoEleicao;
            this.SituacaoMigracao = situacaoMigracao;
            this.IntervencaoMP = intervencaoMP;
            this.Juizo100Digital = juizo100Digital;
            this.Magistrados = magistrados;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TramitacaoOpenSearch" /> class.
        /// </summary>
        public TramitacaoOpenSearch()
        {
        }

    }
}