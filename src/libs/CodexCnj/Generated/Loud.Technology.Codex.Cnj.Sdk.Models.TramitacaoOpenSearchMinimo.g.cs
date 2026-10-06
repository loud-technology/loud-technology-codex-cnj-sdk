
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TramitacaoOpenSearchMinimo
    {
        /// <summary>
        /// Dados da classe processual relacionada ao trâmite. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("classe")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.ClasseOpenSearch>? Classe { get; set; }

        /// <summary>
        /// Indica se o processo é de natureza criminal
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("isCriminal")]
        public bool? IsCriminal { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgaoJulgador")]
        public global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorOpenSearchMinimo? OrgaoJulgador { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgaoJulgadorColegiado")]
        public global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorColegiadoOpenSearch? OrgaoJulgadorColegiado { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tribunal")]
        public global::Loud.Technology.Codex.Cnj.Sdk.TribunalOpenSearchMinimo? Tribunal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TramitacaoOpenSearchMinimo" /> class.
        /// </summary>
        /// <param name="classe">
        /// Dados da classe processual relacionada ao trâmite. 
        /// </param>
        /// <param name="isCriminal">
        /// Indica se o processo é de natureza criminal
        /// </param>
        /// <param name="orgaoJulgador"></param>
        /// <param name="orgaoJulgadorColegiado"></param>
        /// <param name="tribunal"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TramitacaoOpenSearchMinimo(
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.ClasseOpenSearch>? classe,
            bool? isCriminal,
            global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorOpenSearchMinimo? orgaoJulgador,
            global::Loud.Technology.Codex.Cnj.Sdk.OrgaoJulgadorColegiadoOpenSearch? orgaoJulgadorColegiado,
            global::Loud.Technology.Codex.Cnj.Sdk.TribunalOpenSearchMinimo? tribunal)
        {
            this.Classe = classe;
            this.IsCriminal = isCriminal;
            this.OrgaoJulgador = orgaoJulgador;
            this.OrgaoJulgadorColegiado = orgaoJulgadorColegiado;
            this.Tribunal = tribunal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TramitacaoOpenSearchMinimo" /> class.
        /// </summary>
        public TramitacaoOpenSearchMinimo()
        {
        }

    }
}