
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class JurisdicaoLocalS3
    {
        /// <summary>
        /// Identificador da jurisdição local relacionada ao órgão julgador. Exemplo: 12345.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Identificador de origem jurisdição local. Exemplo: 12345.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idOrigem")]
        public string? IdOrigem { get; set; }

        /// <summary>
        /// Refere-se à jurisdição territorial do órgão julgador local. Exemplos: "Tribunal de Justiça do Estado do Paraná", "Maceió".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="JurisdicaoLocalS3" /> class.
        /// </summary>
        /// <param name="id">
        /// Identificador da jurisdição local relacionada ao órgão julgador. Exemplo: 12345.
        /// </param>
        /// <param name="idOrigem">
        /// Identificador de origem jurisdição local. Exemplo: 12345.
        /// </param>
        /// <param name="nome">
        /// Refere-se à jurisdição territorial do órgão julgador local. Exemplos: "Tribunal de Justiça do Estado do Paraná", "Maceió".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public JurisdicaoLocalS3(
            long? id,
            string? idOrigem,
            string? nome)
        {
            this.Id = id;
            this.IdOrigem = idOrigem;
            this.Nome = nome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="JurisdicaoLocalS3" /> class.
        /// </summary>
        public JurisdicaoLocalS3()
        {
        }

    }
}