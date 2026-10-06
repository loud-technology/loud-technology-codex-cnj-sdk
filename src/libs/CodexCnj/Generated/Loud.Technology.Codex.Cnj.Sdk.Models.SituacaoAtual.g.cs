
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SituacaoAtual
    {
        /// <summary>
        /// Refere-se à data início da situação atual do processo. Exemplo: "2023-01-01T12:00:00". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataInicio")]
        public string? DataInicio { get; set; }

        /// <summary>
        /// Endereço de endpoint da situação relacionada. Exemplo: "/situacao/07024621520178070003".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipo")]
        public global::Loud.Technology.Codex.Cnj.Sdk.TipoSituacaoAtual? Tipo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgaoJulgador")]
        public global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorSituacaoAtualOpenSearch? OrgaoJulgador { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SituacaoAtual" /> class.
        /// </summary>
        /// <param name="dataInicio">
        /// Refere-se à data início da situação atual do processo. Exemplo: "2023-01-01T12:00:00". 
        /// </param>
        /// <param name="href">
        /// Endereço de endpoint da situação relacionada. Exemplo: "/situacao/07024621520178070003".
        /// </param>
        /// <param name="tipo"></param>
        /// <param name="orgaoJulgador"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SituacaoAtual(
            string? dataInicio,
            string? href,
            global::Loud.Technology.Codex.Cnj.Sdk.TipoSituacaoAtual? tipo,
            global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorSituacaoAtualOpenSearch? orgaoJulgador)
        {
            this.DataInicio = dataInicio;
            this.Href = href;
            this.Tipo = tipo;
            this.OrgaoJulgador = orgaoJulgador;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SituacaoAtual" /> class.
        /// </summary>
        public SituacaoAtual()
        {
        }

    }
}