using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddStaticId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33609e33-8cf4-4058-9f07-a29c33acd7dd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74416ff6-9c28-494d-939b-266bd377f2e3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "746130c4-73f4-4796-ad6a-9a0bd44c959b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", null, "Doctor", "DOCTOR" },
                    { "675b578c-8739-4b1b-a706-816fb14910bd", null, "Admin", "ADMIN" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", null, "Patient", "PATIENT" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "675b578c-8739-4b1b-a706-816fb14910bd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72235979-4cb2-4bb1-9de9-9e931f98610e");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33609e33-8cf4-4058-9f07-a29c33acd7dd", null, "Doctor", "DOCTOR" },
                    { "74416ff6-9c28-494d-939b-266bd377f2e3", null, "Admin", "ADMIN" },
                    { "746130c4-73f4-4796-ad6a-9a0bd44c959b", null, "Patient", "PATIENT" }
                });
        }
    }
}
