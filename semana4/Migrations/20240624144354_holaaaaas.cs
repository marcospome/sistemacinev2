using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace semana4.Migrations
{
    /// <inheritdoc />
    public partial class holaaaaas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: "a6c716f7-6d58-42a0-b8b1-5956ddaec3ee");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2dfe93d-6794-4b1b-8b95-b2fb3d9af872");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "a6c716f7-6d58-42a0-b8b1-5956ddaec3ee", null, "Admin", "ADMIN" },
                    { "b2dfe93d-6794-4b1b-8b95-b2fb3d9af872", null, "User", "USER" }
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
    }
}
