
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuditoriaMTDProtocolo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("siglaTribunal")]
        public string? SiglaTribunal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instancia")]
        public string? Instancia { get; set; }

        /// <summary>
        /// Data e hora da última atualização do protocolo no Datalake. Exemplo: "2023-01-01T12:00:00".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHoraAtualizacao")]
        public string? DataHoraAtualizacao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public string? StatusCode { get; set; }

        /// <summary>
        /// Número do processo. Exemplo: "00012345620238260000". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numeroProcesso")]
        public string? NumeroProcesso { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocolos")]
        public global::Loud.Technology.Codex.Cnj.Sdk.Protocolo? Protocolos { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditoriaMTDProtocolo" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="siglaTribunal"></param>
        /// <param name="instancia"></param>
        /// <param name="dataHoraAtualizacao">
        /// Data e hora da última atualização do protocolo no Datalake. Exemplo: "2023-01-01T12:00:00".
        /// </param>
        /// <param name="statusCode"></param>
        /// <param name="numeroProcesso">
        /// Número do processo. Exemplo: "00012345620238260000". 
        /// </param>
        /// <param name="protocolos"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditoriaMTDProtocolo(
            string? id,
            string? siglaTribunal,
            string? instancia,
            string? dataHoraAtualizacao,
            string? statusCode,
            string? numeroProcesso,
            global::Loud.Technology.Codex.Cnj.Sdk.Protocolo? protocolos)
        {
            this.Id = id;
            this.SiglaTribunal = siglaTribunal;
            this.Instancia = instancia;
            this.DataHoraAtualizacao = dataHoraAtualizacao;
            this.StatusCode = statusCode;
            this.NumeroProcesso = numeroProcesso;
            this.Protocolos = protocolos;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditoriaMTDProtocolo" /> class.
        /// </summary>
        public AuditoriaMTDProtocolo()
        {
        }

    }
}