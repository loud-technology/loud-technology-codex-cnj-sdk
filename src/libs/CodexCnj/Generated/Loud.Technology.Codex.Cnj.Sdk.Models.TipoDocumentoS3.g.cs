
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TipoDocumentoS3
    {
        /// <summary>
        /// Código do tipo de documento, conforme TPU de documentos processuais. Exemplo: "550".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codigo")]
        public long? Codigo { get; set; }

        /// <summary>
        /// Nome do tipo de documento, conforme TPU de documentos processuais. Exemplo: "Sentença".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Identificador do tipo de documento no Codex. Exemplo: 1234567.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idCodex")]
        public long? IdCodex { get; set; }

        /// <summary>
        /// Identificador do tipo de documento na origem. Exemplo: "123".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idOrigem")]
        public string? IdOrigem { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TipoDocumentoS3" /> class.
        /// </summary>
        /// <param name="codigo">
        /// Código do tipo de documento, conforme TPU de documentos processuais. Exemplo: "550".
        /// </param>
        /// <param name="nome">
        /// Nome do tipo de documento, conforme TPU de documentos processuais. Exemplo: "Sentença".
        /// </param>
        /// <param name="idCodex">
        /// Identificador do tipo de documento no Codex. Exemplo: 1234567.
        /// </param>
        /// <param name="idOrigem">
        /// Identificador do tipo de documento na origem. Exemplo: "123".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TipoDocumentoS3(
            long? codigo,
            string? nome,
            long? idCodex,
            string? idOrigem)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.IdCodex = idCodex;
            this.IdOrigem = idOrigem;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TipoDocumentoS3" /> class.
        /// </summary>
        public TipoDocumentoS3()
        {
        }

    }
}