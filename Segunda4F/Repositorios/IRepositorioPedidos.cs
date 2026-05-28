using Segunda4F.Data;

namespace Segunda4F.Repositorios {
    public interface IRepositorioPedidos {
        Task AgregarPedido(Pedido pedido);
        Task<List<Pedido>> ObtenerPedidos();
    }
}