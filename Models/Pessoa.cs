namespace CorreiosAPI.Models {
    public class Pessoa {
        public string Nome { get; set; }
        public string CpfCnpj { get; set; }
        public Contato Contato { get; set; }
        public Endereco Endereco { get; set; }
    }
}