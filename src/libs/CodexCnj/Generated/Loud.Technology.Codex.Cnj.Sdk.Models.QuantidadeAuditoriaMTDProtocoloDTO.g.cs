
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class QuantidadeAuditoriaMTDProtocoloDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instancia")]
        public string? Instancia { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantidade")]
        public int? Quantidade { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantidadeAuditoriaMTDProtocoloDTO" /> class.
        /// </summary>
        /// <param name="instancia"></param>
        /// <param name="quantidade"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QuantidadeAuditoriaMTDProtocoloDTO(
            string? instancia,
            int? quantidade)
        {
            this.Instancia = instancia;
            this.Quantidade = quantidade;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QuantidadeAuditoriaMTDProtocoloDTO" /> class.
        /// </summary>
        public QuantidadeAuditoriaMTDProtocoloDTO()
        {
        }

    }
}