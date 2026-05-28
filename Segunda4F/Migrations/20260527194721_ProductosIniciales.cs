using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Segunda4F.Migrations
{
    /// <inheritdoc />
    public partial class ProductosIniciales : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "IdProducto", "Categoria", "Descripcion", "Disponible", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, "Ramen", "Caldo cremoso con fideos, cerdo, huevo y cebollín.", true, "Ramen tonkotsu", 180m },
                    { 2, "Sushi", "Rollo con cangrejo, aguacate, pepino y ajonjolí.", true, "Sushi roll California", 140m },
                    { 3, "Entradas", "Empanadillas japonesas doradas con salsa de soya.", true, "Gyozas de cerdo", 95m },
                    { 4, "Wok", "Fideos salteados con camarón, cacahuate y salsa thai.", true, "Pad Thai de camarón", 175m },
                    { 5, "Arroz", "Arroz salteado con verduras, huevo y pollo.", true, "Arroz frito especial", 130m },
                    { 6, "Bebidas", "Bebida refrescante de té verde japonés.", true, "Té verde frío", 45m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "IdProducto",
                keyValue: 6);
        }
    }
}
