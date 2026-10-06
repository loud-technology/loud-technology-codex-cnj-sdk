
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TipoSituacaoAtualDTO
    {
        /// <summary>
        /// Id da situação
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Nome da situação
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TipoSituacaoAtualDTO" /> class.
        /// </summary>
        /// <param name="id">
        /// Id da situação
        /// </param>
        /// <param name="nome">
        /// Nome da situação
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TipoSituacaoAtualDTO(
            string? id,
            string? nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TipoSituacaoAtualDTO" /> class.
        /// </summary>
        public TipoSituacaoAtualDTO()
        {
        }

    }
}