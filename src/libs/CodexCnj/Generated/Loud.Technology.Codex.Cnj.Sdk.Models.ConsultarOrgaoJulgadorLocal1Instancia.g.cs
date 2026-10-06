
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConsultarOrgaoJulgadorLocal1Instancia
    {
        /// <summary>
        /// 
        /// </summary>
        Inconsistente,
        /// <summary>
        /// 
        /// </summary>
        PrimeiroGrau,
        /// <summary>
        /// 
        /// </summary>
        QuartoGrau,
        /// <summary>
        /// 
        /// </summary>
        SegundoGrau,
        /// <summary>
        /// 
        /// </summary>
        TerceiroGrau,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConsultarOrgaoJulgadorLocal1InstanciaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConsultarOrgaoJulgadorLocal1Instancia value)
        {
            return value switch
            {
                ConsultarOrgaoJulgadorLocal1Instancia.Inconsistente => "INCONSISTENTE",
                ConsultarOrgaoJulgadorLocal1Instancia.PrimeiroGrau => "PRIMEIRO_GRAU",
                ConsultarOrgaoJulgadorLocal1Instancia.QuartoGrau => "QUARTO_GRAU",
                ConsultarOrgaoJulgadorLocal1Instancia.SegundoGrau => "SEGUNDO_GRAU",
                ConsultarOrgaoJulgadorLocal1Instancia.TerceiroGrau => "TERCEIRO_GRAU",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConsultarOrgaoJulgadorLocal1Instancia? ToEnum(string value)
        {
            return value switch
            {
                "INCONSISTENTE" => ConsultarOrgaoJulgadorLocal1Instancia.Inconsistente,
                "PRIMEIRO_GRAU" => ConsultarOrgaoJulgadorLocal1Instancia.PrimeiroGrau,
                "QUARTO_GRAU" => ConsultarOrgaoJulgadorLocal1Instancia.QuartoGrau,
                "SEGUNDO_GRAU" => ConsultarOrgaoJulgadorLocal1Instancia.SegundoGrau,
                "TERCEIRO_GRAU" => ConsultarOrgaoJulgadorLocal1Instancia.TerceiroGrau,
                _ => null,
            };
        }
    }
}