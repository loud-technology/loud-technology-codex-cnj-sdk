
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OrgaoJulgadorS3
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tribunal")]
        public global::Loud.Technology.Codex.Cnj.Sdk.TribunalOrgaoJulgadorS3? Tribunal { get; set; }

        /// <summary>
        /// Identificador do órgão julgador. Exemplo: 12345.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Identificador do órgão julgador local. Exemplo: 123456.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idLocal")]
        public long? IdLocal { get; set; }

        /// <summary>
        /// Nome do órgão julgador. Exemplo: "1ª Vara Cível". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jurisdicao")]
        public global::Loud.Technology.Codex.Cnj.Sdk.JurisdicaoS3? Jurisdicao { get; set; }

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
        /// Initializes a new instance of the <see cref="OrgaoJulgadorS3" /> class.
        /// </summary>
        /// <param name="tribunal"></param>
        /// <param name="id">
        /// Identificador do órgão julgador. Exemplo: 12345.
        /// </param>
        /// <param name="idLocal">
        /// Identificador do órgão julgador local. Exemplo: 123456.
        /// </param>
        /// <param name="nome">
        /// Nome do órgão julgador. Exemplo: "1ª Vara Cível". 
        /// </param>
        /// <param name="jurisdicao"></param>
        /// <param name="ibge"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrgaoJulgadorS3(
            global::Loud.Technology.Codex.Cnj.Sdk.TribunalOrgaoJulgadorS3? tribunal,
            long? id,
            long? idLocal,
            string? nome,
            global::Loud.Technology.Codex.Cnj.Sdk.JurisdicaoS3? jurisdicao,
            global::Loud.Technology.Codex.Cnj.Sdk.DadosIBGE? ibge)
        {
            this.Tribunal = tribunal;
            this.Id = id;
            this.IdLocal = idLocal;
            this.Nome = nome;
            this.Jurisdicao = jurisdicao;
            this.Ibge = ibge;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgaoJulgadorS3" /> class.
        /// </summary>
        public OrgaoJulgadorS3()
        {
        }

    }
}