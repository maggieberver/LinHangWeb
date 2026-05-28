using Microsoft.EntityFrameworkCore;
using Segunda4F.Data;

namespace Segunda4F.Repositorios {
    public class RepositorioPedidos : IRepositorioPedidos {
        readonly DirectorioDBContext _context;

        public RepositorioPedidos(DirectorioDBContext context) {
            _context = context;
        }

        public async Task AgregarPedido(Pedido pedido) {
            await _context.Pedidos.AddAsync(pedido);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Pedido>> ObtenerPedidos() {
            return await _context.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Detalles)
                .ThenInclude(d => d.Producto)
                .ToListAsync();
        }
    }
}