
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ParteS3
    {
        /// <summary>
        /// Atributo destinado a permitir a identificação do tipo de polo processual. Exemplo: ASSISTENTE_DESINTERESSADO_AMICUS_CURAE; ATIVO; FISCAL_LEI; NAO_VINCULADOS; OUTROS_PARTICIPANTES; PASSIVO; TERCEIRO; TESTEMUNHA_JUIZO; VITIMA.
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
        /// Nome da parte. Exemplo: "Maria Souza".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Registro do gênero da parte. Exemplos: "FEMININO", "MASCULINO" ou "OUTROS".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexo")]
        public string? Sexo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nacionalidade")]
        public global::Loud.Technology.Codex.Cnj.Sdk.NacionalidadeS3? Nacionalidade { get; set; }

        /// <summary>
        /// Data de nascimento da parte. Exemplo: "1980-02-03".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataNascimento")]
        public string? DataNascimento { get; set; }

        /// <summary>
        /// Lista de genitores da parte. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genitores")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.GenitoresS3>? Genitores { get; set; }

        /// <summary>
        /// Lista de outros nomes relacionados à parte. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outrosNomes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.OutroNomeS3>? OutrosNomes { get; set; }

        /// <summary>
        /// Indica a natureza jurídica da pessoa. Exemplos: "FÍSICA" e "JURÍDICA".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoPessoa")]
        public string? TipoPessoa { get; set; }

        /// <summary>
        /// Lista de documentos principais relacionados à parte. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("documentosPrincipais")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.DocumentosPrincipaisS3>? DocumentosPrincipais { get; set; }

        /// <summary>
        /// Lista de outros documentos relacionados à parte. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outrosDocumentos")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.OutrosDocumentosS3>? OutrosDocumentos { get; set; }

        /// <summary>
        /// Indica se há assistência judiciária gratuita. Valores permitidos: true, false. Exemplo: true. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assistenciaJudiciariaGratuita")]
        public bool? AssistenciaJudiciariaGratuita { get; set; }

        /// <summary>
        /// Indica se a parte é sigilosa. Valores permitidos: true, false. Exemplo: false. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sigilosa")]
        public bool? Sigilosa { get; set; }

        /// <summary>
        /// Lista de representantes da parte. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("representantes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.RepresentanteParteS3>? Representantes { get; set; }

        /// <summary>
        /// Lista de endereços da parte. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enderecos")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.EnderecoS3>? Enderecos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ParteS3" /> class.
        /// </summary>
        /// <param name="polo">
        /// Atributo destinado a permitir a identificação do tipo de polo processual. Exemplo: ASSISTENTE_DESINTERESSADO_AMICUS_CURAE; ATIVO; FISCAL_LEI; NAO_VINCULADOS; OUTROS_PARTICIPANTES; PASSIVO; TERCEIRO; TESTEMUNHA_JUIZO; VITIMA.
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
        /// <param name="nome">
        /// Nome da parte. Exemplo: "Maria Souza".
        /// </param>
        /// <param name="sexo">
        /// Registro do gênero da parte. Exemplos: "FEMININO", "MASCULINO" ou "OUTROS".
        /// </param>
        /// <param name="nacionalidade"></param>
        /// <param name="dataNascimento">
        /// Data de nascimento da parte. Exemplo: "1980-02-03".
        /// </param>
        /// <param name="genitores">
        /// Lista de genitores da parte. 
        /// </param>
        /// <param name="outrosNomes">
        /// Lista de outros nomes relacionados à parte. 
        /// </param>
        /// <param name="tipoPessoa">
        /// Indica a natureza jurídica da pessoa. Exemplos: "FÍSICA" e "JURÍDICA".
        /// </param>
        /// <param name="documentosPrincipais">
        /// Lista de documentos principais relacionados à parte. 
        /// </param>
        /// <param name="outrosDocumentos">
        /// Lista de outros documentos relacionados à parte. 
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
        /// <param name="enderecos">
        /// Lista de endereços da parte. 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ParteS3(
            string? polo,
            string? tipoParte,
            string? situacao,
            string? racaCor,
            string? nome,
            string? sexo,
            global::Loud.Technology.Codex.Cnj.Sdk.NacionalidadeS3? nacionalidade,
            string? dataNascimento,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.GenitoresS3>? genitores,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.OutroNomeS3>? outrosNomes,
            string? tipoPessoa,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.DocumentosPrincipaisS3>? documentosPrincipais,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.OutrosDocumentosS3>? outrosDocumentos,
            bool? assistenciaJudiciariaGratuita,
            bool? sigilosa,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.RepresentanteParteS3>? representantes,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.EnderecoS3>? enderecos)
        {
            this.Polo = polo;
            this.TipoParte = tipoParte;
            this.Situacao = situacao;
            this.RacaCor = racaCor;
            this.Nome = nome;
            this.Sexo = sexo;
            this.Nacionalidade = nacionalidade;
            this.DataNascimento = dataNascimento;
            this.Genitores = genitores;
            this.OutrosNomes = outrosNomes;
            this.TipoPessoa = tipoPessoa;
            this.DocumentosPrincipais = documentosPrincipais;
            this.OutrosDocumentos = outrosDocumentos;
            this.AssistenciaJudiciariaGratuita = assistenciaJudiciariaGratuita;
            this.Sigilosa = sigilosa;
            this.Representantes = representantes;
            this.Enderecos = enderecos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ParteS3" /> class.
        /// </summary>
        public ParteS3()
        {
        }

    }
}