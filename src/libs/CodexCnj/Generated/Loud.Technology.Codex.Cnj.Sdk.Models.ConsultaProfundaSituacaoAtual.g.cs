
#nullable enable

namespace Loud.Technology.Codex.Cnj.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum ConsultaProfundaSituacaoAtual
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
    public static class ConsultaProfundaSituacaoAtualExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConsultaProfundaSituacaoAtual value)
        {
            return value switch
            {
                ConsultaProfundaSituacaoAtual.ArquivadoDefinitivamente => "Arquivado definitivamente",
                ConsultaProfundaSituacaoAtual.ArquivadoProvisoriamente => "Arquivado provisoriamente",
                ConsultaProfundaSituacaoAtual.AtoInfracionalIniciado => "Ato infracional iniciado",
                ConsultaProfundaSituacaoAtual.AudiênciaConciliatóriaDesignada => "Audiência conciliatória designada",
                ConsultaProfundaSituacaoAtual.AudiênciaConciliatóriaRedesignada => "Audiência conciliatória redesignada",
                ConsultaProfundaSituacaoAtual.AudiênciaNãoConciliatóriaDesignada => "Audiência não conciliatória designada",
                ConsultaProfundaSituacaoAtual.AudiênciaNãoConciliatóriaRedesignada => "Audiência não conciliatória redesignada",
                ConsultaProfundaSituacaoAtual.BaixadoDefinitivamente => "Baixado definitivamente",
                ConsultaProfundaSituacaoAtual.ClasseEvoluídaParaAtoInfracional => "Classe evoluída para ato infracional",
                ConsultaProfundaSituacaoAtual.ClasseEvoluídaParaAçãoPenal => "Classe evoluída para ação penal",
                ConsultaProfundaSituacaoAtual.Concluso => "Concluso",
                ConsultaProfundaSituacaoAtual.ConclusoParaAdmissibilidadeRecursal => "Concluso para admissibilidade recursal",
                ConsultaProfundaSituacaoAtual.ConclusoParaDecisão => "Concluso para decisão",
                ConsultaProfundaSituacaoAtual.ConclusoParaDespacho => "Concluso para despacho",
                ConsultaProfundaSituacaoAtual.ConclusoParaJulgamento => "Concluso para julgamento",
                ConsultaProfundaSituacaoAtual.DenúnciaQueixaRecebida => "Denúncia/queixa recebida",
                ConsultaProfundaSituacaoAtual.DistribuiçãoCancelada => "Distribuição cancelada",
                ConsultaProfundaSituacaoAtual.Distribuído => "Distribuído",
                ConsultaProfundaSituacaoAtual.ExecuçãoNãoCriminal => "Execução não criminal",
                ConsultaProfundaSituacaoAtual.ExecuçãoNãoCriminalIniciada => "Execução não criminal iniciada",
                ConsultaProfundaSituacaoAtual.FaseProcessualIniciada => "Fase processual iniciada",
                ConsultaProfundaSituacaoAtual.LiquidaçãoIniciada => "Liquidação iniciada",
                ConsultaProfundaSituacaoAtual.Pendente => "Pendente",
                ConsultaProfundaSituacaoAtual.PeríciaAgendada => "Perícia agendada",
                ConsultaProfundaSituacaoAtual.PeríciaDesignada => "Perícia designada",
                ConsultaProfundaSituacaoAtual.PeríciaReagendada => "Perícia reagendada",
                ConsultaProfundaSituacaoAtual.RecebidoPeloTribunal => "Recebido pelo Tribunal",
                ConsultaProfundaSituacaoAtual.RecursoInternoIniciado => "Recurso interno iniciado",
                ConsultaProfundaSituacaoAtual.RedistribuídoParaOutroTribunal => "Redistribuído para outro Tribunal",
                ConsultaProfundaSituacaoAtual.Remetido => "Remetido",
                ConsultaProfundaSituacaoAtual.RemetidoEmGrauDeRecurso => "Remetido em grau de recurso",
                ConsultaProfundaSituacaoAtual.RemetidoParaOutraInstância => "Remetido para outra instância",
                ConsultaProfundaSituacaoAtual.SessãoRestaurativaDesignada => "Sessão Restaurativa designada",
                ConsultaProfundaSituacaoAtual.SessãoRestaurativaRedesignada => "Sessão Restaurativa redesignada",
                ConsultaProfundaSituacaoAtual.SessãoDoJuriDesignada => "Sessão do juri designada",
                ConsultaProfundaSituacaoAtual.SessãoDoJuriRedesignada => "Sessão do juri redesignada",
                ConsultaProfundaSituacaoAtual.SupensoSobrestadoPorSirdr => "Supenso/Sobrestado por SIRDR",
                ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorIrdr => "Suspenso/Sobrestado por IRDR",
                ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorAçãoDeControleConcentradoDeConstitucionalidade => "Suspenso/sobrestado por Ação de Controle Concentrado de Constitucionalidade",
                ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorControvérsia => "Suspenso/sobrestado por Controvérsia",
                ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorGrupoDeRepresentativos => "Suspenso/sobrestado por Grupo de Representativos",
                ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorIac => "Suspenso/sobrestado por IAC",
                ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorRecursoRepetitivo => "Suspenso/sobrestado por Recurso Repetitivo",
                ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorRecursoDeRevistaRepetitiva => "Suspenso/sobrestado por Recurso de Revista Repetitiva",
                ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorRepercussãoGeral => "Suspenso/sobrestado por Repercussão Geral",
                ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorDecisãoJudicial => "Suspenso/sobrestado por decisão judicial",
                ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorDespachoJudicial => "Suspenso/sobrestado por despacho judicial",
                ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorPrejudicialidadeDeRe => "Suspenso/sobrestado por prejudicialidade de RE",
                ConsultaProfundaSituacaoAtual.Tramitando => "Tramitando",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConsultaProfundaSituacaoAtual? ToEnum(string value)
        {
            return value switch
            {
                "Arquivado definitivamente" => ConsultaProfundaSituacaoAtual.ArquivadoDefinitivamente,
                "Arquivado provisoriamente" => ConsultaProfundaSituacaoAtual.ArquivadoProvisoriamente,
                "Ato infracional iniciado" => ConsultaProfundaSituacaoAtual.AtoInfracionalIniciado,
                "Audiência conciliatória designada" => ConsultaProfundaSituacaoAtual.AudiênciaConciliatóriaDesignada,
                "Audiência conciliatória redesignada" => ConsultaProfundaSituacaoAtual.AudiênciaConciliatóriaRedesignada,
                "Audiência não conciliatória designada" => ConsultaProfundaSituacaoAtual.AudiênciaNãoConciliatóriaDesignada,
                "Audiência não conciliatória redesignada" => ConsultaProfundaSituacaoAtual.AudiênciaNãoConciliatóriaRedesignada,
                "Baixado definitivamente" => ConsultaProfundaSituacaoAtual.BaixadoDefinitivamente,
                "Classe evoluída para ato infracional" => ConsultaProfundaSituacaoAtual.ClasseEvoluídaParaAtoInfracional,
                "Classe evoluída para ação penal" => ConsultaProfundaSituacaoAtual.ClasseEvoluídaParaAçãoPenal,
                "Concluso" => ConsultaProfundaSituacaoAtual.Concluso,
                "Concluso para admissibilidade recursal" => ConsultaProfundaSituacaoAtual.ConclusoParaAdmissibilidadeRecursal,
                "Concluso para decisão" => ConsultaProfundaSituacaoAtual.ConclusoParaDecisão,
                "Concluso para despacho" => ConsultaProfundaSituacaoAtual.ConclusoParaDespacho,
                "Concluso para julgamento" => ConsultaProfundaSituacaoAtual.ConclusoParaJulgamento,
                "Denúncia/queixa recebida" => ConsultaProfundaSituacaoAtual.DenúnciaQueixaRecebida,
                "Distribuição cancelada" => ConsultaProfundaSituacaoAtual.DistribuiçãoCancelada,
                "Distribuído" => ConsultaProfundaSituacaoAtual.Distribuído,
                "Execução não criminal" => ConsultaProfundaSituacaoAtual.ExecuçãoNãoCriminal,
                "Execução não criminal iniciada" => ConsultaProfundaSituacaoAtual.ExecuçãoNãoCriminalIniciada,
                "Fase processual iniciada" => ConsultaProfundaSituacaoAtual.FaseProcessualIniciada,
                "Liquidação iniciada" => ConsultaProfundaSituacaoAtual.LiquidaçãoIniciada,
                "Pendente" => ConsultaProfundaSituacaoAtual.Pendente,
                "Perícia agendada" => ConsultaProfundaSituacaoAtual.PeríciaAgendada,
                "Perícia designada" => ConsultaProfundaSituacaoAtual.PeríciaDesignada,
                "Perícia reagendada" => ConsultaProfundaSituacaoAtual.PeríciaReagendada,
                "Recebido pelo Tribunal" => ConsultaProfundaSituacaoAtual.RecebidoPeloTribunal,
                "Recurso interno iniciado" => ConsultaProfundaSituacaoAtual.RecursoInternoIniciado,
                "Redistribuído para outro Tribunal" => ConsultaProfundaSituacaoAtual.RedistribuídoParaOutroTribunal,
                "Remetido" => ConsultaProfundaSituacaoAtual.Remetido,
                "Remetido em grau de recurso" => ConsultaProfundaSituacaoAtual.RemetidoEmGrauDeRecurso,
                "Remetido para outra instância" => ConsultaProfundaSituacaoAtual.RemetidoParaOutraInstância,
                "Sessão Restaurativa designada" => ConsultaProfundaSituacaoAtual.SessãoRestaurativaDesignada,
                "Sessão Restaurativa redesignada" => ConsultaProfundaSituacaoAtual.SessãoRestaurativaRedesignada,
                "Sessão do juri designada" => ConsultaProfundaSituacaoAtual.SessãoDoJuriDesignada,
                "Sessão do juri redesignada" => ConsultaProfundaSituacaoAtual.SessãoDoJuriRedesignada,
                "Supenso/Sobrestado por SIRDR" => ConsultaProfundaSituacaoAtual.SupensoSobrestadoPorSirdr,
                "Suspenso/Sobrestado por IRDR" => ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorIrdr,
                "Suspenso/sobrestado por Ação de Controle Concentrado de Constitucionalidade" => ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorAçãoDeControleConcentradoDeConstitucionalidade,
                "Suspenso/sobrestado por Controvérsia" => ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorControvérsia,
                "Suspenso/sobrestado por Grupo de Representativos" => ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorGrupoDeRepresentativos,
                "Suspenso/sobrestado por IAC" => ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorIac,
                "Suspenso/sobrestado por Recurso Repetitivo" => ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorRecursoRepetitivo,
                "Suspenso/sobrestado por Recurso de Revista Repetitiva" => ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorRecursoDeRevistaRepetitiva,
                "Suspenso/sobrestado por Repercussão Geral" => ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorRepercussãoGeral,
                "Suspenso/sobrestado por decisão judicial" => ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorDecisãoJudicial,
                "Suspenso/sobrestado por despacho judicial" => ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorDespachoJudicial,
                "Suspenso/sobrestado por prejudicialidade de RE" => ConsultaProfundaSituacaoAtual.SuspensoSobrestadoPorPrejudicialidadeDeRe,
                "Tramitando" => ConsultaProfundaSituacaoAtual.Tramitando,
                _ => null,
            };
        }
    }
}