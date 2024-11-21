using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedForeignKeyToAPplicationUserInEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Managers",
                keyColumn: "Id",
                keyValue: new Guid("73044b9a-9fda-4e3b-9848-91f542086c17"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("497482ef-2b44-48cf-86c4-6602fbde4e87"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("6984e6ce-a4bc-4164-bd68-c29c3b685555"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("e0df7feb-41ff-4293-b3c2-7ef9b6ace02e"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("f0a97740-9e98-49af-82b8-32ebc80e9aa2"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("2a1864df-a151-46a8-9158-8b8111b378b8"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("7f30e0e4-a1c1-4e83-89ec-a1115be199be"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("948e5d2a-95f9-4a10-bf74-eb536be482dc"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("97610e5c-bb3e-437b-988a-e47a3f4dc208"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "babd184c-9bab-4497-99a3-c3f1aa423a0e", "AQAAAAIAAYagAAAAECnfplmwwIylI4gO7MUueqT0RcFl1tSL+03wILgHE4cLyJXkPXV9Jn3HEaYBvuDq0g==", "0990fa52-0013-45a9-89bb-d7013db14823" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "davissophia@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44e71754-a326-44b5-8394-8bd69e7fd9a5", "AQAAAAIAAYagAAAAECB6pShd4E/+cl7icdNysI9CIFb7hIRSfd4p1cMVlg1e5zlYQ7zhRM6Ewr6X/sTMYQ==", "4eba9f3b-ecb8-4ca0-875b-cc57834daed8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ivanovivan@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0de1b5a4-84f7-4175-866f-2a00a656a535", "AQAAAAIAAYagAAAAECNqnvw+0TjBGrmZb8J/VVcIhQy9pMyTXq2wb5hbFUmZ9RcafWUVRoEcYIvZ92kncA==", "d237f925-ed2f-4857-99e3-68f4318a4dd8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ivanovst@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93085ab2-a077-4b87-ad77-454961626734", "AQAAAAIAAYagAAAAEDt4r4G0D+qmBYGtvKGOIb5Scig9gWldTfpWf74tNUfRSGU7WCUcdPUb7kRTeU4h/g==", "416b8376-2147-44bd-aea6-df5572184ef5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "jhondoe@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbf97272-2386-4efd-a028-5ef6c95bf50c", "AQAAAAIAAYagAAAAEGsgfUpktLj9ubaQjyoKYh9jO2LL5q1iLyNMOx3J7GPlH8c+U9+Gv54ojXyqWBPBvw==", "4d15ab14-eec0-4204-a2b4-3ed759442981" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "jhonson@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ffe35a5c-11a2-474a-a58e-5c74404e09cc", "AQAAAAIAAYagAAAAEGZC6+rA5H1GO3PGpJEwFn1PP/GS9/XrDxlC9jhAHby/8eIm3rtV8nWYkYcWeTujaA==", "bb115431-3c35-4e43-95f3-d0b7679b8242" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "miller@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ccdeb78-03bc-48a2-a144-50cef51872f8", "AQAAAAIAAYagAAAAEFBqSrDnC4SvE476yS6JKuLZgKngREbfJxJay5QNJICcArj3Yekd2Af1zFz1h7alsw==", "38e4e4a8-aa44-45f8-b671-2602552abfdd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovai@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15ba88d6-cec5-4d66-953e-ee4b6b04a9da", "AQAAAAIAAYagAAAAEEjkRoHyz+5ol3fS40UJQXfqmx9w6ctNVWx4Y8j7j/VI96YUkNoZHFGb9qK7NheTGA==", "406c24de-6b71-40bd-98ce-4aa7208ad77a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovavanya@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "781344b0-d0c5-46df-8d0e-4909682bb922", "AQAAAAIAAYagAAAAEBVlUnrWHKbcSmwwWvjJMgwqFI0xSJAEqtICR3tsnpEIiYl3XT0sXbjP/GjT3Xxdqg==", "aaace37b-59f8-48db-8569-b888c702ac77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovlazar@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "919d8839-43e0-4a37-a95c-05011ae4e015", "AQAAAAIAAYagAAAAEBvPHRbGrnmq0choRfLQEZXKTvzTXUxFYwTXjwANexzRQArj7cSBIDulW/76Iax+oQ==", "9e0816bf-e4f7-4f93-93b9-aeab3c9f8bed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "petrovp@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01ae1503-24e3-464f-8eae-8864ca682f49", "AQAAAAIAAYagAAAAEJT2mW4Uf71/ZUMiW7c2bnFmZhpAMOpbNXqQMyKYYT/M/AtbHZR+ffGwhA+L6wvitA==", "be3c02c0-5c6b-487e-a304-84d42fdbeb84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "smith@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f42c14be-afc7-462c-b9a4-ce7e4a68dd0e", "AQAAAAIAAYagAAAAEIIe+0YIPksjtwX2HMgaeQeRMsTK8JalaDU+z808GH/xnbDBQg4qXjraSf6yAHKa9A==", "bd291cd9-dc39-4e3c-862f-52118535e535" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "stefanovp@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5596fbd2-10e1-46b7-81a0-eea06588cba4", "AQAAAAIAAYagAAAAEDkfNAuhlO+H19QQVLQHt5o4M/OZ3toJ5R7JDFBAaEIrOl3PZH/SjtzbTUzz7G8thA==", "13849cdb-6c9d-42d0-989d-6177a7fcdab3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "taylor@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c7b9352-411f-40c1-815d-7d877c44bbca", "AQAAAAIAAYagAAAAEOkCn+M8vXuwMRu3+AvWxPw6oBH4yBFZi+xNr56LVHb1PrvrmonV8D/eERhyuUFKEg==", "06a95d79-90c7-42d6-ac16-26f95dff493d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "williams@abv.bg",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dff75c46-e740-417c-a39b-7f25ca28928f", "AQAAAAIAAYagAAAAEKvRjZHWbfFhE47QDDgIpNXlmXaFvDlTjfBVLHHkrPwPs6urEdhENxxZnTmjUmXNvw==", "9499b8ec-e938-445a-a214-877051e53331" });

            migrationBuilder.InsertData(
                table: "Managers",
                columns: new[] { "Id", "EmailAddress", "FullName", "IsDeleted", "PhoneNumber", "UserId" },
                values: new object[] { new Guid("73044b9a-9fda-4e3b-9848-91f542086c17"), "ivanovst@abv.bg", "Stoian Ivanov", false, "+359883456789", "ivanovst@abv.bg" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "DepartmentId", "EGN", "EmailAddress", "FirstName", "HasMedicalInsurance", "IsDeleted", "LastName", "PhoneNumber", "RoomId", "UserId" },
                values: new object[,]
                {
                    { new Guid("497482ef-2b44-48cf-86c4-6602fbde4e87"), "Sofi, ul.Rezovo 13, et.2, ap.6", new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "4810234567", "ivanovivan@abv.bg", "Ivan", true, false, "Ivanov", "No phone", new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac"), "ivanovivan@abv.bg" },
                    { new Guid("6984e6ce-a4bc-4164-bd68-c29c3b685555"), "Sofi, bul.Vitosha 3, et.7, ap.16", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "8302198562", "petrovavanya@abv.bg", "Vanya", true, false, "Petrova", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0"), "petrovavanya@abv.bg" },
                    { new Guid("e0df7feb-41ff-4293-b3c2-7ef9b6ace02e"), "Sofi, ul.Belomorska, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6212094475", "stefanovp@abv.bg", "Petar", true, false, "Stefanov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"), "stefanovp@abv.bg" },
                    { new Guid("f0a97740-9e98-49af-82b8-32ebc80e9aa2"), "Sofi, bul.Vitosha 123, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6102193476", "petrovlazar@abv.bg", "Lazar", true, false, "Petrov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"), "petrovlazar@abv.bg" }
                });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("2a1864df-a151-46a8-9158-8b8111b378b8"), false, "Manual therapy", 170.0m },
                    { new Guid("7f30e0e4-a1c1-4e83-89ec-a1115be199be"), false, "Physical Therapy", 100.0m },
                    { new Guid("948e5d2a-95f9-4a10-bf74-eb536be482dc"), false, "Massage Therapy", 80.0m },
                    { new Guid("97610e5c-bb3e-437b-988a-e47a3f4dc208"), false, "Chiropractic Adjustment", 120.0m }
                });
        }
    }
}
