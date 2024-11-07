using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class MenagerAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("56b32c95-a076-43e0-a2f9-6a6cbbcb720a"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("c8724be4-1fef-4c65-bfef-4c22a0396d36"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("c892c0aa-a489-48dd-8b8e-233b7e271feb"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("e5c503eb-54a5-4bca-b1b0-a9d4e6a77207"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("054271e0-5814-41cc-aa60-1da02a970405"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("34e66570-6348-4855-9725-ba3281bbfa2d"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("690f963c-5181-451d-8dda-9eb3c1992064"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("7d134953-42f9-4caf-9358-1f9960d8d579"));

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Manager unique identifier"),
                    FullName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Manager Full Name"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Manager phone number")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                },
                comment: "Data for Hospital Manager");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Managers");

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

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "DepartmentId", "EGN", "FirstName", "HasMedicalInsurance", "LastName", "PhoneNumber", "RoomId" },
                values: new object[,]
                {
                    { new Guid("56b32c95-a076-43e0-a2f9-6a6cbbcb720a"), "Sofi, bul.Vitosha 3, et.7, ap.16", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "8302198562", "Vanya", true, "Petrova", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0") },
                    { new Guid("c8724be4-1fef-4c65-bfef-4c22a0396d36"), "Sofi, bul.Vitosha 123, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6102193476", "Lazar", true, "Petrov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c") },
                    { new Guid("c892c0aa-a489-48dd-8b8e-233b7e271feb"), "Sofi, ul.Rezovo 13, et.2, ap.6", new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "4810234567", "Ivan", true, "Ivanov", "No phone", new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac") },
                    { new Guid("e5c503eb-54a5-4bca-b1b0-a9d4e6a77207"), "Sofi, ul.Belomorska, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6212094475", "Petar", true, "Stefanov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c") }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("054271e0-5814-41cc-aa60-1da02a970405"), "Chiropractic Adjustment", 120.0m },
                    { new Guid("34e66570-6348-4855-9725-ba3281bbfa2d"), "Massage Therapy", 80.0m },
                    { new Guid("690f963c-5181-451d-8dda-9eb3c1992064"), "Manual therapy", 170.0m },
                    { new Guid("7d134953-42f9-4caf-9358-1f9960d8d579"), "Physical Therapy", 100.0m }
                });
        }
    }
}
