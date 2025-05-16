using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AppointmentAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.CheckConstraint("CK_Appointment_StartBeforeEnd", "[Start] < [End]");
                    table.ForeignKey(
                        name: "FK_Appointments_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Appointments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "DoctorId", "End", "PatientId", "Start" },
                values: new object[,]
                {
                    { new Guid("425262b5-2ef6-4de3-a7ab-230252dc1c5c"), new Guid("78429ef3-6e8f-441a-8224-cf9a41152a2c"), new DateTime(2025, 5, 9, 14, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dd5538d3-1f68-412f-9949-94edde16d8a2"), new DateTime(2025, 5, 9, 13, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c0b7041-206d-45e5-b4ab-6ad0eb83baad"), new Guid("a15998c9-52af-4c6b-a032-b135b879e5a7"), new DateTime(2025, 5, 6, 11, 30, 0, 0, DateTimeKind.Unspecified), new Guid("a001bd24-5c2a-4f7a-b000-5f7bd233cd12"), new DateTime(2025, 5, 6, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("50dada77-19e6-4ff1-9b15-8d37a1e677ca"), new Guid("a15998c9-52af-4c6b-a032-b135b879e5a7"), new DateTime(2025, 5, 7, 13, 0, 0, 0, DateTimeKind.Unspecified), new Guid("134d8ce3-4c26-434a-90b4-f59ae5457a01"), new DateTime(2025, 5, 7, 12, 30, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5cef2e11-6c21-4034-a020-6fbae170e056"), new Guid("38a0afd0-c8d6-4674-b24a-db1e6861fcc8"), new DateTime(2025, 5, 5, 11, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17e9933d-2a1b-467b-b6a2-79297246b8b3"), new DateTime(2025, 5, 5, 10, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ea23a1-095e-475f-937e-cb3e34c4def2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2674cdd-b7d0-4772-b218-a943fb6ed76c", "AQAAAAIAAYagAAAAEImiQPRG1cynV1i+NIulP75OqKDNxFg+PdqksJofP2wvYXuXM904NeTDbKzx2yEsVg==", "bd5e130a-b090-4e5a-89f6-52f67385f640" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b02a5c0c-fa7e-4a1a-959d-9b83ff443f0a", "AQAAAAIAAYagAAAAEMGx9V35Rr3rzyPfP65c2jDfmXFk+j4G6eMS/mK4wyw8rkaQ1tGd/ZLrgbaCilAfhA==", "5ee0551a-a942-4d40-94d5-bdfe773a8130" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1babbe-d5db-49b9-9624-47b9d69df236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e149a74e-f51d-4d38-89c3-032f97f91845", "AQAAAAIAAYagAAAAEGvQTQbt4rrTlWNAAbm7uR0FTy1A+Ho3Lhqn94I+Q32pSoNB+3skpvn9So/ztFz2Hg==", "630f1b47-faf4-42b7-88f5-42fdfd98cd45" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134d8ce3-4c26-434a-90b4-f59ae5457a01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "380340d2-1b6a-42f4-ba71-1dc82a02d4ff", "AQAAAAIAAYagAAAAEDsj3XQ8fMxCRG3RIRLeNv5iFD9xJ7S9pMGX4dpNQBL5EsbrcE9uNybl1B6gZWm9sA==", "c5ace37b-dfcc-4366-b04e-100d52e0c5b2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15050ff2-ed6c-475f-8831-f61d54a29175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0504812-5860-4095-8d14-8c6150c6a645", "AQAAAAIAAYagAAAAEMawaBOpzzcf+cM1Xw3aLe4uecsCi6eUZJWkGxfQEyETCIJOdBjNJgz9XqbGhtEntQ==", "095ff018-72e6-495b-9769-79bd363a6cc2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17139a72-76d4-4362-aa27-18a64cc8d285",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "471e5545-50af-463a-ab31-cfd8862dd58f", "AQAAAAIAAYagAAAAELHqSf6Xw+4cGIShLUVExnF9VitAovNuFC88jnQvX+d7KuZTvFDmrvlomw5Id+TY4Q==", "d63b72d8-c749-406f-ac94-6f657c0ac368" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e9933d-2a1b-467b-b6a2-79297246b8b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90d68df2-52c5-4ca7-9c6e-87cd1db36cee", "AQAAAAIAAYagAAAAEGybIa5cbmv6kmfxDH6OcKDoOs//J/d2mh5OBNqp7oCn+8mh76T6tfcw+z+1JpTQVQ==", "77aafeab-cc20-4d72-9dc5-d8ed647ce14f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18538144-c4ee-4d7d-b4eb-fd9267ca134f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7c92eaa-20eb-4710-9d57-2dbd69058ac6", "AQAAAAIAAYagAAAAEFQgkKF8JNvuO4r3j8wZSug25Ng/X08GZEvv3PWSHjPqCDCxe2AC5QWKvTg2CBg2LQ==", "f388f0d4-1cfe-4797-a735-10e8ce25de04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23fbee5b-fbe0-49a4-b312-6a5471f79dca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6da3db10-d748-4b5a-9510-f207804f6f42", "AQAAAAIAAYagAAAAEJ+uGSPRf02DC6rABt6cJIg7WlQAKh7X/K7p0oZOtMdl2aIJHeOMFqFgbNYEHp8VLQ==", "e6fc035e-11c5-425e-99d9-d8e74826d43d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ed71cee-9204-4ff0-85d6-f6617ffe3804", "AQAAAAIAAYagAAAAEG5BNG4wmsE1yg2JXSN8vFZap0/yWvrrUIsv+jAiZK1ApsCxwlO2oZIV2cYTxa5vAw==", "2024341f-f441-42ed-ae69-887a688f2ed5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3110d510-2d4d-4e84-9f69-84794965586d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5a1e111-df6f-42cb-ae89-f8bbace3b608", "AQAAAAIAAYagAAAAEDFhh5MQgkD0yOOzRYIQzkNvvhF7YrrAbxplDQ43o6XgguKLMl2RjZO5SanolmgqwA==", "b9c2d5b2-93ef-4f7a-96d8-2238319d7f16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56c4574f-0ea7-4417-943a-d799b20aa0bc", "AQAAAAIAAYagAAAAEAZBaEcoUBMrLL/Amj1/z/FpSty81BtUXqcSDstdFT6zEu0QsCRfpw1iRVBZFKkCuA==", "5399a182-4880-4f20-a462-6cb9437d2560" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c8870b2-58cf-4341-8ea1-d024520563d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce102d6f-a598-4acc-bc90-9129963307c9", "AQAAAAIAAYagAAAAEJJscged9ziHLGm0L8knp/NRZDYOuy0+HePmgiRAablm+sxYIl3pIR2mepmxouJKEg==", "5e7568ba-7e9a-4a93-8035-4575484c164b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c0a3b2-bf91-4c97-9a31-cb7b454c1415",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "407e8baf-b3f9-4226-af64-66b7fd711a14", "AQAAAAIAAYagAAAAEClHAFL1Jkyb5UngY6woSKdLEpBmWRzs16tcYUQC7lgNoMt+0v15iBMX4JP6yXTrcg==", "7aca8b8f-166c-4e38-b0bf-9af423747319" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57e1941c-1412-4384-b819-d67a19204baf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44b21227-2517-4156-b8e7-06e478366b20", "AQAAAAIAAYagAAAAEAk/I5zXtOx/RIx1icg/IWQ19filb/Yqhz8EP1iqVP6vmeQiBa92ZBbk67Ui0dgGyw==", "34e342c3-22a3-483a-a823-0d45a8c85133" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621fb5c5-b634-405d-951b-3088891c3d5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1394520b-81cd-4e5d-9fc2-ec245ff8ee94", "AQAAAAIAAYagAAAAEHK4ymiceYpoos3lO03Jq37MhgK+V0IRdFocNpjUb2O3DZKyi4nIX3UtKZF9IKPGhg==", "13624a43-864d-44c6-99ea-d984dc8526b5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76222e29-cbf5-4335-b2e4-fa6a77afeab1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a9f4efa-4dd6-4895-9574-8a51d718129f", "AQAAAAIAAYagAAAAELeB9+prG64KR6AS7N68iUsLC0dyJZXcd1VWkJsrhWaG4Bh5hTUHs06nD6lAsev4OQ==", "a2745586-4ef3-4dbe-912e-7f779e7ef307" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78429ef3-6e8f-441a-8224-cf9a41152a2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a517e997-a14d-4c28-b909-dab96b87c2d0", "AQAAAAIAAYagAAAAEKsqhcsdrEf+rU6eO19YH3fYHW53AY2cpUGO3WEn0Kv39hL6EIgjCCPbdHa2jOSJyQ==", "c6607839-1676-4ff4-9a45-95b7b69726ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c032bc0-04e2-4111-bbfb-a59d46791529",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8980e336-e071-40fd-82a5-dd9f44170006", "AQAAAAIAAYagAAAAELrrFWnsae7AMzXo3p8RWKAY0Mt95Re0zcM3hVlY/2h77rT4o/JFjYJL4FosFBgA5A==", "53c56f84-c496-4da9-bfbd-9e8463d54d00" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c99b5d-6573-4514-81eb-183ace313419",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdd9781b-e864-493c-89b2-5b9627bf9958", "AQAAAAIAAYagAAAAEG2NRDcRKJH5mtHaaQpEdpJdkWpDbIOUYfogJean/ZQsf0eeY9PQ+Oe4XpzVwZDn+g==", "2c8ffe9c-2bbb-4cfa-960c-1c45130f547a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a001bd24-5c2a-4f7a-b000-5f7bd233cd12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "685759ad-e7a1-4c9d-a569-303a1c1c4354", "AQAAAAIAAYagAAAAEHSJcKLKsYIeqzoOdtMUue/etGzFKKoM6LI65m6FsRJnzPTW4eZ6+BrJ78on9eesVA==", "8664589d-be34-47c4-9849-683c9d122a76" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15998c9-52af-4c6b-a032-b135b879e5a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3eec22ea-497b-4e05-8352-e6e4bc0ca28d", "AQAAAAIAAYagAAAAECh9vXYXmsC56Og6+6aiqG7a18Zs1gS/sNezhGMRabO2ootGjzsABfPugLXdaSUUrg==", "0aa69e9d-e915-457f-b771-b3177ab67e9d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8d287e8-357a-40f3-893a-ed507ed6a85d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83cb22e3-fa03-4dc9-b47a-46b4d46cd15c", "AQAAAAIAAYagAAAAEFiWZXJM3vTBUucjSEj600oYkAx4cNdeq60qDevZ3jF0p8Fwt/CB91TcS4qaDd4KiA==", "10855e6f-431d-40e4-ad72-6ef3a4776353" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558d53-8adc-45ba-bfdd-1ca9e11e7185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd4745fc-4329-4da4-9bd6-0d879121d62f", "AQAAAAIAAYagAAAAENd50hETuFH9x8VYe8fGRtNLFU5g8bJHyIZVHjZd2yQ0R5g1qS55sbBtRqBXfCWh8A==", "c0337697-e87d-4674-baf1-3e63373ec9fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55b3e3f-6604-4bf4-a9c8-014d0c146003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a841750e-574e-49ef-92ab-f84f4f29c02e", "AQAAAAIAAYagAAAAEJKWOXXtalWXmJXXtjd6O6vy3YJkac115hoJ1swsRWDvJoKX7LDvy6rTyR80wfUqCQ==", "b4f0b2b3-db7b-43de-a571-6f06c198be2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6e29719-7856-4b5f-b5da-84ed3a292877",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa6106d0-2990-4a61-b646-524db2282613", "AQAAAAIAAYagAAAAEKs2h7MetCpD+zZAjnoY+gbjZciaEisHi9PArGNsN0uTfsQp3My1XQ4SB1xW2Jj0mA==", "812e16d2-065f-4962-9800-32b959317662" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8d0d177-60a0-4925-b4ed-bb36aebb48c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fccbb23-8670-45ca-a7fd-e6b17edc4f1f", "AQAAAAIAAYagAAAAEBnhm9Nw7hMYb2JKyRnXtTeLlLciIt4R5v2I6kZjlmaSE4QBgnf+GFtdfhqAWPWakA==", "43a50a9b-12fe-4645-bc73-9fc303b63510" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd5538d3-1f68-412f-9949-94edde16d8a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c36eb146-2af7-488b-a4bd-d600e4cbe6ea", "AQAAAAIAAYagAAAAEEtbJvWrLc821yvt4u4ELFD47l5bvAUPc6BWox12ShDVRVgVuTc7gRwtyVkVmI/XGw==", "0764d4dd-a260-40da-ae4c-940dbe2f8f2b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fddefbf4-e1a5-42a1-a64d-e0843640267c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22e81794-eacc-4021-ab6c-aac6bfea531e", "AQAAAAIAAYagAAAAEPmRcAYhsU9aVbPJ3MaPJ88qDLNseJdyGMj742ABXCXFQAB1uNbkzC9lbQX0TvmVOw==", "9f01c306-7712-49ac-b3a4-e214f56ff79a" });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_DoctorId",
                table: "Appointments",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_PatientId",
                table: "Appointments",
                column: "PatientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ea23a1-095e-475f-937e-cb3e34c4def2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9c8e518-ea3c-4a06-ad67-235a2d4c2c2d", "AQAAAAIAAYagAAAAEL85ZgzZPrDDLeuM8/sI98XtbgsMZDgJQYljPxDauAmtRBZkd8H4cl2eOSXmc87TsQ==", "be8fb048-3b8e-4505-88a8-3d57715c4e3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "073c81bb-0fc2-40cf-821f-b9e23a3a2c4d", "AQAAAAIAAYagAAAAEFoKMGvS63xDQZjQQ946CvIHYv065DUUbwo+sk5Vl+WlCrOKMzLgfnkUQ08g+yG0Ng==", "f1e1fd02-9408-42ba-99a4-8008a63d3616" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1babbe-d5db-49b9-9624-47b9d69df236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e42361d-48bc-42ed-b45b-e400253aafff", "AQAAAAIAAYagAAAAEAN+vWTQ283adQoM1XC9L1+ip8h5UYa0TtbJdNfD/VQKEAAnWQ2o64IzB69CccxOOA==", "75592781-0247-4e96-b251-50340d85e3a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134d8ce3-4c26-434a-90b4-f59ae5457a01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32bdc8fb-a7dd-4218-8d77-2287582ace8d", "AQAAAAIAAYagAAAAECDeot2giZJOJrWhsjueiLquRBOdbvpuOibgMU4rBMYM82lPh2KgRO5UkOE4ZvztwA==", "8f916021-6cf3-41ad-8a20-d8f98d713c84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15050ff2-ed6c-475f-8831-f61d54a29175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3a99881-8e1a-4ac7-8568-d9dbfed8c15b", "AQAAAAIAAYagAAAAEGglNX63aE4hQ/mSm7EYCoHJCBOrHMLhdLmDQEdyb59k813hUZwrWVm/vQjoUZzIlw==", "55b16cc8-daff-4b94-91cc-2bb555d3a783" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17139a72-76d4-4362-aa27-18a64cc8d285",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cb9fa4a-3d16-4b02-9ffe-f884164ba815", "AQAAAAIAAYagAAAAENi4i1eP1c1UmDDOgUODlkdfguxAc5QiyR+CoHIdZwvndi5bSFKJ6FLHvREQMbUmxw==", "1f859e3f-50ff-4b3e-b405-2fc2966bda1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e9933d-2a1b-467b-b6a2-79297246b8b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73bca0b4-e204-4022-9bf1-b020ef56f90c", "AQAAAAIAAYagAAAAEExAEy2faSU87NQ+UvKLMjaqzrxnJS1uXN5X8xVJED40rG1S6Cb1KRZ73ev6Plj/TA==", "ee9ec2a9-d8e9-4a6e-95e1-3922d4fbfbeb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18538144-c4ee-4d7d-b4eb-fd9267ca134f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70fc9769-9cc2-43b9-b8bb-9b7f3183cca2", "AQAAAAIAAYagAAAAEGymEHdATGxTlBz/kxe7utqLM7J+/Vdzq+4ioS/cQpIdACM/1Hdoo20miKxuhNpR0w==", "390993a0-5d73-4b60-b968-802a87c39fe1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23fbee5b-fbe0-49a4-b312-6a5471f79dca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ffd743c-4f9b-44ca-95ce-4b4811433972", "AQAAAAIAAYagAAAAEKRZEMs7TnwJlRzEC2UfWfYgDv8V4vGSHFDHHvwF8sKJXqD4t/vLj7Zkt6RO2od2mg==", "2b6f882a-d068-45d9-8e16-f90c5bdf17db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d6837c3-d43c-440f-9e95-a1b2d17f59db", "AQAAAAIAAYagAAAAENmPt+7oFvvjQrZpbK2/0+FGjuvNAiZ9B3tGkAPADpQoL9OC4szX429K9zAn4CS/JA==", "8c713ce7-88c7-422e-83bf-09b3ac4e2126" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3110d510-2d4d-4e84-9f69-84794965586d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fe0a305-5193-4d31-98ad-33b6a39667ca", "AQAAAAIAAYagAAAAEC+Rd61t2PZfuU5W8mJ7KdCgJdxWj/MTtEzsRmOzTDnCPCoU7hLYqy44d7sT7zvv0g==", "88e07351-cfe7-4be4-9b41-ce71a99096a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21106461-a315-47cb-be5f-be9095f27ea3", "AQAAAAIAAYagAAAAEHzNfEHOaLRpqKAvkzO5HlN1GLwOzfpo1e66rw5WnGXcGJw+IvqJ+G+n8kueVDBlyQ==", "91910509-c460-409f-9b60-c1a246a416b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c8870b2-58cf-4341-8ea1-d024520563d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ecc514c-8843-4df1-a60e-e1c1afef1f6c", "AQAAAAIAAYagAAAAENNh+jbsGfByGroWKAnOITbEypj86uM6fn77Z3auwJLF3jYn5okupGYr0z+2u3eCeQ==", "89d8895e-1526-4812-a5f8-c85edd2e08a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c0a3b2-bf91-4c97-9a31-cb7b454c1415",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65779719-e9ec-4ef9-9724-ab69dba38daf", "AQAAAAIAAYagAAAAEE4ELJVqiH4vqc3GpE1h87wlUvfIUucWYKh4eFrHdUvI9xEgOGGeNrpeO/LT0vaweA==", "c205b9f8-e3da-41f6-9cee-c2ae2cfc2141" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57e1941c-1412-4384-b819-d67a19204baf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "396601e1-4f3e-457c-bb5e-d84823782a19", "AQAAAAIAAYagAAAAEDNiUgw0VRxKuD45MMQpcisKndIhs/NixkkSLZ5g7ECVbH42ACgo2SJwKORmc6GjjQ==", "f1a30c54-35ee-4934-9803-a642643bf1a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621fb5c5-b634-405d-951b-3088891c3d5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fabef8f-2196-40ea-9c3c-4555381e91e2", "AQAAAAIAAYagAAAAEJDKsfzfePby8vukERU6c2B0ZmDTp2Gw6WepvJF8COPgLfM8q+xzYJQGKkdfQiaXKg==", "ae0e4d36-f061-4f9b-9c28-565465bd67e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76222e29-cbf5-4335-b2e4-fa6a77afeab1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5acb41fa-0cfa-4952-a07d-531689279c4e", "AQAAAAIAAYagAAAAEIGhMPphlV0sbadcRZk7qH+8AcvnWttMKWtNpirgKEUnpYUj7aUPEt/RE4HeKpLohw==", "0acc8b2d-6b8d-45a0-9950-60f8009ad8cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78429ef3-6e8f-441a-8224-cf9a41152a2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55004615-a158-49d3-ac94-46ac394be36d", "AQAAAAIAAYagAAAAEJ1d7MySe+U2HUwr2ha6nbiZXxya5stlmUh0zNrzeVTTlzydIoYfivB1EwDrr0zsxw==", "ca865acc-92c2-4fe5-b985-3cea83232040" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c032bc0-04e2-4111-bbfb-a59d46791529",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f0c96c1-6faa-478d-b39c-1560e2130f55", "AQAAAAIAAYagAAAAEFV959RRYhvg7Ll/umRFIYzYS0xAiPTHdspNY+YN0as0qKWWwonivYkIj1bWFM9HvA==", "196f7c47-3ae2-4e87-9239-258e20a213ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c99b5d-6573-4514-81eb-183ace313419",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ee7164d-e6ac-483e-a673-250f9e930e7b", "AQAAAAIAAYagAAAAEHWbnaO4y2/yUAZSiM3dDGGpWwyqz5oR2mJV3IXPW3yE3g7gZ2uLgh+HpV+1uANFwg==", "251122c8-260b-452a-8b82-a40147052bb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a001bd24-5c2a-4f7a-b000-5f7bd233cd12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09364051-8c73-46ef-b52a-0e77b981df2c", "AQAAAAIAAYagAAAAEDC/WcRnu/KMmo10kiR4ry+sFIDXLeiLWe0N0/Z0G9Bm8JYlciOhnQi+NGTtHtJ6zg==", "5abee15e-7a1e-4bfb-bea3-e57c834170ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15998c9-52af-4c6b-a032-b135b879e5a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07095467-217d-43d1-9924-7c4a6c672164", "AQAAAAIAAYagAAAAEJe/GdaPPKmRZ+pKZKEdn7DSBy6YlvqwKlzMdxS7ty0i7r2lnXGsHKTNj4UWRwWgiw==", "2c141b24-2ba8-4604-b25c-5b02480863ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8d287e8-357a-40f3-893a-ed507ed6a85d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41728920-0efb-4be8-b4c6-f6d87a968de0", "AQAAAAIAAYagAAAAEH8eO1d3eeqtYFaPDISnd4qWSGjmSsyTxYrXqvhZepuaVUiYB6D2Qivnrd5ASzfSjw==", "21abaada-4883-426d-85ce-4b5a6301c5f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558d53-8adc-45ba-bfdd-1ca9e11e7185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "331bb38c-3bb9-474f-ae91-9c1d0e4757b2", "AQAAAAIAAYagAAAAEKvRm7XAH4a247PY8mvuBAoK5GoNh5rW8yy+/l3xJimqwSSNurknCvHjp32wPcTH3A==", "cf3a0575-f0f5-4a9d-be10-96ede43f3a0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55b3e3f-6604-4bf4-a9c8-014d0c146003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "700966d2-6b30-4cd1-a580-6eca6586eecc", "AQAAAAIAAYagAAAAEGfOUIkYBN7ALkHlXz+OrhBcmb9aPlITXzyUceCsIN9caJ2uP8oX95MDZvPKhZgVKA==", "770ff2ae-5279-4142-8937-87d6947ab353" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6e29719-7856-4b5f-b5da-84ed3a292877",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b7da226-da41-41f1-81df-3566fa4ebf7e", "AQAAAAIAAYagAAAAEO+NNjzrxdrKBZEcLs7eZcpx02rre/GrUhiwQ1qkPO1PFWRkcFqU+Wb9KgJg2jbtGg==", "cdb33106-4b50-41b9-8a0f-7f38eb5f5cc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8d0d177-60a0-4925-b4ed-bb36aebb48c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7e352d1-a6d5-47cc-af65-dfb617cc4401", "AQAAAAIAAYagAAAAEFL4dY/BouqqUTEmC143ZVrJAGr3Oe9dLKsvF7uK5RRKSdu5rwiLMJ5ysbD9MwI+kQ==", "ee058937-be2a-4815-8028-b67ff6298f35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd5538d3-1f68-412f-9949-94edde16d8a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "358fe4c6-69c7-4e27-919d-113d7cd0fce4", "AQAAAAIAAYagAAAAEGtY6wRQ+KLNv4zrf+TyUD86Um0tPnc/6MBRo4tBzQZxwC/LgUJEDMPa6cNdMe8R+g==", "b32cd278-c032-4153-bf02-98629b1ed2c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fddefbf4-e1a5-42a1-a64d-e0843640267c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0212367d-65e2-4417-850a-cc133e42ffef", "AQAAAAIAAYagAAAAELrzRmQF64jaNeK0YMU6NMVARo45482oKEDKcO+rZ4Se4Wqu0aiPZF1C9WFKZQx62A==", "80d1d420-bbe9-4e4b-bcf1-ff8e1c409849" });
        }
    }
}
