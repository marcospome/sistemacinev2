using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace semana4.Migrations
{
    /// <inheritdoc />
    public partial class asdsd : Migration
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
                keyValue: "9291c98f-d958-4e5e-8a76-e3ab2c1c742d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c137e0bd-3c68-409b-913c-bf70465bd502");

            migrationBuilder.DropColumn(
                name: "PeliculaId1",
                table: "Funcion");

            migrationBuilder.AlterColumn<string>(
                name: "Sala",
                table: "Funcion",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Idioma",
                table: "Funcion",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Sala",
                table: "Funcion",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Idioma",
                table: "Funcion",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
    }
}
