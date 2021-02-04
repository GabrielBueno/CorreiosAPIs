using CorreiosAPI.Models.Geometria;

namespace CorreiosAPI.Models.Embalagem {
    public class Envelope : IEmbalagem {
        public Dimensoes Dimensoes() {
            return new Dimensoes {
                Altura      = 0.0f,
                Largura     = 0.0f,
                Comprimento = 0.0f,
                Diametro    = 0.0f
            };
        }

        public string CodigoCorreios()
            => "001";
    }
}