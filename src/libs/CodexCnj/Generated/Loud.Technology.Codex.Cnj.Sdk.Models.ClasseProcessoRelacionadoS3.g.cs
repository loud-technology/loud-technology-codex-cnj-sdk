
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClasseProcessoRelacionadoS3
    {
        /// <summary>
        /// Identificador da classe do processo relacionado conforme TPU de classes. Exemplo: "12193",
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Descrição da classe do processo relacionado de acordo com TPU de classes. Exemplo: “Prestação de Contas Eleitorais”.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descricao")]
        public string? Descricao { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClasseProcessoRelacionadoS3" /> class.
        /// </summary>
        /// <param name="id">
        /// Identificador da classe do processo relacionado conforme TPU de classes. Exemplo: "12193",
        /// </param>
        /// <param name="descricao">
        /// Descrição da classe do processo relacionado de acordo com TPU de classes. Exemplo: “Prestação de Contas Eleitorais”.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClasseProcessoRelacionadoS3(
            long? id,
            string? descricao)
        {
            this.Id = id;
            this.Descricao = descricao;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClasseProcessoRelacionadoS3" /> class.
        /// </summary>
        public ClasseProcessoRelacionadoS3()
        {
        }

    }
}