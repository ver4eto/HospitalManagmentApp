using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SoftDeleteAddedToEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Treatments",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Soft delete property");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Rooms",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Soft delete property");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Patients",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Soft delete property");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Nurses",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Soft delete property");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Managers",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Soft delete property");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Doctors",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Soft delete property");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Departments",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Soft delete property");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3a19290a-8b6d-4551-97ae-b87ecf3f2dd2"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0b04322a-bab8-41ca-b791-ec1abdd7e8a0"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("18538144-c4ee-4d7d-b4eb-fd9267ca134f"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("38a0afd0-c8d6-4674-b24a-db1e6861fcc8"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("78429ef3-6e8f-441a-8224-cf9a41152a2c"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a15998c9-52af-4c6b-a032-b135b879e5a7"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "EmailAddress", "FullName", "IsDeleted", "PhoneNumber" },
                values: new object[] { new Guid("01d74edf-8699-4451-a722-9ea391ca81a1"), "ivanovst@abv.bg", "Stoian Ivanov", false, "+359883456789" });

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("0f1babbe-d5db-49b9-9624-47b9d69df236"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("2c5c4962-15bb-4282-bfbf-5a0cd30ba664"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("3c8870b2-58cf-4341-8ea1-d024520563d0"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("af558d53-8adc-45ba-bfdd-1ca9e11e7185"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("c55b3e3f-6604-4bf4-a9c8-014d0c146003"),
                column: "IsDeleted",
                value: false);

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

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("334c034e-51e8-4956-a6a5-f25ce92bf8fa"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("fc4cc53a-2a34-4232-b63a-0724783fdfa3"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: new Guid("ff64e198-4cac-40d9-817c-ca3a62637fed"),
                column: "IsDeleted",
                value: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Treatments");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Patients");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Nurses");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Managers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Doctors");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Departments");

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "EmailAddress", "FullName", "PhoneNumber" },
                values: new object[] { new Guid("f09b5989-44fc-4600-aeab-e82dcaee8f94"), "ivanovst@abv.bg", "Stoian Ivanov", "+359883456789" });

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
    }
}
