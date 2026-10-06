
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ValorS3
    {
        /// <summary>
        /// Código do valor do complemento tabelado do movimento, de acordo com a tabela de complementos de movimentos da TPU movimentos. Exemplo: 107.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codigo")]
        public long? Codigo { get; set; }

        /// <summary>
        /// Descrição do valor do complemento tabelado do movimento, de acordo com a tabela de complementos de movimentos da TPU movimentos. Exemplo: "Certidão".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descricao")]
        public string? Descricao { get; set; }

        /// <summary>
        /// Valor do complemento do movimento, seja ele tabelado, livre ou identificador.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valor")]
        public string? Valor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ValorS3" /> class.
        /// </summary>
        /// <param name="codigo">
        /// Código do valor do complemento tabelado do movimento, de acordo com a tabela de complementos de movimentos da TPU movimentos. Exemplo: 107.
        /// </param>
        /// <param name="descricao">
        /// Descrição do valor do complemento tabelado do movimento, de acordo com a tabela de complementos de movimentos da TPU movimentos. Exemplo: "Certidão".
        /// </param>
        /// <param name="valor">
        /// Valor do complemento do movimento, seja ele tabelado, livre ou identificador.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ValorS3(
            long? codigo,
            string? descricao,
            string? valor)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Valor = valor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ValorS3" /> class.
        /// </summary>
        public ValorS3()
        {
        }

    }
}