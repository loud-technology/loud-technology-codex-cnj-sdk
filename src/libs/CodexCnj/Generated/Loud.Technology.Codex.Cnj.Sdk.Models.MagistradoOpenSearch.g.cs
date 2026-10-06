
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MagistradoOpenSearch
    {
        /// <summary>
        /// Nome do magistrado. Exemplo: Fulano de tal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// CPF do magistrado. Exemplo: 99999999999.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cpf")]
        public string? Cpf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MagistradoOpenSearch" /> class.
        /// </summary>
        /// <param name="nome">
        /// Nome do magistrado. Exemplo: Fulano de tal.
        /// </param>
        /// <param name="cpf">
        /// CPF do magistrado. Exemplo: 99999999999.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MagistradoOpenSearch(
            string? nome,
            string? cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MagistradoOpenSearch" /> class.
        /// </summary>
        public MagistradoOpenSearch()
        {
        }

    }
}