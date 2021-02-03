using System.Xml.Linq;
using CorreiosAPI.SIGEP.Interfaces;

namespace CorreiosAPI.SIGEP.Request {
    public class GetStatusCartaoPostagemRequest : ISIGEPRequest {
        public string Cartao { get; set; }

        public GetStatusCartaoPostagemRequest(string cartao) {
            Cartao = cartao;
        }

        public XElement XML(string usuario, string senha, XNamespace cli) {
            return new XElement(cli+"getStatusCartaoPostagem",
                new XElement("numeroCartaoPostagem", Cartao),
                new XElement("usuario", usuario),
                new XElement("senha", senha)
            );
        }
    }
}