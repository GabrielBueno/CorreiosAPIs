namespace CorreiosAPI.SIGEP.Data {
    public class IntervaloEtiquetas {
        public EtiquetaCorreios Inicio { get; set; }
        public EtiquetaCorreios Fim { get; set; }

        public IntervaloEtiquetas(EtiquetaCorreios inicio, EtiquetaCorreios fim) {
            Inicio = inicio;
            Fim    = fim;
        }

        public bool PossuiProximo() 
            => Faixa(Inicio) < Faixa(Fim);

        public IntervaloEtiquetas Proximo(int n = 1) {
            if (!PossuiProximo())
                return new IntervaloEtiquetas(Inicio, Fim);

            return new IntervaloEtiquetas(new EtiquetaCorreios(Inicio.TipoPostal, Faixa(Inicio) + n, Inicio.Pais), Fim);
        }

        public long Faixa(EtiquetaCorreios etiqueta)
            => long.Parse(etiqueta.Faixa);
    }
}