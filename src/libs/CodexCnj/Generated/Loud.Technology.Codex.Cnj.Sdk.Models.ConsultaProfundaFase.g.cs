
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConsultaProfundaFase
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
    public static class ConsultaProfundaFaseExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConsultaProfundaFase value)
        {
            return value switch
            {
                ConsultaProfundaFase.Conhecimento => "CONHECIMENTO",
                ConsultaProfundaFase.Execução => "EXECUÇÃO",
                ConsultaProfundaFase.Investigatória => "INVESTIGATÓRIA",
                ConsultaProfundaFase.Inválido => "INVÁLIDO",
                ConsultaProfundaFase.NãoInformado => "NÃO INFORMADO",
                ConsultaProfundaFase.Outro => "OUTRO",
                ConsultaProfundaFase.PréProcessual => "PRÉ-PROCESSUAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConsultaProfundaFase? ToEnum(string value)
        {
            return value switch
            {
                "CONHECIMENTO" => ConsultaProfundaFase.Conhecimento,
                "EXECUÇÃO" => ConsultaProfundaFase.Execução,
                "INVESTIGATÓRIA" => ConsultaProfundaFase.Investigatória,
                "INVÁLIDO" => ConsultaProfundaFase.Inválido,
                "NÃO INFORMADO" => ConsultaProfundaFase.NãoInformado,
                "OUTRO" => ConsultaProfundaFase.Outro,
                "PRÉ-PROCESSUAL" => ConsultaProfundaFase.PréProcessual,
                _ => null,
            };
        }
    }
}