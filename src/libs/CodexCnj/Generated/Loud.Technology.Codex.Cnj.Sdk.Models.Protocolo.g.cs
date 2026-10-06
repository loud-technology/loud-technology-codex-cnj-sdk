
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class Protocolo
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("envios")]
        public global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.Envio>? Envios { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Protocolo" /> class.
        /// </summary>
        /// <param name="envios"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Protocolo(
            global::System.Collections.Generic.IList<global::Loud.Technology.Codex.Cnj.Sdk.Envio>? envios)
        {
            this.Envios = envios;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Protocolo" /> class.
        /// </summary>
        public Protocolo()
        {
        }

    }
}