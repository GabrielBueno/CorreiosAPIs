namespace CorreiosAPI.SIGEP.Exception {
    public class SIGEPValidacaoException : SIGEPException {
        public SIGEPValidacaoException() : base() {}
        public SIGEPValidacaoException(string message) : base(message) {}
        public SIGEPValidacaoException(string mesage, System.Exception inner) : base(mesage, inner) {}
    }
}