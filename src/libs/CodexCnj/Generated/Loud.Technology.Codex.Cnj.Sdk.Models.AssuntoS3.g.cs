
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssuntoS3
    {
        /// <summary>
        /// Código do assunto atual conforme TPU de assuntos. Exemplo: "11631".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("codigo")]
        public long? Codigo { get; set; }

        /// <summary>
        /// Descrição do assunto de acordo com TPU de assuntos. Exemplo: “Cargo - Deputado Federal".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("descricao")]
        public string? Descricao { get; set; }

        /// <summary>
        /// Ordem crescente do assunto em relação aos níveis da TPU de assuntos. Exemplo:"(11631) Cargo - Deputado Federal | (11628) Cargos | (11583) Eleições | (11428) DIREITO ELEITORAL".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hierarquia")]
        public string? Hierarquia { get; set; }

        /// <summary>
        /// Lista de outros assuntos relacionados. Modelo detalhado abaixo 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outrosAssuntos")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.OutrosAssuntosS3>? OutrosAssuntos { get; set; }

        /// <summary>
        /// Indicador se o assunto é principal ou complementar. Quando for igual a 'N', ele é principal, ou seja, é o tema central que define a natureza da ação; quando for igual a 'S', ele é complementar, ou seja, é o tema acessório que detalha o tema principal.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("assunto_secundario")]
        public string? AssuntoSecundario { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssuntoS3" /> class.
        /// </summary>
        /// <param name="codigo">
        /// Código do assunto atual conforme TPU de assuntos. Exemplo: "11631".
        /// </param>
        /// <param name="descricao">
        /// Descrição do assunto de acordo com TPU de assuntos. Exemplo: “Cargo - Deputado Federal".
        /// </param>
        /// <param name="hierarquia">
        /// Ordem crescente do assunto em relação aos níveis da TPU de assuntos. Exemplo:"(11631) Cargo - Deputado Federal | (11628) Cargos | (11583) Eleições | (11428) DIREITO ELEITORAL".
        /// </param>
        /// <param name="outrosAssuntos">
        /// Lista de outros assuntos relacionados. Modelo detalhado abaixo 
        /// </param>
        /// <param name="assuntoSecundario">
        /// Indicador se o assunto é principal ou complementar. Quando for igual a 'N', ele é principal, ou seja, é o tema central que define a natureza da ação; quando for igual a 'S', ele é complementar, ou seja, é o tema acessório que detalha o tema principal.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssuntoS3(
            long? codigo,
            string? descricao,
            string? hierarquia,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.OutrosAssuntosS3>? outrosAssuntos,
            string? assuntoSecundario)
        {
            this.Codigo = codigo;
            this.Descricao = descricao;
            this.Hierarquia = hierarquia;
            this.OutrosAssuntos = outrosAssuntos;
            this.AssuntoSecundario = assuntoSecundario;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssuntoS3" /> class.
        /// </summary>
        public AssuntoS3()
        {
        }

    }
}