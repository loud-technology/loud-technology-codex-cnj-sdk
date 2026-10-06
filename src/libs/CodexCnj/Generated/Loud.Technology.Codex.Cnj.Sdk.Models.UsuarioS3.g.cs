
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UsuarioS3
    {
        /// <summary>
        /// Nome do usuário. Exemplo: "João Pereira". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nome")]
        public string? Nome { get; set; }

        /// <summary>
        /// Login do usuário. Exemplo: "joao.pereira". 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("login")]
        public string? Login { get; set; }

        /// <summary>
        /// CPF do usuário. Exemplo: "12345678910".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("CPF")]
        public string? Cpf { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioS3" /> class.
        /// </summary>
        /// <param name="nome">
        /// Nome do usuário. Exemplo: "João Pereira". 
        /// </param>
        /// <param name="login">
        /// Login do usuário. Exemplo: "joao.pereira". 
        /// </param>
        /// <param name="cpf">
        /// CPF do usuário. Exemplo: "12345678910".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UsuarioS3(
            string? nome,
            string? login,
            string? cpf)
        {
            this.Nome = nome;
            this.Login = login;
            this.Cpf = cpf;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UsuarioS3" /> class.
        /// </summary>
        public UsuarioS3()
        {
        }

    }
}