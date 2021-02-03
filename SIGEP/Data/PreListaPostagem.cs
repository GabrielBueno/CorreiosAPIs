using CorreiosAPI.SIGEP.Interfaces;

namespace CorreiosAPI.SIGEP.Data {
    public class PreListaPostagem {
        public long? Id { get; set; }
        public double? ValorGlobal { get; set; }
        public string McuUnidadePostagem { get; set; }
        public string NomeUnidadePostagem { get; set; }
        public string CartaoPostagem { get; set; }
    }
}