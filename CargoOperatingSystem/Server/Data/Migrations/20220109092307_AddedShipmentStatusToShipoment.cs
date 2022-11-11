using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedShipmentStatusToShipoment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShipmentStatus",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "1a2ab569-b14c-431b-8e35-d4bbf93de7c7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "e057aabe-2994-4f9b-8e94-7f8d620946c5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4e5292c-2744-46e5-a42c-792f27d77aa0", "AQAAAAEAACcQAAAAELQYJND8CpUZekCLOcO67wIbPve+CqoFao3lU5aKN9VcFMb84d6oAdW7WmDEd8TgzA==", "e83ae2dc-31e1-425c-92f5-67d3493bbacb" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 886, DateTimeKind.Local).AddTicks(2383), new DateTime(2022, 1, 9, 10, 23, 5, 888, DateTimeKind.Local).AddTicks(7922) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 889, DateTimeKind.Local).AddTicks(8251), new DateTime(2022, 1, 9, 10, 23, 5, 889, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 889, DateTimeKind.Local).AddTicks(8346), new DateTime(2022, 1, 9, 10, 23, 5, 889, DateTimeKind.Local).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(2540), new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(2557) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(4300), new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(4313) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(4320), new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(4323) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(7808), new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(9099), new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(9120), new DateTime(2022, 1, 9, 10, 23, 5, 890, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 891, DateTimeKind.Local).AddTicks(3140), new DateTime(2022, 1, 9, 10, 23, 5, 891, DateTimeKind.Local).AddTicks(3155) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 891, DateTimeKind.Local).AddTicks(5395), new DateTime(2022, 1, 9, 10, 23, 5, 891, DateTimeKind.Local).AddTicks(5409) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 9, 10, 23, 5, 891, DateTimeKind.Local).AddTicks(5416), new DateTime(2022, 1, 9, 10, 23, 5, 891, DateTimeKind.Local).AddTicks(5419) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShipmentStatus",
                table: "Shipments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "c2f6d9a9-ea3d-46ea-906b-d425922e8fd5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "77dee6bc-e3f0-4cb3-92ba-c84ea3c0917a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a014727e-4421-4e5a-b86e-3a63ce98c4c0", "AQAAAAEAACcQAAAAEL3ci33siyfHc+079kEQffmtXkePZmfFkwHtNPUf4H0EgtzRVAMWZFuPQj2jSTbbSg==", "03c4495b-b219-4929-b18c-253f781506cd" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 549, DateTimeKind.Local).AddTicks(1006), new DateTime(2022, 1, 8, 20, 59, 39, 551, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 552, DateTimeKind.Local).AddTicks(6697), new DateTime(2022, 1, 8, 20, 59, 39, 552, DateTimeKind.Local).AddTicks(6714) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 552, DateTimeKind.Local).AddTicks(6790), new DateTime(2022, 1, 8, 20, 59, 39, 552, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(846), new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(2612), new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(2634), new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(2637) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(6149), new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(7406), new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(7419) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(7426), new DateTime(2022, 1, 8, 20, 59, 39, 553, DateTimeKind.Local).AddTicks(7429) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 554, DateTimeKind.Local).AddTicks(1188), new DateTime(2022, 1, 8, 20, 59, 39, 554, DateTimeKind.Local).AddTicks(1203) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 554, DateTimeKind.Local).AddTicks(3406), new DateTime(2022, 1, 8, 20, 59, 39, 554, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 8, 20, 59, 39, 554, DateTimeKind.Local).AddTicks(3429), new DateTime(2022, 1, 8, 20, 59, 39, 554, DateTimeKind.Local).AddTicks(3432) });
        }
    }
}
