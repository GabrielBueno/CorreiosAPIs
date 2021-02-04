using System;
using System.Threading.Tasks;
using CorreiosAPI.Models;
using CorreiosAPI.SIGEP.Data;
using CorreiosAPI.SIGEP.Exception;

namespace CorreiosAPI
{
    class Program
    {
        static void TestarSigep() {
            var contrato = new ContratoCorreios {
                Contrato             = "9992157880",
                CartaoPostal         = "0067599079",
                CodigoAdministrativo = "17000190",
                Cnpj                 = "34028316000103"
            };

            var credenciaisSigep = new Credenciais("sigep", "n5f9t8");

            var sigep = new CorreiosAPI.SIGEP.CorreiosSIGEP {
                Contrato             = "9992157880",
                Cartao               = "0067599079",
                Cnpj                 = "34028316000103",
                CodigoAdministrativo = "17000190",
                Usuario              = "sigep",
                Senha                = "n5f9t8"
            };
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
