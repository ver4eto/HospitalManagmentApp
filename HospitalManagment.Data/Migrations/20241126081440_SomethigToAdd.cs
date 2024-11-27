using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SomethigToAdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("ed566f8c-5287-4cb8-8084-04134972e6c9"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("10d0a6f5-aaf1-4ddd-8f45-b104c7630351"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("5f6c85fc-0b00-4367-9f4f-bfd007d37bfd"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("9f295abc-1156-4d79-8fed-ebeb5e52f5b9"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("ea30bbae-2fec-44e7-9308-76acbd9de08d"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("546795b1-d788-4b83-8a9f-86b4e41dffa8"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("89c48d24-281a-461d-ae13-78052f9f38b1"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("c8e9e8aa-b891-4c31-8538-a39244fb262d"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("fa8269ac-b97b-4495-b142-7df7f5dd675c"));

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "brown@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff8eff20-fcf2-4ad2-8ba8-a8ce2ae6393e", "AQAAAAIAAYagAAAAEObyKvaBzwsIpWX65LYVh4Emu8/JScOnc7swftj7GJ1UuL/nSduFsfaISWKRao+OLA==", "597f8369-bda3-4512-bb0c-297195e3fc38" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "davissophia@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f9bf1c2-fce3-4f5a-9fc1-e953c84bdca8", "AQAAAAIAAYagAAAAENR8X1fmcsvLgvajCIEwRAhODwsy8jBV9flCFfn4F96Pm7dnh7EQPBPmhKaBeJFerg==", "44b02cc6-a4d1-444e-b2de-db1bdeb16115" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ivanovivan@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29ae79bb-c821-4a70-ad59-d2a025add68b", "AQAAAAIAAYagAAAAEPQ3l0UNownx0hNXnPmPBEitE491flGF8rbdOEuAxr2ObHmXKMbjSYSI/zhjIoYbIA==", "7a6379cb-1809-486f-b09f-da8f079ce069" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ivanovst@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "894d0dbe-31cd-48b7-927a-6978b9d4edaf", "AQAAAAIAAYagAAAAEHkB6ZMV1Ya2xkmxcAH/TjaLZ9dBrGzKSEmh6xWRrZbDNTBxF1VjN9ekSeQnBI3/WQ==", "84c596bc-fabf-4713-8142-0ecc659afd4c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "jhondoe@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "295e9f45-3258-448a-ad52-1f2d3c6471e2", "AQAAAAIAAYagAAAAEPd6rr9VJzbDNS/MwvuK7zfUig0M1rttJRuIceFOsLjwH8+T3KPhOOnx5QY7x3lmCA==", "02399b9b-3589-4cd6-8010-3c70135aea5e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "jhonson@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca42a285-10b1-48f1-8e74-73f5f58fa738", "AQAAAAIAAYagAAAAEI1nVIsW0KKQ+sBEe/deTygv4IG4bGwlkNE7RZ1nvfxnhkuZ0SWwovZCfJgL6BEUGA==", "6f5c17ec-e5a6-4895-bfb9-d5fdcf5c83a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "miller@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d94641c5-526a-43b9-a5eb-f068bd87a38d", "AQAAAAIAAYagAAAAEN40lNvQpI8ExmjomMRdAKq2mHvrzLRcHsVkAdIG9I4xgRpcSFIpUkmh1xKuzyc9Cg==", "02a4395c-3620-48dd-9286-ea49b5773ab4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovai@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85399074-f899-41de-a9fb-26afc1dc8daa", "AQAAAAIAAYagAAAAEDNecbObipUho8zIsyxdDnIahX/lwyyuMDG7c0zv0Igy9EA+mRKX2LJAgAb7LOjazA==", "1c206e57-93c6-4d70-8eb7-3659c251415b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovavanya@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c52a822f-bcbc-413f-bf87-28812c3a16af", "AQAAAAIAAYagAAAAENzrH81U+/YBtd8ym6knyXeOgCZmvQeEk4Vs/2erlWq4FVn64dM/UrjDA2i+k8QZOA==", "7a6a20dc-ea11-45fe-b2c3-d27bb6561b7e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovlazar@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65371648-196e-4ecc-be8f-a12fc8ab17a5", "AQAAAAIAAYagAAAAELJV3d+HCqXlqhowkaIjAO2KIffEjIzfOshEXUGiq+JQA4cUKi/iWcJc3aOt8k4Wfg==", "bbb19d71-29e8-403b-a057-c9dd706e75ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovp@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0051a783-ace2-4bca-ab79-c9b9a5df5e85", "AQAAAAIAAYagAAAAEPvGcliuzF6CqZWAsI8JxDjRVZDOwROJIJ5s9C8U06xrdORpwh62kVPqsjTnZ7/YdA==", "40604119-2262-4075-b190-a78342d8d7fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "smith@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9958924-fa11-4000-a74a-197200ccb8e8", "AQAAAAIAAYagAAAAEK4TAEk6fcvRbaCAbUKJRQ9pSeFIlqPg8D8zEVZVtKg3XWSseIpJZotPNRXv6OL0+Q==", "698c9aa3-80bf-4849-8549-2f6b5955e658" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "stefanovp@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cd09cb4-e1fd-485b-a907-e845e7974658", "AQAAAAIAAYagAAAAEGK21ED/9fio32uxhwU7mGEgZ3YrtL0wTVuiAjzqfZim3+h8lHyZfDmCy9iz83ka7A==", "e4307473-0d95-4e83-a2f0-fdcd8fbd3124" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "taylor@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbdc928e-a35b-4989-ad2a-32dfed596261", "AQAAAAIAAYagAAAAENx6Bqf35cBlxvEzTZBkDeVPZkW19zhLVYF613U0jbWsLMGlLWnkJ2A5sivV1VCNCw==", "560dcd24-6762-4ce7-8286-3bb8d50ccd49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "williams@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc289a26-21ce-4dcc-b7aa-46033a6ca2f7", "AQAAAAIAAYagAAAAEEazYQp/XX8sNbQQEOoZenAfGbzODKht3tqy7/3gPdhrkqj12TunUo4l3INX82jswA==", "22b97da0-2db2-4353-a6b4-3fe892490229" });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "EmailAddress", "FullName", "IsDeleted", "PhoneNumber", "UserId" },
                values: new object[] { new Guid("ed566f8c-5287-4cb8-8084-04134972e6c9"), "ivanovst@abv.bg", "Stoian Ivanov", false, "+359883456789", "ivanovst@abv.bg" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "DepartmentId", "EGN", "EmailAddress", "FirstName", "HasMedicalInsurance", "IsDeleted", "LastName", "PhoneNumber", "RoomId", "UserId" },
                values: new object[,]
                {
                    { new Guid("10d0a6f5-aaf1-4ddd-8f45-b104c7630351"), "Sofi, ul.Rezovo 13, et.2, ap.6", new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "4810234567", "ivanovivan@abv.bg", "Ivan", true, false, "Ivanov", "No phone", new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac"), "ivanovivan@abv.bg" },
                    { new Guid("5f6c85fc-0b00-4367-9f4f-bfd007d37bfd"), "Sofi, ul.Belomorska, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6212094475", "stefanovp@abv.bg", "Petar", true, false, "Stefanov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"), "stefanovp@abv.bg" },
                    { new Guid("9f295abc-1156-4d79-8fed-ebeb5e52f5b9"), "Sofi, bul.Vitosha 123, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6102193476", "petrovlazar@abv.bg", "Lazar", true, false, "Petrov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"), "petrovlazar@abv.bg" },
                    { new Guid("ea30bbae-2fec-44e7-9308-76acbd9de08d"), "Sofi, bul.Vitosha 3, et.7, ap.16", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "8302198562", "petrovavanya@abv.bg", "Vanya", true, false, "Petrova", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0"), "petrovavanya@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("546795b1-d788-4b83-8a9f-86b4e41dffa8"), false, "Chiropractic Adjustment", 120.0m },
                    { new Guid("89c48d24-281a-461d-ae13-78052f9f38b1"), false, "Massage Therapy", 80.0m },
                    { new Guid("c8e9e8aa-b891-4c31-8538-a39244fb262d"), false, "Manual therapy", 170.0m },
                    { new Guid("fa8269ac-b97b-4495-b142-7df7f5dd675c"), false, "Physical Therapy", 100.0m }
                });
        }
    }
}
