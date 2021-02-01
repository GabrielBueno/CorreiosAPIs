using System.Xml.Serialization;

namespace CorreiosAPI.SIGEP.Response {
    [XmlRoot("return")]
    public class ConsultaCepResponse {
        [XmlElement("bairro")]
        public string Bairro { get; set; }

        [XmlElement("cep")]
        public string Cep { get; set; }

        [XmlElement("cidade")]
        public string Cidade { get; set; }

        [XmlElement("complemento")]
        public string Complemento { get; set; }

        [XmlElement("complemento2")]
        public string Complemento2 { get; set; }

        [XmlElement("end")]
        public string End { get; set; }

        [XmlElement("id")]
        public string Id { get; set; }

        [XmlElement("uf")]
        public string Uf { get; set; }
    }
}