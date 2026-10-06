
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutroNomeOpenSearch
    {
        /// <summary>
        /// Nome alternativo. Exemplo: "J. Silva". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Tipo do nome. Exemplos: “OUTRO” ;  “ALCUNHA” 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipo")]
        public string? Tipo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutroNomeOpenSearch" /> class.
        /// </summary>
        /// <param name="nome">
        /// Nome alternativo. Exemplo: "J. Silva". 
        /// </param>
        /// <param name="tipo">
        /// Tipo do nome. Exemplos: “OUTRO” ;  “ALCUNHA” 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutroNomeOpenSearch(
            string? nome,
            string? tipo)
        {
            this.Nome = nome;
            this.Tipo = tipo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutroNomeOpenSearch" /> class.
        /// </summary>
        public OutroNomeOpenSearch()
        {
        }

    }
}