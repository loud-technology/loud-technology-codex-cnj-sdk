
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClasseOpenSearch
    {
        /// <summary>
        /// Código da classe atual conforme TPU de classes. Exemplo: "12193".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codigo")]
        public long? Codigo { get; set; }

        /// <summary>
        /// Descrição da classe de acordo com TPU de classes. Exemplo: “Prestação de Contas Eleitorais”.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descricao")]
        public string? Descricao { get; set; }

        /// <summary>
        /// Ordem crescente da classe em relação aos níveis da TPU de classes. Exemplo: "(11531) Prestação de Contas Eleitorais| (11529) Procedimentos Relativos a Realização de Eleição | (11427) PROCESSO ELEITORAL".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarquia")]
        public string? Hierarquia { get; set; }

        /// <summary>
        /// Indicador de designação a ser adotada para polos passivo e ativo. Exemplo: processos que tenham a classe 1107 - Procedimento Comum Cível, terão a designação para polo ativo = 'Autor' e polo passivo = 'Réu'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("polo_passivo")]
        public string? PoloPassivo { get; set; }

        /// <summary>
        /// Indicador de designação a ser adotada para polos passivo e ativo. Exemplo: processos que tenham a classe 1107 - Procedimento Comum Cível, terão a designação para polo ativo = 'Autor' e polo passivo = 'Réu'
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("polo_ativo")]
        public string? PoloAtivo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ClasseOpenSearch" /> class.
        /// </summary>
        /// <param name="codigo">
        /// Código da classe atual conforme TPU de classes. Exemplo: "12193".
        /// </param>
        /// <param name="descricao">
        /// Descrição da classe de acordo com TPU de classes. Exemplo: “Prestação de Contas Eleitorais”.
        /// </param>
        /// <param name="hierarquia">
        /// Ordem crescente da classe em relação aos níveis da TPU de classes. Exemplo: "(11531) Prestação de Contas Eleitorais| (11529) Procedimentos Relativos a Realização de Eleição | (11427) PROCESSO ELEITORAL".
        /// </param>
        /// <param name="poloPassivo">
        /// Indicador de designação a ser adotada para polos passivo e ativo. Exemplo: processos que tenham a classe 1107 - Procedimento Comum Cível, terão a designação para polo ativo = 'Autor' e polo passivo = 'Réu'
        /// </param>
        /// <param name="poloAtivo">
        /// Indicador de designação a ser adotada para polos passivo e ativo. Exemplo: processos que tenham a classe 1107 - Procedimento Comum Cível, terão a designação para polo ativo = 'Autor' e polo passivo = 'Réu'
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ClasseOpenSearch(
            long? codigo,
            string? descricao,
            string? hierarquia,
            string? poloPassivo,
            string? poloAtivo)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Hierarquia = hierarquia;
            this.PoloPassivo = poloPassivo;
            this.PoloAtivo = poloAtivo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClasseOpenSearch" /> class.
        /// </summary>
        public ClasseOpenSearch()
        {
        }

    }
}