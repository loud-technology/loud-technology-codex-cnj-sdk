
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DistribuicoesS3
    {
        /// <summary>
        /// Registro de qual a sequência da distribuição no referido processo. Exemplo: “1“ ; “2 “ ; “3” 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequencia")]
        public long? Sequencia { get; set; }

        /// <summary>
        /// Data e hora da distribuição. Exemplo: "2023-01-01T12:00:00". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHora")]
        public string? DataHora { get; set; }

        /// <summary>
        /// Uso de controle interno que não é objeto de consumo negocial. Identificador da distribuição. Número gerado pelo próprio sistema. Exemplo: ""69cafeb9-8c22-5e7d-b104-15d47db84474"".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Identificador da distribuição no Codex. Exemplo: 123456789.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idCodex")]
        public long? IdCodex { get; set; }

        /// <summary>
        /// Lista de Órgão julgador. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgaoJulgador")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorS3>? OrgaoJulgador { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgaoJulgadorLocal")]
        public global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorLocalS3? OrgaoJulgadorLocal { get; set; }

        /// <summary>
        /// Lista de Órgão julgador colegiado. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgaoJulgadorColegiado")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorColegiadoS3>? OrgaoJulgadorColegiado { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DistribuicoesS3" /> class.
        /// </summary>
        /// <param name="sequencia">
        /// Registro de qual a sequência da distribuição no referido processo. Exemplo: “1“ ; “2 “ ; “3” 
        /// </param>
        /// <param name="dataHora">
        /// Data e hora da distribuição. Exemplo: "2023-01-01T12:00:00". 
        /// </param>
        /// <param name="id">
        /// Uso de controle interno que não é objeto de consumo negocial. Identificador da distribuição. Número gerado pelo próprio sistema. Exemplo: ""69cafeb9-8c22-5e7d-b104-15d47db84474"".
        /// </param>
        /// <param name="idCodex">
        /// Identificador da distribuição no Codex. Exemplo: 123456789.
        /// </param>
        /// <param name="orgaoJulgador">
        /// Lista de Órgão julgador. 
        /// </param>
        /// <param name="orgaoJulgadorLocal"></param>
        /// <param name="orgaoJulgadorColegiado">
        /// Lista de Órgão julgador colegiado. 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DistribuicoesS3(
            long? sequencia,
            string? dataHora,
            string? id,
            long? idCodex,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorS3>? orgaoJulgador,
            global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorLocalS3? orgaoJulgadorLocal,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorColegiadoS3>? orgaoJulgadorColegiado)
        {
            this.Sequencia = sequencia;
            this.DataHora = dataHora;
            this.Id = id;
            this.IdCodex = idCodex;
            this.OrgaoJulgador = orgaoJulgador;
            this.OrgaoJulgadorLocal = orgaoJulgadorLocal;
            this.OrgaoJulgadorColegiado = orgaoJulgadorColegiado;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DistribuicoesS3" /> class.
        /// </summary>
        public DistribuicoesS3()
        {
        }

    }
}