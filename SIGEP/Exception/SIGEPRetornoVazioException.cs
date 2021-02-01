namespace CorreiosAPI.SIGEP.Exception {
    public class SIGEPRetornoVazioException : SIGEPException {
        public SIGEPRetornoVazioException() : base() {}
        public SIGEPRetornoVazioException(string message) : base(message) {}
        public SIGEPRetornoVazioException(string mesage, System.Exception inner) : base(mesage, inner) {}
    }
}