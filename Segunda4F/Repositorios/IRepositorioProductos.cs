using Segunda4F.Data;

namespace Segunda4F.Repositorios {
    public interface IRepositorioProductos {
        Task<List<Producto>> ObtenerProductos();
        Task<Producto?> ObtenerProductoPorId(int id);
    }
}