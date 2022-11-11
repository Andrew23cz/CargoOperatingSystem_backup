using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedChargeAndSupplierModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OtherChargeCode",
                table: "Charge",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Charge",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "cd3aee3e-1146-4d44-acc3-864d8d946dc7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "ab72cc41-c8e1-49a6-b6c9-667044079cab");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d08096c9-89e7-4371-8ad2-13c8eeb4907f", "AQAAAAEAACcQAAAAEB84RL+iBPBDt4MEH3WJNdKAOxtLphqgpCJyij1AMxWVxwxzmshQ+vw4vYy7Wk0/EQ==", "699e9054-5dc7-4c85-9fea-d75fb056c1f1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "13234f63-649e-41c0-803d-39d7a9496c17", "AQAAAAEAACcQAAAAEOWi5OSjwwbZZJ/UbS6eCXcW7raSpru32Jk+83ekr2hCs8EcBNtwDg0LH7KXZrTq4g==", "dfa7789d-d127-410e-b26c-26668e72193e" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 19, 45, 15, 129, DateTimeKind.Local).AddTicks(4407), new DateTime(2022, 4, 9, 19, 45, 15, 132, DateTimeKind.Local).AddTicks(1827) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 19, 45, 15, 133, DateTimeKind.Local).AddTicks(2422), new DateTime(2022, 4, 9, 19, 45, 15, 133, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 19, 45, 15, 133, DateTimeKind.Local).AddTicks(2554), new DateTime(2022, 4, 9, 19, 45, 15, 133, DateTimeKind.Local).AddTicks(2558) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 19, 45, 15, 133, DateTimeKind.Local).AddTicks(6329), new DateTime(2022, 4, 9, 19, 45, 15, 133, DateTimeKind.Local).AddTicks(6345) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 19, 45, 15, 133, DateTimeKind.Local).AddTicks(8112), new DateTime(2022, 4, 9, 19, 45, 15, 133, DateTimeKind.Local).AddTicks(8125) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 19, 45, 15, 133, DateTimeKind.Local).AddTicks(8134), new DateTime(2022, 4, 9, 19, 45, 15, 133, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 19, 45, 15, 134, DateTimeKind.Local).AddTicks(1723), new DateTime(2022, 4, 9, 19, 45, 15, 134, DateTimeKind.Local).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 19, 45, 15, 134, DateTimeKind.Local).AddTicks(3071), new DateTime(2022, 4, 9, 19, 45, 15, 134, DateTimeKind.Local).AddTicks(3085) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 19, 45, 15, 134, DateTimeKind.Local).AddTicks(3093), new DateTime(2022, 4, 9, 19, 45, 15, 134, DateTimeKind.Local).AddTicks(3096) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 19, 45, 15, 134, DateTimeKind.Local).AddTicks(6919), new DateTime(2022, 4, 9, 19, 45, 15, 134, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 19, 45, 15, 134, DateTimeKind.Local).AddTicks(8915), new DateTime(2022, 4, 9, 19, 45, 15, 134, DateTimeKind.Local).AddTicks(8929) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 19, 45, 15, 134, DateTimeKind.Local).AddTicks(8937), new DateTime(2022, 4, 9, 19, 45, 15, 134, DateTimeKind.Local).AddTicks(8940) });

            migrationBuilder.CreateIndex(
                name: "IX_Charge_SupplierId",
                table: "Charge",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Charge_Suppliers_SupplierId",
                table: "Charge",
                column: "SupplierId",
                principalTable: "Suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Charge_Suppliers_SupplierId",
                table: "Charge");

            migrationBuilder.DropIndex(
                name: "IX_Charge_SupplierId",
                table: "Charge");

            migrationBuilder.DropColumn(
                name: "OtherChargeCode",
                table: "Charge");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Charge");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "ff9bbf48-029d-43f3-abe7-1e5e2401f517");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "e03ff787-c2ff-4928-a708-ec3a62a5dbaf");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6eb02fcd-f73d-435c-a18a-9652f19de919", "AQAAAAEAACcQAAAAEFFDQGkjP0Hzj+soDhvNpUyt7eS5ruqJWSLktiT9stgfUrzu/UnL7zzUqiCHowqh7A==", "1ece85c3-4f9d-4bca-b192-9ed6005d3f39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a69c89a7-293a-477b-8470-d9b17b382c14", "AQAAAAEAACcQAAAAEHd1Ses1UuIbrUpGfQgWq1Wmzs2CzWtl06C5kWzDrbhXiuVYWfW0IO4atBHA9moKVA==", "17faa842-343b-4c25-a73a-5b84d473c250" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 362, DateTimeKind.Local).AddTicks(3572), new DateTime(2022, 4, 9, 17, 9, 11, 366, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 367, DateTimeKind.Local).AddTicks(7333), new DateTime(2022, 4, 9, 17, 9, 11, 367, DateTimeKind.Local).AddTicks(7355) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 367, DateTimeKind.Local).AddTicks(7432), new DateTime(2022, 4, 9, 17, 9, 11, 367, DateTimeKind.Local).AddTicks(7435) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(1696), new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(3522), new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(3543), new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(3546) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(7082), new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(8396), new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(8409) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(8416), new DateTime(2022, 4, 9, 17, 9, 11, 368, DateTimeKind.Local).AddTicks(8419) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 369, DateTimeKind.Local).AddTicks(2229), new DateTime(2022, 4, 9, 17, 9, 11, 369, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 369, DateTimeKind.Local).AddTicks(4534), new DateTime(2022, 4, 9, 17, 9, 11, 369, DateTimeKind.Local).AddTicks(4547) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 17, 9, 11, 369, DateTimeKind.Local).AddTicks(4555), new DateTime(2022, 4, 9, 17, 9, 11, 369, DateTimeKind.Local).AddTicks(4558) });
        }
    }
}
