using System.Collections.Generic;
using System.Xml.Serialization;

namespace CorreiosAPI.SIGEP.Response {
    [XmlRoot("return")]
    public class BuscaClienteResponse {
        [XmlElement("cnpj")]
        public string Cnpj { get; set; }

        [XmlElement("contratos")]
        public List<Contrato> Contratos { get; set; }
    }

    public class Contrato {
        [XmlElement("codigoDiretoria")]
        public string CodigoDiretoria { get; set; }

        [XmlElement("cartoesPostagem")]
        public CartaoPostagem CartoesPostagem { get; set; }
    }

    public class CartaoPostagem {
        [XmlElement("codigoAdministrativo")]
        public string CodigoAdministrativo { get; set; }

        [XmlElement("numero")]
        public string Numero { get; set; }

        [XmlElement("servicos")]
        public List<Servico> Servicos { get; set; }
    }

    public class Servico {
        [XmlElement("codigo")]
        public string Codigo { get; set; }

        [XmlElement("descricao")]
        public string Descricao { get; set; }

        [XmlElement("id")]
        public string Id { get; set; }
    }
}