
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class OutrosDocumentosS3
    {
        /// <summary>
        /// Nome do documento. Exemplo: "CNH". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Número do documento. Exemplo: 12345678. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numero")]
        public string? Numero { get; set; }

        /// <summary>
        /// Tipo de outro(s) documento(s) da parte. Admite os seguintes valores: CI: carteira de identidade; CNH: carteira nacional de habilitação; TE: título de eleitor; CN: certidão de nascimento; CC: certidão de casamento; PAS: passaporte; CT: carteira de trabalho; RIC: registro individual do cidadão; CPF: cadastro de pessoa física; CNPJ: cadastro nacional de pessoa jurídica; PIS_PASEP: número no programa de integração social; CEI: cadastro específico do INSS; NIT: número de identificação do trabalho; CP: cadastro em conselhos profissionais; IF: identidade funcional; OAB: número de cadastro na Ordem dos Advogados do Brasi; RJC: número de inscrição empresarial; RGE: registro de identificação do estrangeiro; NB: número do benefício no INSS; RIND: Registro de identificação de indígenas ou de povos e comunidades tradicionais; RJI: Registro Judiciário Individual, gerado pelo CNJ conforme BNMP; OUTROS: Outros (para certificado de reservista por exemplo).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipo")]
        public string? Tipo { get; set; }

        /// <summary>
        /// Órgão emissor do documento. Exemplo: "DETRAN". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("orgaoEmissor")]
        public string? OrgaoEmissor { get; set; }

        /// <summary>
        /// Estado emissor do documento. Exemplo: "SP". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("estadoEmissor")]
        public string? EstadoEmissor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OutrosDocumentosS3" /> class.
        /// </summary>
        /// <param name="nome">
        /// Nome do documento. Exemplo: "CNH". 
        /// </param>
        /// <param name="numero">
        /// Número do documento. Exemplo: 12345678. 
        /// </param>
        /// <param name="tipo">
        /// Tipo de outro(s) documento(s) da parte. Admite os seguintes valores: CI: carteira de identidade; CNH: carteira nacional de habilitação; TE: título de eleitor; CN: certidão de nascimento; CC: certidão de casamento; PAS: passaporte; CT: carteira de trabalho; RIC: registro individual do cidadão; CPF: cadastro de pessoa física; CNPJ: cadastro nacional de pessoa jurídica; PIS_PASEP: número no programa de integração social; CEI: cadastro específico do INSS; NIT: número de identificação do trabalho; CP: cadastro em conselhos profissionais; IF: identidade funcional; OAB: número de cadastro na Ordem dos Advogados do Brasi; RJC: número de inscrição empresarial; RGE: registro de identificação do estrangeiro; NB: número do benefício no INSS; RIND: Registro de identificação de indígenas ou de povos e comunidades tradicionais; RJI: Registro Judiciário Individual, gerado pelo CNJ conforme BNMP; OUTROS: Outros (para certificado de reservista por exemplo).
        /// </param>
        /// <param name="orgaoEmissor">
        /// Órgão emissor do documento. Exemplo: "DETRAN". 
        /// </param>
        /// <param name="estadoEmissor">
        /// Estado emissor do documento. Exemplo: "SP". 
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OutrosDocumentosS3(
            string? nome,
            string? numero,
            string? tipo,
            string? orgaoEmissor,
            string? estadoEmissor)
        {
            this.Nome = nome;
            this.Numero = numero;
            this.Tipo = tipo;
            this.OrgaoEmissor = orgaoEmissor;
            this.EstadoEmissor = estadoEmissor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OutrosDocumentosS3" /> class.
        /// </summary>
        public OutrosDocumentosS3()
        {
        }

    }
}