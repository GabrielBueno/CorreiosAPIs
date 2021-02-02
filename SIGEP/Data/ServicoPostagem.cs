using System.Collections.Generic;

namespace CorreiosAPI.SIGEP.Data {
    public class ServicoPostagem {
        public string Nome { get; set; }
        public string Codigo { get; set; }
        public List<TipoServicoAdicional> ServicosAdicionaisObrigatorios { get; set; }

        public static ServicoPostagem SEDEX() {
            return new ServicoPostagem {
                Nome                           = "SEDEX CONTRATO AG",
                Codigo                         = "03220",
                ServicosAdicionaisObrigatorios = new List<TipoServicoAdicional> { TipoServicoAdicional.RegistroNacional() }
            };
        }

        public static ServicoPostagem PAC() {
            return new ServicoPostagem {
                Codigo                         = "03298",
                Nome                           = "PAC CONTRATO AG",
                ServicosAdicionaisObrigatorios = new List<TipoServicoAdicional> { TipoServicoAdicional.RegistroNacional() }
            };
        }
    }
}