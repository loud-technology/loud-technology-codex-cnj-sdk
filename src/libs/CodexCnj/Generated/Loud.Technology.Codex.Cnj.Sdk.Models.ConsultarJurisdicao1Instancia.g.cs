
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConsultarJurisdicao1Instancia
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
    public static class ConsultarJurisdicao1InstanciaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConsultarJurisdicao1Instancia value)
        {
            return value switch
            {
                ConsultarJurisdicao1Instancia.Inconsistente => "INCONSISTENTE",
                ConsultarJurisdicao1Instancia.PrimeiroGrau => "PRIMEIRO_GRAU",
                ConsultarJurisdicao1Instancia.QuartoGrau => "QUARTO_GRAU",
                ConsultarJurisdicao1Instancia.SegundoGrau => "SEGUNDO_GRAU",
                ConsultarJurisdicao1Instancia.TerceiroGrau => "TERCEIRO_GRAU",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConsultarJurisdicao1Instancia? ToEnum(string value)
        {
            return value switch
            {
                "INCONSISTENTE" => ConsultarJurisdicao1Instancia.Inconsistente,
                "PRIMEIRO_GRAU" => ConsultarJurisdicao1Instancia.PrimeiroGrau,
                "QUARTO_GRAU" => ConsultarJurisdicao1Instancia.QuartoGrau,
                "SEGUNDO_GRAU" => ConsultarJurisdicao1Instancia.SegundoGrau,
                "TERCEIRO_GRAU" => ConsultarJurisdicao1Instancia.TerceiroGrau,
                _ => null,
            };
        }
    }
}