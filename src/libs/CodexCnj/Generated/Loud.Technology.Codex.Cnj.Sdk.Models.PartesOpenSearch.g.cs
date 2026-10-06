
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PartesOpenSearch
    {
        /// <summary>
        /// Atributo destinado a permitir a identificação do tipo de polo processual. Deve ser definido usando um dos seguintes valores: ASSISTENTE_DESINTERESSADO_AMICUS_CURAE; ATIVO; FISCAL_LEI; NAO_VINCULADOS; OUTROS_PARTICIPANTES; PASSIVO; TERCEIRO; TESTEMUNHA_JUIZO; VITIMA.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("polo")]
        public string? Polo { get; set; }

        /// <summary>
        /// Tipo de elemento que permite a identificação de uma parte que compõe o processo. Cada parte deve ter apenas uma pessoa física ou jurídica. Exemplo: "RÉU", "REQUERIDO", "FISCAL DA LEI", "REQUERENTE", "EXEQUENTE", "EXECUTADO", "TERCEIRO INTERESSADO", "AUTOR", "VÍTIMA"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoParte")]
        public string? TipoParte { get; set; }

        /// <summary>
        /// Indica a situação da parte em relação ao processo. Exemplo: ‘ATIVO’, ’INATIVO’, ‘BAIXADO’, ‘SUSPENSO’
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("situacao")]
        public string? Situacao { get; set; }

        /// <summary>
        /// Raça cor da parte.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("racaCor")]
        public string? RacaCor { get; set; }

        /// <summary>
        /// Caminho para endpoint pessoas seguido pelo idPessoa. Exemplo: '/pessoas/1fe353ba-98a2-5ba7-889b-324e2e901d09' 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// Nome da parte. Exemplo: "Maria Souza".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Registro do gênero da parte. Exemplo: "FEMININO", "MASCULINO" ou "OUTROS".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexo")]
        public string? Sexo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nacionalidade")]
        public global::Loud.Technology.Codex.Cnj.Sdk.NacionalidadeOpenSearch? Nacionalidade { get; set; }

        /// <summary>
        /// Lista de outros nomes relacionados a parte. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outrosNomes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.OutroNomeOpenSearch>? OutrosNomes { get; set; }

        /// <summary>
        /// Indica a natureza jurídica da pessoa. Exemplos: "FÍSICA" e "JURÍDICA".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoPessoa")]
        public string? TipoPessoa { get; set; }

        /// <summary>
        /// Lista de documentos principais relacionados a parte. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentosPrincipais")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.DocumentoPrincipalOpenSearch>? DocumentosPrincipais { get; set; }

        /// <summary>
        /// Indica se há assistência judiciária gratuita. Valores permitidos: true, false. Exemplo: true. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistenciaJudiciariaGratuita")]
        public string? AssistenciaJudiciariaGratuita { get; set; }

        /// <summary>
        /// Indica se a parte é sigilosa. Valores permitidos: true, false. Exemplo: false. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sigilosa")]
        public bool? Sigilosa { get; set; }

        /// <summary>
        /// Lista de representantes da parte. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("representantes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.RepresentanteOpenSearch>? Representantes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PartesOpenSearch" /> class.
        /// </summary>
        /// <param name="polo">
        /// Atributo destinado a permitir a identificação do tipo de polo processual. Deve ser definido usando um dos seguintes valores: ASSISTENTE_DESINTERESSADO_AMICUS_CURAE; ATIVO; FISCAL_LEI; NAO_VINCULADOS; OUTROS_PARTICIPANTES; PASSIVO; TERCEIRO; TESTEMUNHA_JUIZO; VITIMA.
        /// </param>
        /// <param name="tipoParte">
        /// Tipo de elemento que permite a identificação de uma parte que compõe o processo. Cada parte deve ter apenas uma pessoa física ou jurídica. Exemplo: "RÉU", "REQUERIDO", "FISCAL DA LEI", "REQUERENTE", "EXEQUENTE", "EXECUTADO", "TERCEIRO INTERESSADO", "AUTOR", "VÍTIMA"
        /// </param>
        /// <param name="situacao">
        /// Indica a situação da parte em relação ao processo. Exemplo: ‘ATIVO’, ’INATIVO’, ‘BAIXADO’, ‘SUSPENSO’
        /// </param>
        /// <param name="racaCor">
        /// Raça cor da parte.
        /// </param>
        /// <param name="href">
        /// Caminho para endpoint pessoas seguido pelo idPessoa. Exemplo: '/pessoas/1fe353ba-98a2-5ba7-889b-324e2e901d09' 
        /// </param>
        /// <param name="nome">
        /// Nome da parte. Exemplo: "Maria Souza".
        /// </param>
        /// <param name="sexo">
        /// Registro do gênero da parte. Exemplo: "FEMININO", "MASCULINO" ou "OUTROS".
        /// </param>
        /// <param name="nacionalidade"></param>
        /// <param name="outrosNomes">
        /// Lista de outros nomes relacionados a parte. 
        /// </param>
        /// <param name="tipoPessoa">
        /// Indica a natureza jurídica da pessoa. Exemplos: "FÍSICA" e "JURÍDICA".
        /// </param>
        /// <param name="documentosPrincipais">
        /// Lista de documentos principais relacionados a parte. 
        /// </param>
        /// <param name="assistenciaJudiciariaGratuita">
        /// Indica se há assistência judiciária gratuita. Valores permitidos: true, false. Exemplo: true. 
        /// </param>
        /// <param name="sigilosa">
        /// Indica se a parte é sigilosa. Valores permitidos: true, false. Exemplo: false. 
        /// </param>
        /// <param name="representantes">
        /// Lista de representantes da parte. 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PartesOpenSearch(
            string? polo,
            string? tipoParte,
            string? situacao,
            string? racaCor,
            string? href,
            string? nome,
            string? sexo,
            global::Loud.Technology.Codex.Cnj.Sdk.NacionalidadeOpenSearch? nacionalidade,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.OutroNomeOpenSearch>? outrosNomes,
            string? tipoPessoa,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.DocumentoPrincipalOpenSearch>? documentosPrincipais,
            string? assistenciaJudiciariaGratuita,
            bool? sigilosa,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.RepresentanteOpenSearch>? representantes)
        {
            this.Polo = polo;
            this.TipoParte = tipoParte;
            this.Situacao = situacao;
            this.RacaCor = racaCor;
            this.Href = href;
            this.Nome = nome;
            this.Sexo = sexo;
            this.Nacionalidade = nacionalidade;
            this.OutrosNomes = outrosNomes;
            this.TipoPessoa = tipoPessoa;
            this.DocumentosPrincipais = documentosPrincipais;
            this.AssistenciaJudiciariaGratuita = assistenciaJudiciariaGratuita;
            this.Sigilosa = sigilosa;
            this.Representantes = representantes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PartesOpenSearch" /> class.
        /// </summary>
        public PartesOpenSearch()
        {
        }

    }
}