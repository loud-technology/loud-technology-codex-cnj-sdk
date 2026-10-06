
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConsultaMetricaFase
    {
        /// <summary>
        /// 
        /// </summary>
        Conhecimento,
        /// <summary>
        /// 
        /// </summary>
        Execução,
        /// <summary>
        /// 
        /// </summary>
        Investigatória,
        /// <summary>
        /// 
        /// </summary>
        Inválido,
        /// <summary>
        /// 
        /// </summary>
        NãoInformado,
        /// <summary>
        /// 
        /// </summary>
        Outro,
        /// <summary>
        /// 
        /// </summary>
        PréProcessual,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConsultaMetricaFaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConsultaMetricaFase value)
        {
            return value switch
            {
                ConsultaMetricaFase.Conhecimento => "CONHECIMENTO",
                ConsultaMetricaFase.Execução => "EXECUÇÃO",
                ConsultaMetricaFase.Investigatória => "INVESTIGATÓRIA",
                ConsultaMetricaFase.Inválido => "INVÁLIDO",
                ConsultaMetricaFase.NãoInformado => "NÃO INFORMADO",
                ConsultaMetricaFase.Outro => "OUTRO",
                ConsultaMetricaFase.PréProcessual => "PRÉ-PROCESSUAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConsultaMetricaFase? ToEnum(string value)
        {
            return value switch
            {
                "CONHECIMENTO" => ConsultaMetricaFase.Conhecimento,
                "EXECUÇÃO" => ConsultaMetricaFase.Execução,
                "INVESTIGATÓRIA" => ConsultaMetricaFase.Investigatória,
                "INVÁLIDO" => ConsultaMetricaFase.Inválido,
                "NÃO INFORMADO" => ConsultaMetricaFase.NãoInformado,
                "OUTRO" => ConsultaMetricaFase.Outro,
                "PRÉ-PROCESSUAL" => ConsultaMetricaFase.PréProcessual,
                _ => null,
            };
        }
    }
}