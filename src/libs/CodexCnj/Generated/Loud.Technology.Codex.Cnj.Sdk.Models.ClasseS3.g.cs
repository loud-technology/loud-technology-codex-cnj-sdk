
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ClasseS3
    {
        /// <summary>
        /// Registro da sequência da classe no referido processo. É gerada uma sequência de acordo com a ordenação crescente da data início. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequencia")]
        public long? Sequencia { get; set; }

        /// <summary>
        /// Data e hora de início da classe. Exemplo: "2023-01-01T12:00:00". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHoraInicio")]
        public string? DataHoraInicio { get; set; }

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
        /// Lista do histórico das classes. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("historico")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.HistoricoS3>? Historico { get; set; }

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
        /// Initializes a new instance of the <see cref="ClasseS3" /> class.
        /// </summary>
        /// <param name="sequencia">
        /// Registro da sequência da classe no referido processo. É gerada uma sequência de acordo com a ordenação crescente da data início. 
        /// </param>
        /// <param name="dataHoraInicio">
        /// Data e hora de início da classe. Exemplo: "2023-01-01T12:00:00". 
        /// </param>
        /// <param name="codigo">
        /// Código da classe atual conforme TPU de classes. Exemplo: "12193".
        /// </param>
        /// <param name="descricao">
        /// Descrição da classe de acordo com TPU de classes. Exemplo: “Prestação de Contas Eleitorais”.
        /// </param>
        /// <param name="hierarquia">
        /// Ordem crescente da classe em relação aos níveis da TPU de classes. Exemplo: "(11531) Prestação de Contas Eleitorais| (11529) Procedimentos Relativos a Realização de Eleição | (11427) PROCESSO ELEITORAL".
        /// </param>
        /// <param name="historico">
        /// Lista do histórico das classes. 
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
        public ClasseS3(
            long? sequencia,
            string? dataHoraInicio,
            long? codigo,
            string? descricao,
            string? hierarquia,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.HistoricoS3>? historico,
            string? poloPassivo,
            string? poloAtivo)
        {
            this.Sequencia = sequencia;
            this.DataHoraInicio = dataHoraInicio;
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Hierarquia = hierarquia;
            this.Historico = historico;
            this.PoloPassivo = poloPassivo;
            this.PoloAtivo = poloAtivo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClasseS3" /> class.
        /// </summary>
        public ClasseS3()
        {
        }

    }
}