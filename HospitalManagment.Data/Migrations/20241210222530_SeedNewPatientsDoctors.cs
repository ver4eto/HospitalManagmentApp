using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedNewPatientsDoctors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientsDoctors_Doctors_DoctorId",
                table: "PatientsDoctors");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ea23a1-095e-475f-937e-cb3e34c4def2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d90331a1-2446-498d-805b-4d15bda059af", "AQAAAAIAAYagAAAAEBuWMAhh6ogjkIEKOskpFkIWkYEqUGS4uE5HNUVJiR7KvzS3sHF79zGITmPK3Iv9yw==", "3d0c5850-e7e4-47c5-b72b-779ed98e0316" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1375be3-2cae-4b83-be75-a44fa38eefd4", "AQAAAAIAAYagAAAAEAO9slCl5/8kxQxH6Rnp53SqXY8XXkpBcOnqiBntBmKMVDiofsIBtdz6a7mU4KQwvw==", "3d27724d-f203-45b8-944d-3cd012224e4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1babbe-d5db-49b9-9624-47b9d69df236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee112903-142d-4dfe-a7ef-abd74116385e", "AQAAAAIAAYagAAAAEMhq7flysM3swyNNVNlHuydD304/jgLt6XE24cWr7MgzploaUV/vQvVXFJtBTPzjqw==", "2c5877e1-de47-425c-9c21-3dffb8650114" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134d8ce3-4c26-434a-90b4-f59ae5457a01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "072ac36f-71f5-44ec-a846-715ac11facb7", "AQAAAAIAAYagAAAAEB6NM0Kkjp0pPB21LjJWM7ZtpWsqQAHQa4LAE0S3OBUfCAmnDJ4NhcMgdqViZpejcA==", "cd04ca30-ddf9-45ec-8268-9a61a0a197eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15050ff2-ed6c-475f-8831-f61d54a29175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb74396c-d1a3-4154-9499-3390957b469b", "AQAAAAIAAYagAAAAENw5kac+mBhvmW1o59fsW8kkUfgnwXNmgiGspe5+ejkG2VggDYC50jQGiAwkDw1wEg==", "2036af03-33d6-4809-b718-6583cc03bfd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17139a72-76d4-4362-aa27-18a64cc8d285",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95700ec6-2e8b-405c-90eb-51a10398332d", "AQAAAAIAAYagAAAAEKwiBUcUHML8Nez89B9W/pxGhtdioewt37FeQozblcMo3Tkcyw6E8ZSnIqtFJHAMOw==", "bb54f961-c569-4a31-bc5d-4fc313bd6a23" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e9933d-2a1b-467b-b6a2-79297246b8b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8778aabc-214a-4454-b462-12f2647b1612", "AQAAAAIAAYagAAAAELNgf/bK5VIpoWjmK2iWQxYHmJP3etYlAppp4seKwyGjpTTY+GXGJ6QMVANwazt+iA==", "25dd6dd0-cd0b-4bd3-88e4-4bb466e74242" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18538144-c4ee-4d7d-b4eb-fd9267ca134f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0703128-aba3-4e28-96a5-9867aae68e46", "AQAAAAIAAYagAAAAEErjCyMeL2MCqZnL4lk9vuKYHY2r6exfA9e0KuLK0JwFZqAISidQzE6XYSAKDO0rfA==", "8822984e-bedb-40da-aeab-eebf426074c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23fbee5b-fbe0-49a4-b312-6a5471f79dca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87393628-999d-412b-94e0-d4cfa74af63a", "AQAAAAIAAYagAAAAEPHhv8eNsUm/oknddKfXFoFGQYGItOiS6YH4mWZ6PLtRIcCni+GFG/A05ENw2fBXpg==", "f1c460d5-d447-48a2-998f-702e5479edb7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30dfa524-f228-47be-94f5-06f8956265d2", "AQAAAAIAAYagAAAAEJJbDOPOznETCTyhuwyQKErGhq38g5KZOVJqqKalCZuqN9B1VR97IQwg+YF1RhCb5A==", "d85a0354-430c-4664-98f1-1833cd949629" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3110d510-2d4d-4e84-9f69-84794965586d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7dcc3fd-e212-4912-bdb9-3ab0165ef3c0", "AQAAAAIAAYagAAAAEMIJHTImfWe6cTSwhW2HpQotrr10wt0W6bgn+vCXCVthknx9OXRcy++8IYe++yre4g==", "33c09b81-6e60-4b22-98ad-a295681f98c1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d762994-22b2-4fff-b38d-65295429c994", "AQAAAAIAAYagAAAAEI1lyEOKzKZ9SSPfiiiMDjMx6vkGQEC0N+6Z/7eQ8bQc9tvqrCDS0pfWw/EDU8qqIw==", "c1f7056f-df99-4768-8e97-8daae0a8af1b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c8870b2-58cf-4341-8ea1-d024520563d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba638ec9-fff2-43c4-af3d-c0207cc0f439", "AQAAAAIAAYagAAAAEHQHAbu03VxTVawx+zFOLfgCUFi8R4s8VfNIx2LMcxJYWCcg8rM4iyuW0K+Jehcy0w==", "857257ab-565a-4fcf-bc2e-447e71b8ae41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c0a3b2-bf91-4c97-9a31-cb7b454c1415",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b90bf5d-5de5-4345-b83e-01b673885d60", "AQAAAAIAAYagAAAAEO8qjd2atldEc9kHGsdxUDurg2RGWCWbOlICVOVb1hQJxb39p1hJHgGK27aHYgIMcA==", "a85f02c2-eded-4b73-8993-444e226d8137" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57e1941c-1412-4384-b819-d67a19204baf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af72ed65-a3b7-435d-950d-e413a3b53d77", "AQAAAAIAAYagAAAAEC1yPsikuWe2zFrnGy9vh4FbMy80mhelOAIoC8eGZhrg4EHBkcfyHU5svguzqxMGQQ==", "6e6d899f-19f9-4b31-b9f0-bd95a39fea97" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621fb5c5-b634-405d-951b-3088891c3d5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f10d4a9-1eab-48b3-818a-5c7acd8fd707", "AQAAAAIAAYagAAAAEIJXHpfUC/Z/Wl6vALReRPCwea/nf4F5/xKLmis8vqC5MZY4DTB/aB9y1VGwhKnl9Q==", "60303ac2-ea44-4be2-af55-d2d94298b0b7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76222e29-cbf5-4335-b2e4-fa6a77afeab1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24b71c1d-fb2d-48f0-adc9-28971462f4d0", "AQAAAAIAAYagAAAAENqyjB5nAtx0+By/A55WZX2XxiYZPoQ8i/AyR3Mxfhv3tVEHXb2sA3IpaKK76GK7lg==", "2a0b2d1c-10df-4ea9-a2bb-bee93c8938d4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78429ef3-6e8f-441a-8224-cf9a41152a2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a2af997-55bc-47e6-b9cb-623e500b378e", "AQAAAAIAAYagAAAAEMHUUmvII98MwyMgAu8GKQpTcgYSjjDrmLoYoR9USjBy3UQR8FSJm6dCcLi8k9uZzQ==", "a2cc4c02-a19b-45cf-b362-24ec19c90686" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c032bc0-04e2-4111-bbfb-a59d46791529",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc1f0d83-3b84-4743-b399-512d0994117c", "AQAAAAIAAYagAAAAEGyDhE2AkGetrcopMRw93bctghr9Ed51I0xejoUrmokji9Sx5c9GYdKIFnVnaklqhQ==", "bcc5b916-0fb7-41b6-bca7-04d100ee73d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c99b5d-6573-4514-81eb-183ace313419",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d8c276a-8a15-49ca-ba6b-d81ae6b08650", "AQAAAAIAAYagAAAAEOaM7ZkmVreELbGb1Axw8wxY82/4E1ZH+vSi0zPCZO4XMq2N5mf0FSn5sgK85P0EeQ==", "2b76b4f6-5484-4f96-856d-76163c1516e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a001bd24-5c2a-4f7a-b000-5f7bd233cd12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd4e7906-61b3-4da5-98cf-3b6c4324fb59", "AQAAAAIAAYagAAAAEAJHRuDu8ouMoJR8plGvn6jshVc6DVO52NvaPFfdyFJJ/82yQMpHPY8UOjfS05sssQ==", "c2f630f1-94e3-461e-9030-09a1c06442cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15998c9-52af-4c6b-a032-b135b879e5a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea555e40-e515-4982-aaf4-de7a3386a3db", "AQAAAAIAAYagAAAAEOCN7SJsya2VAm6IjDi09a8y20Xzemh14x2/N0avMVo5pisx2iaI5xpJrv4J2uppKQ==", "03880f85-7acc-4c16-b193-58008f40221d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8d287e8-357a-40f3-893a-ed507ed6a85d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77efee74-8767-44f6-890d-a9fb16e1fe36", "AQAAAAIAAYagAAAAEKvocJxLbb3XGYMpDw8Og6k8nOMJa+xex11Lpy67Hej1M7Q7C8Q67njwy0QDijsVMw==", "5552211e-3e8e-4b71-978c-71d25f7bb4c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558d53-8adc-45ba-bfdd-1ca9e11e7185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad4c36f0-6382-49ea-bcee-c82e1f600242", "AQAAAAIAAYagAAAAEEhAyeRjIP0p+DGDoZ+2Eu1wY8SZO7777ZG4nf+DYj8lHIcYTOVs9iaQ3bkERpDaLg==", "12d5557e-0f68-4fa1-b932-db36928de477" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55b3e3f-6604-4bf4-a9c8-014d0c146003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d17dd6ea-0764-45f0-8eb8-b85a5a631d81", "AQAAAAIAAYagAAAAELP0cU8CqnOH3XPfKUB/bEvkf7VwsAceYSiiAF4CFejRQVP+p170bQ9KQ6hUaXj/0A==", "5c72720c-388e-4a94-84aa-32bc2f07931e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6e29719-7856-4b5f-b5da-84ed3a292877",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1776d0fd-dc6a-4e04-803d-f467e4df05f8", "AQAAAAIAAYagAAAAEK//uPNVeHzeja0oYexIGDHHhIrGV+7jWFpWOzMh2PH4mkA3bye9rMVQh+rI+TvGDQ==", "594cf32c-8de7-4905-82e1-f7edb11d4091" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8d0d177-60a0-4925-b4ed-bb36aebb48c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac421ca1-e333-4ca7-b465-5fb121389a1b", "AQAAAAIAAYagAAAAEAPpueuFgsuXqEKPAoood80hydRq3FpkaFmd6qZVmvFrbXFn19GZVfI7p51Z3wa4cA==", "2c38a6d8-f7da-4d6f-b7bd-7a21ee7b23be" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd5538d3-1f68-412f-9949-94edde16d8a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33f3321c-8256-4fea-a682-8c8b8380146c", "AQAAAAIAAYagAAAAECdayd3/zy+OE7/7OxhzS0oypZz4qJTFsxrTcPDTJ/0rvOci10sTp4sjS/PSPubKdQ==", "76edaec5-5961-4e0e-a63d-7e795828f8b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fddefbf4-e1a5-42a1-a64d-e0843640267c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a19c8dc-45bc-4265-a5de-4f4118cdcc01", "AQAAAAIAAYagAAAAENOeWpjLOWTq04yiAgymwYao9UuUyxy7HXJU94ck39/tJaSKydb555L5PUZDEGcWNg==", "f812eeea-1a54-4ea8-afe3-6f34d9165b9e" });

            migrationBuilder.InsertData(
                table: "PatientsDoctors",
                columns: new[] { "DoctorId", "PatientId" },
                values: new object[,]
                {
                    { new Guid("a15998c9-52af-4c6b-a032-b135b879e5a7"), new Guid("134d8ce3-4c26-434a-90b4-f59ae5457a01") },
                    { new Guid("a15998c9-52af-4c6b-a032-b135b879e5a7"), new Guid("15050ff2-ed6c-475f-8831-f61d54a29175") },
                    { new Guid("78429ef3-6e8f-441a-8224-cf9a41152a2c"), new Guid("17139a72-76d4-4362-aa27-18a64cc8d285") },
                    { new Guid("38a0afd0-c8d6-4674-b24a-db1e6861fcc8"), new Guid("17e9933d-2a1b-467b-b6a2-79297246b8b3") },
                    { new Guid("0b04322a-bab8-41ca-b791-ec1abdd7e8a0"), new Guid("3110d510-2d4d-4e84-9f69-84794965586d") },
                    { new Guid("0b04322a-bab8-41ca-b791-ec1abdd7e8a0"), new Guid("76222e29-cbf5-4335-b2e4-fa6a77afeab1") },
                    { new Guid("a15998c9-52af-4c6b-a032-b135b879e5a7"), new Guid("a001bd24-5c2a-4f7a-b000-5f7bd233cd12") },
                    { new Guid("18538144-c4ee-4d7d-b4eb-fd9267ca134f"), new Guid("d8d0d177-60a0-4925-b4ed-bb36aebb48c4") },
                    { new Guid("78429ef3-6e8f-441a-8224-cf9a41152a2c"), new Guid("dd5538d3-1f68-412f-9949-94edde16d8a2") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PatientsDoctors_Doctors_DoctorId",
                table: "PatientsDoctors",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PatientsDoctors_Doctors_DoctorId",
                table: "PatientsDoctors");

            migrationBuilder.DeleteData(
                table: "PatientsDoctors",
                keyColumns: new[] { "DoctorId", "PatientId" },
                keyValues: new object[] { new Guid("a15998c9-52af-4c6b-a032-b135b879e5a7"), new Guid("134d8ce3-4c26-434a-90b4-f59ae5457a01") });

            migrationBuilder.DeleteData(
                table: "PatientsDoctors",
                keyColumns: new[] { "DoctorId", "PatientId" },
                keyValues: new object[] { new Guid("a15998c9-52af-4c6b-a032-b135b879e5a7"), new Guid("15050ff2-ed6c-475f-8831-f61d54a29175") });

            migrationBuilder.DeleteData(
                table: "PatientsDoctors",
                keyColumns: new[] { "DoctorId", "PatientId" },
                keyValues: new object[] { new Guid("78429ef3-6e8f-441a-8224-cf9a41152a2c"), new Guid("17139a72-76d4-4362-aa27-18a64cc8d285") });

            migrationBuilder.DeleteData(
                table: "PatientsDoctors",
                keyColumns: new[] { "DoctorId", "PatientId" },
                keyValues: new object[] { new Guid("38a0afd0-c8d6-4674-b24a-db1e6861fcc8"), new Guid("17e9933d-2a1b-467b-b6a2-79297246b8b3") });

            migrationBuilder.DeleteData(
                table: "PatientsDoctors",
                keyColumns: new[] { "DoctorId", "PatientId" },
                keyValues: new object[] { new Guid("0b04322a-bab8-41ca-b791-ec1abdd7e8a0"), new Guid("3110d510-2d4d-4e84-9f69-84794965586d") });

            migrationBuilder.DeleteData(
                table: "PatientsDoctors",
                keyColumns: new[] { "DoctorId", "PatientId" },
                keyValues: new object[] { new Guid("0b04322a-bab8-41ca-b791-ec1abdd7e8a0"), new Guid("76222e29-cbf5-4335-b2e4-fa6a77afeab1") });

            migrationBuilder.DeleteData(
                table: "PatientsDoctors",
                keyColumns: new[] { "DoctorId", "PatientId" },
                keyValues: new object[] { new Guid("a15998c9-52af-4c6b-a032-b135b879e5a7"), new Guid("a001bd24-5c2a-4f7a-b000-5f7bd233cd12") });

            migrationBuilder.DeleteData(
                table: "PatientsDoctors",
                keyColumns: new[] { "DoctorId", "PatientId" },
                keyValues: new object[] { new Guid("18538144-c4ee-4d7d-b4eb-fd9267ca134f"), new Guid("d8d0d177-60a0-4925-b4ed-bb36aebb48c4") });

            migrationBuilder.DeleteData(
                table: "PatientsDoctors",
                keyColumns: new[] { "DoctorId", "PatientId" },
                keyValues: new object[] { new Guid("78429ef3-6e8f-441a-8224-cf9a41152a2c"), new Guid("dd5538d3-1f68-412f-9949-94edde16d8a2") });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ea23a1-095e-475f-937e-cb3e34c4def2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3e46271-bf2e-41a1-86c3-50bd1578d177", "AQAAAAIAAYagAAAAEOpLGxm/hOPzo/q230lQgRP4d2Ghgp17HYNhZ+SkDMF7lbDcNrfbeInHr1OPRGWr9A==", "cf306d79-31ab-4873-adec-6990837680f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16827408-8d9b-43c1-a92e-b4167d8978ce", "AQAAAAIAAYagAAAAEHgTX0O/PbinuJRsjkJq/YQitd7wN8uDqRWvQZYmXrCLJpIL4/24sibNSFsDZyNy7w==", "cc57c26e-5664-4488-b13a-52a8ba884d2f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1babbe-d5db-49b9-9624-47b9d69df236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d54bd571-b1e0-46c2-b04e-1d0354b25cf0", "AQAAAAIAAYagAAAAEBptmjTF4l74Erdf/85lxJtYR2RDDDNvGId0IS9IQqSaAQ8LX4oeMVUf7ihHqRxmfA==", "606c1726-5f8d-4a3e-a98d-243a091b9577" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134d8ce3-4c26-434a-90b4-f59ae5457a01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9645afe-6e21-4876-8f2d-15929df93767", "AQAAAAIAAYagAAAAEC0FfnqguSAnrPK7tgPFktbvdzWx46N6yMK23390/SKe1HSkRNzWmTfGKNuI1mGbrg==", "73e8026f-f6eb-431d-9efc-daa3c5dad2eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15050ff2-ed6c-475f-8831-f61d54a29175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "379e44e1-ddf1-41c9-8355-32b949c4fd4d", "AQAAAAIAAYagAAAAEAk0U1jFqljVfsWD2UCHRq5SjjCCJpafEdNxpU+Lh8psKNc3TbeQF87pRYuWyL3kUQ==", "10afb9d0-2e62-489d-a389-341e9696820e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17139a72-76d4-4362-aa27-18a64cc8d285",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "91411f64-0a7f-4a98-966d-967fceff5698", "AQAAAAIAAYagAAAAEEhjYuLFwWPGhrosrNE1Gie1QLoHB1QBYkUNQxnsHrKGNEVT/lNAH+iJ99UaXr/gjw==", "85059e91-e66e-4d5d-8183-43cf80eb9611" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e9933d-2a1b-467b-b6a2-79297246b8b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d01a698-81a4-493c-a1b8-b0d176fbef2e", "AQAAAAIAAYagAAAAEELrSB9HEydndf9p6mYMb3xu0oho5i9p0yW0X7Ep6AAhgKLPTNBowHZrtuSDgLSvqQ==", "6014502f-5cc6-4724-9f26-62127d12bf15" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18538144-c4ee-4d7d-b4eb-fd9267ca134f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb80280b-ab2f-4023-985e-98a85cbc5b6c", "AQAAAAIAAYagAAAAEBZ4j/RJEaitYtmfFvQEsMS/xIA5NkZTlpKNVJSPFK0zsSBT43hAl4UOcdDaRfo6ww==", "dc845503-fe48-4b37-8ffd-5deac41d7c5d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23fbee5b-fbe0-49a4-b312-6a5471f79dca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "921bbe69-31ed-45f0-aa78-56999bf7a9e7", "AQAAAAIAAYagAAAAEPq26R4Um7k4xTkrr2qtIjQ9iA08V2KnMMWU+p1n2AuLGlZx46Z0mAYh8q/ULDKT/Q==", "ecdea6be-6067-4875-a015-f231280c7566" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d61d8370-8201-4494-b390-f3218f73a947", "AQAAAAIAAYagAAAAEFxnE2Ll2NqgrJzITWOaw4runsmLbi9BtUQBTsDZurFO+dFJTGJnw6mXSu1j55sVPg==", "37b3b2b7-df62-4ec0-9cb9-7624606c2c5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3110d510-2d4d-4e84-9f69-84794965586d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a586e3d3-37fd-413d-9ae4-8403e7f88a6a", "AQAAAAIAAYagAAAAEPzoZSUlVUrjRoi5YoljSE36L6pgYs8FZzbBRNOv3kp5Zg+1Zs0OP2Hfc2j5nmmGaQ==", "b5ebc964-0765-40cf-86cd-d7f02dbeb2e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "225c9314-81a7-4050-a6b5-167d17b13213", "AQAAAAIAAYagAAAAEBFA+z9gvyHf1lAio28f1iQTST5H652YEpgQOjFoQEMsjLI55HdTM/QNlIim/UUDXQ==", "0c68ccff-a8f9-42b0-9cda-50dd1293c74b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c8870b2-58cf-4341-8ea1-d024520563d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48386e51-228e-483b-acee-2eab774fe0e7", "AQAAAAIAAYagAAAAEA03XTAVQM4+244UW/IAGOlMz5DDlQdHChtBqeSZxU7SgZg5uxxriQ7yz7eI5VX96g==", "44dddea4-c650-47bf-a85f-5c9f6d4737bf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c0a3b2-bf91-4c97-9a31-cb7b454c1415",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88085572-6e77-4a5f-97ab-92190c96f312", "AQAAAAIAAYagAAAAEMFw5JBGMnkOXxU3XK+xIIPhlgnjaV0Hd/rv7tJ6hi9asvP7J3O6dTEJbY/aDgCMUA==", "6affb371-d6cd-4438-92d0-1439e8e38383" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57e1941c-1412-4384-b819-d67a19204baf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07112671-5c22-4318-9c7c-d1468e0b5fb3", "AQAAAAIAAYagAAAAEJgVQt4IpZRfcV8BWtNnXNhOPy4cIlV2kIDreNZCKuFNABWQurVOhAs2uJyxAz9IZw==", "d453d4ea-5b6c-4d34-a252-0fb7f4042d5a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621fb5c5-b634-405d-951b-3088891c3d5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46a8c3b2-6eee-4c4b-8e44-5fc5084abd83", "AQAAAAIAAYagAAAAEDPOkqVkdLuC9iqyrsUV5f/op0kcuLQKIUdReHdoq2nrSaoxkNm0/g/mlYBCSKpI+w==", "f428c607-4261-4f74-ab5f-b56aee9ad585" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76222e29-cbf5-4335-b2e4-fa6a77afeab1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cd1236e-99fd-438b-9aea-7bceadc4a2c2", "AQAAAAIAAYagAAAAEHaNakpEPnzexKGHPzqa+LLa2Gjwdv50K+YXNTCXG38ZIAOurj7iJzjzBQZ/oAbRuw==", "a66865bc-a507-4334-abbd-b62683c0ed8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78429ef3-6e8f-441a-8224-cf9a41152a2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95b173a3-349b-4f25-906b-a8d9fa61fd68", "AQAAAAIAAYagAAAAEDWhPahwQlmKV4R61LfGPcxKj3Qc6w0CQ0UqVgo9B8C39qBAD+nZDSnUpoKXyvaAcw==", "6213749c-0df0-4c9d-b916-42545afd07b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c032bc0-04e2-4111-bbfb-a59d46791529",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9d48853-9e4b-41c8-8cce-16c9a0dd8c5f", "AQAAAAIAAYagAAAAEKwSzqKhCRE+JCC2LpivgHP4cn/aJyEy7nt+nP+s4vswHrrse0a5uOOZBhNfQNSeEA==", "b577f5f3-368f-4161-abb2-27d0b679b3b9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c99b5d-6573-4514-81eb-183ace313419",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63e96eb7-10a5-4ca5-903b-b32c402e6a9a", "AQAAAAIAAYagAAAAEAPjbPIj2jhgMAcs2hWCtvSWJy90W2uLrunsiSx9EcCIvUN/OhQC49xwxx6INptiNQ==", "673d43d8-cafa-40d5-b129-4ed7f4ce418c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a001bd24-5c2a-4f7a-b000-5f7bd233cd12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1d02ae2-07c3-4c5b-8c7d-faa3cf43870e", "AQAAAAIAAYagAAAAEAO9hduPdWqM/aEarIlnG+7NVNNXXAZHbXmHGYlbuDGn20wT5tpRVZTrYQ2s7KnXLg==", "21a72e4d-127a-4bf2-ab78-4784414be6a3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15998c9-52af-4c6b-a032-b135b879e5a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a735b6f-90b4-4527-bb44-a233fbcbb375", "AQAAAAIAAYagAAAAEB/SdSIRTrh5NNpWFvDtX9OEz2DX4c6EmfmstSu2LxrqWGwn+zPkUcybBSyJzEwHQQ==", "ca868bb9-c1da-4717-b093-d2cade33b957" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8d287e8-357a-40f3-893a-ed507ed6a85d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17918b66-9912-489f-b626-5e6b7cb16c8a", "AQAAAAIAAYagAAAAEDtDesbCC4Uy+8KtxT1yHykx8LK+NBIeqWVvWkWNruoSARVBFqFbgdGOqZ/yX8reeg==", "94f6c689-09a1-4a22-bbb8-691040a2f5c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558d53-8adc-45ba-bfdd-1ca9e11e7185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4e40d01-6f57-4c58-96ad-1d9bfd26159c", "AQAAAAIAAYagAAAAEAofZQOn/AQgy2JfSsTGM2CM8zx/uWKr04cmdO4jRLyS04ocK9uG+hUuflH1CadFfw==", "960ae795-aa67-4cbb-a54a-ad941fe2ba60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55b3e3f-6604-4bf4-a9c8-014d0c146003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59b77b54-58dd-493c-b770-7e398f8619fb", "AQAAAAIAAYagAAAAEAdiH7HcnVXwEQ9l5G+k/CCfcHUdopGBWjm2OucBIKvfz3FuESkkN2FqxBQcRvUIAg==", "4bff0f7d-29f1-476c-a8d1-412ac0ee013b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6e29719-7856-4b5f-b5da-84ed3a292877",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2bccb28-a55d-4bb4-8499-c658f83ab9ce", "AQAAAAIAAYagAAAAEN0OpSVFKZZrOlDUkNDjBXHl4glgCnXXzEBbFH2isOR3OYWZeVC4uCYvM7bKEX5lCQ==", "dc211e28-2d06-4cce-8fff-c617b364fbc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8d0d177-60a0-4925-b4ed-bb36aebb48c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bca4f798-ae60-4c92-afe1-1a9e4bfe2d8a", "AQAAAAIAAYagAAAAEDksdzXgUew+f7M7e1ZYZnIozn+DHV15Bnbh6zSoDh+bL1GuKS1tU2k/kqJtp2NDSg==", "32eb45e5-01c8-45cb-9cdd-5ff9230c7369" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd5538d3-1f68-412f-9949-94edde16d8a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f65ce1d-30ad-4946-9b75-713c706418a9", "AQAAAAIAAYagAAAAEMQRZFXUZxG7i8U77LDQ2kzDWk49IoaPK9RZnbEDZT/H0McE4xVViMCrEmhGMhvBHw==", "9cfc4bdd-9873-423c-b24e-151143f9009a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fddefbf4-e1a5-42a1-a64d-e0843640267c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01e835a3-a579-4518-8d33-192d0fabddeb", "AQAAAAIAAYagAAAAEJhVHG0DQQVhkzAkl8UzCv54DDzptoueXeaobZ4oJ8FQL8Zd3DGwdCQjvOVsm90lYA==", "b2b91d0a-c584-40b4-98e1-dffe0a058f64" });

            migrationBuilder.AddForeignKey(
                name: "FK_PatientsDoctors_Doctors_DoctorId",
                table: "PatientsDoctors",
                column: "DoctorId",
                principalTable: "Doctors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
