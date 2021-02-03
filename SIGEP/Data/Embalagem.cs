using CorreiosAPI.SIGEP.Enum;
using CorreiosAPI.SIGEP.Interfaces;

namespace CorreiosAPI.SIGEP.Data {
    public class Envelope : IEmbalagem {
        public DimensoesCm Dimensoes() {
            return new DimensoesCm {
                Altura      = 0,
                Largura     = 0,
                Comprimento = 0,
                Diametro    = 0
            };
        }

        public TipoEmbalagem Tipo()
            => TipoEmbalagem.Envelope;

        public string Codigo()
            => "001";
    }

    public class Caixa : IEmbalagem {
        public float Altura { get; set; }
        public float Largura { get; set; }
        public float Comprimento { get; set; }

        public DimensoesCm Dimensoes() {
            return new DimensoesCm {
                Altura      = Altura,
                Largura     = Largura,
                Comprimento = Comprimento,
                Diametro    = 0
            };
        }

        public TipoEmbalagem Tipo()
            => TipoEmbalagem.PacoteOuCaixa;

        public string Codigo()
            => "002";
    }

    public class Cilindro : IEmbalagem {
        public float Comprimento { get; set; }
        public float Diametro { get; set; }

        public DimensoesCm Dimensoes() {
            return new DimensoesCm {
                Altura      = 0,
                Largura     = 0,
                Comprimento = Comprimento,
                Diametro    = Diametro
            };
        }

        public TipoEmbalagem Tipo()
            => TipoEmbalagem.RoloOuCilindroOuEsferico;

        public string Codigo()
            => "003";
    }
}