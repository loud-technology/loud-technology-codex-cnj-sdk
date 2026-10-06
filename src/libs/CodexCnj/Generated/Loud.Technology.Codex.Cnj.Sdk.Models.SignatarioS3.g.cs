
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class SignatarioS3
    {
        /// <summary>
        /// Nome do signatário. Exemplo: "Ana Silva". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SignatarioS3" /> class.
        /// </summary>
        /// <param name="nome">
        /// Nome do signatário. Exemplo: "Ana Silva". 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SignatarioS3(
            string? nome)
        {
            this.Nome = nome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SignatarioS3" /> class.
        /// </summary>
        public SignatarioS3()
        {
        }

    }
}