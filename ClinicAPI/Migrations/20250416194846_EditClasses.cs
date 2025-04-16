using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class EditClasses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "808965c0-5548-4afa-b2fc-1dc1c02bb261");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cd276094-a15b-435c-94c0-0ad9d8caba0f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d55ba242-ca94-425b-b9c0-8fdf1f204425");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "364f971c-8f16-44b2-a10a-f20403302f9e", null, "Doctor", "DOCTOR" },
                    { "6394d61e-d5ca-40ff-bee9-8963f5a2aaf1", null, "Patient", "PATIENT" },
                    { "c8ee4210-e6bc-4a16-8284-cef6a74bd60f", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "364f971c-8f16-44b2-a10a-f20403302f9e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6394d61e-d5ca-40ff-bee9-8963f5a2aaf1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8ee4210-e6bc-4a16-8284-cef6a74bd60f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "808965c0-5548-4afa-b2fc-1dc1c02bb261", null, "Doctor", "DOCTOR" },
                    { "cd276094-a15b-435c-94c0-0ad9d8caba0f", null, "Admin", "ADMIN" },
                    { "d55ba242-ca94-425b-b9c0-8fdf1f204425", null, "Patient", "PATIENT" }
                });
        }
    }
}
