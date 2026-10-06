
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Envio
    {
        /// <summary>
        /// Data e hora de envio do protocolo no Datalake. Exemplo: "2023-01-01T12:00:00".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHora")]
        public string? DataHora { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mensagem")]
        public string? Mensagem { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("protocolo")]
        public string? Protocolo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Envio" /> class.
        /// </summary>
        /// <param name="dataHora">
        /// Data e hora de envio do protocolo no Datalake. Exemplo: "2023-01-01T12:00:00".
        /// </param>
        /// <param name="mensagem"></param>
        /// <param name="protocolo"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Envio(
            string? dataHora,
            string? mensagem,
            string? protocolo,
            string? status)
        {
            this.DataHora = dataHora;
            this.Mensagem = mensagem;
            this.Protocolo = protocolo;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Envio" /> class.
        /// </summary>
        public Envio()
        {
        }

    }
}