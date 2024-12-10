using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class doctorsCommentsForNameChanged : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("000c1e00-88eb-4642-90bb-956943461897"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("20ffe815-5996-4718-b1c1-476c46a47f94"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("dcd47aee-6c96-46b7-ad7d-88110ca2edcd"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("e340fb0b-7b02-4883-af7e-4be7850db211"));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Doctors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Doctor`s Last Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Doctor`s First Name");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Doctors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Doctor`s First Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Doctor`s Last Name");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ea23a1-095e-475f-937e-cb3e34c4def2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "126733ba-a030-4ae8-ada5-4b2b0a747173", "AQAAAAIAAYagAAAAEEJG/fPbaqst7TL/cwspLSOx0z48UYZkUt+0CqNnBVZ8L2NWN3bRMVa5sp4bjgiVbw==", "344931e7-63d1-4219-8980-8ffa90ffb8cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc48d307-82eb-4a81-8c2a-24a4addb3eb5", "AQAAAAIAAYagAAAAEPi2ImgY+COi4m+nVWjuOzDeOhgF0uC/MrCmK5cDgU8N/SWylVpKWaVV6SXoT1f98A==", "5169fade-bb90-46a7-92a9-3368a89b0b48" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1babbe-d5db-49b9-9624-47b9d69df236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d9adcfb-fbcd-470a-bfcd-d5d956320734", "AQAAAAIAAYagAAAAEK9Xp4NupaISULghyBrbUyP8IlErC8t5iQ5lCL/FEUO4gqw6yijBfpOW6tkZKSgWdA==", "9a3678c0-0f87-424d-80f5-54b5c62e144d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e9933d-2a1b-467b-b6a2-79297246b8b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "319099c8-526e-4b14-86de-2490e2b4c97e", "AQAAAAIAAYagAAAAEE8uCTxiDF/6mrn/NyqnjjdUXmj1neyxsh+NpOhqxmipg9EGUxrzoKsBhcy/JmpkXA==", "3596762b-f117-4ca5-8bdd-494820796214" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18538144-c4ee-4d7d-b4eb-fd9267ca134f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f091d96-5b1b-4232-8be5-a854104e26d3", "AQAAAAIAAYagAAAAELMAZ2eLWn8CQPrJbm6wKrSjFEBIjM1KPoyBr0xy9d06mx4drIxpiYdNeh4MB5wk4g==", "5d9273c8-ec68-49f6-9aeb-00025f93413d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad125417-bd0c-4d29-aa9b-a2b4d4909736", "AQAAAAIAAYagAAAAEGYNPaB6YFntak+6kdQ4W1Emm8cZD33+zbSAHEdlqDpQUdRbhxwN8LLO/LPXdgIjAw==", "d4181687-0e28-4bd2-aed8-af03b381db2d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dad2d6d-6c3c-4eb6-b283-a16d9a244f19", "AQAAAAIAAYagAAAAEPJ/tC9B2KxqjIL7ElMgDiV6QEDSf4/1dxfomIhvH8WfAUQCcwdwNNaR0wJkTytWqw==", "ea95c156-41d6-4de9-bbb6-d7ccc4672568" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c8870b2-58cf-4341-8ea1-d024520563d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f519f2d-c478-48ff-965a-f0e6b7b64ed1", "AQAAAAIAAYagAAAAEGmm8To/0oXMnvt9Rcf43EbNWuAX2jXfHaqdLo2ogOdPR64vBdSt/yy/2TUj8Aq6zA==", "207e8c51-1bc3-463e-8c82-812734b6e58e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c0a3b2-bf91-4c97-9a31-cb7b454c1415",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b655b235-8f1f-463b-840b-e498e1887fa1", "AQAAAAIAAYagAAAAEEvDo/0LlGTLc8lwgpGhwVRJlNn6BZHvfM+QMbac1Y8k94V6pfN9TEM25+g3pw9/ZA==", "045de085-e4e7-475a-be7a-c681e3cb4126" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621fb5c5-b634-405d-951b-3088891c3d5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3dedc51e-caad-4cf2-a288-23d3f4ed6165", "AQAAAAIAAYagAAAAEECsXBcF4kfQJp+7tAEHm4ixWL3lyqiWZq/dUpbIf6S5pxPdUZDZVyYKm54pU909Lg==", "436e7ac9-2045-47d6-b68f-58577c3bf3f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78429ef3-6e8f-441a-8224-cf9a41152a2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6775e35-ac57-4cc6-b44e-155d39aab58e", "AQAAAAIAAYagAAAAEDC0GZpkaElTw1AdcT/sCxx5nMnF0i69AayauCyDPEan6eIfRYDU6WqPtvOLlNV4JA==", "ed206048-e297-4f08-b5b6-2fa8236744df" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15998c9-52af-4c6b-a032-b135b879e5a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39cc9609-aeed-419c-bcc6-959c7c54b306", "AQAAAAIAAYagAAAAEAI2flDTt1dbLCLxY8YFMwmU3n6Cqe6DLNL+3LBk31v+n1WVnOL1TkkriNakveqPig==", "ac3a9f2c-7edd-459b-be97-fbc6ba6520db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558d53-8adc-45ba-bfdd-1ca9e11e7185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "180ce7b8-1caf-4a09-93bb-bbf3b4cb8662", "AQAAAAIAAYagAAAAEOBaQwU0LAeOs+tFraaVqEFsM4K/ROKOOfY1odnVFXxRxlnDm+oeY7X7mf/qv3qNFw==", "98cc4628-d864-484a-82ad-a6e8a340383b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55b3e3f-6604-4bf4-a9c8-014d0c146003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb547ad3-cf14-4bb5-928f-78426e814421", "AQAAAAIAAYagAAAAEPqwPxceG+DQDXOC7H735i5QLNc7GtvPFCi9IyUprIiQfYo00GJ+JiX4uxUb2IuT9w==", "48b0894a-e795-4680-bea7-fe49061fc065" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd5538d3-1f68-412f-9949-94edde16d8a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "155c9d83-7a17-4b6f-944d-7016d77e0b6c", "AQAAAAIAAYagAAAAEOczoRipocEacrnVFgoGMl7mWS14mYybVBgHwSp9uOJyy3meh6opP3KCKqAwpTLT2g==", "5aeb9c44-bdcf-4fb2-949d-462342585382" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("6e7d387c-3afe-405d-b067-4a25a3e3f2b0"), false, "Chiropractic Adjustment", 120.0m },
                    { new Guid("8fe37543-0bdf-4334-a62b-59a1c8b4fa8c"), false, "Massage Therapy", 80.0m },
                    { new Guid("d60050be-6a5f-4e11-9a35-4b8ba5348613"), false, "Manual therapy", 170.0m },
                    { new Guid("fd76e5a0-0631-4d4d-8a3f-5414e8556941"), false, "Physical Therapy", 100.0m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("6e7d387c-3afe-405d-b067-4a25a3e3f2b0"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("8fe37543-0bdf-4334-a62b-59a1c8b4fa8c"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("d60050be-6a5f-4e11-9a35-4b8ba5348613"));

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "Id",
                keyValue: new Guid("fd76e5a0-0631-4d4d-8a3f-5414e8556941"));

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Doctors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Doctor`s First Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Doctor`s Last Name");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Doctors",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "Doctor`s Last Name",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "Doctor`s First Name");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ea23a1-095e-475f-937e-cb3e34c4def2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef0bd2fa-b77e-4b76-872d-4da07f758fef", "AQAAAAIAAYagAAAAEGSNLO3hBsQA9CY/vo11g8QM9CCUDc17Fc9bhI6FeLpmVkMwImT2KJ96rljJOOsygQ==", "4dc4cd11-f6cc-4afe-af44-94dd0b7c49b6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b71dad96-a257-474a-9ce4-e0c0be97e793", "AQAAAAIAAYagAAAAEDVolTZEdVME6xsjSQBtLUTAz2pvPZHmw02rM6YMbVRHgtEG/COEzlxz8nJFJzpc1A==", "6f15f8b3-37ce-4b89-a550-4894b0e3214a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1babbe-d5db-49b9-9624-47b9d69df236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e38ae82-69aa-4e16-bef7-626593bfb382", "AQAAAAIAAYagAAAAEABTVcP9IlCc/FsJkPDC09pK5NVqbf//8Nd3qCHjuD2Nti1wR5mMBubW1c0sJXSSwA==", "d7faf687-28e0-4f49-a107-b46b5592ffc7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e9933d-2a1b-467b-b6a2-79297246b8b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8d2aa75-33a2-4ac1-b6f9-3a3b807bfc8d", "AQAAAAIAAYagAAAAEHmSwTkajhgbLtWiKzUzFwc1eGU5Sei0OVd+6UUdbhanN3kZ8gPQRNyDqjHQxgvioQ==", "4f0b9c21-a817-47c4-be8c-a1e134a11e44" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18538144-c4ee-4d7d-b4eb-fd9267ca134f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2afb3709-41be-4c4e-9bbb-39f5c07545b5", "AQAAAAIAAYagAAAAEItZsCJsLAZDVbvV2viG606wc1D5BcXiX4XFzSCOcwO6G5Nt5dJvHsiPzoSugaqeyg==", "d1832d94-e9f5-4684-a3f5-5364c83cb756" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d37d2d7-dc39-46ea-8baa-b3b2001ff1e4", "AQAAAAIAAYagAAAAEHt0bE9cQXEv3KDhYAP9UlrXma+J86HEQU0vCAxMtWp/lTJE1wJfufXIeyYXtZszyA==", "b11b20d8-02a6-41b8-a7b8-6dd828ca5b21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8cba80d-2e3f-4e65-a8f3-b4bc6f4f8114", "AQAAAAIAAYagAAAAEDH0qAEYmIAg5wRw1Ldv22bX3HLoEJAzXXw9VZVXo77PRWI2sPJWiNVrViYad927/w==", "52d83774-f574-49d9-9794-d016d4b1c7bb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c8870b2-58cf-4341-8ea1-d024520563d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c1c5b9d-11de-459e-a51f-f8127f91aa30", "AQAAAAIAAYagAAAAEIsGmMH3Ak/JIiRbhlNvPx6mKoV1MNGeCw4mWpE7Nu6MAbW2YcB783r5r/no9HUWoQ==", "cb395c9c-7ff4-4671-9821-99c2e77af5a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c0a3b2-bf91-4c97-9a31-cb7b454c1415",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c99483c5-c223-449f-94e0-e8084b0696ae", "AQAAAAIAAYagAAAAEPWO8Yo/7JwpfLF+w5Hxz/5GbeMmif710iqCOru7AIW3VH4ghxb8AWTQDiXfK/h9+A==", "105eb502-4de7-4287-9dbf-94214b184212" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621fb5c5-b634-405d-951b-3088891c3d5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f34b3389-7fa7-4082-bdb0-756c397c5a79", "AQAAAAIAAYagAAAAEL7tJWpiNHxKvHUUmkpqo2zguGVzVCixiZBzeMCOKwlwojSxdavY3o7x/JuhNpUhgA==", "3e2f7377-70cc-4c78-91b6-e5ced6cfe85b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78429ef3-6e8f-441a-8224-cf9a41152a2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67b83a2f-6cec-4473-b53f-4c39e4e1bacf", "AQAAAAIAAYagAAAAEJNgttdpKTo6HegBmaePkU19LS54k9kzdHMVGkoSK4fKwaqPFln7vZyqR0qys0YjrQ==", "0de0a507-246c-4f13-8dae-d7c0282b0341" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15998c9-52af-4c6b-a032-b135b879e5a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eed24e31-2bc5-4b4b-b56c-f868081b9bfb", "AQAAAAIAAYagAAAAEChk0mKyD3gZmAh9fQBSpGycqFD5ACQanBWOBxn72EAkOzveVtlAPqSA+zYg1wXlBQ==", "df6c9d3d-9d06-4577-bfa1-da9fd46c671a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558d53-8adc-45ba-bfdd-1ca9e11e7185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62f3c1b2-4475-4c20-983a-181d7209119b", "AQAAAAIAAYagAAAAEABEZN+uBkjLbH+zQrdFs7ScxLS2W5SV9vE7H/bf40raVrlP42AoYi0u/qeb2O2DTA==", "12435b49-45b9-45c2-9172-d83207b86dcb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55b3e3f-6604-4bf4-a9c8-014d0c146003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5625fd1-ef89-4a4f-9943-e95855c7766f", "AQAAAAIAAYagAAAAEJ9QwqKMeLEdtzvENyX3UKDAgQ/cOFedfF2zFMWHBqjLChV7CM+bYJlcaNV+1OHTrA==", "8c3cb740-130a-4d1d-b9ff-c9f4e67b42b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd5538d3-1f68-412f-9949-94edde16d8a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17d79b09-033c-4abf-87a3-bae461c1a96c", "AQAAAAIAAYagAAAAEGSsM11+kWkGzhMQgd/XzbNvbMzxBkNJd9N099+rm3CsRTOhBhxtXQO/SICzBq3Mug==", "c57131cc-b393-43bb-a37c-1349d43cb71d" });

            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "Id", "IsDeleted", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("000c1e00-88eb-4642-90bb-956943461897"), false, "Massage Therapy", 80.0m },
                    { new Guid("20ffe815-5996-4718-b1c1-476c46a47f94"), false, "Chiropractic Adjustment", 120.0m },
                    { new Guid("dcd47aee-6c96-46b7-ad7d-88110ca2edcd"), false, "Manual therapy", 170.0m },
                    { new Guid("e340fb0b-7b02-4883-af7e-4be7850db211"), false, "Physical Therapy", 100.0m }
                });
        }
    }
}
