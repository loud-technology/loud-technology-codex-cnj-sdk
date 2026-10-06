
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompetenciaS3
    {
        /// <summary>
        /// identificador da competência
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// identificador do local vinculado à competência
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idLocal")]
        public long? IdLocal { get; set; }

        /// <summary>
        /// nome descritivo da competência
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompetenciaS3" /> class.
        /// </summary>
        /// <param name="id">
        /// identificador da competência
        /// </param>
        /// <param name="idLocal">
        /// identificador do local vinculado à competência
        /// </param>
        /// <param name="nome">
        /// nome descritivo da competência
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompetenciaS3(
            long? id,
            long? idLocal,
            string? nome)
        {
            this.Id = id;
            this.IdLocal = idLocal;
            this.Nome = nome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompetenciaS3" /> class.
        /// </summary>
        public CompetenciaS3()
        {
        }

    }
}