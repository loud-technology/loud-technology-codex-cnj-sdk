
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HistoricoS3
    {
        /// <summary>
        /// Sequência do histórico da classe ordenado de forma ascendente pela data_inicio da própria classe. Exemplo: 1; 2; 3 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequencia")]
        public long? Sequencia { get; set; }

        /// <summary>
        /// Data e hora de início do histórico. Exemplo: "2023-01-01T12:00:00". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHoraInicio")]
        public string? DataHoraInicio { get; set; }

        /// <summary>
        /// Data e hora de fim do histórico. Exemplo: "2023-01-01T12:00:00". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHoraFim")]
        public string? DataHoraFim { get; set; }

        /// <summary>
        /// Código da classe histórica conforme TPU de classes. Exemplo: "12193".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codigo")]
        public long? Codigo { get; set; }

        /// <summary>
        /// Nome da classe histórica de acordo com TPU de classes. Exemplo: “Prestação de Contas Eleitorais”.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descricao")]
        public string? Descricao { get; set; }

        /// <summary>
        /// Ordem crescente da classe histórica em relação aos níveis da TPU de classes. Exemplo: "(12193) Prestação de Contas Eleitorais | (11529) Procedimentos Relativos a Realização de Eleição | (11427) PROCESSO ELEITORAL".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarquia")]
        public string? Hierarquia { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricoS3" /> class.
        /// </summary>
        /// <param name="sequencia">
        /// Sequência do histórico da classe ordenado de forma ascendente pela data_inicio da própria classe. Exemplo: 1; 2; 3 
        /// </param>
        /// <param name="dataHoraInicio">
        /// Data e hora de início do histórico. Exemplo: "2023-01-01T12:00:00". 
        /// </param>
        /// <param name="dataHoraFim">
        /// Data e hora de fim do histórico. Exemplo: "2023-01-01T12:00:00". 
        /// </param>
        /// <param name="codigo">
        /// Código da classe histórica conforme TPU de classes. Exemplo: "12193".
        /// </param>
        /// <param name="descricao">
        /// Nome da classe histórica de acordo com TPU de classes. Exemplo: “Prestação de Contas Eleitorais”.
        /// </param>
        /// <param name="hierarquia">
        /// Ordem crescente da classe histórica em relação aos níveis da TPU de classes. Exemplo: "(12193) Prestação de Contas Eleitorais | (11529) Procedimentos Relativos a Realização de Eleição | (11427) PROCESSO ELEITORAL".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HistoricoS3(
            long? sequencia,
            string? dataHoraInicio,
            string? dataHoraFim,
            long? codigo,
            string? descricao,
            string? hierarquia)
        {
            this.Sequencia = sequencia;
            this.DataHoraInicio = dataHoraInicio;
            this.DataHoraFim = dataHoraFim;
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Hierarquia = hierarquia;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HistoricoS3" /> class.
        /// </summary>
        public HistoricoS3()
        {
        }

    }
}