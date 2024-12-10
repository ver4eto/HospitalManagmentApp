using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedPatientsTreatments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientsTreatments_Patients_PatientId",
                table: "PatientsTreatments");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ea23a1-095e-475f-937e-cb3e34c4def2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57fdb967-5f02-4250-8e98-5c40dde587c5", "AQAAAAIAAYagAAAAEK9dESxw3Uycwgq+MRQS4va6xgEWQtuaXbqh9sJTz/q8h6gkHCODB2qGkp1z8oh57w==", "f41619f8-3f77-4973-9f4b-825cbe2ab59b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51a11144-05d6-494b-b10c-8c2565de8ff2", "AQAAAAIAAYagAAAAEDXdabJmzGrwdlPITnx1sZ56YTL1gJaLEIA0IVLRj/VpTK5PFt8jA8klUqkBc+29uw==", "cb12515f-15fc-47c8-a2a8-32d43dd3ef34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1babbe-d5db-49b9-9624-47b9d69df236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93f68d79-375f-4f69-b9a8-3af793bf5474", "AQAAAAIAAYagAAAAEEBO73Yk4sjpEDYm6jF8oV1LGBrZ7moPOg5hA6LBLgMk0tsW7fbq5ZZX6o3lhOmGNw==", "3f8196f7-64f9-4c60-bd90-483c1f3bf23f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134d8ce3-4c26-434a-90b4-f59ae5457a01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a768b856-1348-43ae-92e8-19f5a1f4c6ec", "AQAAAAIAAYagAAAAEI/ctUMsAoJTFDxXxzwOnLaDqXcSXfKV2aBKuS+ZitUZpdSrfF1m96SSbrJT+DwIPg==", "6be6a7a0-b5a5-49fd-9f11-d18e579ae1c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15050ff2-ed6c-475f-8831-f61d54a29175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccc930a9-019f-417e-9c5e-5d71583a52b4", "AQAAAAIAAYagAAAAEA50UEPMrmCFSYpL67tqu0ts2XrK9QVB+l3tDBYDqkduQa+IqzSRaRLskYRZXk+1GQ==", "3aa5e4cd-6b69-4e7f-9410-58819fcbb8b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17139a72-76d4-4362-aa27-18a64cc8d285",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ef0ba64-d333-411e-bd6c-8f900e852fa0", "AQAAAAIAAYagAAAAEEHgH2i/eWklNrGtbw3QsDssngMbBpo0KMrkoeC7jzSpnVM0tbzgDTZQlrQEf5V62Q==", "b31b4102-9c96-4335-a2a9-d5486fd56428" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e9933d-2a1b-467b-b6a2-79297246b8b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dad9593f-8589-4fe0-80d6-bf9f0d5f43a1", "AQAAAAIAAYagAAAAECi0gAog8U1BFqiEPbefLXcrtAKs+DUIKKN9F0Op8cQ01OZLdnsLjQK7f1NpGcDdDw==", "3ea88a67-5dfe-47e3-b9a2-0b2c8ba5fa34" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18538144-c4ee-4d7d-b4eb-fd9267ca134f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad93b740-f6f7-444f-bd32-eb017871bffb", "AQAAAAIAAYagAAAAED88AgAhTXiwvRrZMAaB8YBTCf/DMqp2W0gwBYVxqpAdJoCddK3D4Pkal9HiMifc0w==", "64d1ba1f-74ef-4d5c-aa88-007461161887" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23fbee5b-fbe0-49a4-b312-6a5471f79dca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a535f3dc-8eb9-49b2-ba58-56b716c061cc", "AQAAAAIAAYagAAAAEALDMZwPXdtzAw94AaRmzXGExA6grHnlXwL2dbI8Qq3YApmhySBsBqh0zzlFQ7+Mmw==", "e0e807ca-3d7c-4ac6-beaf-5905c6a0830f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a8ff809-eb3d-4ca4-a9d9-f6c69345b315", "AQAAAAIAAYagAAAAEDsTq8jkuzsiVyfCIw8/IL6Nb1n7BOvGZOJ6skULp4Ny1rCotYrf07Uw2VK3A0l7ww==", "4a1588dd-bba2-42db-8b7b-e67a98416f6e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3110d510-2d4d-4e84-9f69-84794965586d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "05153525-7ec2-4117-85da-786b363e8c7b", "AQAAAAIAAYagAAAAEBu/dLPB4xgVcN4Oa/IQb9oHjl4RB5MbVqFo18u4r4zCFyQUGOtdOth2HtslAKmbFA==", "52438def-acff-44c7-8986-7d4f666429df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "598ec93e-0bbb-4548-abb2-c42d73b26b7c", "AQAAAAIAAYagAAAAEAQM/WwVZyxZu/B4n+NWrcGa4DHl+ESfO1rkXciGIDQ0w2p1kJ65vMQ1UhCpCCpeMA==", "7306cfbd-f863-4490-9da5-3d2213aad5e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c8870b2-58cf-4341-8ea1-d024520563d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3940072c-202f-4dda-86c2-e903220da038", "AQAAAAIAAYagAAAAECT3qhPveM0l6ygc/jBTyUmnKnjCm/nE2IZAdLkWdXLBmILP+VkBRd59SP5qatVEgg==", "457035ce-8d08-498f-91fd-cd9e024310c4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c0a3b2-bf91-4c97-9a31-cb7b454c1415",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c8e79d5-a752-4e1c-9497-a55fca5d342d", "AQAAAAIAAYagAAAAEBBSdSH8ESePpauB0DxrORzldN5+b42rc2+7Mw2wsahARFLGHEMBuRJpNHtk/87aWA==", "51c86916-6ec5-4f32-9fd5-c94c72fb0984" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57e1941c-1412-4384-b819-d67a19204baf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9aa560d6-cc3b-44b8-b7ab-2f1daa848a21", "AQAAAAIAAYagAAAAEBeQINrOjiPw19W17MvVN7rSu3ibmyzpRLjwdxMeha/gakLWV6leEIurN22A8GFTIw==", "f82b3c4f-9b67-456e-80b7-629b15a41da2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621fb5c5-b634-405d-951b-3088891c3d5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3817887f-ee14-46a7-a46f-35295d8e9744", "AQAAAAIAAYagAAAAEC4m4utqPhL+eG2khEsx3xxS4iVbOGhvlI7CaLTX5gH+KggvaQShWyF1ZBrDt8fT0A==", "e349a303-c54c-4a0d-bbed-fbb6d6fb3344" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76222e29-cbf5-4335-b2e4-fa6a77afeab1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33b74f88-bc82-4425-83db-97895223f3a2", "AQAAAAIAAYagAAAAEMOSSpuPicppP3N1RYSal+3eWcOU9k2vQGILKonMhx2QnAcuruvvheFl+MxZYgfhCQ==", "b9c9fb8f-9984-4ed8-9bb5-a25e75ebf53c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78429ef3-6e8f-441a-8224-cf9a41152a2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "441a543c-db63-47ba-931a-c32faefc645e", "AQAAAAIAAYagAAAAELa62FcdtZc0WJj9H3lE0o1bSt4a0NFq8MTyFLcGJ3BFRRiwpGaQ4EgYuT8gdaRmaw==", "4e759640-bd5a-42e7-9edd-d686c012d3ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c032bc0-04e2-4111-bbfb-a59d46791529",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38cc9539-147a-4c8b-8794-c7944f7c1534", "AQAAAAIAAYagAAAAEBKH9FyB0ZcDp2WB9mJwbGm09vVHNNEJULFkhhY4R7v+/kPYNv67VVvd/byClg//MA==", "fdc42a16-93d4-44d8-bd4a-15b90344949e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c99b5d-6573-4514-81eb-183ace313419",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f3d82d3-c669-47db-95c1-944ee781b655", "AQAAAAIAAYagAAAAEKxQHl774hHHbNsE8N7vW0QzDU5mdMrrXwxPosHV9ZuiLyosUWptestQPSxrwv/6+g==", "6eff4d26-c0e0-4328-ac02-9fa66e17a351" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a001bd24-5c2a-4f7a-b000-5f7bd233cd12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6c20bd0-2eff-4bea-9b11-d3f4484d15b7", "AQAAAAIAAYagAAAAENGmQi3+Pme9hIKPKrN/PNsiN4EZkaDh3LUIRB7yA7TXL9pqdHr9r0LQ4zZUxHkn6g==", "092d27d0-84e9-4a02-a45a-c70877a24db7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15998c9-52af-4c6b-a032-b135b879e5a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a0b581f-1513-4193-be4f-0e8e8c8d5dd0", "AQAAAAIAAYagAAAAEF7a/L9DpWI4eUzZHTUASkmJt6utSZ/OReKKb2WjpR7UrISO17e+MfBPFx+Ovs7ShQ==", "ff60e195-23fd-484f-afd1-9751e553fcfc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8d287e8-357a-40f3-893a-ed507ed6a85d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "177626d2-7a1e-45de-a1bf-96759d948fcc", "AQAAAAIAAYagAAAAEIWqeea2a5E+gsfdIPzsEgM0OckeKsa5TSHtKn2IM73b/1+dc02ene/vl4ePaxjWCg==", "957f6f7c-eff4-4958-97d1-8eff6fd5dc77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558d53-8adc-45ba-bfdd-1ca9e11e7185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcdf868b-09e5-444b-a6b2-bd6fe69823f4", "AQAAAAIAAYagAAAAEKYqkhrRNaz8VQks5QrqyUIBTZU6e3lor9mTOh0LpQ80jp5fgDsKtfwwxBetX19GcQ==", "c54b0951-3c0b-4bb1-9f67-041c20a17fab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55b3e3f-6604-4bf4-a9c8-014d0c146003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74576824-18b5-431b-a62c-b9caaa780c03", "AQAAAAIAAYagAAAAEIhMyjhxobbxtrGDQBH8jfzEKXULvQ4qQPb1sXiumGbR3HxdkQxMdlchcN+dVVzkrA==", "f58ae8d2-3f8c-49a7-a6c8-742c9be3d636" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6e29719-7856-4b5f-b5da-84ed3a292877",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9a5dd65-cab5-4243-be83-31816b38e5ee", "AQAAAAIAAYagAAAAEEk6K1a5WonO/KwZy8Ip1gYx5bNXxhC2kevLRgeFJsZL8EDuCemGa/9E147IaB2+9g==", "69ba8217-aaaa-4b85-a45b-aec9cc474cff" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8d0d177-60a0-4925-b4ed-bb36aebb48c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4fd50af-ba73-48b2-a143-2de33f9d63c2", "AQAAAAIAAYagAAAAEHds2yvXP2Wb2Z9PvTuphQUPYFKFkfUSq5cMhvc2R1GQFjI/ulGpPkxNjSmJyTZe+w==", "fb6cae5b-980e-4566-bb3f-b39892747943" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd5538d3-1f68-412f-9949-94edde16d8a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de3eee63-9d8d-4292-975c-d9a8cef78e43", "AQAAAAIAAYagAAAAEAMzHMPHMYkWXfcCYZ6irE9RG23/e2KYxoIKXCfAB2aIMjFO/c2l4epVW63ceiX5Bg==", "ec44d621-04aa-49d9-a7c8-e2b246ca1873" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fddefbf4-e1a5-42a1-a64d-e0843640267c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9138787-c4f9-4ee9-a4b1-ef394cd695a6", "AQAAAAIAAYagAAAAEJXcq5Kq12DsX7Ie2eylM7SCu2NjNAIbwe3BLYVudvhTNnKudltZixQEGBOHeZCJ8g==", "84864199-f2fa-4934-a7c9-a66e949cf286" });

            migrationBuilder.InsertData(
                table: "PatientsTreatments",
                columns: new[] { "PatientId", "TreatmentId" },
                values: new object[,]
                {
                    { new Guid("17e9933d-2a1b-467b-b6a2-79297246b8b3"), new Guid("2a24b3e3-93db-487d-8074-3e5a51217d8c") },
                    { new Guid("17e9933d-2a1b-467b-b6a2-79297246b8b3"), new Guid("64e59e91-8492-41a1-a6b5-2e98f6b5f667") },
                    { new Guid("57c0a3b2-bf91-4c97-9a31-cb7b454c1415"), new Guid("1e472cfa-5488-49f7-bc90-87bcd37b85c0") },
                    { new Guid("57c0a3b2-bf91-4c97-9a31-cb7b454c1415"), new Guid("273f30d9-6c5f-49fa-84a7-734dbdc4a1d2") },
                    { new Guid("57c0a3b2-bf91-4c97-9a31-cb7b454c1415"), new Guid("bb26ac70-f9dc-426f-9c36-d6105537e909") },
                    { new Guid("621fb5c5-b634-405d-951b-3088891c3d5c"), new Guid("1e472cfa-5488-49f7-bc90-87bcd37b85c0") },
                    { new Guid("621fb5c5-b634-405d-951b-3088891c3d5c"), new Guid("2a24b3e3-93db-487d-8074-3e5a51217d8c") },
                    { new Guid("621fb5c5-b634-405d-951b-3088891c3d5c"), new Guid("64e59e91-8492-41a1-a6b5-2e98f6b5f667") },
                    { new Guid("76222e29-cbf5-4335-b2e4-fa6a77afeab1"), new Guid("1e472cfa-5488-49f7-bc90-87bcd37b85c0") },
                    { new Guid("76222e29-cbf5-4335-b2e4-fa6a77afeab1"), new Guid("273f30d9-6c5f-49fa-84a7-734dbdc4a1d2") },
                    { new Guid("dd5538d3-1f68-412f-9949-94edde16d8a2"), new Guid("2a24b3e3-93db-487d-8074-3e5a51217d8c") },
                    { new Guid("dd5538d3-1f68-412f-9949-94edde16d8a2"), new Guid("39bf20f4-81c8-4cd6-9262-61184c8d6b9a") },
                    { new Guid("dd5538d3-1f68-412f-9949-94edde16d8a2"), new Guid("bb26ac70-f9dc-426f-9c36-d6105537e909") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PatientsTreatments_Patients_PatientId",
                table: "PatientsTreatments",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientsTreatments_Patients_PatientId",
                table: "PatientsTreatments");

            migrationBuilder.DeleteData(
                table: "PatientsTreatments",
                keyColumns: new[] { "PatientId", "TreatmentId" },
                keyValues: new object[] { new Guid("17e9933d-2a1b-467b-b6a2-79297246b8b3"), new Guid("2a24b3e3-93db-487d-8074-3e5a51217d8c") });

            migrationBuilder.DeleteData(
                table: "PatientsTreatments",
                keyColumns: new[] { "PatientId", "TreatmentId" },
                keyValues: new object[] { new Guid("17e9933d-2a1b-467b-b6a2-79297246b8b3"), new Guid("64e59e91-8492-41a1-a6b5-2e98f6b5f667") });

            migrationBuilder.DeleteData(
                table: "PatientsTreatments",
                keyColumns: new[] { "PatientId", "TreatmentId" },
                keyValues: new object[] { new Guid("57c0a3b2-bf91-4c97-9a31-cb7b454c1415"), new Guid("1e472cfa-5488-49f7-bc90-87bcd37b85c0") });

            migrationBuilder.DeleteData(
                table: "PatientsTreatments",
                keyColumns: new[] { "PatientId", "TreatmentId" },
                keyValues: new object[] { new Guid("57c0a3b2-bf91-4c97-9a31-cb7b454c1415"), new Guid("273f30d9-6c5f-49fa-84a7-734dbdc4a1d2") });

            migrationBuilder.DeleteData(
                table: "PatientsTreatments",
                keyColumns: new[] { "PatientId", "TreatmentId" },
                keyValues: new object[] { new Guid("57c0a3b2-bf91-4c97-9a31-cb7b454c1415"), new Guid("bb26ac70-f9dc-426f-9c36-d6105537e909") });

            migrationBuilder.DeleteData(
                table: "PatientsTreatments",
                keyColumns: new[] { "PatientId", "TreatmentId" },
                keyValues: new object[] { new Guid("621fb5c5-b634-405d-951b-3088891c3d5c"), new Guid("1e472cfa-5488-49f7-bc90-87bcd37b85c0") });

            migrationBuilder.DeleteData(
                table: "PatientsTreatments",
                keyColumns: new[] { "PatientId", "TreatmentId" },
                keyValues: new object[] { new Guid("621fb5c5-b634-405d-951b-3088891c3d5c"), new Guid("2a24b3e3-93db-487d-8074-3e5a51217d8c") });

            migrationBuilder.DeleteData(
                table: "PatientsTreatments",
                keyColumns: new[] { "PatientId", "TreatmentId" },
                keyValues: new object[] { new Guid("621fb5c5-b634-405d-951b-3088891c3d5c"), new Guid("64e59e91-8492-41a1-a6b5-2e98f6b5f667") });

            migrationBuilder.DeleteData(
                table: "PatientsTreatments",
                keyColumns: new[] { "PatientId", "TreatmentId" },
                keyValues: new object[] { new Guid("76222e29-cbf5-4335-b2e4-fa6a77afeab1"), new Guid("1e472cfa-5488-49f7-bc90-87bcd37b85c0") });

            migrationBuilder.DeleteData(
                table: "PatientsTreatments",
                keyColumns: new[] { "PatientId", "TreatmentId" },
                keyValues: new object[] { new Guid("76222e29-cbf5-4335-b2e4-fa6a77afeab1"), new Guid("273f30d9-6c5f-49fa-84a7-734dbdc4a1d2") });

            migrationBuilder.DeleteData(
                table: "PatientsTreatments",
                keyColumns: new[] { "PatientId", "TreatmentId" },
                keyValues: new object[] { new Guid("dd5538d3-1f68-412f-9949-94edde16d8a2"), new Guid("2a24b3e3-93db-487d-8074-3e5a51217d8c") });

            migrationBuilder.DeleteData(
                table: "PatientsTreatments",
                keyColumns: new[] { "PatientId", "TreatmentId" },
                keyValues: new object[] { new Guid("dd5538d3-1f68-412f-9949-94edde16d8a2"), new Guid("39bf20f4-81c8-4cd6-9262-61184c8d6b9a") });

            migrationBuilder.DeleteData(
                table: "PatientsTreatments",
                keyColumns: new[] { "PatientId", "TreatmentId" },
                keyValues: new object[] { new Guid("dd5538d3-1f68-412f-9949-94edde16d8a2"), new Guid("bb26ac70-f9dc-426f-9c36-d6105537e909") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ea23a1-095e-475f-937e-cb3e34c4def2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81c0746e-42b4-4353-9716-681e896282f6", "AQAAAAIAAYagAAAAEPB2c/+ntqXnNgonnsZJiGpCckm1P/mz93OMdN9D70eJw4XvTPlFl0xXS+JMeJT7iw==", "c1971d6d-616d-4dce-b417-5c2de7244de8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72086fe5-a574-41cf-886c-b7112b4bba60", "AQAAAAIAAYagAAAAECP8PSRAE8PDuhK6qagWXxDnmVUV3aSPv2aCYAy4Cfz57qHVTE2y4tj699P1vIPdEw==", "dd0d153c-ba7d-4237-902d-aed70803e838" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1babbe-d5db-49b9-9624-47b9d69df236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db28104a-d4cd-4e8b-a1c5-a6e24363b309", "AQAAAAIAAYagAAAAEFOEmHRnva5PxemIjpyhHvL7fZLK4YRrfq44aIyyXfZ1Rz7rm72ozXjp2MBiRQcxNw==", "fb6b3d6a-2b01-482c-935a-d72b3ca45b54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134d8ce3-4c26-434a-90b4-f59ae5457a01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f2f76e0-032b-4d0f-a5da-7da0ff63fc76", "AQAAAAIAAYagAAAAEAnmYn6YoNgCeUG/tMvQDh5HldgYFLyjKOv5HrBJXEmIcFngFfuILI0/fvMrzeKffQ==", "f4ad06b0-fc88-4e85-94dc-713cb644878f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15050ff2-ed6c-475f-8831-f61d54a29175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d35c0532-439f-4506-86a0-768287e343e5", "AQAAAAIAAYagAAAAEIxbTd2b62M629qsptpl+CHWEeOUpeZg1CO3O1S89ruVabeRs5UuASLOCXEuGXyN0g==", "d4562a54-7e70-4f46-8ef1-10d0b4805527" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17139a72-76d4-4362-aa27-18a64cc8d285",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eebe9af-545d-4b34-83ad-548bfaf54754", "AQAAAAIAAYagAAAAEGRbCXlFk+laUF7Ir43as5EnoXCpYUG/C6vgYGIeVwxaHvno+sAvlNDZGrW7/Cq3sQ==", "8af24fec-4749-4736-a5df-ca615f852e91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e9933d-2a1b-467b-b6a2-79297246b8b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3952da39-182e-4afa-babd-7ce6fa17cc7f", "AQAAAAIAAYagAAAAEMN1COU8BNKPMeH6jpBlkML86h5smYoNu9feZvyDviGa5gE5s/cVCP/WK3+05lWbrA==", "c36b7113-eb49-4236-bf95-ce6970455e9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18538144-c4ee-4d7d-b4eb-fd9267ca134f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c0e760d-cbbe-4917-82df-61ae2ceef847", "AQAAAAIAAYagAAAAEHbzCmZUef9qPGiVBGRCQpIGps05fGQ2f+rC4wkzHRCsg5oWZIAARXYikaDQgfvc7A==", "871cfd34-4444-4871-8f5a-927a5116a484" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23fbee5b-fbe0-49a4-b312-6a5471f79dca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ddb9380-8b4f-4195-bc93-8ee193b9dda8", "AQAAAAIAAYagAAAAEEy6ynsi1GFTT4c1V47TEcKM0CBLiGPR9KB7Wl/VGJlnnfQObnN33mW3YWT+O89rWg==", "c26a747d-d045-4704-96da-4d5083303ee6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56474114-d821-4ffe-bf43-88207a8f80c4", "AQAAAAIAAYagAAAAENu2DkGQYjuZEib7QMV7OCbmBz02d9pN1IIUrTtSVtLtnfLOKz8/tYoDV03r0pSMGw==", "69cb39a2-2fdf-4b8c-9edf-e7330b0cb691" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3110d510-2d4d-4e84-9f69-84794965586d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fcc15d5-4276-41da-8ef4-7bf6d83c3a9c", "AQAAAAIAAYagAAAAEDY9WAiDxU0aQ127E6Sv79yO03MCZvJmUjF+RZ9HLUE7SPkJVFFL0QV68ykF+7D/2g==", "bdd72389-ca1d-46de-9096-a6fd1b8436bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5494085a-78ca-417b-8e23-8c84550aa49a", "AQAAAAIAAYagAAAAEO1TClZeQD0gHDsYZrr++QqPCCGTBltGNdjtCslvEYHrgcLRLhhfx928HxX/7yqryA==", "520fd164-3470-47d5-acbd-e6f496d984bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c8870b2-58cf-4341-8ea1-d024520563d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa823dc2-b7be-48a1-8cd8-4afcb36f6bc5", "AQAAAAIAAYagAAAAECo9hMavhDsO7krQsjPmBqhHZebk+FbCecXzNgYOuVK8r6+K8CtDb0xOODxIYASoKA==", "fd99b8f5-f2ec-4519-9637-031b6b1b0100" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c0a3b2-bf91-4c97-9a31-cb7b454c1415",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c65835ae-2f59-4c2e-a692-441dc747f220", "AQAAAAIAAYagAAAAECZhz4s5uwe19xiEWFpZCABta/SKMwJK0nAcB+lNItC4mGVviwiRwMkxPauy05fJ1A==", "21618bf4-fa17-4aa9-9376-e256f89a640e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57e1941c-1412-4384-b819-d67a19204baf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5329b37e-d00f-4528-b4e3-1a3d0cd22fdc", "AQAAAAIAAYagAAAAEIsgzSp4OUr5Ecz9SAgUnZqGHLDp8ILZZpLJzIe4j6Zto+vjflbJputOZgga/bHITQ==", "8720b08d-8265-49c0-8958-3101bfbae187" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621fb5c5-b634-405d-951b-3088891c3d5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6d6faf8-8e71-4ca7-991b-50f154543c76", "AQAAAAIAAYagAAAAEFVouX0CN+qtmp2vNNpuAgIpqoJayIaAaH9DJX/YdFvPnqB2epPLxGwHH8CSaAVY9g==", "15403e6c-7750-4af3-b012-ffa1947f5a02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76222e29-cbf5-4335-b2e4-fa6a77afeab1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87e7e3b6-44b1-48de-a1f8-94058a1e9dbf", "AQAAAAIAAYagAAAAEA8r2hsKj+L+yp8a2oLFtJbt6aJ23YyST9u7lAVA6vab+3aTnEv0V5qGjLfhyWzYpQ==", "e3e747d2-339f-44a3-8247-298d6a0c0fb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78429ef3-6e8f-441a-8224-cf9a41152a2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4522219f-ab06-4c02-bc6f-b37d1443a999", "AQAAAAIAAYagAAAAEBclcI/SU9b9x9OE2Jkcm8U3UsFrNLUKEyc8c6c5tpXSyZWTAhM14nsoA+RQu99cpA==", "deaedc57-ad67-41e0-b80b-a17a0c7aad58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c032bc0-04e2-4111-bbfb-a59d46791529",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dea7b720-a8a8-4961-874a-238f0fa99c3e", "AQAAAAIAAYagAAAAELSG8Gf7YUtJZUsGpdp2dI8WvQQ2kIQd4KhOZDaGePBlYONIO5j1V+leDmOkhQUovw==", "fd4e3b0e-db0b-4c9c-b252-e05096da4664" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c99b5d-6573-4514-81eb-183ace313419",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e84edde4-731f-4beb-91c5-8bbed825c10b", "AQAAAAIAAYagAAAAENSJePHLyVp4hEFu3nTHmZgBpnYWSRjwxEwVLGu+iWtlHrEFE+ZA0McI3jsAc7QV/w==", "71fbe41f-2389-4063-ac94-d5c9c61ac0ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a001bd24-5c2a-4f7a-b000-5f7bd233cd12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a3e638c-a72f-44ec-af6d-1fcd6fe77688", "AQAAAAIAAYagAAAAEJPnKrPbotIeqTqMDj8VLGe/4vR5kVPEAy4RSrQ8UPpOBW74p8voA1mgsfLZXVclrQ==", "ede55410-70fe-46f8-9bb7-d245f599be77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15998c9-52af-4c6b-a032-b135b879e5a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df4491f2-9cfa-41df-b6bd-992f7f68460a", "AQAAAAIAAYagAAAAEMzvcwFt+82L8d9Wk6tTI/qNELvWNwgitDjGetqGqMhqm4NkX7o8/MTBQU6LiUZX3g==", "b5c348e5-ddd8-4386-b3f5-952522773f55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8d287e8-357a-40f3-893a-ed507ed6a85d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f5d5c81-203e-4d75-a266-89fece414f20", "AQAAAAIAAYagAAAAENfjBlwKXnm6w6KQ4HDadS/Yx8ohWtq4SI+I/hgYjMHbWKDAEm9OpLjTQfljaD8wGw==", "e3e0a341-c426-49bf-b046-bd7e88d8edbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558d53-8adc-45ba-bfdd-1ca9e11e7185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f08371a-e2da-4899-973d-62f978b642e2", "AQAAAAIAAYagAAAAEJH6RcKNY/AITAUF7uR6mHOxEWGktubcOoiMBLsV1lhe1rzbD2nJWz0O3AIuLTLW4Q==", "9fb46e7b-32b8-4676-84c8-cac57ea4808d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55b3e3f-6604-4bf4-a9c8-014d0c146003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbf6573f-ae73-4f29-87cf-d4ff5e0d1bd4", "AQAAAAIAAYagAAAAEM/jV8B9fFRK9eyZvGzuvWAs3yZ5Y0KtfZnkFxoDaJCoZ/fQKGGB0AcTHQYgmzW/Ag==", "197d8e84-6cf6-4652-8567-2923bd77a935" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6e29719-7856-4b5f-b5da-84ed3a292877",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbfbf7e1-7df6-4fe6-b0bc-360708436e6c", "AQAAAAIAAYagAAAAEEhvS6qH+t5L7Ayq954RkdTs5A8sl7QUIMHTLNDf674prYw2+EXjyjqUQBgHvHFImw==", "a868be2d-2343-4b25-b14a-015b2fe0b13e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8d0d177-60a0-4925-b4ed-bb36aebb48c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19ff5e5d-42cb-451f-9243-9579e7f127c8", "AQAAAAIAAYagAAAAEAZqxWCfo5Ygi4FvhBYhCmQZHNRiW1CFkKTKElWZOjJY0ZORw0x6NuZQG/ddRgXdpA==", "fcc9ba75-f321-4348-990c-4b3438a3b210" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd5538d3-1f68-412f-9949-94edde16d8a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d21b46e-b86e-438c-b4de-cb7c8d41cb15", "AQAAAAIAAYagAAAAEK8t2fiPxKvXmavXDiiYu36VlIRuXNNT5ewGNxLOlm5g7SihBA4jkmri8dpGY2aLbQ==", "aff753f1-8357-4e36-a448-6c1bb6cee61d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fddefbf4-e1a5-42a1-a64d-e0843640267c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e686c998-392f-434e-bec0-fc7e7d098468", "AQAAAAIAAYagAAAAEGVRoSFMaSKftuiRjdzbgLjmXp+lh9FL7f6c+0SUyO7hHw1Gx40iLcUqPcefyV6Ydw==", "545f759d-0aae-4cd8-bd88-9252da880633" });

            migrationBuilder.AddForeignKey(
                name: "FK_PatientsTreatments_Patients_PatientId",
                table: "PatientsTreatments",
                column: "PatientId",
                principalTable: "Patients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
