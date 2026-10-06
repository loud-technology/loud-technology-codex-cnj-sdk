
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TramiteInfoProcessoOpenSearchMinimo
    {
        /// <summary>
        /// Número do processo. Exemplo: "0001234-56.2023.8.26.0000". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroProcesso")]
        public string? NumeroProcesso { get; set; }

        /// <summary>
        /// Lista de tramitações referente às etapas ou ações que ocorrem durante o andamento de um processo judicial. A lista é formada em ordem decrescente por data de ajuizamento. Essas tramitações são agrupadas e ordenadas de acordo com a entrada na base de dados, podendo incluir diversas atividades processuais, como movimentações de partes, documentos anexados e outros eventos relevantes dentro do processo. Cada uma dessas ações é sincronizada e registrada com uma data específica que reflete o momento em que ocorreu dentro do sistema.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tramitacoes")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.TramitacaoOpenSearchMinimo>? Tramitacoes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TramiteInfoProcessoOpenSearchMinimo" /> class.
        /// </summary>
        /// <param name="numeroProcesso">
        /// Número do processo. Exemplo: "0001234-56.2023.8.26.0000". 
        /// </param>
        /// <param name="tramitacoes">
        /// Lista de tramitações referente às etapas ou ações que ocorrem durante o andamento de um processo judicial. A lista é formada em ordem decrescente por data de ajuizamento. Essas tramitações são agrupadas e ordenadas de acordo com a entrada na base de dados, podendo incluir diversas atividades processuais, como movimentações de partes, documentos anexados e outros eventos relevantes dentro do processo. Cada uma dessas ações é sincronizada e registrada com uma data específica que reflete o momento em que ocorreu dentro do sistema.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TramiteInfoProcessoOpenSearchMinimo(
            string? numeroProcesso,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.TramitacaoOpenSearchMinimo>? tramitacoes)
        {
            this.NumeroProcesso = numeroProcesso;
            this.Tramitacoes = tramitacoes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TramiteInfoProcessoOpenSearchMinimo" /> class.
        /// </summary>
        public TramiteInfoProcessoOpenSearchMinimo()
        {
        }

    }
}