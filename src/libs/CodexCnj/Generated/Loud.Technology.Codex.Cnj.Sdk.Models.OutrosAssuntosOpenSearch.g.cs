
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutrosAssuntosOpenSearch
    {
        /// <summary>
        /// Código de outro assunto conforme TPU de assuntos. Exemplo: "11724".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codigo")]
        public long? Codigo { get; set; }

        /// <summary>
        /// Descrição de outro assunto de acordo com TPU de assuntos. Exemplo: “Diplomação".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descricao")]
        public string? Descricao { get; set; }

        /// <summary>
        /// Ordem crescente do outro assunto em relação aos níveis da TPU de assuntos. Exemplo:"(11631) Cargo - Deputado Federal | (11628) Cargos | (11583) Eleições | (11428) DIREITO ELEITORAL".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarquia")]
        public string? Hierarquia { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutrosAssuntosOpenSearch" /> class.
        /// </summary>
        /// <param name="codigo">
        /// Código de outro assunto conforme TPU de assuntos. Exemplo: "11724".
        /// </param>
        /// <param name="descricao">
        /// Descrição de outro assunto de acordo com TPU de assuntos. Exemplo: “Diplomação".
        /// </param>
        /// <param name="hierarquia">
        /// Ordem crescente do outro assunto em relação aos níveis da TPU de assuntos. Exemplo:"(11631) Cargo - Deputado Federal | (11628) Cargos | (11583) Eleições | (11428) DIREITO ELEITORAL".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutrosAssuntosOpenSearch(
            long? codigo,
            string? descricao,
            string? hierarquia)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Hierarquia = hierarquia;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutrosAssuntosOpenSearch" /> class.
        /// </summary>
        public OutrosAssuntosOpenSearch()
        {
        }

    }
}