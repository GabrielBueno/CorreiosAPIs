using CorreiosAPI.SIGEP.Interfaces;

namespace CorreiosAPI.SIGEP.Data {
    public class TipoServicoAdicional : IEq {
        public string Codigo { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }

        public TipoServicoAdicional() {}

        public TipoServicoAdicional(string codigo, string sigla, string descricao) {
            Codigo    = codigo;
            Sigla     = sigla;
            Descricao = descricao;
        }

        public bool Eq(IEq some)
            => some.Eq(this);

        public bool Eq(TipoServicoAdicional ts)
            => ts.Codigo.Trim() == Codigo.Trim();

        public static TipoServicoAdicional AvisoDeRecebimento()
            => new TipoServicoAdicional("001", "AR", "Aviso de recebimento");

        public static TipoServicoAdicional MaoPropriaNacional()
            => new TipoServicoAdicional("002", "MP", "Mão própria nacional");

        public static TipoServicoAdicional EntregaNoVizinho()
            => new TipoServicoAdicional("011", "EV", "Entrega no vizinho");

        public static TipoServicoAdicional Eleicao()
            => new TipoServicoAdicional("017", "EL", "Eleição");

        public static TipoServicoAdicional ValorDeclaradoNacionalPremiumExpresso()
            => new TipoServicoAdicional("019", "VD", "Valor declarado nacional premium e expresso");

        public static TipoServicoAdicional AvisoDeRecebimentoEletronico()
            => new TipoServicoAdicional("021", "E-AR", "Aviso de recebimento eletrônico");

        public static TipoServicoAdicional RegistroNacional()
            => new TipoServicoAdicional("025", "RR", "Registro nacional");

        public static TipoServicoAdicional CartaRegistradaComValorDeclarado()
            => new TipoServicoAdicional("035", "VD", "Carta registrada com valor declarado");

        public static TipoServicoAdicional GrandesFormatos()
            => new TipoServicoAdicional("057", "GF", "Grandes formatos (GF)");

        public static TipoServicoAdicional ValorDeclaradoNacionalStandard()
            => new TipoServicoAdicional("064", "VD", "Valor declarado nacional standard");

        public static TipoServicoAdicional ValorDeclaradoCorreiosMiniEnvios()
            => new TipoServicoAdicional("065", "VD", "Valor declarado para o Correios Mini Envios");

    }
}