using System.Collections.Generic;

namespace CorreiosAPI.Models {
    public class IntervaloEtiquetas {
        public Etiqueta Inicio { get; set; }
        public Etiqueta Fim { get; set; }

        public IntervaloEtiquetas(Etiqueta inicio, Etiqueta fim) {
            Inicio = inicio;
            Fim    = fim;
        }

        public bool PossuiProximo() 
            => Faixa(Inicio) < Faixa(Fim);

        public IntervaloEtiquetas Proximo(int n = 1) {
            if (!PossuiProximo())
                return new IntervaloEtiquetas(Inicio, Fim);

            return new IntervaloEtiquetas(new Etiqueta(Inicio.TipoPostal, Faixa(Inicio) + n, Inicio.Pais), Fim);
        }

        /// <summary>
        /// Retorna uma lista com todas as etiquetas contidas neste intervalo
        /// </summary>
        /// <returns></returns>
        public List<Etiqueta> ToList() {
            var intervalo = new IntervaloEtiquetas(Inicio, Fim);
            var lista     = new List<Etiqueta>() { Inicio };
            
            while (intervalo.PossuiProximo()) {
                intervalo = intervalo.Proximo();
                lista.Add(intervalo.Inicio);
            }

            return lista;
        }

        private long Faixa(Etiqueta etiqueta)
            => long.Parse(etiqueta.Faixa);
    }
}