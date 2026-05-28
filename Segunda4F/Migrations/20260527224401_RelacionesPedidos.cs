using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Segunda4F.Migrations
{
    /// <inheritdoc />
    public partial class RelacionesPedidos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedidos_Pedidos_PedidoIdPedido",
                table: "DetallePedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedidos_Productos_ProductoIdProducto",
                table: "DetallePedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_ClienteIdCliente",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_ClienteIdCliente",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_DetallePedidos_PedidoIdPedido",
                table: "DetallePedidos");

            migrationBuilder.DropIndex(
                name: "IX_DetallePedidos_ProductoIdProducto",
                table: "DetallePedidos");

            migrationBuilder.DropColumn(
                name: "ClienteIdCliente",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "PedidoIdPedido",
                table: "DetallePedidos");

            migrationBuilder.DropColumn(
                name: "ProductoIdProducto",
                table: "DetallePedidos");

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_IdCliente",
                table: "Pedidos",
                column: "IdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedidos_IdPedido",
                table: "DetallePedidos",
                column: "IdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedidos_IdProducto",
                table: "DetallePedidos",
                column: "IdProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedidos_Pedidos_IdPedido",
                table: "DetallePedidos",
                column: "IdPedido",
                principalTable: "Pedidos",
                principalColumn: "IdPedido",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedidos_Productos_IdProducto",
                table: "DetallePedidos",
                column: "IdProducto",
                principalTable: "Productos",
                principalColumn: "IdProducto",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_IdCliente",
                table: "Pedidos",
                column: "IdCliente",
                principalTable: "Clientes",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedidos_Pedidos_IdPedido",
                table: "DetallePedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_DetallePedidos_Productos_IdProducto",
                table: "DetallePedidos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Clientes_IdCliente",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_IdCliente",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_DetallePedidos_IdPedido",
                table: "DetallePedidos");

            migrationBuilder.DropIndex(
                name: "IX_DetallePedidos_IdProducto",
                table: "DetallePedidos");

            migrationBuilder.AddColumn<int>(
                name: "ClienteIdCliente",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PedidoIdPedido",
                table: "DetallePedidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductoIdProducto",
                table: "DetallePedidos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_ClienteIdCliente",
                table: "Pedidos",
                column: "ClienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedidos_PedidoIdPedido",
                table: "DetallePedidos",
                column: "PedidoIdPedido");

            migrationBuilder.CreateIndex(
                name: "IX_DetallePedidos_ProductoIdProducto",
                table: "DetallePedidos",
                column: "ProductoIdProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedidos_Pedidos_PedidoIdPedido",
                table: "DetallePedidos",
                column: "PedidoIdPedido",
                principalTable: "Pedidos",
                principalColumn: "IdPedido");

            migrationBuilder.AddForeignKey(
                name: "FK_DetallePedidos_Productos_ProductoIdProducto",
                table: "DetallePedidos",
                column: "ProductoIdProducto",
                principalTable: "Productos",
                principalColumn: "IdProducto");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Clientes_ClienteIdCliente",
                table: "Pedidos",
                column: "ClienteIdCliente",
                principalTable: "Clientes",
                principalColumn: "IdCliente");
        }
    }
}
