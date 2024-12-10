using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedPatients : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Departments_DepartmentId",
                table: "Patients");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ea23a1-095e-475f-937e-cb3e34c4def2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81c0746e-42b4-4353-9716-681e896282f6", "AQAAAAIAAYagAAAAEPB2c/+ntqXnNgonnsZJiGpCckm1P/mz93OMdN9D70eJw4XvTPlFl0xXS+JMeJT7iw==", "c1971d6d-616d-4dce-b417-5c2de7244de8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72086fe5-a574-41cf-886c-b7112b4bba60", "AQAAAAIAAYagAAAAECP8PSRAE8PDuhK6qagWXxDnmVUV3aSPv2aCYAy4Cfz57qHVTE2y4tj699P1vIPdEw==", "dd0d153c-ba7d-4237-902d-aed70803e838" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1babbe-d5db-49b9-9624-47b9d69df236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db28104a-d4cd-4e8b-a1c5-a6e24363b309", "AQAAAAIAAYagAAAAEFOEmHRnva5PxemIjpyhHvL7fZLK4YRrfq44aIyyXfZ1Rz7rm72ozXjp2MBiRQcxNw==", "fb6b3d6a-2b01-482c-935a-d72b3ca45b54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134d8ce3-4c26-434a-90b4-f59ae5457a01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f2f76e0-032b-4d0f-a5da-7da0ff63fc76", "AQAAAAIAAYagAAAAEAnmYn6YoNgCeUG/tMvQDh5HldgYFLyjKOv5HrBJXEmIcFngFfuILI0/fvMrzeKffQ==", "f4ad06b0-fc88-4e85-94dc-713cb644878f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15050ff2-ed6c-475f-8831-f61d54a29175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d35c0532-439f-4506-86a0-768287e343e5", "AQAAAAIAAYagAAAAEIxbTd2b62M629qsptpl+CHWEeOUpeZg1CO3O1S89ruVabeRs5UuASLOCXEuGXyN0g==", "d4562a54-7e70-4f46-8ef1-10d0b4805527" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17139a72-76d4-4362-aa27-18a64cc8d285",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eebe9af-545d-4b34-83ad-548bfaf54754", "AQAAAAIAAYagAAAAEGRbCXlFk+laUF7Ir43as5EnoXCpYUG/C6vgYGIeVwxaHvno+sAvlNDZGrW7/Cq3sQ==", "8af24fec-4749-4736-a5df-ca615f852e91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e9933d-2a1b-467b-b6a2-79297246b8b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3952da39-182e-4afa-babd-7ce6fa17cc7f", "AQAAAAIAAYagAAAAEMN1COU8BNKPMeH6jpBlkML86h5smYoNu9feZvyDviGa5gE5s/cVCP/WK3+05lWbrA==", "c36b7113-eb49-4236-bf95-ce6970455e9e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18538144-c4ee-4d7d-b4eb-fd9267ca134f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c0e760d-cbbe-4917-82df-61ae2ceef847", "AQAAAAIAAYagAAAAEHbzCmZUef9qPGiVBGRCQpIGps05fGQ2f+rC4wkzHRCsg5oWZIAARXYikaDQgfvc7A==", "871cfd34-4444-4871-8f5a-927a5116a484" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23fbee5b-fbe0-49a4-b312-6a5471f79dca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ddb9380-8b4f-4195-bc93-8ee193b9dda8", "AQAAAAIAAYagAAAAEEy6ynsi1GFTT4c1V47TEcKM0CBLiGPR9KB7Wl/VGJlnnfQObnN33mW3YWT+O89rWg==", "c26a747d-d045-4704-96da-4d5083303ee6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56474114-d821-4ffe-bf43-88207a8f80c4", "AQAAAAIAAYagAAAAENu2DkGQYjuZEib7QMV7OCbmBz02d9pN1IIUrTtSVtLtnfLOKz8/tYoDV03r0pSMGw==", "69cb39a2-2fdf-4b8c-9edf-e7330b0cb691" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3110d510-2d4d-4e84-9f69-84794965586d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fcc15d5-4276-41da-8ef4-7bf6d83c3a9c", "AQAAAAIAAYagAAAAEDY9WAiDxU0aQ127E6Sv79yO03MCZvJmUjF+RZ9HLUE7SPkJVFFL0QV68ykF+7D/2g==", "bdd72389-ca1d-46de-9096-a6fd1b8436bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5494085a-78ca-417b-8e23-8c84550aa49a", "AQAAAAIAAYagAAAAEO1TClZeQD0gHDsYZrr++QqPCCGTBltGNdjtCslvEYHrgcLRLhhfx928HxX/7yqryA==", "520fd164-3470-47d5-acbd-e6f496d984bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c8870b2-58cf-4341-8ea1-d024520563d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fa823dc2-b7be-48a1-8cd8-4afcb36f6bc5", "AQAAAAIAAYagAAAAECo9hMavhDsO7krQsjPmBqhHZebk+FbCecXzNgYOuVK8r6+K8CtDb0xOODxIYASoKA==", "fd99b8f5-f2ec-4519-9637-031b6b1b0100" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c0a3b2-bf91-4c97-9a31-cb7b454c1415",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c65835ae-2f59-4c2e-a692-441dc747f220", "AQAAAAIAAYagAAAAECZhz4s5uwe19xiEWFpZCABta/SKMwJK0nAcB+lNItC4mGVviwiRwMkxPauy05fJ1A==", "21618bf4-fa17-4aa9-9376-e256f89a640e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57e1941c-1412-4384-b819-d67a19204baf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5329b37e-d00f-4528-b4e3-1a3d0cd22fdc", "AQAAAAIAAYagAAAAEIsgzSp4OUr5Ecz9SAgUnZqGHLDp8ILZZpLJzIe4j6Zto+vjflbJputOZgga/bHITQ==", "8720b08d-8265-49c0-8958-3101bfbae187" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621fb5c5-b634-405d-951b-3088891c3d5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6d6faf8-8e71-4ca7-991b-50f154543c76", "AQAAAAIAAYagAAAAEFVouX0CN+qtmp2vNNpuAgIpqoJayIaAaH9DJX/YdFvPnqB2epPLxGwHH8CSaAVY9g==", "15403e6c-7750-4af3-b012-ffa1947f5a02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76222e29-cbf5-4335-b2e4-fa6a77afeab1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87e7e3b6-44b1-48de-a1f8-94058a1e9dbf", "AQAAAAIAAYagAAAAEA8r2hsKj+L+yp8a2oLFtJbt6aJ23YyST9u7lAVA6vab+3aTnEv0V5qGjLfhyWzYpQ==", "e3e747d2-339f-44a3-8247-298d6a0c0fb8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78429ef3-6e8f-441a-8224-cf9a41152a2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4522219f-ab06-4c02-bc6f-b37d1443a999", "AQAAAAIAAYagAAAAEBclcI/SU9b9x9OE2Jkcm8U3UsFrNLUKEyc8c6c5tpXSyZWTAhM14nsoA+RQu99cpA==", "deaedc57-ad67-41e0-b80b-a17a0c7aad58" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c032bc0-04e2-4111-bbfb-a59d46791529",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dea7b720-a8a8-4961-874a-238f0fa99c3e", "AQAAAAIAAYagAAAAELSG8Gf7YUtJZUsGpdp2dI8WvQQ2kIQd4KhOZDaGePBlYONIO5j1V+leDmOkhQUovw==", "fd4e3b0e-db0b-4c9c-b252-e05096da4664" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c99b5d-6573-4514-81eb-183ace313419",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e84edde4-731f-4beb-91c5-8bbed825c10b", "AQAAAAIAAYagAAAAENSJePHLyVp4hEFu3nTHmZgBpnYWSRjwxEwVLGu+iWtlHrEFE+ZA0McI3jsAc7QV/w==", "71fbe41f-2389-4063-ac94-d5c9c61ac0ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a001bd24-5c2a-4f7a-b000-5f7bd233cd12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a3e638c-a72f-44ec-af6d-1fcd6fe77688", "AQAAAAIAAYagAAAAEJPnKrPbotIeqTqMDj8VLGe/4vR5kVPEAy4RSrQ8UPpOBW74p8voA1mgsfLZXVclrQ==", "ede55410-70fe-46f8-9bb7-d245f599be77" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15998c9-52af-4c6b-a032-b135b879e5a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df4491f2-9cfa-41df-b6bd-992f7f68460a", "AQAAAAIAAYagAAAAEMzvcwFt+82L8d9Wk6tTI/qNELvWNwgitDjGetqGqMhqm4NkX7o8/MTBQU6LiUZX3g==", "b5c348e5-ddd8-4386-b3f5-952522773f55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8d287e8-357a-40f3-893a-ed507ed6a85d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f5d5c81-203e-4d75-a266-89fece414f20", "AQAAAAIAAYagAAAAENfjBlwKXnm6w6KQ4HDadS/Yx8ohWtq4SI+I/hgYjMHbWKDAEm9OpLjTQfljaD8wGw==", "e3e0a341-c426-49bf-b046-bd7e88d8edbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558d53-8adc-45ba-bfdd-1ca9e11e7185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f08371a-e2da-4899-973d-62f978b642e2", "AQAAAAIAAYagAAAAEJH6RcKNY/AITAUF7uR6mHOxEWGktubcOoiMBLsV1lhe1rzbD2nJWz0O3AIuLTLW4Q==", "9fb46e7b-32b8-4676-84c8-cac57ea4808d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55b3e3f-6604-4bf4-a9c8-014d0c146003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbf6573f-ae73-4f29-87cf-d4ff5e0d1bd4", "AQAAAAIAAYagAAAAEM/jV8B9fFRK9eyZvGzuvWAs3yZ5Y0KtfZnkFxoDaJCoZ/fQKGGB0AcTHQYgmzW/Ag==", "197d8e84-6cf6-4652-8567-2923bd77a935" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6e29719-7856-4b5f-b5da-84ed3a292877",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dbfbf7e1-7df6-4fe6-b0bc-360708436e6c", "AQAAAAIAAYagAAAAEEhvS6qH+t5L7Ayq954RkdTs5A8sl7QUIMHTLNDf674prYw2+EXjyjqUQBgHvHFImw==", "a868be2d-2343-4b25-b14a-015b2fe0b13e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8d0d177-60a0-4925-b4ed-bb36aebb48c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19ff5e5d-42cb-451f-9243-9579e7f127c8", "AQAAAAIAAYagAAAAEAZqxWCfo5Ygi4FvhBYhCmQZHNRiW1CFkKTKElWZOjJY0ZORw0x6NuZQG/ddRgXdpA==", "fcc9ba75-f321-4348-990c-4b3438a3b210" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd5538d3-1f68-412f-9949-94edde16d8a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d21b46e-b86e-438c-b4de-cb7c8d41cb15", "AQAAAAIAAYagAAAAEK8t2fiPxKvXmavXDiiYu36VlIRuXNNT5ewGNxLOlm5g7SihBA4jkmri8dpGY2aLbQ==", "aff753f1-8357-4e36-a448-6c1bb6cee61d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fddefbf4-e1a5-42a1-a64d-e0843640267c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e686c998-392f-434e-bec0-fc7e7d098468", "AQAAAAIAAYagAAAAEGVRoSFMaSKftuiRjdzbgLjmXp+lh9FL7f6c+0SUyO7hHw1Gx40iLcUqPcefyV6Ydw==", "545f759d-0aae-4cd8-bd88-9252da880633" });

            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Id", "Address", "DepartmentId", "EGN", "EmailAddress", "FirstName", "HasMedicalInsurance", "IsDeleted", "LastName", "PhoneNumber", "RoomId", "UserId" },
                values: new object[,]
                {
                    { new Guid("134d8ce3-4c26-434a-90b4-f59ae5457a01"), "456 Maple Avenue", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "2345678901", "mary.johnson@example.com", "Mary", true, false, "Johnson", "No phone", new Guid("ff64e198-4cac-40d9-817c-ca3a62637fed"), "134d8ce3-4c26-434a-90b4-f59ae5457a01" },
                    { new Guid("15050ff2-ed6c-475f-8831-f61d54a29175"), "321 Pine Lane", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "4567890123", "patricia.brown@example.com", "Patricia", true, false, "Brown", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"), "15050ff2-ed6c-475f-8831-f61d54a29175" },
                    { new Guid("17139a72-76d4-4362-aa27-18a64cc8d285"), "789 Oak Boulevard", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "3456789012", "robert.williams@example.com", "Robert", true, false, "Williams", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"), "17139a72-76d4-4362-aa27-18a64cc8d285" },
                    { new Guid("17e9933d-2a1b-467b-b6a2-79297246b8b3"), "Sofi, ul.Rezovo 13, et.2, ap.6", new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "4810234567", "ivanovivan@abv.bg", "Ivan", true, false, "Ivanov", "No phone", new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac"), "17e9933d-2a1b-467b-b6a2-79297246b8b3" },
                    { new Guid("3110d510-2d4d-4e84-9f69-84794965586d"), "159 Walnut Avenue", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "7890123456", "michael.wilson@example.com", "Michael", true, false, "Wilson", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0"), "3110d510-2d4d-4e84-9f69-84794965586d" },
                    { new Guid("45ff5a3c-c27e-4e62-8c90-4954281d46d0"), "Sofi, ul.Rezovo 13, et.2, ap.6", new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "4810234567", "ivanovivan@abv.bg", "Ivan", true, false, "Ivanov", "No phone", new Guid("6a746a43-8fe2-4b2f-b6a3-69104089e8ac"), "45ff5a3c-c27e-4e62-8c90-4954281d46d0" },
                    { new Guid("57c0a3b2-bf91-4c97-9a31-cb7b454c1415"), "Sofi, ul.Belomorska, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6212094475", "stefanovp@abv.bg", "Petar", true, false, "Stefanov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"), "57c0a3b2-bf91-4c97-9a31-cb7b454c1415" },
                    { new Guid("621fb5c5-b634-405d-951b-3088891c3d5c"), "Sofi, bul.Vitosha 123, et.7, ap.16", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "6102193476", "petrovlazar@abv.bg", "Lazar", true, false, "Petrov", "No phone", new Guid("9f415f68-1979-4d9f-ba39-8586cc1d6c4c"), "621fb5c5-b634-405d-951b-3088891c3d5c" },
                    { new Guid("76222e29-cbf5-4335-b2e4-fa6a77afeab1"), "987 Birch Road", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "6789012345", "jennifer.miller@example.com", "Jennifer", true, false, "Miller", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0"), "76222e29-cbf5-4335-b2e4-fa6a77afeab1" },
                    { new Guid("a001bd24-5c2a-4f7a-b000-5f7bd233cd12"), "123 Elm Street", new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "1234567890", "james.anderson@example.com", "James", true, false, "Anderson", "No phone", new Guid("ff64e198-4cac-40d9-817c-ca3a62637fed"), "a001bd24-5c2a-4f7a-b000-5f7bd233cd12" },
                    { new Guid("a8d287e8-357a-40f3-893a-ed507ed6a85d"), "123 Elm Court", new Guid("66ff68b3-846e-5398-805f-06411c1bbdff"), "0123456789", "susan.anderson@example.com", "Susan", true, false, "Anderson", "No phone", new Guid("994355a8-add4-4d49-a52f-f610e4cb6893"), "a8d287e8-357a-40f3-893a-ed507ed6a85d" },
                    { new Guid("d8d0d177-60a0-4925-b4ed-bb36aebb48c4"), "159 Walnut Avenue", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "8901234567", "elizabeth.moore@example.com", "Elizabeth", true, false, "Moore", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0"), "d8d0d177-60a0-4925-b4ed-bb36aebb48c4" },
                    { new Guid("dd5538d3-1f68-412f-9949-94edde16d8a2"), "Sofi, bul.Vitosha 3, et.7, ap.16", new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "8302198562", "petrovavanya@abv.bg", "Vanya", true, false, "Petrova", "No phone", new Guid("3b85738c-1a1a-40a9-952a-465e8914a2e0"), "dd5538d3-1f68-412f-9949-94edde16d8a2" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Departments_DepartmentId",
                table: "Patients",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_Departments_DepartmentId",
                table: "Patients");

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("134d8ce3-4c26-434a-90b4-f59ae5457a01"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("15050ff2-ed6c-475f-8831-f61d54a29175"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("17139a72-76d4-4362-aa27-18a64cc8d285"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("17e9933d-2a1b-467b-b6a2-79297246b8b3"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("3110d510-2d4d-4e84-9f69-84794965586d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("45ff5a3c-c27e-4e62-8c90-4954281d46d0"));

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
                keyValue: new Guid("76222e29-cbf5-4335-b2e4-fa6a77afeab1"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("a001bd24-5c2a-4f7a-b000-5f7bd233cd12"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("a8d287e8-357a-40f3-893a-ed507ed6a85d"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("d8d0d177-60a0-4925-b4ed-bb36aebb48c4"));

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Id",
                keyValue: new Guid("dd5538d3-1f68-412f-9949-94edde16d8a2"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ea23a1-095e-475f-937e-cb3e34c4def2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25da7d3c-92db-44f5-be32-5713c47a14fc", "AQAAAAIAAYagAAAAEOQ3yRr6Tj/UHfG5iIeYAwB3M0Am/0GnPpW1E8LqGbp8To36G8iRfxY3KtNdA/fu1g==", "d4e092fb-cacc-4739-a611-cf3f4566624d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b8a51a6-d8d2-4ccc-9abd-ccb3b305b0c8", "AQAAAAIAAYagAAAAEBChlRCdMf2wcMeEyZSB/sajtoCbrIrokQxyj7cumCZej7BppAjnBjx+pR1kLxsFnA==", "e02dfe54-8f5c-440f-ad7f-7b3d4ce79955" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1babbe-d5db-49b9-9624-47b9d69df236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84ccd4c6-beff-477d-a5ac-552816c2421d", "AQAAAAIAAYagAAAAEJBhd2n2K4qwmfh+wTd65CP7CIBDtXLCDy0qIkC8DoaaKCreOYKSSN8rfwDsHtsKRA==", "8230d1b5-f1df-4fe9-8d6c-2f2e382d1c41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134d8ce3-4c26-434a-90b4-f59ae5457a01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce9d3384-076e-4aef-87c2-3ad95e6c54f5", "AQAAAAIAAYagAAAAEEArmYIgxVWjZiS94H+SIRqGaesVetK47jTS5gAlnK4B/OvJiOK0s8QSeo9ovG2yPg==", "9a031f1f-5870-4015-8fe4-13fffb720e70" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15050ff2-ed6c-475f-8831-f61d54a29175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61987f0d-f719-4f11-ab41-bbd67271b587", "AQAAAAIAAYagAAAAEAm+qk17vB2IGT76FP2rUHAYSZPk/71G56vRGz0ShEEiyPxNTEmpStzSU735I+Rx+Q==", "e0e7b2f2-4e19-4b5f-8e8e-927dc1d87714" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17139a72-76d4-4362-aa27-18a64cc8d285",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6a6392f-06cc-496f-b422-3722c5969f79", "AQAAAAIAAYagAAAAEEw8RKFrUe7qEgJhMzb5HscB6UtEhunF+84iA+6Se7rYvSGgIYy2kPuCLiQaX2dUvA==", "c34c7af8-db1d-4fbc-bf9f-c6108f708110" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e9933d-2a1b-467b-b6a2-79297246b8b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06bd174c-785d-45cf-b50d-4054c85b22db", "AQAAAAIAAYagAAAAEIuefNTpWjFAr87AoOSzedaJjB9a0ESf+ytxNhWIw7ZEkck0aXiOESn9p8S1ty4dUQ==", "8cb6dd27-657f-4f7b-a7e9-274be5baae95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18538144-c4ee-4d7d-b4eb-fd9267ca134f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b996dbf-2cb8-4e00-9ce4-d77754b8cb57", "AQAAAAIAAYagAAAAEMM+KbPdvzp97co6/5ujB4FvAk4E++RWxkkSZkG/NswEnlyHTap/fPO55fa/qtePYg==", "a53890ce-9d37-4935-bd22-3bacc4bc7d01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23fbee5b-fbe0-49a4-b312-6a5471f79dca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f0eba62-f4a0-4f37-b8f7-68ca4b13b2b7", "AQAAAAIAAYagAAAAEPvBpo5jWQ9F7wpasJBREr5H704Eaa3B81NvuJkO0wYTs8SRcRPBguLY7yrnZiBFOA==", "4b733498-4775-4175-81eb-33becee289c5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "949cb93f-df01-4871-b0d0-9ba169ba44d6", "AQAAAAIAAYagAAAAEFQ1rJGYuANRQwqW+UOApuvPqFmbw5pCbyIr3yUC+ygENwPFS5oolR2LpFhz/Bfvhw==", "5bc09dc0-c1e5-4de2-8581-cd258a853c88" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3110d510-2d4d-4e84-9f69-84794965586d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62e819f7-1983-453c-ad6d-6e65655ac4ab", "AQAAAAIAAYagAAAAEIrGByqUKd0btHs0rLj0DgqgDpw1fvGx91W4rJR/TZvC52/haVVRgbmP19iXQOjRkA==", "31c3fe02-0850-4c18-9a10-52df514f9c49" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbdfef9e-7d0a-4d0d-be65-675da00a4098", "AQAAAAIAAYagAAAAECZi0siujibK3IF/9Iy8ICGSWt6KJK4O2QlF4Qk6umAWeRbjddRHdwLNntA4d+jhHg==", "548dbecf-8359-4393-9399-a4de2bc14f9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c8870b2-58cf-4341-8ea1-d024520563d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38ff57f0-1468-4bd2-9523-5d739b4bb0b8", "AQAAAAIAAYagAAAAEMXUDsg0U9q+9iTeiVay7mcpi6nVqSXWmMFZ2xxwGfkRl+8pJH4MPocYquFFItDSgA==", "166b7971-1b64-4a98-9d37-5f5c6495626e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c0a3b2-bf91-4c97-9a31-cb7b454c1415",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24f88c58-9aed-4ebe-a8a7-57f4b9cb9568", "AQAAAAIAAYagAAAAEOyUPk0LKcLczsiUE39W2L0Ye18KhkZRGoAE5iaaOf2PwrWLPMyCq7HWV6BP9hbl+g==", "2954337f-37a6-4ab5-9667-bca3f94075c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57e1941c-1412-4384-b819-d67a19204baf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f4ce8d0-3819-487a-96fe-8a116af64203", "AQAAAAIAAYagAAAAEO3pFDEaevc+IrqvTnpj8QnajwLYPCjNj+oAS4Lf+FOVw7yGI6mOZ012OwBveB3IJw==", "55bb0c4d-fcd4-44fb-990d-9d4117af7c75" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621fb5c5-b634-405d-951b-3088891c3d5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13dc073e-004c-4ee0-9563-73a5c86cf36a", "AQAAAAIAAYagAAAAEH+FNHtPt3U7aHFf/FXctddXa7TrlTpwWuW8xswZ51N/xtM4Y3qlxolI4TqTt2eHZA==", "6feb33a7-ea6c-4c84-b764-69bc8ec46834" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76222e29-cbf5-4335-b2e4-fa6a77afeab1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f35772fd-3c25-4fe7-8656-7d51fcaa4c0f", "AQAAAAIAAYagAAAAEII1PA9GfnxQOoFju2yN3JHunzC3uyFSFznqKTkqLzR6NNWcTESvtIIPfL37+H2WJw==", "8ef8f522-7d21-4aad-b0a3-5ca56a490bb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78429ef3-6e8f-441a-8224-cf9a41152a2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "450ba5ec-8d15-42a9-89cf-3e126bc1a819", "AQAAAAIAAYagAAAAEDhP1pUxk+FZ0JT2hlHwYcR79gmf7/KW51uYA4twxpECrwAkb7p8yrxfaZt6CVXOhg==", "64bb8e4d-0ab2-4a6a-a2cd-822c7f71a51c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c032bc0-04e2-4111-bbfb-a59d46791529",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e48cf96-1240-4055-8aad-0a2d7ad2e40a", "AQAAAAIAAYagAAAAEISS3h3CFbnJDEPNV6oRTaJu/OcX6RI81qdf+owrI4lzOklRUBgMi8Qb7R5ji7goww==", "5dd1d591-5040-46f1-a061-add0c781443b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c99b5d-6573-4514-81eb-183ace313419",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b54c2493-be34-4d3e-9bd7-c03f32d4b22d", "AQAAAAIAAYagAAAAEDbLxYyy9fRh/bJOa6cQF2Bu3OoTliWbHPCgLUXSn9XeW8QQ2WuAhEY7p0kNoCH9SQ==", "ba261ad7-40e3-4b81-81cc-7b7e57091fab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a001bd24-5c2a-4f7a-b000-5f7bd233cd12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04edcb26-3c1a-458d-bb09-4f270b6d5ec9", "AQAAAAIAAYagAAAAEJjMVzse//6bCjUTvn8Wb96qFhgtLGo+E+rrMJJwnilmmp6YKGDpW0Vu7eBTX5urog==", "ca2a8af8-3906-47fe-af35-c75018bec97a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15998c9-52af-4c6b-a032-b135b879e5a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0839bf09-eb4e-4a3a-afa4-f94d2b239df1", "AQAAAAIAAYagAAAAEDw6/64Tm6xvnrUeWkT2iOhgJUApMXh4f7MLjp2dtVbp1yQoNv+guo3Uyrg64RXRYg==", "51948464-76a4-4f90-9305-de84f1a44572" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8d287e8-357a-40f3-893a-ed507ed6a85d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d3ffd7e-5990-4ba8-8003-0f3189b46f0c", "AQAAAAIAAYagAAAAELZ533LPGuBAvBK+8h4fM6CoPYdg6IxPcWfGfPd46GlwpQ8TIRVPfCw1u4jVoHhnKw==", "4c6fea80-cdb7-4178-82d1-504c525a0e41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558d53-8adc-45ba-bfdd-1ca9e11e7185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39cb89da-a194-4966-8fb8-6bb2acde5870", "AQAAAAIAAYagAAAAEEXxLV3O8807kinCtH0cF0wmknEJ0I/7lELgp4tRZbGVAbGJD8XXK+YalMCE3y9zNg==", "7b4cf661-d092-4d82-85c0-b2ec8cabe446" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55b3e3f-6604-4bf4-a9c8-014d0c146003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "368b5e1d-9060-42f3-ab8a-8236d736649a", "AQAAAAIAAYagAAAAEDgsYZf7yWLgpJL96FjscXDXafupkuFnoA+cPCLPoaejafffqIiku0TjCMC/5lxrEA==", "a8b2b163-20c1-41bc-bec6-6e435a245db3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6e29719-7856-4b5f-b5da-84ed3a292877",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e7432cb-ffb1-47d3-9e64-ce4dd2faa8ce", "AQAAAAIAAYagAAAAENdC4+tl4ccBQWkyswZxo38VLRjUYS2ecdKpj1tbCUKAN06wm5vCvt/jSW/XFWzZHw==", "b7df8c30-2ff9-4403-836e-103837487e04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8d0d177-60a0-4925-b4ed-bb36aebb48c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb53c4b8-eaae-414d-8c8f-8d55e5e34aaa", "AQAAAAIAAYagAAAAECQhLT45X2MP2s24dLQlPpQsmXFLI/a8Mchsvv1YxZ0v4mebD+uLPFn/D8SMz5dgZg==", "10d097ad-f96f-4750-a929-7082933cc62d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd5538d3-1f68-412f-9949-94edde16d8a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fba9e0c7-49f1-43bc-8c7b-a05e6f391a70", "AQAAAAIAAYagAAAAEF8wSlmDr2uZY+SBKw6UAavRmAjRFxHdvbaVChvSDjhg9XP/Zq/7aRXc1WKdisB9hQ==", "d58a7b37-e727-4a3f-bb09-c34944132c4e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fddefbf4-e1a5-42a1-a64d-e0843640267c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e49c3c9-d479-4820-9e87-8e27666ffb6b", "AQAAAAIAAYagAAAAEFMimlZJ4QWO6o989tPOlcZB1iZCwB770K7BAwhVIwthx4M/bByVY2qdW7AnZFHVFA==", "a4e12fd1-5cde-4112-a22b-73a3cba9c07b" });

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_Departments_DepartmentId",
                table: "Patients",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
