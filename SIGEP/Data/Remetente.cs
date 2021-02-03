using CorreiosAPI.SIGEP.Interfaces;

namespace CorreiosAPI.SIGEP.Data {
    public class Remetente {
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public string NumeroContrato { get; set; }
        public string NumeroDiretoria { get; set; }
        public string CodigoAdministrativo { get; set; }
        public bool CienciaConteudoProibido { get; set; }
        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }
    }
}