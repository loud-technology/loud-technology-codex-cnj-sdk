
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContadorProcessosSegmentoJustica
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
    public static class ContadorProcessosSegmentoJusticaExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContadorProcessosSegmentoJustica value)
        {
            return value switch
            {
                ContadorProcessosSegmentoJustica.ConselhoNacionalJustica => "CONSELHO_NACIONAL_JUSTICA",
                ContadorProcessosSegmentoJustica.JusticaEleitoral => "JUSTICA_ELEITORAL",
                ContadorProcessosSegmentoJustica.JusticaEstadual => "JUSTICA_ESTADUAL",
                ContadorProcessosSegmentoJustica.JusticaFederal => "JUSTICA_FEDERAL",
                ContadorProcessosSegmentoJustica.JusticaMilitarEstadual => "JUSTICA_MILITAR_ESTADUAL",
                ContadorProcessosSegmentoJustica.JusticaMilitarUniao => "JUSTICA_MILITAR_UNIAO",
                ContadorProcessosSegmentoJustica.JusticaTrabalho => "JUSTICA_TRABALHO",
                ContadorProcessosSegmentoJustica.SuperiorTribunalJustica => "SUPERIOR_TRIBUNAL_JUSTICA",
                ContadorProcessosSegmentoJustica.SupremoTribunalFederal => "SUPREMO_TRIBUNAL_FEDERAL",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContadorProcessosSegmentoJustica? ToEnum(string value)
        {
            return value switch
            {
                "CONSELHO_NACIONAL_JUSTICA" => ContadorProcessosSegmentoJustica.ConselhoNacionalJustica,
                "JUSTICA_ELEITORAL" => ContadorProcessosSegmentoJustica.JusticaEleitoral,
                "JUSTICA_ESTADUAL" => ContadorProcessosSegmentoJustica.JusticaEstadual,
                "JUSTICA_FEDERAL" => ContadorProcessosSegmentoJustica.JusticaFederal,
                "JUSTICA_MILITAR_ESTADUAL" => ContadorProcessosSegmentoJustica.JusticaMilitarEstadual,
                "JUSTICA_MILITAR_UNIAO" => ContadorProcessosSegmentoJustica.JusticaMilitarUniao,
                "JUSTICA_TRABALHO" => ContadorProcessosSegmentoJustica.JusticaTrabalho,
                "SUPERIOR_TRIBUNAL_JUSTICA" => ContadorProcessosSegmentoJustica.SuperiorTribunalJustica,
                "SUPREMO_TRIBUNAL_FEDERAL" => ContadorProcessosSegmentoJustica.SupremoTribunalFederal,
                _ => null,
            };
        }
    }
}