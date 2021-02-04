using CorreiosAPI.Models.Geometria;

namespace CorreiosAPI.Models.Embalagem {
    public class Caixa : IEmbalagem {
        public float Altura { get; set; }
        public float Largura { get; set; }
        public float Comprimento { get; set; }

        public Dimensoes Dimensoes() {
            return new Dimensoes {
                Altura      = Altura,
                Largura     = Largura,
                Comprimento = Comprimento,
                Diametro    = 0.0f
            };
        }

        public string CodigoCorreios()
            => "002";
    }
}