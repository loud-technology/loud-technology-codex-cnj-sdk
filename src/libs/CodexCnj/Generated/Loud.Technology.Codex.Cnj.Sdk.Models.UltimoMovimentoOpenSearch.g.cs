
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UltimoMovimentoOpenSearch
    {
        /// <summary>
        /// O sistema gera uma lista de todos os movimentos do processo. Este atributo se refere ao número sequencial da última movimentação nessa lista. Exemplo: 21.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequencia")]
        public long? Sequencia { get; set; }

        /// <summary>
        /// Data e hora do último movimento. Exemplo: "2023-01-01T12:00:00".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHora")]
        public string? DataHora { get; set; }

        /// <summary>
        /// Código do último movimento conforme TPU de movimentos. Exemplo: "26".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codigo")]
        public long? Codigo { get; set; }

        /// <summary>
        /// Descrição do último movimento, conforme TPU de movimentos. Exemplo: "Distribuído por sorteio".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descricao")]
        public string? Descricao { get; set; }

        /// <summary>
        /// Identificador do último movimento no Codex. Exemplo: 123456789101.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idCodex")]
        public long? IdCodex { get; set; }

        /// <summary>
        /// Identificador do último movimento na origem. Exemplo: "123456"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idMovimentoOrigem")]
        public string? IdMovimentoOrigem { get; set; }

        /// <summary>
        /// Identificador da distribuição no Codex relacionada ao último movimento. Exemplo: "847629397".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idDistribuicaoCodex")]
        public long? IdDistribuicaoCodex { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classe")]
        public global::Loud.Technology.Codex.Cnj.Sdk.ClasseUltimoMovimentoOpenSearch? Classe { get; set; }

        /// <summary>
        /// Orgão julgador referente ao último movimento do trâmite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgaoJulgador")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorUltimoMovimentoOpenSearch>? OrgaoJulgador { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UltimoMovimentoOpenSearch" /> class.
        /// </summary>
        /// <param name="sequencia">
        /// O sistema gera uma lista de todos os movimentos do processo. Este atributo se refere ao número sequencial da última movimentação nessa lista. Exemplo: 21.
        /// </param>
        /// <param name="dataHora">
        /// Data e hora do último movimento. Exemplo: "2023-01-01T12:00:00".
        /// </param>
        /// <param name="codigo">
        /// Código do último movimento conforme TPU de movimentos. Exemplo: "26".
        /// </param>
        /// <param name="descricao">
        /// Descrição do último movimento, conforme TPU de movimentos. Exemplo: "Distribuído por sorteio".
        /// </param>
        /// <param name="idCodex">
        /// Identificador do último movimento no Codex. Exemplo: 123456789101.
        /// </param>
        /// <param name="idMovimentoOrigem">
        /// Identificador do último movimento na origem. Exemplo: "123456"
        /// </param>
        /// <param name="idDistribuicaoCodex">
        /// Identificador da distribuição no Codex relacionada ao último movimento. Exemplo: "847629397".
        /// </param>
        /// <param name="classe"></param>
        /// <param name="orgaoJulgador">
        /// Orgão julgador referente ao último movimento do trâmite.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UltimoMovimentoOpenSearch(
            long? sequencia,
            string? dataHora,
            long? codigo,
            string? descricao,
            long? idCodex,
            string? idMovimentoOrigem,
            long? idDistribuicaoCodex,
            global::Loud.Technology.Codex.Cnj.Sdk.ClasseUltimoMovimentoOpenSearch? classe,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorUltimoMovimentoOpenSearch>? orgaoJulgador)
        {
            this.Sequencia = sequencia;
            this.DataHora = dataHora;
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.IdCodex = idCodex;
            this.IdMovimentoOrigem = idMovimentoOrigem;
            this.IdDistribuicaoCodex = idDistribuicaoCodex;
            this.Classe = classe;
            this.OrgaoJulgador = orgaoJulgador;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UltimoMovimentoOpenSearch" /> class.
        /// </summary>
        public UltimoMovimentoOpenSearch()
        {
        }

    }
}