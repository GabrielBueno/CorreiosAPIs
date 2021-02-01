namespace CorreiosAPI.SIGEP.Exception {
    public class SIGEPException : System.Exception {
        public SIGEPException() : base() {}
        public SIGEPException(string message) : base(message) {}
        public SIGEPException(string mesage, System.Exception inner) : base(mesage, inner) {}
    }
}