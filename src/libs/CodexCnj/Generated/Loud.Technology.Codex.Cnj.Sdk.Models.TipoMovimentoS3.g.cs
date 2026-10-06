
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TipoMovimentoS3
    {
        /// <summary>
        /// Código do tipo de movimento, conforme TPU de movimentos. Exemplo: "236".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Nome do tipo de movimento, conforme TPU de movimentos. Exemplo: "Negação de seguimento".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Descrição do tipo de movimento, conforme TPU de movimentos. Exemplo: "Negado seguimento a Recurso".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descricao")]
        public string? Descricao { get; set; }

        /// <summary>
        /// Ordem crescente da sequência do movimento em relação aos níveis da TPU de movimentos. Exemplo: Exemplo:"(236) Negação de seguimento | (218) Sem Resolução De Mérito | (193) Julgamento | (1) Magistrado".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarquia")]
        public string? Hierarquia { get; set; }

        /// <summary>
        /// Lista de complementos. Modelo detalhado acima 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("complementos")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.ComplementoS3>? Complementos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TipoMovimentoS3" /> class.
        /// </summary>
        /// <param name="id">
        /// Código do tipo de movimento, conforme TPU de movimentos. Exemplo: "236".
        /// </param>
        /// <param name="nome">
        /// Nome do tipo de movimento, conforme TPU de movimentos. Exemplo: "Negação de seguimento".
        /// </param>
        /// <param name="descricao">
        /// Descrição do tipo de movimento, conforme TPU de movimentos. Exemplo: "Negado seguimento a Recurso".
        /// </param>
        /// <param name="hierarquia">
        /// Ordem crescente da sequência do movimento em relação aos níveis da TPU de movimentos. Exemplo: Exemplo:"(236) Negação de seguimento | (218) Sem Resolução De Mérito | (193) Julgamento | (1) Magistrado".
        /// </param>
        /// <param name="complementos">
        /// Lista de complementos. Modelo detalhado acima 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TipoMovimentoS3(
            long? id,
            string? nome,
            string? descricao,
            string? hierarquia,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.ComplementoS3>? complementos)
        {
            this.Id = id;
            this.Nome = nome;
            this.Descricao = descricao;
            this.Hierarquia = hierarquia;
            this.Complementos = complementos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TipoMovimentoS3" /> class.
        /// </summary>
        public TipoMovimentoS3()
        {
        }

    }
}