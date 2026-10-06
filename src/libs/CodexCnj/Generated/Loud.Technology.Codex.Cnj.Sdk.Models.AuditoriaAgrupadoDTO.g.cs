
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuditoriaAgrupadoDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("porDia")]
        public global::System.Collections.Generic.Dictionary<string, long>? PorDia { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("totalGeral")]
        public long? TotalGeral { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditoriaAgrupadoDTO" /> class.
        /// </summary>
        /// <param name="porDia"></param>
        /// <param name="totalGeral"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditoriaAgrupadoDTO(
            global::System.Collections.Generic.Dictionary<string, long>? porDia,
            long? totalGeral)
        {
            this.PorDia = porDia;
            this.TotalGeral = totalGeral;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditoriaAgrupadoDTO" /> class.
        /// </summary>
        public AuditoriaAgrupadoDTO()
        {
        }

    }
}