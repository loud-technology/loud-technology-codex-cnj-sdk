
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgaoJulgadorSituacaoAtualOpenSearch
    {
        /// <summary>
        /// Identificador do órgão julgador. Exemplo: 12345.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Nome do órgão julgador. Exemplos:  "GABINETE - DESEMBARGADOR DO TRABALHO PAULINO COUTO", “CENTRAL DE MANDADOS DE BLUMENAU”  ;   “3ª VARA DO TRABALHO DE ARACAJU” . 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgaoJulgadorSituacaoAtualOpenSearch" /> class.
        /// </summary>
        /// <param name="id">
        /// Identificador do órgão julgador. Exemplo: 12345.
        /// </param>
        /// <param name="nome">
        /// Nome do órgão julgador. Exemplos:  "GABINETE - DESEMBARGADOR DO TRABALHO PAULINO COUTO", “CENTRAL DE MANDADOS DE BLUMENAU”  ;   “3ª VARA DO TRABALHO DE ARACAJU” . 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgaoJulgadorSituacaoAtualOpenSearch(
            long? id,
            string? nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgaoJulgadorSituacaoAtualOpenSearch" /> class.
        /// </summary>
        public OrgaoJulgadorSituacaoAtualOpenSearch()
        {
        }

    }
}