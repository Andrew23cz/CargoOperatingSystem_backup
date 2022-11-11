using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class update05 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_Consignees_ConsigneeId",
                table: "Hawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_Mawbs_MawbId",
                table: "Hawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_Shippers_ShipperId",
                table: "Hawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_Consignees_ConsigneeId",
                table: "Mawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_Shippers_ShipperId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Mawbs_ConsigneeId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Mawbs_ShipperId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Hawbs_ConsigneeId",
                table: "Hawbs");

            migrationBuilder.DropIndex(
                name: "IX_Hawbs_ShipperId",
                table: "Hawbs");

            migrationBuilder.RenameColumn(
                name: "ShipperId",
                table: "Mawbs",
                newName: "ShipperPhoneNumber");

            migrationBuilder.RenameColumn(
                name: "ConsigneeId",
                table: "Mawbs",
                newName: "ConsigneePhoneNumber");

            migrationBuilder.RenameColumn(
                name: "ShipperId",
                table: "Hawbs",
                newName: "ShipperPhoneNumber");

            migrationBuilder.RenameColumn(
                name: "ConsigneeId",
                table: "Hawbs",
                newName: "ConsigneePhoneNumber");

            migrationBuilder.AddColumn<int>(
                name: "HawbId",
                table: "Shippers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MawbId",
                table: "Shippers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsigneeAddress",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsigneeEmail",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsigneeName",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsigneeTemplate",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipperAddress",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipperEmail",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipperName",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipperTemplate",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsigneeAddress",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsigneeEmail",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsigneeName",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ConsigneeTemplate",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipperAddress",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipperEmail",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipperName",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShipperTemplate",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HawbId",
                table: "Consignees",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MawbId",
                table: "Consignees",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "dd21c2e5-d278-4988-934c-ff3ef8636592");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "74cc8842-c9ff-4c8e-aae7-61057d3aa73e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dec0bc51-c291-4006-bd06-fedf4a89a984", "AQAAAAEAACcQAAAAEBr9XFH96TOlcvwJ4RmRN4yosRgUljnFxpBS3KSHjnnK+R6qRF8Xlut8UqFc5s1wdg==", "c828b721-0f66-4d3d-87c4-f098d0077768" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 66, DateTimeKind.Local).AddTicks(7900), new DateTime(2022, 1, 13, 16, 30, 27, 78, DateTimeKind.Local).AddTicks(3814) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 79, DateTimeKind.Local).AddTicks(9028), new DateTime(2022, 1, 13, 16, 30, 27, 79, DateTimeKind.Local).AddTicks(9074) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 79, DateTimeKind.Local).AddTicks(9210), new DateTime(2022, 1, 13, 16, 30, 27, 79, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 80, DateTimeKind.Local).AddTicks(4666), new DateTime(2022, 1, 13, 16, 30, 27, 80, DateTimeKind.Local).AddTicks(4685) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 80, DateTimeKind.Local).AddTicks(7104), new DateTime(2022, 1, 13, 16, 30, 27, 80, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 80, DateTimeKind.Local).AddTicks(7131), new DateTime(2022, 1, 13, 16, 30, 27, 80, DateTimeKind.Local).AddTicks(7134) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 81, DateTimeKind.Local).AddTicks(1915), new DateTime(2022, 1, 13, 16, 30, 27, 81, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 81, DateTimeKind.Local).AddTicks(3538), new DateTime(2022, 1, 13, 16, 30, 27, 81, DateTimeKind.Local).AddTicks(3553) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 81, DateTimeKind.Local).AddTicks(3563), new DateTime(2022, 1, 13, 16, 30, 27, 81, DateTimeKind.Local).AddTicks(3566) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 81, DateTimeKind.Local).AddTicks(9149), new DateTime(2022, 1, 13, 16, 30, 27, 81, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 82, DateTimeKind.Local).AddTicks(1614), new DateTime(2022, 1, 13, 16, 30, 27, 82, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 16, 30, 27, 82, DateTimeKind.Local).AddTicks(1639), new DateTime(2022, 1, 13, 16, 30, 27, 82, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.CreateIndex(
                name: "IX_Shippers_HawbId",
                table: "Shippers",
                column: "HawbId");

            migrationBuilder.CreateIndex(
                name: "IX_Shippers_MawbId",
                table: "Shippers",
                column: "MawbId");

            migrationBuilder.CreateIndex(
                name: "IX_Consignees_HawbId",
                table: "Consignees",
                column: "HawbId");

            migrationBuilder.CreateIndex(
                name: "IX_Consignees_MawbId",
                table: "Consignees",
                column: "MawbId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consignees_Hawbs_HawbId",
                table: "Consignees",
                column: "HawbId",
                principalTable: "Hawbs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Consignees_Mawbs_MawbId",
                table: "Consignees",
                column: "MawbId",
                principalTable: "Mawbs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_Mawbs_MawbId",
                table: "Hawbs",
                column: "MawbId",
                principalTable: "Mawbs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shippers_Hawbs_HawbId",
                table: "Shippers",
                column: "HawbId",
                principalTable: "Hawbs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Shippers_Mawbs_MawbId",
                table: "Shippers",
                column: "MawbId",
                principalTable: "Mawbs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consignees_Hawbs_HawbId",
                table: "Consignees");

            migrationBuilder.DropForeignKey(
                name: "FK_Consignees_Mawbs_MawbId",
                table: "Consignees");

            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_Mawbs_MawbId",
                table: "Hawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Shippers_Hawbs_HawbId",
                table: "Shippers");

            migrationBuilder.DropForeignKey(
                name: "FK_Shippers_Mawbs_MawbId",
                table: "Shippers");

            migrationBuilder.DropIndex(
                name: "IX_Shippers_HawbId",
                table: "Shippers");

            migrationBuilder.DropIndex(
                name: "IX_Shippers_MawbId",
                table: "Shippers");

            migrationBuilder.DropIndex(
                name: "IX_Consignees_HawbId",
                table: "Consignees");

            migrationBuilder.DropIndex(
                name: "IX_Consignees_MawbId",
                table: "Consignees");

            migrationBuilder.DropColumn(
                name: "HawbId",
                table: "Shippers");

            migrationBuilder.DropColumn(
                name: "MawbId",
                table: "Shippers");

            migrationBuilder.DropColumn(
                name: "ConsigneeAddress",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ConsigneeEmail",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ConsigneeName",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ConsigneeTemplate",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ShipperAddress",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ShipperEmail",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ShipperName",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ShipperTemplate",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "ConsigneeAddress",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ConsigneeEmail",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ConsigneeName",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ConsigneeTemplate",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ShipperAddress",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ShipperEmail",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ShipperName",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "ShipperTemplate",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "HawbId",
                table: "Consignees");

            migrationBuilder.DropColumn(
                name: "MawbId",
                table: "Consignees");

            migrationBuilder.RenameColumn(
                name: "ShipperPhoneNumber",
                table: "Mawbs",
                newName: "ShipperId");

            migrationBuilder.RenameColumn(
                name: "ConsigneePhoneNumber",
                table: "Mawbs",
                newName: "ConsigneeId");

            migrationBuilder.RenameColumn(
                name: "ShipperPhoneNumber",
                table: "Hawbs",
                newName: "ShipperId");

            migrationBuilder.RenameColumn(
                name: "ConsigneePhoneNumber",
                table: "Hawbs",
                newName: "ConsigneeId");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "872eaab8-c4e9-47d2-ad56-20c1b05b7d75");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "13a43c1b-dad1-4d5f-9b30-9904f664299b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfd8787c-c249-4fde-a0cc-dde761fd8599", "AQAAAAEAACcQAAAAEKpef6sXT2f51eOnTB/SCKaIIMKX67A3rPfiVrA80WcRI+sSG8ZmQwR5t4MfnmS+rA==", "4abcb543-19c1-4e53-8483-c30d3e608859" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 81, DateTimeKind.Local).AddTicks(1820), new DateTime(2022, 1, 13, 15, 28, 39, 94, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 96, DateTimeKind.Local).AddTicks(5766), new DateTime(2022, 1, 13, 15, 28, 39, 96, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 96, DateTimeKind.Local).AddTicks(6001), new DateTime(2022, 1, 13, 15, 28, 39, 96, DateTimeKind.Local).AddTicks(6005) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 97, DateTimeKind.Local).AddTicks(2812), new DateTime(2022, 1, 13, 15, 28, 39, 97, DateTimeKind.Local).AddTicks(2876) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 97, DateTimeKind.Local).AddTicks(5512), new DateTime(2022, 1, 13, 15, 28, 39, 97, DateTimeKind.Local).AddTicks(5529) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 97, DateTimeKind.Local).AddTicks(5540), new DateTime(2022, 1, 13, 15, 28, 39, 97, DateTimeKind.Local).AddTicks(5544) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 98, DateTimeKind.Local).AddTicks(2296), new DateTime(2022, 1, 13, 15, 28, 39, 98, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 98, DateTimeKind.Local).AddTicks(6042), new DateTime(2022, 1, 13, 15, 28, 39, 98, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 98, DateTimeKind.Local).AddTicks(6118), new DateTime(2022, 1, 13, 15, 28, 39, 98, DateTimeKind.Local).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 99, DateTimeKind.Local).AddTicks(4043), new DateTime(2022, 1, 13, 15, 28, 39, 99, DateTimeKind.Local).AddTicks(4140) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 99, DateTimeKind.Local).AddTicks(7717), new DateTime(2022, 1, 13, 15, 28, 39, 99, DateTimeKind.Local).AddTicks(7742) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 13, 15, 28, 39, 99, DateTimeKind.Local).AddTicks(7753), new DateTime(2022, 1, 13, 15, 28, 39, 99, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_ConsigneeId",
                table: "Mawbs",
                column: "ConsigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_ShipperId",
                table: "Mawbs",
                column: "ShipperId");

            migrationBuilder.CreateIndex(
                name: "IX_Hawbs_ConsigneeId",
                table: "Hawbs",
                column: "ConsigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Hawbs_ShipperId",
                table: "Hawbs",
                column: "ShipperId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_Consignees_ConsigneeId",
                table: "Hawbs",
                column: "ConsigneeId",
                principalTable: "Consignees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_Mawbs_MawbId",
                table: "Hawbs",
                column: "MawbId",
                principalTable: "Mawbs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_Shippers_ShipperId",
                table: "Hawbs",
                column: "ShipperId",
                principalTable: "Shippers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_Consignees_ConsigneeId",
                table: "Mawbs",
                column: "ConsigneeId",
                principalTable: "Consignees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_Shippers_ShipperId",
                table: "Mawbs",
                column: "ShipperId",
                principalTable: "Shippers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
