
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaisS3
    {
        /// <summary>
        /// Sigla do país. Exemplo: "BR".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sigla")]
        public string? Sigla { get; set; }

        /// <summary>
        /// Nome do país. Exemplo: "BRASIL".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaisS3" /> class.
        /// </summary>
        /// <param name="sigla">
        /// Sigla do país. Exemplo: "BR".
        /// </param>
        /// <param name="nome">
        /// Nome do país. Exemplo: "BRASIL".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaisS3(
            string? sigla,
            string? nome)
        {
            this.Sigla = sigla;
            this.Nome = nome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaisS3" /> class.
        /// </summary>
        public PaisS3()
        {
        }

    }
}