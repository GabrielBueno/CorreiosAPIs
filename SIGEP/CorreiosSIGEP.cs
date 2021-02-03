using System;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using CorreiosAPI.SIGEP.Data;
using CorreiosAPI.SIGEP.Exception;
using CorreiosAPI.SIGEP.Interfaces;
using CorreiosAPI.SIGEP.Request;
using CorreiosAPI.SIGEP.Response;
using RestSharp;
using RestSharp.Serialization.Xml;

namespace CorreiosAPI.SIGEP {
    public class CorreiosSIGEP {
        /* Constantes */
        public readonly static string PRODENV = "https://apps.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente";
        public readonly static string TESTENV = "https://apphom.correios.com.br/SigepMasterJPA/AtendeClienteService/AtendeCliente";

        /* Configuração */
        private readonly string _apiUrl = CorreiosSIGEP.TESTENV;

        public string Usuario { get; set; }
        public string Senha { get; set; }
        public string CodigoAdministrativo { get; set; }
        public string Contrato { get; set; }
        public string Cartao { get; set; }
        public string Cnpj { get; set; }

        public CorreiosSIGEP() {}

        public CorreiosSIGEP(string usuario, string senha) {
            Usuario = usuario;
            Senha   = senha;
        }

        public string GetStatusCartaoPostagem() {
            var response = DoRequest(new GetStatusCartaoPostagemRequest(Cartao));

            return response.CodigoRetornado().Codigo;
        }

        public BuscaClienteResponse BuscaCliente() {
            var response = DoRequest(new BuscaClienteRequest {
                IdCartaoPostagem = Cartao,
                IdContrato       = Contrato
            });

            return response.Deserialize<BuscaClienteResponse>();
        }

        public VerificacaoCep ConsultaCep(string cep) {
            try {
                var response    = DoRequest(new ConsultaCepRequest(cep));
                var cepResponse = response.Deserialize<ConsultaCepResponse>();

                return new VerificacaoCep {
                    Existe = true,
                    Endereco = new Endereco {
                        Bairro        = cepResponse.Bairro,
                        Cep           = cepResponse.Cep,
                        Cidade        = cepResponse.Cidade,
                        Logradouro    = cepResponse.End,
                        Complemento   = cepResponse.Complemento,
                        Complemento2  = cepResponse.Complemento2,
                        Uf            = cepResponse.Uf
                    }
                };
            } catch (System.Exception ex) when (ex is SIGEPFaultException || ex is SIGEPRetornoVazioException) {
                return new VerificacaoCep { Existe = false, Endereco = null };
            } catch (System.Exception ex) {
                return new VerificacaoCep { ErroInesperado = ex };
            }
        }

        public IntervaloEtiquetas SolicitaEtiquetas(string idServico, int qtdeEtiquetas) {
            var request = new SolicitaEtiquetasRequest {
                TipoDestinatario = "C", // Cliente
                Cnpj             = Cnpj,
                IdServico        = idServico,
                QtdeEtiquetas    = qtdeEtiquetas
            };

            var response = DoRequest(request);
            var range    = response.RangeRetornado();

            return new IntervaloEtiquetas(new EtiquetaCorreios(range.Inicio), new EtiquetaCorreios(range.Fim));
        }

        private SIGEPResponse DoRequest(ISIGEPRequest body) {
            var (client, request) = Request(body);
            var response          = client.Post(request);

            return new SIGEPResponse(response.IsSuccessful, response.StatusCode, response.RawBytes);
        }

        private (RestClient, RestRequest) Request(ISIGEPRequest body) {
            var client  = new RestClient(_apiUrl);
            var request = new RestRequest();
            var mime    = "text/xml";

            request.AddHeader("Content-Type", mime);
            request.AddHeader("Accept",       mime);

            request.AddParameter(mime, Envelope(body).ToString(), mime, ParameterType.RequestBody);

            return (client, request);
        }

        private XElement Envelope(ISIGEPRequest request) {
            XNamespace xmlns   = XNamespace.Xmlns;
            XNamespace soapenv = "http://schemas.xmlsoap.org/soap/envelope/";
            XNamespace cli     = "http://cliente.bean.master.sigep.bsb.correios.com.br/";

            return new XElement(soapenv+"Envelope", 
                new XAttribute(xmlns+"soapenv", soapenv), 
                new XAttribute(xmlns+"cli", cli),

                new XElement(soapenv+"Header"),
                new XElement(soapenv+"Body",
                    request.XML(Usuario, Senha, cli)
                )
            );
        }
    }
}