using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedDepartments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Departments_DepartmnetId",
                table: "Rooms");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ea23a1-095e-475f-937e-cb3e34c4def2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0971c043-2cc7-42f9-b13a-4ec919262b83", "AQAAAAIAAYagAAAAEB9g4QWiXpPPALLE+Ckylv0cPL3iVJibnZqyHVleAGWSnfSV2jaP0tCSXzIbVQbPIA==", "07851a44-796a-4b6c-b872-25a303edbb51" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1254a532-79d1-4faa-8023-abde6bba9733", "AQAAAAIAAYagAAAAEE0+MohsUqAHeKWupuZDJJt0w6OUywAxoh7s0uEGJDBJ9jblNIoXN8waxRiUMgepPg==", "bbcccbd6-b55b-4120-add2-3345d9fe481a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1babbe-d5db-49b9-9624-47b9d69df236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ebb7621-b6db-4e40-9c57-a68654bd6494", "AQAAAAIAAYagAAAAEI6rrKG5Dyd7unMfvtdYeJPqpVgt7m+zmWz3KtijfH87TW3znXTXQnJLQ6nZVpzMvA==", "f508f886-c02b-4075-b2e1-03d2aaddc8f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134d8ce3-4c26-434a-90b4-f59ae5457a01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4502a8e-d99f-4ef5-9205-c032a30c897f", "AQAAAAIAAYagAAAAEGQwizJNM1LQo+6nlpPrn2DFlTspOJv4u8P+jF6dtA91ZIzEus4Amw7Tn0Ji2lLs4Q==", "7fc1a45f-f0c9-40df-955b-6b1effc4b98d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15050ff2-ed6c-475f-8831-f61d54a29175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef675b90-8faa-4ef4-8b52-202204d64208", "AQAAAAIAAYagAAAAEAJIeIJC06gXuSc6nfjsJOQGstdwZvqMklxfrvGmutJkpUnh7AGvKT7ZOM0O7L7Zyg==", "ced575c9-f48d-4933-b8be-c1dde97bb3f5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17139a72-76d4-4362-aa27-18a64cc8d285",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c80b6597-5f30-46f8-867e-6e720e221c9c", "AQAAAAIAAYagAAAAEAy8rDBU/2qDsJU0T2pJfbnqil9R9euAGd63PKfC5RVl6kJ0TGxE7s6OZSShWS/kWA==", "2063d373-9de5-43f0-8aab-27bd5708575e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e9933d-2a1b-467b-b6a2-79297246b8b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b225dd55-724d-4caf-8ba2-48e507200695", "AQAAAAIAAYagAAAAEPmbOpOu/ezba24MVpr+ettFcWX5GednyZndaflIOnE4h6ktqljru4S5SsSsWfuXnA==", "f139fe51-f273-483b-a9d2-6f0ca536875f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18538144-c4ee-4d7d-b4eb-fd9267ca134f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "918f487e-fbc7-4644-9de6-6b242043686e", "AQAAAAIAAYagAAAAEM2jM0aObsjOwzf6T09onGyFDS8e4vyiSmvwMx2T32U1wd/p5mxiQ+QDQuvsNC7/BA==", "77d02cd5-cf61-499d-998c-884a4ea45361" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23fbee5b-fbe0-49a4-b312-6a5471f79dca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "81aa5a40-9505-4d34-a245-3ce4264008f1", "AQAAAAIAAYagAAAAEHMHVcz4iiNvRFQ1YGAMOSJ71jIGn28Cqxu0HhH4e5zdXHkNmbCaqkh8zh5mPm5GHQ==", "85bf0767-2e81-4087-aaef-f534aa866871" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "20062ca4-ccef-498b-b370-3158b49a4e35", "AQAAAAIAAYagAAAAEH0rjusM/WqpBgdEpWpFdiDpNvFKPhOMnFIN8Iyttg+2b3VXdGEAr3pmrWxgbMa++g==", "3ae73877-2b33-4f15-aeeb-7e58223232c9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3110d510-2d4d-4e84-9f69-84794965586d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c291975-0cdd-4f6d-beb1-58e986cdb94e", "AQAAAAIAAYagAAAAEO+2E/LJ51i755hSK2YZIGNdVXumyqOru8i9IbpiYlr717/f+bTg6BvRna0bSfgn1g==", "7b339d06-1e07-4c3d-ad2d-e48d40322cdc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3eb6f9e1-95bb-4437-8c98-714ae52e2d25", "AQAAAAIAAYagAAAAEOeIQqHvABc5AlEiJZc6YHIP+XLT0Fgv2A0cN7I0NqfiVAj4i7YoRdpSogQRGOFvWw==", "ce54bea5-607f-4d3d-aba4-4185262fd5c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c8870b2-58cf-4341-8ea1-d024520563d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b3784d1-1a9a-4845-8d01-38e29adda9eb", "AQAAAAIAAYagAAAAECuQ8w8nGzla6fHIkmqH9XRA/HsFP8JS90b28kI3Q/y7YusclrjR0hsnsfOCvnt/dQ==", "682bf4fb-85a3-41e4-9735-59fbfb3f6946" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c0a3b2-bf91-4c97-9a31-cb7b454c1415",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fef0d695-f3ec-40cc-bd70-8e958615b3f9", "AQAAAAIAAYagAAAAEFynMX50ye4BvZEpLm1yzTz5WFROgqGqr3gksRFjww25FxrXIh5Kfw6GYxyWOR5a8Q==", "47cb51e2-beee-42d2-a3cb-26d7fc7b59d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57e1941c-1412-4384-b819-d67a19204baf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3d63c0f-2d49-4d74-89c5-b0ff93f0bff9", "AQAAAAIAAYagAAAAEMk7Oy6ZZeJpPJiN395IvZk0/mDoXh9GAobc2yV7xBFk67WYTIsiHq5BxgV6alr40A==", "9f15c5de-0bc8-4630-8126-5a461fd5d887" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621fb5c5-b634-405d-951b-3088891c3d5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dccbf541-dfb5-4d72-9c3b-02391a1aeb1d", "AQAAAAIAAYagAAAAEEq37RIDjofCtwbq9YTbrhc0A4O0NFaQGNieVIe+96PgEA3J+4jyb8SWbjETrT9Uqw==", "9b5ab03e-260d-41b7-859b-1417855ffdcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76222e29-cbf5-4335-b2e4-fa6a77afeab1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0db848c-50c2-45bf-bc7c-67dc53e89c47", "AQAAAAIAAYagAAAAEK3AG4Ad3/99pWiqTdMYa9jXkZvoJEX4x7qNEAPC9UR/cTHdgy9TkcFMDqftjF4t5g==", "8a315031-176f-409b-9553-be16c9d6a9d3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78429ef3-6e8f-441a-8224-cf9a41152a2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b5fb8bb-dd74-4028-a6d1-97a0d00e6d14", "AQAAAAIAAYagAAAAEBQH6xtJnxtdBTak8jGgZxtvMf3Ov2rXYJhtdfzdtBH/2jHc+qB1ubvc9KgAMvDMWw==", "6bd28cc0-5e1c-46c4-beff-6d61aa02b7d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c032bc0-04e2-4111-bbfb-a59d46791529",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5e62615-f1b1-4a63-a237-432d521f38c4", "AQAAAAIAAYagAAAAENBEiu+5/oYWWzH1BUhg6Q6MzhVTc4h0gRHK0jEcYNpom8xO5g8qRZR4+RrhraFuUg==", "fbdeded5-e30d-442a-b472-e889c5f2325f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c99b5d-6573-4514-81eb-183ace313419",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "111d62ea-f38d-4780-ac43-216d8f3ff043", "AQAAAAIAAYagAAAAEMNwjqB0fXV59iBEyIcus4/eimmhnEIJ0pDThKp8tZAQqvdOuA8/o9kVWDx5LV5jsw==", "cd73a68e-1913-470e-b5d7-66105643fb1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a001bd24-5c2a-4f7a-b000-5f7bd233cd12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ac4e2f0-fb5f-40b5-a2ee-78c7f0c35c10", "AQAAAAIAAYagAAAAEBD4pGIQXXSrrD4pO0TZr6njyresr9R6Cxl6rVRZ0O2ixa8aiEKYLg2ZQ3KzPTrmGA==", "65bd3912-0d8c-44c2-8523-70c5ef3ebe80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15998c9-52af-4c6b-a032-b135b879e5a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ed946d2-c275-4fe5-b369-90d1183d83fc", "AQAAAAIAAYagAAAAEG6Fb/tX6/v9P29TsjHwk0E3PGS7Ielkm6QbP1+8zTp5rS6w3JCFXzklIibqY+980Q==", "67e4e44e-72c1-4b2c-a86c-56281b4590b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8d287e8-357a-40f3-893a-ed507ed6a85d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12964e50-c1ef-4927-88db-57872debb5c5", "AQAAAAIAAYagAAAAEJ1rtVKO5tM8D9bcI/6hEgaShIs+z+LnEtxllnalOrboR13Rj55OrwA5ppEW9Frtew==", "cf586c3a-0cb9-45bf-a84a-f0c516c7f573" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558d53-8adc-45ba-bfdd-1ca9e11e7185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f6eab20-0c94-4e36-9414-295b3566be9d", "AQAAAAIAAYagAAAAEJfks3dFRWq1NO7FiPALsj3Dy18UDG3VNI/jMW2fdqbSm0qx5YeI7vJHHWVlct3Dtw==", "7b693eec-2aa7-49d5-b6fb-437184d577e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55b3e3f-6604-4bf4-a9c8-014d0c146003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8b5a699-4597-4064-9f3e-b203856e8eb5", "AQAAAAIAAYagAAAAEJOhCvcfjIZkeFzLuRA0LGUgNnLeAIzS2LluMsSqDX1n9kA32ciMjV8a4U8uhRuIrg==", "99beb75e-66db-4bcc-9d66-a9d76252301b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6e29719-7856-4b5f-b5da-84ed3a292877",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4355317d-f61a-4654-9f15-20b6127b1720", "AQAAAAIAAYagAAAAEP8YKxECiZ/SFJspXnhcRKPTkqRWxGytKPseqpSs45WeCYfJueqbtpMQIooecvYAOw==", "86ee3722-f37d-4bfc-924f-90ecfee59032" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8d0d177-60a0-4925-b4ed-bb36aebb48c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e40eea3-c907-4146-b3cd-54c4dfe14c6d", "AQAAAAIAAYagAAAAELJwtO+DEaa8+bG7icuoBQ00pdLAOKbiFeRT69vqT0DLZKOcpf5epYrrn6kza3QXbA==", "a16e2996-3f42-4874-9b58-2e96ce2b84f7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd5538d3-1f68-412f-9949-94edde16d8a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0fa9121-f244-4de4-a683-4ca88cd13c9a", "AQAAAAIAAYagAAAAEHeC20zkPMH+qple5DS2WPqM+A5uiDfyfZm97hT5Ap7adkAET0KOIiURouR45gpxHg==", "5d8e89e4-eeb5-4fda-ae2a-b6b81c34952c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fddefbf4-e1a5-42a1-a64d-e0843640267c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "770412f8-9868-4288-9a90-a2427982a606", "AQAAAAIAAYagAAAAEAe28XjAczOaIqUlvwwT2PMpOtwulm2R0YayDw+DCAvXYjk4SWg97iGtF7bST08Igg==", "6f7a7a55-6406-4682-8631-b0fe8af351ae" });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("3a19290a-8b6d-4551-97ae-b87ecf3f2dd2"), false, "Pediatrics" },
                    { new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"), false, "Internal" },
                    { new Guid("66ff68b3-846e-5398-805f-06411c1bbdff"), false, "Oncology" },
                    { new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"), false, "Surgery" },
                    { new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"), false, "Neurology" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Departments_DepartmnetId",
                table: "Rooms",
                column: "DepartmnetId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Departments_DepartmnetId",
                table: "Rooms");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("3a19290a-8b6d-4551-97ae-b87ecf3f2dd2"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("43f9018c-2a02-448d-b26e-bc832bc097d3"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("66ff68b3-846e-5398-805f-06411c1bbdff"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("70dd58b3-966e-4498-806f-04411c1bbbee"));

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: new Guid("af2f0ad4-ff86-4e51-ab19-630145898ec6"));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ea23a1-095e-475f-937e-cb3e34c4def2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4298edd2-7f3a-4156-b1fb-c243c76ce4de", "AQAAAAIAAYagAAAAEKpF14qA33gjSPqbxpY3qsa98DeSfqDfGtftiYqGipbJEQEXhwlKa04EZ2trAaUn8g==", "1d650ef7-a2eb-4a88-903a-e84ea25b3081" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0c7688be-aa2c-435b-98aa-4db150fb68a2", "AQAAAAIAAYagAAAAEKfPFwqAs80U82qvYOx9l5oVo50CBQx7qsova7Dkc+vEYb4R9M8HeYpzC6IyDi1WsQ==", "4a8d89f9-3c58-4b19-b18c-f93259a4c3b1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1babbe-d5db-49b9-9624-47b9d69df236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31fb23c5-5634-4338-8718-8a499a437732", "AQAAAAIAAYagAAAAEFlsdd2Jq9MZRSQjo+qh6zaxjb4UZRetDueG3Oac97H03NtjC4/SSHaj3PN0fqXp1w==", "f8dcb3d9-a823-4726-8742-a3f7e9c2d601" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134d8ce3-4c26-434a-90b4-f59ae5457a01",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eeb5ac4c-9273-47de-92b7-e9aae5c7d24b", "AQAAAAIAAYagAAAAEJGk9DD8Ig+mOYxc91XgPgpKl5Oo7TVwSCHu2LWoWM4SSR24ebknbs0Rxv8FQNRczg==", "d695d4f9-88f4-43c9-b7af-c754c4b3b0ed" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15050ff2-ed6c-475f-8831-f61d54a29175",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76cc6e55-5856-4c8c-bfcf-3b0e235f7fb1", "AQAAAAIAAYagAAAAEPfoJ6B4F9kxN2UJhH2yAZs9TqJpQqA5cFL1646jksQ6nJjXIoq4H0t8lmC2/aUgBw==", "9da4d9d7-040c-49a6-b380-03b5ceb14b4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17139a72-76d4-4362-aa27-18a64cc8d285",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "150b0aea-a43a-46e1-9d52-16c45ae99aa0", "AQAAAAIAAYagAAAAEEid6vvuPDMRiZlhQUVXpLYSS1bE0FkMX/Z06o9mM0foa8nSZosrLwhh2FPuUogZow==", "885842c5-0f19-4ee2-8d01-99f68d324a16" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e9933d-2a1b-467b-b6a2-79297246b8b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1192d77-5538-4bc2-ad30-c8351bffdca3", "AQAAAAIAAYagAAAAEJIQIatJX/c+4l8og+x2iWczvG4lgfs4yy95ewaxn7JnNEebhL6j4FYMWZ/mY13S2g==", "0cd883cd-508b-4684-b529-e6e3802afd6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18538144-c4ee-4d7d-b4eb-fd9267ca134f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2f5779c4-29c0-4479-bba0-6a2fd94f255b", "AQAAAAIAAYagAAAAEMGf+xg+EUaapTchXKkQ4iKrUsrCP8KxOr5M8XvbCcdVPY78rkidN4E6gNws9TAvQg==", "5aa497d6-6e4c-428c-b265-7aeac2e70bfb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23fbee5b-fbe0-49a4-b312-6a5471f79dca",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1095c4f2-293f-47da-b56e-836fbaf59612", "AQAAAAIAAYagAAAAEH5ihNapbjsVOkNkINbn2O36Rn56B3laKP1rMhvQhGTX+qwg6WhEWrWsK4HxbAC9UA==", "984e233d-6a77-4ce8-bea8-9ed487e79899" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "52d0fb11-c689-4ccf-9c57-6e487c8ca06c", "AQAAAAIAAYagAAAAENRkW6F5/fAdlmo5ON122LR679yccJ0gJ3TUhXHRALCyzZfTdtk2uMiqPuvcwRijZg==", "11b8cf6b-c7ce-44fb-b129-12728822a8fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3110d510-2d4d-4e84-9f69-84794965586d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dbe73e1-fbf7-4c4e-a9df-08b4bb6cf927", "AQAAAAIAAYagAAAAEHzVGiSuyNpukyXRZhK0Z+Vf7Fhi8PN98W816CD2btQSaFjcnjqBiGNPEABXGJMjAQ==", "4b663933-c73b-4e7c-a123-efe33b461805" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e71ae832-5c5c-4134-a2f0-d0dc93d6d521", "AQAAAAIAAYagAAAAEO3J7edjS9uXfpQYrmZGdiqJ2DHhCtBIFdj6bT+5bYWI7y1b7vjIeCHbuyx3T4IJIA==", "e9c91145-9a6b-437e-a81f-7ee7de8a6290" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c8870b2-58cf-4341-8ea1-d024520563d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9bf3f970-5df8-4b1e-abe2-5c00b2508333", "AQAAAAIAAYagAAAAEAORUVpytfmBltgGaa4RUqZPhCKxmAbS/1YPHW6qNvwxiae71O6oRR9cY6T1BNkx/Q==", "149383ef-9abe-45e1-a290-1d2712d3ee20" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c0a3b2-bf91-4c97-9a31-cb7b454c1415",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1e1c55ee-e837-4c26-bfea-ec30a45fb00c", "AQAAAAIAAYagAAAAEMa3IKQoClLxQTFqZ/hah8w6uqMmdT4tuTNm+5CGDJcgFwEUx+tZ56AHATi0xhTE9w==", "50f825ff-8e9e-4bc9-9cb8-989793875955" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57e1941c-1412-4384-b819-d67a19204baf",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5234b35-7bcc-4463-b97f-b85e6c3388ef", "AQAAAAIAAYagAAAAEKpWttLyn3u1uGm3TwVYlSfb9WsOtHoEa+Z3X4eqYrofp0b15KETRiFnSSpR3mO+SQ==", "2aaef69f-bcbc-41ed-bced-d75bcaed3152" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621fb5c5-b634-405d-951b-3088891c3d5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad9e5348-3051-4ecf-b75d-701c5246e25c", "AQAAAAIAAYagAAAAECqW6kMRILSwDtIt58OlHaQZvRlBwSVVl1uFBXf4wdpyxjci+GfyrGtxxfZGuDdYkA==", "9d6ad080-ac9a-4e48-a02f-03b5856603b4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76222e29-cbf5-4335-b2e4-fa6a77afeab1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2327a832-5b8d-42df-9cf9-e0faf09063cb", "AQAAAAIAAYagAAAAEBUslUBGcPUraCbjLRGHG5y6016gr0Ky/eqr4kC+VpIesskX0wwclG1pdkY9qyuoXA==", "19323f1a-050c-455e-a306-ab463347a3b0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78429ef3-6e8f-441a-8224-cf9a41152a2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5287248-5df8-4ca8-a52c-0fc277ab3d26", "AQAAAAIAAYagAAAAEA7P1tzxJbmLJEvf6SOx0Me64weXsZ8j2Txz/5fr7F5xK78vOXgthEp4ebPvRlStNw==", "be673280-582c-4635-b425-537c2f7d267e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c032bc0-04e2-4111-bbfb-a59d46791529",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "476849d7-2f91-403b-9f84-18dd7b0ac406", "AQAAAAIAAYagAAAAELe9LbvU6Zib0JYox+4LBjEsUYlQvn/IUBFQBxRAyaKmAAKl/QvfYQmCnfUXbYwc1g==", "6d56db7c-80ec-4cc2-b642-4dca45361261" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c99b5d-6573-4514-81eb-183ace313419",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3c88bca-de8b-4341-88bc-9b86a831e3b4", "AQAAAAIAAYagAAAAEBKYtDLlCVwqn7KgOML2rqj8P8mBZL+387Cf3YRguaRNS6Fcp7RWv7/oxh5gqjuZfg==", "1d82713e-b69f-4bff-9c89-0659c6b4e28b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a001bd24-5c2a-4f7a-b000-5f7bd233cd12",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c88a4132-8142-4bd7-ba20-260732cf9167", "AQAAAAIAAYagAAAAEFMk0PfXDyyMfxP+Xrmnb8AicKo30DY701yUwnnE7sB5vw/a0983KFGOQCXJk4KE0g==", "a977c0bf-83fa-479d-b3b9-25b14907691d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15998c9-52af-4c6b-a032-b135b879e5a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3df8c6f5-c83c-46d3-aa23-d36fcd50ccc5", "AQAAAAIAAYagAAAAEGesHXjyYXd49kbAJn8FUWMzS2Twklq5ksZUCFfa7Fy2bQ6HQ3LhwnV5tO3Rfi7xVw==", "1fa9b47b-0c88-4494-9e7d-3ce28a71f75d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8d287e8-357a-40f3-893a-ed507ed6a85d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e174c1b4-c94d-4715-afae-112f276fb297", "AQAAAAIAAYagAAAAEB1h9ilzHB7ZadmH+YIDmrwEOp433b8tWtfRXfAzE7mQcdbJ9LSjO48t4pbBbs2YWQ==", "72fb4691-5a1f-4387-8f93-2424cd993d47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558d53-8adc-45ba-bfdd-1ca9e11e7185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75c3c160-6873-4b4e-91ae-c940320408cd", "AQAAAAIAAYagAAAAEC7NHcNoJWhw/og7hFMpmvvD3HFOftXTEXudKrvEcIrEiR3XKIqEF76ZT6LozSprPw==", "24c63c0c-941a-48c5-aca9-7a1aab3052f8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55b3e3f-6604-4bf4-a9c8-014d0c146003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e79c9b32-be6c-445f-b291-480b6ef38668", "AQAAAAIAAYagAAAAEMLGrADrJ6uszokxsox/DnUhEonfY8OO3uyqYcUe+0sjmzmo3PDBLrzfqvWVGRVAAw==", "fceb6f29-d45a-4641-80e9-1f152f558062" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6e29719-7856-4b5f-b5da-84ed3a292877",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "962793a0-4ff8-4163-922c-3ac343644d53", "AQAAAAIAAYagAAAAENYj6k66bm6qfn2tEXB5jt4/aX3R5/jA/kR4obmzwHyymQFrP8T1bilmLd52TS370w==", "94e195fb-92b0-42d3-9d0a-0e6a7a961639" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8d0d177-60a0-4925-b4ed-bb36aebb48c4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80592c06-3606-4b6e-9dd9-718a4e01fbdc", "AQAAAAIAAYagAAAAENs+4Np7fcfDFu+z2nepZcSyBWK5fbj1HLSoKCVz5eRqlWrNNJz2c+ObBN5OXKmxdQ==", "239c2454-8e12-43ff-b0e3-60f4464b68b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd5538d3-1f68-412f-9949-94edde16d8a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "563d0b02-3acd-47e0-aafe-c2b43f59eaa6", "AQAAAAIAAYagAAAAEIgAnpESPdseB1bSym7PUQW9WV2QjXgfWM6/OGXjseeiNsg+iee0kbjnP9L8SDCSIQ==", "b233f491-9702-4085-bdab-24ad71999b0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fddefbf4-e1a5-42a1-a64d-e0843640267c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae1917fb-446d-4b22-96bf-390fc8de83c0", "AQAAAAIAAYagAAAAEIcj3DAHaBeS+rvFxvBxLmPO1h2wWeC7KJxsM8eNyWXIObQ6lVJeIiFs8iy63pjNpA==", "088ba545-d1d5-42cf-bd72-0a4e90223719" });

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Departments_DepartmnetId",
                table: "Rooms",
                column: "DepartmnetId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
