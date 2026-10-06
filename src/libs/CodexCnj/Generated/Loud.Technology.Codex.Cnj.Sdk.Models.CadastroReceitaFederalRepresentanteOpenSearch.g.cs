
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CadastroReceitaFederalRepresentanteOpenSearch
    {
        /// <summary>
        /// Número do cadastro do representante na Receita Federal. Exemplo: "12345678901"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numero")]
        public string? Numero { get; set; }

        /// <summary>
        /// Tipo de cadastro do representante, podendo ser CPF (Cadastro de Pessoa Física) ou CNPJ (Cadastro Nacional de Pessoa Jurídica). Exemplo: "CPF".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipo")]
        public string? Tipo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CadastroReceitaFederalRepresentanteOpenSearch" /> class.
        /// </summary>
        /// <param name="numero">
        /// Número do cadastro do representante na Receita Federal. Exemplo: "12345678901"
        /// </param>
        /// <param name="tipo">
        /// Tipo de cadastro do representante, podendo ser CPF (Cadastro de Pessoa Física) ou CNPJ (Cadastro Nacional de Pessoa Jurídica). Exemplo: "CPF".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CadastroReceitaFederalRepresentanteOpenSearch(
            string? numero,
            string? tipo)
        {
            this.Numero = numero;
            this.Tipo = tipo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CadastroReceitaFederalRepresentanteOpenSearch" /> class.
        /// </summary>
        public CadastroReceitaFederalRepresentanteOpenSearch()
        {
        }

    }
}