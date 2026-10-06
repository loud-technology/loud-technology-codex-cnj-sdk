
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessoParteHrefDTO
    {
        /// <summary>
        /// Id do processo no Codex
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idCodex")]
        public long? IdCodex { get; set; }

        /// <summary>
        /// Número do processo. Exemplo: "0001234-56.2023.8.26.0000". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroProcesso")]
        public string? NumeroProcesso { get; set; }

        /// <summary>
        /// Quantidade de tramites relaciocionado o Processo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantidadeTramitacoes")]
        public int? QuantidadeTramitacoes { get; set; }

        /// <summary>
        /// Uso de controle interno que não é objeto de consumo negocial. Identificação da versão do Json utilizado . 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versao")]
        public string? Versao { get; set; }

        /// <summary>
        /// Nível de sigilo a ser aplicado ao processo.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nivelSigilo")]
        public long? NivelSigilo { get; set; }

        /// <summary>
        /// Segmento do tribunal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentoJustica")]
        public string? SegmentoJustica { get; set; }

        /// <summary>
        /// Sigla do tribunal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("siglaTribunal")]
        public string? SiglaTribunal { get; set; }

        /// <summary>
        /// Tipo de polo processual
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("polo")]
        public string? Polo { get; set; }

        /// <summary>
        /// Tipo da parte
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoParte")]
        public string? TipoParte { get; set; }

        /// <summary>
        /// Situação da parte
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("situacaoParte")]
        public string? SituacaoParte { get; set; }

        /// <summary>
        /// Natureza do trâmite
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("natureza")]
        public string? Natureza { get; set; }

        /// <summary>
        /// Tipo de justiça
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoJustica")]
        public string? TipoJustica { get; set; }

        /// <summary>
        /// Id do assunto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idAssunto")]
        public long? IdAssunto { get; set; }

        /// <summary>
        /// Descrição do assunto
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assuntoPrincipal")]
        public string? AssuntoPrincipal { get; set; }

        /// <summary>
        /// Id do órgão julgador
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idOrgaoJustica")]
        public long? IdOrgaoJustica { get; set; }

        /// <summary>
        /// Nome do órgão julgador
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgaoJustica")]
        public string? OrgaoJustica { get; set; }

        /// <summary>
        /// Código da classe atual
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idClasseAtual")]
        public long? IdClasseAtual { get; set; }

        /// <summary>
        /// Fonte de dados Codex
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idFonteDadosCodex")]
        public string? IdFonteDadosCodex { get; set; }

        /// <summary>
        /// Descrição da classe
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classeAtual")]
        public string? ClasseAtual { get; set; }

        /// <summary>
        /// Instância do órgão julgador
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instancia")]
        public string? Instancia { get; set; }

        /// <summary>
        /// Data e hora do ajuizamento
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHoraAjuizamento")]
        public string? DataHoraAjuizamento { get; set; }

        /// <summary>
        /// Fase processual
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("faseProcessual")]
        public string? FaseProcessual { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("situacaoAtual")]
        public global::Loud.Technology.Codex.Cnj.Sdk.SituacaoAtual? SituacaoAtual { get; set; }

        /// <summary>
        /// Indica se a tramitação está ativa (true) ou inativa (false). Reflete exatamente o valor de tramitacoes.ativo na fonte de dados.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ativo")]
        public bool? Ativo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessoParteHrefDTO" /> class.
        /// </summary>
        /// <param name="idCodex">
        /// Id do processo no Codex
        /// </param>
        /// <param name="numeroProcesso">
        /// Número do processo. Exemplo: "0001234-56.2023.8.26.0000". 
        /// </param>
        /// <param name="quantidadeTramitacoes">
        /// Quantidade de tramites relaciocionado o Processo
        /// </param>
        /// <param name="versao">
        /// Uso de controle interno que não é objeto de consumo negocial. Identificação da versão do Json utilizado . 
        /// </param>
        /// <param name="nivelSigilo">
        /// Nível de sigilo a ser aplicado ao processo.
        /// </param>
        /// <param name="segmentoJustica">
        /// Segmento do tribunal
        /// </param>
        /// <param name="siglaTribunal">
        /// Sigla do tribunal
        /// </param>
        /// <param name="polo">
        /// Tipo de polo processual
        /// </param>
        /// <param name="tipoParte">
        /// Tipo da parte
        /// </param>
        /// <param name="situacaoParte">
        /// Situação da parte
        /// </param>
        /// <param name="natureza">
        /// Natureza do trâmite
        /// </param>
        /// <param name="tipoJustica">
        /// Tipo de justiça
        /// </param>
        /// <param name="idAssunto">
        /// Id do assunto
        /// </param>
        /// <param name="assuntoPrincipal">
        /// Descrição do assunto
        /// </param>
        /// <param name="idOrgaoJustica">
        /// Id do órgão julgador
        /// </param>
        /// <param name="orgaoJustica">
        /// Nome do órgão julgador
        /// </param>
        /// <param name="idClasseAtual">
        /// Código da classe atual
        /// </param>
        /// <param name="idFonteDadosCodex">
        /// Fonte de dados Codex
        /// </param>
        /// <param name="classeAtual">
        /// Descrição da classe
        /// </param>
        /// <param name="instancia">
        /// Instância do órgão julgador
        /// </param>
        /// <param name="dataHoraAjuizamento">
        /// Data e hora do ajuizamento
        /// </param>
        /// <param name="faseProcessual">
        /// Fase processual
        /// </param>
        /// <param name="situacaoAtual"></param>
        /// <param name="ativo">
        /// Indica se a tramitação está ativa (true) ou inativa (false). Reflete exatamente o valor de tramitacoes.ativo na fonte de dados.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessoParteHrefDTO(
            long? idCodex,
            string? numeroProcesso,
            int? quantidadeTramitacoes,
            string? versao,
            long? nivelSigilo,
            string? segmentoJustica,
            string? siglaTribunal,
            string? polo,
            string? tipoParte,
            string? situacaoParte,
            string? natureza,
            string? tipoJustica,
            long? idAssunto,
            string? assuntoPrincipal,
            long? idOrgaoJustica,
            string? orgaoJustica,
            long? idClasseAtual,
            string? idFonteDadosCodex,
            string? classeAtual,
            string? instancia,
            string? dataHoraAjuizamento,
            string? faseProcessual,
            global::Loud.Technology.Codex.Cnj.Sdk.SituacaoAtual? situacaoAtual,
            bool? ativo)
        {
            this.IdCodex = idCodex;
            this.NumeroProcesso = numeroProcesso;
            this.QuantidadeTramitacoes = quantidadeTramitacoes;
            this.Versao = versao;
            this.NivelSigilo = nivelSigilo;
            this.SegmentoJustica = segmentoJustica;
            this.SiglaTribunal = siglaTribunal;
            this.Polo = polo;
            this.TipoParte = tipoParte;
            this.SituacaoParte = situacaoParte;
            this.Natureza = natureza;
            this.TipoJustica = tipoJustica;
            this.IdAssunto = idAssunto;
            this.AssuntoPrincipal = assuntoPrincipal;
            this.IdOrgaoJustica = idOrgaoJustica;
            this.OrgaoJustica = orgaoJustica;
            this.IdClasseAtual = idClasseAtual;
            this.IdFonteDadosCodex = idFonteDadosCodex;
            this.ClasseAtual = classeAtual;
            this.Instancia = instancia;
            this.DataHoraAjuizamento = dataHoraAjuizamento;
            this.FaseProcessual = faseProcessual;
            this.SituacaoAtual = situacaoAtual;
            this.Ativo = ativo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessoParteHrefDTO" /> class.
        /// </summary>
        public ProcessoParteHrefDTO()
        {
        }

    }
}