
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CadastroReceitaFederalS3
    {
        /// <summary>
        /// Número do cadastro na Receita Federal. Exemplo: 12345678901. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numero")]
        public string? Numero { get; set; }

        /// <summary>
        /// Tipo de cadastro, podendo ser CPF (Cadastro de Pessoa Física) ou CNPJ (Cadastro Nacional de Pessoa Jurídica). Exemplo: "CPF". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipo")]
        public string? Tipo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CadastroReceitaFederalS3" /> class.
        /// </summary>
        /// <param name="numero">
        /// Número do cadastro na Receita Federal. Exemplo: 12345678901. 
        /// </param>
        /// <param name="tipo">
        /// Tipo de cadastro, podendo ser CPF (Cadastro de Pessoa Física) ou CNPJ (Cadastro Nacional de Pessoa Jurídica). Exemplo: "CPF". 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CadastroReceitaFederalS3(
            string? numero,
            string? tipo)
        {
            this.Numero = numero;
            this.Tipo = tipo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CadastroReceitaFederalS3" /> class.
        /// </summary>
        public CadastroReceitaFederalS3()
        {
        }

    }
}