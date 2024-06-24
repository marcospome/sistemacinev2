using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace semana4.Migrations
{
    /// <inheritdoc />
    public partial class hola : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "107ce885-e441-40a6-9f7c-df139e7db7e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b205abb7-535f-4c94-bb17-2404fe23d144");

            migrationBuilder.AddColumn<int>(
                name: "PeliculaId1",
                table: "Funcion",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9291c98f-d958-4e5e-8a76-e3ab2c1c742d", null, "Admin", "ADMIN" },
                    { "c137e0bd-3c68-409b-913c-bf70465bd502", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcion_PeliculaId1",
                table: "Funcion",
                column: "PeliculaId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcion_Peliculas_PeliculaId1",
                table: "Funcion",
                column: "PeliculaId1",
                principalTable: "Peliculas",
                principalColumn: "PeliculaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcion_Peliculas_PeliculaId1",
                table: "Funcion");

            migrationBuilder.DropIndex(
                name: "IX_Funcion_PeliculaId1",
                table: "Funcion");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9291c98f-d958-4e5e-8a76-e3ab2c1c742d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c137e0bd-3c68-409b-913c-bf70465bd502");

            migrationBuilder.DropColumn(
                name: "PeliculaId1",
                table: "Funcion");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "107ce885-e441-40a6-9f7c-df139e7db7e8", null, "User", "USER" },
                    { "b205abb7-535f-4c94-bb17-2404fe23d144", null, "Admin", "ADMIN" }
                });
        }
    }
}
