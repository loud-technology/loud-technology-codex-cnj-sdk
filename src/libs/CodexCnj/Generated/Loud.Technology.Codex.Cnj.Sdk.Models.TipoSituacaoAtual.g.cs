
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TipoSituacaoAtual
    {
        /// <summary>
        /// Código do tipo da situação atual do processo conforme situações parametrizadas e definidas pelo Datajud. Exemplo: 10.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codigo")]
        public long? Codigo { get; set; }

        /// <summary>
        /// Descrição do tipo da situação atual do processo conforme situações parametrizadas e definidas pelo Datajud. Exemplo: "Baixado definitivamente".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descricao")]
        public string? Descricao { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TipoSituacaoAtual" /> class.
        /// </summary>
        /// <param name="codigo">
        /// Código do tipo da situação atual do processo conforme situações parametrizadas e definidas pelo Datajud. Exemplo: 10.
        /// </param>
        /// <param name="descricao">
        /// Descrição do tipo da situação atual do processo conforme situações parametrizadas e definidas pelo Datajud. Exemplo: "Baixado definitivamente".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TipoSituacaoAtual(
            long? codigo,
            string? descricao)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TipoSituacaoAtual" /> class.
        /// </summary>
        public TipoSituacaoAtual()
        {
        }

    }
}