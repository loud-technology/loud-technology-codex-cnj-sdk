
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgaoJulgadorOpenSearch
    {
        /// <summary>
        /// Identificador do órgão julgador. Exemplo: 12345.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Identificador do órgão julgador local. Exemplo: 312809.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idLocal")]
        public long? IdLocal { get; set; }

        /// <summary>
        /// Nome do órgão julgador. Exemplos:  "GABINETE - DESEMBARGADOR DO TRABALHO PAULINO COUTO", “CENTRAL DE MANDADOS DE BLUMENAU”  ;   “3ª VARA DO TRABALHO DE ARACAJU” . 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ibge")]
        public global::Loud.Technology.Codex.Cnj.Sdk.DadosIBGE? Ibge { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgaoJulgadorOpenSearch" /> class.
        /// </summary>
        /// <param name="id">
        /// Identificador do órgão julgador. Exemplo: 12345.
        /// </param>
        /// <param name="idLocal">
        /// Identificador do órgão julgador local. Exemplo: 312809.
        /// </param>
        /// <param name="nome">
        /// Nome do órgão julgador. Exemplos:  "GABINETE - DESEMBARGADOR DO TRABALHO PAULINO COUTO", “CENTRAL DE MANDADOS DE BLUMENAU”  ;   “3ª VARA DO TRABALHO DE ARACAJU” . 
        /// </param>
        /// <param name="ibge"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgaoJulgadorOpenSearch(
            long? id,
            long? idLocal,
            string? nome,
            global::Loud.Technology.Codex.Cnj.Sdk.DadosIBGE? ibge)
        {
            this.Id = id;
            this.IdLocal = idLocal;
            this.Nome = nome;
            this.Ibge = ibge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgaoJulgadorOpenSearch" /> class.
        /// </summary>
        public OrgaoJulgadorOpenSearch()
        {
        }

    }
}