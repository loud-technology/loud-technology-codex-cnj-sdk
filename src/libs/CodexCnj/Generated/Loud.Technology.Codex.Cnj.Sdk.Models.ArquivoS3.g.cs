
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ArquivoS3
    {
        /// <summary>
        /// Identificador do arquivo. Exemplo: "50235a19-e4e5-5292-aca3-981904f3bf6c".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Identificador do arquivo no Codex. Exemplo: 12345678910.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idCodex")]
        public long? IdCodex { get; set; }

        /// <summary>
        /// Tipo de arquivo. Pode ser um dos 23 valores pré-definidos, abrangendo documentos (doc, docx, odt, pdf), imagens (vários formatos), áudio (vários formatos), vídeo (vários formatos) ou não identificado. Exemplo: "TEXT_HTML".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipo")]
        public string? Tipo { get; set; }

        /// <summary>
        /// Quantidade de páginas no documento. Exemplo: 10.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantidadePaginas")]
        public long? QuantidadePaginas { get; set; }

        /// <summary>
        /// Quantidade de imagens no documento. Exemplo: 5.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantidadeImagens")]
        public long? QuantidadeImagens { get; set; }

        /// <summary>
        /// Tamanho do arquivo em bytes. Exemplo: 12345.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tamanho")]
        public long? Tamanho { get; set; }

        /// <summary>
        /// Tamanho do texto do arquivo em quantidade de caracteres. Exemplo: 12345.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tamanhoTexto")]
        public long? TamanhoTexto { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ArquivoS3" /> class.
        /// </summary>
        /// <param name="id">
        /// Identificador do arquivo. Exemplo: "50235a19-e4e5-5292-aca3-981904f3bf6c".
        /// </param>
        /// <param name="idCodex">
        /// Identificador do arquivo no Codex. Exemplo: 12345678910.
        /// </param>
        /// <param name="tipo">
        /// Tipo de arquivo. Pode ser um dos 23 valores pré-definidos, abrangendo documentos (doc, docx, odt, pdf), imagens (vários formatos), áudio (vários formatos), vídeo (vários formatos) ou não identificado. Exemplo: "TEXT_HTML".
        /// </param>
        /// <param name="quantidadePaginas">
        /// Quantidade de páginas no documento. Exemplo: 10.
        /// </param>
        /// <param name="quantidadeImagens">
        /// Quantidade de imagens no documento. Exemplo: 5.
        /// </param>
        /// <param name="tamanho">
        /// Tamanho do arquivo em bytes. Exemplo: 12345.
        /// </param>
        /// <param name="tamanhoTexto">
        /// Tamanho do texto do arquivo em quantidade de caracteres. Exemplo: 12345.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ArquivoS3(
            string? id,
            long? idCodex,
            string? tipo,
            long? quantidadePaginas,
            long? quantidadeImagens,
            long? tamanho,
            long? tamanhoTexto)
        {
            this.Id = id;
            this.IdCodex = idCodex;
            this.Tipo = tipo;
            this.QuantidadePaginas = quantidadePaginas;
            this.QuantidadeImagens = quantidadeImagens;
            this.Tamanho = tamanho;
            this.TamanhoTexto = tamanhoTexto;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ArquivoS3" /> class.
        /// </summary>
        public ArquivoS3()
        {
        }

    }
}