
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CustomSearchAfterResponseProcessoMetricaCasosBaixadosOpenSearch
    {
        /// <summary>
        /// Total de registros para a busca realizada. Exemplo: 1000.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total")]
        public long? Total { get; set; }

        /// <summary>
        /// Quantidade de registros para a busca realizada. Exemplo: 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numberOfElements")]
        public int? NumberOfElements { get; set; }

        /// <summary>
        /// Quantidade máxima de registros que podem ser retornados por consulta. Exemplo: 100.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxElementsSize")]
        public long? MaxElementsSize { get; set; }

        /// <summary>
        /// Timestamp da data/hora do último movimento e Id do processo, sendo ambos os valores retornados na busca anterior para essa propriedade. Os valores devem estar separados por vírgula. A busca será realizada a partir desse ponto. Exemplo: 1744391412000,"50421427220248240090".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("searchAfter")]
        public global::System.Collections.Generic.IList<object>? SearchAfter { get; set; }

        /// <summary>
        /// Lista de processos retornados na consulta.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.ProcessoMetricaCasosBaixadosOpenSearch>? Content { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSearchAfterResponseProcessoMetricaCasosBaixadosOpenSearch" /> class.
        /// </summary>
        /// <param name="total">
        /// Total de registros para a busca realizada. Exemplo: 1000.
        /// </param>
        /// <param name="numberOfElements">
        /// Quantidade de registros para a busca realizada. Exemplo: 100.
        /// </param>
        /// <param name="maxElementsSize">
        /// Quantidade máxima de registros que podem ser retornados por consulta. Exemplo: 100.
        /// </param>
        /// <param name="searchAfter">
        /// Timestamp da data/hora do último movimento e Id do processo, sendo ambos os valores retornados na busca anterior para essa propriedade. Os valores devem estar separados por vírgula. A busca será realizada a partir desse ponto. Exemplo: 1744391412000,"50421427220248240090".
        /// </param>
        /// <param name="content">
        /// Lista de processos retornados na consulta.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CustomSearchAfterResponseProcessoMetricaCasosBaixadosOpenSearch(
            long? total,
            int? numberOfElements,
            long? maxElementsSize,
            global::System.Collections.Generic.IList<object>? searchAfter,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.ProcessoMetricaCasosBaixadosOpenSearch>? content)
        {
            this.Total = total;
            this.NumberOfElements = numberOfElements;
            this.MaxElementsSize = maxElementsSize;
            this.SearchAfter = searchAfter;
            this.Content = content;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomSearchAfterResponseProcessoMetricaCasosBaixadosOpenSearch" /> class.
        /// </summary>
        public CustomSearchAfterResponseProcessoMetricaCasosBaixadosOpenSearch()
        {
        }

    }
}