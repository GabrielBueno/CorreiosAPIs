using System.Xml.Linq;

namespace CorreiosAPI.SIGEP.Request {
    public class SolicitaEtiquetasRequest : ISIGEPRequest {
        public string TipoDestinatario { get; set; }
        public string Cnpj { get; set; }
        public string IdServico { get; set; }
        public int QtdeEtiquetas { get; set; }

        public XElement XML(string usuario, string senha, XNamespace cli) {
            return new XElement(cli+"solicitaEtiquetas",
                new XElement("tipoDestinatario", TipoDestinatario),
                new XElement("identificador",    Cnpj),
                new XElement("idServico",        IdServico),
                new XElement("qtdEtiquetas",     QtdeEtiquetas),
                new XElement("usuario",          usuario),
                new XElement("senha",            senha)
            );
        }
    }
}