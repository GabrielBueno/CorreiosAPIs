using CorreiosAPI.Enums;

namespace CorreiosAPI.Models {
    public class Envio {
        public ContratoCorreios Contrato { get; set; }
        public Pessoa Remetente { get; set; }
        public ObjetoPostal ObjetoPostal { get; set; }
        public FormaPagamento FormaPagamento { get; set; }
        public bool RemetenteCienteConteudoProibido { get; set; }
    }
}