using System.Collections.Generic;
using CorreiosAPI.SIGEP.Enum;

namespace CorreiosAPI.SIGEP.Data {
    public class FechamentoPLP {
        public PreListaPostagem PreListaPostagem { get; set; }
        public Remetente Remetente { get; set; }
        public FormaPagamentoCorreios FormaPagamento { get; set; }
        public List<ObjetoPostal> ObjetosPostais { get; set; }
        
    }
}