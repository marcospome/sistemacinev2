using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace semana4.Migrations
{
    /// <inheritdoc />
    public partial class sdsadssf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Funcion_Peliculas_PeliculaId",
                table: "Funcion");

            migrationBuilder.DropIndex(
                name: "IX_Funcion_PeliculaId",
                table: "Funcion");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bb41f5b-ebcc-4d6e-8ad5-0b4fad476408");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c165b38f-df7e-4143-9bbb-4d5dd9b5a368");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "38bffaa1-c120-40ff-88a9-b4977e22830d", null, "Admin", "ADMIN" },
                    { "8de2e1d6-8347-417d-bd44-c90a777f2b84", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "38bffaa1-c120-40ff-88a9-b4977e22830d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8de2e1d6-8347-417d-bd44-c90a777f2b84");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2bb41f5b-ebcc-4d6e-8ad5-0b4fad476408", null, "User", "USER" },
                    { "c165b38f-df7e-4143-9bbb-4d5dd9b5a368", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcion_PeliculaId",
                table: "Funcion",
                column: "PeliculaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Funcion_Peliculas_PeliculaId",
                table: "Funcion",
                column: "PeliculaId",
                principalTable: "Peliculas",
                principalColumn: "PeliculaId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
