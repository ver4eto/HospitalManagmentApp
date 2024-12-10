using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Department unique identifier"),
                    Name = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Name of the Department"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Soft delete property")
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
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Soft delete property")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Treatments", x => x.Id);
                },
                comment: "Treatment info table");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Manager unique identifier"),
                    FullName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false, comment: "Manager Full Name"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Soft delete property"),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The person email address"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false, comment: "Manager phone number"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Managers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Data for Hospital Manager");

            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Doctor`s unique identifier"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Doctor`s Last Name"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Doctor`s First Name"),
                    Specialty = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Doctor`s Speciality"),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The person email address"),
                    Salary = table.Column<decimal>(type: "money", nullable: false, comment: "Doctor`s monthly salary"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Soft delete property"),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "In which department works the doctor"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctors_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                },
                comment: "Doctor info table");

            migrationBuilder.CreateTable(
                name: "Nurses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Nurse unnique identifier"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Nurse first name"),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Nurse last name"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Soft delete property"),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The person email address"),
                    Salary = table.Column<decimal>(type: "money", nullable: false, comment: "Nurse monthly salary"),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Nurse`s department"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nurses_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Nurses_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Soft delete property"),
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
                        onDelete: ReferentialAction.Restrict);
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
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, comment: "Soft delete property"),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The person email address"),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "Patient phone number"),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Patient address"),
                    HasMedicalInsurance = table.Column<bool>(type: "bit", nullable: false, comment: "Specify if the patient is insured"),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "In which department the patient is assigned"),
                    RoomId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, comment: "Room of the patient"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Patients_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientsDoctors_Patients_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PatientsTreatments_Treatments_TreatmentId",
                        column: x => x.TreatmentId,
                        principalTable: "Treatments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[,]
                {
                    { "06ea23a1-095e-475f-937e-cb3e34c4def2", 0, "4298edd2-7f3a-4156-b1fb-c243c76ce4de", "ivanovst@abv.bg", true, false, null, "IVANOVST@ABV.BG", "IVANOVST@ABV.BG", "AQAAAAIAAYagAAAAEKpF14qA33gjSPqbxpY3qsa98DeSfqDfGtftiYqGipbJEQEXhwlKa04EZ2trAaUn8g==", null, false, "1d650ef7-a2eb-4a88-903a-e84ea25b3081", false, "ivanovst@abv.bg", "Manager" },
                    { "0b04322a-bab8-41ca-b791-ec1abdd7e8a0", 0, "0c7688be-aa2c-435b-98aa-4db150fb68a2", "petrovp@abv.bg", true, false, null, "PETROVP@ABV.BG", "PETROVP@ABV.BG", "AQAAAAIAAYagAAAAEKfPFwqAs80U82qvYOx9l5oVo50CBQx7qsova7Dkc+vEYb4R9M8HeYpzC6IyDi1WsQ==", null, false, "4a8d89f9-3c58-4b19-b18c-f93259a4c3b1", false, "petrovp@abv.bg", "Doctor" },
                    { "0f1babbe-d5db-49b9-9624-47b9d69df236", 0, "31fb23c5-5634-4338-8718-8a499a437732", "brown@abv.bg", true, false, null, "BROWN@ABV.BG", "BROWN@ABV.BG", "AQAAAAIAAYagAAAAEFlsdd2Jq9MZRSQjo+qh6zaxjb4UZRetDueG3Oac97H03NtjC4/SSHaj3PN0fqXp1w==", null, false, "f8dcb3d9-a823-4726-8742-a3f7e9c2d601", false, "brown@abv.bg", "Nurse" },
                    { "134d8ce3-4c26-434a-90b4-f59ae5457a01", 0, "eeb5ac4c-9273-47de-92b7-e9aae5c7d24b", "mary.johnson@example.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEJGk9DD8Ig+mOYxc91XgPgpKl5Oo7TVwSCHu2LWoWM4SSR24ebknbs0Rxv8FQNRczg==", null, false, "d695d4f9-88f4-43c9-b7af-c754c4b3b0ed", false, "mary.johnson@example.com", "Patient" },
                    { "15050ff2-ed6c-475f-8831-f61d54a29175", 0, "76cc6e55-5856-4c8c-bfcf-3b0e235f7fb1", "patricia.brown@example.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEPfoJ6B4F9kxN2UJhH2yAZs9TqJpQqA5cFL1646jksQ6nJjXIoq4H0t8lmC2/aUgBw==", null, false, "9da4d9d7-040c-49a6-b380-03b5ceb14b4f", false, "patricia.brown@example.com", "Patient" },
                    { "17139a72-76d4-4362-aa27-18a64cc8d285", 0, "150b0aea-a43a-46e1-9d52-16c45ae99aa0", "robert.williams@example.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEEid6vvuPDMRiZlhQUVXpLYSS1bE0FkMX/Z06o9mM0foa8nSZosrLwhh2FPuUogZow==", null, false, "885842c5-0f19-4ee2-8d01-99f68d324a16", false, "robert.williams@example.com", "Patient" },
                    { "17e9933d-2a1b-467b-b6a2-79297246b8b3", 0, "a1192d77-5538-4bc2-ad30-c8351bffdca3", "ivanovivan@abv.bg", true, false, null, "IVANOVIVAN@ABV.BG", "IVANOVIVAN@ABV.BG", "AQAAAAIAAYagAAAAEJIQIatJX/c+4l8og+x2iWczvG4lgfs4yy95ewaxn7JnNEebhL6j4FYMWZ/mY13S2g==", null, false, "0cd883cd-508b-4684-b529-e6e3802afd6f", false, "ivanovivan@abv.bg", "Patient" },
                    { "18538144-c4ee-4d7d-b4eb-fd9267ca134f", 0, "2f5779c4-29c0-4479-bba0-6a2fd94f255b", "petrovai@abv.bg", true, false, null, "PETROVAI@ABV.BG", "PETROVAI@ABV.BG", "AQAAAAIAAYagAAAAEMGf+xg+EUaapTchXKkQ4iKrUsrCP8KxOr5M8XvbCcdVPY78rkidN4E6gNws9TAvQg==", null, false, "5aa497d6-6e4c-428c-b265-7aeac2e70bfb", false, "petrovai@abv.bg", "Doctor" },
                    { "23fbee5b-fbe0-49a4-b312-6a5471f79dca", 0, "1095c4f2-293f-47da-b56e-836fbaf59612", "nikolovapa@abv.bg", true, false, null, null, null, "AQAAAAIAAYagAAAAEH5ihNapbjsVOkNkINbn2O36Rn56B3laKP1rMhvQhGTX+qwg6WhEWrWsK4HxbAC9UA==", null, false, "984e233d-6a77-4ce8-bea8-9ed487e79899", false, "nikolovapa@abv.bg", "Nurse" },
                    { "2c5c4962-15bb-4282-bfbf-5a0cd30ba664", 0, "52d0fb11-c689-4ccf-9c57-6e487c8ca06c", "williams@abv.bg", true, false, null, "WILLIAMS@ABV.BG", "WILLIAMS@ABV.BG", "AQAAAAIAAYagAAAAENRkW6F5/fAdlmo5ON122LR679yccJ0gJ3TUhXHRALCyzZfTdtk2uMiqPuvcwRijZg==", null, false, "11b8cf6b-c7ce-44fb-b129-12728822a8fc", false, "williams@abv.bg", "Nurse" },
                    { "3110d510-2d4d-4e84-9f69-84794965586d", 0, "9dbe73e1-fbf7-4c4e-a9df-08b4bb6cf927", "michael.wilson@example.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEHzVGiSuyNpukyXRZhK0Z+Vf7Fhi8PN98W816CD2btQSaFjcnjqBiGNPEABXGJMjAQ==", null, false, "4b663933-c73b-4e7c-a123-efe33b461805", false, "michael.wilson@example.com", "Patient" },
                    { "38a0afd0-c8d6-4674-b24a-db1e6861fcc8", 0, "e71ae832-5c5c-4134-a2f0-d0dc93d6d521", "jhondoe@abv.bg", true, false, null, "JHONDOE@ABV.BG", "JHONDOE@ABV.BG", "AQAAAAIAAYagAAAAEO3J7edjS9uXfpQYrmZGdiqJ2DHhCtBIFdj6bT+5bYWI7y1b7vjIeCHbuyx3T4IJIA==", null, false, "e9c91145-9a6b-437e-a81f-7ee7de8a6290", false, "jhondoe@abv.bg", "Doctor" },
                    { "3c8870b2-58cf-4341-8ea1-d024520563d0", 0, "9bf3f970-5df8-4b1e-abe2-5c00b2508333", "taylor@abv.bg", true, false, null, "TAYLOR@ABV.BG", "TAYLOR@ABV.BG", "AQAAAAIAAYagAAAAEAORUVpytfmBltgGaa4RUqZPhCKxmAbS/1YPHW6qNvwxiae71O6oRR9cY6T1BNkx/Q==", null, false, "149383ef-9abe-45e1-a290-1d2712d3ee20", false, "taylor@abv.bg", "Nurse" },
                    { "57c0a3b2-bf91-4c97-9a31-cb7b454c1415", 0, "1e1c55ee-e837-4c26-bfea-ec30a45fb00c", "stefanovp@abv.bg", true, false, null, "STEFANOVP@ABV.BG", "STEFANOVP@ABV.BG", "AQAAAAIAAYagAAAAEMa3IKQoClLxQTFqZ/hah8w6uqMmdT4tuTNm+5CGDJcgFwEUx+tZ56AHATi0xhTE9w==", null, false, "50f825ff-8e9e-4bc9-9cb8-989793875955", false, "stefanovp@abv.bg", "Patient" },
                    { "57e1941c-1412-4384-b819-d67a19204baf", 0, "c5234b35-7bcc-4463-b97f-b85e6c3388ef", "angelovz@abv.bg", true, false, null, null, null, "AQAAAAIAAYagAAAAEKpWttLyn3u1uGm3TwVYlSfb9WsOtHoEa+Z3X4eqYrofp0b15KETRiFnSSpR3mO+SQ==", null, false, "2aaef69f-bcbc-41ed-bced-d75bcaed3152", false, "angelovz@abv.bg", "Doctor" },
                    { "621fb5c5-b634-405d-951b-3088891c3d5c", 0, "ad9e5348-3051-4ecf-b75d-701c5246e25c", "petrovlazar@abv.bg", true, false, null, "PETROVLAZAR@ABV.BG", "PETROVLAZAR@ABV.BG", "AQAAAAIAAYagAAAAECqW6kMRILSwDtIt58OlHaQZvRlBwSVVl1uFBXf4wdpyxjci+GfyrGtxxfZGuDdYkA==", null, false, "9d6ad080-ac9a-4e48-a02f-03b5856603b4", false, "petrovlazar@abv.bg", "Patient" },
                    { "76222e29-cbf5-4335-b2e4-fa6a77afeab1", 0, "2327a832-5b8d-42df-9cf9-e0faf09063cb", "jennifer.miller@example.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEBUslUBGcPUraCbjLRGHG5y6016gr0Ky/eqr4kC+VpIesskX0wwclG1pdkY9qyuoXA==", null, false, "19323f1a-050c-455e-a306-ab463347a3b0", false, "jennifer.miller@example.com", "Patient" },
                    { "78429ef3-6e8f-441a-8224-cf9a41152a2c", 0, "a5287248-5df8-4ca8-a52c-0fc277ab3d26", "smith@abv.bg", true, false, null, "SMITH@ABV.BG", "SMITH@ABV.BG", "AQAAAAIAAYagAAAAEA7P1tzxJbmLJEvf6SOx0Me64weXsZ8j2Txz/5fr7F5xK78vOXgthEp4ebPvRlStNw==", null, false, "be673280-582c-4635-b425-537c2f7d267e", false, "smith@abv.bg", "Doctor" },
                    { "7c032bc0-04e2-4111-bbfb-a59d46791529", 0, "476849d7-2f91-403b-9f84-18dd7b0ac406", "taskovao@abv.bg", true, false, null, null, null, "AQAAAAIAAYagAAAAELe9LbvU6Zib0JYox+4LBjEsUYlQvn/IUBFQBxRAyaKmAAKl/QvfYQmCnfUXbYwc1g==", null, false, "6d56db7c-80ec-4cc2-b642-4dca45361261", false, "taskovao@abv.bg", "Nurse" },
                    { "82c99b5d-6573-4514-81eb-183ace313419", 0, "f3c88bca-de8b-4341-88bc-9b86a831e3b4", "david.taylor@example.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEBKYtDLlCVwqn7KgOML2rqj8P8mBZL+387Cf3YRguaRNS6Fcp7RWv7/oxh5gqjuZfg==", null, false, "1d82713e-b69f-4bff-9c89-0659c6b4e28b", false, "david.taylor@example.com", "Patient" },
                    { "a001bd24-5c2a-4f7a-b000-5f7bd233cd12", 0, "c88a4132-8142-4bd7-ba20-260732cf9167", "james.anderson@example.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEFMk0PfXDyyMfxP+Xrmnb8AicKo30DY701yUwnnE7sB5vw/a0983KFGOQCXJk4KE0g==", null, false, "a977c0bf-83fa-479d-b3b9-25b14907691d", false, "james.anderson@example.com", "Patient" },
                    { "a15998c9-52af-4c6b-a032-b135b879e5a7", 0, "3df8c6f5-c83c-46d3-aa23-d36fcd50ccc5", "jhonson@abv.bg", true, false, null, "JHONSON@ABV.BG", "JHONSON@ABV.BG", "AQAAAAIAAYagAAAAEGesHXjyYXd49kbAJn8FUWMzS2Twklq5ksZUCFfa7Fy2bQ6HQ3LhwnV5tO3Rfi7xVw==", null, false, "1fa9b47b-0c88-4494-9e7d-3ce28a71f75d", false, "jhonson@abv.bg", "Doctor" },
                    { "a8d287e8-357a-40f3-893a-ed507ed6a85d", 0, "e174c1b4-c94d-4715-afae-112f276fb297", "susan.anderson@example.com", true, false, null, null, null, "AQAAAAIAAYagAAAAEB1h9ilzHB7ZadmH+YIDmrwEOp433b8tWtfRXfAzE7mQcdbJ9LSjO48t4pbBbs2YWQ==", null, false, "72fb4691-5a1f-4387-8f93-2424cd993d47", false, "susan.anderson@example.com", "Patient" },
                    { "af558d53-8adc-45ba-bfdd-1ca9e11e7185", 0, "75c3c160-6873-4b4e-91ae-c940320408cd", "davissophia@abv.bg", true, false, null, "DAVISSOPHIA@ABV.BG", "DAVISSOPHIA@ABV.BG", "AQAAAAIAAYagAAAAEC7NHcNoJWhw/og7hFMpmvvD3HFOftXTEXudKrvEcIrEiR3XKIqEF76ZT6LozSprPw==", null, false, "24c63c0c-941a-48c5-aca9-7a1aab3052f8", false, "davissophia@abv.bg", "Nurse" },
                    { "c55b3e3f-6604-4bf4-a9c8-014d0c146003", 0, "e79c9b32-be6c-445f-b291-480b6ef38668", "miller@abv.bg", true, false, null, "MILLER@ABV.BG", "MILLER@ABV.BG", "AQAAAAIAAYagAAAAEMLGrADrJ6uszokxsox/DnUhEonfY8OO3uyqYcUe+0sjmzmo3PDBLrzfqvWVGRVAAw==", null, false, "fceb6f29-d45a-4641-80e9-1f152f558062", false, "miller@abv.bg", "Nurse" },
                    { "c6e29719-7856-4b5f-b5da-84ed3a292877", 0, "962793a0-4ff8-4163-922c-3ac343644d53", "slaveykir@abv.bg", true, false, null, null, null, "AQAAAAIAAYagAAAAENYj6k66bm6qfn2tEXB5jt4/aX3R5/jA/kR4obmzwHyymQFrP8T1bilmLd52TS370w==", null, false, "94e195fb-92b0-42d3-9d0a-0e6a7a961639", false, "slaveykir@abv.bg", "Doctor" },
                    { "d8d0d177-60a0-4925-b4ed-bb36aebb48c4", 0, "80592c06-3606-4b6e-9dd9-718a4e01fbdc", "elizabeth.moore@example.com", true, false, null, null, null, "AQAAAAIAAYagAAAAENs+4Np7fcfDFu+z2nepZcSyBWK5fbj1HLSoKCVz5eRqlWrNNJz2c+ObBN5OXKmxdQ==", null, false, "239c2454-8e12-43ff-b0e3-60f4464b68b6", false, "elizabeth.moore@example.com", "Patient" },
                    { "dd5538d3-1f68-412f-9949-94edde16d8a2", 0, "563d0b02-3acd-47e0-aafe-c2b43f59eaa6", "petrovavanya@abv.bg", true, false, null, "PETROVAVANYA@ABV.BG", "PETROVAVANYA@ABV.BG", "AQAAAAIAAYagAAAAEIgAnpESPdseB1bSym7PUQW9WV2QjXgfWM6/OGXjseeiNsg+iee0kbjnP9L8SDCSIQ==", null, false, "b233f491-9702-4085-bdab-24ad71999b0a", false, "petrovavanya@abv.bg", "Patient" },
                    { "fddefbf4-e1a5-42a1-a64d-e0843640267c", 0, "ae1917fb-446d-4b22-96bf-390fc8de83c0", "atanasovao@abv.bg", true, false, null, null, null, "AQAAAAIAAYagAAAAEIcj3DAHaBeS+rvFxvBxLmPO1h2wWeC7KJxsM8eNyWXIObQ6lVJeIiFs8iy63pjNpA==", null, false, "088ba545-d1d5-42cf-bd72-0a4e90223719", false, "atanasovao@abv.bg", "Doctor" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_DepartmentId",
                table: "Doctors",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_UserId",
                table: "Doctors",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_UserId",
                table: "Managers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_DepartmentId",
                table: "Nurses",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurses_UserId",
                table: "Nurses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DepartmentId",
                table: "Patients",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_RoomId",
                table: "Patients",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_UserId",
                table: "Patients",
                column: "UserId");

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Nurses");

            migrationBuilder.DropTable(
                name: "PatientsDoctors");

            migrationBuilder.DropTable(
                name: "PatientsTreatments");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Treatments");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
