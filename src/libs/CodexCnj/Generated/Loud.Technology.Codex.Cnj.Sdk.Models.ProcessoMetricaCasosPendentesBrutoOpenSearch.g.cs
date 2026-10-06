
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessoMetricaCasosPendentesBrutoOpenSearch
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroProcesso")]
        public string? NumeroProcesso { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("situacao")]
        public string? Situacao { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessoMetricaCasosPendentesBrutoOpenSearch" /> class.
        /// </summary>
        /// <param name="numeroProcesso"></param>
        /// <param name="situacao"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessoMetricaCasosPendentesBrutoOpenSearch(
            string? numeroProcesso,
            string? situacao)
        {
            this.NumeroProcesso = numeroProcesso;
            this.Situacao = situacao;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessoMetricaCasosPendentesBrutoOpenSearch" /> class.
        /// </summary>
        public ProcessoMetricaCasosPendentesBrutoOpenSearch()
        {
        }

    }
}