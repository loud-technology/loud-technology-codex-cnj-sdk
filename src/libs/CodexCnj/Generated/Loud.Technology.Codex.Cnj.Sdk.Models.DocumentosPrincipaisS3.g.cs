
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DocumentosPrincipaisS3
    {
        /// <summary>
        /// Número do documento principal. Exemplo: 12345678. 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("numero")]
        public string? Numero { get; set; }

        /// <summary>
        /// Tipo de documento da parte. Admite os seguintes valores: CI: carteira de identidade; CNH: carteira nacional de habilitação; TE: título de eleitor; CN: certidão de nascimento; CC: certidão de casamento; PAS: passaporte; CT: carteira de trabalho; RIC: registro individual do cidadão; CPF: cadastro de pessoa física; CNPJ: cadastro nacional de pessoa jurídica; PIS_PASEP: número no programa de integração social; CEI: cadastro específico do INSS; NIT: número de identificação do trabalho; CP: cadastro em conselhos profissionais; IF: identidade funcional; OAB: número de cadastro na Ordem dos Advogados do Brasi; RJC: número de inscrição empresarial; RGE: registro de identificação do estrangeiro; NB: número do benefício no INSS; RIND: Registro de identificação de indígenas ou de povos e comunidades tradicionais; RJI: Registro Judiciário Individual, gerado pelo CNJ conforme BNMP; OUTROS: Outros (para certificado de reservista, por exemplo).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tipo")]
        public string? Tipo { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentosPrincipaisS3" /> class.
        /// </summary>
        /// <param name="numero">
        /// Número do documento principal. Exemplo: 12345678. 
        /// </param>
        /// <param name="tipo">
        /// Tipo de documento da parte. Admite os seguintes valores: CI: carteira de identidade; CNH: carteira nacional de habilitação; TE: título de eleitor; CN: certidão de nascimento; CC: certidão de casamento; PAS: passaporte; CT: carteira de trabalho; RIC: registro individual do cidadão; CPF: cadastro de pessoa física; CNPJ: cadastro nacional de pessoa jurídica; PIS_PASEP: número no programa de integração social; CEI: cadastro específico do INSS; NIT: número de identificação do trabalho; CP: cadastro em conselhos profissionais; IF: identidade funcional; OAB: número de cadastro na Ordem dos Advogados do Brasi; RJC: número de inscrição empresarial; RGE: registro de identificação do estrangeiro; NB: número do benefício no INSS; RIND: Registro de identificação de indígenas ou de povos e comunidades tradicionais; RJI: Registro Judiciário Individual, gerado pelo CNJ conforme BNMP; OUTROS: Outros (para certificado de reservista, por exemplo).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DocumentosPrincipaisS3(
            string? numero,
            string? tipo)
        {
            this.Numero = numero;
            this.Tipo = tipo;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentosPrincipaisS3" /> class.
        /// </summary>
        public DocumentosPrincipaisS3()
        {
        }

    }
}