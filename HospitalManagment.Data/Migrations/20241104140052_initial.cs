using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Department unique identifier"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Name of the Department")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                },
                comment: "Department info");

            migrationBuilder.CreateTable(
                name: "Treatments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Treatment unique identifier"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.Id);
                },
                comment: "Treatment info table");

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Doctor`s unique identifier"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Doctor`s First Name"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Doctor`s Last Name"),
                    Specialty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Doctor`s Speciality"),
                    Salary = table.Column<decimal>(type: "money", nullable: false, comment: "Doctor`s monthly salary"),
                    DepartmnetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "In which department works the doctor")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Departments_DepartmnetId",
                        column: x => x.DepartmnetId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Doctor info table");

            migrationBuilder.CreateTable(
                name: "Nurses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Nurse unnique identifier"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Nurse first name"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Nurse last name"),
                    Salary = table.Column<decimal>(type: "money", nullable: false, comment: "Nurse monthly salary"),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Nurse`s department")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nurses_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Nurse info table");

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Room unique identifier"),
                    RoomNumber = table.Column<int>(type: "int", nullable: false, comment: "Room Number"),
                    BedCount = table.Column<int>(type: "int", nullable: false, comment: "Room`s beds count"),
                    HasFreeBeds = table.Column<bool>(type: "bit", nullable: false, comment: "Does room has free beds?"),
                    DepartmnetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "In which department is the room")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_Departments_DepartmnetId",
                        column: x => x.DepartmnetId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Room information table");

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Unique identifier of Patient"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Patient First Name"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Patient Last Name"),
                    EGN = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Patient Personal Citizen Number"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Patient phone number"),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Patient address"),
                    HasMedicalInsurance = table.Column<bool>(type: "bit", nullable: false, comment: "Specify if the patient is insured"),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "In which department the patient is assigned"),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Room of the patient")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Patients_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Patient Info Table");

            migrationBuilder.CreateTable(
                name: "PatientsDoctors",
                columns: table => new
                {
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DoctorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientsDoctors", x => new { x.PatientId, x.DoctorId });
                    table.ForeignKey(
                        name: "FK_PatientsDoctors_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientsDoctors_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientsTreatments",
                columns: table => new
                {
                    PatientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TreatmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientsTreatments", x => new { x.PatientId, x.TreatmentId });
                    table.ForeignKey(
                        name: "FK_PatientsTreatments_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientsTreatments_Treatments_TreatmentId",
                        column: x => x.TreatmentId,
                        principalTable: "Treatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3a19290a-8b6d-4551-97ae-b87ecf3f2dd2"), "Pediatrics" },
                    { new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "Internal" },
                    { new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "Surgery" },
                    { new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "Neurology" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "DepartmnetId", "FirstName", "LastName", "Salary", "Specialty" },
                values: new object[,]
                {
                    { new Guid("0b04322a-bab8-41ca-b791-ec1abdd7e8a0"), new Guid("00000000-0000-0000-0000-000000000000"), "Petar", "Petrov", 2150m, "Surgeon" },
                    { new Guid("18538144-c4ee-4d7d-b4eb-fd9267ca134f"), new Guid("00000000-0000-0000-0000-000000000000"), "Ivana", "Petrova", 4150m, "Gynecologist" },
                    { new Guid("38a0afd0-c8d6-4674-b24a-db1e6861fcc8"), new Guid("00000000-0000-0000-0000-000000000000"), "John", "Doe", 1000m, "Neurology" },
                    { new Guid("78429ef3-6e8f-441a-8224-cf9a41152a2c"), new Guid("00000000-0000-0000-0000-000000000000"), "Alice", "Smith", 1200m, "Cardiology" },
                    { new Guid("a15998c9-52af-4c6b-a032-b135b879e5a7"), new Guid("00000000-0000-0000-0000-000000000000"), "Sara", "Johnson", 1150m, "Pediatrics" }
                });

            migrationBuilder.InsertData(
                table: "Nurses",
                columns: new[] { "Id", "DepartmentId", "FirstName", "LastName", "Salary" },
                values: new object[,]
                {
                    { new Guid("0f1babbe-d5db-49b9-9624-47b9d69df236"), new Guid("00000000-0000-0000-0000-000000000000"), "Liam", "Brown", 1020m },
                    { new Guid("2c5c4962-15bb-4282-bfbf-5a0cd30ba664"), new Guid("00000000-0000-0000-0000-000000000000"), "Emma", "Williams", 650m },
                    { new Guid("3c8870b2-58cf-4341-8ea1-d024520563d0"), new Guid("00000000-0000-0000-0000-000000000000"), "Olivia", "Taylor", 66000m },
                    { new Guid("af558d53-8adc-45ba-bfdd-1ca9e11e7185"), new Guid("00000000-0000-0000-0000-000000000000"), "Sophia", "Davis", 67000m },
                    { new Guid("c55b3e3f-6604-4bf4-a9c8-014d0c146003"), new Guid("00000000-0000-0000-0000-000000000000"), "Noah", "Miller", 64000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_DepartmnetId",
                table: "Doctors",
                column: "DepartmnetId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_DepartmentId",
                table: "Nurses",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DepartmentId",
                table: "Patients",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_RoomId",
                table: "Patients",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientsDoctors_DoctorId",
                table: "PatientsDoctors",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientsTreatments_TreatmentId",
                table: "PatientsTreatments",
                column: "TreatmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_DepartmnetId",
                table: "Rooms",
                column: "DepartmnetId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nurses");

            migrationBuilder.DropTable(
                name: "PatientsDoctors");

            migrationBuilder.DropTable(
                name: "PatientsTreatments");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
