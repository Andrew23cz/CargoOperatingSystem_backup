using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedAirlineAndAwbStock : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AwbNumber",
                table: "Shipments");

            migrationBuilder.AddColumn<int>(
                name: "AwbStockId",
                table: "Workloads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AwbStockId",
                table: "Shipments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AwbStockId",
                table: "Mawbs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AwbStockId",
                table: "Hawbs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AwbStockId",
                table: "Dimensions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Airline",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Prefix = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Header = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airline", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AwbStock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AwbNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirlineId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AirlineId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AwbStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AwbStock_Airline_AirlineId1",
                        column: x => x.AirlineId1,
                        principalTable: "Airline",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "c5e7f300-3dbd-47ce-864c-d15481d59181");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "0f995e80-902c-4823-afee-07087143cf99");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bddc3d74-2a83-4308-836c-5fa3fda08a35", "AQAAAAEAACcQAAAAEIfSqCZLtbh+ROO3uYBYJ/ctF616A2OdrY98v1TltEMqwVzE5zVtMicMNDQCWxSsdw==", "6310678b-173c-4651-b9da-0dde90146823" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 459, DateTimeKind.Local).AddTicks(9980), new DateTime(2022, 1, 3, 19, 43, 49, 462, DateTimeKind.Local).AddTicks(5407) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 463, DateTimeKind.Local).AddTicks(5269), new DateTime(2022, 1, 3, 19, 43, 49, 463, DateTimeKind.Local).AddTicks(5285) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 463, DateTimeKind.Local).AddTicks(5357), new DateTime(2022, 1, 3, 19, 43, 49, 463, DateTimeKind.Local).AddTicks(5360) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 463, DateTimeKind.Local).AddTicks(9333), new DateTime(2022, 1, 3, 19, 43, 49, 463, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(1213), new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(1228) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(1236), new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(1238) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(4776), new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(4792) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(6096), new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(6109) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(6117), new DateTime(2022, 1, 3, 19, 43, 49, 464, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 465, DateTimeKind.Local).AddTicks(564), new DateTime(2022, 1, 3, 19, 43, 49, 465, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 465, DateTimeKind.Local).AddTicks(2538), new DateTime(2022, 1, 3, 19, 43, 49, 465, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 19, 43, 49, 465, DateTimeKind.Local).AddTicks(2568), new DateTime(2022, 1, 3, 19, 43, 49, 465, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.CreateIndex(
                name: "IX_Workloads_AwbStockId",
                table: "Workloads",
                column: "AwbStockId");

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_AwbStockId",
                table: "Shipments",
                column: "AwbStockId");

            migrationBuilder.CreateIndex(
                name: "IX_Mawbs_AwbStockId",
                table: "Mawbs",
                column: "AwbStockId");

            migrationBuilder.CreateIndex(
                name: "IX_Hawbs_AwbStockId",
                table: "Hawbs",
                column: "AwbStockId");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_AwbStockId",
                table: "Dimensions",
                column: "AwbStockId");

            migrationBuilder.CreateIndex(
                name: "IX_AwbStock_AirlineId1",
                table: "AwbStock",
                column: "AirlineId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Dimensions_AwbStock_AwbStockId",
                table: "Dimensions",
                column: "AwbStockId",
                principalTable: "AwbStock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Hawbs_AwbStock_AwbStockId",
                table: "Hawbs",
                column: "AwbStockId",
                principalTable: "AwbStock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mawbs_AwbStock_AwbStockId",
                table: "Mawbs",
                column: "AwbStockId",
                principalTable: "AwbStock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_AwbStock_AwbStockId",
                table: "Shipments",
                column: "AwbStockId",
                principalTable: "AwbStock",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Workloads_AwbStock_AwbStockId",
                table: "Workloads",
                column: "AwbStockId",
                principalTable: "AwbStock",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dimensions_AwbStock_AwbStockId",
                table: "Dimensions");

            migrationBuilder.DropForeignKey(
                name: "FK_Hawbs_AwbStock_AwbStockId",
                table: "Hawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Mawbs_AwbStock_AwbStockId",
                table: "Mawbs");

            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_AwbStock_AwbStockId",
                table: "Shipments");

            migrationBuilder.DropForeignKey(
                name: "FK_Workloads_AwbStock_AwbStockId",
                table: "Workloads");

            migrationBuilder.DropTable(
                name: "AwbStock");

            migrationBuilder.DropTable(
                name: "Airline");

            migrationBuilder.DropIndex(
                name: "IX_Workloads_AwbStockId",
                table: "Workloads");

            migrationBuilder.DropIndex(
                name: "IX_Shipments_AwbStockId",
                table: "Shipments");

            migrationBuilder.DropIndex(
                name: "IX_Mawbs_AwbStockId",
                table: "Mawbs");

            migrationBuilder.DropIndex(
                name: "IX_Hawbs_AwbStockId",
                table: "Hawbs");

            migrationBuilder.DropIndex(
                name: "IX_Dimensions_AwbStockId",
                table: "Dimensions");

            migrationBuilder.DropColumn(
                name: "AwbStockId",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "AwbStockId",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "AwbStockId",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "AwbStockId",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "AwbStockId",
                table: "Dimensions");

            migrationBuilder.AddColumn<string>(
                name: "AwbNumber",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "df87b461-869f-45b3-9d57-bfe73ad5a7c3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "271ab113-17cb-4169-b4fa-c28553276c23");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da9929d6-b734-4e7c-ae62-48ac414be61d", "AQAAAAEAACcQAAAAEK+us6QyzniL09pqPI5q8UIgF6jEbgkTDpmIvqfSVWvp8+prufnOpYnHYM750Pnbsg==", "2ba07d92-824c-48be-b087-e3c9a0529dfc" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 577, DateTimeKind.Local).AddTicks(5956), new DateTime(2022, 1, 3, 9, 15, 28, 589, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 590, DateTimeKind.Local).AddTicks(8305), new DateTime(2022, 1, 3, 9, 15, 28, 590, DateTimeKind.Local).AddTicks(8331) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 590, DateTimeKind.Local).AddTicks(8442), new DateTime(2022, 1, 3, 9, 15, 28, 590, DateTimeKind.Local).AddTicks(8446) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(383), new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(443) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(3280), new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(3311), new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(8341), new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(8361) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(9960), new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(9983), new DateTime(2022, 1, 3, 9, 15, 28, 592, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 593, DateTimeKind.Local).AddTicks(5585), new DateTime(2022, 1, 3, 9, 15, 28, 593, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 593, DateTimeKind.Local).AddTicks(8015), new DateTime(2022, 1, 3, 9, 15, 28, 593, DateTimeKind.Local).AddTicks(8030) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 3, 9, 15, 28, 593, DateTimeKind.Local).AddTicks(8041), new DateTime(2022, 1, 3, 9, 15, 28, 593, DateTimeKind.Local).AddTicks(8044) });
        }
    }
}
