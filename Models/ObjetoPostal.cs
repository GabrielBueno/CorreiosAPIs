using CorreiosAPI.Enums;
using CorreiosAPI.Models.Embalagem;

namespace CorreiosAPI.Models {
    public class ObjetoPostal {
        public Etiqueta Etiqueta { get; set; }
        public Pessoa Destinatario { get; set; }
        public NotaFiscal NotaFiscal { get; set; }
        public ServicoPostagem ServicoPostagem { get; set; }
        public ServicosAdicionais ServicosAdicionais { get; set; }
        public IEmbalagem Embalagem { get; set; }
        public double PesoEmGramas { get; set; }
    }
}