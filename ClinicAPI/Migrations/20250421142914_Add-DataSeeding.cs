using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClinicAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "06ef133d-a03d-4045-9dff-03ba2353c36b", 0, "c1d07609-db92-42e2-b53f-72608f3e6b0c", "doctor4@clinic.com", true, false, null, "DOCTOR4@CLINIC.COM", "DOCTOR4@CLINIC.COM", "AQAAAAIAAYagAAAAEKdtNM+/b4XCdHu8RWoY1WAbnHyohQsfqTihsmfbMwkSXiEOtHQBKpUbY5Lum9Tb5Q==", "01100000004", true, "89825f74-ef07-43d2-938e-0e9ec1b653ee", false, "doctor4@clinic.com" },
                    { "0b1b1a02-ff25-46e8-add7-b55bc94596db", 0, "de088424-62f7-42b6-9719-5d3e35a96f3a", "patient16@clinic.com", true, false, null, "PATIENT16@CLINIC.COM", "PATIENT16@CLINIC.COM", "AQAAAAIAAYagAAAAECEwyPIvdfqHQ6EWxzi0uf4mi+Z1YFAZf/XTToVjffnhNjKKi/+O7/VF4vCHwayniQ==", "01000000016", true, "0ebcffc5-9a3f-4709-ab95-739997005484", false, "patient16@clinic.com" },
                    { "0df249dc-078d-4f0a-9709-d3f628d5fce7", 0, "128c13c5-0c34-4e1c-9420-60297984e720", "patient22@clinic.com", true, false, null, "PATIENT2@CLINIC.COM", "PATIENT2@CLINIC.COM", "AQAAAAIAAYagAAAAEKtvb8JjoKfZAmjg6EYWU+eWrM+1CVlreLBHyXIJW/fOM5Sn0i2XUi+Xe4G9rZvLeg==", "01000000002", true, "22169dbf-42a6-41ae-8712-218d8612381e", false, "patient2@clinic.com" },
                    { "1660ddf2-fc20-40ae-a0e0-a9b3c6ef1489", 0, "c6118e3f-3765-4d07-9dcf-1e5bf937c89c", "doctor15@clinic.com", true, false, null, "DOCTOR15@CLINIC.COM", "DOCTOR15@CLINIC.COM", "AQAAAAIAAYagAAAAEEG90KalWrqOjgNwULu9w6vgFUrqwylxzoGswGGF85muPDXTSi1PjYl/3ikNhBENfQ==", "01100000015", true, "1575e5d6-d9a7-453f-ae39-ca686dfcf357", false, "doctor15@clinic.com" },
                    { "1c63783b-affc-40f1-9d4f-f4d4593ff09d", 0, "f2f8a9b4-858e-4e5d-9bee-dda8f082b60f", "patient11@clinic.com", true, false, null, "PATIENT11@CLINIC.COM", "PATIENT11@CLINIC.COM", "AQAAAAIAAYagAAAAECsLNfA4H0HIgM+Eo7q0ar7gAEYu8TIG/kAZkM+nP9H5X1O0bwxHn2AW6AJaNgmBUQ==", "01000000011", true, "62389492-e0b6-4a77-878e-285d38c8367d", false, "patient11@clinic.com" },
                    { "1d74cdaa-fe65-4358-88c6-cd1d2eeb86b4", 0, "d461a036-2c42-4f87-89f2-8449d64858f1", "doctor10@clinic.com", true, false, null, "DOCTOR10@CLINIC.COM", "DOCTOR10@CLINIC.COM", "AQAAAAIAAYagAAAAEAhMqai3y70YdpwQHSHLvxE77anjuMEEIXeLYPFREo46fj6yNmu5mnzPkWoFhytlcg==", "01100000010", true, "d7b9ff28-907a-40aa-ae9c-eb118b7386e2", false, "doctor10@clinic.com" },
                    { "1db9741a-8ead-4416-8207-d6ed26176eb9", 0, "4a49084e-acf1-47fa-8a59-7bb701979287", "doctor18@clinic.com", true, false, null, "DOCTOR18@CLINIC.COM", "DOCTOR18@CLINIC.COM", "AQAAAAIAAYagAAAAENTQNDISzAXWQotD7xGqZDCzbISVBM0pP9FWsdQ0mO74mSd3CVmMoKdm2gclLTyJtw==", "01100000018", true, "350c4c62-cfe9-4233-8623-0f7b5fb4ecb6", false, "doctor18@clinic.com" },
                    { "1e6e6d31-1208-4254-84a0-666ef240af48", 0, "ff2be00a-72a8-4d88-afce-11925044e513", "doctor9@clinic.com", true, false, null, "DOCTOR9@CLINIC.COM", "DOCTOR9@CLINIC.COM", "AQAAAAIAAYagAAAAEKU9WQ9BRQskCcAe3crQs8apn1ZFBFUbGohRxskCgFpwUtT8cvv3OilJYhvKm2Y18w==", "01100000009", true, "1182da7d-6cf7-4d5f-8e2d-2ae5fbec150d", false, "doctor9@clinic.com" },
                    { "1e7230ac-2344-47e4-b698-ef958bc93868", 0, "51e21788-0268-4151-ad16-7fb5af438899", "doctor14@clinic.com", true, false, null, "DOCTOR14@CLINIC.COM", "DOCTOR14@CLINIC.COM", "AQAAAAIAAYagAAAAELY+KXGKjDwuT+Z4NCVf9GjVTkITuPFaVEqPhD3D9KezIq89y67pSN3uX62fgLI7jw==", "01100000014", true, "d270558c-c041-4797-b703-678edc240f01", false, "doctor14@clinic.com" },
                    { "26f898b8-0deb-4ba9-8058-354a737a4687", 0, "11ce92eb-ab87-46a8-8c01-7a740c52855e", "patient12@clinic.com", true, false, null, "PATIENT12@CLINIC.COM", "PATIENT12@CLINIC.COM", "AQAAAAIAAYagAAAAEIM5UV0a3QBf6zvWzS/0yHAwEX3XLcRv0Y2bkvgZtMxxmACWVJ9Y5fXILnLXkIAhWA==", "01000000012", true, "070da9fb-4d83-4d74-a3f8-751ba83e4bb4", false, "patient12@clinic.com" },
                    { "29cb3ec1-e138-439b-9128-922bf2b3c338", 0, "cc0be3d8-9881-4483-a07d-a969980cb046", "patient4@clinic.com", true, false, null, "PATIENT4@CLINIC.COM", "PATIENT4@CLINIC.COM", "AQAAAAIAAYagAAAAEAYL+J61EsgX903JLM8WXK4bOr7kdsvIXp8IwtyTUjpbQk9wKeuARZ3XFXWPnSeQBg==", "01000000004", true, "6edd982e-f0f7-44fc-b817-61c2332fd40b", false, "patient4@clinic.com" },
                    { "29e30fb1-8998-4b05-adeb-5a75884e2aca", 0, "a589b910-4b17-487b-9014-cb9ead2478b8", "patient23@clinic.com", true, false, null, "PATIENT3@CLINIC.COM", "PATIENT3@CLINIC.COM", "AQAAAAIAAYagAAAAEPFADMai7cqKo9PkgkwUtHzSfXX24RjKSXeptM4lwBI0BJB3EM7kvHU7hLHqFE45Hg==", "01000000003", true, "701117d2-88d6-4ff9-9d92-5c8fd85ebd98", false, "patient3@clinic.com" },
                    { "2db8c815-4497-4a2c-9567-eb555115d05b", 0, "8581b27f-9f84-4bc0-82b3-21cc451399c5", "doctor20@clinic.com", true, false, null, "DOCTOR20@CLINIC.COM", "DOCTOR20@CLINIC.COM", "AQAAAAIAAYagAAAAEIcReBY0oXBfWR32gmKb1X3DGFNTPPdJnp3Ah8k6AAB/hDKv/Iu00H3uGCNcBYMwEQ==", "01100000020", true, "e353fb85-1620-4659-b95b-1f91d2563fdf", false, "doctor20@clinic.com" },
                    { "31a5d5ca-755b-4295-a6b5-1c6e90a4f051", 0, "42eb0ab5-9888-4881-81f4-3838c3878e45", "patient17@clinic.com", true, false, null, "PATIENT17@CLINIC.COM", "PATIENT17@CLINIC.COM", "AQAAAAIAAYagAAAAEOx94haA5UYD2TJ39rDdlwQQVrjXlR0PRr5ZTJab6KGS+Mh+ublbNMyfqZp8LA4xKQ==", "01000000017", true, "608bfba0-afba-484c-9ee7-9b194d126715", false, "patient17@clinic.com" },
                    { "38d495e2-af91-4b97-89e1-60827bb63a24", 0, "5d5aec81-118b-44c5-b9e6-e6710ca73aa3", "doctor12@clinic.com", true, false, null, "DOCTOR12@CLINIC.COM", "DOCTOR12@CLINIC.COM", "AQAAAAIAAYagAAAAEPcLrP7wIk7aKmJ+b/XknrRALoYfU+ZNjk3ulJrTZYWnPFlYkwCi+8d1Q4PXLsDcCg==", "01100000012", true, "b72ce1ce-3dae-49fd-b613-4999682a7f60", false, "doctor12@clinic.com" },
                    { "39f173ee-43e0-4b2d-a5bd-973e513472cc", 0, "76582f60-8c9a-49ad-b223-c8a20080a1db", "doctor11@clinic.com", true, false, null, "DOCTOR11@CLINIC.COM", "DOCTOR11@CLINIC.COM", "AQAAAAIAAYagAAAAEFlt4M++I0HONzK1rCgAkT0xBr/dL8Q239WWhQ24n7/P+T7dEqJUgrCQ3ePx4h7uaw==", "01100000011", true, "ce32660e-74ba-4d57-9d8f-3ecf0f28cc0e", false, "doctor11@clinic.com" },
                    { "4319c960-bf8a-4a56-8591-ac477d434d0e", 0, "8244cafe-fb42-48d7-9b51-1c26f28ec469", "patient14@clinic.com", true, false, null, "PATIENT14@CLINIC.COM", "PATIENT14@CLINIC.COM", "AQAAAAIAAYagAAAAEDYHMtWghu64alx8zUSwCpZof21/GNA+ptJ+4MRxk5anaCys9nWVCBzA0TGQdERsnw==", "01000000014", true, "dcf023b0-b6ca-4863-9858-ae2dc7215499", false, "patient14@clinic.com" },
                    { "507c3fc0-7ba1-45b6-8f4e-70daeee6a87b", 0, "e937187c-a7e3-4aa1-a988-14e9c2d1964e", "patient10@clinic.com", true, false, null, "PATIENT10@CLINIC.COM", "PATIENT10@CLINIC.COM", "AQAAAAIAAYagAAAAEPvINf1CzJW1nLC4tJZG9te7LuqCRW9OrDBb1+Dozp3cNJuwlgkcX6lzVZtTqfhN4g==", "01000000010", true, "1f6cd537-def2-430c-8ec9-cd459cf55788", false, "patient10@clinic.com" },
                    { "52cbe818-dd65-46ce-8764-830a3d9008f6", 0, "4e8d966a-02f0-4978-9f98-2a28848574d9", "patient21@clinic.com", true, false, null, "PATIENT1@CLINIC.COM", "PATIENT1@CLINIC.COM", "AQAAAAIAAYagAAAAEFzta9Vkotow/DhK5F3bab23pPMx0B3yloqUarzheWlSELqD5XZ+TQqyd+fUnKaDFw==", "01000000001", true, "3ffbc2c3-aedb-46eb-b807-18afee10835c", false, "patient1@clinic.com" },
                    { "640ba30c-0831-4e9d-b677-fc4dbd052882", 0, "3e4ffbbc-4db6-41f7-b1de-dbce2cab4a40", "doctor5@clinic.com", true, false, null, "DOCTOR5@CLINIC.COM", "DOCTOR5@CLINIC.COM", "AQAAAAIAAYagAAAAEKw2RV3YRofgdHTzLQshj1UdBOFl+qutPpH+fE+B4+DZMC2eRKV4xJ3tntVHQWa+tg==", "01100000005", true, "89106df2-17bd-4acd-9ffd-fdc1e04df2fb", false, "doctor5@clinic.com" },
                    { "66f7c3ff-cf5d-4022-9d03-4bcefc1e0a25", 0, "33e84adb-3475-4c47-8dc2-068a43c73cc5", "patient20@clinic.com", true, false, null, "PATIENT20@CLINIC.COM", "PATIENT20@CLINIC.COM", "AQAAAAIAAYagAAAAENgbcqQi8NxZmgjrbIvzpnrOJI0J58zDjVd2soxI20Yw2jYZNKZcMagIa+oLXHkHVQ==", "01000000020", true, "536884c9-e0fb-4caf-ac0b-50675eaa7e08", false, "patient20@clinic.com" },
                    { "670ab904-39e1-4d71-b77d-9058c4fb3826", 0, "3fd395c8-6645-49d5-95f2-96860f68f1d6", "doctor8@clinic.com", true, false, null, "DOCTOR8@CLINIC.COM", "DOCTOR8@CLINIC.COM", "AQAAAAIAAYagAAAAEE8XyVOg94FnQISLycw8qfhH7kC+8TPcC6RRJRdMrzQ+aESyan7pq/gjPZ5u04B5nQ==", "01100000008", true, "d1761ecc-a690-4bc6-b24f-05926c774d3c", false, "doctor8@clinic.com" },
                    { "73e422a2-ff2d-40da-ae75-82c96d3d0778", 0, "4d0f517b-bbb7-48b3-8178-968b92f3dcdf", "doctor13@clinic.com", true, false, null, "DOCTOR13@CLINIC.COM", "DOCTOR13@CLINIC.COM", "AQAAAAIAAYagAAAAEOBdqI5cH3FbAEO3eS6+JwyDL0LT0B4PF/873svQIg1/Ft59cmdYcTo4MdyiD9pekA==", "01100000013", true, "e06b5f55-e0cf-4170-8de3-5aa11d151e23", false, "doctor13@clinic.com" },
                    { "82624f06-56f4-49c8-84e4-dc5bb33c5247", 0, "7d41cd5f-aae2-4ba3-b0d1-014713a3f309", "patient9@clinic.com", true, false, null, "PATIENT9@CLINIC.COM", "PATIENT9@CLINIC.COM", "AQAAAAIAAYagAAAAED1Aoh4DoWnt+YAmnJ5T1kfANgK35FWYCVEo44pCevFbxKeC5B5APhuyCi9ArNt9IA==", "01000000009", true, "50ffae3c-cdb6-46e8-9f6f-076fce39d3ce", false, "patient9@clinic.com" },
                    { "88f16ccb-22ec-44f0-9f07-092241c4643c", 0, "e3e04159-007a-415a-bf13-d7fdb6671d66", "doctor7@clinic.com", true, false, null, "DOCTOR7@CLINIC.COM", "DOCTOR7@CLINIC.COM", "AQAAAAIAAYagAAAAEA3tepPwlgP5kCtDrBGQhd5fIm1bawzlDU+EMsg9e73Dh3uERf4kTd+7agAYyTwgEg==", "01100000007", true, "3fe93ff8-631a-4fd5-8633-857e12968ff9", false, "doctor7@clinic.com" },
                    { "93b598d1-17b3-427f-9488-a1e9e998aa6c", 0, "baf573bf-04d5-4007-addc-f2a24a13b257", "doctor6@clinic.com", true, false, null, "DOCTOR6@CLINIC.COM", "DOCTOR6@CLINIC.COM", "AQAAAAIAAYagAAAAEK+/IaVzgAq3IkDLB/6s0+Ks2p+WcS3fXUNR3DiOXzek4K94M2j/J40tAYWKNmggGA==", "01100000006", true, "45fe89cf-a991-488f-ac81-168b9cfcc99b", false, "doctor6@clinic.com" },
                    { "9f1d1b06-f65f-49e9-96e4-4c2b73b83983", 0, "02cb0b7d-b2c1-4285-b8af-b71ab8fd7fa1", "patient5@clinic.com", true, false, null, "PATIENT5@CLINIC.COM", "PATIENT5@CLINIC.COM", "AQAAAAIAAYagAAAAEHrsP2nEb65mWDXjgFtlrku8mGMY7Mjmf4w1vh+PLwApHR4qFz+xdD+ZD9S9CvNlgA==", "01000000005", true, "87589296-abd8-4786-a258-5d764e1d20ba", false, "patient5@clinic.com" },
                    { "a05a6664-68b9-48ff-a760-42b2f5b16e7f", 0, "874e58f7-d9f2-4324-978f-26491611353f", "patient6@clinic.com", true, false, null, "PATIENT6@CLINIC.COM", "PATIENT6@CLINIC.COM", "AQAAAAIAAYagAAAAEMlEebxbXx1FfkV9GdUAohp0/KLOhtt1uNW9idrxHJ+apSG3gMC8NJNcgUJOS7Z0xw==", "01000000006", true, "1ba3727d-7fa3-48c2-927d-09118c46b36a", false, "patient6@clinic.com" },
                    { "a3d69e15-a1a0-40b7-b29d-4c509ef3abb2", 0, "f6f6258f-1c67-41b0-8c92-d4473e52146c", "doctor23@clinic.com", true, false, null, "DOCTOR3@CLINIC.COM", "DOCTOR3@CLINIC.COM", "AQAAAAIAAYagAAAAELJCzyYUTosckjd82FGqXTKcIknOO/DUZoOYxGfoTQSUpV2c8MvJQeUfV4RdwQnPDA==", "01100000003", true, "e55e3846-7890-4a60-a3aa-0631a89b8648", false, "doctor3@clinic.com" },
                    { "ae9e4a55-1221-440a-9e81-26436f64666a", 0, "58c95c23-896d-41c2-b12c-93fdc1e0f1c9", "patient8@clinic.com", true, false, null, "PATIENT8@CLINIC.COM", "PATIENT8@CLINIC.COM", "AQAAAAIAAYagAAAAEDmi/tp6KawMhkSn8X931acEZA2YjSR15vz864RCa3lESdxjg5EQO+xGhMnM5Udr+A==", "01000000008", true, "1214581b-1017-4677-9a6c-996b6ae9cb96", false, "patient8@clinic.com" },
                    { "b2b74884-dc36-40af-a889-de4b0d44030a", 0, "88724701-3765-4751-be4d-17b2e2a299af", "doctor16@clinic.com", true, false, null, "DOCTOR16@CLINIC.COM", "DOCTOR16@CLINIC.COM", "AQAAAAIAAYagAAAAEBjni34urTTGkrFsq17Qmn7pn67rxJ3EfokuzmKVdN5Vy3aG9pY+Z0CGE7wnl3abYA==", "01100000016", true, "c6ea1e5c-dcc0-4b70-bbac-de88575a6465", false, "doctor16@clinic.com" },
                    { "b7041f80-6512-4fa9-b99e-7fa037fe1383", 0, "aac5f08a-5f92-4a29-a227-1256be36ae57", "doctor17@clinic.com", true, false, null, "DOCTOR17@CLINIC.COM", "DOCTOR17@CLINIC.COM", "AQAAAAIAAYagAAAAEOff+t8xRvTbLYwz7WOXEjY51P7nqv6KKaVhO7xqRkdwD4JJrxoP1URcY6n+Z7o88w==", "01100000017", true, "894d24cf-f390-4d4f-a5b1-a0b5345ab57a", false, "doctor17@clinic.com" },
                    { "c7758f2b-c854-4002-b334-1700df4c9a96", 0, "33bc4a99-7543-4cc5-ba1a-1ea9e8494c95", "doctor19@clinic.com", true, false, null, "DOCTOR19@CLINIC.COM", "DOCTOR19@CLINIC.COM", "AQAAAAIAAYagAAAAEIO6kzJ5tVu/yqfsDpCMBwyEudIIrcyj8xiH1HJKljGFQowCSHSZ3TiuCQKFW1xKAw==", "01100000019", true, "f13fb049-1755-4bf7-bab6-aa6bcb3eaa2c", false, "doctor19@clinic.com" },
                    { "ca9d8238-f49e-46e1-a9d7-9f5dc745e22c", 0, "80945fd6-6b0c-4e12-8a5d-2e8af3695f05", "patient15@clinic.com", true, false, null, "PATIENT15@CLINIC.COM", "PATIENT15@CLINIC.COM", "AQAAAAIAAYagAAAAEOeTo0HH2H6K4etZCNfg0NUGGusvemVTLBHxmJNlK7xiaiIKjCrKjJZSTnTe6gnfOQ==", "01000000015", true, "5b4c0b81-1303-4a02-afd1-d14626e50eb7", false, "patient15@clinic.com" },
                    { "cbff071f-b407-4dd2-a5c5-e4381cf5a5b7", 0, "ea9b5b07-a029-489e-bfb7-3e4df326de5b", "patient13@clinic.com", true, false, null, "PATIENT13@CLINIC.COM", "PATIENT13@CLINIC.COM", "AQAAAAIAAYagAAAAEHUx6ZfKzY5mztNjofoKuZPPqi6JuXsY2wF7UO7FM9F65XxhLJLkiaqUO+uENbvl1A==", "01000000013", true, "02cba3b7-4e82-4e13-99b8-5a8de1272601", false, "patient13@clinic.com" },
                    { "d329a52a-f062-483b-8ee0-5ee8bddec3cd", 0, "beb8726b-5362-474b-b201-b295c1dda66f", "doctor22@clinic.com", true, false, null, "DOCTOR2@CLINIC.COM", "DOCTOR2@CLINIC.COM", "AQAAAAIAAYagAAAAEHbW1796BbIVXmI6Kbjue0t5hOQNlE3YFTvlQgt2MYjeBSRSZ2ix33ff3z4xDZ3yMw==", "01100000002", true, "0e5c401e-9a97-4905-adfa-6701a408a6ba", false, "doctor2@clinic.com" },
                    { "e8d1902f-57d2-4718-85c7-1cf5f0a1ca18", 0, "2a85c041-7817-4d44-986f-3aacb8d82e56", "patient18@clinic.com", true, false, null, "PATIENT18@CLINIC.COM", "PATIENT18@CLINIC.COM", "AQAAAAIAAYagAAAAECAmJkUGHUTe2OfzEMjhyj6pnF4Y/257qc1rabcciNXyQ62ZIkIJ0UAwjYKGBVeBaw==", "01000000018", true, "27f56009-2bcc-4fb2-9a70-194a7089df5a", false, "patient18@clinic.com" },
                    { "ee9464c4-72dd-487e-abae-f28eb1f283d6", 0, "5fdf2825-8ca6-4fc7-b290-167338d79a49", "doctor21@clinic.com", true, false, null, "DOCTOR1@CLINIC.COM", "DOCTOR1@CLINIC.COM", "AQAAAAIAAYagAAAAEEH9FIkQSclacw1sRNDPzUqJTTYpfA6Cp8q6OLQG4jcrU0DmPZFZ1IuIIy0CJAo2Dg==", "01100000001", true, "06b3a41a-17d4-4085-8d57-2047412479b9", false, "doctor1@clinic.com" },
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
