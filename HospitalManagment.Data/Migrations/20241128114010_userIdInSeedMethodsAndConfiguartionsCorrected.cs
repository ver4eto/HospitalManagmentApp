using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class userIdInSeedMethodsAndConfiguartionsCorrected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_AspNetUsers_UserId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
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

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Rooms_RoomId",
                table: "Patients");

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
                keyValue: new Guid("3ea074a2-b24a-4d9f-870c-eb59e79e6cbe"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("04f9fbae-c80f-4ae8-8306-74a3e26af7d1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("688e114e-68e4-41f0-8d58-b2655d5e599d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("9054c053-ef1b-4dc9-820b-4c244684e4d7"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("a688da38-a5f7-42ef-adb5-87a153a538e1"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("4c2ff5de-b529-41bf-af45-885bdec6bd87"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("6df98aa6-f5b6-4b96-a5d3-d966f93e8bb6"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("be0c0656-f3a5-4ed6-8b96-fe877b11ca1e"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("d3195cfd-84d6-4ae6-b175-bf4af2b09ed9"));

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

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[,]
                {
                    { "06ea23a1-095e-475f-937e-cb3e34c4def2", 0, "8ccd92b6-c9b0-45e8-a612-a3ac13649df9", "ivanovst@abv.bg", true, false, null, "IVANOVST@ABV.BG", "IVANOVST@ABV.BG", "AQAAAAIAAYagAAAAEFz0TSLP6m4ZC/mIWFxC7W+ZEXQ9cZYjXKzUlfVIm2KxS4Ofo066MPtKZqPePxLl7w==", null, false, "cbefefe4-3faa-44fc-957c-0c0508853961", false, "ivanovst@abv.bg", "Manager" },
                    { "0b04322a-bab8-41ca-b791-ec1abdd7e8a0", 0, "4f7ac8b8-ef5c-4b3e-8b97-0cf28123b82a", "petrovp@abv.bg", true, false, null, "PETROVP@ABV.BG", "PETROVP@ABV.BG", "AQAAAAIAAYagAAAAEIS/n4gtcc6dBqMVz8MBIyMOx0Y9PhrUOxdRynDFsRsZ0XhF99UXXAScWg71UDMxQA==", null, false, "e5739100-eee6-4173-bb6d-2844fd4ca00d", false, "petrovp@abv.bg", "Doctor" },
                    { "0f1babbe-d5db-49b9-9624-47b9d69df236", 0, "7e209ca5-a0d9-4ff6-a468-65bce185570e", "brown@abv.bg", true, false, null, "BROWN@ABV.BG", "BROWN@ABV.BG", "AQAAAAIAAYagAAAAEJ1zcqKh8iXzgqQ40oZbsVN/GmwmCIfDWq85YOJ5lRpOR6rZ4SpPL6Wxmy+r8IIA+A==", null, false, "306dc3e8-2994-4fd3-899a-45d07acc0cbf", false, "brown@abv.bg", "Nurse" },
                    { "17e9933d-2a1b-467b-b6a2-79297246b8b3", 0, "85476cd5-b3eb-41eb-8d3f-b114c0aef562", "ivanovivan@abv.bg", true, false, null, "IVANOVIVAN@ABV.BG", "IVANOVIVAN@ABV.BG", "AQAAAAIAAYagAAAAEH6HtdQ2T8nH+MMJHxQMjtlKo7tyMwrXi89zphddqsVRZo5fJyDUQ848y5zlDetA6Q==", null, false, "32ee187f-5e30-43ab-81eb-0632d202e52f", false, "ivanovivan@abv.bg", "Patient" },
                    { "18538144-c4ee-4d7d-b4eb-fd9267ca134f", 0, "51addee8-7769-4c65-83c0-33713f865661", "petrovai@abv.bg", true, false, null, "PETROVAI@ABV.BG", "PETROVAI@ABV.BG", "AQAAAAIAAYagAAAAEM772f5A+hb8i5iQRZT8ItmPSrQ0dYiFDWeNTrZyw7o0vKxEB/KDeL6SWLE17HIApA==", null, false, "0e074eb4-1e9b-4fa2-b96b-c588bc5b0b60", false, "petrovai@abv.bg", "Doctor" },
                    { "2c5c4962-15bb-4282-bfbf-5a0cd30ba664", 0, "990cb90a-5199-48e5-8c02-7234980eddc6", "williams@abv.bg", true, false, null, "WILLIAMS@ABV.BG", "WILLIAMS@ABV.BG", "AQAAAAIAAYagAAAAEOaREZaqut0fIF0FGWDC1hoN7JPcydsXftfHCy22IDQoJb8SgXfqkUCbaYEY7hiPwg==", null, false, "364d9167-288c-4c91-bbf8-17b0352e4d73", false, "williams@abv.bg", "Nurse" },
                    { "38a0afd0-c8d6-4674-b24a-db1e6861fcc8", 0, "5c3cd3ca-1227-4f15-a643-366453261c8a", "jhondoe@abv.bg", true, false, null, "JHONDOE@ABV.BG", "JHONDOE@ABV.BG", "AQAAAAIAAYagAAAAEBnmJyZPmW8FM3EpyKqQzNwjhCjSQKgBFECtZDn/u2sM5fSK95puA+lp9qmsbHX1nQ==", null, false, "561bdab5-dbde-40b0-9092-8ade134ad4c2", false, "jhondoe@abv.bg", "Doctor" },
                    { "3c8870b2-58cf-4341-8ea1-d024520563d0", 0, "cc590115-fc49-49cd-8da8-8ec766c9d747", "taylor@abv.bg", true, false, null, "TAYLOR@ABV.BG", "TAYLOR@ABV.BG", "AQAAAAIAAYagAAAAEFW3bNitz7qdt1PgXb9644xQzzn3qk5oRkVM/lttpMs+dnrR24g/ppAkdgKKvfK+LQ==", null, false, "f55b9c88-6f6c-488a-bdac-c62aa3ddfc35", false, "taylor@abv.bg", "Nurse" },
                    { "57c0a3b2-bf91-4c97-9a31-cb7b454c1415", 0, "edd99b46-84bc-4b06-9c37-ce8e151b632a", "stefanovp@abv.bg", true, false, null, "STEFANOVP@ABV.BG", "STEFANOVP@ABV.BG", "AQAAAAIAAYagAAAAECkqjb4scfAyDrTmATldRYGjyVYcjB4ptIvTZmqzEahaiuWAJxb45FPI/HX+oBvNkA==", null, false, "1e6d3d3e-4b45-4398-a33b-b8ac3a3f012c", false, "stefanovp@abv.bg", "Patient" },
                    { "621fb5c5-b634-405d-951b-3088891c3d5c", 0, "68bef7ae-c145-49ef-85cb-fd4a49169b37", "petrovlazar@abv.bg", true, false, null, "PETROVLAZAR@ABV.BG", "PETROVLAZAR@ABV.BG", "AQAAAAIAAYagAAAAEIndqQ8EiThGviwEQKa8homd12qHgCSB3KawKEkUMF3h3K8R721M0nVDbWa4BWkG/A==", null, false, "91ed4edd-399c-450d-96e9-e67c9ecaaa6c", false, "petrovlazar@abv.bg", "Patient" },
                    { "78429ef3-6e8f-441a-8224-cf9a41152a2c", 0, "799a4c36-3a92-499c-9122-2fce2c38964c", "smith@abv.bg", true, false, null, "SMITH@ABV.BG", "SMITH@ABV.BG", "AQAAAAIAAYagAAAAECdCAfdC9BuYrTkVUDTSGixB9PxUQkc8a8I2LDeGRuZ2p21w9v1u4jKOWYiX1SiTuw==", null, false, "2fa7e9f3-3327-4502-a447-98164b453678", false, "smith@abv.bg", "Doctor" },
                    { "a15998c9-52af-4c6b-a032-b135b879e5a7", 0, "3aa3ee1f-82ff-4390-afc1-ef8387d17c8a", "jhonson@abv.bg", true, false, null, "JHONSON@ABV.BG", "JHONSON@ABV.BG", "AQAAAAIAAYagAAAAEGGoLKaWACqCmB2eqaBPIHpkjzclZfezoQ9tpPI1xwcsloO1KgfynEBiD7cQZMH97A==", null, false, "40924e62-7c3a-4a45-86d5-700c09c024cf", false, "jhonson@abv.bg", "Doctor" },
                    { "af558d53-8adc-45ba-bfdd-1ca9e11e7185", 0, "99470de7-7e0e-41e9-8004-6f47ffc61383", "davissophia@abv.bg", true, false, null, "DAVISSOPHIA@ABV.BG", "DAVISSOPHIA@ABV.BG", "AQAAAAIAAYagAAAAEPo7NiOW1FQdvAZgPvM7QtEFTkkfgoNMWe69k06YwMV4E6vMcSsi6WHs5cAWLWDTqA==", null, false, "ded0989f-cfd8-464a-b5db-0f44cfe93f80", false, "davissophia@abv.bg", "Nurse" },
                    { "c55b3e3f-6604-4bf4-a9c8-014d0c146003", 0, "d197ee7e-994c-43b2-ad27-a8f406d49f5d", "miller@abv.bg", true, false, null, "MILLER@ABV.BG", "MILLER@ABV.BG", "AQAAAAIAAYagAAAAEI/evvR+aAXyyTyZB1zra+GTI1l4jV3SSjd2nyrZd9aQMN+HhPQeGlzS7MkzMKkUwA==", null, false, "eb8666a5-0cba-4601-90f0-f9617f882861", false, "miller@abv.bg", "Nurse" },
                    { "dd5538d3-1f68-412f-9949-94edde16d8a2", 0, "a1bfcdc2-dda0-44a1-aa5e-4de2d3d7cac9", "petrovavanya@abv.bg", true, false, null, "PETROVAVANYA@ABV.BG", "PETROVAVANYA@ABV.BG", "AQAAAAIAAYagAAAAEJnxjzM6nDTBzPdyHIXPG+qgReYmoYJWWgGvZT2zwJWoHM2KyLidWSH8meBzv0Lv/g==", null, false, "4dd98bdd-c585-4aa5-b055-8945ed68f394", false, "petrovavanya@abv.bg", "Patient" }
                });

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0b04322a-bab8-41ca-b791-ec1abdd7e8a0"),
                column: "UserId",
                value: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("18538144-c4ee-4d7d-b4eb-fd9267ca134f"),
                column: "UserId",
                value: "18538144-c4ee-4d7d-b4eb-fd9267ca134f");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("38a0afd0-c8d6-4674-b24a-db1e6861fcc8"),
                column: "UserId",
                value: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("78429ef3-6e8f-441a-8224-cf9a41152a2c"),
                column: "UserId",
                value: "78429ef3-6e8f-441a-8224-cf9a41152a2c");

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a15998c9-52af-4c6b-a032-b135b879e5a7"),
                column: "UserId",
                value: "a15998c9-52af-4c6b-a032-b135b879e5a7");

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("0f1babbe-d5db-49b9-9624-47b9d69df236"),
                column: "UserId",
                value: "0f1babbe-d5db-49b9-9624-47b9d69df236");

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("2c5c4962-15bb-4282-bfbf-5a0cd30ba664"),
                column: "UserId",
                value: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664");

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("3c8870b2-58cf-4341-8ea1-d024520563d0"),
                column: "UserId",
                value: "3c8870b2-58cf-4341-8ea1-d024520563d0");

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("af558d53-8adc-45ba-bfdd-1ca9e11e7185"),
                column: "UserId",
                value: "af558d53-8adc-45ba-bfdd-1ca9e11e7185");

            migrationBuilder.UpdateData(
                table: "Nurses",
                keyColumn: "Id",
                keyValue: new Guid("c55b3e3f-6604-4bf4-a9c8-014d0c146003"),
                column: "UserId",
                value: "c55b3e3f-6604-4bf4-a9c8-014d0c146003");

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("c1447cba-053b-436c-8839-936338f4432c"), false, "Massage Therapy", 80.0m },
                    { new Guid("c8bef3b0-3658-48f9-a6ff-d3c3b10dcf77"), false, "Manual therapy", 170.0m },
                    { new Guid("c97f1b8c-0169-4567-99d2-2b610c4ab161"), false, "Physical Therapy", 100.0m },
                    { new Guid("cacea8c0-cbf3-433d-a21f-1b461dbae66b"), false, "Chiropractic Adjustment", 120.0m }
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "EmailAddress", "FullName", "IsDeleted", "PhoneNumber", "UserId" },
                values: new object[] { new Guid("06ea23a1-095e-475f-937e-cb3e34c4def2"), "ivanovst@abv.bg", "Stoian Ivanov", false, "+359883456789", "06ea23a1-095e-475f-937e-cb3e34c4def2" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "DepartmentId", "EGN", "EmailAddress", "FirstName", "HasMedicalInsurance", "IsDeleted", "LastName", "PhoneNumber", "RoomId", "UserId" },
                values: new object[,]
                {
                    { new Guid("17e9933d-2a1b-467b-b6a2-79297246b8b3"), "Sofi, ul.Rezovo 13, et.2, ap.6", new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "4810234567", "ivanovivan@abv.bg", "Ivan", true, false, "Ivanov", "No phone", new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac"), "17e9933d-2a1b-467b-b6a2-79297246b8b3" },
                    { new Guid("57c0a3b2-bf91-4c97-9a31-cb7b454c1415"), "Sofi, ul.Belomorska, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6212094475", "stefanovp@abv.bg", "Petar", true, false, "Stefanov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"), "57c0a3b2-bf91-4c97-9a31-cb7b454c1415" },
                    { new Guid("621fb5c5-b634-405d-951b-3088891c3d5c"), "Sofi, bul.Vitosha 123, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6102193476", "petrovlazar@abv.bg", "Lazar", true, false, "Petrov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"), "621fb5c5-b634-405d-951b-3088891c3d5c" },
                    { new Guid("dd5538d3-1f68-412f-9949-94edde16d8a2"), "Sofi, bul.Vitosha 3, et.7, ap.16", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "8302198562", "petrovavanya@abv.bg", "Vanya", true, false, "Petrova", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0"), "dd5538d3-1f68-412f-9949-94edde16d8a2" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_AspNetUsers_UserId",
                table: "Doctors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
                table: "Doctors",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Managers_AspNetUsers_UserId",
                table: "Managers",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Nurses_AspNetUsers_UserId",
                table: "Nurses",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_AspNetUsers_UserId",
                table: "Patients",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Doctors_AspNetUsers_UserId",
                table: "Doctors");

            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
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

            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Rooms_RoomId",
                table: "Patients");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1babbe-d5db-49b9-9624-47b9d69df236");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18538144-c4ee-4d7d-b4eb-fd9267ca134f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c8870b2-58cf-4341-8ea1-d024520563d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78429ef3-6e8f-441a-8224-cf9a41152a2c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15998c9-52af-4c6b-a032-b135b879e5a7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558d53-8adc-45ba-bfdd-1ca9e11e7185");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55b3e3f-6604-4bf4-a9c8-014d0c146003");

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("06ea23a1-095e-475f-937e-cb3e34c4def2"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("17e9933d-2a1b-467b-b6a2-79297246b8b3"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("57c0a3b2-bf91-4c97-9a31-cb7b454c1415"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("621fb5c5-b634-405d-951b-3088891c3d5c"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("dd5538d3-1f68-412f-9949-94edde16d8a2"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("c1447cba-053b-436c-8839-936338f4432c"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("c8bef3b0-3658-48f9-a6ff-d3c3b10dcf77"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("c97f1b8c-0169-4567-99d2-2b610c4ab161"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("cacea8c0-cbf3-433d-a21f-1b461dbae66b"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ea23a1-095e-475f-937e-cb3e34c4def2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e9933d-2a1b-467b-b6a2-79297246b8b3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c0a3b2-bf91-4c97-9a31-cb7b454c1415");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621fb5c5-b634-405d-951b-3088891c3d5c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd5538d3-1f68-412f-9949-94edde16d8a2");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "UserType" },
                values: new object[,]
                {
                    { "brown@abv.bg", 0, "f77e2d4b-5c2b-4382-bc2f-49b6bb768216", "brown@abv.bg", true, false, null, "BROWN@ABV.BG", "BROWN@ABV.BG", "AQAAAAIAAYagAAAAEEZZOqF1Fzg7K3tVc/qXXcvN6i7l+zmxEGxXz/LJ5mxTtRdNA1n/k3cE2kWI+jZx+A==", null, false, "8d17650f-3e12-46db-a6f9-aed8a5d45d2c", false, "brown@abv.bg", "Nurse" },
                    { "davissophia@abv.bg", 0, "654ace96-fd9c-43ca-89c9-950c23205cc1", "davissophia@abv.bg", true, false, null, "DAVISSOPHIA@ABV.BG", "DAVISSOPHIA@ABV.BG", "AQAAAAIAAYagAAAAEDPnYirBobhSBKuoGEXOILMnD7AHXIMAafyAB5PdA5teTin8bDTFvTQUw/79/5GRUQ==", null, false, "16ac7a37-2382-448c-baef-f6aeff0d8930", false, "davissophia@abv.bg", "Nurse" },
                    { "ivanovivan@abv.bg", 0, "a410b6f8-b63e-4626-8793-3ac992881dee", "ivanovivan@abv.bg", true, false, null, "IVANOVIVAN@ABV.BG", "IVANOVIVAN@ABV.BG", "AQAAAAIAAYagAAAAEIdAEJeqKgLWuA7Uy3Ml3mgiZ00vMD1yRYVMZZm50jg0SULILbTKFtGQQ4T7NGR4IA==", null, false, "4fe2ac5c-c85b-45cf-a6d1-6f6657374125", false, "ivanovivan@abv.bg", "Patient" },
                    { "ivanovst@abv.bg", 0, "68e2ab2e-2725-4868-bade-0f2d0091ec9a", "ivanovst@abv.bg", true, false, null, "IVANOVST@ABV.BG", "IVANOVST@ABV.BG", "AQAAAAIAAYagAAAAEPoshEHzAgqNfWycP2BdOjIzqddMZt8CMofrze4wi2M6vvcd7ZtoiPykzLF1Z+TUzw==", null, false, "cd5f058d-600c-4bc4-a838-39db55c69238", false, "ivanovst@abv.bg", "Manager" },
                    { "jhondoe@abv.bg", 0, "8366fa3b-2e17-4fa0-9e1b-5d4237b41643", "jhondoe@abv.bg", true, false, null, "JHONDOE@ABV.BG", "JHONDOE@ABV.BG", "AQAAAAIAAYagAAAAEFocf8TDw0vgex//p/T4rAj+UQZ3FJnIaYIiK51i7bJMX5gO4RffCc5QG9tzT7cvZQ==", null, false, "2e16c7d5-f88d-40a9-87f4-b297171570f5", false, "jhondoe@abv.bg", "Doctor" },
                    { "jhonson@abv.bg", 0, "9aff2152-f8bc-436b-aa37-e4a40aba5383", "jhonson@abv.bg", true, false, null, "JHONSON@ABV.BG", "JHONSON@ABV.BG", "AQAAAAIAAYagAAAAEOlPiu2IEEajUH2sbYQod1/4GPPWkEJpxy58mp611TosCt7hpYw5fhZU+ImvGSvNDA==", null, false, "2ea76c03-71a1-40bf-9cff-3dc84700d485", false, "jhonson@abv.bg", "Doctor" },
                    { "miller@abv.bg", 0, "042e227f-a538-41c7-ae66-d4850e542914", "miller@abv.bg", true, false, null, "MILLER@ABV.BG", "MILLER@ABV.BG", "AQAAAAIAAYagAAAAECfVhau5JxsVf6Vm2JXPYslDKJADuGHEWHjNSYRpJOCt8u1hw5NM8Y2T8AyULEl1jw==", null, false, "d5686880-75a8-4f67-a2ca-5310e4139ac6", false, "miller@abv.bg", "Nurse" },
                    { "petrovai@abv.bg", 0, "eb28a81c-05fc-4f24-ba46-07eafdf6782c", "petrovai@abv.bg", true, false, null, "PETROVAI@ABV.BG", "PETROVAI@ABV.BG", "AQAAAAIAAYagAAAAEP4H/Vb57qO7tNUX7Ys0Ez4aO9bC8Rm5lZTS1Y2nyQflQmEM6Q5HUJviluQDMkdc/w==", null, false, "d4c89be7-50b8-4f5f-a6ae-9851ec28196c", false, "petrovai@abv.bg", "Doctor" },
                    { "petrovavanya@abv.bg", 0, "c7c67be6-a6b1-4a15-a441-e9ba1aa25056", "petrovavanya@abv.bg", true, false, null, "PETROVAVANYA@ABV.BG", "PETROVAVANYA@ABV.BG", "AQAAAAIAAYagAAAAEAEzJwx6aTL749rwFI/8ioOFHCfOksSDz26m2kZ60d9LX8g3lQ5G70mlk3U9tIW/rA==", null, false, "608c9bda-6ae1-43c8-b718-84af6c69b75d", false, "petrovavanya@abv.bg", "Patient" },
                    { "petrovlazar@abv.bg", 0, "fc1e5a1c-55c1-45af-8cc8-8d3a5a4a49ef", "petrovlazar@abv.bg", true, false, null, "PETROVLAZAR@ABV.BG", "PETROVLAZAR@ABV.BG", "AQAAAAIAAYagAAAAELnF9nEq2ZFO144P99z/rygIR0dVhlvXhpHEGCUlL0SlFC2WvEELjrgZugz8oOEUCQ==", null, false, "c5f0e3d8-e755-472e-8afb-197c1f817d13", false, "petrovlazar@abv.bg", "Patient" },
                    { "petrovp@abv.bg", 0, "1db139c0-7021-4ec8-9122-9c95d4b18700", "petrovp@abv.bg", true, false, null, "PETROVP@ABV.BG", "PETROVP@ABV.BG", "AQAAAAIAAYagAAAAEGVYBoUQ7VucyD/bxfQFCOkxirqkFY+laTIj49wSRk6SDJVcty+HC3CLk5yRiGDA+w==", null, false, "97d14058-a63f-4359-98ed-76e43f487c89", false, "petrovp@abv.bg", "Doctor" },
                    { "smith@abv.bg", 0, "476fb837-5805-454a-9528-762797af125c", "smith@abv.bg", true, false, null, "SMITH@ABV.BG", "SMITH@ABV.BG", "AQAAAAIAAYagAAAAEKvoYgAvY1JP2ujTCjNxBP83Zh+4fRAsoDZXyTK6FfaN1zblvlQ+u4rN8gUIbLGVGg==", null, false, "2cf618ae-6e20-49ca-9c3b-2158ef06a91f", false, "smith@abv.bg", "Doctor" },
                    { "stefanovp@abv.bg", 0, "43788661-d9d6-4ac3-bc45-f3c229038768", "stefanovp@abv.bg", true, false, null, "STEFANOVP@ABV.BG", "STEFANOVP@ABV.BG", "AQAAAAIAAYagAAAAEIk+xlpMR5fA3IW6Y7FIDlWsG0iqypJsRiq59Pi5TUCZha6LCb0gLGUtRVP26SDBag==", null, false, "151f3761-95f7-4e4e-b134-2a3a89657391", false, "stefanovp@abv.bg", "Patient" },
                    { "taylor@abv.bg", 0, "b5245027-50d8-426e-94a5-4b956ca2498e", "taylor@abv.bg", true, false, null, "TAYLOR@ABV.BG", "TAYLOR@ABV.BG", "AQAAAAIAAYagAAAAED5sPyi9Xd/4oJynBsyJBVVBIfUio1wD6GonhbiFkZd2sOdNidQFrJ7G7x1QPZfecg==", null, false, "40dad66a-4638-467c-9b12-2c78641fb979", false, "taylor@abv.bg", "Nurse" },
                    { "williams@abv.bg", 0, "a4b4e431-8a9c-4856-a689-9286b1d2f8c6", "williams@abv.bg", true, false, null, "WILLIAMS@ABV.BG", "WILLIAMS@ABV.BG", "AQAAAAIAAYagAAAAEJy16qxThdEUaxGkrmDDvkiAkiq30N6qZ2hjoAUfV2LutZTVkRY3msSNHHFUpcjUQQ==", null, false, "a682dc9e-2977-43fc-83f8-7517087fe0dc", false, "williams@abv.bg", "Nurse" }
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
                    { new Guid("4c2ff5de-b529-41bf-af45-885bdec6bd87"), false, "Physical Therapy", 100.0m },
                    { new Guid("6df98aa6-f5b6-4b96-a5d3-d966f93e8bb6"), false, "Massage Therapy", 80.0m },
                    { new Guid("be0c0656-f3a5-4ed6-8b96-fe877b11ca1e"), false, "Chiropractic Adjustment", 120.0m },
                    { new Guid("d3195cfd-84d6-4ae6-b175-bf4af2b09ed9"), false, "Manual therapy", 170.0m }
                });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "EmailAddress", "FullName", "IsDeleted", "PhoneNumber", "UserId" },
                values: new object[] { new Guid("3ea074a2-b24a-4d9f-870c-eb59e79e6cbe"), "ivanovst@abv.bg", "Stoian Ivanov", false, "+359883456789", "ivanovst@abv.bg" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "DepartmentId", "EGN", "EmailAddress", "FirstName", "HasMedicalInsurance", "IsDeleted", "LastName", "PhoneNumber", "RoomId", "UserId" },
                values: new object[,]
                {
                    { new Guid("04f9fbae-c80f-4ae8-8306-74a3e26af7d1"), "Sofi, bul.Vitosha 3, et.7, ap.16", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "8302198562", "petrovavanya@abv.bg", "Vanya", true, false, "Petrova", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0"), "petrovavanya@abv.bg" },
                    { new Guid("688e114e-68e4-41f0-8d58-b2655d5e599d"), "Sofi, ul.Rezovo 13, et.2, ap.6", new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "4810234567", "ivanovivan@abv.bg", "Ivan", true, false, "Ivanov", "No phone", new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac"), "ivanovivan@abv.bg" },
                    { new Guid("9054c053-ef1b-4dc9-820b-4c244684e4d7"), "Sofi, ul.Belomorska, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6212094475", "stefanovp@abv.bg", "Petar", true, false, "Stefanov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"), "stefanovp@abv.bg" },
                    { new Guid("a688da38-a5f7-42ef-adb5-87a153a538e1"), "Sofi, bul.Vitosha 123, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6102193476", "petrovlazar@abv.bg", "Lazar", true, false, "Petrov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"), "petrovlazar@abv.bg" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_AspNetUsers_UserId",
                table: "Doctors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
                table: "Doctors",
                column: "DepartmentId",
                principalTable: "Departments",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Rooms_RoomId",
                table: "Patients",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id");
        }
    }
}
