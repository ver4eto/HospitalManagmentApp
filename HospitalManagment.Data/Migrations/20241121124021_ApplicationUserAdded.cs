using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationUserAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("01d74edf-8699-4451-a722-9ea391ca81a1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("1b61ac97-b140-4954-a95c-d2654ed521c2"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("3787c00e-f0a7-416b-80b3-30e9a643a8d5"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("98ccf7d7-921c-49ee-805a-1971d84118ea"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("f51b9a71-7c01-4375-b001-0cb536427644"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("2047c7a4-e166-4102-bd03-78948fbc8801"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("78285f42-81a1-4ec4-809c-436ff6226043"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("8f749f14-9e5b-4600-b6e8-a8192f8a0813"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("d7c3636d-72bb-4697-87d2-0485fed2efba"));

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Patients",
                type: "nvarchar(450)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Nurses",
                type: "nvarchar(450)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Managers",
                type: "nvarchar(450)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Doctors",
                type: "nvarchar(450)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "UserType",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[,]
                {
                    { "brown@abv.bg", 0, "babd184c-9bab-4497-99a3-c3f1aa423a0e", "brown@abv.bg", true, false, null, "BROWN@ABV.BG", "BROWN@ABV.BG", "AQAAAAIAAYagAAAAECnfplmwwIylI4gO7MUueqT0RcFl1tSL+03wILgHE4cLyJXkPXV9Jn3HEaYBvuDq0g==", null, false, "0990fa52-0013-45a9-89bb-d7013db14823", false, "brown@abv.bg", "Nurse" },
                    { "davissophia@abv.bg", 0, "44e71754-a326-44b5-8394-8bd69e7fd9a5", "davissophia@abv.bg", true, false, null, "DAVISSOPHIA@ABV.BG", "DAVISSOPHIA@ABV.BG", "AQAAAAIAAYagAAAAECB6pShd4E/+cl7icdNysI9CIFb7hIRSfd4p1cMVlg1e5zlYQ7zhRM6Ewr6X/sTMYQ==", null, false, "4eba9f3b-ecb8-4ca0-875b-cc57834daed8", false, "davissophia@abv.bg", "Nurse" },
                    { "ivanovivan@abv.bg", 0, "0de1b5a4-84f7-4175-866f-2a00a656a535", "ivanovivan@abv.bg", true, false, null, "IVANOVIVAN@ABV.BG", "IVANOVIVAN@ABV.BG", "AQAAAAIAAYagAAAAECNqnvw+0TjBGrmZb8J/VVcIhQy9pMyTXq2wb5hbFUmZ9RcafWUVRoEcYIvZ92kncA==", null, false, "d237f925-ed2f-4857-99e3-68f4318a4dd8", false, "ivanovivan@abv.bg", "Patient" },
                    { "ivanovst@abv.bg", 0, "93085ab2-a077-4b87-ad77-454961626734", "ivanovst@abv.bg", true, false, null, "IVANOVST@ABV.BG", "IVANOVST@ABV.BG", "AQAAAAIAAYagAAAAEDt4r4G0D+qmBYGtvKGOIb5Scig9gWldTfpWf74tNUfRSGU7WCUcdPUb7kRTeU4h/g==", null, false, "416b8376-2147-44bd-aea6-df5572184ef5", false, "ivanovst@abv.bg", "Manager" },
                    { "jhondoe@abv.bg", 0, "fbf97272-2386-4efd-a028-5ef6c95bf50c", "jhondoe@abv.bg", true, false, null, "JHONDOE@ABV.BG", "JHONDOE@ABV.BG", "AQAAAAIAAYagAAAAEGsgfUpktLj9ubaQjyoKYh9jO2LL5q1iLyNMOx3J7GPlH8c+U9+Gv54ojXyqWBPBvw==", null, false, "4d15ab14-eec0-4204-a2b4-3ed759442981", false, "jhondoe@abv.bg", "Doctor" },
                    { "jhonson@abv.bg", 0, "ffe35a5c-11a2-474a-a58e-5c74404e09cc", "jhonson@abv.bg", true, false, null, "JHONSON@ABV.BG", "JHONSON@ABV.BG", "AQAAAAIAAYagAAAAEGZC6+rA5H1GO3PGpJEwFn1PP/GS9/XrDxlC9jhAHby/8eIm3rtV8nWYkYcWeTujaA==", null, false, "bb115431-3c35-4e43-95f3-d0b7679b8242", false, "jhonson@abv.bg", "Doctor" },
                    { "miller@abv.bg", 0, "1ccdeb78-03bc-48a2-a144-50cef51872f8", "miller@abv.bg", true, false, null, "MILLER@ABV.BG", "MILLER@ABV.BG", "AQAAAAIAAYagAAAAEFBqSrDnC4SvE476yS6JKuLZgKngREbfJxJay5QNJICcArj3Yekd2Af1zFz1h7alsw==", null, false, "38e4e4a8-aa44-45f8-b671-2602552abfdd", false, "miller@abv.bg", "Nurse" },
                    { "petrovai@abv.bg", 0, "15ba88d6-cec5-4d66-953e-ee4b6b04a9da", "petrovai@abv.bg", true, false, null, "PETROVAI@ABV.BG", "PETROVAI@ABV.BG", "AQAAAAIAAYagAAAAEEjkRoHyz+5ol3fS40UJQXfqmx9w6ctNVWx4Y8j7j/VI96YUkNoZHFGb9qK7NheTGA==", null, false, "406c24de-6b71-40bd-98ce-4aa7208ad77a", false, "petrovai@abv.bg", "Doctor" },
                    { "petrovavanya@abv.bg", 0, "781344b0-d0c5-46df-8d0e-4909682bb922", "petrovavanya@abv.bg", true, false, null, "PETROVAVANYA@ABV.BG", "PETROVAVANYA@ABV.BG", "AQAAAAIAAYagAAAAEBVlUnrWHKbcSmwwWvjJMgwqFI0xSJAEqtICR3tsnpEIiYl3XT0sXbjP/GjT3Xxdqg==", null, false, "aaace37b-59f8-48db-8569-b888c702ac77", false, "petrovavanya@abv.bg", "Patient" },
                    { "petrovlazar@abv.bg", 0, "919d8839-43e0-4a37-a95c-05011ae4e015", "petrovlazar@abv.bg", true, false, null, "PETROVLAZAR@ABV.BG", "PETROVLAZAR@ABV.BG", "AQAAAAIAAYagAAAAEBvPHRbGrnmq0choRfLQEZXKTvzTXUxFYwTXjwANexzRQArj7cSBIDulW/76Iax+oQ==", null, false, "9e0816bf-e4f7-4f93-93b9-aeab3c9f8bed", false, "petrovlazar@abv.bg", "Patient" },
                    { "petrovp@abv.bg", 0, "01ae1503-24e3-464f-8eae-8864ca682f49", "petrovp@abv.bg", true, false, null, "PETROVP@ABV.BG", "PETROVP@ABV.BG", "AQAAAAIAAYagAAAAEJT2mW4Uf71/ZUMiW7c2bnFmZhpAMOpbNXqQMyKYYT/M/AtbHZR+ffGwhA+L6wvitA==", null, false, "be3c02c0-5c6b-487e-a304-84d42fdbeb84", false, "petrovp@abv.bg", "Doctor" },
                    { "smith@abv.bg", 0, "f42c14be-afc7-462c-b9a4-ce7e4a68dd0e", "smith@abv.bg", true, false, null, "SMITH@ABV.BG", "SMITH@ABV.BG", "AQAAAAIAAYagAAAAEIIe+0YIPksjtwX2HMgaeQeRMsTK8JalaDU+z808GH/xnbDBQg4qXjraSf6yAHKa9A==", null, false, "bd291cd9-dc39-4e3c-862f-52118535e535", false, "smith@abv.bg", "Doctor" },
                    { "stefanovp@abv.bg", 0, "5596fbd2-10e1-46b7-81a0-eea06588cba4", "stefanovp@abv.bg", true, false, null, "STEFANOVP@ABV.BG", "STEFANOVP@ABV.BG", "AQAAAAIAAYagAAAAEDkfNAuhlO+H19QQVLQHt5o4M/OZ3toJ5R7JDFBAaEIrOl3PZH/SjtzbTUzz7G8thA==", null, false, "13849cdb-6c9d-42d0-989d-6177a7fcdab3", false, "stefanovp@abv.bg", "Patient" },
                    { "taylor@abv.bg", 0, "7c7b9352-411f-40c1-815d-7d877c44bbca", "taylor@abv.bg", true, false, null, "TAYLOR@ABV.BG", "TAYLOR@ABV.BG", "AQAAAAIAAYagAAAAEOkCn+M8vXuwMRu3+AvWxPw6oBH4yBFZi+xNr56LVHb1PrvrmonV8D/eERhyuUFKEg==", null, false, "06a95d79-90c7-42d6-ac16-26f95dff493d", false, "taylor@abv.bg", "Nurse" },
                    { "williams@abv.bg", 0, "dff75c46-e740-417c-a39b-7f25ca28928f", "williams@abv.bg", true, false, null, "WILLIAMS@ABV.BG", "WILLIAMS@ABV.BG", "AQAAAAIAAYagAAAAEKvRjZHWbfFhE47QDDgIpNXlmXaFvDlTjfBVLHHkrPwPs6urEdhENxxZnTmjUmXNvw==", null, false, "9499b8ec-e938-445a-a214-877051e53331", false, "williams@abv.bg", "Nurse" }
                });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0b04322a-bab8-41ca-b791-ec1abdd7e8a0"),
                column: "UserId",
                value: "petrovp@abv.bg");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("18538144-c4ee-4d7d-b4eb-fd9267ca134f"),
                column: "UserId",
                value: "petrovai@abv.bg");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("38a0afd0-c8d6-4674-b24a-db1e6861fcc8"),
                column: "UserId",
                value: "jhondoe@abv.bg");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("78429ef3-6e8f-441a-8224-cf9a41152a2c"),
                column: "UserId",
                value: "smith@abv.bg");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a15998c9-52af-4c6b-a032-b135b879e5a7"),
                column: "UserId",
                value: "jhonson@abv.bg");

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("0f1babbe-d5db-49b9-9624-47b9d69df236"),
                column: "UserId",
                value: "brown@abv.bg");

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("2c5c4962-15bb-4282-bfbf-5a0cd30ba664"),
                column: "UserId",
                value: "williams@abv.bg");

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("3c8870b2-58cf-4341-8ea1-d024520563d0"),
                column: "UserId",
                value: "taylor@abv.bg");

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("af558d53-8adc-45ba-bfdd-1ca9e11e7185"),
                column: "UserId",
                value: "davissophia@abv.bg");

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("c55b3e3f-6604-4bf4-a9c8-014d0c146003"),
                column: "UserId",
                value: "miller@abv.bg");

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("2a1864df-a151-46a8-9158-8b8111b378b8"), false, "Manual therapy", 170.0m },
                    { new Guid("7f30e0e4-a1c1-4e83-89ec-a1115be199be"), false, "Physical Therapy", 100.0m },
                    { new Guid("948e5d2a-95f9-4a10-bf74-eb536be482dc"), false, "Massage Therapy", 80.0m },
                    { new Guid("97610e5c-bb3e-437b-988a-e47a3f4dc208"), false, "Chiropractic Adjustment", 120.0m }
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "EmailAddress", "FullName", "IsDeleted", "PhoneNumber", "UserId" },
                values: new object[] { new Guid("73044b9a-9fda-4e3b-9848-91f542086c17"), "ivanovst@abv.bg", "Stoian Ivanov", false, "+359883456789", "ivanovst@abv.bg" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "DepartmentId", "EGN", "EmailAddress", "FirstName", "HasMedicalInsurance", "IsDeleted", "LastName", "PhoneNumber", "RoomId", "UserId" },
                values: new object[,]
                {
                    { new Guid("497482ef-2b44-48cf-86c4-6602fbde4e87"), "Sofi, ul.Rezovo 13, et.2, ap.6", new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "4810234567", "ivanovivan@abv.bg", "Ivan", true, false, "Ivanov", "No phone", new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac"), "ivanovivan@abv.bg" },
                    { new Guid("6984e6ce-a4bc-4164-bd68-c29c3b685555"), "Sofi, bul.Vitosha 3, et.7, ap.16", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "8302198562", "petrovavanya@abv.bg", "Vanya", true, false, "Petrova", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0"), "petrovavanya@abv.bg" },
                    { new Guid("e0df7feb-41ff-4293-b3c2-7ef9b6ace02e"), "Sofi, ul.Belomorska, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6212094475", "stefanovp@abv.bg", "Petar", true, false, "Stefanov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"), "stefanovp@abv.bg" },
                    { new Guid("f0a97740-9e98-49af-82b8-32ebc80e9aa2"), "Sofi, bul.Vitosha 123, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6102193476", "petrovlazar@abv.bg", "Lazar", true, false, "Petrov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"), "petrovlazar@abv.bg" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Patients_UserId",
                table: "Patients",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_UserId",
                table: "Nurses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_UserId",
                table: "Managers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_AspNetUsers_UserId",
                table: "Doctors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_AspNetUsers_UserId",
                table: "Managers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Nurses_AspNetUsers_UserId",
                table: "Nurses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_AspNetUsers_UserId",
                table: "Patients",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_AspNetUsers_UserId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Managers_AspNetUsers_UserId",
                table: "Managers");

            migrationBuilder.DropForeignKey(
                name: "FK_Nurses_AspNetUsers_UserId",
                table: "Nurses");

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_AspNetUsers_UserId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Patients_UserId",
                table: "Patients");

            migrationBuilder.DropIndex(
                name: "IX_Nurses_UserId",
                table: "Nurses");

            migrationBuilder.DropIndex(
                name: "IX_Managers_UserId",
                table: "Managers");

            migrationBuilder.DropIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "brown@abv.bg");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "davissophia@abv.bg");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "jhondoe@abv.bg");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "jhonson@abv.bg");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "miller@abv.bg");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovai@abv.bg");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovp@abv.bg");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "smith@abv.bg");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "taylor@abv.bg");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "williams@abv.bg");

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("73044b9a-9fda-4e3b-9848-91f542086c17"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("497482ef-2b44-48cf-86c4-6602fbde4e87"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("6984e6ce-a4bc-4164-bd68-c29c3b685555"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("e0df7feb-41ff-4293-b3c2-7ef9b6ace02e"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("f0a97740-9e98-49af-82b8-32ebc80e9aa2"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("2a1864df-a151-46a8-9158-8b8111b378b8"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("7f30e0e4-a1c1-4e83-89ec-a1115be199be"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("948e5d2a-95f9-4a10-bf74-eb536be482dc"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("97610e5c-bb3e-437b-988a-e47a3f4dc208"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ivanovivan@abv.bg");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ivanovst@abv.bg");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovavanya@abv.bg");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovlazar@abv.bg");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "stefanovp@abv.bg");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "EmailAddress", "FullName", "IsDeleted", "PhoneNumber" },
                values: new object[] { new Guid("01d74edf-8699-4451-a722-9ea391ca81a1"), "ivanovst@abv.bg", "Stoian Ivanov", false, "+359883456789" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "DepartmentId", "EGN", "EmailAddress", "FirstName", "HasMedicalInsurance", "IsDeleted", "LastName", "PhoneNumber", "RoomId" },
                values: new object[,]
                {
                    { new Guid("1b61ac97-b140-4954-a95c-d2654ed521c2"), "Sofi, bul.Vitosha 123, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6102193476", "petrovlazar@abv.bg", "Lazar", true, false, "Petrov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c") },
                    { new Guid("3787c00e-f0a7-416b-80b3-30e9a643a8d5"), "Sofi, ul.Belomorska, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6212094475", "stefanovp@abv.bg", "Petar", true, false, "Stefanov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c") },
                    { new Guid("98ccf7d7-921c-49ee-805a-1971d84118ea"), "Sofi, ul.Rezovo 13, et.2, ap.6", new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "4810234567", "ivanovivan@abv.bg", "Ivan", true, false, "Ivanov", "No phone", new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac") },
                    { new Guid("f51b9a71-7c01-4375-b001-0cb536427644"), "Sofi, bul.Vitosha 3, et.7, ap.16", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "8302198562", "petrovavanya@abv.bg", "Vanya", true, false, "Petrova", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0") }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("2047c7a4-e166-4102-bd03-78948fbc8801"), false, "Physical Therapy", 100.0m },
                    { new Guid("78285f42-81a1-4ec4-809c-436ff6226043"), false, "Massage Therapy", 80.0m },
                    { new Guid("8f749f14-9e5b-4600-b6e8-a8192f8a0813"), false, "Chiropractic Adjustment", 120.0m },
                    { new Guid("d7c3636d-72bb-4697-87d2-0485fed2efba"), false, "Manual therapy", 170.0m }
                });
        }
    }
}
