using CorreiosAPI.Data.Geometria;

namespace CorreiosAPI.Data.Embalagem {
    public interface IEmbalagem {
        Dimensoes Dimensoes();
        string CodigoCorreios();
    }
}