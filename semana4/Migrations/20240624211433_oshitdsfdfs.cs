using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace semana4.Migrations
{
    /// <inheritdoc />
    public partial class oshitdsfdfs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "24c29b7b-05c0-4a3b-abc8-01c6e0aee293");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fde02b8-bee2-4a06-8d2f-ed4082883c61");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bb08c574-0eaf-4a9c-9c4f-3df66c71c1dc", null, "User", "USER" },
                    { "d41181dc-77af-4204-8409-5947e44073c1", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb08c574-0eaf-4a9c-9c4f-3df66c71c1dc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d41181dc-77af-4204-8409-5947e44073c1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "24c29b7b-05c0-4a3b-abc8-01c6e0aee293", null, "Admin", "ADMIN" },
                    { "4fde02b8-bee2-4a06-8d2f-ed4082883c61", null, "User", "USER" }
                });
        }
    }
}
