
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DadosIBGE
    {
        /// <summary>
        /// Código IBGE 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codIbge")]
        public string? CodIbge { get; set; }

        /// <summary>
        /// Código cidade 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codCidade")]
        public int? CodCidade { get; set; }

        /// <summary>
        /// Nome da cidade 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nomeCidade")]
        public string? NomeCidade { get; set; }

        /// <summary>
        /// Sigla UF 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sigUf")]
        public string? SigUf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DadosIBGE" /> class.
        /// </summary>
        /// <param name="codIbge">
        /// Código IBGE 
        /// </param>
        /// <param name="codCidade">
        /// Código cidade 
        /// </param>
        /// <param name="nomeCidade">
        /// Nome da cidade 
        /// </param>
        /// <param name="sigUf">
        /// Sigla UF 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DadosIBGE(
            string? codIbge,
            int? codCidade,
            string? nomeCidade,
            string? sigUf)
        {
            this.CodIbge = codIbge;
            this.CodCidade = codCidade;
            this.NomeCidade = nomeCidade;
            this.SigUf = sigUf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DadosIBGE" /> class.
        /// </summary>
        public DadosIBGE()
        {
        }

    }
}