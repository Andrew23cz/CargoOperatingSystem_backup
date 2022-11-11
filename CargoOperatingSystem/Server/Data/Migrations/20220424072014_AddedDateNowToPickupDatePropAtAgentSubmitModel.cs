using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedDateNowToPickupDatePropAtAgentSubmitModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "4c516bf1-f980-465c-bc00-66f062e13472");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "463a4eb1-1206-4823-96d8-1e53292fdee4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6e2306b-5ad7-4443-9a1c-eb61d3684913", "AQAAAAEAACcQAAAAEMZduU0jzecxQKlJLhjGiUyq9KZMKnWIr8BjgbnpgRi7JWBQdqOLcOCDe0m4AKLh3w==", "b935b030-4efb-4543-82a1-c6ddbe9a6c41" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b58cce3-db0c-4c4d-bdd7-8016c004a953", "AQAAAAEAACcQAAAAELEJuov+ac34maxhcN8MITnEtRxQ7oQG8oJB4VLfcGZwUnpgPxfSXxOBApmrYy4YDw==", "d5928ec7-525e-45dc-9cab-e09cc26039d7" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 24, 9, 20, 13, 147, DateTimeKind.Local).AddTicks(1024), new DateTime(2022, 4, 24, 9, 20, 13, 150, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 24, 9, 20, 13, 151, DateTimeKind.Local).AddTicks(2789), new DateTime(2022, 4, 24, 9, 20, 13, 151, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 24, 9, 20, 13, 151, DateTimeKind.Local).AddTicks(2898), new DateTime(2022, 4, 24, 9, 20, 13, 151, DateTimeKind.Local).AddTicks(2902) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 24, 9, 20, 13, 151, DateTimeKind.Local).AddTicks(6810), new DateTime(2022, 4, 24, 9, 20, 13, 151, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 24, 9, 20, 13, 151, DateTimeKind.Local).AddTicks(8595), new DateTime(2022, 4, 24, 9, 20, 13, 151, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 24, 9, 20, 13, 151, DateTimeKind.Local).AddTicks(8618), new DateTime(2022, 4, 24, 9, 20, 13, 151, DateTimeKind.Local).AddTicks(8621) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 24, 9, 20, 13, 152, DateTimeKind.Local).AddTicks(2325), new DateTime(2022, 4, 24, 9, 20, 13, 152, DateTimeKind.Local).AddTicks(2341) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 24, 9, 20, 13, 152, DateTimeKind.Local).AddTicks(5588), new DateTime(2022, 4, 24, 9, 20, 13, 152, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 24, 9, 20, 13, 152, DateTimeKind.Local).AddTicks(5616), new DateTime(2022, 4, 24, 9, 20, 13, 152, DateTimeKind.Local).AddTicks(5619) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 24, 9, 20, 13, 152, DateTimeKind.Local).AddTicks(9667), new DateTime(2022, 4, 24, 9, 20, 13, 152, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 24, 9, 20, 13, 153, DateTimeKind.Local).AddTicks(1690), new DateTime(2022, 4, 24, 9, 20, 13, 153, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 24, 9, 20, 13, 153, DateTimeKind.Local).AddTicks(1712), new DateTime(2022, 4, 24, 9, 20, 13, 153, DateTimeKind.Local).AddTicks(1715) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "8c5f6eb1-783c-4a93-ab79-4f4fd9d83b58");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "f82602a9-d4e0-48a1-8160-2c86c702fa63");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfd73274-ebb7-40d9-bf36-01c43adab888", "AQAAAAEAACcQAAAAEIgNi2dpEZRU/98/vcAkD9u0XsJEaSlqvS74Ww0F9wuASvbo1Ap4sboLk5e5UksY3w==", "82ad811b-bd51-4ad3-9257-e9b88d9bcf74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "898a1b1a-674f-461b-afee-f0960bfed523", "AQAAAAEAACcQAAAAEMykehggIYRsV6l/+NHxwmWwPBTYcRnqgKLiKvq8/Unpuaws6Q0YXJ3SGeTY2tGcmQ==", "e2e837da-9965-4c52-a7e2-4e3aff342e42" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 991, DateTimeKind.Local).AddTicks(5444), new DateTime(2022, 4, 23, 13, 22, 14, 994, DateTimeKind.Local).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(1969), new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(2062), new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(6101), new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(7855), new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(7876), new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(1538), new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(2854), new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(2876), new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(6714), new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(8661), new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(8682), new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(8684) });
        }
    }
}
