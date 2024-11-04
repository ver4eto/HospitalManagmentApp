using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class changedRoomAndPatientAndDepConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Departments_DepartmnetId",
                table: "Rooms");

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("17cb1541-eb44-4779-8c98-60cc6b6ffb40"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("36425763-e699-46b9-8eea-356c2744f521"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("642ff24d-5a2b-4fea-8be2-61882a1dda7e"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("edeb559d-8ab1-440d-842c-ef6616fbeafa"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("15029a07-3502-4798-a28d-13fc993a585c"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("c5c5e258-842b-4276-84b5-8f040b599f16"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("e6346e0c-021b-46da-adaf-7c0b7563fac8"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("eec8035b-d157-427c-aaaa-10a35beb6e97"));

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "DepartmentId", "EGN", "FirstName", "HasMedicalInsurance", "LastName", "PhoneNumber", "RoomId" },
                values: new object[,]
                {
                    { new Guid("5c1e1f09-cd12-443b-8f2c-dc5b0bd775ef"), "Sofi, ul.Rezovo 13, et.2, ap.6", new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "4810234567", "Ivan", true, "Ivanov", "No phone", new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac") },
                    { new Guid("9be05fc7-e16a-47f9-b7e4-b2e86f263f80"), "Sofi, bul.Vitosha 123, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6102193476", "Lazar", true, "Petrov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c") },
                    { new Guid("f1da1441-c2e4-481b-b039-8d97b3acf5d4"), "Sofi, ul.Belomorska, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6212094475", "Petar", true, "Stefanov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c") },
                    { new Guid("f8c073b1-c027-4439-b971-d76598d40883"), "Sofi, bul.Vitosha 3, et.7, ap.16", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "8302198562", "Vanya", true, "Petrova", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0") }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("4800d31a-7a3e-4e41-9b50-6bdfc5a9d843"), "Physical Therapy", 100.0m },
                    { new Guid("71663a14-8bad-4448-8465-492d4b6b183d"), "Chiropractic Adjustment", 120.0m },
                    { new Guid("7c7658ea-df00-4f9d-8294-9e9b4fba60ac"), "Massage Therapy", 80.0m },
                    { new Guid("bde1aada-9775-4cd5-af6a-a35ef2b81c68"), "Manual therapy", 170.0m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Departments_DepartmnetId",
                table: "Rooms",
                column: "DepartmnetId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Departments_DepartmnetId",
                table: "Rooms");

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("5c1e1f09-cd12-443b-8f2c-dc5b0bd775ef"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("9be05fc7-e16a-47f9-b7e4-b2e86f263f80"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("f1da1441-c2e4-481b-b039-8d97b3acf5d4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("f8c073b1-c027-4439-b971-d76598d40883"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("4800d31a-7a3e-4e41-9b50-6bdfc5a9d843"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("71663a14-8bad-4448-8465-492d4b6b183d"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("7c7658ea-df00-4f9d-8294-9e9b4fba60ac"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("bde1aada-9775-4cd5-af6a-a35ef2b81c68"));

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "DepartmentId", "EGN", "FirstName", "HasMedicalInsurance", "LastName", "PhoneNumber", "RoomId" },
                values: new object[,]
                {
                    { new Guid("17cb1541-eb44-4779-8c98-60cc6b6ffb40"), "Sofi, bul.Vitosha 123, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6102193476", "Lazar", true, "Petrov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c") },
                    { new Guid("36425763-e699-46b9-8eea-356c2744f521"), "Sofi, ul.Belomorska, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6212094475", "Petar", true, "Stefanov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c") },
                    { new Guid("642ff24d-5a2b-4fea-8be2-61882a1dda7e"), "Sofi, bul.Vitosha 3, et.7, ap.16", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "8302198562", "Vanya", true, "Petrova", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0") },
                    { new Guid("edeb559d-8ab1-440d-842c-ef6616fbeafa"), "Sofi, ul.Rezovo 13, et.2, ap.6", new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "4810234567", "Ivan", true, "Ivanov", "No phone", new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac") }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("15029a07-3502-4798-a28d-13fc993a585c"), "Massage Therapy", 80.0m },
                    { new Guid("c5c5e258-842b-4276-84b5-8f040b599f16"), "Chiropractic Adjustment", 120.0m },
                    { new Guid("e6346e0c-021b-46da-adaf-7c0b7563fac8"), "Physical Therapy", 100.0m },
                    { new Guid("eec8035b-d157-427c-aaaa-10a35beb6e97"), "Manual therapy", 170.0m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Departments_DepartmnetId",
                table: "Rooms",
                column: "DepartmnetId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
