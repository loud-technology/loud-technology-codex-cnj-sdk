
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessoMetricaCasosNovosOpenSearch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroProcesso")]
        public string? NumeroProcesso { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessoMetricaCasosNovosOpenSearch" /> class.
        /// </summary>
        /// <param name="numeroProcesso"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessoMetricaCasosNovosOpenSearch(
            string? numeroProcesso)
        {
            this.NumeroProcesso = numeroProcesso;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessoMetricaCasosNovosOpenSearch" /> class.
        /// </summary>
        public ProcessoMetricaCasosNovosOpenSearch()
        {
        }

    }
}