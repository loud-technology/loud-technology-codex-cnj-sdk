
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class NacionalidadeOpenSearch
    {
        /// <summary>
        /// Atributo destinado à sigla do país da nacionalidade da pessoa. Exemplos: “ BR” ;  “US”; "AR" 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sigla")]
        public string? Sigla { get; set; }

        /// <summary>
        /// Indica o nome do país de nacionalidade da parte. Exemplo: "Brasil", "Estados Unidos", “Argentina”.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NacionalidadeOpenSearch" /> class.
        /// </summary>
        /// <param name="sigla">
        /// Atributo destinado à sigla do país da nacionalidade da pessoa. Exemplos: “ BR” ;  “US”; "AR" 
        /// </param>
        /// <param name="nome">
        /// Indica o nome do país de nacionalidade da parte. Exemplo: "Brasil", "Estados Unidos", “Argentina”.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NacionalidadeOpenSearch(
            string? sigla,
            string? nome)
        {
            this.Sigla = sigla;
            this.Nome = nome;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NacionalidadeOpenSearch" /> class.
        /// </summary>
        public NacionalidadeOpenSearch()
        {
        }

    }
}