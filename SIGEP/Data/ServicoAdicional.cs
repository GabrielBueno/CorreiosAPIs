using System.Collections.Generic;

namespace CorreiosAPI.SIGEP.Data {
    public class ServicoAdicional {
        public double ValorDeclarado { get; set; }
        public Endereco EnderecoVizinho { get; set; }
        public List<TipoServicoAdicional> TiposServicos { get; set; }
    }
}