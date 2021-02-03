namespace CorreiosAPI.SIGEP.Data {
    public class EtiquetaCorreios {
        public string TipoPostal { get; set; }
        public string Faixa { get; set; }
        public string Pais { get; set; }

        public EtiquetaCorreios() {}

        public EtiquetaCorreios(string etiqueta) {
            TipoPostal = etiqueta.Substring(0, 2);
            Faixa      = etiqueta.Substring(2, etiqueta.Length - 4).Trim();
            Pais       = etiqueta.Substring(etiqueta.Length - 2);
        }

        public EtiquetaCorreios(string tipoPostal, string faixa, string pais) {
            TipoPostal = tipoPostal;
            Faixa      = faixa;
            Pais       = pais;
        }

        public EtiquetaCorreios(string tipoPostal, long faixa, string pais) {
            TipoPostal = tipoPostal;
            Faixa      = faixa.ToString();
            Pais       = pais;
        }

        public int DigitoVerificador() {
            var multiplicadores = new int[] {8, 6, 4, 2, 3, 5, 9, 7};
            var faixa           = Faixa;
            var somatorio       = 0;

            while (faixa.Length < 8)
                faixa = "0" + faixa;

            for (int i = 0; i < 8; i++)
                somatorio += (faixa[i] - '0') * multiplicadores[i];

            var resto = somatorio % 11;

            if (resto == 0)
                return 5;

            if (resto == 1)
                return 0;

            return 11 - resto;
        }

        public string StrComDv()
            => TipoPostal + Faixa + DigitoVerificador() + Pais;

        public string StrSemDv()
            => TipoPostal + Faixa + Pais;

        public override string ToString()
            => StrComDv();
    }
}