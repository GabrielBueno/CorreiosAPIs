using System.Xml.Linq;
using CorreiosAPI.SIGEP.Interfaces;

namespace CorreiosAPI.SIGEP.Request {
    public class BuscaClienteRequest : ISIGEPRequest {
        public string IdContrato { get; set; }
        public string IdCartaoPostagem { get; set; }

        public XElement XML(string usuario, string senha, XNamespace cli) {
            return new XElement(cli+"buscaCliente",
                new XElement("idContrato",       IdContrato),
                new XElement("idCartaoPostagem", IdCartaoPostagem),
                new XElement("usuario",          usuario),
                new XElement("senha",            senha)
            );
        }
    }
}