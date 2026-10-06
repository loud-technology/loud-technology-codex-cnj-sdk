
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TribunalQuantidadeDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantidade")]
        public long? Quantidade { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tribunal")]
        public string? Tribunal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TribunalQuantidadeDTO" /> class.
        /// </summary>
        /// <param name="quantidade"></param>
        /// <param name="tribunal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TribunalQuantidadeDTO(
            long? quantidade,
            string? tribunal)
        {
            this.Quantidade = quantidade;
            this.Tribunal = tribunal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TribunalQuantidadeDTO" /> class.
        /// </summary>
        public TribunalQuantidadeDTO()
        {
        }

    }
}