using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class update02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs");

            migrationBuilder.AlterColumn<int>(
                name: "ShipmentId",
                table: "Mawbs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MawbId",
                table: "Hawbs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs",
                column: "ShipmentId",
                unique: true,
                filter: "[ShipmentId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs");

            migrationBuilder.AlterColumn<int>(
                name: "ShipmentId",
                table: "Mawbs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MawbId",
                table: "Hawbs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "badff4bc-25a0-4410-8092-a0c45b8cddfc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "876938e1-6680-41da-b0e1-30c34cc3310f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "328d5489-480b-4112-9589-edb467bf9dec", "AQAAAAEAACcQAAAAEPXf7/sSYHgVzBn4m5jk9D9GgGQSWAD95Vfj6DQk5+kdMupRxf6J4UhNxiSPT9Vd/A==", "d6a1bc53-48d4-421a-a2fb-ddf482aced18" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 716, DateTimeKind.Local).AddTicks(353), new DateTime(2022, 1, 13, 14, 7, 9, 728, DateTimeKind.Local).AddTicks(454) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 729, DateTimeKind.Local).AddTicks(9823), new DateTime(2022, 1, 13, 14, 7, 9, 729, DateTimeKind.Local).AddTicks(9884) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 730, DateTimeKind.Local).AddTicks(30), new DateTime(2022, 1, 13, 14, 7, 9, 730, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 730, DateTimeKind.Local).AddTicks(6409), new DateTime(2022, 1, 13, 14, 7, 9, 730, DateTimeKind.Local).AddTicks(6439) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 730, DateTimeKind.Local).AddTicks(8822), new DateTime(2022, 1, 13, 14, 7, 9, 730, DateTimeKind.Local).AddTicks(8839) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 730, DateTimeKind.Local).AddTicks(8850), new DateTime(2022, 1, 13, 14, 7, 9, 730, DateTimeKind.Local).AddTicks(8853) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 731, DateTimeKind.Local).AddTicks(4287), new DateTime(2022, 1, 13, 14, 7, 9, 731, DateTimeKind.Local).AddTicks(4312) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 731, DateTimeKind.Local).AddTicks(9848), new DateTime(2022, 1, 13, 14, 7, 9, 731, DateTimeKind.Local).AddTicks(9900) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 731, DateTimeKind.Local).AddTicks(9918), new DateTime(2022, 1, 13, 14, 7, 9, 731, DateTimeKind.Local).AddTicks(9923) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 732, DateTimeKind.Local).AddTicks(8881), new DateTime(2022, 1, 13, 14, 7, 9, 732, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 733, DateTimeKind.Local).AddTicks(1982), new DateTime(2022, 1, 13, 14, 7, 9, 733, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 14, 7, 9, 733, DateTimeKind.Local).AddTicks(2012), new DateTime(2022, 1, 13, 14, 7, 9, 733, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_ShipmentId",
                table: "Mawbs",
                column: "ShipmentId",
                unique: true);
        }
    }
}
