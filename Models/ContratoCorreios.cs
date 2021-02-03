using CorreiosAPI.Enums;

namespace CorreiosAPI.Models {
    public class ContratoCorreios {
        public string Contrato { get; set; }
        public string CodigoAdministrativo { get; set; }
        public string CartaoPostal { get; set; }
        public string Cnpj { get; set; }
        public DiretoriaRegional DiretoriaRegional { get; set; }
    }
}