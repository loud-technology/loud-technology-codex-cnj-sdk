
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MagistradoS3
    {
        /// <summary>
        /// Nome do magistrado. Exemplo: "João Silva". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// CPF do magistrado. Exemplo: "12345678910".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("CPF")]
        public string? Cpf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MagistradoS3" /> class.
        /// </summary>
        /// <param name="nome">
        /// Nome do magistrado. Exemplo: "João Silva". 
        /// </param>
        /// <param name="cpf">
        /// CPF do magistrado. Exemplo: "12345678910".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MagistradoS3(
            string? nome,
            string? cpf)
        {
            this.Nome = nome;
            this.Cpf = cpf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MagistradoS3" /> class.
        /// </summary>
        public MagistradoS3()
        {
        }

    }
}