namespace CorreiosAPI.SIGEP.Data {
    public class VerificacaoCep {
        public bool Existe { get; set; }
        public Endereco Endereco { get; set; }
        public System.Exception ErroInesperado { get; set; }
    }
}