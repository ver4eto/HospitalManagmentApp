using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class IdentityUserAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("2d66bdc6-5e0d-479b-815d-a98a2dad92ab"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("3c1b3634-d1ff-4e95-9306-831796b84d63"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("7f7a928f-232d-4089-a79c-123ac04289a7"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("9ead3e9e-0aad-4208-bf59-8e16c65c07e6"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("5ad68be0-92a3-4e6a-85f6-fc53d191959c"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("68164ca0-defd-4ca4-9e21-bb062d262e47"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("77b50529-4cbe-4959-b8dd-1372a3d95964"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("cd59d850-c415-4677-b492-f52f8b9740ee"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "DepartmentId", "EGN", "FirstName", "HasMedicalInsurance", "LastName", "PhoneNumber", "RoomId" },
                values: new object[,]
                {
                    { new Guid("2d66bdc6-5e0d-479b-815d-a98a2dad92ab"), "Sofi, ul.Rezovo 13, et.2, ap.6", new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "4810234567", "Ivan", true, "Ivanov", "No phone", new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac") },
                    { new Guid("3c1b3634-d1ff-4e95-9306-831796b84d63"), "Sofi, bul.Vitosha 123, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6102193476", "Lazar", true, "Petrov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c") },
                    { new Guid("7f7a928f-232d-4089-a79c-123ac04289a7"), "Sofi, ul.Belomorska, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6212094475", "Petar", true, "Stefanov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c") },
                    { new Guid("9ead3e9e-0aad-4208-bf59-8e16c65c07e6"), "Sofi, bul.Vitosha 3, et.7, ap.16", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "8302198562", "Vanya", true, "Petrova", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0") }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("5ad68be0-92a3-4e6a-85f6-fc53d191959c"), "Manual therapy", 170.0m },
                    { new Guid("68164ca0-defd-4ca4-9e21-bb062d262e47"), "Chiropractic Adjustment", 120.0m },
                    { new Guid("77b50529-4cbe-4959-b8dd-1372a3d95964"), "Massage Therapy", 80.0m },
                    { new Guid("cd59d850-c415-4677-b492-f52f8b9740ee"), "Physical Therapy", 100.0m }
                });
        }
    }
}
