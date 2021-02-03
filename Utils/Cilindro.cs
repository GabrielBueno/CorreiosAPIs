namespace CorreiosAPI.Utils {
    public class Cilindro : IEmbalagem {
        public float Comprimento { get; set; }
        public float Diametro { get; set; }

        public Dimensoes Dimensoes() {
            return new Dimensoes {
                Altura      = 0.0f,
                Largura     = 0.0f,
                Comprimento = Comprimento,
                Diametro    = Diametro
            };
        }

        public string CodigoCorreios()
            => "003";
    }
}