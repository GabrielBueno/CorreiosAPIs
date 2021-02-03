using CorreiosAPI.SIGEP.Data;
using CorreiosAPI.SIGEP.Enum;

namespace CorreiosAPI.SIGEP.Interfaces {
    public interface IEmbalagem { 
        DimensoesCm Dimensoes(); 
        TipoEmbalagem Tipo();
        string Codigo();
    }
}