
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GenitoresS3
    {
        /// <summary>
        /// Nome do genitor das partes. Exemplo: "Maria Souza".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Registro do gênero do genitor. Exemplos: "FEMININO", "MASCULINO" ou "OUTROS".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sexo")]
        public string? Sexo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GenitoresS3" /> class.
        /// </summary>
        /// <param name="nome">
        /// Nome do genitor das partes. Exemplo: "Maria Souza".
        /// </param>
        /// <param name="sexo">
        /// Registro do gênero do genitor. Exemplos: "FEMININO", "MASCULINO" ou "OUTROS".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GenitoresS3(
            string? nome,
            string? sexo)
        {
            this.Nome = nome;
            this.Sexo = sexo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GenitoresS3" /> class.
        /// </summary>
        public GenitoresS3()
        {
        }

    }
}