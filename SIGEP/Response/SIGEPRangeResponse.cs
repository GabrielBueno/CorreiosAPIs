namespace CorreiosAPI.SIGEP.Response {
    public class SIGEPRangeResponse {
        public string Inicio { get; set; }
        public string Fim { get; set; }

        public SIGEPRangeResponse() {}

        public SIGEPRangeResponse(string inicio, string fim) {
            Inicio = inicio;
            Fim    = fim;
        }
    }
}