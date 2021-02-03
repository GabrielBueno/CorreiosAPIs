namespace CorreiosAPI.Models {
    public class Credenciais {
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public Credenciais() {}

        public Credenciais(string usuario, string senha) {
            Usuario = usuario;
            Senha   = senha;
        }
    }
}