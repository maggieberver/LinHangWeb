using Microsoft.EntityFrameworkCore;
using Segunda4F.Data;

namespace Segunda4F.Repositorios {
    public class RepositorioProductos : IRepositorioProductos {
        readonly DirectorioDBContext _context;

        public RepositorioProductos(DirectorioDBContext context) {
            _context = context;
        }

        public async Task<List<Producto>> ObtenerProductos() {
            return await _context.Productos.ToListAsync();
        }

        public async Task<Producto?> ObtenerProductoPorId(int id) {
            return await _context.Productos.FindAsync(id);
        }
    }
}