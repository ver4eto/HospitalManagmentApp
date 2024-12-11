using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HospitalManagmentApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class NormalizeDEmailAndUserNameAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "06ea23a1-095e-475f-937e-cb3e34c4def2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9c8e518-ea3c-4a06-ad67-235a2d4c2c2d", "AQAAAAIAAYagAAAAEL85ZgzZPrDDLeuM8/sI98XtbgsMZDgJQYljPxDauAmtRBZkd8H4cl2eOSXmc87TsQ==", "be8fb048-3b8e-4505-88a8-3d57715c4e3f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b04322a-bab8-41ca-b791-ec1abdd7e8a0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "073c81bb-0fc2-40cf-821f-b9e23a3a2c4d", "AQAAAAIAAYagAAAAEFoKMGvS63xDQZjQQ946CvIHYv065DUUbwo+sk5Vl+WlCrOKMzLgfnkUQ08g+yG0Ng==", "f1e1fd02-9408-42ba-99a4-8008a63d3616" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0f1babbe-d5db-49b9-9624-47b9d69df236",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e42361d-48bc-42ed-b45b-e400253aafff", "AQAAAAIAAYagAAAAEAN+vWTQ283adQoM1XC9L1+ip8h5UYa0TtbJdNfD/VQKEAAnWQ2o64IzB69CccxOOA==", "75592781-0247-4e96-b251-50340d85e3a7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "134d8ce3-4c26-434a-90b4-f59ae5457a01",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32bdc8fb-a7dd-4218-8d77-2287582ace8d", "MARY.JOHNSON@EXAMPLE.COM", "MARY.JOHNSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAECDeot2giZJOJrWhsjueiLquRBOdbvpuOibgMU4rBMYM82lPh2KgRO5UkOE4ZvztwA==", "8f916021-6cf3-41ad-8a20-d8f98d713c84" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15050ff2-ed6c-475f-8831-f61d54a29175",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3a99881-8e1a-4ac7-8568-d9dbfed8c15b", "PATRICIA.BROWN@EXAMPLE.COM", "PATRICIA.BROWN@EXAMPLE.COM", "AQAAAAIAAYagAAAAEGglNX63aE4hQ/mSm7EYCoHJCBOrHMLhdLmDQEdyb59k813hUZwrWVm/vQjoUZzIlw==", "55b16cc8-daff-4b94-91cc-2bb555d3a783" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17139a72-76d4-4362-aa27-18a64cc8d285",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cb9fa4a-3d16-4b02-9ffe-f884164ba815", "ROBERT.WILLIAMS@EXAMPLE.COM", "ROBERT.WILLIAMS@EXAMPLE.COM", "AQAAAAIAAYagAAAAENi4i1eP1c1UmDDOgUODlkdfguxAc5QiyR+CoHIdZwvndi5bSFKJ6FLHvREQMbUmxw==", "1f859e3f-50ff-4b3e-b405-2fc2966bda1e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17e9933d-2a1b-467b-b6a2-79297246b8b3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73bca0b4-e204-4022-9bf1-b020ef56f90c", "AQAAAAIAAYagAAAAEExAEy2faSU87NQ+UvKLMjaqzrxnJS1uXN5X8xVJED40rG1S6Cb1KRZ73ev6Plj/TA==", "ee9ec2a9-d8e9-4a6e-95e1-3922d4fbfbeb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18538144-c4ee-4d7d-b4eb-fd9267ca134f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70fc9769-9cc2-43b9-b8bb-9b7f3183cca2", "AQAAAAIAAYagAAAAEGymEHdATGxTlBz/kxe7utqLM7J+/Vdzq+4ioS/cQpIdACM/1Hdoo20miKxuhNpR0w==", "390993a0-5d73-4b60-b968-802a87c39fe1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23fbee5b-fbe0-49a4-b312-6a5471f79dca",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ffd743c-4f9b-44ca-95ce-4b4811433972", "NIKOLOVAPA@ABV.BG", "NIKOLOVAPA@ABV.BG", "AQAAAAIAAYagAAAAEKRZEMs7TnwJlRzEC2UfWfYgDv8V4vGSHFDHHvwF8sKJXqD4t/vLj7Zkt6RO2od2mg==", "2b6f882a-d068-45d9-8e16-f90c5bdf17db" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2c5c4962-15bb-4282-bfbf-5a0cd30ba664",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5d6837c3-d43c-440f-9e95-a1b2d17f59db", "AQAAAAIAAYagAAAAENmPt+7oFvvjQrZpbK2/0+FGjuvNAiZ9B3tGkAPADpQoL9OC4szX429K9zAn4CS/JA==", "8c713ce7-88c7-422e-83bf-09b3ac4e2126" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3110d510-2d4d-4e84-9f69-84794965586d",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fe0a305-5193-4d31-98ad-33b6a39667ca", "MICHAEL.WILSON@EXAMPLE.COM", "MICHAEL.WILSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEC+Rd61t2PZfuU5W8mJ7KdCgJdxWj/MTtEzsRmOzTDnCPCoU7hLYqy44d7sT7zvv0g==", "88e07351-cfe7-4be4-9b41-ce71a99096a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "38a0afd0-c8d6-4674-b24a-db1e6861fcc8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21106461-a315-47cb-be5f-be9095f27ea3", "AQAAAAIAAYagAAAAEHzNfEHOaLRpqKAvkzO5HlN1GLwOzfpo1e66rw5WnGXcGJw+IvqJ+G+n8kueVDBlyQ==", "91910509-c460-409f-9b60-c1a246a416b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3c8870b2-58cf-4341-8ea1-d024520563d0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ecc514c-8843-4df1-a60e-e1c1afef1f6c", "AQAAAAIAAYagAAAAENNh+jbsGfByGroWKAnOITbEypj86uM6fn77Z3auwJLF3jYn5okupGYr0z+2u3eCeQ==", "89d8895e-1526-4812-a5f8-c85edd2e08a6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57c0a3b2-bf91-4c97-9a31-cb7b454c1415",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "65779719-e9ec-4ef9-9724-ab69dba38daf", "AQAAAAIAAYagAAAAEE4ELJVqiH4vqc3GpE1h87wlUvfIUucWYKh4eFrHdUvI9xEgOGGeNrpeO/LT0vaweA==", "c205b9f8-e3da-41f6-9cee-c2ae2cfc2141" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57e1941c-1412-4384-b819-d67a19204baf",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "396601e1-4f3e-457c-bb5e-d84823782a19", "ANGELOVZ@ABV.BG", "ANGELOVZ@ABV.BG", "AQAAAAIAAYagAAAAEDNiUgw0VRxKuD45MMQpcisKndIhs/NixkkSLZ5g7ECVbH42ACgo2SJwKORmc6GjjQ==", "f1a30c54-35ee-4934-9803-a642643bf1a8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "621fb5c5-b634-405d-951b-3088891c3d5c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fabef8f-2196-40ea-9c3c-4555381e91e2", "AQAAAAIAAYagAAAAEJDKsfzfePby8vukERU6c2B0ZmDTp2Gw6WepvJF8COPgLfM8q+xzYJQGKkdfQiaXKg==", "ae0e4d36-f061-4f9b-9c28-565465bd67e5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76222e29-cbf5-4335-b2e4-fa6a77afeab1",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5acb41fa-0cfa-4952-a07d-531689279c4e", "JENNIFER.MILLER@EXAMPLE.COM", "JENNIFER.MILLER@EXAMPLE.COM", "AQAAAAIAAYagAAAAEIGhMPphlV0sbadcRZk7qH+8AcvnWttMKWtNpirgKEUnpYUj7aUPEt/RE4HeKpLohw==", "0acc8b2d-6b8d-45a0-9950-60f8009ad8cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78429ef3-6e8f-441a-8224-cf9a41152a2c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "55004615-a158-49d3-ac94-46ac394be36d", "AQAAAAIAAYagAAAAEJ1d7MySe+U2HUwr2ha6nbiZXxya5stlmUh0zNrzeVTTlzydIoYfivB1EwDrr0zsxw==", "ca865acc-92c2-4fe5-b985-3cea83232040" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c032bc0-04e2-4111-bbfb-a59d46791529",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f0c96c1-6faa-478d-b39c-1560e2130f55", "TASKOVAO@ABV.BG", "TASKOVAO@ABV.BG", "AQAAAAIAAYagAAAAEFV959RRYhvg7Ll/umRFIYzYS0xAiPTHdspNY+YN0as0qKWWwonivYkIj1bWFM9HvA==", "196f7c47-3ae2-4e87-9239-258e20a213ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c99b5d-6573-4514-81eb-183ace313419",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ee7164d-e6ac-483e-a673-250f9e930e7b", "DAVID.TAYLOR@EXAMPLE.COM", "DAVID.TAYLOR@EXAMPLE.COM", "AQAAAAIAAYagAAAAEHWbnaO4y2/yUAZSiM3dDGGpWwyqz5oR2mJV3IXPW3yE3g7gZ2uLgh+HpV+1uANFwg==", "251122c8-260b-452a-8b82-a40147052bb3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a001bd24-5c2a-4f7a-b000-5f7bd233cd12",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09364051-8c73-46ef-b52a-0e77b981df2c", "JAMES.ANDERSON@EXAMPLE.COM", "JAMES.ANDERSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEDC/WcRnu/KMmo10kiR4ry+sFIDXLeiLWe0N0/Z0G9Bm8JYlciOhnQi+NGTtHtJ6zg==", "5abee15e-7a1e-4bfb-bea3-e57c834170ad" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a15998c9-52af-4c6b-a032-b135b879e5a7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07095467-217d-43d1-9924-7c4a6c672164", "AQAAAAIAAYagAAAAEJe/GdaPPKmRZ+pKZKEdn7DSBy6YlvqwKlzMdxS7ty0i7r2lnXGsHKTNj4UWRwWgiw==", "2c141b24-2ba8-4604-b25c-5b02480863ea" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8d287e8-357a-40f3-893a-ed507ed6a85d",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41728920-0efb-4be8-b4c6-f6d87a968de0", "SUSAN.ANDERSON@EXAMPLE.COM", "SUSAN.ANDERSON@EXAMPLE.COM", "AQAAAAIAAYagAAAAEH8eO1d3eeqtYFaPDISnd4qWSGjmSsyTxYrXqvhZepuaVUiYB6D2Qivnrd5ASzfSjw==", "21abaada-4883-426d-85ce-4b5a6301c5f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af558d53-8adc-45ba-bfdd-1ca9e11e7185",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "331bb38c-3bb9-474f-ae91-9c1d0e4757b2", "AQAAAAIAAYagAAAAEKvRm7XAH4a247PY8mvuBAoK5GoNh5rW8yy+/l3xJimqwSSNurknCvHjp32wPcTH3A==", "cf3a0575-f0f5-4a9d-be10-96ede43f3a0a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c55b3e3f-6604-4bf4-a9c8-014d0c146003",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "700966d2-6b30-4cd1-a580-6eca6586eecc", "AQAAAAIAAYagAAAAEGfOUIkYBN7ALkHlXz+OrhBcmb9aPlITXzyUceCsIN9caJ2uP8oX95MDZvPKhZgVKA==", "770ff2ae-5279-4142-8937-87d6947ab353" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6e29719-7856-4b5f-b5da-84ed3a292877",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6b7da226-da41-41f1-81df-3566fa4ebf7e", "SLAVEYKIR@ABV.BG", "SLAVEYKIR@ABV.BG", "AQAAAAIAAYagAAAAEO+NNjzrxdrKBZEcLs7eZcpx02rre/GrUhiwQ1qkPO1PFWRkcFqU+Wb9KgJg2jbtGg==", "cdb33106-4b50-41b9-8a0f-7f38eb5f5cc3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8d0d177-60a0-4925-b4ed-bb36aebb48c4",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7e352d1-a6d5-47cc-af65-dfb617cc4401", "ELIZABETH.MOORE@EXAMPLE.COM", "ELIZABETH.MOORE@EXAMPLE.COM", "AQAAAAIAAYagAAAAEFL4dY/BouqqUTEmC143ZVrJAGr3Oe9dLKsvF7uK5RRKSdu5rwiLMJ5ysbD9MwI+kQ==", "ee058937-be2a-4815-8028-b67ff6298f35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd5538d3-1f68-412f-9949-94edde16d8a2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "358fe4c6-69c7-4e27-919d-113d7cd0fce4", "AQAAAAIAAYagAAAAEGtY6wRQ+KLNv4zrf+TyUD86Um0tPnc/6MBRo4tBzQZxwC/LgUJEDMPa6cNdMe8R+g==", "b32cd278-c032-4153-bf02-98629b1ed2c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fddefbf4-e1a5-42a1-a64d-e0843640267c",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0212367d-65e2-4417-850a-cc133e42ffef", "ATANASOVAO@ABV.BG", "ATANASOVAO@ABV.BG", "AQAAAAIAAYagAAAAELrzRmQF64jaNeK0YMU6NMVARo45482oKEDKcO+rZ4Se4Wqu0aiPZF1C9WFKZQx62A==", "80d1d420-bbe9-4e4b-bcf1-ff8e1c409849" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "072ac36f-71f5-44ec-a846-715ac11facb7", null, null, "AQAAAAIAAYagAAAAEB6NM0Kkjp0pPB21LjJWM7ZtpWsqQAHQa4LAE0S3OBUfCAmnDJ4NhcMgdqViZpejcA==", "cd04ca30-ddf9-45ec-8268-9a61a0a197eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "15050ff2-ed6c-475f-8831-f61d54a29175",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb74396c-d1a3-4154-9499-3390957b469b", null, null, "AQAAAAIAAYagAAAAENw5kac+mBhvmW1o59fsW8kkUfgnwXNmgiGspe5+ejkG2VggDYC50jQGiAwkDw1wEg==", "2036af03-33d6-4809-b718-6583cc03bfd0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "17139a72-76d4-4362-aa27-18a64cc8d285",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95700ec6-2e8b-405c-90eb-51a10398332d", null, null, "AQAAAAIAAYagAAAAEKwiBUcUHML8Nez89B9W/pxGhtdioewt37FeQozblcMo3Tkcyw6E8ZSnIqtFJHAMOw==", "bb54f961-c569-4a31-bc5d-4fc313bd6a23" });

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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87393628-999d-412b-94e0-d4cfa74af63a", null, null, "AQAAAAIAAYagAAAAEPHhv8eNsUm/oknddKfXFoFGQYGItOiS6YH4mWZ6PLtRIcCni+GFG/A05ENw2fBXpg==", "f1c460d5-d447-48a2-998f-702e5479edb7" });

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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7dcc3fd-e212-4912-bdb9-3ab0165ef3c0", null, null, "AQAAAAIAAYagAAAAEMIJHTImfWe6cTSwhW2HpQotrr10wt0W6bgn+vCXCVthknx9OXRcy++8IYe++yre4g==", "33c09b81-6e60-4b22-98ad-a295681f98c1" });

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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "af72ed65-a3b7-435d-950d-e413a3b53d77", null, null, "AQAAAAIAAYagAAAAEC1yPsikuWe2zFrnGy9vh4FbMy80mhelOAIoC8eGZhrg4EHBkcfyHU5svguzqxMGQQ==", "6e6d899f-19f9-4b31-b9f0-bd95a39fea97" });

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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24b71c1d-fb2d-48f0-adc9-28971462f4d0", null, null, "AQAAAAIAAYagAAAAENqyjB5nAtx0+By/A55WZX2XxiYZPoQ8i/AyR3Mxfhv3tVEHXb2sA3IpaKK76GK7lg==", "2a0b2d1c-10df-4ea9-a2bb-bee93c8938d4" });

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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc1f0d83-3b84-4743-b399-512d0994117c", null, null, "AQAAAAIAAYagAAAAEGyDhE2AkGetrcopMRw93bctghr9Ed51I0xejoUrmokji9Sx5c9GYdKIFnVnaklqhQ==", "bcc5b916-0fb7-41b6-bca7-04d100ee73d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82c99b5d-6573-4514-81eb-183ace313419",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d8c276a-8a15-49ca-ba6b-d81ae6b08650", null, null, "AQAAAAIAAYagAAAAEOaM7ZkmVreELbGb1Axw8wxY82/4E1ZH+vSi0zPCZO4XMq2N5mf0FSn5sgK85P0EeQ==", "2b76b4f6-5484-4f96-856d-76163c1516e6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a001bd24-5c2a-4f7a-b000-5f7bd233cd12",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dd4e7906-61b3-4da5-98cf-3b6c4324fb59", null, null, "AQAAAAIAAYagAAAAEAJHRuDu8ouMoJR8plGvn6jshVc6DVO52NvaPFfdyFJJ/82yQMpHPY8UOjfS05sssQ==", "c2f630f1-94e3-461e-9030-09a1c06442cf" });

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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77efee74-8767-44f6-890d-a9fb16e1fe36", null, null, "AQAAAAIAAYagAAAAEKvocJxLbb3XGYMpDw8Og6k8nOMJa+xex11Lpy67Hej1M7Q7C8Q67njwy0QDijsVMw==", "5552211e-3e8e-4b71-978c-71d25f7bb4c7" });

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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1776d0fd-dc6a-4e04-803d-f467e4df05f8", null, null, "AQAAAAIAAYagAAAAEK//uPNVeHzeja0oYexIGDHHhIrGV+7jWFpWOzMh2PH4mkA3bye9rMVQh+rI+TvGDQ==", "594cf32c-8de7-4905-82e1-f7edb11d4091" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8d0d177-60a0-4925-b4ed-bb36aebb48c4",
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac421ca1-e333-4ca7-b465-5fb121389a1b", null, null, "AQAAAAIAAYagAAAAEAPpueuFgsuXqEKPAoood80hydRq3FpkaFmd6qZVmvFrbXFn19GZVfI7p51Z3wa4cA==", "2c38a6d8-f7da-4d6f-b7bd-7a21ee7b23be" });

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
                columns: new[] { "ConcurrencyStamp", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a19c8dc-45bc-4265-a5de-4f4118cdcc01", null, null, "AQAAAAIAAYagAAAAENOeWpjLOWTq04yiAgymwYao9UuUyxy7HXJU94ck39/tJaSKydb555L5PUZDEGcWNg==", "f812eeea-1a54-4ea8-afe3-6f34d9165b9e" });
        }
    }
}
