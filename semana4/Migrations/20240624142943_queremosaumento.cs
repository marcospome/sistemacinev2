using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace semana4.Migrations
{
    /// <inheritdoc />
    public partial class queremosaumento : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a1cf82f1-c7af-4d7c-b027-bdb9ca55e95d", null, "User", "USER" },
                    { "dcf92d6c-a651-4a58-9adf-d17354f065f5", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1cf82f1-c7af-4d7c-b027-bdb9ca55e95d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dcf92d6c-a651-4a58-9adf-d17354f065f5");
        }
    }
}
