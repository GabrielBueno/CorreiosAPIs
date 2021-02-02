using CorreiosAPI.SIGEP.Data;

namespace CorreiosAPI.SIGEP.Constantes {
    public static class ServicosAdicionais {
        public static readonly ServicoAdicional AvisoDeRecebimento                    = new ServicoAdicional("001", "AR", "Aviso de recebimento");
        public static readonly ServicoAdicional MaoPropriaNacional                    = new ServicoAdicional("002", "MP", "Mão própria nacional");
        public static readonly ServicoAdicional EntregaNoVizinho                      = new ServicoAdicional("011", "EV", "Entrega no vizinho");
        public static readonly ServicoAdicional Eleicao                               = new ServicoAdicional("017", "EL", "Eleição");
        public static readonly ServicoAdicional ValorDeclaradoNacionalPremiumExpresso = new ServicoAdicional("019", "VD", "Valor declarado nacional premium e expresso");
        public static readonly ServicoAdicional AvisoDeRecebimentoEletronico          = new ServicoAdicional("021", "E-AR", "Aviso de recebimento eletrônico");
        public static readonly ServicoAdicional RegistroNacional                      = new ServicoAdicional("025", "RR", "Registro nacional");
        public static readonly ServicoAdicional CartaRegistradaComValorDeclarado      = new ServicoAdicional("035", "VD", "Carta registrada com valor declarado");
        public static readonly ServicoAdicional GrandesFormatos                       = new ServicoAdicional("057", "GF", "Grandes formatos (GF)");
        public static readonly ServicoAdicional ValorDeclaradoNacionalStandard        = new ServicoAdicional("064", "VD", "Valor declarado nacional standard");
        public static readonly ServicoAdicional ValorDeclaradoCorreiosMiniEnvios      = new ServicoAdicional("065", "VD", "Valor declarado para o Correios Mini Envios");
    }
}