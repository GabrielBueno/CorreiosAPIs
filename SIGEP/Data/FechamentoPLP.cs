using System.Collections.Generic;
using CorreiosAPI.SIGEP.Enum;
using CorreiosAPI.SIGEP.Interfaces;

namespace CorreiosAPI.SIGEP.Data {
    public class FechamentoPLP {
        public PreListaPostagem PreListaPostagem { get; set; }
        public Remetente Remetente { get; set; }
        public FormaPagamentoCorreios FormaPagamento { get; set; }
        public List<ObjetoPostal> ObjetosPostais { get; set; }
    }
}