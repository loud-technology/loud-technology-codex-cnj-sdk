
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentoS3
    {
        /// <summary>
        /// Registro de qual a sequência do documento no referido processo. É gerado em ordem ascendente da data da juntada do próprio documento.   Exemplo: 1  ;  2  ;  3  ;  4 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequencia")]
        public long? Sequencia { get; set; }

        /// <summary>
        /// Data e hora da última juntada do documento no processo. Exemplo: "2023-01-01T12:00:00". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dataHoraJuntada")]
        public string? DataHoraJuntada { get; set; }

        /// <summary>
        /// Uso de controle interno que não é objeto de consumo negocial. Identificador de um documento juntado ao processo, como petições, decisões, e outros textos processuais. Número gerado pelo próprio sistema. Exemplo: ""77d6373b-cb05-568c-8ad3-258875baf91b".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Identificador do documento no Codex. Exemplo: 12345678910.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idCodex")]
        public long? IdCodex { get; set; }

        /// <summary>
        /// Identificador do documento na origem. Exemplo: "12345678".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("idOrigem")]
        public string? IdOrigem { get; set; }

        /// <summary>
        /// Nome do documento Exemplo: “295505_05052021160734_GuiaCustas BA.pdf”.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Nível de sigilo a ser aplicado ao documento, devendo ser: PUBLICO: públicos, acessíveis a todos os servidores do Judiciário e dos demais órgãos públicos de colaboração na administração da Justiça, assim como aos advogados e a qualquer cidadão; SEGREDO_JUSTICA: segredo de justiça, acessíveis aos servidores do Judiciário, aos servidores dos órgãos públicos de colaboração na administração da Justiça e às partes do processo; SIGILO_MINIMO: sigilo mínimo, acessível aos servidores do Judiciário e aos demais órgãos públicos de colaboração na administração da Justiça; SIGILO_MEDIO: sigilo médio, acessível aos servidores do órgão em que tramita o processo, à(s) parte(s) que provocou(ram) o incidente e àqueles que forem expressamente incluídos; SIGILO_INTENSO: sigilo intenso, acessível a classes de servidores qualificados (magistrado, diretor de secretaria/escrivão, oficial de gabinete/assessor) do órgão em que tramita o processo, às partes que provocaram o incidente e àqueles que forem expressamente incluídos; SIGILO_ABSOLUTO: sigilo absoluto, acessível apenas ao magistrado do órgão em que tramita, aos servidores e demais usuários por ele indicado e às partes que provocaram o incidente.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nivelSigilo")]
        public string? NivelSigilo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipo")]
        public global::Loud.Technology.Codex.Cnj.Sdk.TipoDocumentoS3? Tipo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arquivo")]
        public global::Loud.Technology.Codex.Cnj.Sdk.ArquivoS3? Arquivo { get; set; }

        /// <summary>
        /// Lista de Signatários do documento. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("signatarios")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.SignatarioS3>? Signatarios { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoS3" /> class.
        /// </summary>
        /// <param name="sequencia">
        /// Registro de qual a sequência do documento no referido processo. É gerado em ordem ascendente da data da juntada do próprio documento.   Exemplo: 1  ;  2  ;  3  ;  4 
        /// </param>
        /// <param name="dataHoraJuntada">
        /// Data e hora da última juntada do documento no processo. Exemplo: "2023-01-01T12:00:00". 
        /// </param>
        /// <param name="id">
        /// Uso de controle interno que não é objeto de consumo negocial. Identificador de um documento juntado ao processo, como petições, decisões, e outros textos processuais. Número gerado pelo próprio sistema. Exemplo: ""77d6373b-cb05-568c-8ad3-258875baf91b".
        /// </param>
        /// <param name="idCodex">
        /// Identificador do documento no Codex. Exemplo: 12345678910.
        /// </param>
        /// <param name="idOrigem">
        /// Identificador do documento na origem. Exemplo: "12345678".
        /// </param>
        /// <param name="nome">
        /// Nome do documento Exemplo: “295505_05052021160734_GuiaCustas BA.pdf”.
        /// </param>
        /// <param name="nivelSigilo">
        /// Nível de sigilo a ser aplicado ao documento, devendo ser: PUBLICO: públicos, acessíveis a todos os servidores do Judiciário e dos demais órgãos públicos de colaboração na administração da Justiça, assim como aos advogados e a qualquer cidadão; SEGREDO_JUSTICA: segredo de justiça, acessíveis aos servidores do Judiciário, aos servidores dos órgãos públicos de colaboração na administração da Justiça e às partes do processo; SIGILO_MINIMO: sigilo mínimo, acessível aos servidores do Judiciário e aos demais órgãos públicos de colaboração na administração da Justiça; SIGILO_MEDIO: sigilo médio, acessível aos servidores do órgão em que tramita o processo, à(s) parte(s) que provocou(ram) o incidente e àqueles que forem expressamente incluídos; SIGILO_INTENSO: sigilo intenso, acessível a classes de servidores qualificados (magistrado, diretor de secretaria/escrivão, oficial de gabinete/assessor) do órgão em que tramita o processo, às partes que provocaram o incidente e àqueles que forem expressamente incluídos; SIGILO_ABSOLUTO: sigilo absoluto, acessível apenas ao magistrado do órgão em que tramita, aos servidores e demais usuários por ele indicado e às partes que provocaram o incidente.
        /// </param>
        /// <param name="tipo"></param>
        /// <param name="arquivo"></param>
        /// <param name="signatarios">
        /// Lista de Signatários do documento. 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentoS3(
            long? sequencia,
            string? dataHoraJuntada,
            string? id,
            long? idCodex,
            string? idOrigem,
            string? nome,
            string? nivelSigilo,
            global::Loud.Technology.Codex.Cnj.Sdk.TipoDocumentoS3? tipo,
            global::Loud.Technology.Codex.Cnj.Sdk.ArquivoS3? arquivo,
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.SignatarioS3>? signatarios)
        {
            this.Sequencia = sequencia;
            this.DataHoraJuntada = dataHoraJuntada;
            this.Id = id;
            this.IdCodex = idCodex;
            this.IdOrigem = idOrigem;
            this.Nome = nome;
            this.NivelSigilo = nivelSigilo;
            this.Tipo = tipo;
            this.Arquivo = arquivo;
            this.Signatarios = signatarios;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentoS3" /> class.
        /// </summary>
        public DocumentoS3()
        {
        }

    }
}