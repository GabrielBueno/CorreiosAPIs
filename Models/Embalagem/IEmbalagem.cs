using CorreiosAPI.Models.Geometria;

namespace CorreiosAPI.Models.Embalagem {
    public interface IEmbalagem {
        Dimensoes Dimensoes();
        string CodigoCorreios();
    }
}