using System.Collections.Generic;
using CorreiosAPI.SIGEP.Data;

namespace CorreiosAPI.SIGEP.Constantes {
    public static class ObrigatoriedadeServicosAdicionais {
        public static readonly List<TipoServicoAdicional> SedexContratoEServicosPremiums = new List<TipoServicoAdicional> { 
            ServicosAdicionais.RegistroNacional 
        };

        public static readonly List<TipoServicoAdicional> PacContrato = new List<TipoServicoAdicional> { 
            ServicosAdicionais.RegistroNacional 
        };

        public static readonly List<TipoServicoAdicional> SedexOuPacContratoGrandesFormatos = new List<TipoServicoAdicional> {
            ServicosAdicionais.RegistroNacional,
            ServicosAdicionais.GrandesFormatos
        };

        public static readonly List<TipoServicoAdicional> CorreiosMiniEnvios = new List<TipoServicoAdicional> {
            ServicosAdicionais.RegistroNacional
        };

        public static readonly List<TipoServicoAdicional> CartaRegSeloESe = new List<TipoServicoAdicional> {
            ServicosAdicionais.RegistroNacional
        };

        public static readonly List<TipoServicoAdicional> CartaRgArConvChanEtiq = new List<TipoServicoAdicional> {
            ServicosAdicionais.RegistroNacional
        };

        public static readonly List<TipoServicoAdicional> CartaRgArEltrChancEtiq = new List<TipoServicoAdicional> {
            ServicosAdicionais.RegistroNacional,
            ServicosAdicionais.AvisoDeRecebimentoEletronico
        };
    }
}