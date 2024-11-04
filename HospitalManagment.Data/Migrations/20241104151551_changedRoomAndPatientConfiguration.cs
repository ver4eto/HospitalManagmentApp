using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class changedRoomAndPatientConfiguration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Rooms_RoomId",
                table: "Patients");

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
                    { new Guid("02d5b08e-7e96-406c-a445-332dfa30475b"), "Sofi, ul.Rezovo 13, et.2, ap.6", new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "4810234567", "Ivan", true, "Ivanov", "No phone", new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac") },
                    { new Guid("17a95176-e310-42fa-91b4-90dbc11c76f0"), "Sofi, bul.Vitosha 123, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6102193476", "Lazar", true, "Petrov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c") },
                    { new Guid("6e1de844-4cc6-4f27-a0d2-fb52806bd55d"), "Sofi, ul.Belomorska, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6212094475", "Petar", true, "Stefanov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c") },
                    { new Guid("ceeb401e-96ed-401c-9fe9-0c44eaff91dc"), "Sofi, bul.Vitosha 3, et.7, ap.16", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "8302198562", "Vanya", true, "Petrova", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0") }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("105b3c7a-b9f4-4d22-9788-f884074c6e5a"), "Physical Therapy", 100.0m },
                    { new Guid("13f52fdf-4dbc-433d-a65e-0149ede03a53"), "Manual therapy", 170.0m },
                    { new Guid("c79e4148-c5a8-415f-9c7b-0aab2254a01d"), "Massage Therapy", 80.0m },
                    { new Guid("f8dddc6a-3dc0-47b6-a400-5bf6fc687278"), "Chiropractic Adjustment", 120.0m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Rooms_RoomId",
                table: "Patients",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Rooms_RoomId",
                table: "Patients");

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("02d5b08e-7e96-406c-a445-332dfa30475b"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("17a95176-e310-42fa-91b4-90dbc11c76f0"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("6e1de844-4cc6-4f27-a0d2-fb52806bd55d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("ceeb401e-96ed-401c-9fe9-0c44eaff91dc"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("105b3c7a-b9f4-4d22-9788-f884074c6e5a"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("13f52fdf-4dbc-433d-a65e-0149ede03a53"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("c79e4148-c5a8-415f-9c7b-0aab2254a01d"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("f8dddc6a-3dc0-47b6-a400-5bf6fc687278"));

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
                name: "FK_Patients_Rooms_RoomId",
                table: "Patients",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }
    }
}
