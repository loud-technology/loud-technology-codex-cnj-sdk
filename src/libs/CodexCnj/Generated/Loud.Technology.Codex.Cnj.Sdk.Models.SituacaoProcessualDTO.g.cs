
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SituacaoProcessualDTO
    {
        /// <summary>
        /// Id do processo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Número do processo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numero")]
        public string? Numero { get; set; }

        /// <summary>
        /// Lista de tramitações do processo
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tramitacoes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.TramitacaoSituacaoProcessualDTO>? Tramitacoes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SituacaoProcessualDTO" /> class.
        /// </summary>
        /// <param name="id">
        /// Id do processo
        /// </param>
        /// <param name="numero">
        /// Número do processo
        /// </param>
        /// <param name="tramitacoes">
        /// Lista de tramitações do processo
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SituacaoProcessualDTO(
            string? id,
            string? numero,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.TramitacaoSituacaoProcessualDTO>? tramitacoes)
        {
            this.Id = id;
            this.Numero = numero;
            this.Tramitacoes = tramitacoes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SituacaoProcessualDTO" /> class.
        /// </summary>
        public SituacaoProcessualDTO()
        {
        }

    }
}