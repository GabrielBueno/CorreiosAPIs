using System.Collections.Generic;
using CorreiosAPI.Enums;

namespace CorreiosAPI.Models {
    public class ServicosAdicionais {
        public IEnumerable<ServicoAdicional> Servicos { get; set; }
        public double ValorDeclarado { get; set; }
        public Endereco EnderecoVizinho { get; set; } 
    }
}