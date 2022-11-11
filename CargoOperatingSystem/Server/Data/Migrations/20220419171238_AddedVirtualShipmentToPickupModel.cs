using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedVirtualShipmentToPickupModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pickups_ShipmentId",
                table: "Pickups");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "722aabcb-07a9-4e69-8817-b5a43f314a52");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "9f8d8216-0b7f-4015-8434-6a356fb779af");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc5e5113-b6f6-4b90-afaa-542ace31a8d3", "AQAAAAEAACcQAAAAEKYagWY9ILsa3o0+zwO0qNA9d6T16fsXICx4BudXURKMBCgmwIhFY6oRiHsTUJIXYA==", "0a4c4854-0d1c-4540-8c69-d6e65d8e6371" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d129b036-03c3-4a05-917e-d84deab48a57", "AQAAAAEAACcQAAAAEF04lP1mS2ZEoXAk6NmkSZbIZl8ECXK1K3wHC7kNXiRFZrq3EggcnmR5aezZZwEemg==", "a96dc68c-7400-4e4a-8129-fc3e8bc54689" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 19, 19, 12, 37, 649, DateTimeKind.Local).AddTicks(2996), new DateTime(2022, 4, 19, 19, 12, 37, 651, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 19, 19, 12, 37, 652, DateTimeKind.Local).AddTicks(8871), new DateTime(2022, 4, 19, 19, 12, 37, 652, DateTimeKind.Local).AddTicks(8889) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 19, 19, 12, 37, 652, DateTimeKind.Local).AddTicks(8957), new DateTime(2022, 4, 19, 19, 12, 37, 652, DateTimeKind.Local).AddTicks(8960) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 19, 19, 12, 37, 653, DateTimeKind.Local).AddTicks(3032), new DateTime(2022, 4, 19, 19, 12, 37, 653, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 19, 19, 12, 37, 653, DateTimeKind.Local).AddTicks(4893), new DateTime(2022, 4, 19, 19, 12, 37, 653, DateTimeKind.Local).AddTicks(4907) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 19, 19, 12, 37, 653, DateTimeKind.Local).AddTicks(4915), new DateTime(2022, 4, 19, 19, 12, 37, 653, DateTimeKind.Local).AddTicks(4918) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 19, 19, 12, 37, 653, DateTimeKind.Local).AddTicks(8721), new DateTime(2022, 4, 19, 19, 12, 37, 653, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 19, 19, 12, 37, 653, DateTimeKind.Local).AddTicks(9973), new DateTime(2022, 4, 19, 19, 12, 37, 653, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 19, 19, 12, 37, 653, DateTimeKind.Local).AddTicks(9995), new DateTime(2022, 4, 19, 19, 12, 37, 653, DateTimeKind.Local).AddTicks(9998) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 19, 19, 12, 37, 654, DateTimeKind.Local).AddTicks(3718), new DateTime(2022, 4, 19, 19, 12, 37, 654, DateTimeKind.Local).AddTicks(3735) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 19, 19, 12, 37, 654, DateTimeKind.Local).AddTicks(5625), new DateTime(2022, 4, 19, 19, 12, 37, 654, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 19, 19, 12, 37, 654, DateTimeKind.Local).AddTicks(5647), new DateTime(2022, 4, 19, 19, 12, 37, 654, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.CreateIndex(
                name: "IX_Pickups_ShipmentId",
                table: "Pickups",
                column: "ShipmentId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pickups_ShipmentId",
                table: "Pickups");

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

            migrationBuilder.CreateIndex(
                name: "IX_Pickups_ShipmentId",
                table: "Pickups",
                column: "ShipmentId");
        }
    }
}
