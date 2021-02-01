namespace CorreiosAPI.SIGEP.Response {
    public class SIGEPCodeResponse {
        public string Codigo { get; set; }
        public string Descricao { get; set; }

        public SIGEPCodeResponse(string codigo, string descricao) {
            Codigo    = codigo;
            Descricao = descricao;
        }
    }
}