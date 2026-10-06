
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgaoJulgadorColegiadoOpenSearch
    {
        /// <summary>
        /// Identificador do órgão julgador colegiado local. Exemplo: 1234.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idLocal")]
        public long? IdLocal { get; set; }

        /// <summary>
        /// Descrição do nome do órgão julgador colegiado. Exemplo: "1ª Turma".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgaoJulgadorColegiadoOpenSearch" /> class.
        /// </summary>
        /// <param name="idLocal">
        /// Identificador do órgão julgador colegiado local. Exemplo: 1234.
        /// </param>
        /// <param name="nome">
        /// Descrição do nome do órgão julgador colegiado. Exemplo: "1ª Turma".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgaoJulgadorColegiadoOpenSearch(
            long? idLocal,
            string? nome)
        {
            this.IdLocal = idLocal;
            this.Nome = nome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgaoJulgadorColegiadoOpenSearch" /> class.
        /// </summary>
        public OrgaoJulgadorColegiadoOpenSearch()
        {
        }

    }
}