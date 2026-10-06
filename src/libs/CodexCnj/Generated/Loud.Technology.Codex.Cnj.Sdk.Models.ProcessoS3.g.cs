
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessoS3
    {
        /// <summary>
        /// Identificador do processo. Exemplo: "12345000000123450000". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Indentificação da versão do Json utilizado. Exemplo: "1.0.0".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versao")]
        public string? Versao { get; set; }

        /// <summary>
        /// Número do processo. Exemplo: "0001234-56.2023.8.26.0000". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroProcesso")]
        public string? NumeroProcesso { get; set; }

        /// <summary>
        /// Número sintético do processo. Exemplo: "0001234-56".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroProcessoSintetico")]
        public string? NumeroProcessoSintetico { get; set; }

        /// <summary>
        /// Data e hora da última atualização do processo no Datalake. Exemplo: "2023-01-01T12:00:00".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHoraAtualizacao")]
        public string? DataHoraAtualizacao { get; set; }

        /// <summary>
        /// Data e hora da última atualização do processo no Codex. Exemplo: "2023-01-01T12:00:00".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHoraUltimaAtualizacaoCodex")]
        public string? DataHoraUltimaAtualizacaoCodex { get; set; }

        /// <summary>
        /// Nível de sigilo a ser aplicado ao processo, devendo ser: 0: públicos, acessíveis a todos os servidores do Judiciário e dos demais órgãos públicos de colaboração na administração da Justiça, assim como aos advogados e a qualquer cidadão; 1: segredo de justiça, acessíveis aos servidores do Judiciário, aos servidores dos órgãos públicos de colaboração na administração da Justiça e às partes do processo; 2: sigilo mínimo, acessível aos servidores do Judiciário e aos demais órgãos públicos de colaboração na administração da Justiça; 3: sigilo médio, acessível aos servidores do órgão em que tramita o processo, à(s) parte(s) que provocou(ram) o incidente e àqueles que forem expressamente incluídos; 4: sigilo intenso, acessível a classes de servidores qualificados (magistrado, diretor de secretaria/escrivão, oficial de gabinete/assessor) do órgão em que tramita o processo, às partes que provocaram o incidente e àqueles que forem expressamente incluídos; 5: sigilo absoluto, acessível apenas ao magistrado do órgão em que tramita, aos servidores e demais usuários por ele indicado e às partes que provocaram o incidente.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nivelSigilo")]
        public long? NivelSigilo { get; set; }

        /// <summary>
        /// Segmento da justiça. Exemplos: 'CONSELHO_NACIONAL_JUSTICA', ‘JUSTICA_ELEITORAL’, , ’JUSTICA_ESTADUAL’, ‘JUSTICA_FEDERAL’, ’JUSTICA_MILITAR_ESTADUAL', 'JUSTICA_MILITAR_UNIAO', ’JUSTICA_TRABALHO’, 'SUPERIOR_TRIBUNAL_JUSTICA' e 'SUPREMO_TRIBUNAL_FEDERAL'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentoJustica")]
        public string? SegmentoJustica { get; set; }

        /// <summary>
        /// Identificador do tribunal no Codex.  Exemplo: 12.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idCodexTribunal")]
        public long? IdCodexTribunal { get; set; }

        /// <summary>
        /// Uso de controle interno que não é objeto de consumo negocial. Sigla do tribunal refere-se ao tribunal onde o processo foi ajuizado pela primeira vez, ou seja, onde o processo entrou no sistema. Esta informação é usada para identificar e auxiliar no direcionamento e controle do processo como um todo, antes de qualquer tramitação. Exemplo: "TJSP".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("siglaTribunal")]
        public string? SiglaTribunal { get; set; }

        /// <summary>
        /// Lista de tramitações referente às etapas ou ações que ocorrem durante o andamento de um processo judicial. A lista é formada em ordem decrescente por data de ajuizamento. Essas tramitações são agrupadas e ordenadas de acordo com a entrada na base de dados, podendo incluir diversas atividades processuais, como movimentações de partes, documentos anexados e outros eventos relevantes dentro do processo. Cada uma dessas ações é sincronizada e registrada com uma data específica que reflete o momento em que ocorreu dentro do sistema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tramitacoes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.TramiteS3>? Tramitacoes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessoS3" /> class.
        /// </summary>
        /// <param name="id">
        /// Identificador do processo. Exemplo: "12345000000123450000". 
        /// </param>
        /// <param name="versao">
        /// Indentificação da versão do Json utilizado. Exemplo: "1.0.0".
        /// </param>
        /// <param name="numeroProcesso">
        /// Número do processo. Exemplo: "0001234-56.2023.8.26.0000". 
        /// </param>
        /// <param name="numeroProcessoSintetico">
        /// Número sintético do processo. Exemplo: "0001234-56".
        /// </param>
        /// <param name="dataHoraAtualizacao">
        /// Data e hora da última atualização do processo no Datalake. Exemplo: "2023-01-01T12:00:00".
        /// </param>
        /// <param name="dataHoraUltimaAtualizacaoCodex">
        /// Data e hora da última atualização do processo no Codex. Exemplo: "2023-01-01T12:00:00".
        /// </param>
        /// <param name="nivelSigilo">
        /// Nível de sigilo a ser aplicado ao processo, devendo ser: 0: públicos, acessíveis a todos os servidores do Judiciário e dos demais órgãos públicos de colaboração na administração da Justiça, assim como aos advogados e a qualquer cidadão; 1: segredo de justiça, acessíveis aos servidores do Judiciário, aos servidores dos órgãos públicos de colaboração na administração da Justiça e às partes do processo; 2: sigilo mínimo, acessível aos servidores do Judiciário e aos demais órgãos públicos de colaboração na administração da Justiça; 3: sigilo médio, acessível aos servidores do órgão em que tramita o processo, à(s) parte(s) que provocou(ram) o incidente e àqueles que forem expressamente incluídos; 4: sigilo intenso, acessível a classes de servidores qualificados (magistrado, diretor de secretaria/escrivão, oficial de gabinete/assessor) do órgão em que tramita o processo, às partes que provocaram o incidente e àqueles que forem expressamente incluídos; 5: sigilo absoluto, acessível apenas ao magistrado do órgão em que tramita, aos servidores e demais usuários por ele indicado e às partes que provocaram o incidente.
        /// </param>
        /// <param name="segmentoJustica">
        /// Segmento da justiça. Exemplos: 'CONSELHO_NACIONAL_JUSTICA', ‘JUSTICA_ELEITORAL’, , ’JUSTICA_ESTADUAL’, ‘JUSTICA_FEDERAL’, ’JUSTICA_MILITAR_ESTADUAL', 'JUSTICA_MILITAR_UNIAO', ’JUSTICA_TRABALHO’, 'SUPERIOR_TRIBUNAL_JUSTICA' e 'SUPREMO_TRIBUNAL_FEDERAL'.
        /// </param>
        /// <param name="idCodexTribunal">
        /// Identificador do tribunal no Codex.  Exemplo: 12.
        /// </param>
        /// <param name="siglaTribunal">
        /// Uso de controle interno que não é objeto de consumo negocial. Sigla do tribunal refere-se ao tribunal onde o processo foi ajuizado pela primeira vez, ou seja, onde o processo entrou no sistema. Esta informação é usada para identificar e auxiliar no direcionamento e controle do processo como um todo, antes de qualquer tramitação. Exemplo: "TJSP".
        /// </param>
        /// <param name="tramitacoes">
        /// Lista de tramitações referente às etapas ou ações que ocorrem durante o andamento de um processo judicial. A lista é formada em ordem decrescente por data de ajuizamento. Essas tramitações são agrupadas e ordenadas de acordo com a entrada na base de dados, podendo incluir diversas atividades processuais, como movimentações de partes, documentos anexados e outros eventos relevantes dentro do processo. Cada uma dessas ações é sincronizada e registrada com uma data específica que reflete o momento em que ocorreu dentro do sistema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessoS3(
            string? id,
            string? versao,
            string? numeroProcesso,
            string? numeroProcessoSintetico,
            string? dataHoraAtualizacao,
            string? dataHoraUltimaAtualizacaoCodex,
            long? nivelSigilo,
            string? segmentoJustica,
            long? idCodexTribunal,
            string? siglaTribunal,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.TramiteS3>? tramitacoes)
        {
            this.Id = id;
            this.Versao = versao;
            this.NumeroProcesso = numeroProcesso;
            this.NumeroProcessoSintetico = numeroProcessoSintetico;
            this.DataHoraAtualizacao = dataHoraAtualizacao;
            this.DataHoraUltimaAtualizacaoCodex = dataHoraUltimaAtualizacaoCodex;
            this.NivelSigilo = nivelSigilo;
            this.SegmentoJustica = segmentoJustica;
            this.IdCodexTribunal = idCodexTribunal;
            this.SiglaTribunal = siglaTribunal;
            this.Tramitacoes = tramitacoes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessoS3" /> class.
        /// </summary>
        public ProcessoS3()
        {
        }

    }
}