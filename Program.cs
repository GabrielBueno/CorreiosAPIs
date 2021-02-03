using System;
using System.Threading.Tasks;
using CorreiosAPI.SIGEP.Data;
using CorreiosAPI.SIGEP.Exception;

namespace CorreiosAPI
{
    class Program
    {
        static void TestarSigep() {
            var sigep = new CorreiosAPI.SIGEP.CorreiosSIGEP {
                Contrato             = "9992157880",
                Cartao               = "0067599079",
                Cnpj                 = "34028316000103",
                CodigoAdministrativo = "17000190",
                Usuario              = "sigep",
                Senha                = "n5f9t8"
            };

            // try {
            //     var etiquetas = sigep.SolicitaEtiquetas(idServico: "124849", qtdeEtiquetas: 3);

            //     while (etiquetas.PossuiProximo()) {
            //         Console.WriteLine(etiquetas.Inicio);
            //         etiquetas = etiquetas.Proximo();
            //     }

            //     Console.WriteLine(etiquetas.Fim);
            // } catch (SIGEPFaultException ex) {
            //     Console.WriteLine(ex.Message);
            // } catch (SIGEPDeserializeException ex) {
            //     Console.WriteLine(ex.Message);
            // }

            try {
                var cep = sigep.ConsultaCep("04858551");
                Console.WriteLine("Esse CEP existe");

            } catch (SIGEPFaultException ex) {
                Console.WriteLine("Deu ruim");
                Console.WriteLine(ex.Message);

            } catch (SIGEPDeserializeException ex) {
                Console.WriteLine("Erro de conversão do XML");
                Console.WriteLine(ex.Message);
            }

            // try {
            //     Console.WriteLine("Consultando CEP...");
            //     var cep = sigep.ConsultaCep("04858553");

            //     Console.WriteLine("Id: "              + cep.Id);
            //     Console.WriteLine("Bairro: "          + cep.Bairro);
            //     Console.WriteLine("Cep: "             + cep.Cep);
            //     Console.WriteLine("Cidade: "          + cep.Cidade);
            //     Console.WriteLine("Complemento: "     + cep.Complemento);
            //     Console.WriteLine("Complemento (2): " + cep.Complemento2);
            //     Console.WriteLine("Endereço: "        + cep.End);
            //     Console.WriteLine("UF: "              + cep.Uf);

            //     Console.WriteLine("\nVerificando situação do cartão de postagem...");

            //     var statusCartao = sigep.GetStatusCartaoPostagem();
            //     Console.WriteLine(statusCartao);

            //     Console.WriteLine("\nSolicitando etiquetas...");

            //     var etiquetas = sigep.SolicitaEtiquetas(idServico: "124849", qtdeEtiquetas: 3);

            //     while (etiquetas.PossuiProximo()) {
            //         Console.WriteLine(etiquetas.Inicio);
            //         etiquetas = etiquetas.Proximo();
            //     }

            //     Console.WriteLine(etiquetas.Fim);

            // } catch (SIGEPFaultException e) {
            //     Console.WriteLine(e.Message);
            // } catch (SIGEPDeserializeException e) {
            //     Console.WriteLine("Erro ao deserializar objeto: " + e.Message);

            //     if (e.InnerException != null)
            //         Console.WriteLine(e.InnerException.Message);
            // }

        }

        static void TestarSRO() {
            var sro = new CorreiosAPI.SRO.CorreiosSRO("0506232600", "ERV1>T8W5B");

            var lista = sro.BuscaEventosLista("ON440549803BR");

            Console.WriteLine("");
        }

        static void Main(string[] args) {
            TestarSRO();
        }
    }
}
