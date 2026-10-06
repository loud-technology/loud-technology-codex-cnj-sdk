
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EnderecoS3
    {
        /// <summary>
        /// Identificador do endereço. Exemplo: 123456789.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idEndereco")]
        public long? IdEndereco { get; set; }

        /// <summary>
        /// Logradouro do endereço. Exemplo: "Av. Brasil".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logradouro")]
        public string? Logradouro { get; set; }

        /// <summary>
        /// Número do endereço. Exemplo: "123".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numero")]
        public string? Numero { get; set; }

        /// <summary>
        /// Complemento do endereço. Exemplo: "Apto 01".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complemento")]
        public string? Complemento { get; set; }

        /// <summary>
        /// Bairro do endereço. Exemplo: "Centro".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("bairro")]
        public string? Bairro { get; set; }

        /// <summary>
        /// CEP do endereço. Exemplo: "00000-000".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cep")]
        public string? Cep { get; set; }

        /// <summary>
        /// Localidade do endereço. Exemplo: "BRASÍLIA".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localidade")]
        public string? Localidade { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uf")]
        public global::Loud.Technology.Codex.Cnj.Sdk.UfS3? Uf { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pais")]
        public global::Loud.Technology.Codex.Cnj.Sdk.PaisS3? Pais { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoS3" /> class.
        /// </summary>
        /// <param name="idEndereco">
        /// Identificador do endereço. Exemplo: 123456789.
        /// </param>
        /// <param name="logradouro">
        /// Logradouro do endereço. Exemplo: "Av. Brasil".
        /// </param>
        /// <param name="numero">
        /// Número do endereço. Exemplo: "123".
        /// </param>
        /// <param name="complemento">
        /// Complemento do endereço. Exemplo: "Apto 01".
        /// </param>
        /// <param name="bairro">
        /// Bairro do endereço. Exemplo: "Centro".
        /// </param>
        /// <param name="cep">
        /// CEP do endereço. Exemplo: "00000-000".
        /// </param>
        /// <param name="localidade">
        /// Localidade do endereço. Exemplo: "BRASÍLIA".
        /// </param>
        /// <param name="uf"></param>
        /// <param name="pais"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnderecoS3(
            long? idEndereco,
            string? logradouro,
            string? numero,
            string? complemento,
            string? bairro,
            string? cep,
            string? localidade,
            global::Loud.Technology.Codex.Cnj.Sdk.UfS3? uf,
            global::Loud.Technology.Codex.Cnj.Sdk.PaisS3? pais)
        {
            this.IdEndereco = idEndereco;
            this.Logradouro = logradouro;
            this.Numero = numero;
            this.Complemento = complemento;
            this.Bairro = bairro;
            this.Cep = cep;
            this.Localidade = localidade;
            this.Uf = uf;
            this.Pais = pais;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnderecoS3" /> class.
        /// </summary>
        public EnderecoS3()
        {
        }

    }
}