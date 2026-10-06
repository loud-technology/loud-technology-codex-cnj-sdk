
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConsultaMetricaSituacaoAtual
    {
        /// <summary>
        /// 
        /// </summary>
        ArquivadoDefinitivamente,
        /// <summary>
        /// 
        /// </summary>
        ArquivadoProvisoriamente,
        /// <summary>
        /// 
        /// </summary>
        AtoInfracionalIniciado,
        /// <summary>
        /// 
        /// </summary>
        AudiênciaConciliatóriaDesignada,
        /// <summary>
        /// 
        /// </summary>
        AudiênciaConciliatóriaRedesignada,
        /// <summary>
        /// 
        /// </summary>
        AudiênciaNãoConciliatóriaDesignada,
        /// <summary>
        /// 
        /// </summary>
        AudiênciaNãoConciliatóriaRedesignada,
        /// <summary>
        /// 
        /// </summary>
        BaixadoDefinitivamente,
        /// <summary>
        /// 
        /// </summary>
        ClasseEvoluídaParaAtoInfracional,
        /// <summary>
        /// 
        /// </summary>
        ClasseEvoluídaParaAçãoPenal,
        /// <summary>
        /// 
        /// </summary>
        Concluso,
        /// <summary>
        /// 
        /// </summary>
        ConclusoParaAdmissibilidadeRecursal,
        /// <summary>
        /// 
        /// </summary>
        ConclusoParaDecisão,
        /// <summary>
        /// 
        /// </summary>
        ConclusoParaDespacho,
        /// <summary>
        /// 
        /// </summary>
        ConclusoParaJulgamento,
        /// <summary>
        /// 
        /// </summary>
        DenúnciaQueixaRecebida,
        /// <summary>
        /// 
        /// </summary>
        DistribuiçãoCancelada,
        /// <summary>
        /// 
        /// </summary>
        Distribuído,
        /// <summary>
        /// 
        /// </summary>
        ExecuçãoNãoCriminal,
        /// <summary>
        /// 
        /// </summary>
        ExecuçãoNãoCriminalIniciada,
        /// <summary>
        /// 
        /// </summary>
        FaseProcessualIniciada,
        /// <summary>
        /// 
        /// </summary>
        LiquidaçãoIniciada,
        /// <summary>
        /// 
        /// </summary>
        Pendente,
        /// <summary>
        /// 
        /// </summary>
        PeríciaAgendada,
        /// <summary>
        /// 
        /// </summary>
        PeríciaDesignada,
        /// <summary>
        /// 
        /// </summary>
        PeríciaReagendada,
        /// <summary>
        /// 
        /// </summary>
        RecebidoPeloTribunal,
        /// <summary>
        /// 
        /// </summary>
        RecursoInternoIniciado,
        /// <summary>
        /// 
        /// </summary>
        RedistribuídoParaOutroTribunal,
        /// <summary>
        /// 
        /// </summary>
        Remetido,
        /// <summary>
        /// 
        /// </summary>
        RemetidoEmGrauDeRecurso,
        /// <summary>
        /// 
        /// </summary>
        RemetidoParaOutraInstância,
        /// <summary>
        /// 
        /// </summary>
        SessãoRestaurativaDesignada,
        /// <summary>
        /// 
        /// </summary>
        SessãoRestaurativaRedesignada,
        /// <summary>
        /// 
        /// </summary>
        SessãoDoJuriDesignada,
        /// <summary>
        /// 
        /// </summary>
        SessãoDoJuriRedesignada,
        /// <summary>
        /// 
        /// </summary>
        SupensoSobrestadoPorSirdr,
        /// <summary>
        /// 
        /// </summary>
        SuspensoSobrestadoPorIrdr,
        /// <summary>
        /// 
        /// </summary>
        SuspensoSobrestadoPorAçãoDeControleConcentradoDeConstitucionalidade,
        /// <summary>
        /// 
        /// </summary>
        SuspensoSobrestadoPorControvérsia,
        /// <summary>
        /// 
        /// </summary>
        SuspensoSobrestadoPorGrupoDeRepresentativos,
        /// <summary>
        /// 
        /// </summary>
        SuspensoSobrestadoPorIac,
        /// <summary>
        /// 
        /// </summary>
        SuspensoSobrestadoPorRecursoRepetitivo,
        /// <summary>
        /// 
        /// </summary>
        SuspensoSobrestadoPorRecursoDeRevistaRepetitiva,
        /// <summary>
        /// 
        /// </summary>
        SuspensoSobrestadoPorRepercussãoGeral,
        /// <summary>
        /// 
        /// </summary>
        SuspensoSobrestadoPorDecisãoJudicial,
        /// <summary>
        /// 
        /// </summary>
        SuspensoSobrestadoPorDespachoJudicial,
        /// <summary>
        /// 
        /// </summary>
        SuspensoSobrestadoPorPrejudicialidadeDeRe,
        /// <summary>
        /// 
        /// </summary>
        Tramitando,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConsultaMetricaSituacaoAtualExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConsultaMetricaSituacaoAtual value)
        {
            return value switch
            {
                ConsultaMetricaSituacaoAtual.ArquivadoDefinitivamente => "Arquivado definitivamente",
                ConsultaMetricaSituacaoAtual.ArquivadoProvisoriamente => "Arquivado provisoriamente",
                ConsultaMetricaSituacaoAtual.AtoInfracionalIniciado => "Ato infracional iniciado",
                ConsultaMetricaSituacaoAtual.AudiênciaConciliatóriaDesignada => "Audiência conciliatória designada",
                ConsultaMetricaSituacaoAtual.AudiênciaConciliatóriaRedesignada => "Audiência conciliatória redesignada",
                ConsultaMetricaSituacaoAtual.AudiênciaNãoConciliatóriaDesignada => "Audiência não conciliatória designada",
                ConsultaMetricaSituacaoAtual.AudiênciaNãoConciliatóriaRedesignada => "Audiência não conciliatória redesignada",
                ConsultaMetricaSituacaoAtual.BaixadoDefinitivamente => "Baixado definitivamente",
                ConsultaMetricaSituacaoAtual.ClasseEvoluídaParaAtoInfracional => "Classe evoluída para ato infracional",
                ConsultaMetricaSituacaoAtual.ClasseEvoluídaParaAçãoPenal => "Classe evoluída para ação penal",
                ConsultaMetricaSituacaoAtual.Concluso => "Concluso",
                ConsultaMetricaSituacaoAtual.ConclusoParaAdmissibilidadeRecursal => "Concluso para admissibilidade recursal",
                ConsultaMetricaSituacaoAtual.ConclusoParaDecisão => "Concluso para decisão",
                ConsultaMetricaSituacaoAtual.ConclusoParaDespacho => "Concluso para despacho",
                ConsultaMetricaSituacaoAtual.ConclusoParaJulgamento => "Concluso para julgamento",
                ConsultaMetricaSituacaoAtual.DenúnciaQueixaRecebida => "Denúncia/queixa recebida",
                ConsultaMetricaSituacaoAtual.DistribuiçãoCancelada => "Distribuição cancelada",
                ConsultaMetricaSituacaoAtual.Distribuído => "Distribuído",
                ConsultaMetricaSituacaoAtual.ExecuçãoNãoCriminal => "Execução não criminal",
                ConsultaMetricaSituacaoAtual.ExecuçãoNãoCriminalIniciada => "Execução não criminal iniciada",
                ConsultaMetricaSituacaoAtual.FaseProcessualIniciada => "Fase processual iniciada",
                ConsultaMetricaSituacaoAtual.LiquidaçãoIniciada => "Liquidação iniciada",
                ConsultaMetricaSituacaoAtual.Pendente => "Pendente",
                ConsultaMetricaSituacaoAtual.PeríciaAgendada => "Perícia agendada",
                ConsultaMetricaSituacaoAtual.PeríciaDesignada => "Perícia designada",
                ConsultaMetricaSituacaoAtual.PeríciaReagendada => "Perícia reagendada",
                ConsultaMetricaSituacaoAtual.RecebidoPeloTribunal => "Recebido pelo Tribunal",
                ConsultaMetricaSituacaoAtual.RecursoInternoIniciado => "Recurso interno iniciado",
                ConsultaMetricaSituacaoAtual.RedistribuídoParaOutroTribunal => "Redistribuído para outro Tribunal",
                ConsultaMetricaSituacaoAtual.Remetido => "Remetido",
                ConsultaMetricaSituacaoAtual.RemetidoEmGrauDeRecurso => "Remetido em grau de recurso",
                ConsultaMetricaSituacaoAtual.RemetidoParaOutraInstância => "Remetido para outra instância",
                ConsultaMetricaSituacaoAtual.SessãoRestaurativaDesignada => "Sessão Restaurativa designada",
                ConsultaMetricaSituacaoAtual.SessãoRestaurativaRedesignada => "Sessão Restaurativa redesignada",
                ConsultaMetricaSituacaoAtual.SessãoDoJuriDesignada => "Sessão do juri designada",
                ConsultaMetricaSituacaoAtual.SessãoDoJuriRedesignada => "Sessão do juri redesignada",
                ConsultaMetricaSituacaoAtual.SupensoSobrestadoPorSirdr => "Supenso/Sobrestado por SIRDR",
                ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorIrdr => "Suspenso/Sobrestado por IRDR",
                ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorAçãoDeControleConcentradoDeConstitucionalidade => "Suspenso/sobrestado por Ação de Controle Concentrado de Constitucionalidade",
                ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorControvérsia => "Suspenso/sobrestado por Controvérsia",
                ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorGrupoDeRepresentativos => "Suspenso/sobrestado por Grupo de Representativos",
                ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorIac => "Suspenso/sobrestado por IAC",
                ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorRecursoRepetitivo => "Suspenso/sobrestado por Recurso Repetitivo",
                ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorRecursoDeRevistaRepetitiva => "Suspenso/sobrestado por Recurso de Revista Repetitiva",
                ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorRepercussãoGeral => "Suspenso/sobrestado por Repercussão Geral",
                ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorDecisãoJudicial => "Suspenso/sobrestado por decisão judicial",
                ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorDespachoJudicial => "Suspenso/sobrestado por despacho judicial",
                ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorPrejudicialidadeDeRe => "Suspenso/sobrestado por prejudicialidade de RE",
                ConsultaMetricaSituacaoAtual.Tramitando => "Tramitando",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConsultaMetricaSituacaoAtual? ToEnum(string value)
        {
            return value switch
            {
                "Arquivado definitivamente" => ConsultaMetricaSituacaoAtual.ArquivadoDefinitivamente,
                "Arquivado provisoriamente" => ConsultaMetricaSituacaoAtual.ArquivadoProvisoriamente,
                "Ato infracional iniciado" => ConsultaMetricaSituacaoAtual.AtoInfracionalIniciado,
                "Audiência conciliatória designada" => ConsultaMetricaSituacaoAtual.AudiênciaConciliatóriaDesignada,
                "Audiência conciliatória redesignada" => ConsultaMetricaSituacaoAtual.AudiênciaConciliatóriaRedesignada,
                "Audiência não conciliatória designada" => ConsultaMetricaSituacaoAtual.AudiênciaNãoConciliatóriaDesignada,
                "Audiência não conciliatória redesignada" => ConsultaMetricaSituacaoAtual.AudiênciaNãoConciliatóriaRedesignada,
                "Baixado definitivamente" => ConsultaMetricaSituacaoAtual.BaixadoDefinitivamente,
                "Classe evoluída para ato infracional" => ConsultaMetricaSituacaoAtual.ClasseEvoluídaParaAtoInfracional,
                "Classe evoluída para ação penal" => ConsultaMetricaSituacaoAtual.ClasseEvoluídaParaAçãoPenal,
                "Concluso" => ConsultaMetricaSituacaoAtual.Concluso,
                "Concluso para admissibilidade recursal" => ConsultaMetricaSituacaoAtual.ConclusoParaAdmissibilidadeRecursal,
                "Concluso para decisão" => ConsultaMetricaSituacaoAtual.ConclusoParaDecisão,
                "Concluso para despacho" => ConsultaMetricaSituacaoAtual.ConclusoParaDespacho,
                "Concluso para julgamento" => ConsultaMetricaSituacaoAtual.ConclusoParaJulgamento,
                "Denúncia/queixa recebida" => ConsultaMetricaSituacaoAtual.DenúnciaQueixaRecebida,
                "Distribuição cancelada" => ConsultaMetricaSituacaoAtual.DistribuiçãoCancelada,
                "Distribuído" => ConsultaMetricaSituacaoAtual.Distribuído,
                "Execução não criminal" => ConsultaMetricaSituacaoAtual.ExecuçãoNãoCriminal,
                "Execução não criminal iniciada" => ConsultaMetricaSituacaoAtual.ExecuçãoNãoCriminalIniciada,
                "Fase processual iniciada" => ConsultaMetricaSituacaoAtual.FaseProcessualIniciada,
                "Liquidação iniciada" => ConsultaMetricaSituacaoAtual.LiquidaçãoIniciada,
                "Pendente" => ConsultaMetricaSituacaoAtual.Pendente,
                "Perícia agendada" => ConsultaMetricaSituacaoAtual.PeríciaAgendada,
                "Perícia designada" => ConsultaMetricaSituacaoAtual.PeríciaDesignada,
                "Perícia reagendada" => ConsultaMetricaSituacaoAtual.PeríciaReagendada,
                "Recebido pelo Tribunal" => ConsultaMetricaSituacaoAtual.RecebidoPeloTribunal,
                "Recurso interno iniciado" => ConsultaMetricaSituacaoAtual.RecursoInternoIniciado,
                "Redistribuído para outro Tribunal" => ConsultaMetricaSituacaoAtual.RedistribuídoParaOutroTribunal,
                "Remetido" => ConsultaMetricaSituacaoAtual.Remetido,
                "Remetido em grau de recurso" => ConsultaMetricaSituacaoAtual.RemetidoEmGrauDeRecurso,
                "Remetido para outra instância" => ConsultaMetricaSituacaoAtual.RemetidoParaOutraInstância,
                "Sessão Restaurativa designada" => ConsultaMetricaSituacaoAtual.SessãoRestaurativaDesignada,
                "Sessão Restaurativa redesignada" => ConsultaMetricaSituacaoAtual.SessãoRestaurativaRedesignada,
                "Sessão do juri designada" => ConsultaMetricaSituacaoAtual.SessãoDoJuriDesignada,
                "Sessão do juri redesignada" => ConsultaMetricaSituacaoAtual.SessãoDoJuriRedesignada,
                "Supenso/Sobrestado por SIRDR" => ConsultaMetricaSituacaoAtual.SupensoSobrestadoPorSirdr,
                "Suspenso/Sobrestado por IRDR" => ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorIrdr,
                "Suspenso/sobrestado por Ação de Controle Concentrado de Constitucionalidade" => ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorAçãoDeControleConcentradoDeConstitucionalidade,
                "Suspenso/sobrestado por Controvérsia" => ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorControvérsia,
                "Suspenso/sobrestado por Grupo de Representativos" => ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorGrupoDeRepresentativos,
                "Suspenso/sobrestado por IAC" => ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorIac,
                "Suspenso/sobrestado por Recurso Repetitivo" => ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorRecursoRepetitivo,
                "Suspenso/sobrestado por Recurso de Revista Repetitiva" => ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorRecursoDeRevistaRepetitiva,
                "Suspenso/sobrestado por Repercussão Geral" => ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorRepercussãoGeral,
                "Suspenso/sobrestado por decisão judicial" => ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorDecisãoJudicial,
                "Suspenso/sobrestado por despacho judicial" => ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorDespachoJudicial,
                "Suspenso/sobrestado por prejudicialidade de RE" => ConsultaMetricaSituacaoAtual.SuspensoSobrestadoPorPrejudicialidadeDeRe,
                "Tramitando" => ConsultaMetricaSituacaoAtual.Tramitando,
                _ => null,
            };
        }
    }
}