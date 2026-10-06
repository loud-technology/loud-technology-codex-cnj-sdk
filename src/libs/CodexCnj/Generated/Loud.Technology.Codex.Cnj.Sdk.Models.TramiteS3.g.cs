
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TramiteS3
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
        /// Data e hora do ajuizamento. Exemplo: "2023-01-01T12:00:00
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
        /// identificador do sistema de origem do processo (ex: "PJE", "SEEU", "PROJUDI", "SAJ")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sistemaProcessual")]
        public string? SistemaProcessual { get; set; }

        /// <summary>
        /// classificação do sistema (ex: "JUDICIAL", "ADMINISTRATIVO")
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoSistemaProcessual")]
        public string? TipoSistemaProcessual { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tribunal")]
        public global::Loud.Technology.Codex.Cnj.Sdk.TribunalS3? Tribunal { get; set; }

        /// <summary>
        /// Número histórico que identifica de forma única a tramitação do processo dentro do sistema do Supremo Tribunal Federal (STF). Exemplo: "HC-244185". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroHistorico")]
        public string? NumeroHistorico { get; set; }

        /// <summary>
        /// Refere-se à matéria da tramitação. Delimita a jurisdição de um tribunal ou juiz especificando quais tipos de casos e questões ele tem autoridade para julgar. Exemplos: 'CRIMINAL', "CÍVEL".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("competencia")]
        public string? Competencia { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dadosCompetencia")]
        public global::Loud.Technology.Codex.Cnj.Sdk.CompetenciaS3? DadosCompetencia { get; set; }

        /// <summary>
        /// Identificador da Competencia. Exemplo: 47951. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idCompetencia")]
        public long? IdCompetencia { get; set; }

        /// <summary>
        /// Identificação da instância do órgão julgador em relação à tramitação do processo. Os domínios podem ser: PRIMEIRO_GRAU (referente à primeira instância dos tribunais), SEGUNDO_GRAU (referente à segunda instância dos Tribunais e Conselho da Justiça Federal), TERCEIRO_GRAU (Tribunais Superiores) e QUARTO_GRAU (Conselho Nacional de Justiça e Supremo Tribunal Federal).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instancia")]
        public string? Instancia { get; set; }

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
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.ClasseS3>? Classe { get; set; }

        /// <summary>
        /// Dados do assunto relacionado ao trâmite. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assunto")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.AssuntoS3>? Assunto { get; set; }

        /// <summary>
        /// Lista de partes relacionadas ao trâmite. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.ParteS3>? Partes { get; set; }

        /// <summary>
        /// Lista de distribuições relacionadas ao trâmite. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distribuicoes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.DistribuicoesS3>? Distribuicoes { get; set; }

        /// <summary>
        /// Lista de movimentos associados à tramitação.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("movimentos")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.MovimentoS3>? Movimentos { get; set; }

        /// <summary>
        /// Lista de documentos relacionados ao trâmite. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentos")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.DocumentoS3>? Documentos { get; set; }

        /// <summary>
        /// Lista de processos relacionados ao trâmite. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processosRelacionados")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.ProcessosRelacionadosS3>? ProcessosRelacionados { get; set; }

        /// <summary>
        /// (boolean) Indica se a tramitação está ativa. Valores permitidos: true, false. Exemplo: "false".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ativo")]
        public bool? Ativo { get; set; }

        /// <summary>
        /// (string) Data e hora da exclusão da tramitação. Exemplo: "2023-01-01T12:00:00".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHoraExclusao")]
        public string? DataHoraExclusao { get; set; }

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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TramiteS3" /> class.
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
        /// Data e hora do ajuizamento. Exemplo: "2023-01-01T12:00:00
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
        /// <param name="sistemaProcessual">
        /// identificador do sistema de origem do processo (ex: "PJE", "SEEU", "PROJUDI", "SAJ")
        /// </param>
        /// <param name="tipoSistemaProcessual">
        /// classificação do sistema (ex: "JUDICIAL", "ADMINISTRATIVO")
        /// </param>
        /// <param name="tribunal"></param>
        /// <param name="numeroHistorico">
        /// Número histórico que identifica de forma única a tramitação do processo dentro do sistema do Supremo Tribunal Federal (STF). Exemplo: "HC-244185". 
        /// </param>
        /// <param name="competencia">
        /// Refere-se à matéria da tramitação. Delimita a jurisdição de um tribunal ou juiz especificando quais tipos de casos e questões ele tem autoridade para julgar. Exemplos: 'CRIMINAL', "CÍVEL".
        /// </param>
        /// <param name="dadosCompetencia"></param>
        /// <param name="idCompetencia">
        /// Identificador da Competencia. Exemplo: 47951. 
        /// </param>
        /// <param name="instancia">
        /// Identificação da instância do órgão julgador em relação à tramitação do processo. Os domínios podem ser: PRIMEIRO_GRAU (referente à primeira instância dos tribunais), SEGUNDO_GRAU (referente à segunda instância dos Tribunais e Conselho da Justiça Federal), TERCEIRO_GRAU (Tribunais Superiores) e QUARTO_GRAU (Conselho Nacional de Justiça e Supremo Tribunal Federal).
        /// </param>
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
        /// <param name="distribuicoes">
        /// Lista de distribuições relacionadas ao trâmite. 
        /// </param>
        /// <param name="movimentos">
        /// Lista de movimentos associados à tramitação.
        /// </param>
        /// <param name="documentos">
        /// Lista de documentos relacionados ao trâmite. 
        /// </param>
        /// <param name="processosRelacionados">
        /// Lista de processos relacionados ao trâmite. 
        /// </param>
        /// <param name="ativo">
        /// (boolean) Indica se a tramitação está ativa. Valores permitidos: true, false. Exemplo: "false".
        /// </param>
        /// <param name="dataHoraExclusao">
        /// (string) Data e hora da exclusão da tramitação. Exemplo: "2023-01-01T12:00:00".
        /// </param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TramiteS3(
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
            string? sistemaProcessual,
            string? tipoSistemaProcessual,
            global::Loud.Technology.Codex.Cnj.Sdk.TribunalS3? tribunal,
            string? numeroHistorico,
            string? competencia,
            global::Loud.Technology.Codex.Cnj.Sdk.CompetenciaS3? dadosCompetencia,
            long? idCompetencia,
            string? instancia,
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
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.ClasseS3>? classe,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.AssuntoS3>? assunto,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.ParteS3>? partes,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.DistribuicoesS3>? distribuicoes,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.MovimentoS3>? movimentos,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.DocumentoS3>? documentos,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.ProcessosRelacionadosS3>? processosRelacionados,
            bool? ativo,
            string? dataHoraExclusao,
            string? anoEleicao,
            string? situacaoMigracao,
            string? intervencaoMP,
            string? juizo100Digital)
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
            this.SistemaProcessual = sistemaProcessual;
            this.TipoSistemaProcessual = tipoSistemaProcessual;
            this.Tribunal = tribunal;
            this.NumeroHistorico = numeroHistorico;
            this.Competencia = competencia;
            this.DadosCompetencia = dadosCompetencia;
            this.IdCompetencia = idCompetencia;
            this.Instancia = instancia;
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
            this.Distribuicoes = distribuicoes;
            this.Movimentos = movimentos;
            this.Documentos = documentos;
            this.ProcessosRelacionados = processosRelacionados;
            this.Ativo = ativo;
            this.DataHoraExclusao = dataHoraExclusao;
            this.AnoEleicao = anoEleicao;
            this.SituacaoMigracao = situacaoMigracao;
            this.IntervencaoMP = intervencaoMP;
            this.Juizo100Digital = juizo100Digital;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TramiteS3" /> class.
        /// </summary>
        public TramiteS3()
        {
        }

    }
}