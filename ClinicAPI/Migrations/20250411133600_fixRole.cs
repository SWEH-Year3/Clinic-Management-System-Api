using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class fixRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "049f5991-e393-409d-8689-38aaa4fcba54");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1d2cd565-3f68-448e-90e7-ef2d8cdbc86f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4cfb0f00-26c1-46f1-9b13-232dedc22d2f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9b015a4a-90da-4f55-9024-ad362c639bb3", null, "User", "USER" },
                    { "ae4214fd-e933-41d1-a9de-6eb00af20d11", null, "Admin", "ADMIN" },
                    { "fec639c0-9f09-4e99-88f2-d52a7efaf522", null, "Doctor", "DOCTOR" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b015a4a-90da-4f55-9024-ad362c639bb3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae4214fd-e933-41d1-a9de-6eb00af20d11");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fec639c0-9f09-4e99-88f2-d52a7efaf522");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "049f5991-e393-409d-8689-38aaa4fcba54", null, "User", "USER" },
                    { "1d2cd565-3f68-448e-90e7-ef2d8cdbc86f", null, "Admin", "ADMIN" },
                    { "4cfb0f00-26c1-46f1-9b13-232dedc22d2f", null, "Doctor", "DOCTOR" }
                });
        }
    }
}
