using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace semana4.Migrations
{
    /// <inheritdoc />
    public partial class oshitdsfdfsff : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "83a341f2-3c8d-4c1a-8366-36e0fd96732e", null, "Admin", "ADMIN" },
                    { "fc63ac26-99a5-4908-90b5-a0e6e200d50d", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83a341f2-3c8d-4c1a-8366-36e0fd96732e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc63ac26-99a5-4908-90b5-a0e6e200d50d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bb08c574-0eaf-4a9c-9c4f-3df66c71c1dc", null, "User", "USER" },
                    { "d41181dc-77af-4204-8409-5947e44073c1", null, "Admin", "ADMIN" }
                });
        }
    }
}
