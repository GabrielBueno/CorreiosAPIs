namespace CorreiosAPI.SIGEP.Data {
    public class ServicoAdicional {
        public string Codigo { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }

        public ServicoAdicional() {}

        public ServicoAdicional(string codigo, string sigla, string descricao) {
            Codigo    = codigo;
            Sigla     = sigla;
            Descricao = descricao;
        }
    }
}