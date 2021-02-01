using System.Xml.Linq;

namespace CorreiosAPI.SIGEP.Request {
    public class ConsultaCepRequest : ISIGEPRequest {
        public string Cep { get; set; }

        public ConsultaCepRequest(string cep) {
            Cep = cep;
        }

        public XElement XML(string usuario, string senha, XNamespace cli) {
            return new XElement(cli+"consultaCEP",
                new XElement("cep", Cep)
            );
        }
    }
}