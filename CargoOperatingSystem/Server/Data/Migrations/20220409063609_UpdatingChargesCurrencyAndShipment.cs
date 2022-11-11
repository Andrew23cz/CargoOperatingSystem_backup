using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatingChargesCurrencyAndShipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ShipmentId",
                table: "Charges",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "c913cebb-afa8-44ca-9c36-95a2a0f5fa42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "82f136a7-97f6-4022-a876-20f63af2d1ee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58881432-7f38-49f3-9d32-2d3bb505c6a4", "AQAAAAEAACcQAAAAEC0o0ckMGjODVXDMPqAseE1/TwBg24XCH3obJfK7A2nn8AaTa9+XlTEOy63WYf/8Sg==", "a892238c-f5ce-4e7f-857b-180aa39f4e99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b85f1d2c-22ac-4533-ab51-ce50b3718041", "AQAAAAEAACcQAAAAEISe3C15kvTduqeQS6wAw49uXlXrZ/6Q4rjmIhNNkg9v+vU7ry32NCi/3cofQUj23g==", "b20b89a5-f4c6-4ddd-af50-dbce9b9296f3" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 281, DateTimeKind.Local).AddTicks(568), new DateTime(2022, 4, 9, 8, 36, 8, 284, DateTimeKind.Local).AddTicks(1220) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(1451), new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(1470) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(1542), new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(1545) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(5571), new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(5589) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(7301), new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(7314) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(7321), new DateTime(2022, 4, 9, 8, 36, 8, 285, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(949), new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(2189), new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(2209), new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(5921), new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(7858), new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(7880), new DateTime(2022, 4, 9, 8, 36, 8, 286, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.CreateIndex(
                name: "IX_Charges_ShipmentId",
                table: "Charges",
                column: "ShipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Charges_Shipments_ShipmentId",
                table: "Charges",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Charges_Shipments_ShipmentId",
                table: "Charges");

            migrationBuilder.DropIndex(
                name: "IX_Charges_ShipmentId",
                table: "Charges");

            migrationBuilder.DropColumn(
                name: "ShipmentId",
                table: "Charges");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "d0aef859-bd75-4199-89c4-eee6120b21a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "fc9342a0-e1ea-4567-aaad-9f44df6e3f47");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "def8b214-3685-4370-abe2-f0e25b97ef02", "AQAAAAEAACcQAAAAECUX8Ge2IDkrhkuyrYYk+dxpM6XGqhoohVu5DPqvF0BIRrARJy8tEWS8q94cUE8d6Q==", "02324ecd-32b2-4556-a72a-0a4753abdb4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6e46b529-51d8-49d8-bafc-2f4f9f4f5a08", "AQAAAAEAACcQAAAAED5Ev6zfdj73K4kIYsjUPszRYTNIcAui46VBTpxCKonh2C2MbKOKPWgaVNnlNIEkDA==", "3db74d53-20bd-4ca3-8371-dbfdb33b91f6" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 818, DateTimeKind.Local).AddTicks(8037), new DateTime(2022, 3, 15, 14, 37, 9, 821, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 822, DateTimeKind.Local).AddTicks(9162), new DateTime(2022, 3, 15, 14, 37, 9, 822, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 822, DateTimeKind.Local).AddTicks(9285), new DateTime(2022, 3, 15, 14, 37, 9, 822, DateTimeKind.Local).AddTicks(9289) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 823, DateTimeKind.Local).AddTicks(4201), new DateTime(2022, 3, 15, 14, 37, 9, 823, DateTimeKind.Local).AddTicks(4223) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 823, DateTimeKind.Local).AddTicks(6271), new DateTime(2022, 3, 15, 14, 37, 9, 823, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 823, DateTimeKind.Local).AddTicks(6293), new DateTime(2022, 3, 15, 14, 37, 9, 823, DateTimeKind.Local).AddTicks(6296) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(588), new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(1935), new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(1956), new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(6231), new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(6251) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(9254), new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(9272) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(9285), new DateTime(2022, 3, 15, 14, 37, 9, 824, DateTimeKind.Local).AddTicks(9290) });
        }
    }
}
