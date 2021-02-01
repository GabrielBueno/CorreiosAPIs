namespace CorreiosAPI.SIGEP.Exception {
    public class SIGEPErroIneseperadoException : SIGEPException {
        public SIGEPErroIneseperadoException() : base() {}
        public SIGEPErroIneseperadoException(string message) : base(message) {}
        public SIGEPErroIneseperadoException(string mesage, System.Exception inner) : base(mesage, inner) {}
    }
}