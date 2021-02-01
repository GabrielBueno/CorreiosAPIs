namespace CorreiosAPI.SIGEP.Exception {
    public class SIGEPFaultException : SIGEPException {
        public SIGEPFaultException() : base() {}
        public SIGEPFaultException(string message) : base(message) {}
        public SIGEPFaultException(string mesage, System.Exception inner) : base(mesage, inner) {}
    }
}