using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedBuyingSellingPropToChargeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BuyingSelling",
                table: "Charge",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "125b8cd8-03a6-4a8f-a758-1cd5cd8c6cd9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "12b205e2-6e9c-4d58-88cd-53804404e222");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1935f1e6-3aee-46a1-8263-c65cf0bee920", "AQAAAAEAACcQAAAAEN8y1dge1BHtrYUO5l60bIN4mhmQhl/hCsWOE8H2zHXzTiLZwMPKad/9kGq7aRU0WQ==", "da1d27ea-fb70-4fa0-ab8b-246753fb740f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca500ec9-bd17-41a3-9889-44dcf69c1174", "AQAAAAEAACcQAAAAEMmxii6Mawn9Rog8VJFG7YNzo+mT7e6bZbfEIzlqkUzKgtSqOP1vG6EapAhE+waaKg==", "479435cd-3352-427b-8013-c87d3531642d" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 10, 8, 4, 28, 596, DateTimeKind.Local).AddTicks(7872), new DateTime(2022, 4, 10, 8, 4, 28, 599, DateTimeKind.Local).AddTicks(7846) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 10, 8, 4, 28, 600, DateTimeKind.Local).AddTicks(8028), new DateTime(2022, 4, 10, 8, 4, 28, 600, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 10, 8, 4, 28, 600, DateTimeKind.Local).AddTicks(8120), new DateTime(2022, 4, 10, 8, 4, 28, 600, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 10, 8, 4, 28, 601, DateTimeKind.Local).AddTicks(1970), new DateTime(2022, 4, 10, 8, 4, 28, 601, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 10, 8, 4, 28, 601, DateTimeKind.Local).AddTicks(4089), new DateTime(2022, 4, 10, 8, 4, 28, 601, DateTimeKind.Local).AddTicks(4113) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 10, 8, 4, 28, 601, DateTimeKind.Local).AddTicks(4136), new DateTime(2022, 4, 10, 8, 4, 28, 601, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 10, 8, 4, 28, 601, DateTimeKind.Local).AddTicks(9345), new DateTime(2022, 4, 10, 8, 4, 28, 601, DateTimeKind.Local).AddTicks(9362) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 10, 8, 4, 28, 602, DateTimeKind.Local).AddTicks(738), new DateTime(2022, 4, 10, 8, 4, 28, 602, DateTimeKind.Local).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 10, 8, 4, 28, 602, DateTimeKind.Local).AddTicks(760), new DateTime(2022, 4, 10, 8, 4, 28, 602, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 10, 8, 4, 28, 602, DateTimeKind.Local).AddTicks(4756), new DateTime(2022, 4, 10, 8, 4, 28, 602, DateTimeKind.Local).AddTicks(4772) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 10, 8, 4, 28, 602, DateTimeKind.Local).AddTicks(6790), new DateTime(2022, 4, 10, 8, 4, 28, 602, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 10, 8, 4, 28, 602, DateTimeKind.Local).AddTicks(6811), new DateTime(2022, 4, 10, 8, 4, 28, 602, DateTimeKind.Local).AddTicks(6814) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BuyingSelling",
                table: "Charge");

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
        }
    }
}
