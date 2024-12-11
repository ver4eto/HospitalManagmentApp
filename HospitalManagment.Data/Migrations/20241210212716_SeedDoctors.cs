using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDoctors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
                table: "Doctors");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ea23a1-095e-475f-937e-cb3e34c4def2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e0821f6-4ca2-4c23-926d-76a54dc24286", "AQAAAAIAAYagAAAAEOOlWqa4Tzhf8t4cCZDtQ662Q0H+CmZhFhDFBdbgcQpr7fA0jQtyZQq60J7MXR64oA==", "411cc199-86ef-4421-a314-f38837cb97b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb31157e-f085-4158-95e1-c4ecc3c43673", "AQAAAAIAAYagAAAAEGU5y0dbub/SgrJc4lgvmh89sm8xeZyqRKmZTarKfDzcBkAmhNrnrGJQ9GIIqaNE4w==", "ef7d4734-786b-4149-8fed-faf2edadf5eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1babbe-d5db-49b9-9624-47b9d69df236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f80965c-3897-45db-9db1-462a21dc4355", "AQAAAAIAAYagAAAAEBPHKaJvMiz6s9aqsgUduo48+CkO81nz9eo0vSUvM/DO9GsNps0b6qmEW6KFFOXbGA==", "ef35d2be-837a-4399-83f1-dfc922a85478" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134d8ce3-4c26-434a-90b4-f59ae5457a01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed2dee38-deba-46b5-ac36-faa5985bfc2d", "AQAAAAIAAYagAAAAEMJzfuWK8yMBXZgFv15wR89GWdaXsVECo40wJzYrnKuVrtIf3ctjC5F3XSIeg2hJ5w==", "306b04f1-e485-4633-aef0-ecf8a951d4da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15050ff2-ed6c-475f-8831-f61d54a29175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b002c84c-2c0f-4d4e-8f4e-29ce39e908c5", "AQAAAAIAAYagAAAAEChduUpj1ea58iNO9Ct/qBNVnLTQrATkF4TOMeCp4ET5AoViooK7Q3w8ewMj9CIZNw==", "2861dbbf-bb74-49c4-bdf1-26644aacf50e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17139a72-76d4-4362-aa27-18a64cc8d285",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ad41ea3-0463-4f0f-b842-1300bb8c626c", "AQAAAAIAAYagAAAAEAmLOdf1995zTUGMCVw2fBeJQyBGG4wg/zacRFRlmpaYfdG1hGp073l55i/dMlOx+g==", "ccb41c5c-461e-4b36-ae55-3f5001d89269" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e9933d-2a1b-467b-b6a2-79297246b8b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d410018-cebc-4ea2-b37b-ea12af397843", "AQAAAAIAAYagAAAAEE3B6+Riz28C74MdJUchc9p6zD+k+FVeRO2WItZweByuRWM01t3hJWCwbbRZYcmm9w==", "180e23db-2ef0-43d4-8665-0e495c09a36f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18538144-c4ee-4d7d-b4eb-fd9267ca134f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccfc4353-1775-487e-aa03-027fa95e1072", "AQAAAAIAAYagAAAAEBBbjYaq8pl618dxoOCEXA4hohKfNXm3D9MXVUnHxQpedZEXEEKYNPyxN6aTZ2gneg==", "4d7b58bc-9b93-4126-90d9-be10d5358017" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23fbee5b-fbe0-49a4-b312-6a5471f79dca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8e1eae7c-5857-4b31-bb67-7b4770535757", "AQAAAAIAAYagAAAAEOS12RCx4bm5zD74WP9j1Pl/4iw4iEo92k3CetmnZm+7AHA/WpHYp9Irj5Z6aKp/Lg==", "4b43fc20-a4c4-4a9f-a045-ed733468af84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58118919-c8d6-42cd-aeb1-41563731f8ae", "AQAAAAIAAYagAAAAENBDVIJDl0X2P2nsz/XwLS0VBd7fG4xRusfpgqdbiK04a24sC2T6YK2jEwKFdLWF4Q==", "c5d3a73b-a631-4345-b80a-3079461aa88a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3110d510-2d4d-4e84-9f69-84794965586d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cb0bff6-1440-4284-99af-215925f8e6ba", "AQAAAAIAAYagAAAAEPhPmAb6PF0Mw27iYwbOkDMaf4VOTvQhanOR6XT/J52IOBvfGHXfSdmtUIKAaYHNAA==", "0d08a97f-d3ff-4491-b017-c271392437e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "636f79f3-562a-470b-9250-68df727eeaab", "AQAAAAIAAYagAAAAENKA5Jz9plTbDFwMIdHU7uCzcuOjnDZhlJGih3osiHO1eijTc+yZpwJwDvrlBAzn4g==", "675c7194-9cea-45f4-bd67-d0dd0d01cea3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c8870b2-58cf-4341-8ea1-d024520563d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c75c192-b6c0-43e7-9a65-a99f24aa7ba9", "AQAAAAIAAYagAAAAEE5lLUF/ETew6VaNt3UVhKEjo+kiXBiGJFKzHzmEikdjtR+C9vqUhsjZBTFTIHgXZA==", "23a42ba5-44dd-4008-b6f8-b50ad8f7f8e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c0a3b2-bf91-4c97-9a31-cb7b454c1415",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53e30053-f9ba-485a-81d1-d169618b2a01", "AQAAAAIAAYagAAAAECjOeq4BxomOMxb9dlbvHQf1cgzDfGtOvYYqu6+hjC26QMGUo8o13loC+2TsxYDXxQ==", "b97d9e97-5887-41c7-8ba2-7ec2fa060d6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57e1941c-1412-4384-b819-d67a19204baf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2728fa7c-39ca-4c3c-b9cf-619386c85677", "AQAAAAIAAYagAAAAEPXpOoOH6OP29Ulhdri0+2ZClCjeQOKqaghk8Su4aLQUhdqETjYTGggbhpGzba/TEw==", "7f3781eb-81e0-4386-af3a-738f04d5ed97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621fb5c5-b634-405d-951b-3088891c3d5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4dbf1bd3-6419-4b90-9675-2186891ed880", "AQAAAAIAAYagAAAAEGPwOFPLuUoLboJBVcsdWmrcZdL7wutHoKvoxwpIkG5NuhOdYkfLjLs53jIUqSVlng==", "d224e3c6-5b67-4663-b9cc-b9d8c940a685" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76222e29-cbf5-4335-b2e4-fa6a77afeab1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4ae7b5a-b0c0-4614-8c07-ae1d18b64438", "AQAAAAIAAYagAAAAEFh33Vqem503ooJX3KK5rq8AehFOWqkQBXyNCX/9sFPBH74jwo48El3vbhtC2XDSqA==", "ee6e8c82-28d1-4b01-9142-e0790db06fa7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78429ef3-6e8f-441a-8224-cf9a41152a2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "84242b82-7e6d-4517-a6bd-be9185c0b2b6", "AQAAAAIAAYagAAAAEImGDzLoaaXYYqPHdQTHPbG65CpH8k+vdfSqwd0QQGlGwoWqRudgxvOaYk0wLoykgg==", "22df6af4-4071-4269-a126-3ccbdca7dd43" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c032bc0-04e2-4111-bbfb-a59d46791529",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe41a1ec-0da0-4a09-a484-a4218572a2b2", "AQAAAAIAAYagAAAAECY9l/ZUTqPPqq/w0Bqsjla/UnMyO2KShRAjhtj47uKEfigOPMB+jwZwE/PHflwTwA==", "e10d188b-f367-4e88-bca7-4e9cca37a7d8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c99b5d-6573-4514-81eb-183ace313419",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41483ff5-6652-49c5-a0ed-3d0b4bea73e1", "AQAAAAIAAYagAAAAEKABu+GoIkoZZ2nTpqpQyAvxZVpfnSYtCF0pN4gUv3JtVsEiq+uvpqpMdMuJhiLuiQ==", "ac3a177d-eef8-4b40-8ad5-cbde5871920d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a001bd24-5c2a-4f7a-b000-5f7bd233cd12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ae84a09-68b6-40bb-9fb2-45d62ad1013a", "AQAAAAIAAYagAAAAEMUK46/8Nx1g6woqCCUv5pYsH4MClPm+1wdUGKFhud4U8xBBjjvyhrqSvKAeZC+Reg==", "03b90a3c-6344-4ab7-b137-b8ec482ba938" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15998c9-52af-4c6b-a032-b135b879e5a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "203a0d9b-4ad9-4a9c-ad0e-d9e7a3a3b124", "AQAAAAIAAYagAAAAEJOJ7+WOiD23QKThPUySrObEWN61kXWZe355OxcJ99LsAZTGDn5MKi9wIhmAHl5F7w==", "d1ff99b9-ae85-4a12-a143-b76451463e04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8d287e8-357a-40f3-893a-ed507ed6a85d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80fc373f-f25d-4098-a333-b650ce57ccaa", "AQAAAAIAAYagAAAAEHj/wRfCKLGn1JtP5vJ8L/sJaUwl/nphzhCnvrkOkkeLbV0hlLhQDrVTr9HlY6jOJg==", "a6526512-9f25-4db0-ad80-c9f29167a36b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558d53-8adc-45ba-bfdd-1ca9e11e7185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77a79605-ecae-4e44-b4a9-8b75ac3a118e", "AQAAAAIAAYagAAAAEH6m/vu7Z77be9lGlU4cCYO36OWpRZSnd+j3de7l1sa1vTldzRTbPSZLzncI7TUVUw==", "4178be58-23ba-4ae9-81ef-893f8c93cd9f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55b3e3f-6604-4bf4-a9c8-014d0c146003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "83860833-91a1-4658-8ef8-c4a418f18ebd", "AQAAAAIAAYagAAAAEDcn2oAwjB15vzuQGiyprX0ruqNPjvfQ+7dfVJzUHDphC166AXVqYKzCQ+xLKYQ+Fw==", "8fb80e49-9df2-462f-b77b-9966ddb339ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6e29719-7856-4b5f-b5da-84ed3a292877",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f43f8e14-10da-455f-9f2b-c8efeb3b97ec", "AQAAAAIAAYagAAAAEK9vKdZzOZ1Udc/d5aV8OEeGuQABCNGqDEwEgX1PUeJDMseW6qauu3z3OAdd9lBJKQ==", "fd74cd92-d1fd-4687-9897-0e4afc334d24" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8d0d177-60a0-4925-b4ed-bb36aebb48c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6c26f7a-86a7-474e-997d-131953e5accc", "AQAAAAIAAYagAAAAEAHFZe0yUzlnV+4DeovzX5S0iCHU2Nr8hRJN8jhv5DmVF2/EZoW5klRly+G4gbl6mQ==", "938ab947-071e-4dbc-a79a-3f827b324ce5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd5538d3-1f68-412f-9949-94edde16d8a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bddc764-08ff-443f-a247-cdeb62547af1", "AQAAAAIAAYagAAAAEFSPu2IfhHWFdFhzJvTXWvsgRfU5wpXZe+67krjL79cuYP7xL1/Q8niWVhp0LI/glg==", "da7380c4-43c1-4598-8051-e425eca98080" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fddefbf4-e1a5-42a1-a64d-e0843640267c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c63b8e4d-3576-4bb9-b010-9c987b520db5", "AQAAAAIAAYagAAAAEL5IKOw1l8vPaPuGIQTyurg5gJkpcnHWNhG5tx+RdcNDNveGCuE6K3yYzN9XeqFG4Q==", "74f4ad8c-2be6-4be9-a3b1-7d903b186694" });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "DepartmentId", "EmailAddress", "FirstName", "IsDeleted", "LastName", "Salary", "Specialty", "UserId" },
                values: new object[,]
                {
                    { new Guid("0b04322a-bab8-41ca-b791-ec1abdd7e8a0"), new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "petrovp@abv.bg", "Petar", false, "Petrov", 2150m, "Surgeon", "0b04322a-bab8-41ca-b791-ec1abdd7e8a0" },
                    { new Guid("18538144-c4ee-4d7d-b4eb-fd9267ca134f"), new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), "petrovai@abv.bg", "Ivana", false, "Petrova", 4150m, "Surgeon", "18538144-c4ee-4d7d-b4eb-fd9267ca134f" },
                    { new Guid("38a0afd0-c8d6-4674-b24a-db1e6861fcc8"), new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), "jhondoe@abv.bg", "John", false, "Doe", 1000m, "Neurology", "38a0afd0-c8d6-4674-b24a-db1e6861fcc8" },
                    { new Guid("57e1941c-1412-4384-b819-d67a19204baf"), new Guid("66ff68b3-846e-5398-805f-06411c1bbdff"), "angelovz@abv.bg", "Zhoro", false, "Angelov", 3750m, "Oncologyst", "57e1941c-1412-4384-b819-d67a19204baf" },
                    { new Guid("78429ef3-6e8f-441a-8224-cf9a41152a2c"), new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), "smith@abv.bg", "Alice", false, "Smith", 1200m, "Cardiology", "78429ef3-6e8f-441a-8224-cf9a41152a2c" },
                    { new Guid("a15998c9-52af-4c6b-a032-b135b879e5a7"), new Guid("3a19290a-8b6d-4551-97ae-b87ecf3f2dd2"), "jhonson@abv.bg", "Sara", false, "Johnson", 1150m, "Pediatrics", "a15998c9-52af-4c6b-a032-b135b879e5a7" },
                    { new Guid("c6e29719-7856-4b5f-b5da-84ed3a292877"), new Guid("66ff68b3-846e-5398-805f-06411c1bbdff"), "slaveykir@abv.bg", "Slavey", false, "Kirilov", 6150m, "Oncologyst", "c6e29719-7856-4b5f-b5da-84ed3a292877" },
                    { new Guid("fddefbf4-e1a5-42a1-a64d-e0843640267c"), new Guid("66ff68b3-846e-5398-805f-06411c1bbdff"), "atanasovao@abv.bg", "Olya", false, "Atanasova", 3250m, "Oncologyst", "fddefbf4-e1a5-42a1-a64d-e0843640267c" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
                table: "Doctors",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
                table: "Doctors");

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("0b04322a-bab8-41ca-b791-ec1abdd7e8a0"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("18538144-c4ee-4d7d-b4eb-fd9267ca134f"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("38a0afd0-c8d6-4674-b24a-db1e6861fcc8"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("57e1941c-1412-4384-b819-d67a19204baf"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("78429ef3-6e8f-441a-8224-cf9a41152a2c"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("a15998c9-52af-4c6b-a032-b135b879e5a7"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("c6e29719-7856-4b5f-b5da-84ed3a292877"));

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: new Guid("fddefbf4-e1a5-42a1-a64d-e0843640267c"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ea23a1-095e-475f-937e-cb3e34c4def2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88911ca5-4104-49d2-8744-89284cb782b6", "AQAAAAIAAYagAAAAEBkwUT0jWxWeInoaaBw2Xat9gQwjjQQbl0ZxPl+H8LxlvfPgkaCvC18tgM43u7avEQ==", "01c01dd8-f773-4b68-9b06-c9e7654db8c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98babab3-220a-4894-aa94-bc31af5402d8", "AQAAAAIAAYagAAAAEFFFLZB1W+xAbK7lG38s+wGieVEBqOc0SMxkCSQTVZQxnt0jE0Mr0inlxIo/EKMuNQ==", "9089a40b-bf5c-4182-a54d-b441c2ea62a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1babbe-d5db-49b9-9624-47b9d69df236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d76985e2-1b7b-4cd3-b5d7-cb19c00f56d1", "AQAAAAIAAYagAAAAEOlJxorZ0Y4S75CATQ0rTKAQapTQ650Rmtm5GH+liAfz1JWVncawDi+ggFqHDx0IyA==", "3c9e8e1e-6fb8-4c04-9b50-fb04658c42ae" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134d8ce3-4c26-434a-90b4-f59ae5457a01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18016791-26b9-4161-ac2f-c12ffab3c71c", "AQAAAAIAAYagAAAAEB884O3Tz577/pspcSdxEHx/xqDio1c7zk41ZixoOwWm9rBNneDkB23PyBccEemVXg==", "28079c06-da63-4eb9-bf93-836191a034c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15050ff2-ed6c-475f-8831-f61d54a29175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d515c012-2471-4480-ba58-c372c93f22ee", "AQAAAAIAAYagAAAAEFHPXVVay5iAgUUo0wghoprkOtV7vTEgqEY04eouON3A//pUdCo8rm2seSODgKcYlg==", "03651d70-2a2b-4e9b-b38b-cb2b758e739f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17139a72-76d4-4362-aa27-18a64cc8d285",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7850c2b2-487d-4ec3-961c-548f7126cb87", "AQAAAAIAAYagAAAAEM0dAb6zEOWC6zN9Kf+U1qfI6XGbfRX+mliwingLTwaneCRMS1GEdVDjjcMSEDKacg==", "da65a761-aaaa-420d-906f-ec942b90849d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e9933d-2a1b-467b-b6a2-79297246b8b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3396cec9-4c17-45f6-9c68-0324909dfa86", "AQAAAAIAAYagAAAAEGwdiRAudstfdy0t83N1v/ZumJFEycjjKnxLl9xupDbIYdy8L5D4C9kxs8CV3IxHZg==", "973ce8dc-53bf-4250-b6b8-b7be7d97c54c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18538144-c4ee-4d7d-b4eb-fd9267ca134f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7feae83-c233-479d-88df-52a813a8c518", "AQAAAAIAAYagAAAAEON3deck3sqtjolVO0kQgxFjJqBS7u3o4Pvrj5aa3Fie3uTvmZ+RdvT2VSmC0k3MNw==", "3abd5928-15e8-4287-9642-381fef7b7d91" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23fbee5b-fbe0-49a4-b312-6a5471f79dca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ff1db05-eae9-4938-a28f-02f027ea46b3", "AQAAAAIAAYagAAAAECIjMYqvEwFvJad6fLX5Var35rq6OginKbEzCnCzS9baIzvgC6Y3nejxMldI59hoLQ==", "5defb4cf-0901-4490-97d6-5625e89906d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a04901e9-8e99-4bbc-b833-c40a4b76aac3", "AQAAAAIAAYagAAAAEFIawdfa1GhhxKWKUYE5fTnucOn78FNIUyhiAI/f0SHBxpOETD4otplxGIs9xZxh9A==", "abeefb00-27fd-4ea7-bb3c-53f3c010a436" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3110d510-2d4d-4e84-9f69-84794965586d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcf766f9-2ac0-4247-9c38-f1853c9cc693", "AQAAAAIAAYagAAAAEL7LcjmLaXepols58/tkVYuOLY9Wm2ZHZzYU7A3DtaegCxNby2r04N6G8tSpsA85RA==", "9b18d0c1-7378-4ada-a436-81956c840a84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45561348-943f-4c7c-8f0b-7862e1315067", "AQAAAAIAAYagAAAAEGcNNuUmOaaE+ZAG9g+GUV9CZfVxZPPZ0vzvusXibyfxrKHBGhnTZG58+pGzTVM3hA==", "b00c4ad3-1f15-4c5f-a70a-1a8b86565bd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c8870b2-58cf-4341-8ea1-d024520563d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7145c371-4f9c-46ba-be3c-c128c089bdd5", "AQAAAAIAAYagAAAAENKCoOyWSG2iaMqNZs3PS+unBxGRR5Nl4gFIZ88fA9AKUJAh7a0Ku08JY1r1WfqJPw==", "7c5a7154-2775-4218-bd1c-e5ec7ccc8fa2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c0a3b2-bf91-4c97-9a31-cb7b454c1415",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57d30701-4bdf-4d13-a65c-3f97470cedfa", "AQAAAAIAAYagAAAAEJ5HeKrjfwEuUANc2omeLeJCLBg++vipU0Cxkd3VwS44osmaOc1dksuoCod2OYed/A==", "e51ed749-dfdf-4de5-a527-2d43dc395f78" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57e1941c-1412-4384-b819-d67a19204baf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7be0bb6-4876-4ad5-b481-e264fc010ba8", "AQAAAAIAAYagAAAAEDtNdDjU8i67rBhr134VPJwzkeEym5ECHI5f8BiV0yX10jRUxJ6kHZGS3BeJUPOWVw==", "64fa92b8-7934-462b-a1ef-6608ee421ac5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621fb5c5-b634-405d-951b-3088891c3d5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39f6a4b9-9ff1-4ac6-8dba-495afdf313a9", "AQAAAAIAAYagAAAAEG5u4B8IW0jpzpn2VJAsdQsTtTcuJnPi8kNUsZujIuC6CPT0l0XfYxb0aLIEZuH1WQ==", "9aa9ba3f-517e-4521-a534-9bd635a213dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76222e29-cbf5-4335-b2e4-fa6a77afeab1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cd42d04-62b4-4b49-9a09-7ca1b32a409a", "AQAAAAIAAYagAAAAENAE3wVzSkKT4SlSgGi4PzANy31zcRGIOqXMbzRGGDugSdrTGhNzJbZQHnwzc9v2nw==", "8fac8857-7edd-4587-9231-f827c2b3089c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78429ef3-6e8f-441a-8224-cf9a41152a2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d98aa31-05d5-4512-9d3f-a0aaa33b7b34", "AQAAAAIAAYagAAAAEJ7ZRbrg63RACz7Sj17YtOus3KBMC5kzpYpiJ1Zj/LnM5RMaB8jJvFzW04Gn7Op9zQ==", "d75c345e-4655-495a-829e-4c445718a2b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c032bc0-04e2-4111-bbfb-a59d46791529",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e94e6724-0d6d-443b-a71c-e937f082654a", "AQAAAAIAAYagAAAAEDKx26n9C1oID6cKz0lUFCV84Vhigw/6SQ9UHKmBoHLADwbYbctpUeblYCGqqRRZlQ==", "5025f4ee-ce8e-44b8-8f64-20c42580e9d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c99b5d-6573-4514-81eb-183ace313419",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01ea237a-8e21-43c3-896e-5387b0004f79", "AQAAAAIAAYagAAAAEEADTBJpJ8Ua/EYRjh3dn0BcEayd6CCDE2Gwn6qyGEdu7fjhBLTWTbQ7ppJNph7jpA==", "42b4ba76-e049-4f12-b680-f42a0efcaa17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a001bd24-5c2a-4f7a-b000-5f7bd233cd12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ebddc15-e430-4ecb-b9f6-82c21557eba4", "AQAAAAIAAYagAAAAEJdC5SiNAlKT4DzoF/KSQb2eAXfKqZIQ3o3UnTyD7lPOuh5aawDxgdDwLJSSk/aqaw==", "b9da10e2-bd65-4fbf-8073-4d63ae4c91d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15998c9-52af-4c6b-a032-b135b879e5a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aa03c790-667d-43b9-b85a-b34d23323970", "AQAAAAIAAYagAAAAEBj32kQmWR+lvSce7oaw+ethJTRJ0VXMvwL4OKnyl3NbvfU4norpTj46B93LFXhoZg==", "55fc8507-4b41-4ef6-b4ce-44d84febe88c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8d287e8-357a-40f3-893a-ed507ed6a85d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4eadefb-aa82-42f0-aca5-6127bf957aa9", "AQAAAAIAAYagAAAAEFc1pZyFLoVYtbyymMwrX3/+uN1rEL72jGoUmYBsXHbCsqwl4J/cdVb9V56TWIupAQ==", "73abac39-51aa-4189-b793-f26a96197f36" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558d53-8adc-45ba-bfdd-1ca9e11e7185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32f17596-f575-4419-ae61-d85d33a6b414", "AQAAAAIAAYagAAAAEIMK5Q9YxR0hdKOkdiLP0A7BHLA7XT1TE1d9vRyiBEzP5+680gfQmo/2yF+AZYjSjA==", "d61b7308-1f11-4207-a9aa-fe938d12eb46" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55b3e3f-6604-4bf4-a9c8-014d0c146003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb108f83-9e0d-4185-8538-9da62be355f9", "AQAAAAIAAYagAAAAEGOMQrFo/KPI/zJ+jufSBRNHWbiNaE6UQcJR31Y0R8GbLwKMVo3tlIfptGxFwwMYlQ==", "598d89ad-46bb-4a72-a80a-0d660b35c2c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6e29719-7856-4b5f-b5da-84ed3a292877",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ad706c1-fd27-4727-9bd1-edc0eda96c3d", "AQAAAAIAAYagAAAAEA3vFGxqWPDnVkW87mxBXRIb8vLbw1hWZRbf1RQfntC16JhVKgpdVnnPeUIPqHHZeA==", "35d0050f-b9d5-4594-80f5-3003c7a91fb1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8d0d177-60a0-4925-b4ed-bb36aebb48c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f14d6836-3905-4723-b126-ac59569dc279", "AQAAAAIAAYagAAAAEBKqMa138c2jnS0rVjBR2Ac7jetaRCNVlpz/5cNoYWpxg3OXtbAXm7GgJjGIBTjQrQ==", "c33acc10-187e-4a45-bd48-7a6d4a50f199" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd5538d3-1f68-412f-9949-94edde16d8a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "229b7742-6c91-4ecd-8119-ff5f1e96a144", "AQAAAAIAAYagAAAAEEN0GqPvqtcPl1h6KZENQUNpfjcmDtERXpXsubYQk9CcIYThuhlMI2lEchV4ym/gWQ==", "cfc04573-6fe0-412c-9289-77110ac429a0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fddefbf4-e1a5-42a1-a64d-e0843640267c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f751e37f-d3ce-4bb5-aa16-36430fb434b5", "AQAAAAIAAYagAAAAEAVx7aCJL6LWu2DWGoVVayWClMMDcfod9MgJngd7wpxwqHjkTfGiNLxo++yLjaBAMQ==", "353fcf90-8866-4c9f-a0d9-cbe14098b3ae" });

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_Departments_DepartmentId",
                table: "Doctors",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
