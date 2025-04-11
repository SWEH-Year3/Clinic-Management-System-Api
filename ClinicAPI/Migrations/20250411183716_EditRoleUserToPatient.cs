using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class EditRoleUserToPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "02802b89-67c8-453a-b983-00a8a5aace4a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47a50f86-18e0-49ec-8e7d-61ff864cc9f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b37752e-ec82-45a0-ad05-53907df51b91");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1ab63bbb-8ef4-4a00-9b79-fd955b4f7089", null, "Patient", "PATIENT" },
                    { "475346f0-bdbc-44d5-b3f3-3266ec5fcf5e", null, "Doctor", "DOCTOR" },
                    { "77f5142c-b574-4580-93f5-63c9254265cd", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1ab63bbb-8ef4-4a00-9b79-fd955b4f7089");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "475346f0-bdbc-44d5-b3f3-3266ec5fcf5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "77f5142c-b574-4580-93f5-63c9254265cd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "02802b89-67c8-453a-b983-00a8a5aace4a", null, "User", "USER" },
                    { "47a50f86-18e0-49ec-8e7d-61ff864cc9f9", null, "Admin", "ADMIN" },
                    { "6b37752e-ec82-45a0-ad05-53907df51b91", null, "Doctor", "DOCTOR" }
                });
        }
    }
}
