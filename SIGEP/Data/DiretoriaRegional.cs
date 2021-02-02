namespace CorreiosAPI.SIGEP.Data {
    public class DiretoriaRegional {
        public string Codigo { get; set; }
        public string Descricao { get; set; }
        public string Sigla { get; set; }

        public DiretoriaRegional() {}

        public DiretoriaRegional(string codigo, string descricao, string sigla) {
            Codigo    = codigo;
            Descricao = descricao;
            Sigla     = sigla;
        }

        public static DiretoriaRegional CorreiosSede()
            => new DiretoriaRegional("01", "CS - Correios Sede", "CS");

        public static DiretoriaRegional Acre()
            => new DiretoriaRegional("03", "SE - ACRE", "ACR");

        public static DiretoriaRegional Alagoas()
            => new DiretoriaRegional("04", "SE - ALAGOAS", "AL");

        public static DiretoriaRegional Amazonas()
            => new DiretoriaRegional("06", "SE - AMAZONAS", "AM");

        public static DiretoriaRegional Amapa()
            => new DiretoriaRegional("05", "SE - AMAPÁ", "AP");

        public static DiretoriaRegional Bahia()
            => new DiretoriaRegional("08", "SE - BAHIA", "BA");

        public static DiretoriaRegional Brasilia()
            => new DiretoriaRegional("10", "SE - BRASÍLIA", "BSB");

        public static DiretoriaRegional Ceara()
            => new DiretoriaRegional("12", "SE - CEARÁ", "CE");

        public static DiretoriaRegional EspiritoSanto()
            => new DiretoriaRegional("14", "SE - ESPIRITO SANTO", "ES");

        public static DiretoriaRegional Goias()
            => new DiretoriaRegional("16", "SE - GOIÁS", "GO");

        public static DiretoriaRegional Maranhao()
            => new DiretoriaRegional("18", "SE - MARANHÃO", "MA");

        public static DiretoriaRegional MinasGerais()
            => new DiretoriaRegional("20", "SE - MINAS GERAIS", "MG");

        public static DiretoriaRegional MatoGrossoDoSul()
            => new DiretoriaRegional("22", "SE - MATO GROSSO DO SUL", "MS");

        public static DiretoriaRegional MatoGrosso()
            => new DiretoriaRegional("24", "SE - MATO GROSSO", "MT");

        public static DiretoriaRegional Para()
            => new DiretoriaRegional("28", "SE - PARÁ", "PA");

        public static DiretoriaRegional Paraiba()
            => new DiretoriaRegional("30", "SE - PARAIBA", "PB");

        public static DiretoriaRegional Pernambuco()
            => new DiretoriaRegional("32", "SE - PERNAMBUCO", "PE");

        public static DiretoriaRegional Piaui()
            => new DiretoriaRegional("34", "SE - PIAUI", "PI");

        public static DiretoriaRegional Parana()
            => new DiretoriaRegional("36", "SE - PARANÁ", "PR");

        public static DiretoriaRegional RioDeJaneiro()
            => new DiretoriaRegional("50", "SE - RIO DE JANEIRO", "RJ");

        public static DiretoriaRegional RioGrandeDoNorte()
            => new DiretoriaRegional("60", "SE - RIO GRANDE DO NORTE", "RN");

        public static DiretoriaRegional Rondonia()
            => new DiretoriaRegional("26", "SE - RONDONIA", "RO");

        public static DiretoriaRegional Roraima()
            => new DiretoriaRegional("65", "SE - RORAIMA", "RR");

        public static DiretoriaRegional RioGrandeDoSul()
            => new DiretoriaRegional("64", "SE - RIO GRANDE DO SUL", "RS");

        public static DiretoriaRegional SantaCatarina()
            => new DiretoriaRegional("68", "SE - SANTA CATARINA", "SC");

        public static DiretoriaRegional Sergipe()
            => new DiretoriaRegional("70", "SE - SERGIPE", "SE");

        public static DiretoriaRegional SaoPauloInterior()
            => new DiretoriaRegional("74", "SE - SÃO PAULO INTERIOR", "SPI");

        public static DiretoriaRegional SaoPaulo()
            => new DiretoriaRegional("72", "SE - SÃO PAULO", "SPM");

        public static DiretoriaRegional Tocantins()
            => new DiretoriaRegional("75", "SE - TOCANTINS", "TO");

    }
}