
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JurisdicaoOpenSearch
    {
        /// <summary>
        /// Identificador da jurisdição. Exemplo: 15321.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codigo")]
        public long? Codigo { get; set; }

        /// <summary>
        /// Refere-se à jurisdição territorial do órgão julgador. Exemplos: "Tribunal de Justiça do Estado de Santa Catarina", “Comarca de São Miguel do Guaporé”, “Comarca de Machadinho do Oeste”.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JurisdicaoOpenSearch" /> class.
        /// </summary>
        /// <param name="codigo">
        /// Identificador da jurisdição. Exemplo: 15321.
        /// </param>
        /// <param name="nome">
        /// Refere-se à jurisdição territorial do órgão julgador. Exemplos: "Tribunal de Justiça do Estado de Santa Catarina", “Comarca de São Miguel do Guaporé”, “Comarca de Machadinho do Oeste”.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JurisdicaoOpenSearch(
            long? codigo,
            string? nome)
        {
            this.Codigo = codigo;
            this.Nome = nome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JurisdicaoOpenSearch" /> class.
        /// </summary>
        public JurisdicaoOpenSearch()
        {
        }

    }
}