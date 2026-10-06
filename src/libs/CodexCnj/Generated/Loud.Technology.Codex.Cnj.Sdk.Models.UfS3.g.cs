
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UfS3
    {
        /// <summary>
        /// Sigla da unidade federativa. Exemplo: "DF".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sigla")]
        public string? Sigla { get; set; }

        /// <summary>
        /// Nome da unidade federativa. Exemplo: "DISTRITO FEDERAL".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UfS3" /> class.
        /// </summary>
        /// <param name="sigla">
        /// Sigla da unidade federativa. Exemplo: "DF".
        /// </param>
        /// <param name="nome">
        /// Nome da unidade federativa. Exemplo: "DISTRITO FEDERAL".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UfS3(
            string? sigla,
            string? nome)
        {
            this.Sigla = sigla;
            this.Nome = nome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UfS3" /> class.
        /// </summary>
        public UfS3()
        {
        }

    }
}