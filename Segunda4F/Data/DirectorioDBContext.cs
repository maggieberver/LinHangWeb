using Microsoft.EntityFrameworkCore;

namespace Segunda4F.Data {
    public class DirectorioDBContext : DbContext {
        public DirectorioDBContext(DbContextOptions<DirectorioDBContext> options) : base(options) {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetallePedido> DetallePedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.Cliente)
                .WithMany(c => c.Pedidos)
                .HasForeignKey(p => p.IdCliente);

            modelBuilder.Entity<DetallePedido>()
                .HasOne(d => d.Pedido)
                .WithMany(p => p.Detalles)
                .HasForeignKey(d => d.IdPedido);

            modelBuilder.Entity<DetallePedido>()
                .HasOne(d => d.Producto)
                .WithMany(p => p.Detalles)
                .HasForeignKey(d => d.IdProducto);

            modelBuilder.Entity<Producto>().HasData(
                new Producto { IdProducto = 1, Nombre = "Ramen tonkotsu", Descripcion = "Caldo cremoso con fideos, cerdo, huevo y cebollín.", Precio = 180, Categoria = "Ramen", Disponible = true },
                new Producto { IdProducto = 2, Nombre = "Sushi roll California", Descripcion = "Rollo con cangrejo, aguacate, pepino y ajonjolí.", Precio = 140, Categoria = "Sushi", Disponible = true },
                new Producto { IdProducto = 3, Nombre = "Gyozas de cerdo", Descripcion = "Empanadillas japonesas doradas con salsa de soya.", Precio = 95, Categoria = "Entradas", Disponible = true },
                new Producto { IdProducto = 4, Nombre = "Pad Thai de camarón", Descripcion = "Fideos salteados con camarón, cacahuate y salsa thai.", Precio = 175, Categoria = "Wok", Disponible = true },
                new Producto { IdProducto = 5, Nombre = "Arroz frito especial", Descripcion = "Arroz salteado con verduras, huevo y pollo.", Precio = 130, Categoria = "Arroz", Disponible = true },
                new Producto { IdProducto = 6, Nombre = "Té verde frío", Descripcion = "Bebida refrescante de té verde japonés.", Precio = 45, Categoria = "Bebidas", Disponible = true }
            );
        }
    }
}