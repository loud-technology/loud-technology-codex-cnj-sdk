
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TramitacaoSituacaoProcessualDTO
    {
        /// <summary>
        /// Id do processo no Codex
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idCodex")]
        public string? IdCodex { get; set; }

        /// <summary>
        /// Tribunal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tribunal")]
        public string? Tribunal { get; set; }

        /// <summary>
        /// Instância
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instancia")]
        public string? Instancia { get; set; }

        /// <summary>
        /// Fase
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fase")]
        public string? Fase { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("situacaoAtual")]
        public global::Loud.Technology.Codex.Cnj.Sdk.SituacaoAtualDTO? SituacaoAtual { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TramitacaoSituacaoProcessualDTO" /> class.
        /// </summary>
        /// <param name="idCodex">
        /// Id do processo no Codex
        /// </param>
        /// <param name="tribunal">
        /// Tribunal
        /// </param>
        /// <param name="instancia">
        /// Instância
        /// </param>
        /// <param name="fase">
        /// Fase
        /// </param>
        /// <param name="situacaoAtual"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TramitacaoSituacaoProcessualDTO(
            string? idCodex,
            string? tribunal,
            string? instancia,
            string? fase,
            global::Loud.Technology.Codex.Cnj.Sdk.SituacaoAtualDTO? situacaoAtual)
        {
            this.IdCodex = idCodex;
            this.Tribunal = tribunal;
            this.Instancia = instancia;
            this.Fase = fase;
            this.SituacaoAtual = situacaoAtual;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TramitacaoSituacaoProcessualDTO" /> class.
        /// </summary>
        public TramitacaoSituacaoProcessualDTO()
        {
        }

    }
}