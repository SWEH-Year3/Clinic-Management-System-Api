using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedRolesAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "06ef133d-a03d-4045-9dff-03ba2353c36b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "0b1b1a02-ff25-46e8-add7-b55bc94596db" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "0df249dc-078d-4f0a-9709-d3f628d5fce7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "1660ddf2-fc20-40ae-a0e0-a9b3c6ef1489" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "1c63783b-affc-40f1-9d4f-f4d4593ff09d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "1d74cdaa-fe65-4358-88c6-cd1d2eeb86b4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "1db9741a-8ead-4416-8207-d6ed26176eb9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "1e6e6d31-1208-4254-84a0-666ef240af48" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "1e7230ac-2344-47e4-b698-ef958bc93868" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "26f898b8-0deb-4ba9-8058-354a737a4687" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "29cb3ec1-e138-439b-9128-922bf2b3c338" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "29e30fb1-8998-4b05-adeb-5a75884e2aca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "2db8c815-4497-4a2c-9567-eb555115d05b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "31a5d5ca-755b-4295-a6b5-1c6e90a4f051" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "38d495e2-af91-4b97-89e1-60827bb63a24" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "39f173ee-43e0-4b2d-a5bd-973e513472cc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "4319c960-bf8a-4a56-8591-ac477d434d0e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "507c3fc0-7ba1-45b6-8f4e-70daeee6a87b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "52cbe818-dd65-46ce-8764-830a3d9008f6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "640ba30c-0831-4e9d-b677-fc4dbd052882" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "66f7c3ff-cf5d-4022-9d03-4bcefc1e0a25" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "670ab904-39e1-4d71-b77d-9058c4fb3826" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "73e422a2-ff2d-40da-ae75-82c96d3d0778" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "82624f06-56f4-49c8-84e4-dc5bb33c5247" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "88f16ccb-22ec-44f0-9f07-092241c4643c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "93b598d1-17b3-427f-9488-a1e9e998aa6c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "9f1d1b06-f65f-49e9-96e4-4c2b73b83983" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "a05a6664-68b9-48ff-a760-42b2f5b16e7f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "a3d69e15-a1a0-40b7-b29d-4c509ef3abb2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "ae9e4a55-1221-440a-9e81-26436f64666a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "b2b74884-dc36-40af-a889-de4b0d44030a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "b7041f80-6512-4fa9-b99e-7fa037fe1383" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "c7758f2b-c854-4002-b334-1700df4c9a96" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "ca9d8238-f49e-46e1-a9d7-9f5dc745e22c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "cbff071f-b407-4dd2-a5c5-e4381cf5a5b7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "d329a52a-f062-483b-8ee0-5ee8bddec3cd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "e8d1902f-57d2-4718-85c7-1cf5f0a1ca18" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "ee9464c4-72dd-487e-abae-f28eb1f283d6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "f6c65f86-cf25-455b-b8e9-cf7ce3da6616" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "f8962ac8-7736-429c-8370-b6a5706114c5" });

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("06fb88b0-a3f4-4695-86e7-a6a55d7d1381"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("07c58e22-edfb-4862-a5a6-fe67fef640b6"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("0a4e6800-29f9-4ea8-acda-762843d1a5e7"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("171772ac-4f55-4352-acd3-984fc24fd21e"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("186bb93b-1d1e-4653-b9ab-8dd17952fe54"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("1c8f1052-d43c-445c-a644-78af76fcbd40"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("35aa7d28-c3fa-4009-91d9-02e92fb697a5"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("37ecd7c3-ca7f-41af-b336-818aad0d2ac0"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("51316038-270f-4515-81d2-a6aa49fea6f3"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("7acb50e7-40ac-4b1f-a0a2-e21f6e4a0133"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("7c4a3156-2e4e-45bc-9def-94c35f2d39d7"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("8e74b5c0-da63-4131-8957-29d690e2974e"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("8fc62aee-d315-459f-84ab-224e37f95ba8"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("a1a09032-f9fb-4e70-9a61-18299f48912f"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("bb84d3e2-f9c5-4bb3-80ca-ecea4332613a"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("ccb9531f-d8a5-4d06-bb7f-4a29951dfb2c"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("d9355738-e01a-4c49-8b4a-12d5885ec39c"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("ee977b97-7362-4eb1-aac8-c2de724a2f5d"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("fbc09132-f975-4c50-8dd2-34851d46c601"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("ff3bc475-cf1e-4581-8d30-de2155f3799f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1caad92d-bac0-4527-b80f-7ea7cf0ea111"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("212a8a00-70ea-4ddd-afb7-e034e65148be"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("2a64bbf9-583f-4112-966f-d46740a872bc"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("36218d0f-f9b6-4246-84b2-d78c1bd75b02"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("3731761a-ebb4-4f64-a520-f98f9cac23e6"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("4a9aa06f-481e-42a3-9102-780c16504f88"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("4b77b84f-42f0-4efd-b35c-290b75caabcb"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("6e897d9a-896d-469b-8243-886bb116ea3d"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("825ed25d-b7e1-4a69-bd8d-3d23678adc38"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9501cc24-b228-4837-8f9b-8bfe9de64832"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9c45c14e-3653-43f8-a411-e43b4a1d58f7"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("9ee67f13-e69d-41cd-9cb7-7aa6a8725f7e"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("a2a3c34d-54f5-4ea2-b3a6-35e9d03b41bb"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("bea03a0a-a2e0-4781-b423-d42860218600"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e2c9aec5-98bf-45b3-a9df-ab27262dc4b3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e6345352-3410-464c-8578-0f5e2ef83cfe"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f31a040b-2eb0-4661-9d58-3c3fbffd6402"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f4d86dcb-838c-4d6b-93e0-dde2f1a5ebae"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f4ea6c65-2b12-4690-8b95-887f9ea4ffe3"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("fe7462a6-f917-4d32-b742-3e67ea67a3e4"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b1b1a02-ff25-46e8-add7-b55bc94596db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0df249dc-078d-4f0a-9709-d3f628d5fce7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c63783b-affc-40f1-9d4f-f4d4593ff09d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26f898b8-0deb-4ba9-8058-354a737a4687");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29cb3ec1-e138-439b-9128-922bf2b3c338");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29e30fb1-8998-4b05-adeb-5a75884e2aca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31a5d5ca-755b-4295-a6b5-1c6e90a4f051");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4319c960-bf8a-4a56-8591-ac477d434d0e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "507c3fc0-7ba1-45b6-8f4e-70daeee6a87b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52cbe818-dd65-46ce-8764-830a3d9008f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66f7c3ff-cf5d-4022-9d03-4bcefc1e0a25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82624f06-56f4-49c8-84e4-dc5bb33c5247");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f1d1b06-f65f-49e9-96e4-4c2b73b83983");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a05a6664-68b9-48ff-a760-42b2f5b16e7f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae9e4a55-1221-440a-9e81-26436f64666a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca9d8238-f49e-46e1-a9d7-9f5dc745e22c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cbff071f-b407-4dd2-a5c5-e4381cf5a5b7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8d1902f-57d2-4718-85c7-1cf5f0a1ca18");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f6c65f86-cf25-455b-b8e9-cf7ce3da6616");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f8962ac8-7736-429c-8370-b6a5706114c5");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("06d45262-87d8-4219-bb23-8acff618d7f5"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1a2f49ba-da0e-4535-a79e-cc158fce99c1"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1c164853-7e4d-4afa-9ad8-9fe98385802e"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1d67eaef-637d-47b3-b6f4-3914e5e07472"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("2a0b83bf-316d-4bf4-b4a1-c9951bf23464"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("34a5d994-d051-4f61-936c-8a9851f8b7d6"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("428d16f9-acc5-477e-8157-484d88e54c7e"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("457be12e-9fcf-4509-a7ac-fe97a46229a6"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4d186b3c-69a4-4956-9657-49b81ad7938e"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("58e9b0ca-4cb2-40b1-a834-ba50ee16b3df"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("5fca8307-11e7-48c3-9f30-d36c205ffb58"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("622131d6-49bc-40a4-848c-41af48f51b48"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("6ca827fc-10f0-4329-85a6-a25916ba22ac"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("7426cc31-387c-4357-b0f3-05c06b3e57ce"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("79c290a0-dcce-4ecc-be7a-7b841e83ea09"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("9ea2cd4a-2c48-429a-b04a-c48a58c977d8"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("aa0c65cf-a02e-4674-8422-3f713f6632f2"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("cab0f693-2a97-43d2-bee3-01e4da18a12d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("e25eff5e-9a84-478e-ac04-ee5567fde919"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("eae35e10-9825-4944-adfa-9961a25d6f55"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ef133d-a03d-4045-9dff-03ba2353c36b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1660ddf2-fc20-40ae-a0e0-a9b3c6ef1489");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d74cdaa-fe65-4358-88c6-cd1d2eeb86b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1db9741a-8ead-4416-8207-d6ed26176eb9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e6e6d31-1208-4254-84a0-666ef240af48");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e7230ac-2344-47e4-b698-ef958bc93868");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2db8c815-4497-4a2c-9567-eb555115d05b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38d495e2-af91-4b97-89e1-60827bb63a24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39f173ee-43e0-4b2d-a5bd-973e513472cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "640ba30c-0831-4e9d-b677-fc4dbd052882");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "670ab904-39e1-4d71-b77d-9058c4fb3826");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73e422a2-ff2d-40da-ae75-82c96d3d0778");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "88f16ccb-22ec-44f0-9f07-092241c4643c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "93b598d1-17b3-427f-9488-a1e9e998aa6c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a3d69e15-a1a0-40b7-b29d-4c509ef3abb2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2b74884-dc36-40af-a889-de4b0d44030a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b7041f80-6512-4fa9-b99e-7fa037fe1383");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7758f2b-c854-4002-b334-1700df4c9a96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d329a52a-f062-483b-8ee0-5ee8bddec3cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ee9464c4-72dd-487e-abae-f28eb1f283d6");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00adac97-ef12-4ee0-89d2-9668bad3e333", 0, "e005fc72-9795-4090-a38e-b1d3128c1266", "doctor19@clinic.com", true, false, null, "DOCTOR19@CLINIC.COM", "DOCTOR19@CLINIC.COM", "AQAAAAIAAYagAAAAEKhVcNEkg53lL8lv5y/MkIB54vetfiShRh3VT9b2BIuLSeB6V+FblRlQ8pXGOhgbkQ==", "01100000019", true, "37a52fe9-6b03-4f80-b7c4-e21489e9a22e", false, "doctor19@clinic.com" },
                    { "023978a1-0aad-43dc-8b37-b9bfa1c69d64", 0, "69e708e7-01db-461b-a715-1c363001c960", "patient10@clinic.com", true, false, null, "PATIENT10@CLINIC.COM", "PATIENT10@CLINIC.COM", "AQAAAAIAAYagAAAAEH4ETVRLxHCaVmU+LwBrtJ1rNH1ts/Gf8Iu/Tx4kEgwW6xZJIEizNGcnq4jHxLKsBA==", "01000000010", true, "26db7d63-fa30-4941-9ccb-05d9d828efa2", false, "patient10@clinic.com" },
                    { "0a9b1a7d-d3de-4c07-bfed-f490dfb0d063", 0, "8619676a-cebf-4e65-93f7-7446e70da021", "doctor7@clinic.com", true, false, null, "DOCTOR7@CLINIC.COM", "DOCTOR7@CLINIC.COM", "AQAAAAIAAYagAAAAEBF0Xmg1xRnIOnSt72l+YyWj3GnjRgbNl7F/1l5aps75nOi0XMKiFeVdXfAy/EUivQ==", "01100000007", true, "75d19d7d-62d3-4020-9b11-72e633146463", false, "doctor7@clinic.com" },
                    { "0aeed420-b2f6-4718-a55f-91e9014e15f3", 0, "80597ec7-9f93-4242-824a-9336ac18f33a", "doctor6@clinic.com", true, false, null, "DOCTOR6@CLINIC.COM", "DOCTOR6@CLINIC.COM", "AQAAAAIAAYagAAAAEPuwynyLF26dIzf2jiCzVBIeB+wILgT7eQIh5fdymsjclD3Vad9pN6VN0T5IORCSlA==", "01100000006", true, "dc146ab2-bc5d-4ade-8c52-79b61a81e666", false, "doctor6@clinic.com" },
                    { "0e97bb17-b2c1-467d-8774-411fa6799da5", 0, "df2e33e2-5241-4bcf-8c7a-313effd5d019", "patient18@clinic.com", true, false, null, "PATIENT18@CLINIC.COM", "PATIENT18@CLINIC.COM", "AQAAAAIAAYagAAAAEMSyMelgoiJZb4CuJNp8iek0HBXs1CuuN9YN9/8BLET4MKnKJ2xmwNP6fq3o4NHH9g==", "01000000018", true, "7db2c316-f436-41f9-901d-6a5baf2382df", false, "patient18@clinic.com" },
                    { "148a40a7-da4e-4e1b-a003-9e58c0d6d485", 0, "986ae99b-79bc-4a98-af8e-fa0b333e2509", "doctor17@clinic.com", true, false, null, "DOCTOR17@CLINIC.COM", "DOCTOR17@CLINIC.COM", "AQAAAAIAAYagAAAAEJ94yMuT9LTSiadpZihYJk+FJIlxJ0hVYV6qvp38ZW3/hT0bG6rGZMrjOcCfSBOd3g==", "01100000017", true, "9c91c9a7-e4b6-45ca-967c-342648b0d747", false, "doctor17@clinic.com" },
                    { "1e77598e-eb16-412e-9d18-a2f1b6256387", 0, "ac06e920-db91-4e89-844b-c71bfa73e958", "patient13@clinic.com", true, false, null, "PATIENT13@CLINIC.COM", "PATIENT13@CLINIC.COM", "AQAAAAIAAYagAAAAEPcFYBTmBEvKfLjTfTq5zG0uZ6rGtywLfcJlvcqMqJ5Yo3prhY1I3WC87WAX3aQFqQ==", "01000000013", true, "1ac59bc2-5254-4ceb-b8ed-a8926831d816", false, "patient13@clinic.com" },
                    { "22d0e279-b1bd-4e5d-87d5-4ef437e35487", 0, "952d42a9-726c-42ac-b599-d931dd4f2621", "doctor10@clinic.com", true, false, null, "DOCTOR10@CLINIC.COM", "DOCTOR10@CLINIC.COM", "AQAAAAIAAYagAAAAEFaK2iUCqzB+aGfzFQtEwwDnXlq3IqyT4z1wPN3RNBYKls/e4ETJMC2DsM8VaspNRA==", "01100000010", true, "33e3fa92-c9dc-4aea-9e55-e30222d723af", false, "doctor10@clinic.com" },
                    { "2ec8090b-edb6-42d2-9109-c8296f933566", 0, "2055b24a-2f10-4f00-8354-a1f158c34e22", "patient7@clinic.com", true, false, null, "PATIENT7@CLINIC.COM", "PATIENT7@CLINIC.COM", "AQAAAAIAAYagAAAAEHmS+liqDu+/Ykf+M36/H22qXCQgJEEHOe6rt+iDQf5mwWS4ew5ts1cpx+xPYG6/wg==", "01000000007", true, "4e36b4b7-e000-4863-a88b-b4b104c09cf1", false, "patient7@clinic.com" },
                    { "32366f4e-6267-4b6d-87ae-6df02db5f393", 0, "3d71fdb4-931e-4130-858c-519fa788c315", "doctor5@clinic.com", true, false, null, "DOCTOR5@CLINIC.COM", "DOCTOR5@CLINIC.COM", "AQAAAAIAAYagAAAAEBnvXY3zlmVLaz/hBY9lNxxIhV2QV9cdp8DcIKRUR3e/tbPo2QpGK/V4hJD75MYH1A==", "01100000005", true, "d29dc125-5dc1-4bc9-a758-1b824be6266b", false, "doctor5@clinic.com" },
                    { "39344909-14a6-4fec-b23e-9e2269cfe94f", 0, "530afed5-bea3-4fad-846b-a91e36a30e5c", "patient20@clinic.com", true, false, null, "PATIENT20@CLINIC.COM", "PATIENT20@CLINIC.COM", "AQAAAAIAAYagAAAAECaIxLRlyHe+vJnBai1zyzrM4kdjYlEpVkIL8j2dIBIHWV7AtiaKjFzOmceDuoMG5w==", "01000000020", true, "86f5f857-1733-4163-a17b-38d32e5a5318", false, "patient20@clinic.com" },
                    { "413a2466-e957-431c-837c-20a44fae1d27", 0, "56962d5f-12df-483f-9040-dcaf852e3fb6", "patient19@clinic.com", true, false, null, "PATIENT19@CLINIC.COM", "PATIENT19@CLINIC.COM", "AQAAAAIAAYagAAAAEIE8GDPwDX8WSlVIKq9T93elJBqANszrnEFM4OibdOG74qLBnQ1DxBdfFdxwlD4blw==", "01000000019", true, "150bdc58-f959-443d-bbdc-ca6d52e5511b", false, "patient19@clinic.com" },
                    { "45453ec6-1845-4c04-b76b-641a0e1e350f", 0, "cc4b80be-159e-4a60-bb8f-d1e1baa440a7", "doctor18@clinic.com", true, false, null, "DOCTOR18@CLINIC.COM", "DOCTOR18@CLINIC.COM", "AQAAAAIAAYagAAAAEOZ6nyGUWd2tqZmmGqbvH2NLFK+IMtNfrL2Iwj4Vf9Z2rFMrlZZFdfXXaJMGWk68nA==", "01100000018", true, "b403a021-ef27-4383-8481-e190a52b4413", false, "doctor18@clinic.com" },
                    { "46c76612-1744-4125-9fa2-404d4d586a6e", 0, "bdfdef9b-14f7-4c62-98b5-289a8eb9062c", "doctor20@clinic.com", true, false, null, "DOCTOR20@CLINIC.COM", "DOCTOR20@CLINIC.COM", "AQAAAAIAAYagAAAAEBl+DMPknJdq6MUDy9KYsJC+S2DfcDiuPr6Dddj85cAYHUew3zWGHhGgUw0uL9clAQ==", "01100000020", true, "1c8cb472-61c1-412d-a84c-0be4fc63df34", false, "doctor20@clinic.com" },
                    { "494a9306-12d3-48e8-9249-49a2ace53649", 0, "81ee8b45-775e-4fb3-bbde-d14ce413a738", "doctor15@clinic.com", true, false, null, "DOCTOR15@CLINIC.COM", "DOCTOR15@CLINIC.COM", "AQAAAAIAAYagAAAAEAVz3daxjv29B4F1BszIsTBtG5RIsV6G6/nN2BXKs7HFJ7J+e0JHC4w6H4s37C5e+A==", "01100000015", true, "e29cd504-f45b-46d3-9045-e57623a364e1", false, "doctor15@clinic.com" },
                    { "5b57a12b-2656-440a-9157-6960a1051205", 0, "3306f121-0687-4531-8413-b5bb38aa4d93", "patient12@clinic.com", true, false, null, "PATIENT12@CLINIC.COM", "PATIENT12@CLINIC.COM", "AQAAAAIAAYagAAAAECjr7jaj2lSvYpurbXiMYNTrSAbjnOEl8+I+naL1U1XNNtN/z3YdmFWQazx219kaXg==", "01000000012", true, "fab79c2f-979e-4f01-a60b-476a1a2e4e41", false, "patient12@clinic.com" },
                    { "6201941c-43f3-4fb2-9fe0-5131071e84b8", 0, "c3f76ca2-ec8f-42d0-8bb9-0a115a9502e5", "doctor8@clinic.com", true, false, null, "DOCTOR8@CLINIC.COM", "DOCTOR8@CLINIC.COM", "AQAAAAIAAYagAAAAEE3NmMbDUC2B2ARG4/yrTjulWRNfLd5m9uua0wUVp8qxPV4kGwc/UBBxF8IGN3IBrg==", "01100000008", true, "17858c4d-8165-4526-9d8b-2f72d3d65c4d", false, "doctor8@clinic.com" },
                    { "653a6b90-4762-4a70-bfbf-8ac6c4934969", 0, "d0b83f48-85a9-4372-98b8-7bae558ca7a9", "doctor2@clinic.com", true, false, null, "DOCTOR2@CLINIC.COM", "DOCTOR2@CLINIC.COM", "AQAAAAIAAYagAAAAEI77FwBM9kFuFUeiZoghSgHGaZ9BNjc6IfDMT5nGjVPu2Pur5gR6XApYVTZqSOwIGg==", "01100000002", true, "20579d53-bfaf-4e26-bbd4-48a99dd990b9", false, "doctor2@clinic.com" },
                    { "6627e77d-6c04-4165-a1a9-8e45915006a3", 0, "1fac11e9-b59c-45da-9535-46c1cd7e0e77", "patient5@clinic.com", true, false, null, "PATIENT5@CLINIC.COM", "PATIENT5@CLINIC.COM", "AQAAAAIAAYagAAAAEM4BAEYfIJkT6comCaHVy4czRsuF3lBcQzdD6lI7zNUsswlsB/LC8rBh2jo81XuSuQ==", "01000000005", true, "b36c51f1-a07c-4b3b-b5a0-bd55a13fec63", false, "patient5@clinic.com" },
                    { "755a8257-ad4c-44ac-8e69-ae15c27eb1e0", 0, "5370ec16-f557-45fa-b06b-707bbdd3c686", "admin3@clinic.com", true, false, null, "ADMIN3@CLINIC.COM", "ADMIN3@CLINIC.COM", "AQAAAAIAAYagAAAAECgP5P5TyiZ2Y70PZBNw6qLFRVuOJCd4rXssqi/9Ph/ijgEsFHLExwx4MOKVG7AvVQ==", "01000000003", true, "81baf9b3-bc20-4e10-901a-0a0ee7c4bb25", false, "admin3@clinic.com" },
                    { "7a899aed-90ea-4e2c-9e63-f9694ca2b3bd", 0, "1b742baa-35bd-4ed4-bd9f-8ace131f458c", "patient16@clinic.com", true, false, null, "PATIENT16@CLINIC.COM", "PATIENT16@CLINIC.COM", "AQAAAAIAAYagAAAAEKYKNw7vx4LjBcdApaamSyvnqHp1kxxsMPtyS1MjO302F/NeBf/LeEvJmy3/wA0SBg==", "01000000016", true, "87316bb2-9b76-405c-8547-642810c83048", false, "patient16@clinic.com" },
                    { "84c82c8d-886c-4f3c-a0ae-a9f674c397a6", 0, "86750616-8fc7-4313-a252-8008d7840b2b", "doctor16@clinic.com", true, false, null, "DOCTOR16@CLINIC.COM", "DOCTOR16@CLINIC.COM", "AQAAAAIAAYagAAAAEIW2sRDy7+U+35PiisjNw6GEdcX8jTlk5yjsVyq4nMQpto4HMaN2VQI11vrXucDhTA==", "01100000016", true, "69cd2e32-a286-4147-9ca9-4281c4afa333", false, "doctor16@clinic.com" },
                    { "86689581-87c8-4d18-a12e-b521929851d9", 0, "7702d2a9-6e59-43e6-bcf9-04d867e0ae2f", "doctor1@clinic.com", true, false, null, "DOCTOR1@CLINIC.COM", "DOCTOR1@CLINIC.COM", "AQAAAAIAAYagAAAAEG+kzIuKR5vUPTBuEZMSYXQ0Tf8aLyDvoVCo/S2KSOrnF9jaAD4bPKuT2ORGLsnJfA==", "01100000001", true, "f042a74f-493c-4003-af7a-20edbdcbcc05", false, "doctor1@clinic.com" },
                    { "8bb59f45-c04f-49cd-bdb1-67196483be35", 0, "5c26d331-fc5f-498f-bb9f-9ab6e3879b06", "admin5@clinic.com", true, false, null, "ADMIN5@CLINIC.COM", "ADMIN5@CLINIC.COM", "AQAAAAIAAYagAAAAEC/UbeBuKgFhU4BPVbO+ysI3CM9KC7xSiEUcw1nzD6H8MvVX6N/IzUEyibPS/uWQeA==", "01000000005", true, "7c9f23b9-1e4a-4ef3-99f2-0acdfab1e8b9", false, "admin5@clinic.com" },
                    { "8ca7d99f-35d7-4651-836c-d9d061a49427", 0, "483ae3aa-ee31-4c0e-ac98-f59ef9d8a988", "patient2@clinic.com", true, false, null, "PATIENT2@CLINIC.COM", "PATIENT2@CLINIC.COM", "AQAAAAIAAYagAAAAENzppQZrYZRjdmliNVatniguTpdieA5SThjtpeRTkFc0qyzXLqK7DeLWnmdrae2jQQ==", "01000000002", true, "741d9a2a-6c2b-4651-b05c-e660ce8117a7", false, "patient2@clinic.com" },
                    { "8f1aa731-8712-40ea-b6e4-8ba29cb9f16d", 0, "df70c137-910c-491b-a070-2d6a217955df", "doctor4@clinic.com", true, false, null, "DOCTOR4@CLINIC.COM", "DOCTOR4@CLINIC.COM", "AQAAAAIAAYagAAAAEEB6hFq+d0gYxFMjBirOBUNdUMszmbd4OH/DaboEY7m8E9fOH6muAVNmPg1x4G5fWQ==", "01100000004", true, "a717cfaf-0000-4e4c-be1f-c5c10f7eff35", false, "doctor4@clinic.com" },
                    { "931c0531-e15c-48e1-8a5c-b30c62eb50f9", 0, "2674d4ca-c2bc-48f7-93ba-9fca2219cf71", "patient4@clinic.com", true, false, null, "PATIENT4@CLINIC.COM", "PATIENT4@CLINIC.COM", "AQAAAAIAAYagAAAAEBCJ7xY59Cl5CG8j50++REevvgg5tkma01Zd7JsoRcpnDNHjKeI3cKRCg+tJuYYtcA==", "01000000004", true, "b6be843c-8f3c-4c2a-937a-1b1eea6d040f", false, "patient4@clinic.com" },
                    { "9521e410-248f-4b6d-ba43-3473b824d8de", 0, "fbd66233-a86e-4c4d-b468-9527b37be8dd", "patient15@clinic.com", true, false, null, "PATIENT15@CLINIC.COM", "PATIENT15@CLINIC.COM", "AQAAAAIAAYagAAAAEDUDxf/gPrUcqsxHNDkHlexXUmlW/W9g3fWevhiKO2ghgd7tuF6zWojIbKrTAUPk4g==", "01000000015", true, "2f903a68-6bdc-46b6-8be0-03c5096ee89b", false, "patient15@clinic.com" },
                    { "96ec0f2d-d4cb-46c1-a1bf-73900a1592f5", 0, "e99ca9e8-7f6f-4dfc-af41-920578843268", "patient6@clinic.com", true, false, null, "PATIENT6@CLINIC.COM", "PATIENT6@CLINIC.COM", "AQAAAAIAAYagAAAAEPyDK6ZBFMn8HI39Da9AplU6RHosyS16wnd4vs7NSli4y+jxNPtzRhqvlq8aXxwwEw==", "01000000006", true, "356cccaa-2cac-492a-af97-d94f4e3760b6", false, "patient6@clinic.com" },
                    { "9dfd373d-efd6-4c80-87a5-75f54cc54e83", 0, "c4829006-0234-4e2e-8c63-be92b40081e8", "patient11@clinic.com", true, false, null, "PATIENT11@CLINIC.COM", "PATIENT11@CLINIC.COM", "AQAAAAIAAYagAAAAEEOPBau/q15hxxai2/dGSRwsxBsTfGCHFTg/MFwiiVsrgfaKADcQ3YW+qdqXqIRN8A==", "01000000011", true, "72b1050a-f48c-4c74-a618-96dab87d1424", false, "patient11@clinic.com" },
                    { "9f5a316e-c0f8-417c-93a7-0e8bdf371660", 0, "8cb371f4-2072-44d9-b63c-bcc97c629525", "admin4@clinic.com", true, false, null, "ADMIN4@CLINIC.COM", "ADMIN4@CLINIC.COM", "AQAAAAIAAYagAAAAENPFWqNdlgYq+KiPn2mh5am5R5SK/LSGPXKoRuqR/8a9Gdc7EoD5iIvImPCnckiskQ==", "01000000004", true, "71417afd-faba-4d81-9950-1171cc6a6dfe", false, "admin4@clinic.com" },
                    { "9f7df074-0434-42da-8200-01a5b860c73a", 0, "43b70b94-0b2c-4d1d-b814-92b3d9d737dc", "doctor11@clinic.com", true, false, null, "DOCTOR11@CLINIC.COM", "DOCTOR11@CLINIC.COM", "AQAAAAIAAYagAAAAEAiPuhjnXc+B+H4Xzhur/8qjeexv4h9cea2Lg7Pi2QdfIx2J8KxW/QStACnSxv7vuw==", "01100000011", true, "7211e03a-feec-4872-83e2-2f43b03fc456", false, "doctor11@clinic.com" },
                    { "a12ab74b-ba32-4056-b607-202472f76ca2", 0, "e4a4b0fa-af51-47a5-9ba7-02b7da35e9bd", "patient3@clinic.com", true, false, null, "PATIENT3@CLINIC.COM", "PATIENT3@CLINIC.COM", "AQAAAAIAAYagAAAAECCNJMk7Nr+F1WmeuHaNkRZCJQQmiqes64oOynYULODa/ENPl+HhtiT8JuK5ZMM/FA==", "01000000003", true, "cca4ab3b-e225-4c8b-a2ca-2f788f6565bc", false, "patient3@clinic.com" },
                    { "abb56b65-a9ac-461f-b3a1-2cb386134b78", 0, "dcc2fbf7-9200-432b-b0e1-5ed5a47fd032", "doctor13@clinic.com", true, false, null, "DOCTOR13@CLINIC.COM", "DOCTOR13@CLINIC.COM", "AQAAAAIAAYagAAAAEA76IurAA4uj/RukMagARlzHfKuaJnCzvmmVW+THAwws0yx7dlP7KwIpxGXY9r5Exg==", "01100000013", true, "2a9fdae8-408e-4b28-b203-4f3ea6a86f6b", false, "doctor13@clinic.com" },
                    { "bedfbe7e-17eb-4a27-b5e9-f8a0fc41ec34", 0, "51b80271-6446-4119-a300-331ba3bef56d", "patient17@clinic.com", true, false, null, "PATIENT17@CLINIC.COM", "PATIENT17@CLINIC.COM", "AQAAAAIAAYagAAAAEPchwvtbcQB6eTDSGq7hTOoxI8xElYFJp/5JGl0Jr4FDwlu1QqqAe8v5vjBAUZ9aWw==", "01000000017", true, "4a501771-3eb5-4561-b6cc-bbc18aabbebe", false, "patient17@clinic.com" },
                    { "c64eb54f-f359-48ec-8aea-1d0427f8623a", 0, "e6e48fae-7c78-4f75-ae76-ae681578f5fd", "doctor12@clinic.com", true, false, null, "DOCTOR12@CLINIC.COM", "DOCTOR12@CLINIC.COM", "AQAAAAIAAYagAAAAED/Gu+DrzWtgvQDTDM6ROVMLk+6XEqRHog+5D1nfDasGQbKJdeI6rfu47pNC4i2QPA==", "01100000012", true, "1e511226-a192-4614-9b87-091252ed10e4", false, "doctor12@clinic.com" },
                    { "cdad694a-e53d-4988-9301-549667be2cde", 0, "ee95e38c-557e-4064-a4cc-c143b1bb4172", "doctor9@clinic.com", true, false, null, "DOCTOR9@CLINIC.COM", "DOCTOR9@CLINIC.COM", "AQAAAAIAAYagAAAAEAtbmwY7ml9qaCYSzdnBARIl+y5Q4T9CWF70N4jHQr9y76AKiCG8bJkA2Dyb9iWcrg==", "01100000009", true, "882eaafd-9e58-4e51-ab68-235e806f0ddd", false, "doctor9@clinic.com" },
                    { "ce05714c-0de2-4fd6-afc0-867f4aca74d8", 0, "e5b2e053-ee76-4860-87f5-1e87afda609b", "admin2@clinic.com", true, false, null, "ADMIN2@CLINIC.COM", "ADMIN2@CLINIC.COM", "AQAAAAIAAYagAAAAECvteeyO0yXunJ78Sou54Gr6+UGe+dznbO2rEOuD9RApxViOBoT622H/J16kTxZTLQ==", "01000000002", true, "b5c25ada-43b5-4d2f-957f-46fec42ea97e", false, "admin2@clinic.com" },
                    { "cff99267-3cbb-4014-91ba-d49cf8711e08", 0, "a353c530-2f5e-4c78-8f03-73b9b3474f26", "patient14@clinic.com", true, false, null, "PATIENT14@CLINIC.COM", "PATIENT14@CLINIC.COM", "AQAAAAIAAYagAAAAEDJEm7KDG4+ugKajd9L8SCoiYfSvdqtfkwjnSzYQRvml1QjEB642o7lbwnCLoxODRg==", "01000000014", true, "9cf1fc86-5612-4db9-b867-60988adbbb11", false, "patient14@clinic.com" },
                    { "d3c97e74-8660-494a-a2af-eaa94baedfe4", 0, "748109d0-c851-4a6a-9527-af9499ca439b", "patient9@clinic.com", true, false, null, "PATIENT9@CLINIC.COM", "PATIENT9@CLINIC.COM", "AQAAAAIAAYagAAAAEOcXDEQUa9eoqsEa4BdyMIDY9y36nwGcrMpIIWDXWQj/vmoRyuPtyBMMgia/1pzEtA==", "01000000009", true, "a755d3ef-edd5-49ce-90c2-3cdb8d42b987", false, "patient9@clinic.com" },
                    { "d750d504-86db-4df3-ba0d-f5d2bc2f213b", 0, "65898e2d-4830-4bc0-a5b8-cc7774f7b633", "patient8@clinic.com", true, false, null, "PATIENT8@CLINIC.COM", "PATIENT8@CLINIC.COM", "AQAAAAIAAYagAAAAEGeFOcLFHA3jDqM5kxD9SpusgtHQQgTHSlrmPuKENhtqUT8gf9UdHbS06zR2wQakHg==", "01000000008", true, "dcf684ae-85ee-406d-9676-f42f248011f0", false, "patient8@clinic.com" },
                    { "eee26db5-0164-495f-89f2-83ea285db8c0", 0, "8f504fa2-cd11-461f-81e7-4c194fc4c9d0", "patient1@clinic.com", true, false, null, "PATIENT1@CLINIC.COM", "PATIENT1@CLINIC.COM", "AQAAAAIAAYagAAAAEHAENtJ49TRef2pml7QFDZriLEbKI2Y5X06K7WxGn8TnbLhhUmXYwt6WeTIp3MTpRQ==", "01000000001", true, "1165c168-7c82-4dfd-a3bd-cf3be6c69a81", false, "patient1@clinic.com" },
                    { "ef5e7c5b-2dff-446c-8f31-b53099ea339d", 0, "baf66f10-6ea2-49a5-8a0e-087fa491f604", "doctor3@clinic.com", true, false, null, "DOCTOR3@CLINIC.COM", "DOCTOR3@CLINIC.COM", "AQAAAAIAAYagAAAAEGlQVeI1QkXflklRvQ4mEqq5zSjLbVJUWlvXN4wd+4aZtHAf81gdo0UOxJqFsykIng==", "01100000003", true, "755097b7-1c6b-4bc7-be77-1db83b854cb7", false, "doctor3@clinic.com" },
                    { "f90968cb-de1f-46a0-a508-0e13fef63922", 0, "99948ae2-fab3-454d-96fe-d6e755654911", "admin1@clinic.com", true, false, null, "ADMIN1@CLINIC.COM", "ADMIN1@CLINIC.COM", "AQAAAAIAAYagAAAAEN4J/lKE7hbmjIQcI32Nb1sBM1XAYFTYSaqI7USgFilsQbwbmvA39JcKHLtnHPWWPA==", "01000000001", true, "c85420b0-e60e-47b2-9695-cd28bb8894dd", false, "admin1@clinic.com" },
                    { "fc0cba89-c0c6-44e1-be04-1526d0f22571", 0, "e88fdfb3-1892-4c21-9232-c3cbbc97fcbc", "doctor14@clinic.com", true, false, null, "DOCTOR14@CLINIC.COM", "DOCTOR14@CLINIC.COM", "AQAAAAIAAYagAAAAEL7u5vkWFVs5gp/3siBMMPhGctPw6Ku7prAUtJ/A2PAbNHGtdbNmJx9SYn6kHRQAfw==", "01100000014", true, "a5a30f16-161b-47c2-b68a-e7e648fbffae", false, "doctor14@clinic.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "00adac97-ef12-4ee0-89d2-9668bad3e333" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "023978a1-0aad-43dc-8b37-b9bfa1c69d64" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "0a9b1a7d-d3de-4c07-bfed-f490dfb0d063" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "0aeed420-b2f6-4718-a55f-91e9014e15f3" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "0e97bb17-b2c1-467d-8774-411fa6799da5" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "148a40a7-da4e-4e1b-a003-9e58c0d6d485" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "1e77598e-eb16-412e-9d18-a2f1b6256387" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "22d0e279-b1bd-4e5d-87d5-4ef437e35487" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "2ec8090b-edb6-42d2-9109-c8296f933566" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "32366f4e-6267-4b6d-87ae-6df02db5f393" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "39344909-14a6-4fec-b23e-9e2269cfe94f" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "413a2466-e957-431c-837c-20a44fae1d27" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "45453ec6-1845-4c04-b76b-641a0e1e350f" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "46c76612-1744-4125-9fa2-404d4d586a6e" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "494a9306-12d3-48e8-9249-49a2ace53649" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "5b57a12b-2656-440a-9157-6960a1051205" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "6201941c-43f3-4fb2-9fe0-5131071e84b8" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "653a6b90-4762-4a70-bfbf-8ac6c4934969" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "6627e77d-6c04-4165-a1a9-8e45915006a3" },
                    { "675b578c-8739-4b1b-a706-816fb14910bd", "755a8257-ad4c-44ac-8e69-ae15c27eb1e0" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "7a899aed-90ea-4e2c-9e63-f9694ca2b3bd" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "84c82c8d-886c-4f3c-a0ae-a9f674c397a6" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "86689581-87c8-4d18-a12e-b521929851d9" },
                    { "675b578c-8739-4b1b-a706-816fb14910bd", "8bb59f45-c04f-49cd-bdb1-67196483be35" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "8ca7d99f-35d7-4651-836c-d9d061a49427" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "8f1aa731-8712-40ea-b6e4-8ba29cb9f16d" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "931c0531-e15c-48e1-8a5c-b30c62eb50f9" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "9521e410-248f-4b6d-ba43-3473b824d8de" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "96ec0f2d-d4cb-46c1-a1bf-73900a1592f5" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "9dfd373d-efd6-4c80-87a5-75f54cc54e83" },
                    { "675b578c-8739-4b1b-a706-816fb14910bd", "9f5a316e-c0f8-417c-93a7-0e8bdf371660" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "9f7df074-0434-42da-8200-01a5b860c73a" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "a12ab74b-ba32-4056-b607-202472f76ca2" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "abb56b65-a9ac-461f-b3a1-2cb386134b78" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "bedfbe7e-17eb-4a27-b5e9-f8a0fc41ec34" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "c64eb54f-f359-48ec-8aea-1d0427f8623a" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "cdad694a-e53d-4988-9301-549667be2cde" },
                    { "675b578c-8739-4b1b-a706-816fb14910bd", "ce05714c-0de2-4fd6-afc0-867f4aca74d8" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "cff99267-3cbb-4014-91ba-d49cf8711e08" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "d3c97e74-8660-494a-a2af-eaa94baedfe4" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "d750d504-86db-4df3-ba0d-f5d2bc2f213b" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "eee26db5-0164-495f-89f2-83ea285db8c0" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "ef5e7c5b-2dff-446c-8f31-b53099ea339d" },
                    { "675b578c-8739-4b1b-a706-816fb14910bd", "f90968cb-de1f-46a0-a508-0e13fef63922" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "fc0cba89-c0c6-44e1-be04-1526d0f22571" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Price", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("1ee3aa75-f8b2-4d41-9372-a70900e8ac7c"), 107.0, "Specialty 7", "0a9b1a7d-d3de-4c07-bfed-f490dfb0d063" },
                    { new Guid("35a89b32-a9f3-4d8b-b05c-e43f7d3d383d"), 104.0, "Specialty 4", "8f1aa731-8712-40ea-b6e4-8ba29cb9f16d" },
                    { new Guid("4ca32da6-4b53-42dd-924d-fe2801ff74fc"), 117.0, "Specialty 17", "148a40a7-da4e-4e1b-a003-9e58c0d6d485" },
                    { new Guid("586a05c8-9376-4501-873d-b79f6332874f"), 106.0, "Specialty 6", "0aeed420-b2f6-4718-a55f-91e9014e15f3" },
                    { new Guid("5aa28e01-644d-498c-b66f-bfc2c720cb88"), 110.0, "Specialty 10", "22d0e279-b1bd-4e5d-87d5-4ef437e35487" },
                    { new Guid("65841d01-36b4-425f-908e-4c30f3422b7d"), 119.0, "Specialty 19", "00adac97-ef12-4ee0-89d2-9668bad3e333" },
                    { new Guid("67457fae-0354-4697-a68f-a3c996454db8"), 116.0, "Specialty 16", "84c82c8d-886c-4f3c-a0ae-a9f674c397a6" },
                    { new Guid("6ac96d36-36e6-44f2-bbf6-6578898b494d"), 108.0, "Specialty 8", "6201941c-43f3-4fb2-9fe0-5131071e84b8" },
                    { new Guid("75cb34ef-6a82-4d78-b770-70408334d8fa"), 111.0, "Specialty 11", "9f7df074-0434-42da-8200-01a5b860c73a" },
                    { new Guid("8ec0e9a2-5b1b-472d-bd19-b01af2e2a4b8"), 105.0, "Specialty 5", "32366f4e-6267-4b6d-87ae-6df02db5f393" },
                    { new Guid("8eccff74-55a0-41da-b610-3bde51af8e1d"), 103.0, "Specialty 3", "ef5e7c5b-2dff-446c-8f31-b53099ea339d" },
                    { new Guid("951488a8-30b3-4e3c-9aeb-6c548e5349cb"), 115.0, "Specialty 15", "494a9306-12d3-48e8-9249-49a2ace53649" },
                    { new Guid("95e93ba9-8feb-449a-9310-10f4f1cfa6ae"), 101.0, "Specialty 1", "86689581-87c8-4d18-a12e-b521929851d9" },
                    { new Guid("bf46cb72-248a-454f-9fd6-38bb5c4c0b3a"), 120.0, "Specialty 20", "46c76612-1744-4125-9fa2-404d4d586a6e" },
                    { new Guid("c4485f07-ece1-410c-af94-321edfde9425"), 112.0, "Specialty 12", "c64eb54f-f359-48ec-8aea-1d0427f8623a" },
                    { new Guid("d7aad276-d4c1-4bee-b695-4cba94abb37a"), 113.0, "Specialty 13", "abb56b65-a9ac-461f-b3a1-2cb386134b78" },
                    { new Guid("da4da8de-4558-4d72-a225-054fabbaa9da"), 109.0, "Specialty 9", "cdad694a-e53d-4988-9301-549667be2cde" },
                    { new Guid("ed39d351-1002-40d0-858c-846c3f2b0764"), 114.0, "Specialty 14", "fc0cba89-c0c6-44e1-be04-1526d0f22571" },
                    { new Guid("f8db328e-f29a-4edf-90e2-fa0af9b2f2f7"), 102.0, "Specialty 2", "653a6b90-4762-4a70-bfbf-8ac6c4934969" },
                    { new Guid("fcb2a14b-8af8-40a9-b5e7-270708a7fe9e"), 118.0, "Specialty 18", "45453ec6-1845-4c04-b76b-641a0e1e350f" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "Date", "DoctorId", "PatientId", "State", "Time" },
                values: new object[,]
                {
                    { new Guid("04623cc9-a4b6-4fe7-9340-8f46df018a61"), "2025-05-05", new Guid("8ec0e9a2-5b1b-472d-bd19-b01af2e2a4b8"), "8bb59f45-c04f-49cd-bdb1-67196483be35", "Scheduled", "13:00 AM" },
                    { new Guid("083f0240-a7a9-48a5-b180-19ac48bfac03"), "2025-05-07", new Guid("1ee3aa75-f8b2-4d41-9372-a70900e8ac7c"), "8ca7d99f-35d7-4651-836c-d9d061a49427", "Scheduled", "15:00 AM" },
                    { new Guid("148d0b11-06be-4498-b3a1-41b431406969"), "2025-05-14", new Guid("ed39d351-1002-40d0-858c-846c3f2b0764"), "d3c97e74-8660-494a-a2af-eaa94baedfe4", "Scheduled", "10:00 AM" },
                    { new Guid("1dee1d84-0a01-4f8f-a918-fecf139e23ea"), "2025-05-17", new Guid("4ca32da6-4b53-42dd-924d-fe2801ff74fc"), "5b57a12b-2656-440a-9157-6960a1051205", "Scheduled", "13:00 AM" },
                    { new Guid("2c1ff423-e321-44db-8e9a-035797b483f6"), "2025-05-12", new Guid("c4485f07-ece1-410c-af94-321edfde9425"), "2ec8090b-edb6-42d2-9109-c8296f933566", "Scheduled", "20:00 AM" },
                    { new Guid("2d6a4ecd-51b6-48b7-9f79-ac5ce492402b"), "2025-05-02", new Guid("f8db328e-f29a-4edf-90e2-fa0af9b2f2f7"), "ce05714c-0de2-4fd6-afc0-867f4aca74d8", "Scheduled", "10:00 AM" },
                    { new Guid("58e3c660-82a6-4727-a20c-ed0a0d8c9923"), "2025-05-18", new Guid("fcb2a14b-8af8-40a9-b5e7-270708a7fe9e"), "1e77598e-eb16-412e-9d18-a2f1b6256387", "Scheduled", "14:00 AM" },
                    { new Guid("64e03248-4402-4bed-a7ca-af53dd219328"), "2025-05-16", new Guid("67457fae-0354-4697-a68f-a3c996454db8"), "9dfd373d-efd6-4c80-87a5-75f54cc54e83", "Scheduled", "12:00 AM" },
                    { new Guid("7985db89-7d11-4e96-967f-a1b5c54c419f"), "2025-05-10", new Guid("5aa28e01-644d-498c-b66f-bfc2c720cb88"), "6627e77d-6c04-4165-a1a9-8e45915006a3", "Scheduled", "18:00 AM" },
                    { new Guid("7a8eebfe-9f72-449b-8047-fb1f1541b37f"), "2025-05-08", new Guid("6ac96d36-36e6-44f2-bbf6-6578898b494d"), "a12ab74b-ba32-4056-b607-202472f76ca2", "Scheduled", "16:00 AM" },
                    { new Guid("86988fdf-7997-4e00-8ac9-cc538275673b"), "2025-05-15", new Guid("951488a8-30b3-4e3c-9aeb-6c548e5349cb"), "023978a1-0aad-43dc-8b37-b9bfa1c69d64", "Scheduled", "11:00 AM" },
                    { new Guid("8debbab0-faae-4539-ac70-0055c5edbb53"), "2025-05-06", new Guid("586a05c8-9376-4501-873d-b79f6332874f"), "eee26db5-0164-495f-89f2-83ea285db8c0", "Scheduled", "14:00 AM" },
                    { new Guid("b053a945-94de-432f-b309-818acfbb0576"), "2025-05-03", new Guid("8eccff74-55a0-41da-b610-3bde51af8e1d"), "755a8257-ad4c-44ac-8e69-ae15c27eb1e0", "Scheduled", "11:00 AM" },
                    { new Guid("bd038531-e406-4eea-ba3a-e44bd7bcb86f"), "2025-05-19", new Guid("65841d01-36b4-425f-908e-4c30f3422b7d"), "cff99267-3cbb-4014-91ba-d49cf8711e08", "Scheduled", "15:00 AM" },
                    { new Guid("c57e79c6-076d-4b96-99f6-7baa3ea75cb0"), "2025-05-11", new Guid("75cb34ef-6a82-4d78-b770-70408334d8fa"), "96ec0f2d-d4cb-46c1-a1bf-73900a1592f5", "Scheduled", "19:00 AM" },
                    { new Guid("dc91d62a-5663-4cbf-97db-8eee9d47e832"), "2025-05-13", new Guid("d7aad276-d4c1-4bee-b695-4cba94abb37a"), "d750d504-86db-4df3-ba0d-f5d2bc2f213b", "Scheduled", "9:00 AM" },
                    { new Guid("e730a35d-8464-4faf-bfc5-23c99fda9173"), "2025-05-20", new Guid("bf46cb72-248a-454f-9fd6-38bb5c4c0b3a"), "9521e410-248f-4b6d-ba43-3473b824d8de", "Scheduled", "16:00 AM" },
                    { new Guid("e93ead83-0fd9-427e-b76c-f742c2b9bf3b"), "2025-05-01", new Guid("95e93ba9-8feb-449a-9310-10f4f1cfa6ae"), "f90968cb-de1f-46a0-a508-0e13fef63922", "Scheduled", "9:00 AM" },
                    { new Guid("f716fdb0-5e03-4a7a-8bd5-52c3bd0c60aa"), "2025-05-09", new Guid("da4da8de-4558-4d72-a225-054fabbaa9da"), "931c0531-e15c-48e1-8a5c-b30c62eb50f9", "Scheduled", "17:00 AM" },
                    { new Guid("ff562776-5ecb-49ae-961d-57ccdce8ac3e"), "2025-05-04", new Guid("35a89b32-a9f3-4d8b-b05c-e43f7d3d383d"), "9f5a316e-c0f8-417c-93a7-0e8bdf371660", "Scheduled", "12:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Id", "AppointmentId", "Description", "Modification_date" },
                values: new object[,]
                {
                    { new Guid("0e460cdb-7616-4f30-8f29-42cdc887ee79"), new Guid("f716fdb0-5e03-4a7a-8bd5-52c3bd0c60aa"), "Prescription for appointment 9", "2025-05-06" },
                    { new Guid("1058be7e-1eb3-4fc2-81a2-b90d54273125"), new Guid("8debbab0-faae-4539-ac70-0055c5edbb53"), "Prescription for appointment 6", "2025-05-06" },
                    { new Guid("1ec53acd-4bbf-4cd0-8bd6-e9990d503650"), new Guid("e93ead83-0fd9-427e-b76c-f742c2b9bf3b"), "Prescription for appointment 1", "2025-05-06" },
                    { new Guid("1edd450e-672e-4966-b245-37b0c0ba69cd"), new Guid("c57e79c6-076d-4b96-99f6-7baa3ea75cb0"), "Prescription for appointment 11", "2025-05-06" },
                    { new Guid("238e14b3-3bae-40ff-84b2-503cf139923c"), new Guid("04623cc9-a4b6-4fe7-9340-8f46df018a61"), "Prescription for appointment 5", "2025-05-06" },
                    { new Guid("375ccf86-f585-42f6-8c2d-f19c9ccf8850"), new Guid("86988fdf-7997-4e00-8ac9-cc538275673b"), "Prescription for appointment 15", "2025-05-06" },
                    { new Guid("37ce5be0-4c22-419c-a9d6-6416e9699984"), new Guid("2d6a4ecd-51b6-48b7-9f79-ac5ce492402b"), "Prescription for appointment 2", "2025-05-06" },
                    { new Guid("3accc9d6-c8a0-4786-96fb-5043e2420f64"), new Guid("64e03248-4402-4bed-a7ca-af53dd219328"), "Prescription for appointment 16", "2025-05-06" },
                    { new Guid("6753b1fb-9b1b-4037-ada6-1337eecc0a20"), new Guid("58e3c660-82a6-4727-a20c-ed0a0d8c9923"), "Prescription for appointment 18", "2025-05-06" },
                    { new Guid("6f6aeabb-0a91-4d60-a424-d07f92457e3d"), new Guid("e730a35d-8464-4faf-bfc5-23c99fda9173"), "Prescription for appointment 20", "2025-05-06" },
                    { new Guid("964d02a6-3402-405a-9c01-2bf6fe518e1a"), new Guid("bd038531-e406-4eea-ba3a-e44bd7bcb86f"), "Prescription for appointment 19", "2025-05-06" },
                    { new Guid("a1bd0020-3e56-415f-8b3c-d1b13a578441"), new Guid("1dee1d84-0a01-4f8f-a918-fecf139e23ea"), "Prescription for appointment 17", "2025-05-06" },
                    { new Guid("a80aa1eb-be5e-4016-b923-fb5f7b99796b"), new Guid("083f0240-a7a9-48a5-b180-19ac48bfac03"), "Prescription for appointment 7", "2025-05-06" },
                    { new Guid("b1026625-577a-4d79-8db5-fb4e0d279fbe"), new Guid("7985db89-7d11-4e96-967f-a1b5c54c419f"), "Prescription for appointment 10", "2025-05-06" },
                    { new Guid("b369c02e-a93b-4b2d-90b5-1f3cb5b5861d"), new Guid("2c1ff423-e321-44db-8e9a-035797b483f6"), "Prescription for appointment 12", "2025-05-06" },
                    { new Guid("b54537f3-0469-4864-9226-7aa41e1e1e1b"), new Guid("7a8eebfe-9f72-449b-8047-fb1f1541b37f"), "Prescription for appointment 8", "2025-05-06" },
                    { new Guid("b7e0f4dd-b655-41b0-ba2d-ed1d7184e43e"), new Guid("dc91d62a-5663-4cbf-97db-8eee9d47e832"), "Prescription for appointment 13", "2025-05-06" },
                    { new Guid("c6091f81-8c91-49df-aeb1-afdc562a8df4"), new Guid("ff562776-5ecb-49ae-961d-57ccdce8ac3e"), "Prescription for appointment 4", "2025-05-06" },
                    { new Guid("c94103b9-d260-41a7-958b-d01af023bb78"), new Guid("148d0b11-06be-4498-b3a1-41b431406969"), "Prescription for appointment 14", "2025-05-06" },
                    { new Guid("e92aa1c5-4047-458e-8d7a-c754b025fa97"), new Guid("b053a945-94de-432f-b309-818acfbb0576"), "Prescription for appointment 3", "2025-05-06" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "00adac97-ef12-4ee0-89d2-9668bad3e333" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "023978a1-0aad-43dc-8b37-b9bfa1c69d64" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "0a9b1a7d-d3de-4c07-bfed-f490dfb0d063" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "0aeed420-b2f6-4718-a55f-91e9014e15f3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "0e97bb17-b2c1-467d-8774-411fa6799da5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "148a40a7-da4e-4e1b-a003-9e58c0d6d485" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "1e77598e-eb16-412e-9d18-a2f1b6256387" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "22d0e279-b1bd-4e5d-87d5-4ef437e35487" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "2ec8090b-edb6-42d2-9109-c8296f933566" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "32366f4e-6267-4b6d-87ae-6df02db5f393" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "39344909-14a6-4fec-b23e-9e2269cfe94f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "413a2466-e957-431c-837c-20a44fae1d27" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "45453ec6-1845-4c04-b76b-641a0e1e350f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "46c76612-1744-4125-9fa2-404d4d586a6e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "494a9306-12d3-48e8-9249-49a2ace53649" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "5b57a12b-2656-440a-9157-6960a1051205" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "6201941c-43f3-4fb2-9fe0-5131071e84b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "653a6b90-4762-4a70-bfbf-8ac6c4934969" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "6627e77d-6c04-4165-a1a9-8e45915006a3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675b578c-8739-4b1b-a706-816fb14910bd", "755a8257-ad4c-44ac-8e69-ae15c27eb1e0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "7a899aed-90ea-4e2c-9e63-f9694ca2b3bd" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "84c82c8d-886c-4f3c-a0ae-a9f674c397a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "86689581-87c8-4d18-a12e-b521929851d9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675b578c-8739-4b1b-a706-816fb14910bd", "8bb59f45-c04f-49cd-bdb1-67196483be35" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "8ca7d99f-35d7-4651-836c-d9d061a49427" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "8f1aa731-8712-40ea-b6e4-8ba29cb9f16d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "931c0531-e15c-48e1-8a5c-b30c62eb50f9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "9521e410-248f-4b6d-ba43-3473b824d8de" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "96ec0f2d-d4cb-46c1-a1bf-73900a1592f5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "9dfd373d-efd6-4c80-87a5-75f54cc54e83" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675b578c-8739-4b1b-a706-816fb14910bd", "9f5a316e-c0f8-417c-93a7-0e8bdf371660" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "9f7df074-0434-42da-8200-01a5b860c73a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "a12ab74b-ba32-4056-b607-202472f76ca2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "abb56b65-a9ac-461f-b3a1-2cb386134b78" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "bedfbe7e-17eb-4a27-b5e9-f8a0fc41ec34" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "c64eb54f-f359-48ec-8aea-1d0427f8623a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "cdad694a-e53d-4988-9301-549667be2cde" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675b578c-8739-4b1b-a706-816fb14910bd", "ce05714c-0de2-4fd6-afc0-867f4aca74d8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "cff99267-3cbb-4014-91ba-d49cf8711e08" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "d3c97e74-8660-494a-a2af-eaa94baedfe4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "d750d504-86db-4df3-ba0d-f5d2bc2f213b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72235979-4cb2-4bb1-9de9-9e931f98610e", "eee26db5-0164-495f-89f2-83ea285db8c0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "ef5e7c5b-2dff-446c-8f31-b53099ea339d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "675b578c-8739-4b1b-a706-816fb14910bd", "f90968cb-de1f-46a0-a508-0e13fef63922" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "fc0cba89-c0c6-44e1-be04-1526d0f22571" });

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("0e460cdb-7616-4f30-8f29-42cdc887ee79"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("1058be7e-1eb3-4fc2-81a2-b90d54273125"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("1ec53acd-4bbf-4cd0-8bd6-e9990d503650"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("1edd450e-672e-4966-b245-37b0c0ba69cd"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("238e14b3-3bae-40ff-84b2-503cf139923c"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("375ccf86-f585-42f6-8c2d-f19c9ccf8850"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("37ce5be0-4c22-419c-a9d6-6416e9699984"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("3accc9d6-c8a0-4786-96fb-5043e2420f64"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("6753b1fb-9b1b-4037-ada6-1337eecc0a20"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("6f6aeabb-0a91-4d60-a424-d07f92457e3d"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("964d02a6-3402-405a-9c01-2bf6fe518e1a"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("a1bd0020-3e56-415f-8b3c-d1b13a578441"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("a80aa1eb-be5e-4016-b923-fb5f7b99796b"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("b1026625-577a-4d79-8db5-fb4e0d279fbe"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("b369c02e-a93b-4b2d-90b5-1f3cb5b5861d"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("b54537f3-0469-4864-9226-7aa41e1e1e1b"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("b7e0f4dd-b655-41b0-ba2d-ed1d7184e43e"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("c6091f81-8c91-49df-aeb1-afdc562a8df4"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("c94103b9-d260-41a7-958b-d01af023bb78"));

            migrationBuilder.DeleteData(
                table: "Prescriptions",
                keyColumn: "Id",
                keyValue: new Guid("e92aa1c5-4047-458e-8d7a-c754b025fa97"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("04623cc9-a4b6-4fe7-9340-8f46df018a61"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("083f0240-a7a9-48a5-b180-19ac48bfac03"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("148d0b11-06be-4498-b3a1-41b431406969"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("1dee1d84-0a01-4f8f-a918-fecf139e23ea"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("2c1ff423-e321-44db-8e9a-035797b483f6"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("2d6a4ecd-51b6-48b7-9f79-ac5ce492402b"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("58e3c660-82a6-4727-a20c-ed0a0d8c9923"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("64e03248-4402-4bed-a7ca-af53dd219328"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("7985db89-7d11-4e96-967f-a1b5c54c419f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("7a8eebfe-9f72-449b-8047-fb1f1541b37f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("86988fdf-7997-4e00-8ac9-cc538275673b"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("8debbab0-faae-4539-ac70-0055c5edbb53"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("b053a945-94de-432f-b309-818acfbb0576"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("bd038531-e406-4eea-ba3a-e44bd7bcb86f"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("c57e79c6-076d-4b96-99f6-7baa3ea75cb0"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("dc91d62a-5663-4cbf-97db-8eee9d47e832"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e730a35d-8464-4faf-bfc5-23c99fda9173"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("e93ead83-0fd9-427e-b76c-f742c2b9bf3b"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("f716fdb0-5e03-4a7a-8bd5-52c3bd0c60aa"));

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: new Guid("ff562776-5ecb-49ae-961d-57ccdce8ac3e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e97bb17-b2c1-467d-8774-411fa6799da5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39344909-14a6-4fec-b23e-9e2269cfe94f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "413a2466-e957-431c-837c-20a44fae1d27");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7a899aed-90ea-4e2c-9e63-f9694ca2b3bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bedfbe7e-17eb-4a27-b5e9-f8a0fc41ec34");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "023978a1-0aad-43dc-8b37-b9bfa1c69d64");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e77598e-eb16-412e-9d18-a2f1b6256387");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2ec8090b-edb6-42d2-9109-c8296f933566");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b57a12b-2656-440a-9157-6960a1051205");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6627e77d-6c04-4165-a1a9-8e45915006a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "755a8257-ad4c-44ac-8e69-ae15c27eb1e0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8bb59f45-c04f-49cd-bdb1-67196483be35");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ca7d99f-35d7-4651-836c-d9d061a49427");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "931c0531-e15c-48e1-8a5c-b30c62eb50f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9521e410-248f-4b6d-ba43-3473b824d8de");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96ec0f2d-d4cb-46c1-a1bf-73900a1592f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9dfd373d-efd6-4c80-87a5-75f54cc54e83");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f5a316e-c0f8-417c-93a7-0e8bdf371660");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a12ab74b-ba32-4056-b607-202472f76ca2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce05714c-0de2-4fd6-afc0-867f4aca74d8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cff99267-3cbb-4014-91ba-d49cf8711e08");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d3c97e74-8660-494a-a2af-eaa94baedfe4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d750d504-86db-4df3-ba0d-f5d2bc2f213b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eee26db5-0164-495f-89f2-83ea285db8c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f90968cb-de1f-46a0-a508-0e13fef63922");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("1ee3aa75-f8b2-4d41-9372-a70900e8ac7c"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("35a89b32-a9f3-4d8b-b05c-e43f7d3d383d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("4ca32da6-4b53-42dd-924d-fe2801ff74fc"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("586a05c8-9376-4501-873d-b79f6332874f"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("5aa28e01-644d-498c-b66f-bfc2c720cb88"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("65841d01-36b4-425f-908e-4c30f3422b7d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("67457fae-0354-4697-a68f-a3c996454db8"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("6ac96d36-36e6-44f2-bbf6-6578898b494d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("75cb34ef-6a82-4d78-b770-70408334d8fa"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("8ec0e9a2-5b1b-472d-bd19-b01af2e2a4b8"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("8eccff74-55a0-41da-b610-3bde51af8e1d"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("951488a8-30b3-4e3c-9aeb-6c548e5349cb"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("95e93ba9-8feb-449a-9310-10f4f1cfa6ae"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("bf46cb72-248a-454f-9fd6-38bb5c4c0b3a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("c4485f07-ece1-410c-af94-321edfde9425"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("d7aad276-d4c1-4bee-b695-4cba94abb37a"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("da4da8de-4558-4d72-a225-054fabbaa9da"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("ed39d351-1002-40d0-858c-846c3f2b0764"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("f8db328e-f29a-4edf-90e2-fa0af9b2f2f7"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("fcb2a14b-8af8-40a9-b5e7-270708a7fe9e"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00adac97-ef12-4ee0-89d2-9668bad3e333");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a9b1a7d-d3de-4c07-bfed-f490dfb0d063");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0aeed420-b2f6-4718-a55f-91e9014e15f3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "148a40a7-da4e-4e1b-a003-9e58c0d6d485");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22d0e279-b1bd-4e5d-87d5-4ef437e35487");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32366f4e-6267-4b6d-87ae-6df02db5f393");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "45453ec6-1845-4c04-b76b-641a0e1e350f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46c76612-1744-4125-9fa2-404d4d586a6e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "494a9306-12d3-48e8-9249-49a2ace53649");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6201941c-43f3-4fb2-9fe0-5131071e84b8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "653a6b90-4762-4a70-bfbf-8ac6c4934969");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84c82c8d-886c-4f3c-a0ae-a9f674c397a6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "86689581-87c8-4d18-a12e-b521929851d9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8f1aa731-8712-40ea-b6e4-8ba29cb9f16d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f7df074-0434-42da-8200-01a5b860c73a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abb56b65-a9ac-461f-b3a1-2cb386134b78");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c64eb54f-f359-48ec-8aea-1d0427f8623a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdad694a-e53d-4988-9301-549667be2cde");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef5e7c5b-2dff-446c-8f31-b53099ea339d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc0cba89-c0c6-44e1-be04-1526d0f22571");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "06ef133d-a03d-4045-9dff-03ba2353c36b", 0, "c1d07609-db92-42e2-b53f-72608f3e6b0c", "doctor4@clinic.com", true, false, null, "DOCTOR4@CLINIC.COM", "DOCTOR4@CLINIC.COM", "AQAAAAIAAYagAAAAEKdtNM+/b4XCdHu8RWoY1WAbnHyohQsfqTihsmfbMwkSXiEOtHQBKpUbY5Lum9Tb5Q==", "01100000004", true, "89825f74-ef07-43d2-938e-0e9ec1b653ee", false, "doctor4@clinic.com" },
                    { "0b1b1a02-ff25-46e8-add7-b55bc94596db", 0, "de088424-62f7-42b6-9719-5d3e35a96f3a", "patient16@clinic.com", true, false, null, "PATIENT16@CLINIC.COM", "PATIENT16@CLINIC.COM", "AQAAAAIAAYagAAAAECEwyPIvdfqHQ6EWxzi0uf4mi+Z1YFAZf/XTToVjffnhNjKKi/+O7/VF4vCHwayniQ==", "01000000016", true, "0ebcffc5-9a3f-4709-ab95-739997005484", false, "patient16@clinic.com" },
                    { "0df249dc-078d-4f0a-9709-d3f628d5fce7", 0, "128c13c5-0c34-4e1c-9420-60297984e720", "patient2@clinic.com", true, false, null, "PATIENT2@CLINIC.COM", "PATIENT2@CLINIC.COM", "AQAAAAIAAYagAAAAEKtvb8JjoKfZAmjg6EYWU+eWrM+1CVlreLBHyXIJW/fOM5Sn0i2XUi+Xe4G9rZvLeg==", "01000000002", true, "22169dbf-42a6-41ae-8712-218d8612381e", false, "patient2@clinic.com" },
                    { "1660ddf2-fc20-40ae-a0e0-a9b3c6ef1489", 0, "c6118e3f-3765-4d07-9dcf-1e5bf937c89c", "doctor15@clinic.com", true, false, null, "DOCTOR15@CLINIC.COM", "DOCTOR15@CLINIC.COM", "AQAAAAIAAYagAAAAEEG90KalWrqOjgNwULu9w6vgFUrqwylxzoGswGGF85muPDXTSi1PjYl/3ikNhBENfQ==", "01100000015", true, "1575e5d6-d9a7-453f-ae39-ca686dfcf357", false, "doctor15@clinic.com" },
                    { "1c63783b-affc-40f1-9d4f-f4d4593ff09d", 0, "f2f8a9b4-858e-4e5d-9bee-dda8f082b60f", "patient11@clinic.com", true, false, null, "PATIENT11@CLINIC.COM", "PATIENT11@CLINIC.COM", "AQAAAAIAAYagAAAAECsLNfA4H0HIgM+Eo7q0ar7gAEYu8TIG/kAZkM+nP9H5X1O0bwxHn2AW6AJaNgmBUQ==", "01000000011", true, "62389492-e0b6-4a77-878e-285d38c8367d", false, "patient11@clinic.com" },
                    { "1d74cdaa-fe65-4358-88c6-cd1d2eeb86b4", 0, "d461a036-2c42-4f87-89f2-8449d64858f1", "doctor10@clinic.com", true, false, null, "DOCTOR10@CLINIC.COM", "DOCTOR10@CLINIC.COM", "AQAAAAIAAYagAAAAEAhMqai3y70YdpwQHSHLvxE77anjuMEEIXeLYPFREo46fj6yNmu5mnzPkWoFhytlcg==", "01100000010", true, "d7b9ff28-907a-40aa-ae9c-eb118b7386e2", false, "doctor10@clinic.com" },
                    { "1db9741a-8ead-4416-8207-d6ed26176eb9", 0, "4a49084e-acf1-47fa-8a59-7bb701979287", "doctor18@clinic.com", true, false, null, "DOCTOR18@CLINIC.COM", "DOCTOR18@CLINIC.COM", "AQAAAAIAAYagAAAAENTQNDISzAXWQotD7xGqZDCzbISVBM0pP9FWsdQ0mO74mSd3CVmMoKdm2gclLTyJtw==", "01100000018", true, "350c4c62-cfe9-4233-8623-0f7b5fb4ecb6", false, "doctor18@clinic.com" },
                    { "1e6e6d31-1208-4254-84a0-666ef240af48", 0, "ff2be00a-72a8-4d88-afce-11925044e513", "doctor9@clinic.com", true, false, null, "DOCTOR9@CLINIC.COM", "DOCTOR9@CLINIC.COM", "AQAAAAIAAYagAAAAEKU9WQ9BRQskCcAe3crQs8apn1ZFBFUbGohRxskCgFpwUtT8cvv3OilJYhvKm2Y18w==", "01100000009", true, "1182da7d-6cf7-4d5f-8e2d-2ae5fbec150d", false, "doctor9@clinic.com" },
                    { "1e7230ac-2344-47e4-b698-ef958bc93868", 0, "51e21788-0268-4151-ad16-7fb5af438899", "doctor14@clinic.com", true, false, null, "DOCTOR14@CLINIC.COM", "DOCTOR14@CLINIC.COM", "AQAAAAIAAYagAAAAELY+KXGKjDwuT+Z4NCVf9GjVTkITuPFaVEqPhD3D9KezIq89y67pSN3uX62fgLI7jw==", "01100000014", true, "d270558c-c041-4797-b703-678edc240f01", false, "doctor14@clinic.com" },
                    { "26f898b8-0deb-4ba9-8058-354a737a4687", 0, "11ce92eb-ab87-46a8-8c01-7a740c52855e", "patient12@clinic.com", true, false, null, "PATIENT12@CLINIC.COM", "PATIENT12@CLINIC.COM", "AQAAAAIAAYagAAAAEIM5UV0a3QBf6zvWzS/0yHAwEX3XLcRv0Y2bkvgZtMxxmACWVJ9Y5fXILnLXkIAhWA==", "01000000012", true, "070da9fb-4d83-4d74-a3f8-751ba83e4bb4", false, "patient12@clinic.com" },
                    { "29cb3ec1-e138-439b-9128-922bf2b3c338", 0, "cc0be3d8-9881-4483-a07d-a969980cb046", "patient4@clinic.com", true, false, null, "PATIENT4@CLINIC.COM", "PATIENT4@CLINIC.COM", "AQAAAAIAAYagAAAAEAYL+J61EsgX903JLM8WXK4bOr7kdsvIXp8IwtyTUjpbQk9wKeuARZ3XFXWPnSeQBg==", "01000000004", true, "6edd982e-f0f7-44fc-b817-61c2332fd40b", false, "patient4@clinic.com" },
                    { "29e30fb1-8998-4b05-adeb-5a75884e2aca", 0, "a589b910-4b17-487b-9014-cb9ead2478b8", "patient3@clinic.com", true, false, null, "PATIENT3@CLINIC.COM", "PATIENT3@CLINIC.COM", "AQAAAAIAAYagAAAAEPFADMai7cqKo9PkgkwUtHzSfXX24RjKSXeptM4lwBI0BJB3EM7kvHU7hLHqFE45Hg==", "01000000003", true, "701117d2-88d6-4ff9-9d92-5c8fd85ebd98", false, "patient3@clinic.com" },
                    { "2db8c815-4497-4a2c-9567-eb555115d05b", 0, "8581b27f-9f84-4bc0-82b3-21cc451399c5", "doctor20@clinic.com", true, false, null, "DOCTOR20@CLINIC.COM", "DOCTOR20@CLINIC.COM", "AQAAAAIAAYagAAAAEIcReBY0oXBfWR32gmKb1X3DGFNTPPdJnp3Ah8k6AAB/hDKv/Iu00H3uGCNcBYMwEQ==", "01100000020", true, "e353fb85-1620-4659-b95b-1f91d2563fdf", false, "doctor20@clinic.com" },
                    { "31a5d5ca-755b-4295-a6b5-1c6e90a4f051", 0, "42eb0ab5-9888-4881-81f4-3838c3878e45", "patient17@clinic.com", true, false, null, "PATIENT17@CLINIC.COM", "PATIENT17@CLINIC.COM", "AQAAAAIAAYagAAAAEOx94haA5UYD2TJ39rDdlwQQVrjXlR0PRr5ZTJab6KGS+Mh+ublbNMyfqZp8LA4xKQ==", "01000000017", true, "608bfba0-afba-484c-9ee7-9b194d126715", false, "patient17@clinic.com" },
                    { "38d495e2-af91-4b97-89e1-60827bb63a24", 0, "5d5aec81-118b-44c5-b9e6-e6710ca73aa3", "doctor12@clinic.com", true, false, null, "DOCTOR12@CLINIC.COM", "DOCTOR12@CLINIC.COM", "AQAAAAIAAYagAAAAEPcLrP7wIk7aKmJ+b/XknrRALoYfU+ZNjk3ulJrTZYWnPFlYkwCi+8d1Q4PXLsDcCg==", "01100000012", true, "b72ce1ce-3dae-49fd-b613-4999682a7f60", false, "doctor12@clinic.com" },
                    { "39f173ee-43e0-4b2d-a5bd-973e513472cc", 0, "76582f60-8c9a-49ad-b223-c8a20080a1db", "doctor11@clinic.com", true, false, null, "DOCTOR11@CLINIC.COM", "DOCTOR11@CLINIC.COM", "AQAAAAIAAYagAAAAEFlt4M++I0HONzK1rCgAkT0xBr/dL8Q239WWhQ24n7/P+T7dEqJUgrCQ3ePx4h7uaw==", "01100000011", true, "ce32660e-74ba-4d57-9d8f-3ecf0f28cc0e", false, "doctor11@clinic.com" },
                    { "4319c960-bf8a-4a56-8591-ac477d434d0e", 0, "8244cafe-fb42-48d7-9b51-1c26f28ec469", "patient14@clinic.com", true, false, null, "PATIENT14@CLINIC.COM", "PATIENT14@CLINIC.COM", "AQAAAAIAAYagAAAAEDYHMtWghu64alx8zUSwCpZof21/GNA+ptJ+4MRxk5anaCys9nWVCBzA0TGQdERsnw==", "01000000014", true, "dcf023b0-b6ca-4863-9858-ae2dc7215499", false, "patient14@clinic.com" },
                    { "507c3fc0-7ba1-45b6-8f4e-70daeee6a87b", 0, "e937187c-a7e3-4aa1-a988-14e9c2d1964e", "patient10@clinic.com", true, false, null, "PATIENT10@CLINIC.COM", "PATIENT10@CLINIC.COM", "AQAAAAIAAYagAAAAEPvINf1CzJW1nLC4tJZG9te7LuqCRW9OrDBb1+Dozp3cNJuwlgkcX6lzVZtTqfhN4g==", "01000000010", true, "1f6cd537-def2-430c-8ec9-cd459cf55788", false, "patient10@clinic.com" },
                    { "52cbe818-dd65-46ce-8764-830a3d9008f6", 0, "4e8d966a-02f0-4978-9f98-2a28848574d9", "patient1@clinic.com", true, false, null, "PATIENT1@CLINIC.COM", "PATIENT1@CLINIC.COM", "AQAAAAIAAYagAAAAEFzta9Vkotow/DhK5F3bab23pPMx0B3yloqUarzheWlSELqD5XZ+TQqyd+fUnKaDFw==", "01000000001", true, "3ffbc2c3-aedb-46eb-b807-18afee10835c", false, "patient1@clinic.com" },
                    { "640ba30c-0831-4e9d-b677-fc4dbd052882", 0, "3e4ffbbc-4db6-41f7-b1de-dbce2cab4a40", "doctor5@clinic.com", true, false, null, "DOCTOR5@CLINIC.COM", "DOCTOR5@CLINIC.COM", "AQAAAAIAAYagAAAAEKw2RV3YRofgdHTzLQshj1UdBOFl+qutPpH+fE+B4+DZMC2eRKV4xJ3tntVHQWa+tg==", "01100000005", true, "89106df2-17bd-4acd-9ffd-fdc1e04df2fb", false, "doctor5@clinic.com" },
                    { "66f7c3ff-cf5d-4022-9d03-4bcefc1e0a25", 0, "33e84adb-3475-4c47-8dc2-068a43c73cc5", "patient20@clinic.com", true, false, null, "PATIENT20@CLINIC.COM", "PATIENT20@CLINIC.COM", "AQAAAAIAAYagAAAAENgbcqQi8NxZmgjrbIvzpnrOJI0J58zDjVd2soxI20Yw2jYZNKZcMagIa+oLXHkHVQ==", "01000000020", true, "536884c9-e0fb-4caf-ac0b-50675eaa7e08", false, "patient20@clinic.com" },
                    { "670ab904-39e1-4d71-b77d-9058c4fb3826", 0, "3fd395c8-6645-49d5-95f2-96860f68f1d6", "doctor8@clinic.com", true, false, null, "DOCTOR8@CLINIC.COM", "DOCTOR8@CLINIC.COM", "AQAAAAIAAYagAAAAEE8XyVOg94FnQISLycw8qfhH7kC+8TPcC6RRJRdMrzQ+aESyan7pq/gjPZ5u04B5nQ==", "01100000008", true, "d1761ecc-a690-4bc6-b24f-05926c774d3c", false, "doctor8@clinic.com" },
                    { "73e422a2-ff2d-40da-ae75-82c96d3d0778", 0, "4d0f517b-bbb7-48b3-8178-968b92f3dcdf", "doctor13@clinic.com", true, false, null, "DOCTOR13@CLINIC.COM", "DOCTOR13@CLINIC.COM", "AQAAAAIAAYagAAAAEOBdqI5cH3FbAEO3eS6+JwyDL0LT0B4PF/873svQIg1/Ft59cmdYcTo4MdyiD9pekA==", "01100000013", true, "e06b5f55-e0cf-4170-8de3-5aa11d151e23", false, "doctor13@clinic.com" },
                    { "82624f06-56f4-49c8-84e4-dc5bb33c5247", 0, "7d41cd5f-aae2-4ba3-b0d1-014713a3f309", "patient9@clinic.com", true, false, null, "PATIENT9@CLINIC.COM", "PATIENT9@CLINIC.COM", "AQAAAAIAAYagAAAAED1Aoh4DoWnt+YAmnJ5T1kfANgK35FWYCVEo44pCevFbxKeC5B5APhuyCi9ArNt9IA==", "01000000009", true, "50ffae3c-cdb6-46e8-9f6f-076fce39d3ce", false, "patient9@clinic.com" },
                    { "88f16ccb-22ec-44f0-9f07-092241c4643c", 0, "e3e04159-007a-415a-bf13-d7fdb6671d66", "doctor7@clinic.com", true, false, null, "DOCTOR7@CLINIC.COM", "DOCTOR7@CLINIC.COM", "AQAAAAIAAYagAAAAEA3tepPwlgP5kCtDrBGQhd5fIm1bawzlDU+EMsg9e73Dh3uERf4kTd+7agAYyTwgEg==", "01100000007", true, "3fe93ff8-631a-4fd5-8633-857e12968ff9", false, "doctor7@clinic.com" },
                    { "93b598d1-17b3-427f-9488-a1e9e998aa6c", 0, "baf573bf-04d5-4007-addc-f2a24a13b257", "doctor6@clinic.com", true, false, null, "DOCTOR6@CLINIC.COM", "DOCTOR6@CLINIC.COM", "AQAAAAIAAYagAAAAEK+/IaVzgAq3IkDLB/6s0+Ks2p+WcS3fXUNR3DiOXzek4K94M2j/J40tAYWKNmggGA==", "01100000006", true, "45fe89cf-a991-488f-ac81-168b9cfcc99b", false, "doctor6@clinic.com" },
                    { "9f1d1b06-f65f-49e9-96e4-4c2b73b83983", 0, "02cb0b7d-b2c1-4285-b8af-b71ab8fd7fa1", "patient5@clinic.com", true, false, null, "PATIENT5@CLINIC.COM", "PATIENT5@CLINIC.COM", "AQAAAAIAAYagAAAAEHrsP2nEb65mWDXjgFtlrku8mGMY7Mjmf4w1vh+PLwApHR4qFz+xdD+ZD9S9CvNlgA==", "01000000005", true, "87589296-abd8-4786-a258-5d764e1d20ba", false, "patient5@clinic.com" },
                    { "a05a6664-68b9-48ff-a760-42b2f5b16e7f", 0, "874e58f7-d9f2-4324-978f-26491611353f", "patient6@clinic.com", true, false, null, "PATIENT6@CLINIC.COM", "PATIENT6@CLINIC.COM", "AQAAAAIAAYagAAAAEMlEebxbXx1FfkV9GdUAohp0/KLOhtt1uNW9idrxHJ+apSG3gMC8NJNcgUJOS7Z0xw==", "01000000006", true, "1ba3727d-7fa3-48c2-927d-09118c46b36a", false, "patient6@clinic.com" },
                    { "a3d69e15-a1a0-40b7-b29d-4c509ef3abb2", 0, "f6f6258f-1c67-41b0-8c92-d4473e52146c", "doctor3@clinic.com", true, false, null, "DOCTOR3@CLINIC.COM", "DOCTOR3@CLINIC.COM", "AQAAAAIAAYagAAAAELJCzyYUTosckjd82FGqXTKcIknOO/DUZoOYxGfoTQSUpV2c8MvJQeUfV4RdwQnPDA==", "01100000003", true, "e55e3846-7890-4a60-a3aa-0631a89b8648", false, "doctor3@clinic.com" },
                    { "ae9e4a55-1221-440a-9e81-26436f64666a", 0, "58c95c23-896d-41c2-b12c-93fdc1e0f1c9", "patient8@clinic.com", true, false, null, "PATIENT8@CLINIC.COM", "PATIENT8@CLINIC.COM", "AQAAAAIAAYagAAAAEDmi/tp6KawMhkSn8X931acEZA2YjSR15vz864RCa3lESdxjg5EQO+xGhMnM5Udr+A==", "01000000008", true, "1214581b-1017-4677-9a6c-996b6ae9cb96", false, "patient8@clinic.com" },
                    { "b2b74884-dc36-40af-a889-de4b0d44030a", 0, "88724701-3765-4751-be4d-17b2e2a299af", "doctor16@clinic.com", true, false, null, "DOCTOR16@CLINIC.COM", "DOCTOR16@CLINIC.COM", "AQAAAAIAAYagAAAAEBjni34urTTGkrFsq17Qmn7pn67rxJ3EfokuzmKVdN5Vy3aG9pY+Z0CGE7wnl3abYA==", "01100000016", true, "c6ea1e5c-dcc0-4b70-bbac-de88575a6465", false, "doctor16@clinic.com" },
                    { "b7041f80-6512-4fa9-b99e-7fa037fe1383", 0, "aac5f08a-5f92-4a29-a227-1256be36ae57", "doctor17@clinic.com", true, false, null, "DOCTOR17@CLINIC.COM", "DOCTOR17@CLINIC.COM", "AQAAAAIAAYagAAAAEOff+t8xRvTbLYwz7WOXEjY51P7nqv6KKaVhO7xqRkdwD4JJrxoP1URcY6n+Z7o88w==", "01100000017", true, "894d24cf-f390-4d4f-a5b1-a0b5345ab57a", false, "doctor17@clinic.com" },
                    { "c7758f2b-c854-4002-b334-1700df4c9a96", 0, "33bc4a99-7543-4cc5-ba1a-1ea9e8494c95", "doctor19@clinic.com", true, false, null, "DOCTOR19@CLINIC.COM", "DOCTOR19@CLINIC.COM", "AQAAAAIAAYagAAAAEIO6kzJ5tVu/yqfsDpCMBwyEudIIrcyj8xiH1HJKljGFQowCSHSZ3TiuCQKFW1xKAw==", "01100000019", true, "f13fb049-1755-4bf7-bab6-aa6bcb3eaa2c", false, "doctor19@clinic.com" },
                    { "ca9d8238-f49e-46e1-a9d7-9f5dc745e22c", 0, "80945fd6-6b0c-4e12-8a5d-2e8af3695f05", "patient15@clinic.com", true, false, null, "PATIENT15@CLINIC.COM", "PATIENT15@CLINIC.COM", "AQAAAAIAAYagAAAAEOeTo0HH2H6K4etZCNfg0NUGGusvemVTLBHxmJNlK7xiaiIKjCrKjJZSTnTe6gnfOQ==", "01000000015", true, "5b4c0b81-1303-4a02-afd1-d14626e50eb7", false, "patient15@clinic.com" },
                    { "cbff071f-b407-4dd2-a5c5-e4381cf5a5b7", 0, "ea9b5b07-a029-489e-bfb7-3e4df326de5b", "patient13@clinic.com", true, false, null, "PATIENT13@CLINIC.COM", "PATIENT13@CLINIC.COM", "AQAAAAIAAYagAAAAEHUx6ZfKzY5mztNjofoKuZPPqi6JuXsY2wF7UO7FM9F65XxhLJLkiaqUO+uENbvl1A==", "01000000013", true, "02cba3b7-4e82-4e13-99b8-5a8de1272601", false, "patient13@clinic.com" },
                    { "d329a52a-f062-483b-8ee0-5ee8bddec3cd", 0, "beb8726b-5362-474b-b201-b295c1dda66f", "doctor2@clinic.com", true, false, null, "DOCTOR2@CLINIC.COM", "DOCTOR2@CLINIC.COM", "AQAAAAIAAYagAAAAEHbW1796BbIVXmI6Kbjue0t5hOQNlE3YFTvlQgt2MYjeBSRSZ2ix33ff3z4xDZ3yMw==", "01100000002", true, "0e5c401e-9a97-4905-adfa-6701a408a6ba", false, "doctor2@clinic.com" },
                    { "e8d1902f-57d2-4718-85c7-1cf5f0a1ca18", 0, "2a85c041-7817-4d44-986f-3aacb8d82e56", "patient18@clinic.com", true, false, null, "PATIENT18@CLINIC.COM", "PATIENT18@CLINIC.COM", "AQAAAAIAAYagAAAAECAmJkUGHUTe2OfzEMjhyj6pnF4Y/257qc1rabcciNXyQ62ZIkIJ0UAwjYKGBVeBaw==", "01000000018", true, "27f56009-2bcc-4fb2-9a70-194a7089df5a", false, "patient18@clinic.com" },
                    { "ee9464c4-72dd-487e-abae-f28eb1f283d6", 0, "5fdf2825-8ca6-4fc7-b290-167338d79a49", "doctor1@clinic.com", true, false, null, "DOCTOR1@CLINIC.COM", "DOCTOR1@CLINIC.COM", "AQAAAAIAAYagAAAAEEH9FIkQSclacw1sRNDPzUqJTTYpfA6Cp8q6OLQG4jcrU0DmPZFZ1IuIIy0CJAo2Dg==", "01100000001", true, "06b3a41a-17d4-4085-8d57-2047412479b9", false, "doctor1@clinic.com" },
                    { "f6c65f86-cf25-455b-b8e9-cf7ce3da6616", 0, "4b10d7fe-31e4-4d35-97ef-be504b3650ab", "patient19@clinic.com", true, false, null, "PATIENT19@CLINIC.COM", "PATIENT19@CLINIC.COM", "AQAAAAIAAYagAAAAEPPNs1b+O90DbHLJEmusWt2jvxlcNknoiAM5sZH1u0DoMWT76OODWIGB8SR+I8chvg==", "01000000019", true, "713657b5-4226-4b00-9ec5-2b1b4308da7a", false, "patient19@clinic.com" },
                    { "f8962ac8-7736-429c-8370-b6a5706114c5", 0, "d81c072c-db3b-4e0e-86cb-16ae464b622a", "patient7@clinic.com", true, false, null, "PATIENT7@CLINIC.COM", "PATIENT7@CLINIC.COM", "AQAAAAIAAYagAAAAENUvvdyNj9ZjrMDzdP9ku+j3+S0muUMZjcScYFkniBfaTxoRHu5ZkTnTW1NABX6JDg==", "01000000007", true, "0df2a937-368d-4667-a4ee-08cb2bfce631", false, "patient7@clinic.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "06ef133d-a03d-4045-9dff-03ba2353c36b" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "0b1b1a02-ff25-46e8-add7-b55bc94596db" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "0df249dc-078d-4f0a-9709-d3f628d5fce7" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "1660ddf2-fc20-40ae-a0e0-a9b3c6ef1489" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "1c63783b-affc-40f1-9d4f-f4d4593ff09d" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "1d74cdaa-fe65-4358-88c6-cd1d2eeb86b4" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "1db9741a-8ead-4416-8207-d6ed26176eb9" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "1e6e6d31-1208-4254-84a0-666ef240af48" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "1e7230ac-2344-47e4-b698-ef958bc93868" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "26f898b8-0deb-4ba9-8058-354a737a4687" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "29cb3ec1-e138-439b-9128-922bf2b3c338" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "29e30fb1-8998-4b05-adeb-5a75884e2aca" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "2db8c815-4497-4a2c-9567-eb555115d05b" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "31a5d5ca-755b-4295-a6b5-1c6e90a4f051" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "38d495e2-af91-4b97-89e1-60827bb63a24" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "39f173ee-43e0-4b2d-a5bd-973e513472cc" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "4319c960-bf8a-4a56-8591-ac477d434d0e" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "507c3fc0-7ba1-45b6-8f4e-70daeee6a87b" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "52cbe818-dd65-46ce-8764-830a3d9008f6" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "640ba30c-0831-4e9d-b677-fc4dbd052882" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "66f7c3ff-cf5d-4022-9d03-4bcefc1e0a25" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "670ab904-39e1-4d71-b77d-9058c4fb3826" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "73e422a2-ff2d-40da-ae75-82c96d3d0778" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "82624f06-56f4-49c8-84e4-dc5bb33c5247" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "88f16ccb-22ec-44f0-9f07-092241c4643c" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "93b598d1-17b3-427f-9488-a1e9e998aa6c" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "9f1d1b06-f65f-49e9-96e4-4c2b73b83983" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "a05a6664-68b9-48ff-a760-42b2f5b16e7f" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "a3d69e15-a1a0-40b7-b29d-4c509ef3abb2" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "ae9e4a55-1221-440a-9e81-26436f64666a" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "b2b74884-dc36-40af-a889-de4b0d44030a" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "b7041f80-6512-4fa9-b99e-7fa037fe1383" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "c7758f2b-c854-4002-b334-1700df4c9a96" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "ca9d8238-f49e-46e1-a9d7-9f5dc745e22c" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "cbff071f-b407-4dd2-a5c5-e4381cf5a5b7" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "d329a52a-f062-483b-8ee0-5ee8bddec3cd" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "e8d1902f-57d2-4718-85c7-1cf5f0a1ca18" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "ee9464c4-72dd-487e-abae-f28eb1f283d6" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "f6c65f86-cf25-455b-b8e9-cf7ce3da6616" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "f8962ac8-7736-429c-8370-b6a5706114c5" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Price", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("06d45262-87d8-4219-bb23-8acff618d7f5"), 109.0, "Specialty 9", "1e6e6d31-1208-4254-84a0-666ef240af48" },
                    { new Guid("1a2f49ba-da0e-4535-a79e-cc158fce99c1"), 118.0, "Specialty 18", "1db9741a-8ead-4416-8207-d6ed26176eb9" },
                    { new Guid("1c164853-7e4d-4afa-9ad8-9fe98385802e"), 111.0, "Specialty 11", "39f173ee-43e0-4b2d-a5bd-973e513472cc" },
                    { new Guid("1d67eaef-637d-47b3-b6f4-3914e5e07472"), 102.0, "Specialty 2", "d329a52a-f062-483b-8ee0-5ee8bddec3cd" },
                    { new Guid("2a0b83bf-316d-4bf4-b4a1-c9951bf23464"), 119.0, "Specialty 19", "c7758f2b-c854-4002-b334-1700df4c9a96" },
                    { new Guid("34a5d994-d051-4f61-936c-8a9851f8b7d6"), 110.0, "Specialty 10", "1d74cdaa-fe65-4358-88c6-cd1d2eeb86b4" },
                    { new Guid("428d16f9-acc5-477e-8157-484d88e54c7e"), 105.0, "Specialty 5", "640ba30c-0831-4e9d-b677-fc4dbd052882" },
                    { new Guid("457be12e-9fcf-4509-a7ac-fe97a46229a6"), 112.0, "Specialty 12", "38d495e2-af91-4b97-89e1-60827bb63a24" },
                    { new Guid("4d186b3c-69a4-4956-9657-49b81ad7938e"), 114.0, "Specialty 14", "1e7230ac-2344-47e4-b698-ef958bc93868" },
                    { new Guid("58e9b0ca-4cb2-40b1-a834-ba50ee16b3df"), 113.0, "Specialty 13", "73e422a2-ff2d-40da-ae75-82c96d3d0778" },
                    { new Guid("5fca8307-11e7-48c3-9f30-d36c205ffb58"), 117.0, "Specialty 17", "b7041f80-6512-4fa9-b99e-7fa037fe1383" },
                    { new Guid("622131d6-49bc-40a4-848c-41af48f51b48"), 120.0, "Specialty 20", "2db8c815-4497-4a2c-9567-eb555115d05b" },
                    { new Guid("6ca827fc-10f0-4329-85a6-a25916ba22ac"), 103.0, "Specialty 3", "a3d69e15-a1a0-40b7-b29d-4c509ef3abb2" },
                    { new Guid("7426cc31-387c-4357-b0f3-05c06b3e57ce"), 115.0, "Specialty 15", "1660ddf2-fc20-40ae-a0e0-a9b3c6ef1489" },
                    { new Guid("79c290a0-dcce-4ecc-be7a-7b841e83ea09"), 116.0, "Specialty 16", "b2b74884-dc36-40af-a889-de4b0d44030a" },
                    { new Guid("9ea2cd4a-2c48-429a-b04a-c48a58c977d8"), 108.0, "Specialty 8", "670ab904-39e1-4d71-b77d-9058c4fb3826" },
                    { new Guid("aa0c65cf-a02e-4674-8422-3f713f6632f2"), 101.0, "Specialty 1", "ee9464c4-72dd-487e-abae-f28eb1f283d6" },
                    { new Guid("cab0f693-2a97-43d2-bee3-01e4da18a12d"), 107.0, "Specialty 7", "88f16ccb-22ec-44f0-9f07-092241c4643c" },
                    { new Guid("e25eff5e-9a84-478e-ac04-ee5567fde919"), 106.0, "Specialty 6", "93b598d1-17b3-427f-9488-a1e9e998aa6c" },
                    { new Guid("eae35e10-9825-4944-adfa-9961a25d6f55"), 104.0, "Specialty 4", "06ef133d-a03d-4045-9dff-03ba2353c36b" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "Date", "DoctorId", "PatientId", "State", "Time" },
                values: new object[,]
                {
                    { new Guid("1caad92d-bac0-4527-b80f-7ea7cf0ea111"), "2025-05-03", new Guid("6ca827fc-10f0-4329-85a6-a25916ba22ac"), "29e30fb1-8998-4b05-adeb-5a75884e2aca", "Scheduled", "11:00 AM" },
                    { new Guid("212a8a00-70ea-4ddd-afb7-e034e65148be"), "2025-05-10", new Guid("34a5d994-d051-4f61-936c-8a9851f8b7d6"), "507c3fc0-7ba1-45b6-8f4e-70daeee6a87b", "Scheduled", "18:00 AM" },
                    { new Guid("2a64bbf9-583f-4112-966f-d46740a872bc"), "2025-05-04", new Guid("eae35e10-9825-4944-adfa-9961a25d6f55"), "29cb3ec1-e138-439b-9128-922bf2b3c338", "Scheduled", "12:00 AM" },
                    { new Guid("36218d0f-f9b6-4246-84b2-d78c1bd75b02"), "2025-05-09", new Guid("06d45262-87d8-4219-bb23-8acff618d7f5"), "82624f06-56f4-49c8-84e4-dc5bb33c5247", "Scheduled", "17:00 AM" },
                    { new Guid("3731761a-ebb4-4f64-a520-f98f9cac23e6"), "2025-05-07", new Guid("cab0f693-2a97-43d2-bee3-01e4da18a12d"), "f8962ac8-7736-429c-8370-b6a5706114c5", "Scheduled", "15:00 AM" },
                    { new Guid("4a9aa06f-481e-42a3-9102-780c16504f88"), "2025-05-12", new Guid("457be12e-9fcf-4509-a7ac-fe97a46229a6"), "26f898b8-0deb-4ba9-8058-354a737a4687", "Scheduled", "20:00 AM" },
                    { new Guid("4b77b84f-42f0-4efd-b35c-290b75caabcb"), "2025-05-01", new Guid("aa0c65cf-a02e-4674-8422-3f713f6632f2"), "52cbe818-dd65-46ce-8764-830a3d9008f6", "Scheduled", "9:00 AM" },
                    { new Guid("6e897d9a-896d-469b-8243-886bb116ea3d"), "2025-05-14", new Guid("4d186b3c-69a4-4956-9657-49b81ad7938e"), "4319c960-bf8a-4a56-8591-ac477d434d0e", "Scheduled", "10:00 AM" },
                    { new Guid("825ed25d-b7e1-4a69-bd8d-3d23678adc38"), "2025-05-15", new Guid("7426cc31-387c-4357-b0f3-05c06b3e57ce"), "ca9d8238-f49e-46e1-a9d7-9f5dc745e22c", "Scheduled", "11:00 AM" },
                    { new Guid("9501cc24-b228-4837-8f9b-8bfe9de64832"), "2025-05-08", new Guid("9ea2cd4a-2c48-429a-b04a-c48a58c977d8"), "ae9e4a55-1221-440a-9e81-26436f64666a", "Scheduled", "16:00 AM" },
                    { new Guid("9c45c14e-3653-43f8-a411-e43b4a1d58f7"), "2025-05-16", new Guid("79c290a0-dcce-4ecc-be7a-7b841e83ea09"), "0b1b1a02-ff25-46e8-add7-b55bc94596db", "Scheduled", "12:00 AM" },
                    { new Guid("9ee67f13-e69d-41cd-9cb7-7aa6a8725f7e"), "2025-05-06", new Guid("e25eff5e-9a84-478e-ac04-ee5567fde919"), "a05a6664-68b9-48ff-a760-42b2f5b16e7f", "Scheduled", "14:00 AM" },
                    { new Guid("a2a3c34d-54f5-4ea2-b3a6-35e9d03b41bb"), "2025-05-17", new Guid("5fca8307-11e7-48c3-9f30-d36c205ffb58"), "31a5d5ca-755b-4295-a6b5-1c6e90a4f051", "Scheduled", "13:00 AM" },
                    { new Guid("bea03a0a-a2e0-4781-b423-d42860218600"), "2025-05-18", new Guid("1a2f49ba-da0e-4535-a79e-cc158fce99c1"), "e8d1902f-57d2-4718-85c7-1cf5f0a1ca18", "Scheduled", "14:00 AM" },
                    { new Guid("e2c9aec5-98bf-45b3-a9df-ab27262dc4b3"), "2025-05-13", new Guid("58e9b0ca-4cb2-40b1-a834-ba50ee16b3df"), "cbff071f-b407-4dd2-a5c5-e4381cf5a5b7", "Scheduled", "9:00 AM" },
                    { new Guid("e6345352-3410-464c-8578-0f5e2ef83cfe"), "2025-05-19", new Guid("2a0b83bf-316d-4bf4-b4a1-c9951bf23464"), "f6c65f86-cf25-455b-b8e9-cf7ce3da6616", "Scheduled", "15:00 AM" },
                    { new Guid("f31a040b-2eb0-4661-9d58-3c3fbffd6402"), "2025-05-11", new Guid("1c164853-7e4d-4afa-9ad8-9fe98385802e"), "1c63783b-affc-40f1-9d4f-f4d4593ff09d", "Scheduled", "19:00 AM" },
                    { new Guid("f4d86dcb-838c-4d6b-93e0-dde2f1a5ebae"), "2025-05-02", new Guid("1d67eaef-637d-47b3-b6f4-3914e5e07472"), "0df249dc-078d-4f0a-9709-d3f628d5fce7", "Scheduled", "10:00 AM" },
                    { new Guid("f4ea6c65-2b12-4690-8b95-887f9ea4ffe3"), "2025-05-20", new Guid("622131d6-49bc-40a4-848c-41af48f51b48"), "66f7c3ff-cf5d-4022-9d03-4bcefc1e0a25", "Scheduled", "16:00 AM" },
                    { new Guid("fe7462a6-f917-4d32-b742-3e67ea67a3e4"), "2025-05-05", new Guid("428d16f9-acc5-477e-8157-484d88e54c7e"), "9f1d1b06-f65f-49e9-96e4-4c2b73b83983", "Scheduled", "13:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Id", "AppointmentId", "Description", "Modification_date" },
                values: new object[,]
                {
                    { new Guid("06fb88b0-a3f4-4695-86e7-a6a55d7d1381"), new Guid("2a64bbf9-583f-4112-966f-d46740a872bc"), "Prescription for appointment 4", "2025-04-21" },
                    { new Guid("07c58e22-edfb-4862-a5a6-fe67fef640b6"), new Guid("825ed25d-b7e1-4a69-bd8d-3d23678adc38"), "Prescription for appointment 15", "2025-04-21" },
                    { new Guid("0a4e6800-29f9-4ea8-acda-762843d1a5e7"), new Guid("e2c9aec5-98bf-45b3-a9df-ab27262dc4b3"), "Prescription for appointment 13", "2025-04-21" },
                    { new Guid("171772ac-4f55-4352-acd3-984fc24fd21e"), new Guid("212a8a00-70ea-4ddd-afb7-e034e65148be"), "Prescription for appointment 10", "2025-04-21" },
                    { new Guid("186bb93b-1d1e-4653-b9ab-8dd17952fe54"), new Guid("9ee67f13-e69d-41cd-9cb7-7aa6a8725f7e"), "Prescription for appointment 6", "2025-04-21" },
                    { new Guid("1c8f1052-d43c-445c-a644-78af76fcbd40"), new Guid("1caad92d-bac0-4527-b80f-7ea7cf0ea111"), "Prescription for appointment 3", "2025-04-21" },
                    { new Guid("35aa7d28-c3fa-4009-91d9-02e92fb697a5"), new Guid("9501cc24-b228-4837-8f9b-8bfe9de64832"), "Prescription for appointment 8", "2025-04-21" },
                    { new Guid("37ecd7c3-ca7f-41af-b336-818aad0d2ac0"), new Guid("4b77b84f-42f0-4efd-b35c-290b75caabcb"), "Prescription for appointment 1", "2025-04-21" },
                    { new Guid("51316038-270f-4515-81d2-a6aa49fea6f3"), new Guid("6e897d9a-896d-469b-8243-886bb116ea3d"), "Prescription for appointment 14", "2025-04-21" },
                    { new Guid("7acb50e7-40ac-4b1f-a0a2-e21f6e4a0133"), new Guid("4a9aa06f-481e-42a3-9102-780c16504f88"), "Prescription for appointment 12", "2025-04-21" },
                    { new Guid("7c4a3156-2e4e-45bc-9def-94c35f2d39d7"), new Guid("e6345352-3410-464c-8578-0f5e2ef83cfe"), "Prescription for appointment 19", "2025-04-21" },
                    { new Guid("8e74b5c0-da63-4131-8957-29d690e2974e"), new Guid("f4d86dcb-838c-4d6b-93e0-dde2f1a5ebae"), "Prescription for appointment 2", "2025-04-21" },
                    { new Guid("8fc62aee-d315-459f-84ab-224e37f95ba8"), new Guid("f4ea6c65-2b12-4690-8b95-887f9ea4ffe3"), "Prescription for appointment 20", "2025-04-21" },
                    { new Guid("a1a09032-f9fb-4e70-9a61-18299f48912f"), new Guid("a2a3c34d-54f5-4ea2-b3a6-35e9d03b41bb"), "Prescription for appointment 17", "2025-04-21" },
                    { new Guid("bb84d3e2-f9c5-4bb3-80ca-ecea4332613a"), new Guid("fe7462a6-f917-4d32-b742-3e67ea67a3e4"), "Prescription for appointment 5", "2025-04-21" },
                    { new Guid("ccb9531f-d8a5-4d06-bb7f-4a29951dfb2c"), new Guid("f31a040b-2eb0-4661-9d58-3c3fbffd6402"), "Prescription for appointment 11", "2025-04-21" },
                    { new Guid("d9355738-e01a-4c49-8b4a-12d5885ec39c"), new Guid("3731761a-ebb4-4f64-a520-f98f9cac23e6"), "Prescription for appointment 7", "2025-04-21" },
                    { new Guid("ee977b97-7362-4eb1-aac8-c2de724a2f5d"), new Guid("bea03a0a-a2e0-4781-b423-d42860218600"), "Prescription for appointment 18", "2025-04-21" },
                    { new Guid("fbc09132-f975-4c50-8dd2-34851d46c601"), new Guid("36218d0f-f9b6-4246-84b2-d78c1bd75b02"), "Prescription for appointment 9", "2025-04-21" },
                    { new Guid("ff3bc475-cf1e-4581-8d30-de2155f3799f"), new Guid("9c45c14e-3653-43f8-a411-e43b4a1d58f7"), "Prescription for appointment 16", "2025-04-21" }
                });
        }
    }
}
