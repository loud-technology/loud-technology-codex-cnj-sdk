
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OabS3
    {
        /// <summary>
        /// Número de inscrição na OAB. Exemplo: 12345678. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numero")]
        public string? Numero { get; set; }

        /// <summary>
        /// Tipo de registro da OAB. Exemplos: “A”: inscrição suplementar; “B”: inscrição principal, com transferência entre UFs; “D”: inscrição principal, chamada de definitiva;“E”: inscrição de estagiário; “O”: inscrição principal, chamada de originária; “P”: inscrição principal, chamada de provisória deferida mediante certidão de graduação, sem diploma.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoRegistro")]
        public string? TipoRegistro { get; set; }

        /// <summary>
        /// Unidade Federativa da OAB. Exemplo: "SP". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uf")]
        public string? Uf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OabS3" /> class.
        /// </summary>
        /// <param name="numero">
        /// Número de inscrição na OAB. Exemplo: 12345678. 
        /// </param>
        /// <param name="tipoRegistro">
        /// Tipo de registro da OAB. Exemplos: “A”: inscrição suplementar; “B”: inscrição principal, com transferência entre UFs; “D”: inscrição principal, chamada de definitiva;“E”: inscrição de estagiário; “O”: inscrição principal, chamada de originária; “P”: inscrição principal, chamada de provisória deferida mediante certidão de graduação, sem diploma.
        /// </param>
        /// <param name="uf">
        /// Unidade Federativa da OAB. Exemplo: "SP". 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OabS3(
            string? numero,
            string? tipoRegistro,
            string? uf)
        {
            this.Numero = numero;
            this.TipoRegistro = tipoRegistro;
            this.Uf = uf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OabS3" /> class.
        /// </summary>
        public OabS3()
        {
        }

    }
}