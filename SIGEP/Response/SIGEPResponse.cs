using System.Linq;
using System.Net;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using CorreiosAPI.SIGEP.Exception;

namespace CorreiosAPI.SIGEP.Response {
    public class SIGEPResponse {
        public HttpStatusCode StatusCode { get; set; }
        public bool Sucesso { get; set; }
        public string Xml { get; set; }

        public SIGEPResponse() {}

        public SIGEPResponse(bool sucesso, HttpStatusCode statusCode, byte[] xml) {
            var enc = System.Text.Encoding.GetEncoding("ISO-8859-1");

            Sucesso    = sucesso;
            StatusCode = statusCode;
            Xml        = enc.GetString(xml);
        }

        public SIGEPResponse(bool sucesso, HttpStatusCode statusCode, string xml) {
            Sucesso    = sucesso;
            StatusCode = statusCode;
            Xml        = xml;
        }

        public T Deserialize<T>() {
            using (var mem = new System.IO.MemoryStream()) {
                var retorno = ObterRetorno(Xml);

                retorno.Save(mem);
                mem.Position = 0;
                
                try {
                    var s = new XmlSerializer(typeof(T));
                    
                    return (T)s.Deserialize(mem);
                } catch (System.Exception e) {
                    throw new SIGEPDeserializeException("Erro ao desserializar XML", e);
                }
            }
        }

        public SIGEPCodeResponse CodigoRetornado() {
            var retorno = ObterRetorno(Xml);
            var raw     = retorno?.Value.Split("#");

            var codigo    = raw?.FirstOrDefault() ?? "";
            var descricao = raw?.Skip(1).Aggregate("", (acc, str) => acc + str) ?? "";

            return new SIGEPCodeResponse(codigo, descricao);
        }

        public SIGEPRangeResponse RangeRetornado() {
            var retorno = ObterRetorno(Xml);
            var raw     = retorno?.Value.Split(",");

            var inicio = raw?.FirstOrDefault() ?? "";
            var fim    = raw?.Skip(1).Aggregate("", (acc, str) => acc + str) ?? "";

            return new SIGEPRangeResponse(inicio, fim);
        }

        private XElement ObterRetorno(string xml) {
            var doc = XDocument.Parse(Xml);

            if (!Sucesso)
                throw new SIGEPFaultException(TentarLerFaultString(doc));

            var retorno = doc.Descendants("return").FirstOrDefault();

            if (retorno == null)
                throw new SIGEPRetornoVazioException("Resposta XML não possui valor de retorno (tag return)");

            return retorno;
        }

        private string TentarLerFaultString(XDocument doc) {
            var node = doc.Descendants("faultstring").FirstOrDefault();

            return node?.Value;
        }
    }
}