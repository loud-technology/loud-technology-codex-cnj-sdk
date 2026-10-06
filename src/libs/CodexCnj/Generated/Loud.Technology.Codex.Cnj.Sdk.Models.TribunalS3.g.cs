
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TribunalS3
    {
        /// <summary>
        /// Identificador do tribunal no Codex para recuperar o tribunal da tramitação do Codex. Exemplo: 33. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idCodex")]
        public long? IdCodex { get; set; }

        /// <summary>
        /// Sigla do tribunal. Exemplo: "TRF3".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sigla")]
        public string? Sigla { get; set; }

        /// <summary>
        /// Nome do tribunal. Exemplo: "Tribunal Regional Federal da 3ª Região"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Segmento do tribunal. Exemplos: 'CONSELHO_NACIONAL_JUSTICA', ‘JUSTICA_ELEITORAL’, , ’JUSTICA_ESTADUAL’, ‘JUSTICA_FEDERAL’, ’JUSTICA_MILITAR_ESTADUAL', 'JUSTICA_MILITAR_UNIAO', ’JUSTICA_TRABALHO’, 'SUPERIOR_TRIBUNAL_JUSTICA' e 'SUPREMO_TRIBUNAL_FEDERAL'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmento")]
        public string? Segmento { get; set; }

        /// <summary>
        /// O campo JTR é utilizado para identificar de forma única o segmento de justiça e o tribunal ao qual o processo pertence. O código é composto por duas partes: a primeira letra, J, representa o segmento de justiça (como Justiça Federal, Justiça do Trabalho, etc.), enquanto a sequência TR indica o código específico do tribunal correspondente dentro daquele segmento, conforme art. 1º, §§º 4º e 5º da Res. CNJ 65/2008.  Esse campo é essencial para garantir a correta identificação e classificação dos processos nos diferentes ramos do Poder Judiciário. Exemplo: "123".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jtr")]
        public string? Jtr { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TribunalS3" /> class.
        /// </summary>
        /// <param name="idCodex">
        /// Identificador do tribunal no Codex para recuperar o tribunal da tramitação do Codex. Exemplo: 33. 
        /// </param>
        /// <param name="sigla">
        /// Sigla do tribunal. Exemplo: "TRF3".
        /// </param>
        /// <param name="nome">
        /// Nome do tribunal. Exemplo: "Tribunal Regional Federal da 3ª Região"
        /// </param>
        /// <param name="segmento">
        /// Segmento do tribunal. Exemplos: 'CONSELHO_NACIONAL_JUSTICA', ‘JUSTICA_ELEITORAL’, , ’JUSTICA_ESTADUAL’, ‘JUSTICA_FEDERAL’, ’JUSTICA_MILITAR_ESTADUAL', 'JUSTICA_MILITAR_UNIAO', ’JUSTICA_TRABALHO’, 'SUPERIOR_TRIBUNAL_JUSTICA' e 'SUPREMO_TRIBUNAL_FEDERAL'.
        /// </param>
        /// <param name="jtr">
        /// O campo JTR é utilizado para identificar de forma única o segmento de justiça e o tribunal ao qual o processo pertence. O código é composto por duas partes: a primeira letra, J, representa o segmento de justiça (como Justiça Federal, Justiça do Trabalho, etc.), enquanto a sequência TR indica o código específico do tribunal correspondente dentro daquele segmento, conforme art. 1º, §§º 4º e 5º da Res. CNJ 65/2008.  Esse campo é essencial para garantir a correta identificação e classificação dos processos nos diferentes ramos do Poder Judiciário. Exemplo: "123".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TribunalS3(
            long? idCodex,
            string? sigla,
            string? nome,
            string? segmento,
            string? jtr)
        {
            this.IdCodex = idCodex;
            this.Sigla = sigla;
            this.Nome = nome;
            this.Segmento = segmento;
            this.Jtr = jtr;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TribunalS3" /> class.
        /// </summary>
        public TribunalS3()
        {
        }

    }
}