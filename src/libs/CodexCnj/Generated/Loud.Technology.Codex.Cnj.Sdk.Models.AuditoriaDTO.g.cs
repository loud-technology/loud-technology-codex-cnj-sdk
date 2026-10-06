
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuditoriaDTO
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("@timestamp")]
        public string? x_timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classe")]
        public string? Classe { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clientId")]
        public string? ClientId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idFonteDadosCodex")]
        public string? IdFonteDadosCodex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modulo")]
        public string? Modulo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oab")]
        public string? Oab { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parametro")]
        public string? Parametro { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projeto")]
        public string? Projeto { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requisicao")]
        public string? Requisicao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("retorno")]
        public string? Retorno { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("siglaTribunal")]
        public string? SiglaTribunal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusCode")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tempoExecucao")]
        public long? TempoExecucao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tempoExpiracaoToken")]
        public int? TempoExpiracaoToken { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uriRequisicao")]
        public string? UriRequisicao { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usuario")]
        public string? Usuario { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditoriaDTO" /> class.
        /// </summary>
        /// <param name="x_timestamp"></param>
        /// <param name="classe"></param>
        /// <param name="clientId"></param>
        /// <param name="email"></param>
        /// <param name="idFonteDadosCodex"></param>
        /// <param name="modulo"></param>
        /// <param name="nome"></param>
        /// <param name="oab"></param>
        /// <param name="parametro"></param>
        /// <param name="projeto"></param>
        /// <param name="requisicao"></param>
        /// <param name="retorno"></param>
        /// <param name="siglaTribunal"></param>
        /// <param name="statusCode"></param>
        /// <param name="tempoExecucao"></param>
        /// <param name="tempoExpiracaoToken"></param>
        /// <param name="uriRequisicao"></param>
        /// <param name="usuario"></param>
        /// <param name="uuid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditoriaDTO(
            string? x_timestamp,
            string? classe,
            string? clientId,
            string? email,
            string? idFonteDadosCodex,
            string? modulo,
            string? nome,
            string? oab,
            string? parametro,
            string? projeto,
            string? requisicao,
            string? retorno,
            string? siglaTribunal,
            int? statusCode,
            long? tempoExecucao,
            int? tempoExpiracaoToken,
            string? uriRequisicao,
            string? usuario,
            string? uuid)
        {
            this.x_timestamp = x_timestamp;
            this.Classe = classe;
            this.ClientId = clientId;
            this.Email = email;
            this.IdFonteDadosCodex = idFonteDadosCodex;
            this.Modulo = modulo;
            this.Nome = nome;
            this.Oab = oab;
            this.Parametro = parametro;
            this.Projeto = projeto;
            this.Requisicao = requisicao;
            this.Retorno = retorno;
            this.SiglaTribunal = siglaTribunal;
            this.StatusCode = statusCode;
            this.TempoExecucao = tempoExecucao;
            this.TempoExpiracaoToken = tempoExpiracaoToken;
            this.UriRequisicao = uriRequisicao;
            this.Usuario = usuario;
            this.Uuid = uuid;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditoriaDTO" /> class.
        /// </summary>
        public AuditoriaDTO()
        {
        }

    }
}