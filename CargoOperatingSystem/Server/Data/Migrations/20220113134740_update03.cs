using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class update03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_Mawbs_MawbId",
                table: "Hawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_Shipments_ShipmentId",
                table: "Mawbs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "794df704-60dc-43da-aac9-88da2b49800c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "e629e49e-bb02-4bbe-a49e-170082234989");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c49e8c9-82ef-469c-94ef-ee3f94063f1c", "AQAAAAEAACcQAAAAEPYyEkNKxuJq1P3Uo9rv9oR74LjO6+UtfXAsQZK6OP2WMSfIl6KqXqUs1OU7AZ4dNQ==", "fae0de51-ed7a-4618-bd93-0fab254c1de0" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 759, DateTimeKind.Local).AddTicks(8830), new DateTime(2022, 1, 13, 14, 47, 38, 771, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 772, DateTimeKind.Local).AddTicks(5808), new DateTime(2022, 1, 13, 14, 47, 38, 772, DateTimeKind.Local).AddTicks(5836) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 772, DateTimeKind.Local).AddTicks(5944), new DateTime(2022, 1, 13, 14, 47, 38, 772, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 773, DateTimeKind.Local).AddTicks(1350), new DateTime(2022, 1, 13, 14, 47, 38, 773, DateTimeKind.Local).AddTicks(1387) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 773, DateTimeKind.Local).AddTicks(3684), new DateTime(2022, 1, 13, 14, 47, 38, 773, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 773, DateTimeKind.Local).AddTicks(3713), new DateTime(2022, 1, 13, 14, 47, 38, 773, DateTimeKind.Local).AddTicks(3717) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 773, DateTimeKind.Local).AddTicks(8838), new DateTime(2022, 1, 13, 14, 47, 38, 773, DateTimeKind.Local).AddTicks(8865) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(416), new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(443), new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(448) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(5340), new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(5358) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(7760), new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(7788), new DateTime(2022, 1, 13, 14, 47, 38, 774, DateTimeKind.Local).AddTicks(7792) });

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_Mawbs_MawbId",
                table: "Hawbs",
                column: "MawbId",
                principalTable: "Mawbs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_Shipments_ShipmentId",
                table: "Mawbs",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_Mawbs_MawbId",
                table: "Hawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_Shipments_ShipmentId",
                table: "Mawbs");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "4001997c-9f82-4c87-9d36-8cf9d1d4f719");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "cd83e937-12e0-4e21-9818-38521a04e399");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abc3b20b-94c9-4057-9ca8-653fd8ff6174", "AQAAAAEAACcQAAAAENb47fDcZ054Ee8q/GLqrmTxjdlnbUaFQ0TKCR/tr3tDPwbV437h1Eb/HnDseCI2nQ==", "f214f706-fb38-4fda-b456-0a7e3e2cabdc" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 17, 9, 413, DateTimeKind.Local).AddTicks(1479), new DateTime(2022, 1, 13, 14, 17, 9, 424, DateTimeKind.Local).AddTicks(685) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 17, 9, 425, DateTimeKind.Local).AddTicks(5744), new DateTime(2022, 1, 13, 14, 17, 9, 425, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 17, 9, 425, DateTimeKind.Local).AddTicks(5896), new DateTime(2022, 1, 13, 14, 17, 9, 425, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 17, 9, 426, DateTimeKind.Local).AddTicks(1317), new DateTime(2022, 1, 13, 14, 17, 9, 426, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 17, 9, 426, DateTimeKind.Local).AddTicks(3470), new DateTime(2022, 1, 13, 14, 17, 9, 426, DateTimeKind.Local).AddTicks(3485) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 17, 9, 426, DateTimeKind.Local).AddTicks(3578), new DateTime(2022, 1, 13, 14, 17, 9, 426, DateTimeKind.Local).AddTicks(3582) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 17, 9, 426, DateTimeKind.Local).AddTicks(8968), new DateTime(2022, 1, 13, 14, 17, 9, 426, DateTimeKind.Local).AddTicks(8990) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 17, 9, 427, DateTimeKind.Local).AddTicks(508), new DateTime(2022, 1, 13, 14, 17, 9, 427, DateTimeKind.Local).AddTicks(522) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 17, 9, 427, DateTimeKind.Local).AddTicks(533), new DateTime(2022, 1, 13, 14, 17, 9, 427, DateTimeKind.Local).AddTicks(536) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 17, 9, 427, DateTimeKind.Local).AddTicks(9404), new DateTime(2022, 1, 13, 14, 17, 9, 427, DateTimeKind.Local).AddTicks(9456) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 17, 9, 428, DateTimeKind.Local).AddTicks(4966), new DateTime(2022, 1, 13, 14, 17, 9, 428, DateTimeKind.Local).AddTicks(4999) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 17, 9, 428, DateTimeKind.Local).AddTicks(5015), new DateTime(2022, 1, 13, 14, 17, 9, 428, DateTimeKind.Local).AddTicks(5018) });

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_Mawbs_MawbId",
                table: "Hawbs",
                column: "MawbId",
                principalTable: "Mawbs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_Shipments_ShipmentId",
                table: "Mawbs",
                column: "ShipmentId",
                principalTable: "Shipments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
