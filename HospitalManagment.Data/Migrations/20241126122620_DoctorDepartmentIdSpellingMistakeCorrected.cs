using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class DoctorDepartmentIdSpellingMistakeCorrected : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Departments_DepartmnetId",
                table: "Doctors");

            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("c425430a-de81-4a95-88c1-e3513f1b33d4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("4eb35d81-ab56-4fc2-ad5b-861daf593182"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("63afc1bc-555f-4287-b8d3-0617f5b1dc9e"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("c0d6b6db-888d-49f6-aa04-04d31e034ac7"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("d7d31152-3063-4189-8378-1274fade1d07"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("1c1218e7-6e90-4ddd-ac30-1c3727fb613a"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("34b1292a-4584-42c9-a08a-04cdb7dc46ef"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("34ff9ecb-0078-48a7-8a51-61942f631a1e"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("ffc81b40-375b-407e-9727-52f16c2dcae4"));

            migrationBuilder.RenameColumn(
                name: "DepartmnetId",
                table: "Doctors",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_DepartmnetId",
                table: "Doctors",
                newName: "IX_Doctors_DepartmentId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "brown@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f77e2d4b-5c2b-4382-bc2f-49b6bb768216", "AQAAAAIAAYagAAAAEEZZOqF1Fzg7K3tVc/qXXcvN6i7l+zmxEGxXz/LJ5mxTtRdNA1n/k3cE2kWI+jZx+A==", "8d17650f-3e12-46db-a6f9-aed8a5d45d2c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "davissophia@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "654ace96-fd9c-43ca-89c9-950c23205cc1", "AQAAAAIAAYagAAAAEDPnYirBobhSBKuoGEXOILMnD7AHXIMAafyAB5PdA5teTin8bDTFvTQUw/79/5GRUQ==", "16ac7a37-2382-448c-baef-f6aeff0d8930" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ivanovivan@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a410b6f8-b63e-4626-8793-3ac992881dee", "AQAAAAIAAYagAAAAEIdAEJeqKgLWuA7Uy3Ml3mgiZ00vMD1yRYVMZZm50jg0SULILbTKFtGQQ4T7NGR4IA==", "4fe2ac5c-c85b-45cf-a6d1-6f6657374125" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ivanovst@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68e2ab2e-2725-4868-bade-0f2d0091ec9a", "AQAAAAIAAYagAAAAEPoshEHzAgqNfWycP2BdOjIzqddMZt8CMofrze4wi2M6vvcd7ZtoiPykzLF1Z+TUzw==", "cd5f058d-600c-4bc4-a838-39db55c69238" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "jhondoe@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8366fa3b-2e17-4fa0-9e1b-5d4237b41643", "AQAAAAIAAYagAAAAEFocf8TDw0vgex//p/T4rAj+UQZ3FJnIaYIiK51i7bJMX5gO4RffCc5QG9tzT7cvZQ==", "2e16c7d5-f88d-40a9-87f4-b297171570f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "jhonson@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9aff2152-f8bc-436b-aa37-e4a40aba5383", "AQAAAAIAAYagAAAAEOlPiu2IEEajUH2sbYQod1/4GPPWkEJpxy58mp611TosCt7hpYw5fhZU+ImvGSvNDA==", "2ea76c03-71a1-40bf-9cff-3dc84700d485" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "miller@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "042e227f-a538-41c7-ae66-d4850e542914", "AQAAAAIAAYagAAAAECfVhau5JxsVf6Vm2JXPYslDKJADuGHEWHjNSYRpJOCt8u1hw5NM8Y2T8AyULEl1jw==", "d5686880-75a8-4f67-a2ca-5310e4139ac6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovai@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb28a81c-05fc-4f24-ba46-07eafdf6782c", "AQAAAAIAAYagAAAAEP4H/Vb57qO7tNUX7Ys0Ez4aO9bC8Rm5lZTS1Y2nyQflQmEM6Q5HUJviluQDMkdc/w==", "d4c89be7-50b8-4f5f-a6ae-9851ec28196c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovavanya@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7c67be6-a6b1-4a15-a441-e9ba1aa25056", "AQAAAAIAAYagAAAAEAEzJwx6aTL749rwFI/8ioOFHCfOksSDz26m2kZ60d9LX8g3lQ5G70mlk3U9tIW/rA==", "608c9bda-6ae1-43c8-b718-84af6c69b75d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovlazar@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc1e5a1c-55c1-45af-8cc8-8d3a5a4a49ef", "AQAAAAIAAYagAAAAELnF9nEq2ZFO144P99z/rygIR0dVhlvXhpHEGCUlL0SlFC2WvEELjrgZugz8oOEUCQ==", "c5f0e3d8-e755-472e-8afb-197c1f817d13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovp@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1db139c0-7021-4ec8-9122-9c95d4b18700", "AQAAAAIAAYagAAAAEGVYBoUQ7VucyD/bxfQFCOkxirqkFY+laTIj49wSRk6SDJVcty+HC3CLk5yRiGDA+w==", "97d14058-a63f-4359-98ed-76e43f487c89" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "smith@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "476fb837-5805-454a-9528-762797af125c", "AQAAAAIAAYagAAAAEKvoYgAvY1JP2ujTCjNxBP83Zh+4fRAsoDZXyTK6FfaN1zblvlQ+u4rN8gUIbLGVGg==", "2cf618ae-6e20-49ca-9c3b-2158ef06a91f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "stefanovp@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43788661-d9d6-4ac3-bc45-f3c229038768", "AQAAAAIAAYagAAAAEIk+xlpMR5fA3IW6Y7FIDlWsG0iqypJsRiq59Pi5TUCZha6LCb0gLGUtRVP26SDBag==", "151f3761-95f7-4e4e-b134-2a3a89657391" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "taylor@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5245027-50d8-426e-94a5-4b956ca2498e", "AQAAAAIAAYagAAAAED5sPyi9Xd/4oJynBsyJBVVBIfUio1wD6GonhbiFkZd2sOdNidQFrJ7G7x1QPZfecg==", "40dad66a-4638-467c-9b12-2c78641fb979" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "williams@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4b4e431-8a9c-4856-a689-9286b1d2f8c6", "AQAAAAIAAYagAAAAEJy16qxThdEUaxGkrmDDvkiAkiq30N6qZ2hjoAUfV2LutZTVkRY3msSNHHFUpcjUQQ==", "a682dc9e-2977-43fc-83f8-7517087fe0dc" });

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

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
                table: "Doctors",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
                table: "Doctors");

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

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                table: "Doctors",
                newName: "DepartmnetId");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_DepartmentId",
                table: "Doctors",
                newName: "IX_Doctors_DepartmnetId");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "brown@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cdcd23b-6ea9-42eb-bfa8-be4234056c50", "AQAAAAIAAYagAAAAEMu1HgsFS2rj0RgsGzTY9iseHqUZDH3uUJRYhMNbHFE/BHIzsRL3mNqnoU2SCQMZ/w==", "038596e9-5688-4b77-8616-3251e7a08c8b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "davissophia@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce75c6c9-1f84-47a3-a680-51e318c4e0b6", "AQAAAAIAAYagAAAAED13sGoNKiEJkXcVQmM1mN43XmT6L6Z+oM3yZhu9NpvHte2vb+qd0Yibpc43sm4rcg==", "1a468d6f-bc3d-41c3-8d7e-e700805ff3f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ivanovivan@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0966c80-00b3-4c8e-8b1f-0b022af4dc93", "AQAAAAIAAYagAAAAEJNA410r5LqRXXpFE3KMuo7TnRw22diX6nhQWNatbxTannXJylo6CUAumtgEGV/slg==", "9b33bdc7-438d-4eb8-8046-1beb37fb2bee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ivanovst@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d909600b-0b27-44fb-8d2c-2745bb5c8082", "AQAAAAIAAYagAAAAEA3X44YavGlUbJQg9ufEUBklzQ8K+S5TwRCggmBHOxvjO19GQdV33wnQP5x5gX+ehw==", "b69fdaa6-34a1-4a31-a95c-a298373398cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "jhondoe@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d74c6f13-3a38-4498-9e00-41881bebefc7", "AQAAAAIAAYagAAAAEJCjazj6eU9BUA41wnpFsdzbuR7pE+GWS4/aXyiSSoRI7EGQv9AaeL9IZc4E+IwEeQ==", "d3e09534-dc59-4d92-83ed-ab1ee8c1e715" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "jhonson@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cd071ad-c55c-4ec9-941c-673592093e45", "AQAAAAIAAYagAAAAEPTWiyS091RMR3nLzNj9wg1+92vNRSJs2EGTd/fsBfQ/qbQFzSYVgZ+VRiuePK2b8Q==", "eda2d6e6-d0fe-4486-9d4d-4c71c199a416" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "miller@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31e2b659-a391-4446-869f-ff774efbe440", "AQAAAAIAAYagAAAAEJrgDkrqCCCjhamOl8l4rozeNV+GrU7j1aOa1CS7YIOw+tqnfKojVRnJ9yFG8NLDjQ==", "043ff1a4-c62b-4a0a-b2e1-99779509fc37" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovai@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a01d08a-4e8b-4431-99ec-13448959579d", "AQAAAAIAAYagAAAAEFcB9nAjw9wllFbUkpArI098opAJDJSM9ZX7/O9p/h+gE1kJiGhsmNKeZoWFU7GtQw==", "7d2864de-66b2-41fb-8fec-7b78fdbcff23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovavanya@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4bc3703-8c8d-4aa7-8148-f2b37936b8c3", "AQAAAAIAAYagAAAAECs4aJvdfWN71mWWeF4GWoH2DcJ9IOIomVsu0dZDrzB9QLXfra52Uf9cSQC873lQQQ==", "3d4a9fb1-7b41-4f51-b8e5-d4c20c95c1ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovlazar@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b7edc90-4d23-4bda-b869-98edacb177be", "AQAAAAIAAYagAAAAEN/ee65+EkgotaqBp+eu9aWJD+C35KsJflXvLAEAJCffoFSxcx4XKY4P40ruC5DTEQ==", "3144677f-2825-4825-a010-e91553f7d428" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovp@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6308b26c-9f1e-49c5-8814-242c4c0504c1", "AQAAAAIAAYagAAAAEBrv2K+ewOdOkH/QaLxIpJrMQcbSQIBuwJCqdEZolk0j8wOi5aWakMCopAsrFCY00g==", "3cefa7e6-5ad2-4bd3-a7d8-4aeb3656f539" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "smith@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "552df82c-feea-440b-a9d4-565a48db9e46", "AQAAAAIAAYagAAAAEMPWkX1JZvAl8jLsLKtV0WAxTr/ryRZ0TyRFE4ZTU5A7BcuIpFk489Gs8OgetFKZSw==", "45fce59f-930e-45d9-baa1-7f21cae19b42" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "stefanovp@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c97de153-0fc4-4de0-8c4e-42485d474409", "AQAAAAIAAYagAAAAENQTVfcQMbLs+k4S2XJ+rK7kwuPjiAtelQVuaW0RdAmiUPZg9x0mAEDlroXJSbyMYQ==", "bb219129-cda5-4388-a691-ac2210a68c81" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "taylor@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a521e4f-38ec-4d44-8ed0-2b48e995e17f", "AQAAAAIAAYagAAAAEGhSBTKaO+8yly9GcdIL1NFfAnDARjnZ4NtffvHfXAcjpPqNCTSEPTX8MB1zQEkWLA==", "6fb84e7e-4c2e-4b6e-8092-a4c3fc82f45f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "williams@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0152a1a3-287a-4a74-bea7-b1923a03ec57", "AQAAAAIAAYagAAAAEAW2j4dnpVrZNmnnKj0WeNZGcSg5hhrSAPM9CSmWAPHU3wfXxVOrMtPMydrzzDrPWg==", "99826895-834d-40aa-acae-13244dc20c4d" });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "EmailAddress", "FullName", "IsDeleted", "PhoneNumber", "UserId" },
                values: new object[] { new Guid("c425430a-de81-4a95-88c1-e3513f1b33d4"), "ivanovst@abv.bg", "Stoian Ivanov", false, "+359883456789", "ivanovst@abv.bg" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "DepartmentId", "EGN", "EmailAddress", "FirstName", "HasMedicalInsurance", "IsDeleted", "LastName", "PhoneNumber", "RoomId", "UserId" },
                values: new object[,]
                {
                    { new Guid("4eb35d81-ab56-4fc2-ad5b-861daf593182"), "Sofi, ul.Belomorska, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6212094475", "stefanovp@abv.bg", "Petar", true, false, "Stefanov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"), "stefanovp@abv.bg" },
                    { new Guid("63afc1bc-555f-4287-b8d3-0617f5b1dc9e"), "Sofi, bul.Vitosha 123, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6102193476", "petrovlazar@abv.bg", "Lazar", true, false, "Petrov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"), "petrovlazar@abv.bg" },
                    { new Guid("c0d6b6db-888d-49f6-aa04-04d31e034ac7"), "Sofi, bul.Vitosha 3, et.7, ap.16", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "8302198562", "petrovavanya@abv.bg", "Vanya", true, false, "Petrova", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0"), "petrovavanya@abv.bg" },
                    { new Guid("d7d31152-3063-4189-8378-1274fade1d07"), "Sofi, ul.Rezovo 13, et.2, ap.6", new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "4810234567", "ivanovivan@abv.bg", "Ivan", true, false, "Ivanov", "No phone", new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac"), "ivanovivan@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("1c1218e7-6e90-4ddd-ac30-1c3727fb613a"), false, "Chiropractic Adjustment", 120.0m },
                    { new Guid("34b1292a-4584-42c9-a08a-04cdb7dc46ef"), false, "Massage Therapy", 80.0m },
                    { new Guid("34ff9ecb-0078-48a7-8a51-61942f631a1e"), false, "Physical Therapy", 100.0m },
                    { new Guid("ffc81b40-375b-407e-9727-52f16c2dcae4"), false, "Manual therapy", 170.0m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Departments_DepartmnetId",
                table: "Doctors",
                column: "DepartmnetId",
                principalTable: "Departments",
                principalColumn: "Id");
        }
    }
}
