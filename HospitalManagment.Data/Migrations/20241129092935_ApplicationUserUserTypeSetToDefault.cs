using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationUserUserTypeSetToDefault : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ea23a1-095e-475f-937e-cb3e34c4def2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ccd92b6-c9b0-45e8-a612-a3ac13649df9", "AQAAAAIAAYagAAAAEFz0TSLP6m4ZC/mIWFxC7W+ZEXQ9cZYjXKzUlfVIm2KxS4Ofo066MPtKZqPePxLl7w==", "cbefefe4-3faa-44fc-957c-0c0508853961" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f7ac8b8-ef5c-4b3e-8b97-0cf28123b82a", "AQAAAAIAAYagAAAAEIS/n4gtcc6dBqMVz8MBIyMOx0Y9PhrUOxdRynDFsRsZ0XhF99UXXAScWg71UDMxQA==", "e5739100-eee6-4173-bb6d-2844fd4ca00d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1babbe-d5db-49b9-9624-47b9d69df236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e209ca5-a0d9-4ff6-a468-65bce185570e", "AQAAAAIAAYagAAAAEJ1zcqKh8iXzgqQ40oZbsVN/GmwmCIfDWq85YOJ5lRpOR6rZ4SpPL6Wxmy+r8IIA+A==", "306dc3e8-2994-4fd3-899a-45d07acc0cbf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e9933d-2a1b-467b-b6a2-79297246b8b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85476cd5-b3eb-41eb-8d3f-b114c0aef562", "AQAAAAIAAYagAAAAEH6HtdQ2T8nH+MMJHxQMjtlKo7tyMwrXi89zphddqsVRZo5fJyDUQ848y5zlDetA6Q==", "32ee187f-5e30-43ab-81eb-0632d202e52f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18538144-c4ee-4d7d-b4eb-fd9267ca134f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51addee8-7769-4c65-83c0-33713f865661", "AQAAAAIAAYagAAAAEM772f5A+hb8i5iQRZT8ItmPSrQ0dYiFDWeNTrZyw7o0vKxEB/KDeL6SWLE17HIApA==", "0e074eb4-1e9b-4fa2-b96b-c588bc5b0b60" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "990cb90a-5199-48e5-8c02-7234980eddc6", "AQAAAAIAAYagAAAAEOaREZaqut0fIF0FGWDC1hoN7JPcydsXftfHCy22IDQoJb8SgXfqkUCbaYEY7hiPwg==", "364d9167-288c-4c91-bbf8-17b0352e4d73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5c3cd3ca-1227-4f15-a643-366453261c8a", "AQAAAAIAAYagAAAAEBnmJyZPmW8FM3EpyKqQzNwjhCjSQKgBFECtZDn/u2sM5fSK95puA+lp9qmsbHX1nQ==", "561bdab5-dbde-40b0-9092-8ade134ad4c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c8870b2-58cf-4341-8ea1-d024520563d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc590115-fc49-49cd-8da8-8ec766c9d747", "AQAAAAIAAYagAAAAEFW3bNitz7qdt1PgXb9644xQzzn3qk5oRkVM/lttpMs+dnrR24g/ppAkdgKKvfK+LQ==", "f55b9c88-6f6c-488a-bdac-c62aa3ddfc35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c0a3b2-bf91-4c97-9a31-cb7b454c1415",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edd99b46-84bc-4b06-9c37-ce8e151b632a", "AQAAAAIAAYagAAAAECkqjb4scfAyDrTmATldRYGjyVYcjB4ptIvTZmqzEahaiuWAJxb45FPI/HX+oBvNkA==", "1e6d3d3e-4b45-4398-a33b-b8ac3a3f012c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621fb5c5-b634-405d-951b-3088891c3d5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "68bef7ae-c145-49ef-85cb-fd4a49169b37", "AQAAAAIAAYagAAAAEIndqQ8EiThGviwEQKa8homd12qHgCSB3KawKEkUMF3h3K8R721M0nVDbWa4BWkG/A==", "91ed4edd-399c-450d-96e9-e67c9ecaaa6c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78429ef3-6e8f-441a-8224-cf9a41152a2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "799a4c36-3a92-499c-9122-2fce2c38964c", "AQAAAAIAAYagAAAAECdCAfdC9BuYrTkVUDTSGixB9PxUQkc8a8I2LDeGRuZ2p21w9v1u4jKOWYiX1SiTuw==", "2fa7e9f3-3327-4502-a447-98164b453678" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15998c9-52af-4c6b-a032-b135b879e5a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3aa3ee1f-82ff-4390-afc1-ef8387d17c8a", "AQAAAAIAAYagAAAAEGGoLKaWACqCmB2eqaBPIHpkjzclZfezoQ9tpPI1xwcsloO1KgfynEBiD7cQZMH97A==", "40924e62-7c3a-4a45-86d5-700c09c024cf" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558d53-8adc-45ba-bfdd-1ca9e11e7185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99470de7-7e0e-41e9-8004-6f47ffc61383", "AQAAAAIAAYagAAAAEPo7NiOW1FQdvAZgPvM7QtEFTkkfgoNMWe69k06YwMV4E6vMcSsi6WHs5cAWLWDTqA==", "ded0989f-cfd8-464a-b5db-0f44cfe93f80" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55b3e3f-6604-4bf4-a9c8-014d0c146003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d197ee7e-994c-43b2-ad27-a8f406d49f5d", "AQAAAAIAAYagAAAAEI/evvR+aAXyyTyZB1zra+GTI1l4jV3SSjd2nyrZd9aQMN+HhPQeGlzS7MkzMKkUwA==", "eb8666a5-0cba-4601-90f0-f9617f882861" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd5538d3-1f68-412f-9949-94edde16d8a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1bfcdc2-dda0-44a1-aa5e-4de2d3d7cac9", "AQAAAAIAAYagAAAAEJnxjzM6nDTBzPdyHIXPG+qgReYmoYJWWgGvZT2zwJWoHM2KyLidWSH8meBzv0Lv/g==", "4dd98bdd-c585-4aa5-b055-8945ed68f394" });

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
        }
    }
}
