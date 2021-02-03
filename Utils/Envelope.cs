namespace CorreiosAPI.Utils {
    public class Envelope : IEmbalagem {
        public Dimensoes Dimensoes() {
            return new Dimensoes {
                Altura      = 0,
                Largura     = 0,
                Comprimento = 0,
                Diametro    = 0
            };
        }

        public string CodigoCorreios()
            => "001";
    }
}