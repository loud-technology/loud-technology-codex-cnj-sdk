
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConsultaProfundaSegmentoJustica
    {
        /// <summary>
        /// 
        /// </summary>
        ConselhoNacionalJustica,
        /// <summary>
        /// 
        /// </summary>
        JusticaEleitoral,
        /// <summary>
        /// 
        /// </summary>
        JusticaEstadual,
        /// <summary>
        /// 
        /// </summary>
        JusticaFederal,
        /// <summary>
        /// 
        /// </summary>
        JusticaMilitarEstadual,
        /// <summary>
        /// 
        /// </summary>
        JusticaMilitarUniao,
        /// <summary>
        /// 
        /// </summary>
        JusticaTrabalho,
        /// <summary>
        /// 
        /// </summary>
        SuperiorTribunalJustica,
        /// <summary>
        /// 
        /// </summary>
        SupremoTribunalFederal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConsultaProfundaSegmentoJusticaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConsultaProfundaSegmentoJustica value)
        {
            return value switch
            {
                ConsultaProfundaSegmentoJustica.ConselhoNacionalJustica => "CONSELHO_NACIONAL_JUSTICA",
                ConsultaProfundaSegmentoJustica.JusticaEleitoral => "JUSTICA_ELEITORAL",
                ConsultaProfundaSegmentoJustica.JusticaEstadual => "JUSTICA_ESTADUAL",
                ConsultaProfundaSegmentoJustica.JusticaFederal => "JUSTICA_FEDERAL",
                ConsultaProfundaSegmentoJustica.JusticaMilitarEstadual => "JUSTICA_MILITAR_ESTADUAL",
                ConsultaProfundaSegmentoJustica.JusticaMilitarUniao => "JUSTICA_MILITAR_UNIAO",
                ConsultaProfundaSegmentoJustica.JusticaTrabalho => "JUSTICA_TRABALHO",
                ConsultaProfundaSegmentoJustica.SuperiorTribunalJustica => "SUPERIOR_TRIBUNAL_JUSTICA",
                ConsultaProfundaSegmentoJustica.SupremoTribunalFederal => "SUPREMO_TRIBUNAL_FEDERAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConsultaProfundaSegmentoJustica? ToEnum(string value)
        {
            return value switch
            {
                "CONSELHO_NACIONAL_JUSTICA" => ConsultaProfundaSegmentoJustica.ConselhoNacionalJustica,
                "JUSTICA_ELEITORAL" => ConsultaProfundaSegmentoJustica.JusticaEleitoral,
                "JUSTICA_ESTADUAL" => ConsultaProfundaSegmentoJustica.JusticaEstadual,
                "JUSTICA_FEDERAL" => ConsultaProfundaSegmentoJustica.JusticaFederal,
                "JUSTICA_MILITAR_ESTADUAL" => ConsultaProfundaSegmentoJustica.JusticaMilitarEstadual,
                "JUSTICA_MILITAR_UNIAO" => ConsultaProfundaSegmentoJustica.JusticaMilitarUniao,
                "JUSTICA_TRABALHO" => ConsultaProfundaSegmentoJustica.JusticaTrabalho,
                "SUPERIOR_TRIBUNAL_JUSTICA" => ConsultaProfundaSegmentoJustica.SuperiorTribunalJustica,
                "SUPREMO_TRIBUNAL_FEDERAL" => ConsultaProfundaSegmentoJustica.SupremoTribunalFederal,
                _ => null,
            };
        }
    }
}