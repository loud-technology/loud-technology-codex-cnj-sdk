
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ComplementoS3
    {
        /// <summary>
        /// Código do complemento do movimento, de acordo com a tabela de complementos de movimentos da TPU movimentos. Exemplo: "4"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codigo")]
        public long? Codigo { get; set; }

        /// <summary>
        /// Nome do complemento do movimento, de acordo com a tabela de complementos de movimentos da TPU movimentos. Exemplo: "tipo_de_documento".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Identificador do complemento do movimento na origem. Exemplos: "SG5SP_RI0081H9Z0000_38_0" e "12345678".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idComplementoOrigem")]
        public string? IdComplementoOrigem { get; set; }

        /// <summary>
        /// Categoria do complemento do movimento, podendo ser: LIVRE: complemento que não está predefinido no sistema processual ou no registro do processo, exigindo preenchimento desses dados; TABELADO: complemento que possui valores e códigos predeterminados nas TPUs, permitindo a sua vinculação direta ao movimento; e IDENTIFICADOR: complemento que estiver disponível no sistema informatizado ou no registro do processo, permitindo a sua vinculação ao movimento, mas que não possui valores predeterminados em nível nacional. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("categoria")]
        public string? Categoria { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("valor")]
        public global::Loud.Technology.Codex.Cnj.Sdk.ValorS3? Valor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplementoS3" /> class.
        /// </summary>
        /// <param name="codigo">
        /// Código do complemento do movimento, de acordo com a tabela de complementos de movimentos da TPU movimentos. Exemplo: "4"
        /// </param>
        /// <param name="nome">
        /// Nome do complemento do movimento, de acordo com a tabela de complementos de movimentos da TPU movimentos. Exemplo: "tipo_de_documento".
        /// </param>
        /// <param name="idComplementoOrigem">
        /// Identificador do complemento do movimento na origem. Exemplos: "SG5SP_RI0081H9Z0000_38_0" e "12345678".
        /// </param>
        /// <param name="categoria">
        /// Categoria do complemento do movimento, podendo ser: LIVRE: complemento que não está predefinido no sistema processual ou no registro do processo, exigindo preenchimento desses dados; TABELADO: complemento que possui valores e códigos predeterminados nas TPUs, permitindo a sua vinculação direta ao movimento; e IDENTIFICADOR: complemento que estiver disponível no sistema informatizado ou no registro do processo, permitindo a sua vinculação ao movimento, mas que não possui valores predeterminados em nível nacional. 
        /// </param>
        /// <param name="valor"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ComplementoS3(
            long? codigo,
            string? nome,
            string? idComplementoOrigem,
            string? categoria,
            global::Loud.Technology.Codex.Cnj.Sdk.ValorS3? valor)
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.IdComplementoOrigem = idComplementoOrigem;
            this.Categoria = categoria;
            this.Valor = valor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ComplementoS3" /> class.
        /// </summary>
        public ComplementoS3()
        {
        }

    }
}