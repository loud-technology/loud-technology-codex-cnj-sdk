
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SituacaoAtualDTO
    {
        /// <summary>
        /// Data de ińicio
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataInicio")]
        public string? DataInicio { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipo")]
        public global::Loud.Technology.Codex.Cnj.Sdk.TipoSituacaoAtualDTO? Tipo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SituacaoAtualDTO" /> class.
        /// </summary>
        /// <param name="dataInicio">
        /// Data de ińicio
        /// </param>
        /// <param name="tipo"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SituacaoAtualDTO(
            string? dataInicio,
            global::Loud.Technology.Codex.Cnj.Sdk.TipoSituacaoAtualDTO? tipo)
        {
            this.DataInicio = dataInicio;
            this.Tipo = tipo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SituacaoAtualDTO" /> class.
        /// </summary>
        public SituacaoAtualDTO()
        {
        }

    }
}