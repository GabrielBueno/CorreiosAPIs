namespace CorreiosAPI.SIGEP.Exception {
    public class SIGEPDeserializeException : SIGEPException {
        public SIGEPDeserializeException() : base() {}
        public SIGEPDeserializeException(string message) : base(message) {}
        public SIGEPDeserializeException(string mesage, System.Exception inner) : base(mesage, inner) {}
    }
}