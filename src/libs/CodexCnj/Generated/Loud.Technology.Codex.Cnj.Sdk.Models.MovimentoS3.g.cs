
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MovimentoS3
    {
        /// <summary>
        /// Sequência do movimento dentro da distribuição. Trata-se de um número sequencial de acordo com a ordenação descendente da data do movimento Exemplo: 3, 2, 1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequencia")]
        public long? Sequencia { get; set; }

        /// <summary>
        /// Data e hora do movimento. Exemplo: "2023-01-01T12:00:00". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHora")]
        public string? DataHora { get; set; }

        /// <summary>
        /// Identificador da distribuição relacionada ao movimento. Exemplo: "797d82a6-e945-52a1-b22e-e81c9b83c914".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idDistribuicao")]
        public string? IdDistribuicao { get; set; }

        /// <summary>
        /// Identificador do movimento no Codex. Exemplo: 123456789101.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idCodex")]
        public long? IdCodex { get; set; }

        /// <summary>
        /// Identificador do movimento na origem. Exemplo: “SG5SP_RI004NLBJ12KW_33”.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idOrigem")]
        public string? IdOrigem { get; set; }

        /// <summary>
        /// Descrição do movimento lançado. Exemplo: "Arquivado Definitivamente".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descricao")]
        public string? Descricao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classe")]
        public global::Loud.Technology.Codex.Cnj.Sdk.ClasseMovimentoS3? Classe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipo")]
        public global::Loud.Technology.Codex.Cnj.Sdk.TipoMovimentoS3? Tipo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgaoJulgador")]
        public global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorMovimentoS3? OrgaoJulgador { get; set; }

        /// <summary>
        /// Identificador do documento. Exemplo: 12345 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idDocumento")]
        public string? IdDocumento { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("magistrado")]
        public global::Loud.Technology.Codex.Cnj.Sdk.MagistradoS3? Magistrado { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usuario")]
        public global::Loud.Technology.Codex.Cnj.Sdk.UsuarioS3? Usuario { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MovimentoS3" /> class.
        /// </summary>
        /// <param name="sequencia">
        /// Sequência do movimento dentro da distribuição. Trata-se de um número sequencial de acordo com a ordenação descendente da data do movimento Exemplo: 3, 2, 1.
        /// </param>
        /// <param name="dataHora">
        /// Data e hora do movimento. Exemplo: "2023-01-01T12:00:00". 
        /// </param>
        /// <param name="idDistribuicao">
        /// Identificador da distribuição relacionada ao movimento. Exemplo: "797d82a6-e945-52a1-b22e-e81c9b83c914".
        /// </param>
        /// <param name="idCodex">
        /// Identificador do movimento no Codex. Exemplo: 123456789101.
        /// </param>
        /// <param name="idOrigem">
        /// Identificador do movimento na origem. Exemplo: “SG5SP_RI004NLBJ12KW_33”.
        /// </param>
        /// <param name="descricao">
        /// Descrição do movimento lançado. Exemplo: "Arquivado Definitivamente".
        /// </param>
        /// <param name="classe"></param>
        /// <param name="tipo"></param>
        /// <param name="orgaoJulgador"></param>
        /// <param name="idDocumento">
        /// Identificador do documento. Exemplo: 12345 
        /// </param>
        /// <param name="magistrado"></param>
        /// <param name="usuario"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MovimentoS3(
            long? sequencia,
            string? dataHora,
            string? idDistribuicao,
            long? idCodex,
            string? idOrigem,
            string? descricao,
            global::Loud.Technology.Codex.Cnj.Sdk.ClasseMovimentoS3? classe,
            global::Loud.Technology.Codex.Cnj.Sdk.TipoMovimentoS3? tipo,
            global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorMovimentoS3? orgaoJulgador,
            string? idDocumento,
            global::Loud.Technology.Codex.Cnj.Sdk.MagistradoS3? magistrado,
            global::Loud.Technology.Codex.Cnj.Sdk.UsuarioS3? usuario)
        {
            this.Sequencia = sequencia;
            this.DataHora = dataHora;
            this.IdDistribuicao = idDistribuicao;
            this.IdCodex = idCodex;
            this.IdOrigem = idOrigem;
            this.Descricao = descricao;
            this.Classe = classe;
            this.Tipo = tipo;
            this.OrgaoJulgador = orgaoJulgador;
            this.IdDocumento = idDocumento;
            this.Magistrado = magistrado;
            this.Usuario = usuario;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MovimentoS3" /> class.
        /// </summary>
        public MovimentoS3()
        {
        }

    }
}