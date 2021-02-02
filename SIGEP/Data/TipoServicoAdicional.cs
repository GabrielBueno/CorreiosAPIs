namespace CorreiosAPI.SIGEP.Data {
    public class TipoServicoAdicional {
        public string Codigo { get; set; }
        public string Sigla { get; set; }
        public string Descricao { get; set; }

        public TipoServicoAdicional() {}

        public TipoServicoAdicional(string codigo, string sigla, string descricao) {
            Codigo    = codigo;
            Sigla     = sigla;
            Descricao = descricao;
        }
    }
}