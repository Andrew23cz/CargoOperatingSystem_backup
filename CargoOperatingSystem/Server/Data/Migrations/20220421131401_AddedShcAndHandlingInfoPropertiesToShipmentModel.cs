using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedShcAndHandlingInfoPropertiesToShipmentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HandlingInformationA",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HandlingInformationB",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HandlingInformationC",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShcA",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShcB",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShcC",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "aadd49fb-44c1-4f97-ba77-aa2e92a49d31");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "b154df40-493e-463d-b7d3-df956be718b6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d27f502-f41f-4b9c-9357-4fc841f65f92", "AQAAAAEAACcQAAAAELDncmri39BATusrdpr3fVlkN6+2FXXt12hp95mu8iFg+2BtfLy9W/72naameAc1Jg==", "6e62dd06-9723-498e-b71c-a0f5ffb2154f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "795f0ac7-ba00-493d-88e1-e28d1129cb8c", "AQAAAAEAACcQAAAAEGgY0Ee5faYtIUdKnYwTXyBvqu7e9KXeFt2kLo59RbiazisEHeLM2NUEQM4tS6ok9w==", "4b29fab4-324e-4060-8ce6-7d54435dbcdd" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 844, DateTimeKind.Local).AddTicks(7604), new DateTime(2022, 4, 21, 15, 14, 0, 847, DateTimeKind.Local).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(3659), new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(3751), new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(7659), new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(9494), new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(9515), new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 849, DateTimeKind.Local).AddTicks(3019), new DateTime(2022, 4, 21, 15, 14, 0, 849, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 849, DateTimeKind.Local).AddTicks(4322), new DateTime(2022, 4, 21, 15, 14, 0, 849, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 849, DateTimeKind.Local).AddTicks(4344), new DateTime(2022, 4, 21, 15, 14, 0, 849, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 849, DateTimeKind.Local).AddTicks(8144), new DateTime(2022, 4, 21, 15, 14, 0, 849, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 850, DateTimeKind.Local).AddTicks(438), new DateTime(2022, 4, 21, 15, 14, 0, 850, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 850, DateTimeKind.Local).AddTicks(460), new DateTime(2022, 4, 21, 15, 14, 0, 850, DateTimeKind.Local).AddTicks(462) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HandlingInformationA",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "HandlingInformationB",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "HandlingInformationC",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "ShcA",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "ShcB",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "ShcC",
                table: "Shipments");

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
        }
    }
}
