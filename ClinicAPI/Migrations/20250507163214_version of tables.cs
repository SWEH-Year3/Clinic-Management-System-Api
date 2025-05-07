using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class versionoftables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Specialty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_AspNetUsers_PatientId",
                        column: x => x.PatientId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prescriptions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Modification_date = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prescriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prescriptions_Appointments_AppointmentId",
                        column: x => x.AppointmentId,
                        principalTable: "Appointments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FileImages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileLength = table.Column<double>(type: "float", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrescriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FileImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FileImages_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FileImages_Prescriptions_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "Prescriptions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", null, "Doctor", "DOCTOR" },
                    { "675b578c-8739-4b1b-a706-816fb14910bd", null, "Admin", "ADMIN" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", null, "Patient", "PATIENT" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "08fa64d7-4992-4b42-bc61-543bae5f14fe", 0, "73e78618-d196-44df-aafe-bb056c74f011", "doctor9@clinic.com", true, false, null, "DOCTOR9@CLINIC.COM", "DOCTOR9@CLINIC.COM", "AQAAAAIAAYagAAAAELjz5NqgcJBHAeNl07MCwZXGNPBxmIZJoFAJUEMOmwH4qOHtzWoX4NERF0bUOfXIDw==", "01100000009", true, "855eac10-2f21-42fa-a129-2cda51861d85", false, "doctor9@clinic.com" },
                    { "0dd15ea2-0b87-4a71-a344-822c4f81c31b", 0, "4f795bbb-f4c1-42af-8e6a-570d3c9627f8", "patient3@clinic.com", true, false, null, "PATIENT3@CLINIC.COM", "PATIENT3@CLINIC.COM", "AQAAAAIAAYagAAAAEOip256a89yocxldVKkzZ34m727moJeejBkwxBv/mOTLTv/1aSLIoEO8g0WE/fyn4g==", "01000000003", true, "d1ae3168-fb47-4cad-9d0b-1d4f9e7b68a9", false, "patient3@clinic.com" },
                    { "155af4cd-9869-4ae2-bf58-5c743184adc9", 0, "6154583d-5433-4476-869f-004ce0a24304", "patient1@clinic.com", true, false, null, "PATIENT1@CLINIC.COM", "PATIENT1@CLINIC.COM", "AQAAAAIAAYagAAAAEM5OVfhQ22b5JEfILSWyIyiHe5DvXmf+Stj681xqeFDvpJDdSUaogZ8q+ygdqzjOGg==", "01000000001", true, "5f548e44-5494-438a-844a-c09b965cd650", false, "patient1@clinic.com" },
                    { "1c163814-12e4-47d8-aa17-68bcbdbf897a", 0, "98627825-bf99-4167-918d-87e0c86bde5d", "patient7@clinic.com", true, false, null, "PATIENT7@CLINIC.COM", "PATIENT7@CLINIC.COM", "AQAAAAIAAYagAAAAEKBaGQ+/54ArO5Ubzz7Jt9GKlBxPS5qIxCoLnkFjOlVkdvqqWHaVI8Q5b4MN2J8xTQ==", "01000000007", true, "40bc8688-5a49-48bf-9b78-1397486ab0e8", false, "patient7@clinic.com" },
                    { "1e04d179-7281-4106-8744-88dc51d83d78", 0, "01ff0d77-a20a-44f3-b518-669ade0c37b7", "patient17@clinic.com", true, false, null, "PATIENT17@CLINIC.COM", "PATIENT17@CLINIC.COM", "AQAAAAIAAYagAAAAEJ+vFdk0exYYe2zn/myTFobF7wo1iC1Cf5VAFDF5ssJ8+WwWD03FQDGnYP2eFvF/tw==", "01000000017", true, "c37d1d63-7d11-48de-a538-c46ffc6b25d4", false, "patient17@clinic.com" },
                    { "208a800c-b8bc-4f7c-aa27-b1f5d1f75ce0", 0, "c7c22ebc-e261-490f-9507-9c624e62c226", "doctor12@clinic.com", true, false, null, "DOCTOR12@CLINIC.COM", "DOCTOR12@CLINIC.COM", "AQAAAAIAAYagAAAAEM4p+J+e6MgFVlA7oMRTagfANLuY13suYNykV40yk6L7UG+2VWwnura6tkMzX0dn5w==", "01100000012", true, "0e3d4eb6-34f5-432b-9664-d42958d6fd44", false, "doctor12@clinic.com" },
                    { "239278b6-d460-46d5-a67b-65b2ea8bff56", 0, "3ce45508-cc7a-4255-b7f2-be229250ae49", "doctor10@clinic.com", true, false, null, "DOCTOR10@CLINIC.COM", "DOCTOR10@CLINIC.COM", "AQAAAAIAAYagAAAAENzSMNJ/43eJ0sNV9I9Ed+ENewNoG3OQViSSjmSPRSYfjsN/uCWXsGh2/f4K7bNRCQ==", "01100000010", true, "22e09971-2548-4703-be16-0f17190ab017", false, "doctor10@clinic.com" },
                    { "27bc3900-c570-42a9-968a-388cc321ce04", 0, "22d72e2e-22e6-4040-862a-55aa19a8f0bc", "patient14@clinic.com", true, false, null, "PATIENT14@CLINIC.COM", "PATIENT14@CLINIC.COM", "AQAAAAIAAYagAAAAEBqHYS3pbJgDOdbemlkKGdMt+RXYQXeotH5ckDgFHkVoVuCJLSc1jNXkypP0ts3SKQ==", "01000000014", true, "06db4b99-8c94-4001-a4c9-a02502bcd343", false, "patient14@clinic.com" },
                    { "332f34b3-de2d-4319-882a-d5b5e6257f31", 0, "ae20e1e7-21cb-4746-a19c-db0678f9eeea", "doctor6@clinic.com", true, false, null, "DOCTOR6@CLINIC.COM", "DOCTOR6@CLINIC.COM", "AQAAAAIAAYagAAAAEMxZph5j0ingQLn+r/pTUv8uP3leV2Lcv/svU/kciF84hTvxcym2RVFmvVI8gcjZ6w==", "01100000006", true, "114338de-a517-470c-823e-9abd4580e030", false, "doctor6@clinic.com" },
                    { "37d40e73-452e-4d21-83cd-a233c182a675", 0, "3ca28c9e-d877-466b-83f4-224cc2f8476e", "doctor20@clinic.com", true, false, null, "DOCTOR20@CLINIC.COM", "DOCTOR20@CLINIC.COM", "AQAAAAIAAYagAAAAEOYMi5e9wx5mhBwlLYp6g1T8ojQhXpW1+nY5dXEMKbLNi2U9Au+UfJLZtGUMndKklw==", "01100000020", true, "d4d81e51-9127-43be-a7a3-9dffa4f9ce95", false, "doctor20@clinic.com" },
                    { "388a7b3c-6bf5-4bed-a8e2-c94d4748ee73", 0, "e895bb86-ed79-4e1f-bfa5-3d724e4cc067", "doctor4@clinic.com", true, false, null, "DOCTOR4@CLINIC.COM", "DOCTOR4@CLINIC.COM", "AQAAAAIAAYagAAAAEF9d/j5qD9Wb78c3d9IjrwWPMQN0QakufpSOb2MvDQrpcmfemsuZDC407oEOpVrQ8w==", "01100000004", true, "158d2bef-44be-4a9d-9322-d45a2288022c", false, "doctor4@clinic.com" },
                    { "3b98d85c-0738-4834-91d6-ff8243b6bb78", 0, "e470f107-fb70-4442-afc4-a9fba7496a55", "doctor3@clinic.com", true, false, null, "DOCTOR3@CLINIC.COM", "DOCTOR3@CLINIC.COM", "AQAAAAIAAYagAAAAEG4/sNh1MUs9Pn0Sr2FKFODVg1G3BpXr1lKsrbCc7tNmFhrkiMQ9glaU2chsLyThiA==", "01100000003", true, "dc4f666c-0c23-4174-909e-2f8e4f359861", false, "doctor3@clinic.com" },
                    { "3c429440-8760-40f6-9aa6-cfed9f0c197a", 0, "01ac467c-b3b8-46a3-ba95-cc8a3d196508", "patient20@clinic.com", true, false, null, "PATIENT20@CLINIC.COM", "PATIENT20@CLINIC.COM", "AQAAAAIAAYagAAAAELljl5zOVRYcOGgtBAjVJrTHJeVgEGieEq0rMQow4Es3oX+3W8JElvfP0vjIAwjltw==", "01000000020", true, "e1908580-e95a-4aa8-8800-f79ccf0dbbd6", false, "patient20@clinic.com" },
                    { "471ff9a6-382a-42d5-ae41-5350c22d3056", 0, "18a28e36-93e6-4b76-8fda-2ebaf93efe03", "patient18@clinic.com", true, false, null, "PATIENT18@CLINIC.COM", "PATIENT18@CLINIC.COM", "AQAAAAIAAYagAAAAEMKdLQa9v8M6DlaCR2XEDLXX8c0J/mNc8QHnCBoGc66qcnMUuF+ZfKkyG3GaDjb/0g==", "01000000018", true, "17935b3c-9fd0-49db-a192-f32f43253ae3", false, "patient18@clinic.com" },
                    { "4896696a-191d-4bdf-a628-55ec955890c8", 0, "f96d0d98-110f-4a19-b63d-d149d6486771", "patient10@clinic.com", true, false, null, "PATIENT10@CLINIC.COM", "PATIENT10@CLINIC.COM", "AQAAAAIAAYagAAAAEEJN+pzoliv5xxeMMlQ+Aho/+UVpixZGHHCE/3G8HfTGLqLM8TboMuT2OjRmWgkF9w==", "01000000010", true, "969ae3fc-49ca-4ca8-b32d-fc8119e04d6a", false, "patient10@clinic.com" },
                    { "48b56279-bb35-4703-92a4-4ae6788693e0", 0, "3e0bb603-edb9-4b8b-b1ab-41923855b9c5", "doctor7@clinic.com", true, false, null, "DOCTOR7@CLINIC.COM", "DOCTOR7@CLINIC.COM", "AQAAAAIAAYagAAAAELWjMZo7ZSlQDqwaVc49QBftHH5HRqDZEePdOzOQu+Lz8z+Mgdiv8dwv0Sw3uZi2vg==", "01100000007", true, "dd67df17-132d-4b8f-be76-8563423ced64", false, "doctor7@clinic.com" },
                    { "4bcbf4c1-97c3-4672-9613-73adec3ac42e", 0, "88b6ae85-cc79-4803-adb2-b22c9b4808fe", "doctor2@clinic.com", true, false, null, "DOCTOR2@CLINIC.COM", "DOCTOR2@CLINIC.COM", "AQAAAAIAAYagAAAAEIN1RLVq1T42Xz0Unt0VLuWoBYxyMubZWDXvX37CzNlr1x91jMLws7bCmr/3ZM5rgg==", "01100000002", true, "93ac3fd9-8577-4184-ae57-547b7f12573e", false, "doctor2@clinic.com" },
                    { "4e1b7bf2-f505-4c17-944b-4455e450adc2", 0, "b6e85fa0-bb5a-41ef-af05-0b06b4a4cc09", "patient5@clinic.com", true, false, null, "PATIENT5@CLINIC.COM", "PATIENT5@CLINIC.COM", "AQAAAAIAAYagAAAAECPbMdr7bCuELXj5eadQpJthtkeTmCrh8OR0PDD/Kgz2eAqcnDV2wTMjthj1QnykWw==", "01000000005", true, "b5e4cfa5-1c7c-4dd2-a4cd-041c49a8e127", false, "patient5@clinic.com" },
                    { "50583878-1af1-4c74-bc91-47bb6eb09889", 0, "e4323992-6b90-42c4-b69c-10c10a4343b6", "patient15@clinic.com", true, false, null, "PATIENT15@CLINIC.COM", "PATIENT15@CLINIC.COM", "AQAAAAIAAYagAAAAEPl3RiqrjMK3ifd7Ll9ZHunp2SFAY9NZHO2yt/3atnwTAI8Zs+Aj7v+xBO969fhUDw==", "01000000015", true, "2af2e0bc-9c0d-460d-93d8-a4e51024e9a3", false, "patient15@clinic.com" },
                    { "54313667-8d2c-444e-8dc3-291a46c27d0c", 0, "802301f2-23cb-401a-b1f8-a8d03cd6106d", "doctor1@clinic.com", true, false, null, "DOCTOR1@CLINIC.COM", "DOCTOR1@CLINIC.COM", "AQAAAAIAAYagAAAAECilJ5gdJnXQIkeqlKRziTdFfuTj85B06rbe8YzxKfK52yM5JKcAK1knB1nKsOJkOA==", "01100000001", true, "26da348c-d340-4e05-ab69-d632c8a5073b", false, "doctor1@clinic.com" },
                    { "7ac5d4de-d0fd-4958-bc83-dd478b22e4f5", 0, "b122e653-f577-4237-831b-735483d3258e", "doctor14@clinic.com", true, false, null, "DOCTOR14@CLINIC.COM", "DOCTOR14@CLINIC.COM", "AQAAAAIAAYagAAAAEMvZbQvOk/QMRVgngMnS1ymmUPi458i+ovsX7fR6K6JgHgk8Hvibbgg2lML6zy2p3g==", "01100000014", true, "d09aaf19-6076-43e0-9fe7-2bfd0a988dd9", false, "doctor14@clinic.com" },
                    { "83519268-6998-43f9-b36e-52a61fd2ebea", 0, "73fa63bd-4bf4-4116-a3d3-4b3b4bb40605", "patient2@clinic.com", true, false, null, "PATIENT2@CLINIC.COM", "PATIENT2@CLINIC.COM", "AQAAAAIAAYagAAAAEAgt603wL72x8SMAksOv7fQ0IMZCfas4nsN287358ermsvoZDG7+LiL9GazGNUi6yQ==", "01000000002", true, "a7a05b69-5f98-4d56-93d3-06dc4467b996", false, "patient2@clinic.com" },
                    { "9c825ad4-18e1-4368-8dbc-329f78534d91", 0, "33419765-40ec-4c02-b4e6-ac259889baa1", "doctor15@clinic.com", true, false, null, "DOCTOR15@CLINIC.COM", "DOCTOR15@CLINIC.COM", "AQAAAAIAAYagAAAAEImJyMUOMQ/rL/HYe3iCedS4SteSccdAldVlXZ8Ecm4RB0/CrNYvHfHgAxySv07KUQ==", "01100000015", true, "93b827e1-ad62-4d45-a595-31984744df63", false, "doctor15@clinic.com" },
                    { "9e395a1b-9a82-46a2-8b36-7e11ea2afc8f", 0, "02eb7f99-78b8-43f4-86fd-be1a68a03b4c", "doctor5@clinic.com", true, false, null, "DOCTOR5@CLINIC.COM", "DOCTOR5@CLINIC.COM", "AQAAAAIAAYagAAAAEEpdRAyCukzlpZJo5JOkBjhIpIbU2UWr9zmvZgqKVapHpzQfxWjRFSvNevICZJU/Bg==", "01100000005", true, "38d14990-a544-414c-893b-c8c25c51687d", false, "doctor5@clinic.com" },
                    { "9ea01535-9542-444a-872f-08d09cb4b654", 0, "a58e7f91-bf33-478e-9d9c-1c5254959afe", "patient19@clinic.com", true, false, null, "PATIENT19@CLINIC.COM", "PATIENT19@CLINIC.COM", "AQAAAAIAAYagAAAAEHvZV/pa5iOO3QS4uR84p3f4bsXOnYjFF5e/CeMrhRTKCExICic4i0AYG4rPBCyceg==", "01000000019", true, "c887b94b-9340-4e2b-83ae-59281fc992f2", false, "patient19@clinic.com" },
                    { "9f27b9fb-1ba1-45ee-a85d-c3b190b2fc44", 0, "6ef405f6-c0db-4091-ac27-a48860a294d9", "doctor13@clinic.com", true, false, null, "DOCTOR13@CLINIC.COM", "DOCTOR13@CLINIC.COM", "AQAAAAIAAYagAAAAEKi4ShXGTN0g1DV1BkUtgp/RRl+Xm0s9iDxG2OfxD8B39X2nSF73E60OKlrWCoBpPg==", "01100000013", true, "9c13269a-8bbe-4df7-a8bb-e4e97140b085", false, "doctor13@clinic.com" },
                    { "a4779ae0-81c9-46b7-b989-709460127449", 0, "f967c5e9-dd5b-4908-b905-951e450efecf", "patient4@clinic.com", true, false, null, "PATIENT4@CLINIC.COM", "PATIENT4@CLINIC.COM", "AQAAAAIAAYagAAAAEGnGTFzgi4CVx7Tp8w0V5TbOqgOraK6mrZpzVqxHon52TgHaZAvadMhijixAYN0W1w==", "01000000004", true, "c6973e65-6c05-428d-9aa2-7b362b58546f", false, "patient4@clinic.com" },
                    { "a9d51468-2a82-41cc-9503-2662a256a4b4", 0, "4b8441f8-051e-4be0-b9ba-ef7791e4ab0b", "patient9@clinic.com", true, false, null, "PATIENT9@CLINIC.COM", "PATIENT9@CLINIC.COM", "AQAAAAIAAYagAAAAEIei6KW8m7fJeLcbnNxqeRYx0kZS5n3xJQyQDPABOKR8OQkVriYEEe2uGXctVMafAg==", "01000000009", true, "d8f0c810-1eec-43e2-8405-c1f9ca88f4dc", false, "patient9@clinic.com" },
                    { "ad16ed51-e493-49ad-a1ee-4c04707de040", 0, "5ace0e88-02d4-4f2f-96d5-edb0feb13ec3", "doctor18@clinic.com", true, false, null, "DOCTOR18@CLINIC.COM", "DOCTOR18@CLINIC.COM", "AQAAAAIAAYagAAAAEHZyarj6koFPlcuxloJ2dfKPErD3dBNaduy7ZhQxJuKueA7jKMeQKvqqhtzixbvc2A==", "01100000018", true, "14ae7485-7e84-4163-9d24-c9f3244081b0", false, "doctor18@clinic.com" },
                    { "b728a214-1340-475f-b13a-c62e618669b2", 0, "ccf12655-7b06-4c85-a643-60d89498b30e", "patient8@clinic.com", true, false, null, "PATIENT8@CLINIC.COM", "PATIENT8@CLINIC.COM", "AQAAAAIAAYagAAAAEI9tOXTv7cesZleHxmeRLFnAQT90CLXYiO/U9+7AMjHytXK8Rsb17pi3q5laP/62/A==", "01000000008", true, "0b7784ac-4d54-4c19-9d54-b4af44fe16f2", false, "patient8@clinic.com" },
                    { "b7c5a217-ca8f-430e-82bc-6b5228e4ffd9", 0, "aec11353-3841-4896-949c-aa110aba344e", "doctor17@clinic.com", true, false, null, "DOCTOR17@CLINIC.COM", "DOCTOR17@CLINIC.COM", "AQAAAAIAAYagAAAAEMFE/gG/RJ9OZ3+5Q5quHyV2ze2ncs0NPOYb/2Xq0mbK5rHw+enYeZwtkrfF6JCVAg==", "01100000017", true, "3c23ee73-1774-46c9-9b65-07724d96d1c4", false, "doctor17@clinic.com" },
                    { "bbc7e4b4-8cd2-4ec9-8fc0-4d171783972d", 0, "642df629-782d-4d10-bd75-4c17638ce02f", "patient12@clinic.com", true, false, null, "PATIENT12@CLINIC.COM", "PATIENT12@CLINIC.COM", "AQAAAAIAAYagAAAAEMNryKYQoQruSOhCe2NLxN4LRGLJ1oIrdVGLHCSds4OFWRS8Deh+S2PCX0aXCCfU9w==", "01000000012", true, "8dbf7d02-c7ac-4b70-8ffe-ad01da587937", false, "patient12@clinic.com" },
                    { "be8a8bb7-c229-467c-988b-5934ceaa1432", 0, "d71e1dac-bd33-4bfa-bff0-7e1a08952f3e", "patient16@clinic.com", true, false, null, "PATIENT16@CLINIC.COM", "PATIENT16@CLINIC.COM", "AQAAAAIAAYagAAAAEM/4lWWJdFlIqeUJl6QlrVaH2/y14NCniHtsd6tETeazregiNOo5mb5Pu11uhpAuSw==", "01000000016", true, "5c9bcad8-32f8-4b8a-ad16-044fbee2ee5d", false, "patient16@clinic.com" },
                    { "c69e9027-ee3b-456c-876f-209a391adafe", 0, "912a717c-43a8-4557-a26b-4a0ba65faff1", "patient11@clinic.com", true, false, null, "PATIENT11@CLINIC.COM", "PATIENT11@CLINIC.COM", "AQAAAAIAAYagAAAAEBLpb4taZdZn9ZFm3saIKmz+ZCRTLRN3nCUqzekZsOj3LKj4197BarbPn8CLjt1lMA==", "01000000011", true, "6a9dbff0-9827-4e3f-9d24-1ee84f302b7d", false, "patient11@clinic.com" },
                    { "cf6e8fc8-6d58-456e-86ca-c61a518f9636", 0, "dc852e70-8b5a-4a5e-a679-d9a07763e86e", "doctor8@clinic.com", true, false, null, "DOCTOR8@CLINIC.COM", "DOCTOR8@CLINIC.COM", "AQAAAAIAAYagAAAAEMhb2CPIJgo064Js71bbIPX94JQgQhoP/L6qYfkXKc+rw3dUyIc0D9dC+ATbWcjEKA==", "01100000008", true, "e748de6b-0578-4a30-8f05-5eef59d41919", false, "doctor8@clinic.com" },
                    { "d13b4c2f-13ca-4f64-8ffc-9be8489b923e", 0, "eb2f029c-21c0-4c2a-aaf3-5c6a7c68d814", "patient6@clinic.com", true, false, null, "PATIENT6@CLINIC.COM", "PATIENT6@CLINIC.COM", "AQAAAAIAAYagAAAAEGw0ssQo5JSBfUHQAGZsrS84gDWzmChNkwM1nJAi2Nayg+69zDfA77NU7LhZmPXnfQ==", "01000000006", true, "db8fd649-a1fb-4e1d-88aa-d4e0491ac0cc", false, "patient6@clinic.com" },
                    { "d3d69fd0-f486-482d-a248-e4ef7ed938da", 0, "2445318b-4708-41fd-81f4-090c45e5a1f0", "patient13@clinic.com", true, false, null, "PATIENT13@CLINIC.COM", "PATIENT13@CLINIC.COM", "AQAAAAIAAYagAAAAELdDR973FmH1+HotEh2BMwR4bnGD1GuI8Uisp/TdkBdengLVL7S4uY3+i/DuO+psgQ==", "01000000013", true, "548605b3-15a7-464a-826c-84d01b627b3d", false, "patient13@clinic.com" },
                    { "d5dd7440-fd7c-4ea2-a6e0-fad0d4ff3556", 0, "388d430a-b862-46c4-9b17-65e306a8ec8e", "doctor19@clinic.com", true, false, null, "DOCTOR19@CLINIC.COM", "DOCTOR19@CLINIC.COM", "AQAAAAIAAYagAAAAEFXgGryryHMhiq51HVDgOHh5nrvi1ZRHiVJerQ2Rk4DqFAWrbhfA1FvztBhU9bDJqg==", "01100000019", true, "1defc95d-6215-42d2-952e-b5d785419da2", false, "doctor19@clinic.com" },
                    { "e1ce6150-1488-404b-9e32-636fbee7f133", 0, "d4a227c7-0d4e-4e62-8a2f-da429a1d41ce", "doctor16@clinic.com", true, false, null, "DOCTOR16@CLINIC.COM", "DOCTOR16@CLINIC.COM", "AQAAAAIAAYagAAAAEMY1IeeYlen7xYpY8m8EySaUyKM81Z4jSnq8eUZ39m7zRZTA2gT6YN8HOux4h+VGXA==", "01100000016", true, "dfb9d567-a281-4d65-af9c-251a9c45c741", false, "doctor16@clinic.com" },
                    { "f8630862-4ec6-4b00-a1ad-10b319de03c1", 0, "488810b8-55fb-486e-ad5d-089f5cb21286", "doctor11@clinic.com", true, false, null, "DOCTOR11@CLINIC.COM", "DOCTOR11@CLINIC.COM", "AQAAAAIAAYagAAAAEPqgdMboJH8OW+0IDSCmS44l9GLjdgiuNgE/Gbht2RMWa/ZGlC1WQUr+iTm9JRwdnA==", "01100000011", true, "6dae7221-4755-4352-8ce7-df8297ea68f4", false, "doctor11@clinic.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "08fa64d7-4992-4b42-bc61-543bae5f14fe" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "0dd15ea2-0b87-4a71-a344-822c4f81c31b" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "155af4cd-9869-4ae2-bf58-5c743184adc9" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "1c163814-12e4-47d8-aa17-68bcbdbf897a" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "1e04d179-7281-4106-8744-88dc51d83d78" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "208a800c-b8bc-4f7c-aa27-b1f5d1f75ce0" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "239278b6-d460-46d5-a67b-65b2ea8bff56" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "27bc3900-c570-42a9-968a-388cc321ce04" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "332f34b3-de2d-4319-882a-d5b5e6257f31" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "37d40e73-452e-4d21-83cd-a233c182a675" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "388a7b3c-6bf5-4bed-a8e2-c94d4748ee73" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "3b98d85c-0738-4834-91d6-ff8243b6bb78" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "3c429440-8760-40f6-9aa6-cfed9f0c197a" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "471ff9a6-382a-42d5-ae41-5350c22d3056" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "4896696a-191d-4bdf-a628-55ec955890c8" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "48b56279-bb35-4703-92a4-4ae6788693e0" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "4bcbf4c1-97c3-4672-9613-73adec3ac42e" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "4e1b7bf2-f505-4c17-944b-4455e450adc2" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "50583878-1af1-4c74-bc91-47bb6eb09889" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "54313667-8d2c-444e-8dc3-291a46c27d0c" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "7ac5d4de-d0fd-4958-bc83-dd478b22e4f5" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "83519268-6998-43f9-b36e-52a61fd2ebea" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "9c825ad4-18e1-4368-8dbc-329f78534d91" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "9e395a1b-9a82-46a2-8b36-7e11ea2afc8f" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "9ea01535-9542-444a-872f-08d09cb4b654" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "9f27b9fb-1ba1-45ee-a85d-c3b190b2fc44" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "a4779ae0-81c9-46b7-b989-709460127449" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "a9d51468-2a82-41cc-9503-2662a256a4b4" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "ad16ed51-e493-49ad-a1ee-4c04707de040" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "b728a214-1340-475f-b13a-c62e618669b2" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "b7c5a217-ca8f-430e-82bc-6b5228e4ffd9" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "bbc7e4b4-8cd2-4ec9-8fc0-4d171783972d" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "be8a8bb7-c229-467c-988b-5934ceaa1432" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "c69e9027-ee3b-456c-876f-209a391adafe" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "cf6e8fc8-6d58-456e-86ca-c61a518f9636" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "d13b4c2f-13ca-4f64-8ffc-9be8489b923e" },
                    { "72235979-4cb2-4bb1-9de9-9e931f98610e", "d3d69fd0-f486-482d-a248-e4ef7ed938da" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "d5dd7440-fd7c-4ea2-a6e0-fad0d4ff3556" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "e1ce6150-1488-404b-9e32-636fbee7f133" },
                    { "2f1a1ad3-aa6b-4e9f-b6dc-9294e071a797", "f8630862-4ec6-4b00-a1ad-10b319de03c1" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "Price", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("0dcb619d-545f-4542-b8ba-244c8dc886e6"), 104.0, "Specialty 4", "388a7b3c-6bf5-4bed-a8e2-c94d4748ee73" },
                    { new Guid("1503e0d0-f89d-4f39-af48-401a94804ed9"), 113.0, "Specialty 13", "9f27b9fb-1ba1-45ee-a85d-c3b190b2fc44" },
                    { new Guid("21068e8e-8129-4cb0-a74e-75bd69d1ef9e"), 103.0, "Specialty 3", "3b98d85c-0738-4834-91d6-ff8243b6bb78" },
                    { new Guid("2acd9da2-9f47-447f-93fc-ed01eac15e76"), 114.0, "Specialty 14", "7ac5d4de-d0fd-4958-bc83-dd478b22e4f5" },
                    { new Guid("5f15c5a4-435c-46a2-b7fe-f68ac615f3d9"), 102.0, "Specialty 2", "4bcbf4c1-97c3-4672-9613-73adec3ac42e" },
                    { new Guid("61d25a72-8d70-4164-a8c6-56eb8d3c502b"), 111.0, "Specialty 11", "f8630862-4ec6-4b00-a1ad-10b319de03c1" },
                    { new Guid("6d14cbd4-a354-4481-b918-706732e1405e"), 116.0, "Specialty 16", "e1ce6150-1488-404b-9e32-636fbee7f133" },
                    { new Guid("71fa449f-b3a8-4058-9783-206211aae399"), 107.0, "Specialty 7", "48b56279-bb35-4703-92a4-4ae6788693e0" },
                    { new Guid("8954939b-d108-4541-ab33-5040dea77a2a"), 106.0, "Specialty 6", "332f34b3-de2d-4319-882a-d5b5e6257f31" },
                    { new Guid("a3f47e3f-eed3-40cf-9255-3aff83c64014"), 120.0, "Specialty 20", "37d40e73-452e-4d21-83cd-a233c182a675" },
                    { new Guid("acd364c0-2600-45f3-9286-8ea9c26d99bf"), 110.0, "Specialty 10", "239278b6-d460-46d5-a67b-65b2ea8bff56" },
                    { new Guid("bcb929a5-f78f-4037-af2a-ab83825819b2"), 109.0, "Specialty 9", "08fa64d7-4992-4b42-bc61-543bae5f14fe" },
                    { new Guid("ce2b3ac0-85f1-4018-8a8e-2546ba347125"), 119.0, "Specialty 19", "d5dd7440-fd7c-4ea2-a6e0-fad0d4ff3556" },
                    { new Guid("ceab535d-051a-4c24-9824-d61940ccd8e2"), 108.0, "Specialty 8", "cf6e8fc8-6d58-456e-86ca-c61a518f9636" },
                    { new Guid("dd2c460f-1676-46cb-a4fa-74968e721cbd"), 115.0, "Specialty 15", "9c825ad4-18e1-4368-8dbc-329f78534d91" },
                    { new Guid("e63f7ca7-ae0b-40ea-a92e-2d5649746b47"), 105.0, "Specialty 5", "9e395a1b-9a82-46a2-8b36-7e11ea2afc8f" },
                    { new Guid("e7f2ae3d-4354-4fc7-86aa-4c023557fef7"), 112.0, "Specialty 12", "208a800c-b8bc-4f7c-aa27-b1f5d1f75ce0" },
                    { new Guid("f17bdbd8-26b4-4e1e-be73-9114360bb881"), 117.0, "Specialty 17", "b7c5a217-ca8f-430e-82bc-6b5228e4ffd9" },
                    { new Guid("f4e7dabf-894c-4971-9363-05416e0027d0"), 101.0, "Specialty 1", "54313667-8d2c-444e-8dc3-291a46c27d0c" },
                    { new Guid("fb64d66d-adc7-45f6-918d-33060785c27d"), 118.0, "Specialty 18", "ad16ed51-e493-49ad-a1ee-4c04707de040" }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "Date", "DoctorId", "PatientId", "State", "Time" },
                values: new object[,]
                {
                    { new Guid("0543724f-5b29-4a27-b7c7-6a6665fc5c2e"), "2025-05-06", new Guid("8954939b-d108-4541-ab33-5040dea77a2a"), "d13b4c2f-13ca-4f64-8ffc-9be8489b923e", "Scheduled", "14:00 AM" },
                    { new Guid("14ccac34-95b0-4263-ad0a-691777ba05fd"), "2025-05-11", new Guid("61d25a72-8d70-4164-a8c6-56eb8d3c502b"), "c69e9027-ee3b-456c-876f-209a391adafe", "Scheduled", "19:00 AM" },
                    { new Guid("28481353-9f09-44c0-aeae-625e4200468f"), "2025-05-20", new Guid("a3f47e3f-eed3-40cf-9255-3aff83c64014"), "3c429440-8760-40f6-9aa6-cfed9f0c197a", "Scheduled", "16:00 AM" },
                    { new Guid("2d8947f4-de8c-48aa-9f46-664c51c82ccc"), "2025-05-14", new Guid("2acd9da2-9f47-447f-93fc-ed01eac15e76"), "27bc3900-c570-42a9-968a-388cc321ce04", "Scheduled", "10:00 AM" },
                    { new Guid("3ba70cd3-fa33-49c8-8d3b-bc3ebb5ab5e6"), "2025-05-10", new Guid("acd364c0-2600-45f3-9286-8ea9c26d99bf"), "4896696a-191d-4bdf-a628-55ec955890c8", "Scheduled", "18:00 AM" },
                    { new Guid("45adfd40-9894-425e-9750-0d04e1fa31cf"), "2025-05-04", new Guid("0dcb619d-545f-4542-b8ba-244c8dc886e6"), "a4779ae0-81c9-46b7-b989-709460127449", "Scheduled", "12:00 AM" },
                    { new Guid("49908c9e-d1c6-4c18-b0f0-40327cf45dca"), "2025-05-01", new Guid("f4e7dabf-894c-4971-9363-05416e0027d0"), "155af4cd-9869-4ae2-bf58-5c743184adc9", "Scheduled", "9:00 AM" },
                    { new Guid("6ae2157d-1e58-4543-a7a6-8bb2cea19f86"), "2025-05-16", new Guid("6d14cbd4-a354-4481-b918-706732e1405e"), "be8a8bb7-c229-467c-988b-5934ceaa1432", "Scheduled", "12:00 AM" },
                    { new Guid("6f0a43d4-4ac9-4dfe-9690-e136dc8a35ac"), "2025-05-18", new Guid("fb64d66d-adc7-45f6-918d-33060785c27d"), "471ff9a6-382a-42d5-ae41-5350c22d3056", "Scheduled", "14:00 AM" },
                    { new Guid("7ca31116-8dae-48d8-b0ea-53deda6916cb"), "2025-05-12", new Guid("e7f2ae3d-4354-4fc7-86aa-4c023557fef7"), "bbc7e4b4-8cd2-4ec9-8fc0-4d171783972d", "Scheduled", "20:00 AM" },
                    { new Guid("7e6f1328-0bb7-4245-866f-9e9bab8801a9"), "2025-05-08", new Guid("ceab535d-051a-4c24-9824-d61940ccd8e2"), "b728a214-1340-475f-b13a-c62e618669b2", "Scheduled", "16:00 AM" },
                    { new Guid("8a907523-ab91-408d-894e-800302e25591"), "2025-05-03", new Guid("21068e8e-8129-4cb0-a74e-75bd69d1ef9e"), "0dd15ea2-0b87-4a71-a344-822c4f81c31b", "Scheduled", "11:00 AM" },
                    { new Guid("9545615a-c638-461a-9680-9883bfb3c59b"), "2025-05-19", new Guid("ce2b3ac0-85f1-4018-8a8e-2546ba347125"), "9ea01535-9542-444a-872f-08d09cb4b654", "Scheduled", "15:00 AM" },
                    { new Guid("b4c4b0e8-3ddb-405c-a2ad-de661735065b"), "2025-05-05", new Guid("e63f7ca7-ae0b-40ea-a92e-2d5649746b47"), "4e1b7bf2-f505-4c17-944b-4455e450adc2", "Scheduled", "13:00 AM" },
                    { new Guid("bd590969-6632-4e59-8bc4-7722f64f7dbd"), "2025-05-15", new Guid("dd2c460f-1676-46cb-a4fa-74968e721cbd"), "50583878-1af1-4c74-bc91-47bb6eb09889", "Scheduled", "11:00 AM" },
                    { new Guid("cec7123b-5f10-4a0b-9444-cc6fac7fff15"), "2025-05-13", new Guid("1503e0d0-f89d-4f39-af48-401a94804ed9"), "d3d69fd0-f486-482d-a248-e4ef7ed938da", "Scheduled", "9:00 AM" },
                    { new Guid("d3a060a8-b02a-4109-9fd0-158025c58cfd"), "2025-05-17", new Guid("f17bdbd8-26b4-4e1e-be73-9114360bb881"), "1e04d179-7281-4106-8744-88dc51d83d78", "Scheduled", "13:00 AM" },
                    { new Guid("d4a65d73-7a7b-467e-b525-03389c3dd8df"), "2025-05-07", new Guid("71fa449f-b3a8-4058-9783-206211aae399"), "1c163814-12e4-47d8-aa17-68bcbdbf897a", "Scheduled", "15:00 AM" },
                    { new Guid("dd4bdfb7-a500-4ce2-8888-b449a268eb29"), "2025-05-02", new Guid("5f15c5a4-435c-46a2-b7fe-f68ac615f3d9"), "83519268-6998-43f9-b36e-52a61fd2ebea", "Scheduled", "10:00 AM" },
                    { new Guid("e768c293-9fc2-436f-896a-2be868e7e35d"), "2025-05-09", new Guid("bcb929a5-f78f-4037-af2a-ab83825819b2"), "a9d51468-2a82-41cc-9503-2662a256a4b4", "Scheduled", "17:00 AM" }
                });

            migrationBuilder.InsertData(
                table: "Prescriptions",
                columns: new[] { "Id", "AppointmentId", "Description", "Modification_date" },
                values: new object[,]
                {
                    { new Guid("0f7e3ffe-d440-4663-8d8b-57cba195d0a2"), new Guid("6f0a43d4-4ac9-4dfe-9690-e136dc8a35ac"), "Prescription for appointment 18", "2025-05-07" },
                    { new Guid("2b2aa4ce-5beb-4856-abb8-e7ff7a0c7ee3"), new Guid("9545615a-c638-461a-9680-9883bfb3c59b"), "Prescription for appointment 19", "2025-05-07" },
                    { new Guid("3204a864-ad87-4227-bab5-3f0dceb08590"), new Guid("dd4bdfb7-a500-4ce2-8888-b449a268eb29"), "Prescription for appointment 2", "2025-05-07" },
                    { new Guid("34e518ca-6b7e-4f73-9248-98fe86c9155b"), new Guid("2d8947f4-de8c-48aa-9f46-664c51c82ccc"), "Prescription for appointment 14", "2025-05-07" },
                    { new Guid("3bcb737a-d69f-4031-a436-ca092842fffd"), new Guid("e768c293-9fc2-436f-896a-2be868e7e35d"), "Prescription for appointment 9", "2025-05-07" },
                    { new Guid("412492d5-4111-4aca-9577-482ed1aa3668"), new Guid("14ccac34-95b0-4263-ad0a-691777ba05fd"), "Prescription for appointment 11", "2025-05-07" },
                    { new Guid("43280530-0277-4eec-86a1-75c64fe14a40"), new Guid("d4a65d73-7a7b-467e-b525-03389c3dd8df"), "Prescription for appointment 7", "2025-05-07" },
                    { new Guid("4ac0affb-7382-4e85-a514-95b7eb465a20"), new Guid("7ca31116-8dae-48d8-b0ea-53deda6916cb"), "Prescription for appointment 12", "2025-05-07" },
                    { new Guid("6dd90d34-9af7-453f-8946-5b4adeb00adc"), new Guid("8a907523-ab91-408d-894e-800302e25591"), "Prescription for appointment 3", "2025-05-07" },
                    { new Guid("7347daab-a080-490d-9723-69de3e11940e"), new Guid("bd590969-6632-4e59-8bc4-7722f64f7dbd"), "Prescription for appointment 15", "2025-05-07" },
                    { new Guid("78d24d40-0fff-46ac-ac22-efa22f9a09e4"), new Guid("7e6f1328-0bb7-4245-866f-9e9bab8801a9"), "Prescription for appointment 8", "2025-05-07" },
                    { new Guid("7fa9927c-96c7-49c6-a0f4-97e671360866"), new Guid("3ba70cd3-fa33-49c8-8d3b-bc3ebb5ab5e6"), "Prescription for appointment 10", "2025-05-07" },
                    { new Guid("96cd8fc6-a897-454c-a6ea-e2e0d842c504"), new Guid("d3a060a8-b02a-4109-9fd0-158025c58cfd"), "Prescription for appointment 17", "2025-05-07" },
                    { new Guid("9fda5945-3c8f-4645-90ef-37f93f692341"), new Guid("28481353-9f09-44c0-aeae-625e4200468f"), "Prescription for appointment 20", "2025-05-07" },
                    { new Guid("a64ae0d5-4806-483f-aa31-4dcf7d7ccc37"), new Guid("0543724f-5b29-4a27-b7c7-6a6665fc5c2e"), "Prescription for appointment 6", "2025-05-07" },
                    { new Guid("daac7753-b2ce-4c46-a2cb-d7a2ef1e1e96"), new Guid("b4c4b0e8-3ddb-405c-a2ad-de661735065b"), "Prescription for appointment 5", "2025-05-07" },
                    { new Guid("deec07b7-a289-4ac4-84fe-72a95ebc1cab"), new Guid("cec7123b-5f10-4a0b-9444-cc6fac7fff15"), "Prescription for appointment 13", "2025-05-07" },
                    { new Guid("e2058588-f4aa-43a3-884b-e9931f60956a"), new Guid("49908c9e-d1c6-4c18-b0f0-40327cf45dca"), "Prescription for appointment 1", "2025-05-07" },
                    { new Guid("f11fed2b-5506-4c03-be75-3ff4152d3c89"), new Guid("6ae2157d-1e58-4543-a7a6-8bb2cea19f86"), "Prescription for appointment 16", "2025-05-07" },
                    { new Guid("ffda7880-b053-4324-ba47-1021f3c2a203"), new Guid("45adfd40-9894-425e-9750-0d04e1fa31cf"), "Prescription for appointment 4", "2025-05-07" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FileImages_DoctorId",
                table: "FileImages",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_FileImages_PrescriptionId",
                table: "FileImages",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_Prescriptions_AppointmentId",
                table: "Prescriptions",
                column: "AppointmentId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FileImages");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Prescriptions");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
