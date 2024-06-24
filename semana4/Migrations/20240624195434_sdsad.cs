using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace semana4.Migrations
{
    /// <inheritdoc />
    public partial class sdsad : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b1e5dd9f-fbbc-4608-b936-9c621e784f4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2afb879-dac5-40b9-9b91-0d8b817fadb5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2bb41f5b-ebcc-4d6e-8ad5-0b4fad476408", null, "User", "USER" },
                    { "c165b38f-df7e-4143-9bbb-4d5dd9b5a368", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                    { "b1e5dd9f-fbbc-4608-b936-9c621e784f4a", null, "Admin", "ADMIN" },
                    { "e2afb879-dac5-40b9-9b91-0d8b817fadb5", null, "User", "USER" }
                });
        }
    }
}
