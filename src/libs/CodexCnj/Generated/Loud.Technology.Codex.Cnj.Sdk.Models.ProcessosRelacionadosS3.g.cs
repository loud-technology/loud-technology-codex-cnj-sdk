
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProcessosRelacionadosS3
    {
        /// <summary>
        /// Número do processo relacionado. Exemplo: "00151615520198160069".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroProcesso")]
        public string? NumeroProcesso { get; set; }

        /// <summary>
        /// Endereço de endpoint do processo relacionado. Exemplo: "/processos/00090367120198160069".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("href")]
        public string? Href { get; set; }

        /// <summary>
        /// Identificador do processo relacionado no Codex. Exemplo: 123456789.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idCodex")]
        public long? IdCodex { get; set; }

        /// <summary>
        /// Identificador do processo relacionado na origem. Exemplo: "12345678910".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idOrigem")]
        public string? IdOrigem { get; set; }

        /// <summary>
        /// Tipo de relação entre o processo relacionado e o processo principal. Exemplo: "CONEXAO", "DEPENDENCIA", "OUTRO_TIPO_ASSOCIACAO".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipoRelacao")]
        public string? TipoRelacao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classe")]
        public global::Loud.Technology.Codex.Cnj.Sdk.ClasseProcessoRelacionadoS3? Classe { get; set; }

        /// <summary>
        /// Determina se o processo relacionado está ativo ou não. Valores permitidos: true, false. Exemplo: "true".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ativo")]
        public bool? Ativo { get; set; }

        /// <summary>
        /// Data e hora da exclusão do processo relacionado. Exemplo: “2023-01-01T12:00:00”
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHoraExclusao")]
        public string? DataHoraExclusao { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessosRelacionadosS3" /> class.
        /// </summary>
        /// <param name="numeroProcesso">
        /// Número do processo relacionado. Exemplo: "00151615520198160069".
        /// </param>
        /// <param name="href">
        /// Endereço de endpoint do processo relacionado. Exemplo: "/processos/00090367120198160069".
        /// </param>
        /// <param name="idCodex">
        /// Identificador do processo relacionado no Codex. Exemplo: 123456789.
        /// </param>
        /// <param name="idOrigem">
        /// Identificador do processo relacionado na origem. Exemplo: "12345678910".
        /// </param>
        /// <param name="tipoRelacao">
        /// Tipo de relação entre o processo relacionado e o processo principal. Exemplo: "CONEXAO", "DEPENDENCIA", "OUTRO_TIPO_ASSOCIACAO".
        /// </param>
        /// <param name="classe"></param>
        /// <param name="ativo">
        /// Determina se o processo relacionado está ativo ou não. Valores permitidos: true, false. Exemplo: "true".
        /// </param>
        /// <param name="dataHoraExclusao">
        /// Data e hora da exclusão do processo relacionado. Exemplo: “2023-01-01T12:00:00”
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProcessosRelacionadosS3(
            string? numeroProcesso,
            string? href,
            long? idCodex,
            string? idOrigem,
            string? tipoRelacao,
            global::Loud.Technology.Codex.Cnj.Sdk.ClasseProcessoRelacionadoS3? classe,
            bool? ativo,
            string? dataHoraExclusao)
        {
            this.NumeroProcesso = numeroProcesso;
            this.Href = href;
            this.IdCodex = idCodex;
            this.IdOrigem = idOrigem;
            this.TipoRelacao = tipoRelacao;
            this.Classe = classe;
            this.Ativo = ativo;
            this.DataHoraExclusao = dataHoraExclusao;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessosRelacionadosS3" /> class.
        /// </summary>
        public ProcessosRelacionadosS3()
        {
        }

    }
}