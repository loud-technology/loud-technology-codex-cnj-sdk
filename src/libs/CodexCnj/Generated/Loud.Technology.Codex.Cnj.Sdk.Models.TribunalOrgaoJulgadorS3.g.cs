
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TribunalOrgaoJulgadorS3
    {
        /// <summary>
        /// Segmento do tribunal. Exemplos: 'CONSELHO_NACIONAL_JUSTICA', ‘JUSTICA_ELEITORAL’, , ’JUSTICA_ESTADUAL’, ‘JUSTICA_FEDERAL’, ’JUSTICA_MILITAR_ESTADUAL', 'JUSTICA_MILITAR_UNIAO', ’JUSTICA_TRABALHO’, 'SUPERIOR_TRIBUNAL_JUSTICA' e 'SUPREMO_TRIBUNAL_FEDERAL'.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmento")]
        public string? Segmento { get; set; }

        /// <summary>
        /// Sigla do tribunal. Exemplo: "TJSP". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sigla")]
        public string? Sigla { get; set; }

        /// <summary>
        /// Nome do tribunal. Exemplo: "Tribunal Regional Federal da 3ª Região". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TribunalOrgaoJulgadorS3" /> class.
        /// </summary>
        /// <param name="segmento">
        /// Segmento do tribunal. Exemplos: 'CONSELHO_NACIONAL_JUSTICA', ‘JUSTICA_ELEITORAL’, , ’JUSTICA_ESTADUAL’, ‘JUSTICA_FEDERAL’, ’JUSTICA_MILITAR_ESTADUAL', 'JUSTICA_MILITAR_UNIAO', ’JUSTICA_TRABALHO’, 'SUPERIOR_TRIBUNAL_JUSTICA' e 'SUPREMO_TRIBUNAL_FEDERAL'.
        /// </param>
        /// <param name="sigla">
        /// Sigla do tribunal. Exemplo: "TJSP". 
        /// </param>
        /// <param name="nome">
        /// Nome do tribunal. Exemplo: "Tribunal Regional Federal da 3ª Região". 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TribunalOrgaoJulgadorS3(
            string? segmento,
            string? sigla,
            string? nome)
        {
            this.Segmento = segmento;
            this.Sigla = sigla;
            this.Nome = nome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TribunalOrgaoJulgadorS3" /> class.
        /// </summary>
        public TribunalOrgaoJulgadorS3()
        {
        }

    }
}