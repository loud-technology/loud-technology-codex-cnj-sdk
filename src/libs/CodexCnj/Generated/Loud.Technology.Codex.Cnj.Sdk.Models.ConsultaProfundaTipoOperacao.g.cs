
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConsultaProfundaTipoOperacao
    {
        /// <summary>
        /// 
        /// </summary>
        AlteraçãoDeDocumentos,
        /// <summary>
        /// 
        /// </summary>
        AlteraçãoDeMetadados,
        /// <summary>
        /// 
        /// </summary>
        AlteraçãoDeMovimentos,
        /// <summary>
        /// 
        /// </summary>
        AlteraçãoDePartes,
        /// <summary>
        /// 
        /// </summary>
        ExclusãoDeProcesso,
        /// <summary>
        /// 
        /// </summary>
        IdentificaçãoDePetiçãoInicial,
        /// <summary>
        /// 
        /// </summary>
        InserçãoDeProcesso,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConsultaProfundaTipoOperacaoExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConsultaProfundaTipoOperacao value)
        {
            return value switch
            {
                ConsultaProfundaTipoOperacao.AlteraçãoDeDocumentos => "Alteração de documentos",
                ConsultaProfundaTipoOperacao.AlteraçãoDeMetadados => "Alteração de metadados",
                ConsultaProfundaTipoOperacao.AlteraçãoDeMovimentos => "Alteração de movimentos",
                ConsultaProfundaTipoOperacao.AlteraçãoDePartes => "Alteração de partes",
                ConsultaProfundaTipoOperacao.ExclusãoDeProcesso => "Exclusão de processo",
                ConsultaProfundaTipoOperacao.IdentificaçãoDePetiçãoInicial => "Identificação de petição inicial",
                ConsultaProfundaTipoOperacao.InserçãoDeProcesso => "Inserção de processo",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConsultaProfundaTipoOperacao? ToEnum(string value)
        {
            return value switch
            {
                "Alteração de documentos" => ConsultaProfundaTipoOperacao.AlteraçãoDeDocumentos,
                "Alteração de metadados" => ConsultaProfundaTipoOperacao.AlteraçãoDeMetadados,
                "Alteração de movimentos" => ConsultaProfundaTipoOperacao.AlteraçãoDeMovimentos,
                "Alteração de partes" => ConsultaProfundaTipoOperacao.AlteraçãoDePartes,
                "Exclusão de processo" => ConsultaProfundaTipoOperacao.ExclusãoDeProcesso,
                "Identificação de petição inicial" => ConsultaProfundaTipoOperacao.IdentificaçãoDePetiçãoInicial,
                "Inserção de processo" => ConsultaProfundaTipoOperacao.InserçãoDeProcesso,
                _ => null,
            };
        }
    }
}