using CorreiosAPI.SIGEP.Data;

namespace CorreiosAPI.SIGEP.Constantes {
    public static class ServicosAdicionais {
        public static readonly TipoServicoAdicional AvisoDeRecebimento                    = new TipoServicoAdicional("001", "AR", "Aviso de recebimento");
        public static readonly TipoServicoAdicional MaoPropriaNacional                    = new TipoServicoAdicional("002", "MP", "Mão própria nacional");
        public static readonly TipoServicoAdicional EntregaNoVizinho                      = new TipoServicoAdicional("011", "EV", "Entrega no vizinho");
        public static readonly TipoServicoAdicional Eleicao                               = new TipoServicoAdicional("017", "EL", "Eleição");
        public static readonly TipoServicoAdicional ValorDeclaradoNacionalPremiumExpresso = new TipoServicoAdicional("019", "VD", "Valor declarado nacional premium e expresso");
        public static readonly TipoServicoAdicional AvisoDeRecebimentoEletronico          = new TipoServicoAdicional("021", "E-AR", "Aviso de recebimento eletrônico");
        public static readonly TipoServicoAdicional RegistroNacional                      = new TipoServicoAdicional("025", "RR", "Registro nacional");
        public static readonly TipoServicoAdicional CartaRegistradaComValorDeclarado      = new TipoServicoAdicional("035", "VD", "Carta registrada com valor declarado");
        public static readonly TipoServicoAdicional GrandesFormatos                       = new TipoServicoAdicional("057", "GF", "Grandes formatos (GF)");
        public static readonly TipoServicoAdicional ValorDeclaradoNacionalStandard        = new TipoServicoAdicional("064", "VD", "Valor declarado nacional standard");
        public static readonly TipoServicoAdicional ValorDeclaradoCorreiosMiniEnvios      = new TipoServicoAdicional("065", "VD", "Valor declarado para o Correios Mini Envios");
    }
}