using System;
using System.Collections.Generic;
using CorreiosAPI.SIGEP.Interfaces;

namespace CorreiosAPI.SIGEP.Data {
    public class ObjetoPostal {
        public string CodigoObjetoCliente { get; set; }
        public double CubagemCm3 { get; set; }
        public double PesoGramas { get; set; }
        public string ObservacoesCliente { get; set; }
        public string ReservadoSIGEPWeb { get; set; }
        public bool CienciaConteudoProibido { get; set; }
        public string StatusProcessamento { get; set; }
        public int? NumeroComprovantePostagem { get; set; }
        public double? ValorCobrado { get; set; }
        public DateTime? DataPostagem { get; set; }
        public Destinatario Destinatario { get; set; }
        public ServicoPostagem ServicoPostagem { get; set; }
        public EtiquetaCorreios Etiqueta { get; set; }
        public IEmbalagem Embalagem { get; set; } 
        public Nacional Nacional { get; set; }
        public ServicoAdicional ServicosAdicionais { get; set; }
    }
}