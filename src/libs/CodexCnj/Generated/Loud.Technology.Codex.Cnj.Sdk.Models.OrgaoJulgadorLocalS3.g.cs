
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgaoJulgadorLocalS3
    {
        /// <summary>
        /// Identificador do órgão julgador local. Exemplo: 12345.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Nome do órgão julgador local. Exemplo: "1ª Vara Cível". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Identificador de origemdo órgão julgador local. Exemplo: 12345.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idOrigem")]
        public string? IdOrigem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jurisdicaoLocal")]
        public global::Loud.Technology.Codex.Cnj.Sdk.JurisdicaoLocalS3? JurisdicaoLocal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgaoJulgadorLocalS3" /> class.
        /// </summary>
        /// <param name="id">
        /// Identificador do órgão julgador local. Exemplo: 12345.
        /// </param>
        /// <param name="nome">
        /// Nome do órgão julgador local. Exemplo: "1ª Vara Cível". 
        /// </param>
        /// <param name="idOrigem">
        /// Identificador de origemdo órgão julgador local. Exemplo: 12345.
        /// </param>
        /// <param name="jurisdicaoLocal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgaoJulgadorLocalS3(
            long? id,
            string? nome,
            string? idOrigem,
            global::Loud.Technology.Codex.Cnj.Sdk.JurisdicaoLocalS3? jurisdicaoLocal)
        {
            this.Id = id;
            this.Nome = nome;
            this.IdOrigem = idOrigem;
            this.JurisdicaoLocal = jurisdicaoLocal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgaoJulgadorLocalS3" /> class.
        /// </summary>
        public OrgaoJulgadorLocalS3()
        {
        }

    }
}