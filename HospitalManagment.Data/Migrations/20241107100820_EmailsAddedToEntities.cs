using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class EmailsAddedToEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("780f800a-f64b-4b8d-bb7e-1ca5263f252b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("a918352c-1aec-4f24-b862-44f9a6634302"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("bddfc4b6-786e-431f-be55-0069c97d182a"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("ed677dff-3c61-49e7-8181-c2db15706066"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("ef8b9ea5-83bc-4931-a94a-f0f04af51ab5"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("a53f0866-9dbf-459e-806b-681e03a859f7"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("b3bbf08a-154a-493a-a32f-ecdad601fb46"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("b54f5e41-602f-4344-a46b-d43d21791bab"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("e7945d0a-f7f5-443e-8478-0e258338f4b6"));

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Patients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "The person email address");

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Nurses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "The person email address");

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Managers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "The person email address");

            migrationBuilder.AddColumn<string>(
                name: "EmailAddress",
                table: "Doctors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "The person email address");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0b04322a-bab8-41ca-b791-ec1abdd7e8a0"),
                column: "EmailAddress",
                value: "petrovp@abv.bg");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("18538144-c4ee-4d7d-b4eb-fd9267ca134f"),
                column: "EmailAddress",
                value: "petrovai@abv.bg");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("38a0afd0-c8d6-4674-b24a-db1e6861fcc8"),
                column: "EmailAddress",
                value: "jhondoe@abv.bg");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("78429ef3-6e8f-441a-8224-cf9a41152a2c"),
                column: "EmailAddress",
                value: "smith@abv.bg");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a15998c9-52af-4c6b-a032-b135b879e5a7"),
                column: "EmailAddress",
                value: "jhonson@abv.bg");

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "EmailAddress", "FullName", "PhoneNumber" },
                values: new object[] { new Guid("f09b5989-44fc-4600-aeab-e82dcaee8f94"), "ivanovst@abv.bg", "Stoian Ivanov", "+359883456789" });

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("0f1babbe-d5db-49b9-9624-47b9d69df236"),
                column: "EmailAddress",
                value: "brown@abv.bg");

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("2c5c4962-15bb-4282-bfbf-5a0cd30ba664"),
                column: "EmailAddress",
                value: "williams@abv.bg");

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("3c8870b2-58cf-4341-8ea1-d024520563d0"),
                column: "EmailAddress",
                value: "taylor@abv.bg");

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("af558d53-8adc-45ba-bfdd-1ca9e11e7185"),
                column: "EmailAddress",
                value: "davissophia@abv.bg");

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("c55b3e3f-6604-4bf4-a9c8-014d0c146003"),
                column: "EmailAddress",
                value: "miller@abv.bg");

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "DepartmentId", "EGN", "EmailAddress", "FirstName", "HasMedicalInsurance", "LastName", "PhoneNumber", "RoomId" },
                values: new object[,]
                {
                    { new Guid("95c1f745-3e23-4226-bb03-23fb30680445"), "Sofi, ul.Belomorska, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6212094475", "stefanovp@abv.bg", "Petar", true, "Stefanov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c") },
                    { new Guid("db0f7269-a130-4e5b-a14a-0287395b026b"), "Sofi, bul.Vitosha 3, et.7, ap.16", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "8302198562", "petrovavanya@abv.bg", "Vanya", true, "Petrova", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0") },
                    { new Guid("db98c570-bcc4-4360-9acf-965447dc67b8"), "Sofi, ul.Rezovo 13, et.2, ap.6", new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "4810234567", "ivanovivan@abv.bg", "Ivan", true, "Ivanov", "No phone", new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac") },
                    { new Guid("f03688b2-57dd-41b6-8b7e-a80734d39f33"), "Sofi, bul.Vitosha 123, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6102193476", "petrovlazar@abv.bg", "Lazar", true, "Petrov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c") }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("11f91a3c-ed6b-4c7f-b9fd-4f5ee72bc7e4"), "Physical Therapy", 100.0m },
                    { new Guid("2f43f788-29b3-48e5-9b5b-69db2b601dac"), "Massage Therapy", 80.0m },
                    { new Guid("8c6bcf63-724d-4475-8f50-5a442658f0b7"), "Chiropractic Adjustment", 120.0m },
                    { new Guid("fb156bda-d661-469e-a903-14bcdbe20d14"), "Manual therapy", 170.0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("f09b5989-44fc-4600-aeab-e82dcaee8f94"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("95c1f745-3e23-4226-bb03-23fb30680445"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("db0f7269-a130-4e5b-a14a-0287395b026b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("db98c570-bcc4-4360-9acf-965447dc67b8"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("f03688b2-57dd-41b6-8b7e-a80734d39f33"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("11f91a3c-ed6b-4c7f-b9fd-4f5ee72bc7e4"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("2f43f788-29b3-48e5-9b5b-69db2b601dac"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("8c6bcf63-724d-4475-8f50-5a442658f0b7"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("fb156bda-d661-469e-a903-14bcdbe20d14"));

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "EmailAddress",
                table: "Doctors");

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "FullName", "PhoneNumber" },
                values: new object[] { new Guid("780f800a-f64b-4b8d-bb7e-1ca5263f252b"), "Stoian Ivanov", "+359883456789" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "DepartmentId", "EGN", "FirstName", "HasMedicalInsurance", "LastName", "PhoneNumber", "RoomId" },
                values: new object[,]
                {
                    { new Guid("a918352c-1aec-4f24-b862-44f9a6634302"), "Sofi, bul.Vitosha 123, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6102193476", "Lazar", true, "Petrov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c") },
                    { new Guid("bddfc4b6-786e-431f-be55-0069c97d182a"), "Sofi, ul.Rezovo 13, et.2, ap.6", new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "4810234567", "Ivan", true, "Ivanov", "No phone", new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac") },
                    { new Guid("ed677dff-3c61-49e7-8181-c2db15706066"), "Sofi, bul.Vitosha 3, et.7, ap.16", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "8302198562", "Vanya", true, "Petrova", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0") },
                    { new Guid("ef8b9ea5-83bc-4931-a94a-f0f04af51ab5"), "Sofi, ul.Belomorska, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6212094475", "Petar", true, "Stefanov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c") }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("a53f0866-9dbf-459e-806b-681e03a859f7"), "Manual therapy", 170.0m },
                    { new Guid("b3bbf08a-154a-493a-a32f-ecdad601fb46"), "Chiropractic Adjustment", 120.0m },
                    { new Guid("b54f5e41-602f-4344-a46b-d43d21791bab"), "Physical Therapy", 100.0m },
                    { new Guid("e7945d0a-f7f5-443e-8478-0e258338f4b6"), "Massage Therapy", 80.0m }
                });
        }
    }
}
