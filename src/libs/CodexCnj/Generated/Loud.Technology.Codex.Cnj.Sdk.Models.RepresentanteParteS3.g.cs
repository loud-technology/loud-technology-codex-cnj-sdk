
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RepresentanteParteS3
    {
        /// <summary>
        /// Nome do representante. Exemplo: "João Pereira". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Data de nascimento do representante da parte. Exemplo: "1980-02-03".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataNascimento")]
        public string? DataNascimento { get; set; }

        /// <summary>
        /// Lista de genitores de representante da parte. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("genitores")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.GenitoresRepresentanteS3>? Genitores { get; set; }

        /// <summary>
        /// Atributo que permite indicar o tipo de representante processual, "ADVOGADO", "OUTRO", "CURADOR". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoRepresentacao")]
        public string? TipoRepresentacao { get; set; }

        /// <summary>
        /// Lista de cadastros na Receita Federal. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cadastroReceitaFederal")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.CadastroReceitaFederalS3>? CadastroReceitaFederal { get; set; }

        /// <summary>
        /// Inscrição na OAB do representante. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oab")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.OabS3>? Oab { get; set; }

        /// <summary>
        /// Situação do representante. Exemplo: devendo conter um dos valores do domínio: ‘ATIVO’,’INATIVO’ 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("situacao")]
        public string? Situacao { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RepresentanteParteS3" /> class.
        /// </summary>
        /// <param name="nome">
        /// Nome do representante. Exemplo: "João Pereira". 
        /// </param>
        /// <param name="dataNascimento">
        /// Data de nascimento do representante da parte. Exemplo: "1980-02-03".
        /// </param>
        /// <param name="genitores">
        /// Lista de genitores de representante da parte. 
        /// </param>
        /// <param name="tipoRepresentacao">
        /// Atributo que permite indicar o tipo de representante processual, "ADVOGADO", "OUTRO", "CURADOR". 
        /// </param>
        /// <param name="cadastroReceitaFederal">
        /// Lista de cadastros na Receita Federal. 
        /// </param>
        /// <param name="oab">
        /// Inscrição na OAB do representante. 
        /// </param>
        /// <param name="situacao">
        /// Situação do representante. Exemplo: devendo conter um dos valores do domínio: ‘ATIVO’,’INATIVO’ 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RepresentanteParteS3(
            string? nome,
            string? dataNascimento,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.GenitoresRepresentanteS3>? genitores,
            string? tipoRepresentacao,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.CadastroReceitaFederalS3>? cadastroReceitaFederal,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.OabS3>? oab,
            string? situacao)
        {
            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Genitores = genitores;
            this.TipoRepresentacao = tipoRepresentacao;
            this.CadastroReceitaFederal = cadastroReceitaFederal;
            this.Oab = oab;
            this.Situacao = situacao;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RepresentanteParteS3" /> class.
        /// </summary>
        public RepresentanteParteS3()
        {
        }

    }
}