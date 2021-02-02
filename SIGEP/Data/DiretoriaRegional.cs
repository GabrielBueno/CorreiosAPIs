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
    }
}