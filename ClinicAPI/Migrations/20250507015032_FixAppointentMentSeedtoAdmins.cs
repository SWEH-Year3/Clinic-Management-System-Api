using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixAppointentMentSeedtoAdmins : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "0b2a0b3f-335d-407a-9eb5-1f2df8757ac1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "0cc0fd04-1442-43ff-bbf4-da14d44809f7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "328d7971-00b1-4c1e-ae83-044da79f638c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "355d7bff-7157-406a-be14-1f4f41a2f0d0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "38df6d89-7ef7-411a-aa56-a79222b5035c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "39d18d23-ff3b-402c-93fc-3676c4b84cbd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "3ac0108b-1750-4f96-85a9-fde8ffdda749" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "3da26cb0-5215-44da-bef4-77bcc2b1a71d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "43bb0799-23e3-46f2-9130-d5c864d20fb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "4f5cc6c7-81d0-48b4-897d-b9bb803b7d01" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "54c7cea8-def6-4dac-8ed2-a9df662d978c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "5a3775ae-deee-4d3b-add8-902565287f36" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "5b822ee5-eb3c-4e24-a44f-c8b71d22cd57" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "5cde9f9c-e925-4ce1-b5e8-276997f44b57" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "628f2987-610f-43f0-abeb-b830479b03d4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "69b95277-1f9b-45e9-87cf-33fce9ef5a5c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "6b718587-f8b4-4e5b-86a6-2cdb71959411" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "74401562-e7c7-4448-890f-af9b01dee998" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "75d6a14b-0b4f-4abf-aca2-265fd6c0cfac" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "7aadde49-213c-4ea8-94b7-25d4acf487d2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "8253e185-3837-4996-a49c-786de1c55b35" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "836f43d7-bc60-4d28-8f57-3bc6859c5dea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "8751de00-9e1e-402f-80f3-993617e7574f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "875a481d-ea58-4d71-8dc5-12370b3fc219" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "935ec8d4-4db9-4b2c-aac5-25676806c655" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "9bac9a20-195c-4076-8b1f-1967fc049ea8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "a41359ca-0135-4a0b-881e-07de66eb303e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "a467059e-c9e4-41a1-b3f1-abf681f67ed4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "adcb1db0-0939-4f76-80e4-05fbd8b556f9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "afd8a3f8-9288-49b2-a617-48aa81941de7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "b027c1b3-df44-4b98-9fe4-cb29dc42fd0b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "b2461409-f153-422c-8f18-679564bd945b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "b2bda50f-4e68-4547-92ea-cc9587a118f6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675b578c-8739-4b1b-a706-816fb14910bd", "c4840c30-269e-4148-94ac-3915f8e7a9ff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675b578c-8739-4b1b-a706-816fb14910bd", "c603fd32-532a-4dd6-bc7f-55566a9926a8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675b578c-8739-4b1b-a706-816fb14910bd", "c6ba3d3e-bcc7-4f1b-adf8-378de26ee8d2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675b578c-8739-4b1b-a706-816fb14910bd", "c70bdbeb-1c3a-43c2-9f07-192ef1ac6909" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "cf5d2ca8-28bf-422c-a0ce-f00ea8cbf762" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675b578c-8739-4b1b-a706-816fb14910bd", "dfb83bad-4b8e-41ab-9098-6f09fa4c1b64" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "e2ed9871-1cbd-498c-bd76-88c6ff1f3735" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "e748cacd-4b12-4173-a66c-50e9cf94f303" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "ea0f3cfb-77b1-425e-be71-358c4bf1ba16" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "f2a5cf73-6cdc-47f4-9db2-a9bc6c5b483e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "f5ed5f51-9396-41ff-b972-c2c7cc799cb5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "f68f7e6e-197e-413d-bc72-db072ccf9ea6" });

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("03624d4a-06c0-43de-8ac9-d8addea6811e"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("053a788c-2624-4de4-89f2-ac0f694a3987"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("05952675-894c-41f9-9dcc-501ab5f960c1"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("06c5f2ef-4c5a-4a38-a74b-633ffb18d4d5"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("0791d742-3cd2-42fd-a6d5-1646c595b8b0"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("09caae15-e34d-450d-aaf9-a12ad5342851"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("0d565a43-41dc-42dc-9fe6-59d0de16de68"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("0d700a20-49d0-4cde-829d-5f07c4ec2600"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("0ddf9e57-e472-4bab-a20a-41b95d7c50ff"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("16c88362-1f58-4ec6-9c05-83386d39f947"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("1813f723-0515-4f50-bccd-2e6c7b6f15c4"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("1de91fcb-5cfc-4e5c-bc92-d421bbdbb471"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("1f77fc65-4844-46e7-9215-2738de997191"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("230ded85-8949-4aa8-91b9-a895293b0b91"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("294664e6-f2bd-4827-b469-0cf39614cbad"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("2fefe902-9e72-4ebb-9356-462e9d8dc6c9"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("33f228e7-22a9-4e85-8efa-9abada0c79ba"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("35a249ae-028d-4d6f-a4ad-d1e664b3cce1"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("368df7b1-3b9a-416a-9002-c9601caeaaff"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("396c3760-70a0-4626-ba3e-2f4b1420113c"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("3a2722dc-eb61-4eb0-88ec-9676a611e8da"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("41645a3b-bb08-4682-89a6-5f7d3ca3e7a8"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("458fd1d9-6065-4b87-95ce-bc048af51877"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("46b5966d-c1ea-4443-a126-17fd8d48d39f"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("47e01f92-f52e-47f0-b58f-85b6f014cc73"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("4c328a02-c03d-4386-944a-0d3b7499376c"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("4cc1b983-aebf-4d3b-ad68-ab11058a8e23"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("4ee1f110-27a5-4352-b0dd-bd624f62a75d"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("53ff5df0-2891-403e-8d6f-182dbac378bc"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("563c65d8-1d37-405c-a606-c1a42b20e6f3"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("5845b6e3-1859-4611-a11c-a0334e177a7c"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("597d0cae-db99-4dc8-8d66-dbaae14b31b0"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("598d761f-ac3f-4033-b8d8-a5398bc669f8"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("5bb81cf7-295a-43ce-9ce0-0255b35cff01"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("5e22b191-29aa-41b2-87a6-c81590bb52ce"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("6506a658-4623-41a3-bab3-874068cef384"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("667915b5-154e-49f3-a044-a3d83569d749"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("6799fa63-1031-48de-b3d8-a9d1e6568274"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("67e1623c-595d-4139-bd14-11ed7afcbd37"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("6a76dac2-f0b2-4038-bfb2-51d57c5e617b"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("6c939950-2f3f-43df-82f5-53c44c86cff7"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("71b6d47d-4164-4874-b76f-43f8255d1fa2"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("74304180-7e3f-4c5e-8476-e924054c0585"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("79a07422-bf85-459c-93ba-2f492bbb01af"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("7bb77394-410a-4e3c-9b8d-2212d04cd79d"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("8439cf2e-0e1f-45fb-988b-6d7717f1ceff"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("84a3dad0-3ecf-4461-a8ae-34ac1c8aa212"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("8b19ecff-1f2a-492c-acb5-dbf87a9d55bd"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("8f2eedbe-6a9f-4a1f-850f-13d951c38bf2"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("92c931f6-41ab-4aa2-a575-ef41076ab855"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("9620b308-a347-4c40-b668-a44893e855b9"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("a196025b-24d6-4f75-9981-3f375f827bfa"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("a2385649-3c5a-4212-acd6-941c7dc23e03"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("a5587f51-801c-40bf-b297-0a28a8720bff"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("a57836dc-10de-4ae5-89f6-d5fbb4d09246"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("a6d3aed0-e09a-4c06-a3f2-a12f23b498b3"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("ab5410fc-41f9-4638-8ae0-5473b240866e"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("b57034ad-9ee2-4f80-9f32-b8eb068fa828"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("b8bfcb0b-71d8-4f2a-b56f-0171db8e21d1"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("c478e35d-d8a4-4ffc-a656-50e29fac7371"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("c765d831-9c96-470b-b44d-a4b7d38d5a09"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("c78c4980-044d-4baf-b2dd-14edf0879b1c"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("c887967a-55f9-4560-97d2-2a917e8e8024"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("c9a8498f-7574-410a-bdf2-ec1863a30237"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("cf485009-2070-4073-adbb-1cc16eb12483"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("d4b5a845-78f2-4461-a743-b7c9c7a63f8b"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("d6495406-99b9-4263-b0af-d966ba79dd2e"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("d96ba38c-6587-421a-b34e-2121a7b7160d"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("dabdfc14-208d-4146-b38f-842da88fc1d9"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("dc2c4745-9077-45e1-a9ee-8a4959e9c450"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("e3f148ee-1c3d-40d4-9cc7-46380e3d4c58"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("ead8d5aa-f212-4d96-9265-3402d130faa0"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("ee6ffcd9-084f-435f-8d1f-c15f41812ae3"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("f15ca338-09a5-4b5c-8f90-be2138173f3e"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("f450dd44-e7ab-4313-8837-e0d99e406dee"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("f52dc1a5-a1d5-46aa-b0c0-c84c86cd8f98"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("f5a7c5e7-ab12-4fd7-8c9b-8ecf0d084f84"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("f77c0b92-cddb-4ecb-bcf4-bb668f50ec62"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("fcc31076-6776-40d4-b7e3-289201e17a0a"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("fef936ed-f496-4e98-99f7-21f252de40fd"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("065e9f27-6fd9-41e6-bb89-95704b901b46"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("07e5f1a2-faf7-4e04-a2e8-13ad76ab5523"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("082c45d8-5819-48e3-92cf-cc546669aea7"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("0a602e42-9903-48b0-9662-d97fc7aaa696"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("0a6bb835-1ae9-4693-8df0-d2354753df68"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("0c7a474f-8d10-41d6-a9e4-c69d2a2d4a59"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("117e6342-e3f7-4412-af0b-e153672ec5b0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("183410ad-0d87-402a-9a38-f376fd09da0a"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1903c592-abd7-4621-8b12-acad2f17b062"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1b322e6a-aab0-4f66-b01d-f65071bc23c3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1bf3fff2-508c-401a-84ff-aa74917b326c"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1f2dd148-d438-4e4d-a021-f22c4f5aaed4"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1fa79beb-1f43-479b-bba1-2fd822789d59"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("22715eab-065d-4619-a695-8819b3419f16"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("2594f9b9-4f5d-4e14-b221-a7863c050d3f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("2b73a57d-6ec0-47a2-a202-ee51d3e0b3c9"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("2c442185-975a-45cd-9bdc-3106c36fca9f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("2d6a5cef-e5b5-4eb9-bd68-7b9356152682"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("2fce5827-1abb-4044-af79-32b5f8e49505"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("304b0f60-2139-4705-ac09-5a507a179365"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("30f713d5-5255-4ddc-92e4-4d8964285fe6"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("325e5314-3f28-4acf-922d-13988f60ea77"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("340f9440-611d-45d6-a8d9-05b71842ef22"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("34158a23-c316-47b8-9977-17beb312b448"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("343e2fc5-9a51-49e9-8669-2e24582a9045"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("3ed24390-3494-43ec-80f5-825270929741"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("4018eb77-e05a-4bfb-897d-776195eb2b1b"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("4091e5a4-c59b-4ed7-84b7-94108dfbc6fc"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("53aedd67-c560-4d2a-823a-5a90dfffa928"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("59ae2185-719a-4c24-b319-875d3d168441"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("5a56fd94-b5e9-4ade-a639-b57b9c5add81"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("5a820ae6-654a-4c81-9c61-5d959a6f565e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("5fd82aa0-6045-4aa0-a4eb-8f65ba5dc53d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("60d32f9b-088c-411b-905b-ab66df7a188f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("707b0b09-cb96-4dca-b514-21c1582f7089"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("710f18b6-332d-403c-a004-59a4d4bba511"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("71329a38-8591-4c34-8c47-c28e30dbb6e2"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("722882f0-4e6a-406d-b4d6-ad582e50978a"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("732c7e1a-1ece-4472-9f7e-9c6d308ef715"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("7e9f473a-cf06-402e-8694-82c3c7d7784e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("8734a5e7-262e-456c-ac16-b66309076a8e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("8825a3d8-2a81-457c-8c75-0c92566fa313"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("89c6c5fa-5a55-4662-80b2-8c5d19229406"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("8b4e9d9d-e6f8-42a2-bd58-80908c6fd8ce"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("8bd050bc-d0c6-478c-a750-095300a0ec57"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("8c5600ba-1e20-4afb-b919-08e89638de57"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("915cb1db-ce30-4bbe-a0d1-d4a6c4d2cb7e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("927facf6-983e-496f-bb39-8c67298eee66"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("92fd05bd-5bbf-4865-b0a0-4b19d24bf0df"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("942bdc3a-02d8-4fef-8611-be79c6910f3f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9493cbdb-0311-48ab-b53c-82821d15e98a"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("97d0291f-1762-4fea-ae1b-11885bee6755"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("993d3388-4a22-4b69-b9a7-ddc7915000fe"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9b27f7de-aa7e-4ad8-bc40-015d90ba34cf"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9bfba408-ef8f-41da-aee0-ce1c3f396cde"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9f1174a7-2c2b-48b0-a9f2-87a057a9eed8"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("a33500fb-6dfd-4ca0-8bef-24272f37ed7f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("a9d684cb-6b55-4548-bc4f-53066154d4a3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b3005730-d21e-41d2-bb60-bc7c0676139c"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c16ad5de-562d-4dd9-ab83-8edf08040f1b"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c2dee39e-aedb-4d67-8964-6a2b97cd21c6"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c711f1ad-0dd8-44fd-b4b1-7dc2bb66b82a"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c86446ba-cf8e-4f1e-8cff-1e5fe226a4fd"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c8db2deb-5a28-464d-994f-114b6a054bb8"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c9ee7aa2-a3b6-47bb-b489-d299ff7af12e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("d26e6aa5-50f8-4272-b272-c07f66cbf51c"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e3adf908-019f-4822-8e6f-b31e6ae25685"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e5f9b64c-6b91-4a16-8bc3-4fb3f1be0184"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e6810a18-679b-4871-9fff-1456c3c9a89f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e811f890-0a50-41cd-b508-1a9b2e9eaba7"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e816e287-e209-4b6e-92c1-c70fe0f0c5d4"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e898b1f4-7330-4104-b1b0-ed7966e8a7f1"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("ed3cf7ae-f251-4376-8683-7435ae28282f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("edce17fc-ee3e-43d8-b4ec-a6cc1740862d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("ef2e7e6f-3c6f-4c69-b164-31902f8adbc0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f22723c3-9bad-48f8-96e2-7068b9b2c7c2"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f26745c2-482d-4d89-a03d-411d5612d460"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f8c816d6-ac3b-4b51-9073-a415388885c0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("fe558d48-4921-49e8-959e-9d14f77a8109"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("fe7a99ff-c4d1-435a-b435-b059cb4ecb3f"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "69b95277-1f9b-45e9-87cf-33fce9ef5a5c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "875a481d-ea58-4d71-8dc5-12370b3fc219");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a41359ca-0135-4a0b-881e-07de66eb303e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e2ed9871-1cbd-498c-bd76-88c6ff1f3735");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e748cacd-4b12-4173-a66c-50e9cf94f303");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b2a0b3f-335d-407a-9eb5-1f2df8757ac1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0cc0fd04-1442-43ff-bbf4-da14d44809f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39d18d23-ff3b-402c-93fc-3676c4b84cbd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43bb0799-23e3-46f2-9130-d5c864d20fb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4f5cc6c7-81d0-48b4-897d-b9bb803b7d01");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "54c7cea8-def6-4dac-8ed2-a9df662d978c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5a3775ae-deee-4d3b-add8-902565287f36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7aadde49-213c-4ea8-94b7-25d4acf487d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8253e185-3837-4996-a49c-786de1c55b35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "935ec8d4-4db9-4b2c-aac5-25676806c655");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a467059e-c9e4-41a1-b3f1-abf681f67ed4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adcb1db0-0939-4f76-80e4-05fbd8b556f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c4840c30-269e-4148-94ac-3915f8e7a9ff");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c603fd32-532a-4dd6-bc7f-55566a9926a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6ba3d3e-bcc7-4f1b-adf8-378de26ee8d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c70bdbeb-1c3a-43c2-9f07-192ef1ac6909");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cf5d2ca8-28bf-422c-a0ce-f00ea8cbf762");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dfb83bad-4b8e-41ab-9098-6f09fa4c1b64");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f2a5cf73-6cdc-47f4-9db2-a9bc6c5b483e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f68f7e6e-197e-413d-bc72-db072ccf9ea6");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0e3a7df0-4113-420f-a164-7f73bd0ff1d1"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("28cfc1fd-e78d-41f3-bcb0-13c6e2f6cd64"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4af1c6dc-7503-476d-9b3d-6817c4044fad"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4cf5e673-87f0-4311-a283-fff2d5ffb345"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4f05f789-4331-4bd9-9712-47b8d7d89c15"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("50ed9bc3-c84b-4fad-8606-73fe5a9a7a8e"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("5c26a4a8-31f7-43f1-b539-e7977eee24fd"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("64b2127f-a2c7-49c3-bdbd-5a4bb9d82450"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("694e7951-2664-4ebb-8dbb-de57d8d2f1a6"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("6dbc19ff-9bc2-4612-9957-31b441e074b0"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("767f2e97-9ab4-4621-a768-0738601afa8a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("85204702-efd9-4ab3-b024-e9581f0c763a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("8cf67fd2-00cc-41b8-ad7c-634226698298"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("9ad289a2-4ae4-41d9-a536-bdc45a378754"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("9b488485-c380-4f5d-8387-f8a28466753f"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("9ef651bb-9d32-4df2-8af4-c0ded5f2a237"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("be8e9bdb-a6f6-4b1c-a20e-35c24afe5617"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("cb8a8795-bdf0-4c07-818f-3d9d6ee904ce"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e22dbcb0-874a-4c90-9a96-5850966f82d6"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("f22d0631-fbde-49a0-a637-b15e0dc6b728"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "328d7971-00b1-4c1e-ae83-044da79f638c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "355d7bff-7157-406a-be14-1f4f41a2f0d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38df6d89-7ef7-411a-aa56-a79222b5035c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ac0108b-1750-4f96-85a9-fde8ffdda749");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3da26cb0-5215-44da-bef4-77bcc2b1a71d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b822ee5-eb3c-4e24-a44f-c8b71d22cd57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5cde9f9c-e925-4ce1-b5e8-276997f44b57");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "628f2987-610f-43f0-abeb-b830479b03d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b718587-f8b4-4e5b-86a6-2cdb71959411");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "74401562-e7c7-4448-890f-af9b01dee998");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75d6a14b-0b4f-4abf-aca2-265fd6c0cfac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "836f43d7-bc60-4d28-8f57-3bc6859c5dea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8751de00-9e1e-402f-80f3-993617e7574f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9bac9a20-195c-4076-8b1f-1967fc049ea8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "afd8a3f8-9288-49b2-a617-48aa81941de7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b027c1b3-df44-4b98-9fe4-cb29dc42fd0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2461409-f153-422c-8f18-679564bd945b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2bda50f-4e68-4547-92ea-cc9587a118f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ea0f3cfb-77b1-425e-be71-358c4bf1ba16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5ed5f51-9396-41ff-b972-c2c7cc799cb5");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "08cd7068-9520-4edd-b2b7-96a5726ec51f", 0, "088b0a09-2431-49d9-8af6-0b4541da79f9", "patient11@clinic.com", true, false, null, "PATIENT11@CLINIC.COM", "PATIENT11@CLINIC.COM", "AQAAAAIAAYagAAAAEEMfgHZkUvars5chOh6EloKUCFASkDP0lUIyHOp4b2VaeP0kErreHu03MM0kbsBsfA==", "01000000011", true, "bca4b0c5-8d5f-495e-af95-8bbc0b890f98", false, "patient11@clinic.com" },
                    { "0f240ee8-dc2e-489d-9ea6-97bc5e4a0d04", 0, "fdc387ff-caad-4d69-b024-ec9f441d7d2f", "admin1@clinic.com", true, false, null, "ADMIN1@CLINIC.COM", "ADMIN1@CLINIC.COM", "AQAAAAIAAYagAAAAEBv14gr4TnNQIoBg/54xt/f2rPR4xYE/1C67Zfc59kU6/R7STtosEHfv6NjWtcHI0w==", "01000000001", true, "bccc899f-7639-4f6e-badb-2a2beeaea36c", false, "admin1@clinic.com" },
                    { "13643700-eeff-4cc4-845d-cb688e53011b", 0, "1446073e-a474-4d05-b60e-62cc7962bd89", "doctor18@clinic.com", true, false, null, "DOCTOR18@CLINIC.COM", "DOCTOR18@CLINIC.COM", "AQAAAAIAAYagAAAAEC+pVLvoNOk/3HtLx9dqdyQCG15o9FzYDYdcW/bJ/vA/gj7aEkLRhE0asuQptYZlIg==", "01100000018", true, "c837de4c-64c8-40b2-b58d-eb1e739a57f6", false, "doctor18@clinic.com" },
                    { "2811a265-18aa-45a5-bfa4-69259d61b079", 0, "d8f7c9ad-ff52-48b5-9f3a-2accdd4c1cbc", "patient15@clinic.com", true, false, null, "PATIENT15@CLINIC.COM", "PATIENT15@CLINIC.COM", "AQAAAAIAAYagAAAAEBZYKlJ+A4oK44HvhJN9RUve/cd3lHb7IHI5I7SN37o5pFR/QCNTKbU5HuMmjNFAJg==", "01000000015", true, "6ce8a5bf-75da-4d2b-96a6-caada0c17ae0", false, "patient15@clinic.com" },
                    { "3434b72d-fea4-470c-90b9-dbbcb0ba9e2a", 0, "625deed7-f877-4407-94ec-ac7e0aaf78c6", "doctor5@clinic.com", true, false, null, "DOCTOR5@CLINIC.COM", "DOCTOR5@CLINIC.COM", "AQAAAAIAAYagAAAAEERbcoGfrwTxXeng57918GRGbDucSSAsMs+hG4a2bLIpkcpSR32sL7X5jmCaMLk3vg==", "01100000005", true, "1c8acfcb-548c-41a8-95f2-d8ba14872f35", false, "doctor5@clinic.com" },
                    { "37204e01-945c-4b14-89a7-638d086e09bb", 0, "c40deeb8-aa63-432e-841c-5e0e3040aa19", "admin3@clinic.com", true, false, null, "ADMIN3@CLINIC.COM", "ADMIN3@CLINIC.COM", "AQAAAAIAAYagAAAAEO4V0BlcbpaN++m1+fxt4eyzGOGTMPShiju64WDvG4QOwON5FaPL28vbXK6hPtB/Bg==", "01000000003", true, "c92be217-df28-40b4-bb40-3b3b08fd5efd", false, "admin3@clinic.com" },
                    { "381b6456-0d17-4c3d-8b91-95af19862e97", 0, "1e725f64-233e-4a7a-958c-4baca2f8c882", "patient1@clinic.com", true, false, null, "PATIENT1@CLINIC.COM", "PATIENT1@CLINIC.COM", "AQAAAAIAAYagAAAAECm4e9l2WQGldoabpT05yON7ZI9/A63Kmhg0Cr8v8yxAollbIR78GoZz4HcLXU/IYQ==", "01000000001", true, "9d368b26-5185-47d3-8b90-0e87d6284245", false, "patient1@clinic.com" },
                    { "43010734-d5c2-4160-838a-6aaf9a30ce0d", 0, "5662e282-3784-4898-82e3-8178e6423629", "doctor2@clinic.com", true, false, null, "DOCTOR2@CLINIC.COM", "DOCTOR2@CLINIC.COM", "AQAAAAIAAYagAAAAEAYpJriMRNqpluEIGTdRa7xcrsBZTQxoHbBBxYT17mSA1vXClQrr1+nrenQTXwJVAQ==", "01100000002", true, "94eb2b56-57a6-4541-8e3b-2a593642bcc2", false, "doctor2@clinic.com" },
                    { "4a2c0588-dcdd-4a21-94bb-85131b0e9dda", 0, "efe206a8-4040-492a-974e-e0ab6d516eab", "patient19@clinic.com", true, false, null, "PATIENT19@CLINIC.COM", "PATIENT19@CLINIC.COM", "AQAAAAIAAYagAAAAEFuCslOVkHxkYXmO2iCbuYoO4EiSjiaEaVc5TGGAy/Vsa1u3IpsBmsXCHfxBi2Kwxw==", "01000000019", true, "35ae8435-2bb1-4558-b463-7ca7d17519ff", false, "patient19@clinic.com" },
                    { "509a2dc0-84b2-44d8-a783-a8d3449d3a2a", 0, "5b827c16-b658-4058-844e-b72168ba16ad", "doctor4@clinic.com", true, false, null, "DOCTOR4@CLINIC.COM", "DOCTOR4@CLINIC.COM", "AQAAAAIAAYagAAAAEO1MxiGV82BM0pg+lJq6IhTlN29oAK+0LIbJG+5pO6nyMe2xfqTgItREec1/2EzOJg==", "01100000004", true, "9cd5b712-6e4d-4d67-baf4-b8cbb63b1e1d", false, "doctor4@clinic.com" },
                    { "596ae101-2591-4ba0-93bc-30f3c5c4377c", 0, "fcf7fff9-c7da-44a0-a6a8-fcd5d53f2089", "doctor20@clinic.com", true, false, null, "DOCTOR20@CLINIC.COM", "DOCTOR20@CLINIC.COM", "AQAAAAIAAYagAAAAEJBendCHLYSOpl2/esq5gxGWvYwxBNtvnjm6RxcmfEmY7BM+g801Bp5mf9RGi204CQ==", "01100000020", true, "791b113f-bbb7-4a9d-9db7-8c3130a585a7", false, "doctor20@clinic.com" },
                    { "693a04b2-9757-430a-bf45-ef3d21d6b124", 0, "6c40e8c9-0936-424b-853b-cdf6a9f31009", "patient8@clinic.com", true, false, null, "PATIENT8@CLINIC.COM", "PATIENT8@CLINIC.COM", "AQAAAAIAAYagAAAAEGyobrWdRNjIo2eOhOOp0pecn8YVtkaMNNmfoYN3Z7su+awcjIu+VOX7cej79kSJjQ==", "01000000008", true, "3391bdf7-8130-4b59-9291-074c428ecc8d", false, "patient8@clinic.com" },
                    { "6af6f0c1-3f9a-4866-82dc-cafedbd10695", 0, "490f4eb5-a2c6-4c7a-b5bf-1993b337a927", "doctor17@clinic.com", true, false, null, "DOCTOR17@CLINIC.COM", "DOCTOR17@CLINIC.COM", "AQAAAAIAAYagAAAAECMGQiIisssT3lnMms0YVjI2/eenLXOoznRXq8yjMnKfgqTDDTDV+SuHKddUqPpJAw==", "01100000017", true, "9417566b-9bd1-467d-b215-2c0395694ac0", false, "doctor17@clinic.com" },
                    { "6edd8c29-c317-4d3f-9400-93a2fe0e22bd", 0, "6e7efdbb-d9bd-4d61-9673-c86d548fa417", "patient6@clinic.com", true, false, null, "PATIENT6@CLINIC.COM", "PATIENT6@CLINIC.COM", "AQAAAAIAAYagAAAAEDhO15Pbx9ZCeX9fR+bEYWIEiPsbp3eOglmSny01l8IZwr6R2izsyYtK7K9AyU/IaQ==", "01000000006", true, "439c7de8-977c-4f58-b98b-eaf4d6a83a61", false, "patient6@clinic.com" },
                    { "6f988f34-6f63-40b0-99c1-709d4d980239", 0, "05faa87b-39da-4ee3-ab7f-f593d7b97310", "doctor3@clinic.com", true, false, null, "DOCTOR3@CLINIC.COM", "DOCTOR3@CLINIC.COM", "AQAAAAIAAYagAAAAEKZvk2z1417ZaAdsVFVKTMFZN+OeAeHRXPCAs7y90tl7GP480WuQV1hyE2qdGMFhGw==", "01100000003", true, "8f930acb-481b-4c0d-ab1a-d8f7b95bae5f", false, "doctor3@clinic.com" },
                    { "6fdc9bc7-391e-4773-8099-7b05fd51dfbc", 0, "0de45566-481b-439b-9170-bbddaba31353", "patient14@clinic.com", true, false, null, "PATIENT14@CLINIC.COM", "PATIENT14@CLINIC.COM", "AQAAAAIAAYagAAAAEFmrMarSxvVBpq7Jvef8saOsl5Sdg99284LmjiMOXtzUTizJaBkR7tFAgocACQTegA==", "01000000014", true, "3f64a58e-c63a-4fe4-9674-43e7b170d4b4", false, "patient14@clinic.com" },
                    { "75431e40-761a-4f8c-a976-a29fc506843a", 0, "d9524375-8345-4147-85be-fd27105e57d9", "doctor1@clinic.com", true, false, null, "DOCTOR1@CLINIC.COM", "DOCTOR1@CLINIC.COM", "AQAAAAIAAYagAAAAECsjXvDFlfnVjaQZ+rJ5my0Ql8a9tAlK6RQvh7UnBmUglCpbYg6vc/g6L6AMeEcMyg==", "01100000001", true, "f670dff4-e77c-40cd-ba7f-f8a8d9e1bfdf", false, "doctor1@clinic.com" },
                    { "7b054e61-79be-40a7-8daf-f64b0c316026", 0, "7dfe7bb6-4086-445b-aa29-76e16d2dd216", "doctor6@clinic.com", true, false, null, "DOCTOR6@CLINIC.COM", "DOCTOR6@CLINIC.COM", "AQAAAAIAAYagAAAAEIpYmLzqkntLVycSbovjaiRhYIzQLIKWvUx9EnnB6MfPjKxyxP777GLJu5o73Wu0EA==", "01100000006", true, "af632a48-e9e6-49ad-b793-fda271198c75", false, "doctor6@clinic.com" },
                    { "7efc3472-bafc-46db-82aa-9d6441b83751", 0, "43b0f22b-82b0-4a7f-91f5-63f304c852d0", "doctor11@clinic.com", true, false, null, "DOCTOR11@CLINIC.COM", "DOCTOR11@CLINIC.COM", "AQAAAAIAAYagAAAAEMsDGMTieQiRma0v/Tuq/brgRnWTvH3GcRkW/BcwUQjIT2D4wvgqVJb5OlGanLaDng==", "01100000011", true, "c1298008-3632-4732-90f7-8fdf48399baf", false, "doctor11@clinic.com" },
                    { "816cf552-1697-4f1c-93b0-3b0808ac1af7", 0, "f93e4e90-d655-410f-a96b-87737d686daa", "doctor7@clinic.com", true, false, null, "DOCTOR7@CLINIC.COM", "DOCTOR7@CLINIC.COM", "AQAAAAIAAYagAAAAEPe0B2s3ZZknc1lyEYDG+Jb2sJpAY+y1Z+8mv/1MT3dIYC9tP7fg0Yl8nRFJKqxq9Q==", "01100000007", true, "eeb797f5-6334-4daf-9f0c-b932b7f45a08", false, "doctor7@clinic.com" },
                    { "831b4b2d-854c-426e-adc2-5639c9d2ac2c", 0, "6fb0c414-6e24-44ca-9a42-87680c15c5f5", "patient12@clinic.com", true, false, null, "PATIENT12@CLINIC.COM", "PATIENT12@CLINIC.COM", "AQAAAAIAAYagAAAAEEAOagG9psvVmcCrXPIy5sgvsVeTRHO2azEVIjVOjRKYi/btdUcN9mnveOBLnolm4g==", "01000000012", true, "2a6f8a9f-0f09-4f32-8ce1-ad39122b8b8a", false, "patient12@clinic.com" },
                    { "8514ea90-6379-46cf-96e4-fc21a9cc611a", 0, "1435927b-3eaa-4496-bbdf-bf39138f043f", "patient18@clinic.com", true, false, null, "PATIENT18@CLINIC.COM", "PATIENT18@CLINIC.COM", "AQAAAAIAAYagAAAAEPa2rY9+H1jQqbUKI9ayC8s5jEvXKqsQJnP3uIQsgs6Dpqx9cUQJM/zKnytArGfVkw==", "01000000018", true, "364aa6c5-e2d3-4d30-a610-d6d3270b2811", false, "patient18@clinic.com" },
                    { "86c6a966-5368-4f82-8dfd-c502d181c8d8", 0, "4a8b68ee-a719-4ad5-876d-3680b4808872", "doctor15@clinic.com", true, false, null, "DOCTOR15@CLINIC.COM", "DOCTOR15@CLINIC.COM", "AQAAAAIAAYagAAAAEDKc5MEl7dIHLY+1rK7m2fOqA34Rw+frHgKF04nKXR8LKZDlOR5ko3EZVa0PB/i68w==", "01100000015", true, "7cdd06c3-0856-4e60-ae8a-45f81bfd634b", false, "doctor15@clinic.com" },
                    { "8c4d1bfc-d3df-42d5-85b4-bfdde65c0a8b", 0, "a89991fb-58a0-4091-bd39-67e2b8e4d97a", "doctor10@clinic.com", true, false, null, "DOCTOR10@CLINIC.COM", "DOCTOR10@CLINIC.COM", "AQAAAAIAAYagAAAAEPBPfVD8IdRFjmkC2PnXb1sSOweVkyl4u8MOuDiyY97kFzltK2FGQSeAD1pv48zsiA==", "01100000010", true, "b3a61a49-939b-48d6-a389-a398e029461b", false, "doctor10@clinic.com" },
                    { "8d83ceb2-41a9-4e9f-b2c1-eb7af14c068b", 0, "84dd8756-b514-426d-8a9f-0e5fa372419f", "doctor14@clinic.com", true, false, null, "DOCTOR14@CLINIC.COM", "DOCTOR14@CLINIC.COM", "AQAAAAIAAYagAAAAEHOR8H2Uu/VCGX9/OxZVde0RyLHVbirYjdmzIQokYoYIpS5CJg4DhLDWYilVdUxAEA==", "01100000014", true, "06c650cd-c00a-4bcf-9a7a-806a75d3eab2", false, "doctor14@clinic.com" },
                    { "8e260ae2-7d2c-424a-8d4d-a7878a1fe9fb", 0, "36f4ba81-13bd-4578-a861-01775013ee57", "doctor13@clinic.com", true, false, null, "DOCTOR13@CLINIC.COM", "DOCTOR13@CLINIC.COM", "AQAAAAIAAYagAAAAEKNIldLIoyFGHmaLUAays50lxyJeh8R6vZgKWcniQ1CaiBdznh0udPm2AMTs8fnbVg==", "01100000013", true, "288afa2e-cec7-427e-a6fa-4f2b363e5f89", false, "doctor13@clinic.com" },
                    { "91a639d9-37e2-418c-8db3-5f4d614c13a2", 0, "40808143-10a9-4b64-a593-3500bf422f87", "patient17@clinic.com", true, false, null, "PATIENT17@CLINIC.COM", "PATIENT17@CLINIC.COM", "AQAAAAIAAYagAAAAEF3uxac6lHgbGvdToRleo9C1FmoISN/sUd/CVZVzfBFODtQic/E5R/sR7rQT5AdxYg==", "01000000017", true, "eefde4d6-bb6e-407b-92b6-5173fbd83d97", false, "patient17@clinic.com" },
                    { "93f02f2a-80c4-4196-875a-8ca3d78bdfaf", 0, "ea0bffc2-72c6-4409-b1a2-fbc8a1ba1127", "patient16@clinic.com", true, false, null, "PATIENT16@CLINIC.COM", "PATIENT16@CLINIC.COM", "AQAAAAIAAYagAAAAEPqsDGBwb3iwFPgA5C0ZSrNza3fF6sreQtb9Z8S0uknM0C+9aBJ1txW8edlI+ff5Gw==", "01000000016", true, "2d1fb5eb-abfa-40dd-874e-1a723651cf59", false, "patient16@clinic.com" },
                    { "9410571e-0022-4ad7-a854-b23ade4972ea", 0, "90e0cb1d-3559-4ccf-a9f5-6d412be4bbf1", "patient2@clinic.com", true, false, null, "PATIENT2@CLINIC.COM", "PATIENT2@CLINIC.COM", "AQAAAAIAAYagAAAAEM43M/NybKQO8Oi5QA9e7LN3QMmBnCkCmWJn38Z7RGI7mtotJ0krVv7BzpoOwul4mw==", "01000000002", true, "00429ac2-6909-4b62-9500-f36e21c46e0d", false, "patient2@clinic.com" },
                    { "988f5681-bb05-4cf1-aa5b-c776376920d9", 0, "ae1a6188-bb16-4f60-8552-81bdd31e3c8d", "patient13@clinic.com", true, false, null, "PATIENT13@CLINIC.COM", "PATIENT13@CLINIC.COM", "AQAAAAIAAYagAAAAEG5LLvP6LEtLKgrOFbLKWYEHYp5SP2rakDCZe1w09oMP7Xa4pCmk4C83jHllh7Rt+A==", "01000000013", true, "1c11782a-988a-4b17-8b6d-cc26450602a5", false, "patient13@clinic.com" },
                    { "a49e8aac-965e-4831-b7df-4a2647368547", 0, "a8e768a9-7f85-40f0-818c-b3c4b5343a56", "patient7@clinic.com", true, false, null, "PATIENT7@CLINIC.COM", "PATIENT7@CLINIC.COM", "AQAAAAIAAYagAAAAEHdZmHRFE/wvyC7lP+IXPPsRBUVMzCBZMCfDm6IssqJUG6DViGpwrr3tZKeP2Ol3cA==", "01000000007", true, "62684281-bab7-4dcb-9314-6ec9ef4d4f7a", false, "patient7@clinic.com" },
                    { "ababc1fd-daa3-4f59-b4b5-2bd9acda149b", 0, "c2c21522-ba67-40cd-969c-f58b96b57e65", "patient20@clinic.com", true, false, null, "PATIENT20@CLINIC.COM", "PATIENT20@CLINIC.COM", "AQAAAAIAAYagAAAAEOOZ+hoeHZ2nTcNtHRca/PqXI3jgE+Zltph3K7kbS/eDf3GYjypR6LSPJN5U2jxOxw==", "01000000020", true, "aefc96bd-c63f-42c3-b214-1c5e44bc9955", false, "patient20@clinic.com" },
                    { "b03113fb-d317-45e5-be95-eb84a9c3185b", 0, "5311f1f5-8b41-4d5d-a122-9cb1765a5abd", "patient5@clinic.com", true, false, null, "PATIENT5@CLINIC.COM", "PATIENT5@CLINIC.COM", "AQAAAAIAAYagAAAAEH0Rr/rVkWUCrxOqL1MsQpdI1l2gepB7DOCCG3W+QmBoVy1WAbXxReot4rcSfHSz/g==", "01000000005", true, "f93757b1-0790-4f14-a1c7-0e9f6aec2f86", false, "patient5@clinic.com" },
                    { "b147561b-f1fe-40e6-a40e-cbc4cc0a316c", 0, "b9fff7d4-dc46-40cd-b8fc-eeb1010da569", "patient3@clinic.com", true, false, null, "PATIENT3@CLINIC.COM", "PATIENT3@CLINIC.COM", "AQAAAAIAAYagAAAAED4mHG3oZjP+Ris4eW7q5Zzf6USDNNsQQAc588wo6Z33l6NZ8Xo68XEiNuMUT2lQzQ==", "01000000003", true, "afea358b-d98c-4a64-94fd-3f1cc29a0246", false, "patient3@clinic.com" },
                    { "bc601296-b901-46bd-a22e-595a3ba788d6", 0, "c8fbd223-dd1a-4b68-91f7-9be5a1b94fac", "doctor12@clinic.com", true, false, null, "DOCTOR12@CLINIC.COM", "DOCTOR12@CLINIC.COM", "AQAAAAIAAYagAAAAENMruOWL8v5Q8kPduk86DQ/fkPO8XdNv+RJN1wSJxL8fWNYuItOLgv56tnD9okqbjg==", "01100000012", true, "c2a309d1-30f7-48bd-ae13-3444299eb52b", false, "doctor12@clinic.com" },
                    { "bef24a00-dd40-4348-a2b4-2b5c8a64675b", 0, "f9dca8d9-cf6d-4dff-908e-522c8ac026c6", "patient9@clinic.com", true, false, null, "PATIENT9@CLINIC.COM", "PATIENT9@CLINIC.COM", "AQAAAAIAAYagAAAAECu3TXrDp4LIbiadPTH4w/6/R+Zn2y+epEqZAoY1iCUsoBkWOsv3+iYPJ3yHPAOi+w==", "01000000009", true, "da0d2aa5-ba3b-4456-a8ed-71be57b22d26", false, "patient9@clinic.com" },
                    { "d6e00172-40e4-471c-9e08-45c36a05ea74", 0, "34981041-f3bc-48cb-93d2-51e239d5cce6", "patient4@clinic.com", true, false, null, "PATIENT4@CLINIC.COM", "PATIENT4@CLINIC.COM", "AQAAAAIAAYagAAAAEACSTjdwxDksqOqoki5zEVc/L68RNKWlBb/6AADGfD16TP7mg8KvuJQJiLQRLbrqHg==", "01000000004", true, "3bda6f32-5817-434a-8d39-254e27637295", false, "patient4@clinic.com" },
                    { "d78c1e65-d3c0-434b-ac70-6309295f02e6", 0, "9e84e557-d20a-4272-908d-f24bf690b026", "doctor9@clinic.com", true, false, null, "DOCTOR9@CLINIC.COM", "DOCTOR9@CLINIC.COM", "AQAAAAIAAYagAAAAEGEwW4hD52wSVR7FL1k8akHjbQvA19+GevBbTc0EidRsFKSjO13iC4JSsSBtj6w5kg==", "01100000009", true, "db952a3c-96c3-4ee3-b312-1fc5710649a5", false, "doctor9@clinic.com" },
                    { "d87dbe8a-03b5-455f-a755-6af236edb61b", 0, "4b52a460-538b-40bc-bebf-921a0a963772", "patient10@clinic.com", true, false, null, "PATIENT10@CLINIC.COM", "PATIENT10@CLINIC.COM", "AQAAAAIAAYagAAAAELgA6OGybWmqtb4L0Uyf8iJmNjYUQ60gaKDO8f1pexFHFx00Y6VBQsJzFAUDxmkOjA==", "01000000010", true, "a83390eb-7c09-45c0-838b-1b10221ebbf9", false, "patient10@clinic.com" },
                    { "da197622-64d7-4c38-81fd-c55929c4bb67", 0, "3823cac3-0604-4979-8b84-5c57eb282b1b", "admin2@clinic.com", true, false, null, "ADMIN2@CLINIC.COM", "ADMIN2@CLINIC.COM", "AQAAAAIAAYagAAAAENAG9zCEwlPQPqG8st6F5wZOZT6uyiQztCptSBGD+oKvJRWt3eQQv59E328ERZAbFw==", "01000000002", true, "dced6f39-4cf3-48ce-b898-73d46e77c825", false, "admin2@clinic.com" },
                    { "de6b3bed-f339-48e8-9429-be421115d9d2", 0, "c9c715c5-5436-4ebf-8c4e-bc3a065440dc", "doctor19@clinic.com", true, false, null, "DOCTOR19@CLINIC.COM", "DOCTOR19@CLINIC.COM", "AQAAAAIAAYagAAAAEKz61HQDCct1TlqrwFTKlI0fNbf6xj5gWcIa/2dSncqpalsZ4nLE6QThDeiwTg3NYA==", "01100000019", true, "b86f6e53-c0fd-414f-9d22-8edb79d90019", false, "doctor19@clinic.com" },
                    { "e22ad530-5f0b-4997-a3e6-6f6d519c475d", 0, "611db822-9fc7-4d5c-be0f-92769bb827ab", "admin4@clinic.com", true, false, null, "ADMIN4@CLINIC.COM", "ADMIN4@CLINIC.COM", "AQAAAAIAAYagAAAAECNPubkv+8zQpsJhdswM8r1IukE2nzxtFz8BAFBB63LLsIuq3NU98fINvPmGGMeNgw==", "01000000004", true, "d4e348f2-18a7-4689-918e-dbbcf1c5b461", false, "admin4@clinic.com" },
                    { "f1a97b37-4f92-46e7-a772-2303470d621f", 0, "00b7eb19-301b-4000-9be9-a4c2468a1f9f", "admin5@clinic.com", true, false, null, "ADMIN5@CLINIC.COM", "ADMIN5@CLINIC.COM", "AQAAAAIAAYagAAAAENzqAds5ac+eJhhOBPc3FXKXrHTqL2+RI3bkcDEAGDynJVuEjgE+nmViCM0gw7AX3A==", "01000000005", true, "d6fceb39-a885-486f-aecd-ce7337e4a632", false, "admin5@clinic.com" },
                    { "f500b358-1322-45fb-89dc-22a4134de95b", 0, "541ee426-3bda-42da-bd78-4fe20359d5d0", "doctor16@clinic.com", true, false, null, "DOCTOR16@CLINIC.COM", "DOCTOR16@CLINIC.COM", "AQAAAAIAAYagAAAAEPeXEO+Pn4jIbeVS7vABv32J9Vl21TgcF3elLn7VoLGQwE5djdTNR7NiYv3uvSBl6A==", "01100000016", true, "9262de0e-be06-4e4f-8763-8e6b992b6870", false, "doctor16@clinic.com" },
                    { "ff71eaf9-eb41-4284-92f9-0dc05fec882f", 0, "9002a7c1-89c7-4074-9726-a5e1a44ed3bc", "doctor8@clinic.com", true, false, null, "DOCTOR8@CLINIC.COM", "DOCTOR8@CLINIC.COM", "AQAAAAIAAYagAAAAEO3eiUM5NGaBGrHUI5wOUDhzE7g1jiWx/ZHA/NWy15UHuC+lLJkg9NLSKoJ58FTHbA==", "01100000008", true, "93431adc-b831-4e24-9bbe-2cd401914067", false, "doctor8@clinic.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "08cd7068-9520-4edd-b2b7-96a5726ec51f" },
                    { "675b578c-8739-4b1b-a706-816fb14910bd", "0f240ee8-dc2e-489d-9ea6-97bc5e4a0d04" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "13643700-eeff-4cc4-845d-cb688e53011b" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "2811a265-18aa-45a5-bfa4-69259d61b079" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "3434b72d-fea4-470c-90b9-dbbcb0ba9e2a" },
                    { "675b578c-8739-4b1b-a706-816fb14910bd", "37204e01-945c-4b14-89a7-638d086e09bb" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "381b6456-0d17-4c3d-8b91-95af19862e97" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "43010734-d5c2-4160-838a-6aaf9a30ce0d" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "4a2c0588-dcdd-4a21-94bb-85131b0e9dda" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "509a2dc0-84b2-44d8-a783-a8d3449d3a2a" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "596ae101-2591-4ba0-93bc-30f3c5c4377c" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "693a04b2-9757-430a-bf45-ef3d21d6b124" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "6af6f0c1-3f9a-4866-82dc-cafedbd10695" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "6edd8c29-c317-4d3f-9400-93a2fe0e22bd" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "6f988f34-6f63-40b0-99c1-709d4d980239" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "6fdc9bc7-391e-4773-8099-7b05fd51dfbc" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "75431e40-761a-4f8c-a976-a29fc506843a" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "7b054e61-79be-40a7-8daf-f64b0c316026" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "7efc3472-bafc-46db-82aa-9d6441b83751" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "816cf552-1697-4f1c-93b0-3b0808ac1af7" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "831b4b2d-854c-426e-adc2-5639c9d2ac2c" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "8514ea90-6379-46cf-96e4-fc21a9cc611a" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "86c6a966-5368-4f82-8dfd-c502d181c8d8" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "8c4d1bfc-d3df-42d5-85b4-bfdde65c0a8b" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "8d83ceb2-41a9-4e9f-b2c1-eb7af14c068b" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "8e260ae2-7d2c-424a-8d4d-a7878a1fe9fb" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "91a639d9-37e2-418c-8db3-5f4d614c13a2" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "93f02f2a-80c4-4196-875a-8ca3d78bdfaf" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "9410571e-0022-4ad7-a854-b23ade4972ea" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "988f5681-bb05-4cf1-aa5b-c776376920d9" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "a49e8aac-965e-4831-b7df-4a2647368547" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "ababc1fd-daa3-4f59-b4b5-2bd9acda149b" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "b03113fb-d317-45e5-be95-eb84a9c3185b" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "b147561b-f1fe-40e6-a40e-cbc4cc0a316c" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "bc601296-b901-46bd-a22e-595a3ba788d6" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "bef24a00-dd40-4348-a2b4-2b5c8a64675b" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "d6e00172-40e4-471c-9e08-45c36a05ea74" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "d78c1e65-d3c0-434b-ac70-6309295f02e6" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "d87dbe8a-03b5-455f-a755-6af236edb61b" },
                    { "675b578c-8739-4b1b-a706-816fb14910bd", "da197622-64d7-4c38-81fd-c55929c4bb67" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "de6b3bed-f339-48e8-9429-be421115d9d2" },
                    { "675b578c-8739-4b1b-a706-816fb14910bd", "e22ad530-5f0b-4997-a3e6-6f6d519c475d" },
                    { "675b578c-8739-4b1b-a706-816fb14910bd", "f1a97b37-4f92-46e7-a772-2303470d621f" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "f500b358-1322-45fb-89dc-22a4134de95b" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "ff71eaf9-eb41-4284-92f9-0dc05fec882f" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Price", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("00d583ad-a449-49bd-804a-ee5625d61201"), 111.0, "Specialty 11", "7efc3472-bafc-46db-82aa-9d6441b83751" },
                    { new Guid("1366939d-b9c4-4ed1-aa12-96c67176e078"), 114.0, "Specialty 14", "8d83ceb2-41a9-4e9f-b2c1-eb7af14c068b" },
                    { new Guid("1a0200fd-db8e-412f-a610-0c9e6c8c20bf"), 103.0, "Specialty 3", "6f988f34-6f63-40b0-99c1-709d4d980239" },
                    { new Guid("26e35c4f-5c73-4ca5-b4ed-51815cc96e55"), 116.0, "Specialty 16", "f500b358-1322-45fb-89dc-22a4134de95b" },
                    { new Guid("2d7aae7e-d64a-4ac6-97c9-841c1bf9682b"), 105.0, "Specialty 5", "3434b72d-fea4-470c-90b9-dbbcb0ba9e2a" },
                    { new Guid("465891ed-ea0e-4aba-94a6-2538a6c0e992"), 113.0, "Specialty 13", "8e260ae2-7d2c-424a-8d4d-a7878a1fe9fb" },
                    { new Guid("586502e2-1d49-457f-a2f9-dcde93f5d886"), 119.0, "Specialty 19", "de6b3bed-f339-48e8-9429-be421115d9d2" },
                    { new Guid("6bf06de4-e0d5-4601-a523-178e630e1e9f"), 102.0, "Specialty 2", "43010734-d5c2-4160-838a-6aaf9a30ce0d" },
                    { new Guid("70626a5e-2119-407a-a533-7e9ade00009e"), 120.0, "Specialty 20", "596ae101-2591-4ba0-93bc-30f3c5c4377c" },
                    { new Guid("7ae48af0-d30f-450f-9946-d3db1ae451ff"), 109.0, "Specialty 9", "d78c1e65-d3c0-434b-ac70-6309295f02e6" },
                    { new Guid("7ba550de-c044-4e86-ab48-7ce54a637bbe"), 106.0, "Specialty 6", "7b054e61-79be-40a7-8daf-f64b0c316026" },
                    { new Guid("841483fb-57a6-435a-ad4d-96ab45a9c85c"), 110.0, "Specialty 10", "8c4d1bfc-d3df-42d5-85b4-bfdde65c0a8b" },
                    { new Guid("84369c4e-cb6a-4e97-a7c0-a5a34f17257c"), 117.0, "Specialty 17", "6af6f0c1-3f9a-4866-82dc-cafedbd10695" },
                    { new Guid("94906be6-9e2a-4d5e-9a03-b1d10b24e7d5"), 107.0, "Specialty 7", "816cf552-1697-4f1c-93b0-3b0808ac1af7" },
                    { new Guid("9cd6e37d-e4d1-43eb-a6bd-da6aca3a8597"), 115.0, "Specialty 15", "86c6a966-5368-4f82-8dfd-c502d181c8d8" },
                    { new Guid("b64e4a42-0971-4e61-9039-5cdfcc915e14"), 101.0, "Specialty 1", "75431e40-761a-4f8c-a976-a29fc506843a" },
                    { new Guid("daaab8c8-97e5-48f9-85d7-70b3d7d55e87"), 118.0, "Specialty 18", "13643700-eeff-4cc4-845d-cb688e53011b" },
                    { new Guid("debc34e9-1fb3-4ba2-961f-26196b1d0a44"), 108.0, "Specialty 8", "ff71eaf9-eb41-4284-92f9-0dc05fec882f" },
                    { new Guid("e76c3781-588f-460f-95f0-f7ca0b6d6a3a"), 112.0, "Specialty 12", "bc601296-b901-46bd-a22e-595a3ba788d6" },
                    { new Guid("f6dd720c-aa35-4e9c-b41c-0e49426367f4"), 104.0, "Specialty 4", "509a2dc0-84b2-44d8-a783-a8d3449d3a2a" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "Date", "DoctorId", "PatientId", "State", "Time" },
                values: new object[,]
                {
                    { new Guid("015e7bb3-ffd7-4005-a065-6e569a88d164"), "2025-05-03", new Guid("1a0200fd-db8e-412f-a610-0c9e6c8c20bf"), "37204e01-945c-4b14-89a7-638d086e09bb", "ongoing", "11:00 AM" },
                    { new Guid("03354eef-3926-4477-873c-962723c10dd5"), "2025-05-04", new Guid("f6dd720c-aa35-4e9c-b41c-0e49426367f4"), "e22ad530-5f0b-4997-a3e6-6f6d519c475d", "ongoing", "12:00 AM" },
                    { new Guid("034e2bb7-d05c-4c26-bd26-9a9d49270c21"), "2025-05-14", new Guid("1366939d-b9c4-4ed1-aa12-96c67176e078"), "bef24a00-dd40-4348-a2b4-2b5c8a64675b", "ongoing", "10:00 AM" },
                    { new Guid("05c44080-42de-43b3-86b4-b77d4ed78b28"), "2025-05-01", new Guid("b64e4a42-0971-4e61-9039-5cdfcc915e14"), "0f240ee8-dc2e-489d-9ea6-97bc5e4a0d04", "ongoing", "9:00 AM" },
                    { new Guid("05e479d8-47d0-40c2-9ad4-c39584c4b3a7"), "2025-05-15", new Guid("9cd6e37d-e4d1-43eb-a6bd-da6aca3a8597"), null, "opened", "11:00 AM" },
                    { new Guid("0657d184-5e0a-4784-a757-cdc02dd8c63d"), "2025-05-06", new Guid("7ba550de-c044-4e86-ab48-7ce54a637bbe"), "381b6456-0d17-4c3d-8b91-95af19862e97", "ongoing", "14:00 AM" },
                    { new Guid("12ccec37-49c5-4c49-a535-64478932c786"), "2025-05-12", new Guid("e76c3781-588f-460f-95f0-f7ca0b6d6a3a"), "a49e8aac-965e-4831-b7df-4a2647368547", "closed", "20:00 AM" },
                    { new Guid("153b8437-8550-495a-8e8e-df645628f4fc"), "2025-05-18", new Guid("daaab8c8-97e5-48f9-85d7-70b3d7d55e87"), null, "opened", "14:00 AM" },
                    { new Guid("17256834-9436-40e5-8b20-eb03cbd8d3ce"), "2025-05-11", new Guid("00d583ad-a449-49bd-804a-ee5625d61201"), "6edd8c29-c317-4d3f-9400-93a2fe0e22bd", "pending", "19:00 AM" },
                    { new Guid("173e3207-a5b6-4e33-8101-9e6deb75de20"), "2025-05-19", new Guid("586502e2-1d49-457f-a2f9-dcde93f5d886"), "6fdc9bc7-391e-4773-8099-7b05fd51dfbc", "ongoing", "15:00 AM" },
                    { new Guid("18c4ea2e-cb87-4676-84a8-69dc59bd9cd9"), "2025-05-15", new Guid("9cd6e37d-e4d1-43eb-a6bd-da6aca3a8597"), "d87dbe8a-03b5-455f-a755-6af236edb61b", "ongoing", "11:00 AM" },
                    { new Guid("1cd77978-f6cb-429f-a731-2dc4d568e1fa"), "2025-05-03", new Guid("1a0200fd-db8e-412f-a610-0c9e6c8c20bf"), null, "opened", "11:00 AM" },
                    { new Guid("1eff2bee-40a9-4857-af3d-36bb510b439a"), "2025-05-04", new Guid("f6dd720c-aa35-4e9c-b41c-0e49426367f4"), null, "opened", "12:00 AM" },
                    { new Guid("1faf5614-12b5-4ac5-83ba-c99f1417b4b9"), "2025-05-05", new Guid("2d7aae7e-d64a-4ac6-97c9-841c1bf9682b"), "f1a97b37-4f92-46e7-a772-2303470d621f", "closed", "13:00 AM" },
                    { new Guid("20e5aad4-5e05-4938-aa46-50489184b303"), "2025-05-12", new Guid("e76c3781-588f-460f-95f0-f7ca0b6d6a3a"), "a49e8aac-965e-4831-b7df-4a2647368547", "ongoing", "20:00 AM" },
                    { new Guid("21ef9f10-0638-46d8-849e-843f0f2fe0c3"), "2025-05-09", new Guid("7ae48af0-d30f-450f-9946-d3db1ae451ff"), null, "opened", "17:00 AM" },
                    { new Guid("2925082e-ff72-41d2-b7fc-4e6294c1e30f"), "2025-05-02", new Guid("6bf06de4-e0d5-4601-a523-178e630e1e9f"), "da197622-64d7-4c38-81fd-c55929c4bb67", "ongoing", "10:00 AM" },
                    { new Guid("2a578a1a-2ff0-449e-ab22-6bc1db27ee0f"), "2025-05-15", new Guid("9cd6e37d-e4d1-43eb-a6bd-da6aca3a8597"), "d87dbe8a-03b5-455f-a755-6af236edb61b", "pending", "11:00 AM" },
                    { new Guid("2d4a70b8-092c-4956-9f42-2ca3932ccd4d"), "2025-05-07", new Guid("94906be6-9e2a-4d5e-9a03-b1d10b24e7d5"), null, "opened", "15:00 AM" },
                    { new Guid("30838968-64ee-42b1-b228-bdb7173dd928"), "2025-05-04", new Guid("f6dd720c-aa35-4e9c-b41c-0e49426367f4"), "e22ad530-5f0b-4997-a3e6-6f6d519c475d", "closed", "12:00 AM" },
                    { new Guid("34d85870-646e-47f9-9ba7-7f054588b21d"), "2025-05-19", new Guid("586502e2-1d49-457f-a2f9-dcde93f5d886"), "6fdc9bc7-391e-4773-8099-7b05fd51dfbc", "closed", "15:00 AM" },
                    { new Guid("34ec8bbe-7c06-47f6-a078-fd5c01a85edc"), "2025-05-18", new Guid("daaab8c8-97e5-48f9-85d7-70b3d7d55e87"), "988f5681-bb05-4cf1-aa5b-c776376920d9", "ongoing", "14:00 AM" },
                    { new Guid("3ea60b2a-aff2-44ec-a09f-475bbe37a716"), "2025-05-19", new Guid("586502e2-1d49-457f-a2f9-dcde93f5d886"), null, "opened", "15:00 AM" },
                    { new Guid("3f7b3f01-0e40-4341-82ac-5e4601e49698"), "2025-05-18", new Guid("daaab8c8-97e5-48f9-85d7-70b3d7d55e87"), "988f5681-bb05-4cf1-aa5b-c776376920d9", "closed", "14:00 AM" },
                    { new Guid("40171138-23e3-48bf-9c7d-bbd981e271fd"), "2025-05-12", new Guid("e76c3781-588f-460f-95f0-f7ca0b6d6a3a"), "a49e8aac-965e-4831-b7df-4a2647368547", "pending", "20:00 AM" },
                    { new Guid("47025ba5-3143-4c08-a0ff-08e0467e103e"), "2025-05-17", new Guid("84369c4e-cb6a-4e97-a7c0-a5a34f17257c"), "831b4b2d-854c-426e-adc2-5639c9d2ac2c", "pending", "13:00 AM" },
                    { new Guid("4877e3d6-8e31-4c11-9186-e283e8a0f247"), "2025-05-07", new Guid("94906be6-9e2a-4d5e-9a03-b1d10b24e7d5"), "9410571e-0022-4ad7-a854-b23ade4972ea", "ongoing", "15:00 AM" },
                    { new Guid("48e8ad33-b152-4265-b0b0-9de26d6909e6"), "2025-05-13", new Guid("465891ed-ea0e-4aba-94a6-2538a6c0e992"), "693a04b2-9757-430a-bf45-ef3d21d6b124", "ongoing", "9:00 AM" },
                    { new Guid("49034bc6-63ba-4331-9078-08d11a858c38"), "2025-05-13", new Guid("465891ed-ea0e-4aba-94a6-2538a6c0e992"), "693a04b2-9757-430a-bf45-ef3d21d6b124", "closed", "9:00 AM" },
                    { new Guid("4b3a2556-5f81-4849-a6b3-54fa16e8b634"), "2025-05-20", new Guid("70626a5e-2119-407a-a533-7e9ade00009e"), "2811a265-18aa-45a5-bfa4-69259d61b079", "pending", "16:00 AM" },
                    { new Guid("4ca516e3-88f8-4536-b761-0492b2ef59a3"), "2025-05-09", new Guid("7ae48af0-d30f-450f-9946-d3db1ae451ff"), "d6e00172-40e4-471c-9e08-45c36a05ea74", "pending", "17:00 AM" },
                    { new Guid("519f535a-bd8b-4a7b-b322-9ba59b339fce"), "2025-05-11", new Guid("00d583ad-a449-49bd-804a-ee5625d61201"), null, "opened", "19:00 AM" },
                    { new Guid("53782d02-3dab-4cfb-9f48-1de6c103fd44"), "2025-05-20", new Guid("70626a5e-2119-407a-a533-7e9ade00009e"), "2811a265-18aa-45a5-bfa4-69259d61b079", "closed", "16:00 AM" },
                    { new Guid("560899c5-a623-44c5-adc6-f6b178905aab"), "2025-05-13", new Guid("465891ed-ea0e-4aba-94a6-2538a6c0e992"), "693a04b2-9757-430a-bf45-ef3d21d6b124", "pending", "9:00 AM" },
                    { new Guid("57b4a80f-9c3a-4175-b035-5727cb7765db"), "2025-05-08", new Guid("debc34e9-1fb3-4ba2-961f-26196b1d0a44"), null, "opened", "16:00 AM" },
                    { new Guid("5c0f49ea-8497-4ac3-bbaa-834dca0e0b81"), "2025-05-20", new Guid("70626a5e-2119-407a-a533-7e9ade00009e"), null, "opened", "16:00 AM" },
                    { new Guid("60b18edc-6897-4d51-8574-4ba7168a8679"), "2025-05-17", new Guid("84369c4e-cb6a-4e97-a7c0-a5a34f17257c"), "831b4b2d-854c-426e-adc2-5639c9d2ac2c", "ongoing", "13:00 AM" },
                    { new Guid("63f5339a-208e-42de-85fc-22a2d9c32688"), "2025-05-05", new Guid("2d7aae7e-d64a-4ac6-97c9-841c1bf9682b"), "f1a97b37-4f92-46e7-a772-2303470d621f", "pending", "13:00 AM" },
                    { new Guid("65c9d7e9-500d-4c45-9642-2340a842a072"), "2025-05-01", new Guid("b64e4a42-0971-4e61-9039-5cdfcc915e14"), "0f240ee8-dc2e-489d-9ea6-97bc5e4a0d04", "closed", "9:00 AM" },
                    { new Guid("6d312cd9-3151-46f2-adef-2eaf36c4b5d5"), "2025-05-13", new Guid("465891ed-ea0e-4aba-94a6-2538a6c0e992"), null, "opened", "9:00 AM" },
                    { new Guid("6fd86de2-9da1-4d86-8e9d-202cad3c4046"), "2025-05-01", new Guid("b64e4a42-0971-4e61-9039-5cdfcc915e14"), "0f240ee8-dc2e-489d-9ea6-97bc5e4a0d04", "pending", "9:00 AM" },
                    { new Guid("74ad7ab3-b9c2-488d-b801-885bd8983c17"), "2025-05-14", new Guid("1366939d-b9c4-4ed1-aa12-96c67176e078"), "bef24a00-dd40-4348-a2b4-2b5c8a64675b", "closed", "10:00 AM" },
                    { new Guid("756054e7-2d39-49dd-8ecb-e4394549e46f"), "2025-05-15", new Guid("9cd6e37d-e4d1-43eb-a6bd-da6aca3a8597"), "d87dbe8a-03b5-455f-a755-6af236edb61b", "closed", "11:00 AM" },
                    { new Guid("7990b2a1-8e83-489c-b166-bd3fce7d15dc"), "2025-05-11", new Guid("00d583ad-a449-49bd-804a-ee5625d61201"), "6edd8c29-c317-4d3f-9400-93a2fe0e22bd", "closed", "19:00 AM" },
                    { new Guid("7fbe2f4e-84f1-4924-a080-5edba37d0066"), "2025-05-19", new Guid("586502e2-1d49-457f-a2f9-dcde93f5d886"), "6fdc9bc7-391e-4773-8099-7b05fd51dfbc", "pending", "15:00 AM" },
                    { new Guid("81384609-03df-4bd7-a2f7-8c29e8ccf403"), "2025-05-16", new Guid("26e35c4f-5c73-4ca5-b4ed-51815cc96e55"), "08cd7068-9520-4edd-b2b7-96a5726ec51f", "closed", "12:00 AM" },
                    { new Guid("81f0863e-c839-40db-82c4-13eb4a9653eb"), "2025-05-16", new Guid("26e35c4f-5c73-4ca5-b4ed-51815cc96e55"), "08cd7068-9520-4edd-b2b7-96a5726ec51f", "pending", "12:00 AM" },
                    { new Guid("858a84c8-af60-4bd9-9eb3-901f2f919881"), "2025-05-10", new Guid("841483fb-57a6-435a-ad4d-96ab45a9c85c"), "b03113fb-d317-45e5-be95-eb84a9c3185b", "closed", "18:00 AM" },
                    { new Guid("88519ed1-cbfb-4caa-946e-d9db67dd82a8"), "2025-05-17", new Guid("84369c4e-cb6a-4e97-a7c0-a5a34f17257c"), "831b4b2d-854c-426e-adc2-5639c9d2ac2c", "closed", "13:00 AM" },
                    { new Guid("8b0c107e-6664-42f5-ac32-248b4179bc5b"), "2025-05-08", new Guid("debc34e9-1fb3-4ba2-961f-26196b1d0a44"), "b147561b-f1fe-40e6-a40e-cbc4cc0a316c", "pending", "16:00 AM" },
                    { new Guid("8dd0b9f1-8b05-4801-9fa0-1ccdfeb5e1c8"), "2025-05-10", new Guid("841483fb-57a6-435a-ad4d-96ab45a9c85c"), null, "opened", "18:00 AM" },
                    { new Guid("900d49f4-b404-4dad-9917-e88a99a803cb"), "2025-05-09", new Guid("7ae48af0-d30f-450f-9946-d3db1ae451ff"), "d6e00172-40e4-471c-9e08-45c36a05ea74", "ongoing", "17:00 AM" },
                    { new Guid("95038ddc-ea4b-408c-9102-e72be2d5dd9d"), "2025-05-10", new Guid("841483fb-57a6-435a-ad4d-96ab45a9c85c"), "b03113fb-d317-45e5-be95-eb84a9c3185b", "ongoing", "18:00 AM" },
                    { new Guid("97090fff-1582-4cfa-8966-bd408e7109a8"), "2025-05-06", new Guid("7ba550de-c044-4e86-ab48-7ce54a637bbe"), null, "opened", "14:00 AM" },
                    { new Guid("99848b53-f1cc-4df2-8e54-6a60e4b787ed"), "2025-05-18", new Guid("daaab8c8-97e5-48f9-85d7-70b3d7d55e87"), "988f5681-bb05-4cf1-aa5b-c776376920d9", "pending", "14:00 AM" },
                    { new Guid("9bd16afe-10e2-4320-849d-4f3e6431ad7f"), "2025-05-17", new Guid("84369c4e-cb6a-4e97-a7c0-a5a34f17257c"), null, "opened", "13:00 AM" },
                    { new Guid("a1625d86-8ce3-4b58-bb47-f59335b7f5b4"), "2025-05-10", new Guid("841483fb-57a6-435a-ad4d-96ab45a9c85c"), "b03113fb-d317-45e5-be95-eb84a9c3185b", "pending", "18:00 AM" },
                    { new Guid("ac913815-87c6-42d1-b6db-117bc5f4f6d1"), "2025-05-05", new Guid("2d7aae7e-d64a-4ac6-97c9-841c1bf9682b"), null, "opened", "13:00 AM" },
                    { new Guid("b0cd02f7-a2ba-4306-b027-03b5f7e57bb2"), "2025-05-11", new Guid("00d583ad-a449-49bd-804a-ee5625d61201"), "6edd8c29-c317-4d3f-9400-93a2fe0e22bd", "ongoing", "19:00 AM" },
                    { new Guid("b3cb0a58-2ae1-4cff-b44e-06dff115f68b"), "2025-05-14", new Guid("1366939d-b9c4-4ed1-aa12-96c67176e078"), null, "opened", "10:00 AM" },
                    { new Guid("b5f8c936-32f5-4982-96a0-1717e9fe1978"), "2025-05-04", new Guid("f6dd720c-aa35-4e9c-b41c-0e49426367f4"), "e22ad530-5f0b-4997-a3e6-6f6d519c475d", "pending", "12:00 AM" },
                    { new Guid("b6b3948e-a32a-45f5-bc54-58af7bdadffb"), "2025-05-16", new Guid("26e35c4f-5c73-4ca5-b4ed-51815cc96e55"), null, "opened", "12:00 AM" },
                    { new Guid("b8d2a62c-a554-442d-b9a4-df62ac68c04c"), "2025-05-09", new Guid("7ae48af0-d30f-450f-9946-d3db1ae451ff"), "d6e00172-40e4-471c-9e08-45c36a05ea74", "closed", "17:00 AM" },
                    { new Guid("c3c40936-bc11-44ab-bf25-4f72b48deb99"), "2025-05-01", new Guid("b64e4a42-0971-4e61-9039-5cdfcc915e14"), null, "opened", "9:00 AM" },
                    { new Guid("c59d10a8-011b-4426-8085-8e16853441fa"), "2025-05-06", new Guid("7ba550de-c044-4e86-ab48-7ce54a637bbe"), "381b6456-0d17-4c3d-8b91-95af19862e97", "pending", "14:00 AM" },
                    { new Guid("c5cb6a03-b45b-4a55-8531-953556bdb446"), "2025-05-08", new Guid("debc34e9-1fb3-4ba2-961f-26196b1d0a44"), "b147561b-f1fe-40e6-a40e-cbc4cc0a316c", "ongoing", "16:00 AM" },
                    { new Guid("c8e8f853-99ed-4005-811c-c1bd71d86967"), "2025-05-02", new Guid("6bf06de4-e0d5-4601-a523-178e630e1e9f"), "da197622-64d7-4c38-81fd-c55929c4bb67", "closed", "10:00 AM" },
                    { new Guid("c9fbdb9b-ba8b-49c5-9871-5f0937729fd0"), "2025-05-06", new Guid("7ba550de-c044-4e86-ab48-7ce54a637bbe"), "381b6456-0d17-4c3d-8b91-95af19862e97", "closed", "14:00 AM" },
                    { new Guid("ce3ac501-f3e0-48b5-a247-3c73c3c9db4d"), "2025-05-07", new Guid("94906be6-9e2a-4d5e-9a03-b1d10b24e7d5"), "9410571e-0022-4ad7-a854-b23ade4972ea", "pending", "15:00 AM" },
                    { new Guid("d0d6354c-6260-495e-8dc6-397cebb2847e"), "2025-05-08", new Guid("debc34e9-1fb3-4ba2-961f-26196b1d0a44"), "b147561b-f1fe-40e6-a40e-cbc4cc0a316c", "closed", "16:00 AM" },
                    { new Guid("d2b81e1b-dcca-456d-b6dc-74d25b182ca2"), "2025-05-03", new Guid("1a0200fd-db8e-412f-a610-0c9e6c8c20bf"), "37204e01-945c-4b14-89a7-638d086e09bb", "pending", "11:00 AM" },
                    { new Guid("dba996c3-5f56-4b04-98e1-7ec107a8a7e2"), "2025-05-20", new Guid("70626a5e-2119-407a-a533-7e9ade00009e"), "2811a265-18aa-45a5-bfa4-69259d61b079", "ongoing", "16:00 AM" },
                    { new Guid("dcc79725-db93-43ed-936d-391ad7ac5308"), "2025-05-12", new Guid("e76c3781-588f-460f-95f0-f7ca0b6d6a3a"), null, "opened", "20:00 AM" },
                    { new Guid("e172699b-aa2f-46e7-b6b5-50208dd8b65e"), "2025-05-05", new Guid("2d7aae7e-d64a-4ac6-97c9-841c1bf9682b"), "f1a97b37-4f92-46e7-a772-2303470d621f", "ongoing", "13:00 AM" },
                    { new Guid("e4e1eddf-11dd-42e8-9b0a-ebc2fe581956"), "2025-05-02", new Guid("6bf06de4-e0d5-4601-a523-178e630e1e9f"), "da197622-64d7-4c38-81fd-c55929c4bb67", "pending", "10:00 AM" },
                    { new Guid("e71afc49-98fd-4d8b-9cae-2bf621bf0393"), "2025-05-16", new Guid("26e35c4f-5c73-4ca5-b4ed-51815cc96e55"), "08cd7068-9520-4edd-b2b7-96a5726ec51f", "ongoing", "12:00 AM" },
                    { new Guid("e9b75747-ef06-46f6-922a-bf434c5fa205"), "2025-05-02", new Guid("6bf06de4-e0d5-4601-a523-178e630e1e9f"), null, "opened", "10:00 AM" },
                    { new Guid("fc0a0abe-e6e4-42bc-8219-a782e80a6431"), "2025-05-07", new Guid("94906be6-9e2a-4d5e-9a03-b1d10b24e7d5"), "9410571e-0022-4ad7-a854-b23ade4972ea", "closed", "15:00 AM" },
                    { new Guid("fc7049e9-de17-43b4-874f-6237c56166ee"), "2025-05-03", new Guid("1a0200fd-db8e-412f-a610-0c9e6c8c20bf"), "37204e01-945c-4b14-89a7-638d086e09bb", "closed", "11:00 AM" },
                    { new Guid("fd9921e2-df3d-4c5e-a45a-ff51a0a9dbfe"), "2025-05-14", new Guid("1366939d-b9c4-4ed1-aa12-96c67176e078"), "bef24a00-dd40-4348-a2b4-2b5c8a64675b", "pending", "10:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Id", "AppointmentId", "Description", "Modification_date" },
                values: new object[,]
                {
                    { new Guid("00e66ea2-12fd-4b23-bc30-27cbc3ffe265"), new Guid("ac913815-87c6-42d1-b6db-117bc5f4f6d1"), "Prescription for appointment 5", "2025-05-07" },
                    { new Guid("00f5060f-4fa0-4d8c-9340-12fa671f814e"), new Guid("57b4a80f-9c3a-4175-b035-5727cb7765db"), "Prescription for appointment 8", "2025-05-07" },
                    { new Guid("0126b8bb-90c2-43fc-a169-61fe0f9e2447"), new Guid("b6b3948e-a32a-45f5-bc54-58af7bdadffb"), "Prescription for appointment 16", "2025-05-07" },
                    { new Guid("035734dc-8fd0-4d55-8d8b-ec3e18fdea28"), new Guid("015e7bb3-ffd7-4005-a065-6e569a88d164"), "Prescription for appointment 3", "2025-05-07" },
                    { new Guid("0499a258-ab16-4497-970d-c3c212aa171c"), new Guid("2a578a1a-2ff0-449e-ab22-6bc1db27ee0f"), "Prescription for appointment 15", "2025-05-07" },
                    { new Guid("08605609-32d1-43ac-97a3-7b3f289e617a"), new Guid("b0cd02f7-a2ba-4306-b027-03b5f7e57bb2"), "Prescription for appointment 11", "2025-05-07" },
                    { new Guid("0d965a9c-85ed-4d36-b2ec-529a3f746224"), new Guid("7990b2a1-8e83-489c-b166-bd3fce7d15dc"), "Prescription for appointment 11", "2025-05-07" },
                    { new Guid("0edaae34-95f5-47fd-9211-4fc65b3e7ab9"), new Guid("c5cb6a03-b45b-4a55-8531-953556bdb446"), "Prescription for appointment 8", "2025-05-07" },
                    { new Guid("12dab4ef-f08a-4513-a610-356d280c5fef"), new Guid("c9fbdb9b-ba8b-49c5-9871-5f0937729fd0"), "Prescription for appointment 6", "2025-05-07" },
                    { new Guid("1b738595-f8e4-4a2f-8b88-e9f7484f91b6"), new Guid("17256834-9436-40e5-8b20-eb03cbd8d3ce"), "Prescription for appointment 11", "2025-05-07" },
                    { new Guid("1bc4a96b-2a0b-4836-875f-a7ab4544b527"), new Guid("dba996c3-5f56-4b04-98e1-7ec107a8a7e2"), "Prescription for appointment 20", "2025-05-07" },
                    { new Guid("1e840095-167f-41b3-8e25-b477dd6e474c"), new Guid("153b8437-8550-495a-8e8e-df645628f4fc"), "Prescription for appointment 18", "2025-05-07" },
                    { new Guid("1f6a8abf-e930-490b-ba0a-e58c384d22df"), new Guid("6fd86de2-9da1-4d86-8e9d-202cad3c4046"), "Prescription for appointment 1", "2025-05-07" },
                    { new Guid("25dbed9d-21d4-401d-b8d6-7c2f25cf7937"), new Guid("d2b81e1b-dcca-456d-b6dc-74d25b182ca2"), "Prescription for appointment 3", "2025-05-07" },
                    { new Guid("2e215820-063d-4bf8-a12e-701c5f2e6b6f"), new Guid("560899c5-a623-44c5-adc6-f6b178905aab"), "Prescription for appointment 13", "2025-05-07" },
                    { new Guid("2eb09604-84b8-42de-b1c0-113bd2e91ed2"), new Guid("2d4a70b8-092c-4956-9f42-2ca3932ccd4d"), "Prescription for appointment 7", "2025-05-07" },
                    { new Guid("2f5aed7c-b952-46ff-a481-c71fad0e5295"), new Guid("a1625d86-8ce3-4b58-bb47-f59335b7f5b4"), "Prescription for appointment 10", "2025-05-07" },
                    { new Guid("2f84c301-8944-4196-b763-2e1564f555b9"), new Guid("21ef9f10-0638-46d8-849e-843f0f2fe0c3"), "Prescription for appointment 9", "2025-05-07" },
                    { new Guid("3020ffe7-e3f6-4b4f-b2b8-3549ac42e042"), new Guid("18c4ea2e-cb87-4676-84a8-69dc59bd9cd9"), "Prescription for appointment 15", "2025-05-07" },
                    { new Guid("353bb4b8-c52a-4d86-b34a-23288b8711f4"), new Guid("173e3207-a5b6-4e33-8101-9e6deb75de20"), "Prescription for appointment 19", "2025-05-07" },
                    { new Guid("36fc1698-dcf8-4197-8c10-67a8d5f6bc79"), new Guid("e71afc49-98fd-4d8b-9cae-2bf621bf0393"), "Prescription for appointment 16", "2025-05-07" },
                    { new Guid("3c45b01e-6861-4446-9b26-cf015fb090ca"), new Guid("b3cb0a58-2ae1-4cff-b44e-06dff115f68b"), "Prescription for appointment 14", "2025-05-07" },
                    { new Guid("3de4c5a9-97a0-4758-add9-8c0db72a6f85"), new Guid("34d85870-646e-47f9-9ba7-7f054588b21d"), "Prescription for appointment 19", "2025-05-07" },
                    { new Guid("3dfe00c7-0558-4d96-872f-b353f0096a9e"), new Guid("8dd0b9f1-8b05-4801-9fa0-1ccdfeb5e1c8"), "Prescription for appointment 10", "2025-05-07" },
                    { new Guid("4168e62f-e4fd-4830-9dd8-417acff2dc9f"), new Guid("fc7049e9-de17-43b4-874f-6237c56166ee"), "Prescription for appointment 3", "2025-05-07" },
                    { new Guid("45176741-292e-4fd9-87ff-2abac8a2cff3"), new Guid("30838968-64ee-42b1-b228-bdb7173dd928"), "Prescription for appointment 4", "2025-05-07" },
                    { new Guid("475be487-4334-4311-a7da-8ce0bcbe532e"), new Guid("88519ed1-cbfb-4caa-946e-d9db67dd82a8"), "Prescription for appointment 17", "2025-05-07" },
                    { new Guid("4899cf69-fe1c-41cf-947b-24d78a7352a3"), new Guid("3f7b3f01-0e40-4341-82ac-5e4601e49698"), "Prescription for appointment 18", "2025-05-07" },
                    { new Guid("55a22641-0e63-4264-a041-000544327da7"), new Guid("c3c40936-bc11-44ab-bf25-4f72b48deb99"), "Prescription for appointment 1", "2025-05-07" },
                    { new Guid("5d010f4d-4c7e-4be3-80c8-8a767b07189f"), new Guid("97090fff-1582-4cfa-8966-bd408e7109a8"), "Prescription for appointment 6", "2025-05-07" },
                    { new Guid("5d4dcb38-fd08-4fbe-88bf-72354316a33d"), new Guid("05e479d8-47d0-40c2-9ad4-c39584c4b3a7"), "Prescription for appointment 15", "2025-05-07" },
                    { new Guid("610423a7-c01f-47a1-b554-db2368130cd6"), new Guid("fd9921e2-df3d-4c5e-a45a-ff51a0a9dbfe"), "Prescription for appointment 14", "2025-05-07" },
                    { new Guid("67cf3cf0-980f-487a-adb1-c2ecde425617"), new Guid("c59d10a8-011b-4426-8085-8e16853441fa"), "Prescription for appointment 6", "2025-05-07" },
                    { new Guid("6b3afa48-e1cf-43b8-a8c5-5c6a51137e28"), new Guid("63f5339a-208e-42de-85fc-22a2d9c32688"), "Prescription for appointment 5", "2025-05-07" },
                    { new Guid("6b4c24e9-7633-48da-90e5-84d9528e4f08"), new Guid("4ca516e3-88f8-4536-b761-0492b2ef59a3"), "Prescription for appointment 9", "2025-05-07" },
                    { new Guid("6d2e55aa-86fe-4354-a27c-22933b88c29d"), new Guid("ce3ac501-f3e0-48b5-a247-3c73c3c9db4d"), "Prescription for appointment 7", "2025-05-07" },
                    { new Guid("7179c26c-5fc7-4014-ba72-cf7c326182fa"), new Guid("40171138-23e3-48bf-9c7d-bbd981e271fd"), "Prescription for appointment 12", "2025-05-07" },
                    { new Guid("7b794e73-6716-4707-b6a4-d5bb137accf0"), new Guid("81384609-03df-4bd7-a2f7-8c29e8ccf403"), "Prescription for appointment 16", "2025-05-07" },
                    { new Guid("7bc2737d-bce2-41b0-93ea-371f9dc6783c"), new Guid("9bd16afe-10e2-4320-849d-4f3e6431ad7f"), "Prescription for appointment 17", "2025-05-07" },
                    { new Guid("7d2dedf8-e18a-4620-a10b-6a7d5d6ec1be"), new Guid("b5f8c936-32f5-4982-96a0-1717e9fe1978"), "Prescription for appointment 4", "2025-05-07" },
                    { new Guid("83fa100a-5686-4b85-b738-a569cb86e59f"), new Guid("99848b53-f1cc-4df2-8e54-6a60e4b787ed"), "Prescription for appointment 18", "2025-05-07" },
                    { new Guid("853aca02-247e-4957-ae09-6e8172aebafb"), new Guid("1cd77978-f6cb-429f-a731-2dc4d568e1fa"), "Prescription for appointment 3", "2025-05-07" },
                    { new Guid("86393bc3-db4f-4f62-8657-dac182f8d328"), new Guid("5c0f49ea-8497-4ac3-bbaa-834dca0e0b81"), "Prescription for appointment 20", "2025-05-07" },
                    { new Guid("87365d54-f082-4c30-aa67-3afe6ab04d5c"), new Guid("fc0a0abe-e6e4-42bc-8219-a782e80a6431"), "Prescription for appointment 7", "2025-05-07" },
                    { new Guid("8c19d815-a3e5-4ba8-84fa-dd75af0762c9"), new Guid("60b18edc-6897-4d51-8574-4ba7168a8679"), "Prescription for appointment 17", "2025-05-07" },
                    { new Guid("94460c56-b636-419a-8fe4-1fdd8755a297"), new Guid("03354eef-3926-4477-873c-962723c10dd5"), "Prescription for appointment 4", "2025-05-07" },
                    { new Guid("95bd1eee-588b-4664-994c-0c7531328078"), new Guid("6d312cd9-3151-46f2-adef-2eaf36c4b5d5"), "Prescription for appointment 13", "2025-05-07" },
                    { new Guid("9bd9ca8e-4c06-43b5-a92f-3b6ddc8f33c1"), new Guid("0657d184-5e0a-4784-a757-cdc02dd8c63d"), "Prescription for appointment 6", "2025-05-07" },
                    { new Guid("9d44fb66-592a-438f-bb2f-623bc8630352"), new Guid("95038ddc-ea4b-408c-9102-e72be2d5dd9d"), "Prescription for appointment 10", "2025-05-07" },
                    { new Guid("a36883a8-2e28-474d-b269-d63f561e2d3e"), new Guid("74ad7ab3-b9c2-488d-b801-885bd8983c17"), "Prescription for appointment 14", "2025-05-07" },
                    { new Guid("a4321f02-b812-47bb-8cfc-dadf1a6b866f"), new Guid("2925082e-ff72-41d2-b7fc-4e6294c1e30f"), "Prescription for appointment 2", "2025-05-07" },
                    { new Guid("a51b7676-889f-4a14-8edd-8da3dbd9ea7a"), new Guid("05c44080-42de-43b3-86b4-b77d4ed78b28"), "Prescription for appointment 1", "2025-05-07" },
                    { new Guid("abbedacf-e1cc-49ba-b969-b552261f7146"), new Guid("e172699b-aa2f-46e7-b6b5-50208dd8b65e"), "Prescription for appointment 5", "2025-05-07" },
                    { new Guid("ade9b5ba-5407-4697-bb5d-707014fdf013"), new Guid("34ec8bbe-7c06-47f6-a078-fd5c01a85edc"), "Prescription for appointment 18", "2025-05-07" },
                    { new Guid("aff3607c-d5ad-4806-8fbf-4cbbbbf459e9"), new Guid("65c9d7e9-500d-4c45-9642-2340a842a072"), "Prescription for appointment 1", "2025-05-07" },
                    { new Guid("b5f0b48d-3d54-485b-9d46-65de7eed9ee9"), new Guid("900d49f4-b404-4dad-9917-e88a99a803cb"), "Prescription for appointment 9", "2025-05-07" },
                    { new Guid("b7265ef3-1399-483e-9bac-116a54ccbd59"), new Guid("47025ba5-3143-4c08-a0ff-08e0467e103e"), "Prescription for appointment 17", "2025-05-07" },
                    { new Guid("b7d9f9b2-3be8-453a-8163-2165c8da3845"), new Guid("858a84c8-af60-4bd9-9eb3-901f2f919881"), "Prescription for appointment 10", "2025-05-07" },
                    { new Guid("bbf7cf15-337e-4a72-a4d3-becff27cdeab"), new Guid("20e5aad4-5e05-4938-aa46-50489184b303"), "Prescription for appointment 12", "2025-05-07" },
                    { new Guid("bc4479e8-7f14-420e-b963-16285a359be4"), new Guid("d0d6354c-6260-495e-8dc6-397cebb2847e"), "Prescription for appointment 8", "2025-05-07" },
                    { new Guid("c12e90e6-29bb-4061-b77e-46b92d90f973"), new Guid("1faf5614-12b5-4ac5-83ba-c99f1417b4b9"), "Prescription for appointment 5", "2025-05-07" },
                    { new Guid("c214933b-6510-47bb-955d-c1a8dd9b119a"), new Guid("7fbe2f4e-84f1-4924-a080-5edba37d0066"), "Prescription for appointment 19", "2025-05-07" },
                    { new Guid("c23f3765-5d76-4303-857c-01120304327c"), new Guid("dcc79725-db93-43ed-936d-391ad7ac5308"), "Prescription for appointment 12", "2025-05-07" },
                    { new Guid("ca204fa8-40f4-40d4-9677-4ea421a94b37"), new Guid("e4e1eddf-11dd-42e8-9b0a-ebc2fe581956"), "Prescription for appointment 2", "2025-05-07" },
                    { new Guid("cd412533-74d4-4a75-8dd3-dfa31a52aa5e"), new Guid("1eff2bee-40a9-4857-af3d-36bb510b439a"), "Prescription for appointment 4", "2025-05-07" },
                    { new Guid("ce7c29f9-362e-4d79-a744-026be43990b6"), new Guid("81f0863e-c839-40db-82c4-13eb4a9653eb"), "Prescription for appointment 16", "2025-05-07" },
                    { new Guid("d71ceeac-1aeb-4cd5-b017-1fd91e5de945"), new Guid("e9b75747-ef06-46f6-922a-bf434c5fa205"), "Prescription for appointment 2", "2025-05-07" },
                    { new Guid("d837abda-bb7b-4176-b671-d5dff8b25753"), new Guid("519f535a-bd8b-4a7b-b322-9ba59b339fce"), "Prescription for appointment 11", "2025-05-07" },
                    { new Guid("d9be3386-4c03-407f-acf4-eda8432e382e"), new Guid("3ea60b2a-aff2-44ec-a09f-475bbe37a716"), "Prescription for appointment 19", "2025-05-07" },
                    { new Guid("dce29732-903e-4854-95f7-825395bf92ae"), new Guid("49034bc6-63ba-4331-9078-08d11a858c38"), "Prescription for appointment 13", "2025-05-07" },
                    { new Guid("e1f304d9-88cd-43b2-8118-34cf5a13bbc3"), new Guid("756054e7-2d39-49dd-8ecb-e4394549e46f"), "Prescription for appointment 15", "2025-05-07" },
                    { new Guid("e22ee722-1a5b-44f4-afe9-bdbf8896d219"), new Guid("8b0c107e-6664-42f5-ac32-248b4179bc5b"), "Prescription for appointment 8", "2025-05-07" },
                    { new Guid("e6a7dc2c-8110-45c3-b820-cea154bc11f5"), new Guid("4b3a2556-5f81-4849-a6b3-54fa16e8b634"), "Prescription for appointment 20", "2025-05-07" },
                    { new Guid("e7471e3c-2aac-4be9-81b5-7bb6e5209843"), new Guid("b8d2a62c-a554-442d-b9a4-df62ac68c04c"), "Prescription for appointment 9", "2025-05-07" },
                    { new Guid("e7e09daf-be64-424d-9b15-287e88b90800"), new Guid("53782d02-3dab-4cfb-9f48-1de6c103fd44"), "Prescription for appointment 20", "2025-05-07" },
                    { new Guid("e85daa83-ab13-44ff-b40d-21e01b01f487"), new Guid("c8e8f853-99ed-4005-811c-c1bd71d86967"), "Prescription for appointment 2", "2025-05-07" },
                    { new Guid("ef5528e4-0978-48a6-baec-f479f34a6078"), new Guid("48e8ad33-b152-4265-b0b0-9de26d6909e6"), "Prescription for appointment 13", "2025-05-07" },
                    { new Guid("f41130c5-05af-4a85-bcfd-03cf04f64a82"), new Guid("034e2bb7-d05c-4c26-bd26-9a9d49270c21"), "Prescription for appointment 14", "2025-05-07" },
                    { new Guid("f7da57e6-352a-47ed-975a-4398455b562c"), new Guid("12ccec37-49c5-4c49-a535-64478932c786"), "Prescription for appointment 12", "2025-05-07" },
                    { new Guid("faff4505-2931-47f3-8328-da082853d94d"), new Guid("4877e3d6-8e31-4c11-9186-e283e8a0f247"), "Prescription for appointment 7", "2025-05-07" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "08cd7068-9520-4edd-b2b7-96a5726ec51f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675b578c-8739-4b1b-a706-816fb14910bd", "0f240ee8-dc2e-489d-9ea6-97bc5e4a0d04" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "13643700-eeff-4cc4-845d-cb688e53011b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "2811a265-18aa-45a5-bfa4-69259d61b079" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "3434b72d-fea4-470c-90b9-dbbcb0ba9e2a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675b578c-8739-4b1b-a706-816fb14910bd", "37204e01-945c-4b14-89a7-638d086e09bb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "381b6456-0d17-4c3d-8b91-95af19862e97" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "43010734-d5c2-4160-838a-6aaf9a30ce0d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "4a2c0588-dcdd-4a21-94bb-85131b0e9dda" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "509a2dc0-84b2-44d8-a783-a8d3449d3a2a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "596ae101-2591-4ba0-93bc-30f3c5c4377c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "693a04b2-9757-430a-bf45-ef3d21d6b124" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "6af6f0c1-3f9a-4866-82dc-cafedbd10695" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "6edd8c29-c317-4d3f-9400-93a2fe0e22bd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "6f988f34-6f63-40b0-99c1-709d4d980239" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "6fdc9bc7-391e-4773-8099-7b05fd51dfbc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "75431e40-761a-4f8c-a976-a29fc506843a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "7b054e61-79be-40a7-8daf-f64b0c316026" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "7efc3472-bafc-46db-82aa-9d6441b83751" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "816cf552-1697-4f1c-93b0-3b0808ac1af7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "831b4b2d-854c-426e-adc2-5639c9d2ac2c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "8514ea90-6379-46cf-96e4-fc21a9cc611a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "86c6a966-5368-4f82-8dfd-c502d181c8d8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "8c4d1bfc-d3df-42d5-85b4-bfdde65c0a8b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "8d83ceb2-41a9-4e9f-b2c1-eb7af14c068b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "8e260ae2-7d2c-424a-8d4d-a7878a1fe9fb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "91a639d9-37e2-418c-8db3-5f4d614c13a2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "93f02f2a-80c4-4196-875a-8ca3d78bdfaf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "9410571e-0022-4ad7-a854-b23ade4972ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "988f5681-bb05-4cf1-aa5b-c776376920d9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "a49e8aac-965e-4831-b7df-4a2647368547" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "ababc1fd-daa3-4f59-b4b5-2bd9acda149b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "b03113fb-d317-45e5-be95-eb84a9c3185b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "b147561b-f1fe-40e6-a40e-cbc4cc0a316c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "bc601296-b901-46bd-a22e-595a3ba788d6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "bef24a00-dd40-4348-a2b4-2b5c8a64675b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "d6e00172-40e4-471c-9e08-45c36a05ea74" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "d78c1e65-d3c0-434b-ac70-6309295f02e6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "d87dbe8a-03b5-455f-a755-6af236edb61b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675b578c-8739-4b1b-a706-816fb14910bd", "da197622-64d7-4c38-81fd-c55929c4bb67" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "de6b3bed-f339-48e8-9429-be421115d9d2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675b578c-8739-4b1b-a706-816fb14910bd", "e22ad530-5f0b-4997-a3e6-6f6d519c475d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675b578c-8739-4b1b-a706-816fb14910bd", "f1a97b37-4f92-46e7-a772-2303470d621f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "f500b358-1322-45fb-89dc-22a4134de95b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "ff71eaf9-eb41-4284-92f9-0dc05fec882f" });

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("00e66ea2-12fd-4b23-bc30-27cbc3ffe265"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("00f5060f-4fa0-4d8c-9340-12fa671f814e"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("0126b8bb-90c2-43fc-a169-61fe0f9e2447"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("035734dc-8fd0-4d55-8d8b-ec3e18fdea28"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("0499a258-ab16-4497-970d-c3c212aa171c"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("08605609-32d1-43ac-97a3-7b3f289e617a"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("0d965a9c-85ed-4d36-b2ec-529a3f746224"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("0edaae34-95f5-47fd-9211-4fc65b3e7ab9"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("12dab4ef-f08a-4513-a610-356d280c5fef"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("1b738595-f8e4-4a2f-8b88-e9f7484f91b6"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("1bc4a96b-2a0b-4836-875f-a7ab4544b527"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("1e840095-167f-41b3-8e25-b477dd6e474c"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("1f6a8abf-e930-490b-ba0a-e58c384d22df"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("25dbed9d-21d4-401d-b8d6-7c2f25cf7937"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("2e215820-063d-4bf8-a12e-701c5f2e6b6f"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("2eb09604-84b8-42de-b1c0-113bd2e91ed2"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("2f5aed7c-b952-46ff-a481-c71fad0e5295"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("2f84c301-8944-4196-b763-2e1564f555b9"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("3020ffe7-e3f6-4b4f-b2b8-3549ac42e042"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("353bb4b8-c52a-4d86-b34a-23288b8711f4"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("36fc1698-dcf8-4197-8c10-67a8d5f6bc79"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("3c45b01e-6861-4446-9b26-cf015fb090ca"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("3de4c5a9-97a0-4758-add9-8c0db72a6f85"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("3dfe00c7-0558-4d96-872f-b353f0096a9e"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("4168e62f-e4fd-4830-9dd8-417acff2dc9f"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("45176741-292e-4fd9-87ff-2abac8a2cff3"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("475be487-4334-4311-a7da-8ce0bcbe532e"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("4899cf69-fe1c-41cf-947b-24d78a7352a3"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("55a22641-0e63-4264-a041-000544327da7"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("5d010f4d-4c7e-4be3-80c8-8a767b07189f"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("5d4dcb38-fd08-4fbe-88bf-72354316a33d"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("610423a7-c01f-47a1-b554-db2368130cd6"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("67cf3cf0-980f-487a-adb1-c2ecde425617"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("6b3afa48-e1cf-43b8-a8c5-5c6a51137e28"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("6b4c24e9-7633-48da-90e5-84d9528e4f08"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("6d2e55aa-86fe-4354-a27c-22933b88c29d"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("7179c26c-5fc7-4014-ba72-cf7c326182fa"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("7b794e73-6716-4707-b6a4-d5bb137accf0"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("7bc2737d-bce2-41b0-93ea-371f9dc6783c"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("7d2dedf8-e18a-4620-a10b-6a7d5d6ec1be"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("83fa100a-5686-4b85-b738-a569cb86e59f"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("853aca02-247e-4957-ae09-6e8172aebafb"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("86393bc3-db4f-4f62-8657-dac182f8d328"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("87365d54-f082-4c30-aa67-3afe6ab04d5c"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("8c19d815-a3e5-4ba8-84fa-dd75af0762c9"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("94460c56-b636-419a-8fe4-1fdd8755a297"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("95bd1eee-588b-4664-994c-0c7531328078"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("9bd9ca8e-4c06-43b5-a92f-3b6ddc8f33c1"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("9d44fb66-592a-438f-bb2f-623bc8630352"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("a36883a8-2e28-474d-b269-d63f561e2d3e"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("a4321f02-b812-47bb-8cfc-dadf1a6b866f"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("a51b7676-889f-4a14-8edd-8da3dbd9ea7a"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("abbedacf-e1cc-49ba-b969-b552261f7146"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("ade9b5ba-5407-4697-bb5d-707014fdf013"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("aff3607c-d5ad-4806-8fbf-4cbbbbf459e9"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("b5f0b48d-3d54-485b-9d46-65de7eed9ee9"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("b7265ef3-1399-483e-9bac-116a54ccbd59"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("b7d9f9b2-3be8-453a-8163-2165c8da3845"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("bbf7cf15-337e-4a72-a4d3-becff27cdeab"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("bc4479e8-7f14-420e-b963-16285a359be4"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("c12e90e6-29bb-4061-b77e-46b92d90f973"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("c214933b-6510-47bb-955d-c1a8dd9b119a"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("c23f3765-5d76-4303-857c-01120304327c"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("ca204fa8-40f4-40d4-9677-4ea421a94b37"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("cd412533-74d4-4a75-8dd3-dfa31a52aa5e"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("ce7c29f9-362e-4d79-a744-026be43990b6"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("d71ceeac-1aeb-4cd5-b017-1fd91e5de945"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("d837abda-bb7b-4176-b671-d5dff8b25753"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("d9be3386-4c03-407f-acf4-eda8432e382e"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("dce29732-903e-4854-95f7-825395bf92ae"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("e1f304d9-88cd-43b2-8118-34cf5a13bbc3"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("e22ee722-1a5b-44f4-afe9-bdbf8896d219"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("e6a7dc2c-8110-45c3-b820-cea154bc11f5"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("e7471e3c-2aac-4be9-81b5-7bb6e5209843"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("e7e09daf-be64-424d-9b15-287e88b90800"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("e85daa83-ab13-44ff-b40d-21e01b01f487"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("ef5528e4-0978-48a6-baec-f479f34a6078"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("f41130c5-05af-4a85-bcfd-03cf04f64a82"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("f7da57e6-352a-47ed-975a-4398455b562c"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("faff4505-2931-47f3-8328-da082853d94d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("015e7bb3-ffd7-4005-a065-6e569a88d164"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("03354eef-3926-4477-873c-962723c10dd5"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("034e2bb7-d05c-4c26-bd26-9a9d49270c21"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("05c44080-42de-43b3-86b4-b77d4ed78b28"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("05e479d8-47d0-40c2-9ad4-c39584c4b3a7"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("0657d184-5e0a-4784-a757-cdc02dd8c63d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("12ccec37-49c5-4c49-a535-64478932c786"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("153b8437-8550-495a-8e8e-df645628f4fc"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("17256834-9436-40e5-8b20-eb03cbd8d3ce"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("173e3207-a5b6-4e33-8101-9e6deb75de20"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("18c4ea2e-cb87-4676-84a8-69dc59bd9cd9"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1cd77978-f6cb-429f-a731-2dc4d568e1fa"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1eff2bee-40a9-4857-af3d-36bb510b439a"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1faf5614-12b5-4ac5-83ba-c99f1417b4b9"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("20e5aad4-5e05-4938-aa46-50489184b303"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("21ef9f10-0638-46d8-849e-843f0f2fe0c3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("2925082e-ff72-41d2-b7fc-4e6294c1e30f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("2a578a1a-2ff0-449e-ab22-6bc1db27ee0f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("2d4a70b8-092c-4956-9f42-2ca3932ccd4d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("30838968-64ee-42b1-b228-bdb7173dd928"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("34d85870-646e-47f9-9ba7-7f054588b21d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("34ec8bbe-7c06-47f6-a078-fd5c01a85edc"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("3ea60b2a-aff2-44ec-a09f-475bbe37a716"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("3f7b3f01-0e40-4341-82ac-5e4601e49698"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("40171138-23e3-48bf-9c7d-bbd981e271fd"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("47025ba5-3143-4c08-a0ff-08e0467e103e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("4877e3d6-8e31-4c11-9186-e283e8a0f247"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("48e8ad33-b152-4265-b0b0-9de26d6909e6"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("49034bc6-63ba-4331-9078-08d11a858c38"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("4b3a2556-5f81-4849-a6b3-54fa16e8b634"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("4ca516e3-88f8-4536-b761-0492b2ef59a3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("519f535a-bd8b-4a7b-b322-9ba59b339fce"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("53782d02-3dab-4cfb-9f48-1de6c103fd44"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("560899c5-a623-44c5-adc6-f6b178905aab"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("57b4a80f-9c3a-4175-b035-5727cb7765db"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("5c0f49ea-8497-4ac3-bbaa-834dca0e0b81"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("60b18edc-6897-4d51-8574-4ba7168a8679"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("63f5339a-208e-42de-85fc-22a2d9c32688"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("65c9d7e9-500d-4c45-9642-2340a842a072"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("6d312cd9-3151-46f2-adef-2eaf36c4b5d5"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("6fd86de2-9da1-4d86-8e9d-202cad3c4046"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("74ad7ab3-b9c2-488d-b801-885bd8983c17"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("756054e7-2d39-49dd-8ecb-e4394549e46f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("7990b2a1-8e83-489c-b166-bd3fce7d15dc"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("7fbe2f4e-84f1-4924-a080-5edba37d0066"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("81384609-03df-4bd7-a2f7-8c29e8ccf403"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("81f0863e-c839-40db-82c4-13eb4a9653eb"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("858a84c8-af60-4bd9-9eb3-901f2f919881"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("88519ed1-cbfb-4caa-946e-d9db67dd82a8"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("8b0c107e-6664-42f5-ac32-248b4179bc5b"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("8dd0b9f1-8b05-4801-9fa0-1ccdfeb5e1c8"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("900d49f4-b404-4dad-9917-e88a99a803cb"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("95038ddc-ea4b-408c-9102-e72be2d5dd9d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("97090fff-1582-4cfa-8966-bd408e7109a8"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("99848b53-f1cc-4df2-8e54-6a60e4b787ed"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9bd16afe-10e2-4320-849d-4f3e6431ad7f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("a1625d86-8ce3-4b58-bb47-f59335b7f5b4"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("ac913815-87c6-42d1-b6db-117bc5f4f6d1"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b0cd02f7-a2ba-4306-b027-03b5f7e57bb2"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b3cb0a58-2ae1-4cff-b44e-06dff115f68b"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b5f8c936-32f5-4982-96a0-1717e9fe1978"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b6b3948e-a32a-45f5-bc54-58af7bdadffb"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b8d2a62c-a554-442d-b9a4-df62ac68c04c"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c3c40936-bc11-44ab-bf25-4f72b48deb99"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c59d10a8-011b-4426-8085-8e16853441fa"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c5cb6a03-b45b-4a55-8531-953556bdb446"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c8e8f853-99ed-4005-811c-c1bd71d86967"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c9fbdb9b-ba8b-49c5-9871-5f0937729fd0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("ce3ac501-f3e0-48b5-a247-3c73c3c9db4d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("d0d6354c-6260-495e-8dc6-397cebb2847e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("d2b81e1b-dcca-456d-b6dc-74d25b182ca2"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("dba996c3-5f56-4b04-98e1-7ec107a8a7e2"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("dcc79725-db93-43ed-936d-391ad7ac5308"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e172699b-aa2f-46e7-b6b5-50208dd8b65e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e4e1eddf-11dd-42e8-9b0a-ebc2fe581956"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e71afc49-98fd-4d8b-9cae-2bf621bf0393"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e9b75747-ef06-46f6-922a-bf434c5fa205"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("fc0a0abe-e6e4-42bc-8219-a782e80a6431"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("fc7049e9-de17-43b4-874f-6237c56166ee"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("fd9921e2-df3d-4c5e-a45a-ff51a0a9dbfe"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4a2c0588-dcdd-4a21-94bb-85131b0e9dda");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8514ea90-6379-46cf-96e4-fc21a9cc611a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91a639d9-37e2-418c-8db3-5f4d614c13a2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93f02f2a-80c4-4196-875a-8ca3d78bdfaf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ababc1fd-daa3-4f59-b4b5-2bd9acda149b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08cd7068-9520-4edd-b2b7-96a5726ec51f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f240ee8-dc2e-489d-9ea6-97bc5e4a0d04");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2811a265-18aa-45a5-bfa4-69259d61b079");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37204e01-945c-4b14-89a7-638d086e09bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "381b6456-0d17-4c3d-8b91-95af19862e97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "693a04b2-9757-430a-bf45-ef3d21d6b124");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6edd8c29-c317-4d3f-9400-93a2fe0e22bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6fdc9bc7-391e-4773-8099-7b05fd51dfbc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "831b4b2d-854c-426e-adc2-5639c9d2ac2c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9410571e-0022-4ad7-a854-b23ade4972ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "988f5681-bb05-4cf1-aa5b-c776376920d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a49e8aac-965e-4831-b7df-4a2647368547");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b03113fb-d317-45e5-be95-eb84a9c3185b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b147561b-f1fe-40e6-a40e-cbc4cc0a316c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bef24a00-dd40-4348-a2b4-2b5c8a64675b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d6e00172-40e4-471c-9e08-45c36a05ea74");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d87dbe8a-03b5-455f-a755-6af236edb61b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "da197622-64d7-4c38-81fd-c55929c4bb67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e22ad530-5f0b-4997-a3e6-6f6d519c475d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1a97b37-4f92-46e7-a772-2303470d621f");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("00d583ad-a449-49bd-804a-ee5625d61201"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1366939d-b9c4-4ed1-aa12-96c67176e078"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1a0200fd-db8e-412f-a610-0c9e6c8c20bf"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("26e35c4f-5c73-4ca5-b4ed-51815cc96e55"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("2d7aae7e-d64a-4ac6-97c9-841c1bf9682b"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("465891ed-ea0e-4aba-94a6-2538a6c0e992"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("586502e2-1d49-457f-a2f9-dcde93f5d886"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("6bf06de4-e0d5-4601-a523-178e630e1e9f"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("70626a5e-2119-407a-a533-7e9ade00009e"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7ae48af0-d30f-450f-9946-d3db1ae451ff"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7ba550de-c044-4e86-ab48-7ce54a637bbe"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("841483fb-57a6-435a-ad4d-96ab45a9c85c"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("84369c4e-cb6a-4e97-a7c0-a5a34f17257c"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("94906be6-9e2a-4d5e-9a03-b1d10b24e7d5"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("9cd6e37d-e4d1-43eb-a6bd-da6aca3a8597"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("b64e4a42-0971-4e61-9039-5cdfcc915e14"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("daaab8c8-97e5-48f9-85d7-70b3d7d55e87"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("debc34e9-1fb3-4ba2-961f-26196b1d0a44"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e76c3781-588f-460f-95f0-f7ca0b6d6a3a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("f6dd720c-aa35-4e9c-b41c-0e49426367f4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13643700-eeff-4cc4-845d-cb688e53011b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3434b72d-fea4-470c-90b9-dbbcb0ba9e2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "43010734-d5c2-4160-838a-6aaf9a30ce0d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "509a2dc0-84b2-44d8-a783-a8d3449d3a2a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "596ae101-2591-4ba0-93bc-30f3c5c4377c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6af6f0c1-3f9a-4866-82dc-cafedbd10695");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f988f34-6f63-40b0-99c1-709d4d980239");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75431e40-761a-4f8c-a976-a29fc506843a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7b054e61-79be-40a7-8daf-f64b0c316026");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7efc3472-bafc-46db-82aa-9d6441b83751");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "816cf552-1697-4f1c-93b0-3b0808ac1af7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86c6a966-5368-4f82-8dfd-c502d181c8d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c4d1bfc-d3df-42d5-85b4-bfdde65c0a8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d83ceb2-41a9-4e9f-b2c1-eb7af14c068b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e260ae2-7d2c-424a-8d4d-a7878a1fe9fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bc601296-b901-46bd-a22e-595a3ba788d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d78c1e65-d3c0-434b-ac70-6309295f02e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de6b3bed-f339-48e8-9429-be421115d9d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f500b358-1322-45fb-89dc-22a4134de95b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ff71eaf9-eb41-4284-92f9-0dc05fec882f");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0b2a0b3f-335d-407a-9eb5-1f2df8757ac1", 0, "8820b6bd-6141-47d6-b48f-1d680fb20d93", "patient9@clinic.com", true, false, null, "PATIENT9@CLINIC.COM", "PATIENT9@CLINIC.COM", "AQAAAAIAAYagAAAAEORNjklkH+TwiYbB+5ydOnSX2Zv0l0ePRVV3+bfV4hy9sUhYqeIWc3rHepPNSCtKKA==", "01000000009", true, "4edeb960-8786-4e68-a1f1-3a1928eb2dd2", false, "patient9@clinic.com" },
                    { "0cc0fd04-1442-43ff-bbf4-da14d44809f7", 0, "1ac174e6-4d48-4b7c-b493-a9950755e565", "patient15@clinic.com", true, false, null, "PATIENT15@CLINIC.COM", "PATIENT15@CLINIC.COM", "AQAAAAIAAYagAAAAEOpuQEIJbvI9gEbou/O7on9wHmRNg8ITAJnOq/Qeaktd/MnztROd/eyZ1aXzVpySkg==", "01000000015", true, "b350d9f7-ad4a-4f56-998a-220669424078", false, "patient15@clinic.com" },
                    { "328d7971-00b1-4c1e-ae83-044da79f638c", 0, "9846bf68-b32f-4e5a-819a-3fb633a38863", "doctor3@clinic.com", true, false, null, "DOCTOR3@CLINIC.COM", "DOCTOR3@CLINIC.COM", "AQAAAAIAAYagAAAAEAgXZ7WNqvbuOkx7gD7GNppmNIZJVUyR/DxkgwiSWtz4sjETXygAp0p3YIbxhCjS8w==", "01100000003", true, "ef180e3f-0078-4cb3-9ee1-5af29a7cfce3", false, "doctor3@clinic.com" },
                    { "355d7bff-7157-406a-be14-1f4f41a2f0d0", 0, "4d040c28-4a2d-4f62-b7f1-5a7decea6d4f", "doctor2@clinic.com", true, false, null, "DOCTOR2@CLINIC.COM", "DOCTOR2@CLINIC.COM", "AQAAAAIAAYagAAAAEIAzsfu2NBv9c+tYMwGEG5CNyhHBHqnhIaIVKdbwhvBIZzRdsNB766pX31eAFUHUfQ==", "01100000002", true, "6c0441af-bcb2-4eb7-82d0-79e1c564db82", false, "doctor2@clinic.com" },
                    { "38df6d89-7ef7-411a-aa56-a79222b5035c", 0, "88aa61ab-fc4a-4680-8d81-d3d03239c5fe", "doctor14@clinic.com", true, false, null, "DOCTOR14@CLINIC.COM", "DOCTOR14@CLINIC.COM", "AQAAAAIAAYagAAAAEOaHJRKk/N6S2ybi3so7d4abyhThcPLPaSfj3YL9DXrRIIP2fQllaSTHpVggW8S9jg==", "01100000014", true, "d9520310-264a-473c-b088-a75b54e117cc", false, "doctor14@clinic.com" },
                    { "39d18d23-ff3b-402c-93fc-3676c4b84cbd", 0, "ac7143fc-30a8-4505-bce0-b408bf73967d", "patient11@clinic.com", true, false, null, "PATIENT11@CLINIC.COM", "PATIENT11@CLINIC.COM", "AQAAAAIAAYagAAAAEMUtGa1vqEVDqZIn5oDYJm9hx+T044mZBDXdiAbd6tX3CB3Ozo2Ya34M53b2lx+dYQ==", "01000000011", true, "dc030c5e-0b8f-4fb3-a3ac-2947293607cd", false, "patient11@clinic.com" },
                    { "3ac0108b-1750-4f96-85a9-fde8ffdda749", 0, "fb629699-d467-4abe-bae7-af8b59daa228", "doctor7@clinic.com", true, false, null, "DOCTOR7@CLINIC.COM", "DOCTOR7@CLINIC.COM", "AQAAAAIAAYagAAAAEOqOhx6bWw64wCIUvHmGKMSDy2KMkNJvLITsZLDHpU74FG3HwUgfnFQPkNwaQNfDww==", "01100000007", true, "1f7e9bff-e47f-40fd-8661-3010da65a84a", false, "doctor7@clinic.com" },
                    { "3da26cb0-5215-44da-bef4-77bcc2b1a71d", 0, "0fe2bf93-4257-46f6-b059-2337f01da684", "doctor6@clinic.com", true, false, null, "DOCTOR6@CLINIC.COM", "DOCTOR6@CLINIC.COM", "AQAAAAIAAYagAAAAED3R2/135WBORtV6rHnwTp8e4Wg9GmcNjbQ4r6yFx0b6neR8xziIvtpK6utPJDc89A==", "01100000006", true, "90c6d633-999d-4275-86b0-59315702d56b", false, "doctor6@clinic.com" },
                    { "43bb0799-23e3-46f2-9130-d5c864d20fb9", 0, "6bfe6cc9-9345-44fb-858a-350389283979", "patient12@clinic.com", true, false, null, "PATIENT12@CLINIC.COM", "PATIENT12@CLINIC.COM", "AQAAAAIAAYagAAAAEC9Dofp6H1cboL79y51ZWatNSMYJCB99qAiJ2bIwUoKvuHZ1p39RN9nfyeJ1w6XQEw==", "01000000012", true, "18275010-986f-438d-83f7-9dcdc8dbde4a", false, "patient12@clinic.com" },
                    { "4f5cc6c7-81d0-48b4-897d-b9bb803b7d01", 0, "ef0602eb-a37d-4cfd-a26b-bfb9df7b7d68", "patient3@clinic.com", true, false, null, "PATIENT3@CLINIC.COM", "PATIENT3@CLINIC.COM", "AQAAAAIAAYagAAAAEIBc0e0MjxuF4PvwYrvuaDPApPmV6M5W2fELQzjRFbz0dEgZ27u8X/plYhFtNGqwDA==", "01000000003", true, "cb84fc6f-7c43-411e-b353-dcb426e8c6bf", false, "patient3@clinic.com" },
                    { "54c7cea8-def6-4dac-8ed2-a9df662d978c", 0, "c05c7e76-2fc0-4b6d-bb2a-7099bc455983", "patient1@clinic.com", true, false, null, "PATIENT1@CLINIC.COM", "PATIENT1@CLINIC.COM", "AQAAAAIAAYagAAAAELM7OlBPKKZadzTdG3bueGfWvI45q7nhilr7/ElzJrTQic8CKrsN04Xkt1OI8Il32Q==", "01000000001", true, "9fc87bf3-4e68-4b0b-b43b-265be6d8a367", false, "patient1@clinic.com" },
                    { "5a3775ae-deee-4d3b-add8-902565287f36", 0, "16909ca5-a232-49de-85d7-ce2ab043b313", "patient10@clinic.com", true, false, null, "PATIENT10@CLINIC.COM", "PATIENT10@CLINIC.COM", "AQAAAAIAAYagAAAAEPDpMhs9373r2hWhKrovcqKANKnIe/kTbWmbEEk90ZigvjEh1kk58AS4BHrgcE5Qyg==", "01000000010", true, "2052806a-efb9-4b1f-838c-ff05852a15e1", false, "patient10@clinic.com" },
                    { "5b822ee5-eb3c-4e24-a44f-c8b71d22cd57", 0, "a33961f2-98f4-4a05-a39f-d8373fc3305a", "doctor15@clinic.com", true, false, null, "DOCTOR15@CLINIC.COM", "DOCTOR15@CLINIC.COM", "AQAAAAIAAYagAAAAEEjvoxfKa+V8dDIxyG0Kl59dc2WTFNXKGer7XIRQ5W/r4uE/vczzV/n37ApghCgWag==", "01100000015", true, "760e71db-ade9-4da9-8030-be4b84e4432a", false, "doctor15@clinic.com" },
                    { "5cde9f9c-e925-4ce1-b5e8-276997f44b57", 0, "bf221986-2bdb-4993-ba18-fc864fd6c0c5", "doctor10@clinic.com", true, false, null, "DOCTOR10@CLINIC.COM", "DOCTOR10@CLINIC.COM", "AQAAAAIAAYagAAAAEAjRXKL6QxGLnjJDFx6JqU5LoX8ts8H8dOSHZul72NdUMVJVD7RY4R6eMyfn6P4zGg==", "01100000010", true, "ae008c35-9dc7-41d8-ba9c-fc4984720a4d", false, "doctor10@clinic.com" },
                    { "628f2987-610f-43f0-abeb-b830479b03d4", 0, "d6179a86-e184-4c7c-9a8c-90bb0cf83660", "doctor11@clinic.com", true, false, null, "DOCTOR11@CLINIC.COM", "DOCTOR11@CLINIC.COM", "AQAAAAIAAYagAAAAEL/tZMDP1AudBxTwe4WvJPOqSTLygX+6pBu+CRySkn3FUzF7htosg+nI4AnF4wxAEQ==", "01100000011", true, "a0d25486-6216-43fb-92be-5b55bd344d86", false, "doctor11@clinic.com" },
                    { "69b95277-1f9b-45e9-87cf-33fce9ef5a5c", 0, "0f250e19-f996-4f99-b311-d8cd866c0bb2", "patient19@clinic.com", true, false, null, "PATIENT19@CLINIC.COM", "PATIENT19@CLINIC.COM", "AQAAAAIAAYagAAAAEKCeLorxo1x5nTQxsxsF47jiNDtkTUdDVsVsyS4qA7/3hdvM03rGFb3DQI4dQgxKog==", "01000000019", true, "35cfdf82-188f-468f-8747-7995de41b51a", false, "patient19@clinic.com" },
                    { "6b718587-f8b4-4e5b-86a6-2cdb71959411", 0, "ba177837-84c3-41bf-812d-b25e65821e3d", "doctor20@clinic.com", true, false, null, "DOCTOR20@CLINIC.COM", "DOCTOR20@CLINIC.COM", "AQAAAAIAAYagAAAAELzlSkYzOl/1ieLhONCLYMmfLx4sJfcd2VTMkGdCJ/94xYomt4Hnm6VYo4VRzqoXiQ==", "01100000020", true, "fd62c343-46c4-4f82-88aa-919354321ef6", false, "doctor20@clinic.com" },
                    { "74401562-e7c7-4448-890f-af9b01dee998", 0, "c156fd62-ba26-4670-ac06-2bb52cb437c2", "doctor13@clinic.com", true, false, null, "DOCTOR13@CLINIC.COM", "DOCTOR13@CLINIC.COM", "AQAAAAIAAYagAAAAEEofCDTWUDMKPkeStlMEozJorgvwcSDjROl3P9Ygrz3YSF6kYPIJUnrLzugAnmelgw==", "01100000013", true, "e298b264-b0a7-49d7-8b62-93b334fa03f1", false, "doctor13@clinic.com" },
                    { "75d6a14b-0b4f-4abf-aca2-265fd6c0cfac", 0, "39321eac-c8de-4119-b631-bb523a267600", "doctor19@clinic.com", true, false, null, "DOCTOR19@CLINIC.COM", "DOCTOR19@CLINIC.COM", "AQAAAAIAAYagAAAAEB/cEoP+nnkDBdLipUucbw+57wErLioxa6sYRegkPde1sAYNOHt+1NpgGVZ5rYsOHg==", "01100000019", true, "33f931e4-1dfb-4388-ab90-44f22be48b89", false, "doctor19@clinic.com" },
                    { "7aadde49-213c-4ea8-94b7-25d4acf487d2", 0, "03945210-bcb3-4fce-9fa5-b9321ad498da", "patient5@clinic.com", true, false, null, "PATIENT5@CLINIC.COM", "PATIENT5@CLINIC.COM", "AQAAAAIAAYagAAAAEEPphXMKghwgN49d+P/iulTo6JnUzIHgV5qNDWpmcy4nsl3UKm2Fbl0FgQgygN72iQ==", "01000000005", true, "d8200c4a-f5fa-4214-b3db-af3a3dfd4b12", false, "patient5@clinic.com" },
                    { "8253e185-3837-4996-a49c-786de1c55b35", 0, "1ca1dc77-c60c-4789-bd2e-60cacbcc0dfc", "patient2@clinic.com", true, false, null, "PATIENT2@CLINIC.COM", "PATIENT2@CLINIC.COM", "AQAAAAIAAYagAAAAEMX2KTYAGfd+42TVfU6qSET8D9WwoLWwkiGSAKmUpEmD9bWZQ3CgXrTUmxeIVWI8zQ==", "01000000002", true, "d115f79c-cee7-4339-8498-12b38c073eaa", false, "patient2@clinic.com" },
                    { "836f43d7-bc60-4d28-8f57-3bc6859c5dea", 0, "5f24898e-e6a4-4b3c-b8af-75661e8445a5", "doctor9@clinic.com", true, false, null, "DOCTOR9@CLINIC.COM", "DOCTOR9@CLINIC.COM", "AQAAAAIAAYagAAAAEGGZ1WGHoYxBK6mu+YYNqHQ5rDTq4qFmtXtPp1wKvRt1wUGBSPImUKkYX9n1b73azQ==", "01100000009", true, "8a64400d-28b9-4075-b435-6498305f92f9", false, "doctor9@clinic.com" },
                    { "8751de00-9e1e-402f-80f3-993617e7574f", 0, "63d7c4ed-448d-4338-8bad-a97d6bf6b34e", "doctor8@clinic.com", true, false, null, "DOCTOR8@CLINIC.COM", "DOCTOR8@CLINIC.COM", "AQAAAAIAAYagAAAAEPGSNCbr1XgztJjYnsy9WMNETsuKDpByPwlb1LDB6fG2CLHk3du2baMz7YpWAHEfgg==", "01100000008", true, "aae6c4de-4828-4d90-8713-23fc815e6739", false, "doctor8@clinic.com" },
                    { "875a481d-ea58-4d71-8dc5-12370b3fc219", 0, "9bb22061-9d9d-4412-90e9-a22b4fa45dc6", "patient20@clinic.com", true, false, null, "PATIENT20@CLINIC.COM", "PATIENT20@CLINIC.COM", "AQAAAAIAAYagAAAAEFEtz2kqmAim0pwdizaG5alQXQcevA68e2wt2lO4YByQn54HsjseHwXJss8oA0rMSA==", "01000000020", true, "1887d96e-4c81-4f18-82ef-cdb79364a59c", false, "patient20@clinic.com" },
                    { "935ec8d4-4db9-4b2c-aac5-25676806c655", 0, "59443536-5459-4d17-9e3b-77718219dbaf", "patient7@clinic.com", true, false, null, "PATIENT7@CLINIC.COM", "PATIENT7@CLINIC.COM", "AQAAAAIAAYagAAAAEGNZhU85SAXRYDEWZCMos0qxhSEbXB0K4I67SQwQFq0ehX7kwY3SoY7rXJ0nWPWWtA==", "01000000007", true, "acc21c8b-7df9-4712-81f5-2f846df98423", false, "patient7@clinic.com" },
                    { "9bac9a20-195c-4076-8b1f-1967fc049ea8", 0, "b260f658-8b3b-4dfe-8b86-484798bfb9a6", "doctor4@clinic.com", true, false, null, "DOCTOR4@CLINIC.COM", "DOCTOR4@CLINIC.COM", "AQAAAAIAAYagAAAAEEsCqqn4h2nPJL0gcvxI11EY1m0LDZLDjYoMXaDfon/KeDYaPd9DP9laGN2hRInLsw==", "01100000004", true, "2fc727f0-da25-443e-bbda-83c9bd1c6f46", false, "doctor4@clinic.com" },
                    { "a41359ca-0135-4a0b-881e-07de66eb303e", 0, "06833895-31f5-404a-b23f-6bae89b7a856", "patient16@clinic.com", true, false, null, "PATIENT16@CLINIC.COM", "PATIENT16@CLINIC.COM", "AQAAAAIAAYagAAAAEAcZXTQ+cD2JEyVfyaj7K4zCNk5/XsC55GnIMHjV1cI7OQ6+wS0QuBTvzI8//oOX5w==", "01000000016", true, "3ebefa52-d200-40da-b0cc-89ead6a685f9", false, "patient16@clinic.com" },
                    { "a467059e-c9e4-41a1-b3f1-abf681f67ed4", 0, "6979d3d1-e49c-4aea-bced-dbd111500be8", "patient4@clinic.com", true, false, null, "PATIENT4@CLINIC.COM", "PATIENT4@CLINIC.COM", "AQAAAAIAAYagAAAAECibMfvms8Df9OQagE9vuUwRc7Yy1VTSB5GVgtYs6OAozcUcGW0e+4CRM6RiAJSF+A==", "01000000004", true, "15270390-7b77-4b5b-8c75-f72d79594727", false, "patient4@clinic.com" },
                    { "adcb1db0-0939-4f76-80e4-05fbd8b556f9", 0, "e5bc6469-f174-416b-9a15-7444a43cf239", "patient8@clinic.com", true, false, null, "PATIENT8@CLINIC.COM", "PATIENT8@CLINIC.COM", "AQAAAAIAAYagAAAAEPWfbufOXAQao+mVmhzruT1b8vE0E0PHGTQ+sZawe2xEkZ7Dv4nDvc+8UtGymWlIQA==", "01000000008", true, "12601931-47f5-423f-9979-995a286f2038", false, "patient8@clinic.com" },
                    { "afd8a3f8-9288-49b2-a617-48aa81941de7", 0, "1359c16e-7a15-497a-87e8-5dfb691ea6a3", "doctor5@clinic.com", true, false, null, "DOCTOR5@CLINIC.COM", "DOCTOR5@CLINIC.COM", "AQAAAAIAAYagAAAAEI74NJtuToSnPb3c5g9tB1AFuM86IFvxu21xMLmCk1VAyoILHvkokaYZu5jq0u7MMA==", "01100000005", true, "93380645-1035-4a78-b565-692270a8a69b", false, "doctor5@clinic.com" },
                    { "b027c1b3-df44-4b98-9fe4-cb29dc42fd0b", 0, "64f6157f-01c0-4397-8a42-2417b58a3580", "doctor1@clinic.com", true, false, null, "DOCTOR1@CLINIC.COM", "DOCTOR1@CLINIC.COM", "AQAAAAIAAYagAAAAEKVhXF/yhnNQlyf0A3EJAw0JjOK74558Vn42vzn4ZRf7Lw+wUxP/B3WUZDgUxWzDag==", "01100000001", true, "4ec55df9-7431-49ee-aa95-0ba8f2126342", false, "doctor1@clinic.com" },
                    { "b2461409-f153-422c-8f18-679564bd945b", 0, "4bd699d8-86d7-4528-b7f8-9aa6c1d04ddb", "doctor18@clinic.com", true, false, null, "DOCTOR18@CLINIC.COM", "DOCTOR18@CLINIC.COM", "AQAAAAIAAYagAAAAEGM3c0CymOg8jpoDPXucgT+2B5hhxH4wrOdjfZkY9zKKzQzdpbqpoT+t3kcFSUQJvg==", "01100000018", true, "40d321b8-11a3-4f70-a336-ac5e3dc5f561", false, "doctor18@clinic.com" },
                    { "b2bda50f-4e68-4547-92ea-cc9587a118f6", 0, "00b3ecce-92f5-40b0-aea5-80afa7481c22", "doctor17@clinic.com", true, false, null, "DOCTOR17@CLINIC.COM", "DOCTOR17@CLINIC.COM", "AQAAAAIAAYagAAAAEN5BDs/mtCsFxInViakwf/9YPMe1ScTGs7bEpn/B0z0+l8DleBltgfL86751rgw7CQ==", "01100000017", true, "ca6ca7c7-74cf-4673-8232-95f3bf84eb79", false, "doctor17@clinic.com" },
                    { "c4840c30-269e-4148-94ac-3915f8e7a9ff", 0, "9e906463-3814-4f01-9201-e6e34bd752e3", "admin1@clinic.com", true, false, null, "ADMIN1@CLINIC.COM", "ADMIN1@CLINIC.COM", "AQAAAAIAAYagAAAAEK3gqEqnbi12llE4qZZDZuD6TVsk/plgYPgaAUPd1MMr6YtFndYZs/emGXF6ZRIzYg==", "01000000001", true, "aacdfcc7-60cc-4ac9-b77c-e26031e5f579", false, "admin1@clinic.com" },
                    { "c603fd32-532a-4dd6-bc7f-55566a9926a8", 0, "f5172786-a4c5-4d50-9688-57b556ea6349", "admin4@clinic.com", true, false, null, "ADMIN4@CLINIC.COM", "ADMIN4@CLINIC.COM", "AQAAAAIAAYagAAAAEDnvlJSYd6vIhuwMLPjUY0kj8zFdOojWvGB3HRsHHcGLrP4/DfFI7Rv3lM7eFshdUQ==", "01000000004", true, "9c7e3240-5a76-40c4-9eea-4b5be01d6feb", false, "admin4@clinic.com" },
                    { "c6ba3d3e-bcc7-4f1b-adf8-378de26ee8d2", 0, "4ae712dc-3a45-4d49-a12a-acac15e76db4", "admin2@clinic.com", true, false, null, "ADMIN2@CLINIC.COM", "ADMIN2@CLINIC.COM", "AQAAAAIAAYagAAAAEMf6QNZJNHzejHMSQ/OwoDQXH9ypquYspPt/tbh+QR735wVY1j9ujOlNx1RX6IcgdQ==", "01000000002", true, "ed78e9c0-0bd9-40e4-80ef-3ea1550a6b46", false, "admin2@clinic.com" },
                    { "c70bdbeb-1c3a-43c2-9f07-192ef1ac6909", 0, "af8f3999-42d1-4edb-84f1-4eebf7ddfa4f", "admin3@clinic.com", true, false, null, "ADMIN3@CLINIC.COM", "ADMIN3@CLINIC.COM", "AQAAAAIAAYagAAAAEE3xnLjOZcjrDtdpxlHVMbbiicmlpuz5egDidMI9GWOKrflktBQuhdPAtR8zVf3+yA==", "01000000003", true, "b4ba5730-8b47-4780-a1de-c08e812bb7e4", false, "admin3@clinic.com" },
                    { "cf5d2ca8-28bf-422c-a0ce-f00ea8cbf762", 0, "1114c32e-1c31-4df0-b0d6-bf2ad31eb9c9", "patient13@clinic.com", true, false, null, "PATIENT13@CLINIC.COM", "PATIENT13@CLINIC.COM", "AQAAAAIAAYagAAAAEARWALF73nOF6SG7xkuTPcJlPs8lEPRDpB2F48LjoRxbFzf8rQb/HO42+V78Yt4aEw==", "01000000013", true, "d8a8187f-14b7-438e-b932-72be513261b4", false, "patient13@clinic.com" },
                    { "dfb83bad-4b8e-41ab-9098-6f09fa4c1b64", 0, "144b38b4-0d91-444d-b272-9a79b462abda", "admin5@clinic.com", true, false, null, "ADMIN5@CLINIC.COM", "ADMIN5@CLINIC.COM", "AQAAAAIAAYagAAAAECbTsOPSMk8zMtuhS6MiI4ZtoOWxxiCW0fJLN7zXT/qZBk6X+Rz0UzQelyWqGlMDhA==", "01000000005", true, "7378e2e3-db08-4010-862a-aa9085c87698", false, "admin5@clinic.com" },
                    { "e2ed9871-1cbd-498c-bd76-88c6ff1f3735", 0, "2a64f592-c64f-4a2f-8ad6-9b5cd96a1874", "patient18@clinic.com", true, false, null, "PATIENT18@CLINIC.COM", "PATIENT18@CLINIC.COM", "AQAAAAIAAYagAAAAEF0eZNue7q7xfAY2urQqz2SUpIu4snZqNKiFepwQFaWzQm+gH0bHd3NVsOaGPNXMHA==", "01000000018", true, "e57fc781-d4c4-4f3f-b1a7-c1a437680efc", false, "patient18@clinic.com" },
                    { "e748cacd-4b12-4173-a66c-50e9cf94f303", 0, "5a3024ea-d2f3-4b08-a4b5-d5af6e824ccd", "patient17@clinic.com", true, false, null, "PATIENT17@CLINIC.COM", "PATIENT17@CLINIC.COM", "AQAAAAIAAYagAAAAEH0oMuSmqVxFaYB7jYBAsgux/gRiedNGb3aqvX26JL0lMW7olm0Dct/WvMA7Ft2KGg==", "01000000017", true, "6d54d917-a3fc-4409-afa5-4d5f0978c0c4", false, "patient17@clinic.com" },
                    { "ea0f3cfb-77b1-425e-be71-358c4bf1ba16", 0, "365d51c0-e274-410a-b9d2-4f647e477dfe", "doctor16@clinic.com", true, false, null, "DOCTOR16@CLINIC.COM", "DOCTOR16@CLINIC.COM", "AQAAAAIAAYagAAAAENl7VSbnLydMiuERMhnKkrFRnPbNJPohj0So+vwj6mfgQiwaj5GNbIEUDC3Mc8/7sQ==", "01100000016", true, "94376775-be7a-4aed-8b1d-a8f4510ae8f4", false, "doctor16@clinic.com" },
                    { "f2a5cf73-6cdc-47f4-9db2-a9bc6c5b483e", 0, "6871e3a8-9e94-4df8-a6ba-51181f5bffca", "patient14@clinic.com", true, false, null, "PATIENT14@CLINIC.COM", "PATIENT14@CLINIC.COM", "AQAAAAIAAYagAAAAEHwc0V5tlSEiUpvO9BOxscUAkEoOyk7Qlsi6b7FGjuilYv/LBOEPDy+jz9h5Yc4Pcg==", "01000000014", true, "3872d3fd-2b2e-408c-8b9f-a990986b1e00", false, "patient14@clinic.com" },
                    { "f5ed5f51-9396-41ff-b972-c2c7cc799cb5", 0, "6a44d604-7c69-4b9f-8264-cd9932cec3ea", "doctor12@clinic.com", true, false, null, "DOCTOR12@CLINIC.COM", "DOCTOR12@CLINIC.COM", "AQAAAAIAAYagAAAAEONPBvRfttPcOzoGgprmWUJNdp30pnBKN62zRgP5lNUI+G07cnZhTgV1nimaTQNd1w==", "01100000012", true, "d35b3813-ad71-44c3-92d9-0d4c8226b147", false, "doctor12@clinic.com" },
                    { "f68f7e6e-197e-413d-bc72-db072ccf9ea6", 0, "6dabee43-4131-40ae-ae05-b890bf2ffb31", "patient6@clinic.com", true, false, null, "PATIENT6@CLINIC.COM", "PATIENT6@CLINIC.COM", "AQAAAAIAAYagAAAAEOhp9u6aHSB2iNqDz3Uipob5+uaIL2y+w7EMn2LvaEKO5EmoK6cBXTiDU+5eLx0OXg==", "01000000006", true, "58cba20e-a443-419c-b130-dd6184d82923", false, "patient6@clinic.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "0b2a0b3f-335d-407a-9eb5-1f2df8757ac1" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "0cc0fd04-1442-43ff-bbf4-da14d44809f7" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "328d7971-00b1-4c1e-ae83-044da79f638c" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "355d7bff-7157-406a-be14-1f4f41a2f0d0" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "38df6d89-7ef7-411a-aa56-a79222b5035c" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "39d18d23-ff3b-402c-93fc-3676c4b84cbd" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "3ac0108b-1750-4f96-85a9-fde8ffdda749" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "3da26cb0-5215-44da-bef4-77bcc2b1a71d" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "43bb0799-23e3-46f2-9130-d5c864d20fb9" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "4f5cc6c7-81d0-48b4-897d-b9bb803b7d01" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "54c7cea8-def6-4dac-8ed2-a9df662d978c" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "5a3775ae-deee-4d3b-add8-902565287f36" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "5b822ee5-eb3c-4e24-a44f-c8b71d22cd57" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "5cde9f9c-e925-4ce1-b5e8-276997f44b57" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "628f2987-610f-43f0-abeb-b830479b03d4" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "69b95277-1f9b-45e9-87cf-33fce9ef5a5c" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "6b718587-f8b4-4e5b-86a6-2cdb71959411" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "74401562-e7c7-4448-890f-af9b01dee998" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "75d6a14b-0b4f-4abf-aca2-265fd6c0cfac" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "7aadde49-213c-4ea8-94b7-25d4acf487d2" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "8253e185-3837-4996-a49c-786de1c55b35" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "836f43d7-bc60-4d28-8f57-3bc6859c5dea" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "8751de00-9e1e-402f-80f3-993617e7574f" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "875a481d-ea58-4d71-8dc5-12370b3fc219" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "935ec8d4-4db9-4b2c-aac5-25676806c655" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "9bac9a20-195c-4076-8b1f-1967fc049ea8" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "a41359ca-0135-4a0b-881e-07de66eb303e" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "a467059e-c9e4-41a1-b3f1-abf681f67ed4" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "adcb1db0-0939-4f76-80e4-05fbd8b556f9" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "afd8a3f8-9288-49b2-a617-48aa81941de7" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "b027c1b3-df44-4b98-9fe4-cb29dc42fd0b" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "b2461409-f153-422c-8f18-679564bd945b" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "b2bda50f-4e68-4547-92ea-cc9587a118f6" },
                    { "675b578c-8739-4b1b-a706-816fb14910bd", "c4840c30-269e-4148-94ac-3915f8e7a9ff" },
                    { "675b578c-8739-4b1b-a706-816fb14910bd", "c603fd32-532a-4dd6-bc7f-55566a9926a8" },
                    { "675b578c-8739-4b1b-a706-816fb14910bd", "c6ba3d3e-bcc7-4f1b-adf8-378de26ee8d2" },
                    { "675b578c-8739-4b1b-a706-816fb14910bd", "c70bdbeb-1c3a-43c2-9f07-192ef1ac6909" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "cf5d2ca8-28bf-422c-a0ce-f00ea8cbf762" },
                    { "675b578c-8739-4b1b-a706-816fb14910bd", "dfb83bad-4b8e-41ab-9098-6f09fa4c1b64" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "e2ed9871-1cbd-498c-bd76-88c6ff1f3735" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "e748cacd-4b12-4173-a66c-50e9cf94f303" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "ea0f3cfb-77b1-425e-be71-358c4bf1ba16" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "f2a5cf73-6cdc-47f4-9db2-a9bc6c5b483e" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "f5ed5f51-9396-41ff-b972-c2c7cc799cb5" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "f68f7e6e-197e-413d-bc72-db072ccf9ea6" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Price", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("0e3a7df0-4113-420f-a164-7f73bd0ff1d1"), 114.0, "Specialty 14", "38df6d89-7ef7-411a-aa56-a79222b5035c" },
                    { new Guid("28cfc1fd-e78d-41f3-bcb0-13c6e2f6cd64"), 108.0, "Specialty 8", "8751de00-9e1e-402f-80f3-993617e7574f" },
                    { new Guid("4af1c6dc-7503-476d-9b3d-6817c4044fad"), 102.0, "Specialty 2", "355d7bff-7157-406a-be14-1f4f41a2f0d0" },
                    { new Guid("4cf5e673-87f0-4311-a283-fff2d5ffb345"), 104.0, "Specialty 4", "9bac9a20-195c-4076-8b1f-1967fc049ea8" },
                    { new Guid("4f05f789-4331-4bd9-9712-47b8d7d89c15"), 111.0, "Specialty 11", "628f2987-610f-43f0-abeb-b830479b03d4" },
                    { new Guid("50ed9bc3-c84b-4fad-8606-73fe5a9a7a8e"), 105.0, "Specialty 5", "afd8a3f8-9288-49b2-a617-48aa81941de7" },
                    { new Guid("5c26a4a8-31f7-43f1-b539-e7977eee24fd"), 119.0, "Specialty 19", "75d6a14b-0b4f-4abf-aca2-265fd6c0cfac" },
                    { new Guid("64b2127f-a2c7-49c3-bdbd-5a4bb9d82450"), 103.0, "Specialty 3", "328d7971-00b1-4c1e-ae83-044da79f638c" },
                    { new Guid("694e7951-2664-4ebb-8dbb-de57d8d2f1a6"), 120.0, "Specialty 20", "6b718587-f8b4-4e5b-86a6-2cdb71959411" },
                    { new Guid("6dbc19ff-9bc2-4612-9957-31b441e074b0"), 112.0, "Specialty 12", "f5ed5f51-9396-41ff-b972-c2c7cc799cb5" },
                    { new Guid("767f2e97-9ab4-4621-a768-0738601afa8a"), 107.0, "Specialty 7", "3ac0108b-1750-4f96-85a9-fde8ffdda749" },
                    { new Guid("85204702-efd9-4ab3-b024-e9581f0c763a"), 106.0, "Specialty 6", "3da26cb0-5215-44da-bef4-77bcc2b1a71d" },
                    { new Guid("8cf67fd2-00cc-41b8-ad7c-634226698298"), 118.0, "Specialty 18", "b2461409-f153-422c-8f18-679564bd945b" },
                    { new Guid("9ad289a2-4ae4-41d9-a536-bdc45a378754"), 115.0, "Specialty 15", "5b822ee5-eb3c-4e24-a44f-c8b71d22cd57" },
                    { new Guid("9b488485-c380-4f5d-8387-f8a28466753f"), 110.0, "Specialty 10", "5cde9f9c-e925-4ce1-b5e8-276997f44b57" },
                    { new Guid("9ef651bb-9d32-4df2-8af4-c0ded5f2a237"), 113.0, "Specialty 13", "74401562-e7c7-4448-890f-af9b01dee998" },
                    { new Guid("be8e9bdb-a6f6-4b1c-a20e-35c24afe5617"), 109.0, "Specialty 9", "836f43d7-bc60-4d28-8f57-3bc6859c5dea" },
                    { new Guid("cb8a8795-bdf0-4c07-818f-3d9d6ee904ce"), 101.0, "Specialty 1", "b027c1b3-df44-4b98-9fe4-cb29dc42fd0b" },
                    { new Guid("e22dbcb0-874a-4c90-9a96-5850966f82d6"), 117.0, "Specialty 17", "b2bda50f-4e68-4547-92ea-cc9587a118f6" },
                    { new Guid("f22d0631-fbde-49a0-a637-b15e0dc6b728"), 116.0, "Specialty 16", "ea0f3cfb-77b1-425e-be71-358c4bf1ba16" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "Date", "DoctorId", "PatientId", "State", "Time" },
                values: new object[,]
                {
                    { new Guid("065e9f27-6fd9-41e6-bb89-95704b901b46"), "2025-05-03", new Guid("64b2127f-a2c7-49c3-bdbd-5a4bb9d82450"), "c70bdbeb-1c3a-43c2-9f07-192ef1ac6909", "close", "11:00 AM" },
                    { new Guid("07e5f1a2-faf7-4e04-a2e8-13ad76ab5523"), "2025-05-05", new Guid("50ed9bc3-c84b-4fad-8606-73fe5a9a7a8e"), null, "open", "13:00 AM" },
                    { new Guid("082c45d8-5819-48e3-92cf-cc546669aea7"), "2025-05-06", new Guid("85204702-efd9-4ab3-b024-e9581f0c763a"), null, "open", "14:00 AM" },
                    { new Guid("0a602e42-9903-48b0-9662-d97fc7aaa696"), "2025-05-14", new Guid("0e3a7df0-4113-420f-a164-7f73bd0ff1d1"), "0b2a0b3f-335d-407a-9eb5-1f2df8757ac1", "close", "10:00 AM" },
                    { new Guid("0a6bb835-1ae9-4693-8df0-d2354753df68"), "2025-05-07", new Guid("767f2e97-9ab4-4621-a768-0738601afa8a"), "8253e185-3837-4996-a49c-786de1c55b35", "pending", "15:00 AM" },
                    { new Guid("0c7a474f-8d10-41d6-a9e4-c69d2a2d4a59"), "2025-05-06", new Guid("85204702-efd9-4ab3-b024-e9581f0c763a"), "54c7cea8-def6-4dac-8ed2-a9df662d978c", "pending", "14:00 AM" },
                    { new Guid("117e6342-e3f7-4412-af0b-e153672ec5b0"), "2025-05-18", new Guid("8cf67fd2-00cc-41b8-ad7c-634226698298"), "cf5d2ca8-28bf-422c-a0ce-f00ea8cbf762", "close", "14:00 AM" },
                    { new Guid("183410ad-0d87-402a-9a38-f376fd09da0a"), "2025-05-18", new Guid("8cf67fd2-00cc-41b8-ad7c-634226698298"), "cf5d2ca8-28bf-422c-a0ce-f00ea8cbf762", "pending", "14:00 AM" },
                    { new Guid("1903c592-abd7-4621-8b12-acad2f17b062"), "2025-05-11", new Guid("4f05f789-4331-4bd9-9712-47b8d7d89c15"), "f68f7e6e-197e-413d-bc72-db072ccf9ea6", "ongoing", "19:00 AM" },
                    { new Guid("1b322e6a-aab0-4f66-b01d-f65071bc23c3"), "2025-05-04", new Guid("4cf5e673-87f0-4311-a283-fff2d5ffb345"), null, "open", "12:00 AM" },
                    { new Guid("1bf3fff2-508c-401a-84ff-aa74917b326c"), "2025-05-02", new Guid("4af1c6dc-7503-476d-9b3d-6817c4044fad"), "c6ba3d3e-bcc7-4f1b-adf8-378de26ee8d2", "close", "10:00 AM" },
                    { new Guid("1f2dd148-d438-4e4d-a021-f22c4f5aaed4"), "2025-05-13", new Guid("9ef651bb-9d32-4df2-8af4-c0ded5f2a237"), "adcb1db0-0939-4f76-80e4-05fbd8b556f9", "ongoing", "9:00 AM" },
                    { new Guid("1fa79beb-1f43-479b-bba1-2fd822789d59"), "2025-05-06", new Guid("85204702-efd9-4ab3-b024-e9581f0c763a"), "54c7cea8-def6-4dac-8ed2-a9df662d978c", "close", "14:00 AM" },
                    { new Guid("22715eab-065d-4619-a695-8819b3419f16"), "2025-05-08", new Guid("28cfc1fd-e78d-41f3-bcb0-13c6e2f6cd64"), "4f5cc6c7-81d0-48b4-897d-b9bb803b7d01", "pending", "16:00 AM" },
                    { new Guid("2594f9b9-4f5d-4e14-b221-a7863c050d3f"), "2025-05-09", new Guid("be8e9bdb-a6f6-4b1c-a20e-35c24afe5617"), null, "open", "17:00 AM" },
                    { new Guid("2b73a57d-6ec0-47a2-a202-ee51d3e0b3c9"), "2025-05-01", new Guid("cb8a8795-bdf0-4c07-818f-3d9d6ee904ce"), "c4840c30-269e-4148-94ac-3915f8e7a9ff", "close", "9:00 AM" },
                    { new Guid("2c442185-975a-45cd-9bdc-3106c36fca9f"), "2025-05-12", new Guid("6dbc19ff-9bc2-4612-9957-31b441e074b0"), null, "open", "20:00 AM" },
                    { new Guid("2d6a5cef-e5b5-4eb9-bd68-7b9356152682"), "2025-05-11", new Guid("4f05f789-4331-4bd9-9712-47b8d7d89c15"), "f68f7e6e-197e-413d-bc72-db072ccf9ea6", "close", "19:00 AM" },
                    { new Guid("2fce5827-1abb-4044-af79-32b5f8e49505"), "2025-05-17", new Guid("e22dbcb0-874a-4c90-9a96-5850966f82d6"), "43bb0799-23e3-46f2-9130-d5c864d20fb9", "pending", "13:00 AM" },
                    { new Guid("304b0f60-2139-4705-ac09-5a507a179365"), "2025-05-14", new Guid("0e3a7df0-4113-420f-a164-7f73bd0ff1d1"), null, "open", "10:00 AM" },
                    { new Guid("30f713d5-5255-4ddc-92e4-4d8964285fe6"), "2025-05-18", new Guid("8cf67fd2-00cc-41b8-ad7c-634226698298"), null, "open", "14:00 AM" },
                    { new Guid("325e5314-3f28-4acf-922d-13988f60ea77"), "2025-05-10", new Guid("9b488485-c380-4f5d-8387-f8a28466753f"), "7aadde49-213c-4ea8-94b7-25d4acf487d2", "pending", "18:00 AM" },
                    { new Guid("340f9440-611d-45d6-a8d9-05b71842ef22"), "2025-05-06", new Guid("85204702-efd9-4ab3-b024-e9581f0c763a"), "54c7cea8-def6-4dac-8ed2-a9df662d978c", "ongoing", "14:00 AM" },
                    { new Guid("34158a23-c316-47b8-9977-17beb312b448"), "2025-05-02", new Guid("4af1c6dc-7503-476d-9b3d-6817c4044fad"), "c6ba3d3e-bcc7-4f1b-adf8-378de26ee8d2", "ongoing", "10:00 AM" },
                    { new Guid("343e2fc5-9a51-49e9-8669-2e24582a9045"), "2025-05-04", new Guid("4cf5e673-87f0-4311-a283-fff2d5ffb345"), "c603fd32-532a-4dd6-bc7f-55566a9926a8", "close", "12:00 AM" },
                    { new Guid("3ed24390-3494-43ec-80f5-825270929741"), "2025-05-10", new Guid("9b488485-c380-4f5d-8387-f8a28466753f"), "7aadde49-213c-4ea8-94b7-25d4acf487d2", "close", "18:00 AM" },
                    { new Guid("4018eb77-e05a-4bfb-897d-776195eb2b1b"), "2025-05-07", new Guid("767f2e97-9ab4-4621-a768-0738601afa8a"), "8253e185-3837-4996-a49c-786de1c55b35", "ongoing", "15:00 AM" },
                    { new Guid("4091e5a4-c59b-4ed7-84b7-94108dfbc6fc"), "2025-05-20", new Guid("694e7951-2664-4ebb-8dbb-de57d8d2f1a6"), "0cc0fd04-1442-43ff-bbf4-da14d44809f7", "pending", "16:00 AM" },
                    { new Guid("53aedd67-c560-4d2a-823a-5a90dfffa928"), "2025-05-17", new Guid("e22dbcb0-874a-4c90-9a96-5850966f82d6"), "43bb0799-23e3-46f2-9130-d5c864d20fb9", "close", "13:00 AM" },
                    { new Guid("59ae2185-719a-4c24-b319-875d3d168441"), "2025-05-14", new Guid("0e3a7df0-4113-420f-a164-7f73bd0ff1d1"), "0b2a0b3f-335d-407a-9eb5-1f2df8757ac1", "pending", "10:00 AM" },
                    { new Guid("5a56fd94-b5e9-4ade-a639-b57b9c5add81"), "2025-05-20", new Guid("694e7951-2664-4ebb-8dbb-de57d8d2f1a6"), "0cc0fd04-1442-43ff-bbf4-da14d44809f7", "close", "16:00 AM" },
                    { new Guid("5a820ae6-654a-4c81-9c61-5d959a6f565e"), "2025-05-04", new Guid("4cf5e673-87f0-4311-a283-fff2d5ffb345"), "c603fd32-532a-4dd6-bc7f-55566a9926a8", "ongoing", "12:00 AM" },
                    { new Guid("5fd82aa0-6045-4aa0-a4eb-8f65ba5dc53d"), "2025-05-15", new Guid("9ad289a2-4ae4-41d9-a536-bdc45a378754"), "5a3775ae-deee-4d3b-add8-902565287f36", "ongoing", "11:00 AM" },
                    { new Guid("60d32f9b-088c-411b-905b-ab66df7a188f"), "2025-05-09", new Guid("be8e9bdb-a6f6-4b1c-a20e-35c24afe5617"), "a467059e-c9e4-41a1-b3f1-abf681f67ed4", "ongoing", "17:00 AM" },
                    { new Guid("707b0b09-cb96-4dca-b514-21c1582f7089"), "2025-05-20", new Guid("694e7951-2664-4ebb-8dbb-de57d8d2f1a6"), null, "open", "16:00 AM" },
                    { new Guid("710f18b6-332d-403c-a004-59a4d4bba511"), "2025-05-13", new Guid("9ef651bb-9d32-4df2-8af4-c0ded5f2a237"), "adcb1db0-0939-4f76-80e4-05fbd8b556f9", "pending", "9:00 AM" },
                    { new Guid("71329a38-8591-4c34-8c47-c28e30dbb6e2"), "2025-05-12", new Guid("6dbc19ff-9bc2-4612-9957-31b441e074b0"), "935ec8d4-4db9-4b2c-aac5-25676806c655", "close", "20:00 AM" },
                    { new Guid("722882f0-4e6a-406d-b4d6-ad582e50978a"), "2025-05-19", new Guid("5c26a4a8-31f7-43f1-b539-e7977eee24fd"), "f2a5cf73-6cdc-47f4-9db2-a9bc6c5b483e", "pending", "15:00 AM" },
                    { new Guid("732c7e1a-1ece-4472-9f7e-9c6d308ef715"), "2025-05-17", new Guid("e22dbcb0-874a-4c90-9a96-5850966f82d6"), "43bb0799-23e3-46f2-9130-d5c864d20fb9", "ongoing", "13:00 AM" },
                    { new Guid("7e9f473a-cf06-402e-8694-82c3c7d7784e"), "2025-05-19", new Guid("5c26a4a8-31f7-43f1-b539-e7977eee24fd"), null, "open", "15:00 AM" },
                    { new Guid("8734a5e7-262e-456c-ac16-b66309076a8e"), "2025-05-07", new Guid("767f2e97-9ab4-4621-a768-0738601afa8a"), null, "open", "15:00 AM" },
                    { new Guid("8825a3d8-2a81-457c-8c75-0c92566fa313"), "2025-05-03", new Guid("64b2127f-a2c7-49c3-bdbd-5a4bb9d82450"), "c70bdbeb-1c3a-43c2-9f07-192ef1ac6909", "pending", "11:00 AM" },
                    { new Guid("89c6c5fa-5a55-4662-80b2-8c5d19229406"), "2025-05-13", new Guid("9ef651bb-9d32-4df2-8af4-c0ded5f2a237"), "adcb1db0-0939-4f76-80e4-05fbd8b556f9", "close", "9:00 AM" },
                    { new Guid("8b4e9d9d-e6f8-42a2-bd58-80908c6fd8ce"), "2025-05-10", new Guid("9b488485-c380-4f5d-8387-f8a28466753f"), "7aadde49-213c-4ea8-94b7-25d4acf487d2", "ongoing", "18:00 AM" },
                    { new Guid("8bd050bc-d0c6-478c-a750-095300a0ec57"), "2025-05-19", new Guid("5c26a4a8-31f7-43f1-b539-e7977eee24fd"), "f2a5cf73-6cdc-47f4-9db2-a9bc6c5b483e", "close", "15:00 AM" },
                    { new Guid("8c5600ba-1e20-4afb-b919-08e89638de57"), "2025-05-02", new Guid("4af1c6dc-7503-476d-9b3d-6817c4044fad"), "c6ba3d3e-bcc7-4f1b-adf8-378de26ee8d2", "pending", "10:00 AM" },
                    { new Guid("915cb1db-ce30-4bbe-a0d1-d4a6c4d2cb7e"), "2025-05-13", new Guid("9ef651bb-9d32-4df2-8af4-c0ded5f2a237"), null, "open", "9:00 AM" },
                    { new Guid("927facf6-983e-496f-bb39-8c67298eee66"), "2025-05-15", new Guid("9ad289a2-4ae4-41d9-a536-bdc45a378754"), "5a3775ae-deee-4d3b-add8-902565287f36", "close", "11:00 AM" },
                    { new Guid("92fd05bd-5bbf-4865-b0a0-4b19d24bf0df"), "2025-05-16", new Guid("f22d0631-fbde-49a0-a637-b15e0dc6b728"), "39d18d23-ff3b-402c-93fc-3676c4b84cbd", "ongoing", "12:00 AM" },
                    { new Guid("942bdc3a-02d8-4fef-8611-be79c6910f3f"), "2025-05-01", new Guid("cb8a8795-bdf0-4c07-818f-3d9d6ee904ce"), "c4840c30-269e-4148-94ac-3915f8e7a9ff", "ongoing", "9:00 AM" },
                    { new Guid("9493cbdb-0311-48ab-b53c-82821d15e98a"), "2025-05-12", new Guid("6dbc19ff-9bc2-4612-9957-31b441e074b0"), "935ec8d4-4db9-4b2c-aac5-25676806c655", "ongoing", "20:00 AM" },
                    { new Guid("97d0291f-1762-4fea-ae1b-11885bee6755"), "2025-05-11", new Guid("4f05f789-4331-4bd9-9712-47b8d7d89c15"), null, "open", "19:00 AM" },
                    { new Guid("993d3388-4a22-4b69-b9a7-ddc7915000fe"), "2025-05-01", new Guid("cb8a8795-bdf0-4c07-818f-3d9d6ee904ce"), "c4840c30-269e-4148-94ac-3915f8e7a9ff", "pending", "9:00 AM" },
                    { new Guid("9b27f7de-aa7e-4ad8-bc40-015d90ba34cf"), "2025-05-08", new Guid("28cfc1fd-e78d-41f3-bcb0-13c6e2f6cd64"), "4f5cc6c7-81d0-48b4-897d-b9bb803b7d01", "ongoing", "16:00 AM" },
                    { new Guid("9bfba408-ef8f-41da-aee0-ce1c3f396cde"), "2025-05-10", new Guid("9b488485-c380-4f5d-8387-f8a28466753f"), null, "open", "18:00 AM" },
                    { new Guid("9f1174a7-2c2b-48b0-a9f2-87a057a9eed8"), "2025-05-05", new Guid("50ed9bc3-c84b-4fad-8606-73fe5a9a7a8e"), "dfb83bad-4b8e-41ab-9098-6f09fa4c1b64", "pending", "13:00 AM" },
                    { new Guid("a33500fb-6dfd-4ca0-8bef-24272f37ed7f"), "2025-05-03", new Guid("64b2127f-a2c7-49c3-bdbd-5a4bb9d82450"), null, "open", "11:00 AM" },
                    { new Guid("a9d684cb-6b55-4548-bc4f-53066154d4a3"), "2025-05-16", new Guid("f22d0631-fbde-49a0-a637-b15e0dc6b728"), "39d18d23-ff3b-402c-93fc-3676c4b84cbd", "close", "12:00 AM" },
                    { new Guid("b3005730-d21e-41d2-bb60-bc7c0676139c"), "2025-05-17", new Guid("e22dbcb0-874a-4c90-9a96-5850966f82d6"), null, "open", "13:00 AM" },
                    { new Guid("c16ad5de-562d-4dd9-ab83-8edf08040f1b"), "2025-05-09", new Guid("be8e9bdb-a6f6-4b1c-a20e-35c24afe5617"), "a467059e-c9e4-41a1-b3f1-abf681f67ed4", "pending", "17:00 AM" },
                    { new Guid("c2dee39e-aedb-4d67-8964-6a2b97cd21c6"), "2025-05-11", new Guid("4f05f789-4331-4bd9-9712-47b8d7d89c15"), "f68f7e6e-197e-413d-bc72-db072ccf9ea6", "pending", "19:00 AM" },
                    { new Guid("c711f1ad-0dd8-44fd-b4b1-7dc2bb66b82a"), "2025-05-01", new Guid("cb8a8795-bdf0-4c07-818f-3d9d6ee904ce"), null, "open", "9:00 AM" },
                    { new Guid("c86446ba-cf8e-4f1e-8cff-1e5fe226a4fd"), "2025-05-16", new Guid("f22d0631-fbde-49a0-a637-b15e0dc6b728"), "39d18d23-ff3b-402c-93fc-3676c4b84cbd", "pending", "12:00 AM" },
                    { new Guid("c8db2deb-5a28-464d-994f-114b6a054bb8"), "2025-05-09", new Guid("be8e9bdb-a6f6-4b1c-a20e-35c24afe5617"), "a467059e-c9e4-41a1-b3f1-abf681f67ed4", "close", "17:00 AM" },
                    { new Guid("c9ee7aa2-a3b6-47bb-b489-d299ff7af12e"), "2025-05-20", new Guid("694e7951-2664-4ebb-8dbb-de57d8d2f1a6"), "0cc0fd04-1442-43ff-bbf4-da14d44809f7", "ongoing", "16:00 AM" },
                    { new Guid("d26e6aa5-50f8-4272-b272-c07f66cbf51c"), "2025-05-16", new Guid("f22d0631-fbde-49a0-a637-b15e0dc6b728"), null, "open", "12:00 AM" },
                    { new Guid("e3adf908-019f-4822-8e6f-b31e6ae25685"), "2025-05-08", new Guid("28cfc1fd-e78d-41f3-bcb0-13c6e2f6cd64"), "4f5cc6c7-81d0-48b4-897d-b9bb803b7d01", "close", "16:00 AM" },
                    { new Guid("e5f9b64c-6b91-4a16-8bc3-4fb3f1be0184"), "2025-05-05", new Guid("50ed9bc3-c84b-4fad-8606-73fe5a9a7a8e"), "dfb83bad-4b8e-41ab-9098-6f09fa4c1b64", "ongoing", "13:00 AM" },
                    { new Guid("e6810a18-679b-4871-9fff-1456c3c9a89f"), "2025-05-15", new Guid("9ad289a2-4ae4-41d9-a536-bdc45a378754"), "5a3775ae-deee-4d3b-add8-902565287f36", "pending", "11:00 AM" },
                    { new Guid("e811f890-0a50-41cd-b508-1a9b2e9eaba7"), "2025-05-08", new Guid("28cfc1fd-e78d-41f3-bcb0-13c6e2f6cd64"), null, "open", "16:00 AM" },
                    { new Guid("e816e287-e209-4b6e-92c1-c70fe0f0c5d4"), "2025-05-03", new Guid("64b2127f-a2c7-49c3-bdbd-5a4bb9d82450"), "c70bdbeb-1c3a-43c2-9f07-192ef1ac6909", "ongoing", "11:00 AM" },
                    { new Guid("e898b1f4-7330-4104-b1b0-ed7966e8a7f1"), "2025-05-05", new Guid("50ed9bc3-c84b-4fad-8606-73fe5a9a7a8e"), "dfb83bad-4b8e-41ab-9098-6f09fa4c1b64", "close", "13:00 AM" },
                    { new Guid("ed3cf7ae-f251-4376-8683-7435ae28282f"), "2025-05-04", new Guid("4cf5e673-87f0-4311-a283-fff2d5ffb345"), "c603fd32-532a-4dd6-bc7f-55566a9926a8", "pending", "12:00 AM" },
                    { new Guid("edce17fc-ee3e-43d8-b4ec-a6cc1740862d"), "2025-05-07", new Guid("767f2e97-9ab4-4621-a768-0738601afa8a"), "8253e185-3837-4996-a49c-786de1c55b35", "close", "15:00 AM" },
                    { new Guid("ef2e7e6f-3c6f-4c69-b164-31902f8adbc0"), "2025-05-18", new Guid("8cf67fd2-00cc-41b8-ad7c-634226698298"), "cf5d2ca8-28bf-422c-a0ce-f00ea8cbf762", "ongoing", "14:00 AM" },
                    { new Guid("f22723c3-9bad-48f8-96e2-7068b9b2c7c2"), "2025-05-15", new Guid("9ad289a2-4ae4-41d9-a536-bdc45a378754"), null, "open", "11:00 AM" },
                    { new Guid("f26745c2-482d-4d89-a03d-411d5612d460"), "2025-05-19", new Guid("5c26a4a8-31f7-43f1-b539-e7977eee24fd"), "f2a5cf73-6cdc-47f4-9db2-a9bc6c5b483e", "ongoing", "15:00 AM" },
                    { new Guid("f8c816d6-ac3b-4b51-9073-a415388885c0"), "2025-05-02", new Guid("4af1c6dc-7503-476d-9b3d-6817c4044fad"), null, "open", "10:00 AM" },
                    { new Guid("fe558d48-4921-49e8-959e-9d14f77a8109"), "2025-05-14", new Guid("0e3a7df0-4113-420f-a164-7f73bd0ff1d1"), "0b2a0b3f-335d-407a-9eb5-1f2df8757ac1", "ongoing", "10:00 AM" },
                    { new Guid("fe7a99ff-c4d1-435a-b435-b059cb4ecb3f"), "2025-05-12", new Guid("6dbc19ff-9bc2-4612-9957-31b441e074b0"), "935ec8d4-4db9-4b2c-aac5-25676806c655", "pending", "20:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Id", "AppointmentId", "Description", "Modification_date" },
                values: new object[,]
                {
                    { new Guid("03624d4a-06c0-43de-8ac9-d8addea6811e"), new Guid("710f18b6-332d-403c-a004-59a4d4bba511"), "Prescription for appointment 13", "2025-05-07" },
                    { new Guid("053a788c-2624-4de4-89f2-ac0f694a3987"), new Guid("0c7a474f-8d10-41d6-a9e4-c69d2a2d4a59"), "Prescription for appointment 6", "2025-05-07" },
                    { new Guid("05952675-894c-41f9-9dcc-501ab5f960c1"), new Guid("c86446ba-cf8e-4f1e-8cff-1e5fe226a4fd"), "Prescription for appointment 16", "2025-05-07" },
                    { new Guid("06c5f2ef-4c5a-4a38-a74b-633ffb18d4d5"), new Guid("7e9f473a-cf06-402e-8694-82c3c7d7784e"), "Prescription for appointment 19", "2025-05-07" },
                    { new Guid("0791d742-3cd2-42fd-a6d5-1646c595b8b0"), new Guid("60d32f9b-088c-411b-905b-ab66df7a188f"), "Prescription for appointment 9", "2025-05-07" },
                    { new Guid("09caae15-e34d-450d-aaf9-a12ad5342851"), new Guid("22715eab-065d-4619-a695-8819b3419f16"), "Prescription for appointment 8", "2025-05-07" },
                    { new Guid("0d565a43-41dc-42dc-9fe6-59d0de16de68"), new Guid("d26e6aa5-50f8-4272-b272-c07f66cbf51c"), "Prescription for appointment 16", "2025-05-07" },
                    { new Guid("0d700a20-49d0-4cde-829d-5f07c4ec2600"), new Guid("707b0b09-cb96-4dca-b514-21c1582f7089"), "Prescription for appointment 20", "2025-05-07" },
                    { new Guid("0ddf9e57-e472-4bab-a20a-41b95d7c50ff"), new Guid("9bfba408-ef8f-41da-aee0-ce1c3f396cde"), "Prescription for appointment 10", "2025-05-07" },
                    { new Guid("16c88362-1f58-4ec6-9c05-83386d39f947"), new Guid("fe7a99ff-c4d1-435a-b435-b059cb4ecb3f"), "Prescription for appointment 12", "2025-05-07" },
                    { new Guid("1813f723-0515-4f50-bccd-2e6c7b6f15c4"), new Guid("065e9f27-6fd9-41e6-bb89-95704b901b46"), "Prescription for appointment 3", "2025-05-07" },
                    { new Guid("1de91fcb-5cfc-4e5c-bc92-d421bbdbb471"), new Guid("2b73a57d-6ec0-47a2-a202-ee51d3e0b3c9"), "Prescription for appointment 1", "2025-05-07" },
                    { new Guid("1f77fc65-4844-46e7-9215-2738de997191"), new Guid("71329a38-8591-4c34-8c47-c28e30dbb6e2"), "Prescription for appointment 12", "2025-05-07" },
                    { new Guid("230ded85-8949-4aa8-91b9-a895293b0b91"), new Guid("f26745c2-482d-4d89-a03d-411d5612d460"), "Prescription for appointment 19", "2025-05-07" },
                    { new Guid("294664e6-f2bd-4827-b469-0cf39614cbad"), new Guid("993d3388-4a22-4b69-b9a7-ddc7915000fe"), "Prescription for appointment 1", "2025-05-07" },
                    { new Guid("2fefe902-9e72-4ebb-9356-462e9d8dc6c9"), new Guid("343e2fc5-9a51-49e9-8669-2e24582a9045"), "Prescription for appointment 4", "2025-05-07" },
                    { new Guid("33f228e7-22a9-4e85-8efa-9abada0c79ba"), new Guid("53aedd67-c560-4d2a-823a-5a90dfffa928"), "Prescription for appointment 17", "2025-05-07" },
                    { new Guid("35a249ae-028d-4d6f-a4ad-d1e664b3cce1"), new Guid("e5f9b64c-6b91-4a16-8bc3-4fb3f1be0184"), "Prescription for appointment 5", "2025-05-07" },
                    { new Guid("368df7b1-3b9a-416a-9002-c9601caeaaff"), new Guid("1bf3fff2-508c-401a-84ff-aa74917b326c"), "Prescription for appointment 2", "2025-05-07" },
                    { new Guid("396c3760-70a0-4626-ba3e-2f4b1420113c"), new Guid("c711f1ad-0dd8-44fd-b4b1-7dc2bb66b82a"), "Prescription for appointment 1", "2025-05-07" },
                    { new Guid("3a2722dc-eb61-4eb0-88ec-9676a611e8da"), new Guid("0a602e42-9903-48b0-9662-d97fc7aaa696"), "Prescription for appointment 14", "2025-05-07" },
                    { new Guid("41645a3b-bb08-4682-89a6-5f7d3ca3e7a8"), new Guid("a9d684cb-6b55-4548-bc4f-53066154d4a3"), "Prescription for appointment 16", "2025-05-07" },
                    { new Guid("458fd1d9-6065-4b87-95ce-bc048af51877"), new Guid("f22723c3-9bad-48f8-96e2-7068b9b2c7c2"), "Prescription for appointment 15", "2025-05-07" },
                    { new Guid("46b5966d-c1ea-4443-a126-17fd8d48d39f"), new Guid("b3005730-d21e-41d2-bb60-bc7c0676139c"), "Prescription for appointment 17", "2025-05-07" },
                    { new Guid("47e01f92-f52e-47f0-b58f-85b6f014cc73"), new Guid("2594f9b9-4f5d-4e14-b221-a7863c050d3f"), "Prescription for appointment 9", "2025-05-07" },
                    { new Guid("4c328a02-c03d-4386-944a-0d3b7499376c"), new Guid("e811f890-0a50-41cd-b508-1a9b2e9eaba7"), "Prescription for appointment 8", "2025-05-07" },
                    { new Guid("4cc1b983-aebf-4d3b-ad68-ab11058a8e23"), new Guid("1b322e6a-aab0-4f66-b01d-f65071bc23c3"), "Prescription for appointment 4", "2025-05-07" },
                    { new Guid("4ee1f110-27a5-4352-b0dd-bd624f62a75d"), new Guid("c16ad5de-562d-4dd9-ab83-8edf08040f1b"), "Prescription for appointment 9", "2025-05-07" },
                    { new Guid("53ff5df0-2891-403e-8d6f-182dbac378bc"), new Guid("8b4e9d9d-e6f8-42a2-bd58-80908c6fd8ce"), "Prescription for appointment 10", "2025-05-07" },
                    { new Guid("563c65d8-1d37-405c-a606-c1a42b20e6f3"), new Guid("9493cbdb-0311-48ab-b53c-82821d15e98a"), "Prescription for appointment 12", "2025-05-07" },
                    { new Guid("5845b6e3-1859-4611-a11c-a0334e177a7c"), new Guid("927facf6-983e-496f-bb39-8c67298eee66"), "Prescription for appointment 15", "2025-05-07" },
                    { new Guid("597d0cae-db99-4dc8-8d66-dbaae14b31b0"), new Guid("8c5600ba-1e20-4afb-b919-08e89638de57"), "Prescription for appointment 2", "2025-05-07" },
                    { new Guid("598d761f-ac3f-4033-b8d8-a5398bc669f8"), new Guid("fe558d48-4921-49e8-959e-9d14f77a8109"), "Prescription for appointment 14", "2025-05-07" },
                    { new Guid("5bb81cf7-295a-43ce-9ce0-0255b35cff01"), new Guid("082c45d8-5819-48e3-92cf-cc546669aea7"), "Prescription for appointment 6", "2025-05-07" },
                    { new Guid("5e22b191-29aa-41b2-87a6-c81590bb52ce"), new Guid("340f9440-611d-45d6-a8d9-05b71842ef22"), "Prescription for appointment 6", "2025-05-07" },
                    { new Guid("6506a658-4623-41a3-bab3-874068cef384"), new Guid("117e6342-e3f7-4412-af0b-e153672ec5b0"), "Prescription for appointment 18", "2025-05-07" },
                    { new Guid("667915b5-154e-49f3-a044-a3d83569d749"), new Guid("c2dee39e-aedb-4d67-8964-6a2b97cd21c6"), "Prescription for appointment 11", "2025-05-07" },
                    { new Guid("6799fa63-1031-48de-b3d8-a9d1e6568274"), new Guid("9b27f7de-aa7e-4ad8-bc40-015d90ba34cf"), "Prescription for appointment 8", "2025-05-07" },
                    { new Guid("67e1623c-595d-4139-bd14-11ed7afcbd37"), new Guid("5fd82aa0-6045-4aa0-a4eb-8f65ba5dc53d"), "Prescription for appointment 15", "2025-05-07" },
                    { new Guid("6a76dac2-f0b2-4038-bfb2-51d57c5e617b"), new Guid("5a820ae6-654a-4c81-9c61-5d959a6f565e"), "Prescription for appointment 4", "2025-05-07" },
                    { new Guid("6c939950-2f3f-43df-82f5-53c44c86cff7"), new Guid("34158a23-c316-47b8-9977-17beb312b448"), "Prescription for appointment 2", "2025-05-07" },
                    { new Guid("71b6d47d-4164-4874-b76f-43f8255d1fa2"), new Guid("a33500fb-6dfd-4ca0-8bef-24272f37ed7f"), "Prescription for appointment 3", "2025-05-07" },
                    { new Guid("74304180-7e3f-4c5e-8476-e924054c0585"), new Guid("89c6c5fa-5a55-4662-80b2-8c5d19229406"), "Prescription for appointment 13", "2025-05-07" },
                    { new Guid("79a07422-bf85-459c-93ba-2f492bbb01af"), new Guid("c8db2deb-5a28-464d-994f-114b6a054bb8"), "Prescription for appointment 9", "2025-05-07" },
                    { new Guid("7bb77394-410a-4e3c-9b8d-2212d04cd79d"), new Guid("5a56fd94-b5e9-4ade-a639-b57b9c5add81"), "Prescription for appointment 20", "2025-05-07" },
                    { new Guid("8439cf2e-0e1f-45fb-988b-6d7717f1ceff"), new Guid("edce17fc-ee3e-43d8-b4ec-a6cc1740862d"), "Prescription for appointment 7", "2025-05-07" },
                    { new Guid("84a3dad0-3ecf-4461-a8ae-34ac1c8aa212"), new Guid("1903c592-abd7-4621-8b12-acad2f17b062"), "Prescription for appointment 11", "2025-05-07" },
                    { new Guid("8b19ecff-1f2a-492c-acb5-dbf87a9d55bd"), new Guid("2fce5827-1abb-4044-af79-32b5f8e49505"), "Prescription for appointment 17", "2025-05-07" },
                    { new Guid("8f2eedbe-6a9f-4a1f-850f-13d951c38bf2"), new Guid("97d0291f-1762-4fea-ae1b-11885bee6755"), "Prescription for appointment 11", "2025-05-07" },
                    { new Guid("92c931f6-41ab-4aa2-a575-ef41076ab855"), new Guid("30f713d5-5255-4ddc-92e4-4d8964285fe6"), "Prescription for appointment 18", "2025-05-07" },
                    { new Guid("9620b308-a347-4c40-b668-a44893e855b9"), new Guid("ed3cf7ae-f251-4376-8683-7435ae28282f"), "Prescription for appointment 4", "2025-05-07" },
                    { new Guid("a196025b-24d6-4f75-9981-3f375f827bfa"), new Guid("732c7e1a-1ece-4472-9f7e-9c6d308ef715"), "Prescription for appointment 17", "2025-05-07" },
                    { new Guid("a2385649-3c5a-4212-acd6-941c7dc23e03"), new Guid("c9ee7aa2-a3b6-47bb-b489-d299ff7af12e"), "Prescription for appointment 20", "2025-05-07" },
                    { new Guid("a5587f51-801c-40bf-b297-0a28a8720bff"), new Guid("915cb1db-ce30-4bbe-a0d1-d4a6c4d2cb7e"), "Prescription for appointment 13", "2025-05-07" },
                    { new Guid("a57836dc-10de-4ae5-89f6-d5fbb4d09246"), new Guid("0a6bb835-1ae9-4693-8df0-d2354753df68"), "Prescription for appointment 7", "2025-05-07" },
                    { new Guid("a6d3aed0-e09a-4c06-a3f2-a12f23b498b3"), new Guid("ef2e7e6f-3c6f-4c69-b164-31902f8adbc0"), "Prescription for appointment 18", "2025-05-07" },
                    { new Guid("ab5410fc-41f9-4638-8ae0-5473b240866e"), new Guid("07e5f1a2-faf7-4e04-a2e8-13ad76ab5523"), "Prescription for appointment 5", "2025-05-07" },
                    { new Guid("b57034ad-9ee2-4f80-9f32-b8eb068fa828"), new Guid("4018eb77-e05a-4bfb-897d-776195eb2b1b"), "Prescription for appointment 7", "2025-05-07" },
                    { new Guid("b8bfcb0b-71d8-4f2a-b56f-0171db8e21d1"), new Guid("8734a5e7-262e-456c-ac16-b66309076a8e"), "Prescription for appointment 7", "2025-05-07" },
                    { new Guid("c478e35d-d8a4-4ffc-a656-50e29fac7371"), new Guid("e898b1f4-7330-4104-b1b0-ed7966e8a7f1"), "Prescription for appointment 5", "2025-05-07" },
                    { new Guid("c765d831-9c96-470b-b44d-a4b7d38d5a09"), new Guid("92fd05bd-5bbf-4865-b0a0-4b19d24bf0df"), "Prescription for appointment 16", "2025-05-07" },
                    { new Guid("c78c4980-044d-4baf-b2dd-14edf0879b1c"), new Guid("3ed24390-3494-43ec-80f5-825270929741"), "Prescription for appointment 10", "2025-05-07" },
                    { new Guid("c887967a-55f9-4560-97d2-2a917e8e8024"), new Guid("722882f0-4e6a-406d-b4d6-ad582e50978a"), "Prescription for appointment 19", "2025-05-07" },
                    { new Guid("c9a8498f-7574-410a-bdf2-ec1863a30237"), new Guid("59ae2185-719a-4c24-b319-875d3d168441"), "Prescription for appointment 14", "2025-05-07" },
                    { new Guid("cf485009-2070-4073-adbb-1cc16eb12483"), new Guid("2c442185-975a-45cd-9bdc-3106c36fca9f"), "Prescription for appointment 12", "2025-05-07" },
                    { new Guid("d4b5a845-78f2-4461-a743-b7c9c7a63f8b"), new Guid("e3adf908-019f-4822-8e6f-b31e6ae25685"), "Prescription for appointment 8", "2025-05-07" },
                    { new Guid("d6495406-99b9-4263-b0af-d966ba79dd2e"), new Guid("9f1174a7-2c2b-48b0-a9f2-87a057a9eed8"), "Prescription for appointment 5", "2025-05-07" },
                    { new Guid("d96ba38c-6587-421a-b34e-2121a7b7160d"), new Guid("4091e5a4-c59b-4ed7-84b7-94108dfbc6fc"), "Prescription for appointment 20", "2025-05-07" },
                    { new Guid("dabdfc14-208d-4146-b38f-842da88fc1d9"), new Guid("1f2dd148-d438-4e4d-a021-f22c4f5aaed4"), "Prescription for appointment 13", "2025-05-07" },
                    { new Guid("dc2c4745-9077-45e1-a9ee-8a4959e9c450"), new Guid("f8c816d6-ac3b-4b51-9073-a415388885c0"), "Prescription for appointment 2", "2025-05-07" },
                    { new Guid("e3f148ee-1c3d-40d4-9cc7-46380e3d4c58"), new Guid("8bd050bc-d0c6-478c-a750-095300a0ec57"), "Prescription for appointment 19", "2025-05-07" },
                    { new Guid("ead8d5aa-f212-4d96-9265-3402d130faa0"), new Guid("2d6a5cef-e5b5-4eb9-bd68-7b9356152682"), "Prescription for appointment 11", "2025-05-07" },
                    { new Guid("ee6ffcd9-084f-435f-8d1f-c15f41812ae3"), new Guid("304b0f60-2139-4705-ac09-5a507a179365"), "Prescription for appointment 14", "2025-05-07" },
                    { new Guid("f15ca338-09a5-4b5c-8f90-be2138173f3e"), new Guid("e816e287-e209-4b6e-92c1-c70fe0f0c5d4"), "Prescription for appointment 3", "2025-05-07" },
                    { new Guid("f450dd44-e7ab-4313-8837-e0d99e406dee"), new Guid("e6810a18-679b-4871-9fff-1456c3c9a89f"), "Prescription for appointment 15", "2025-05-07" },
                    { new Guid("f52dc1a5-a1d5-46aa-b0c0-c84c86cd8f98"), new Guid("1fa79beb-1f43-479b-bba1-2fd822789d59"), "Prescription for appointment 6", "2025-05-07" },
                    { new Guid("f5a7c5e7-ab12-4fd7-8c9b-8ecf0d084f84"), new Guid("183410ad-0d87-402a-9a38-f376fd09da0a"), "Prescription for appointment 18", "2025-05-07" },
                    { new Guid("f77c0b92-cddb-4ecb-bcf4-bb668f50ec62"), new Guid("942bdc3a-02d8-4fef-8611-be79c6910f3f"), "Prescription for appointment 1", "2025-05-07" },
                    { new Guid("fcc31076-6776-40d4-b7e3-289201e17a0a"), new Guid("325e5314-3f28-4acf-922d-13988f60ea77"), "Prescription for appointment 10", "2025-05-07" },
                    { new Guid("fef936ed-f496-4e98-99f7-21f252de40fd"), new Guid("8825a3d8-2a81-457c-8c75-0c92566fa313"), "Prescription for appointment 3", "2025-05-07" }
                });
        }
    }
}
