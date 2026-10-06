
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class EstatisticaOabDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("erro")]
        public string? Erro { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oab")]
        public string? Oab { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tribunais")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.TribunalQuantidadeDTO>? Tribunais { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EstatisticaOabDTO" /> class.
        /// </summary>
        /// <param name="erro"></param>
        /// <param name="oab"></param>
        /// <param name="tribunais"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EstatisticaOabDTO(
            string? erro,
            string? oab,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.TribunalQuantidadeDTO>? tribunais)
        {
            this.Erro = erro;
            this.Oab = oab;
            this.Tribunais = tribunais;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EstatisticaOabDTO" /> class.
        /// </summary>
        public EstatisticaOabDTO()
        {
        }

    }
}