using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedBillingDateToShipmentAndAirlineModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BillingDate",
                table: "Shipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "BillingDateBasis",
                table: "Airline",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "ebd51080-19ca-49fa-8108-27b64be118c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "1fa01f8f-01c8-49ec-9c4f-60ceeea7c5c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49b61ff2-863f-4272-875d-5052d7d8dd01", "AQAAAAEAACcQAAAAEIOe8de69g1NHyOv+KzcNTKOwf6kYAHaefRwsyIkrr7ZZSf64wGT+PCQf+JMZi9LHw==", "3f0d6437-1bab-4222-aeed-90e56aeea3e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f6f56aa-fc79-4ff6-a1f2-aafa9ead683d", "AQAAAAEAACcQAAAAEGzGmtf76JvsQUv99dJsj+C6FbNqGCoCw9yooMzlPw5GTbrthfAchVhwgbKViA5f0g==", "be09fd30-646c-416c-b183-fd8d5987f5e9" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 934, DateTimeKind.Local).AddTicks(984), new DateTime(2022, 4, 29, 13, 29, 26, 936, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 937, DateTimeKind.Local).AddTicks(6088), new DateTime(2022, 4, 29, 13, 29, 26, 937, DateTimeKind.Local).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 937, DateTimeKind.Local).AddTicks(6178), new DateTime(2022, 4, 29, 13, 29, 26, 937, DateTimeKind.Local).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 937, DateTimeKind.Local).AddTicks(9948), new DateTime(2022, 4, 29, 13, 29, 26, 937, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(1708), new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(1729), new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(5369), new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(6664), new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(6685), new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 939, DateTimeKind.Local).AddTicks(653), new DateTime(2022, 4, 29, 13, 29, 26, 939, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 939, DateTimeKind.Local).AddTicks(2782), new DateTime(2022, 4, 29, 13, 29, 26, 939, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 939, DateTimeKind.Local).AddTicks(2803), new DateTime(2022, 4, 29, 13, 29, 26, 939, DateTimeKind.Local).AddTicks(2806) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BillingDate",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "BillingDateBasis",
                table: "Airline");

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
    }
}
