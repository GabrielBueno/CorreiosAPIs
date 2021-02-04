using CorreiosAPI.Enums;
using CorreiosAPI.Data.Embalagem;

namespace CorreiosAPI.Models {
    public class ObjetoPostal {
        public double PesoEmGramas { get; set; }
        public double ValorACobrar { get; set; }
        public string CodigoUsuarioPostal { get; set; }
        public string CentroCustoCliente { get; set; }
        public string ObservacoesDoCliente { get; set; }
        public string Descricao { get; set; }
        public bool RemetenteCienteConteudoProibido { get; set; }
        public Etiqueta Etiqueta { get; set; }
        public Pessoa Destinatario { get; set; }
        public NotaFiscal NotaFiscal { get; set; }
        public ServicoPostagem ServicoPostagem { get; set; }
        public ServicosAdicionais ServicosAdicionais { get; set; }
        public IEmbalagem Embalagem { get; set; }
    }
}