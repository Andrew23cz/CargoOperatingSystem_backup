using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class ImplementedArrivalInShipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArrivalId",
                table: "Shipments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Arrival",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArrivalPoint = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverPhone = table.Column<int>(type: "int", nullable: false),
                    CarColour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LicensePlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arrival", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Arrival_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "c6d07628-4759-4985-8055-6f2bfe2d274d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "90891935-e80b-44ce-b3ac-b8481511238d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4159f2c4-92a0-4179-9fbf-93a6ee1bcf9d", "AQAAAAEAACcQAAAAEO9QK3cvqlIoWhF/tx7e49IkAm4riQtAJtw+/GyFAMZnm2zR84GWi+ZfJyQGVMZljg==", "5af484dd-0a41-44be-b9d9-f00eacadecdb" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 14, 15, 2, DateTimeKind.Local).AddTicks(5368), new DateTime(2021, 12, 29, 13, 14, 15, 8, DateTimeKind.Local).AddTicks(2827) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 14, 15, 10, DateTimeKind.Local).AddTicks(7210), new DateTime(2021, 12, 29, 13, 14, 15, 10, DateTimeKind.Local).AddTicks(7250) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 14, 15, 10, DateTimeKind.Local).AddTicks(7429), new DateTime(2021, 12, 29, 13, 14, 15, 10, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 14, 15, 11, DateTimeKind.Local).AddTicks(7047), new DateTime(2021, 12, 29, 13, 14, 15, 11, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 14, 15, 12, DateTimeKind.Local).AddTicks(2107), new DateTime(2021, 12, 29, 13, 14, 15, 12, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 14, 15, 12, DateTimeKind.Local).AddTicks(2154), new DateTime(2021, 12, 29, 13, 14, 15, 12, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 14, 15, 12, DateTimeKind.Local).AddTicks(6609), new DateTime(2021, 12, 29, 13, 14, 15, 12, DateTimeKind.Local).AddTicks(6628) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 14, 15, 12, DateTimeKind.Local).AddTicks(8077), new DateTime(2021, 12, 29, 13, 14, 15, 12, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 14, 15, 12, DateTimeKind.Local).AddTicks(8102), new DateTime(2021, 12, 29, 13, 14, 15, 12, DateTimeKind.Local).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 14, 15, 13, DateTimeKind.Local).AddTicks(2597), new DateTime(2021, 12, 29, 13, 14, 15, 13, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 14, 15, 13, DateTimeKind.Local).AddTicks(4796), new DateTime(2021, 12, 29, 13, 14, 15, 13, DateTimeKind.Local).AddTicks(4811) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 14, 15, 13, DateTimeKind.Local).AddTicks(4821), new DateTime(2021, 12, 29, 13, 14, 15, 13, DateTimeKind.Local).AddTicks(4824) });

            migrationBuilder.CreateIndex(
                name: "IX_Shipments_ArrivalId",
                table: "Shipments",
                column: "ArrivalId");

            migrationBuilder.CreateIndex(
                name: "IX_Arrival_SupplierId",
                table: "Arrival",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Arrival_ArrivalId",
                table: "Shipments",
                column: "ArrivalId",
                principalTable: "Arrival",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Arrival_ArrivalId",
                table: "Shipments");

            migrationBuilder.DropTable(
                name: "Arrival");

            migrationBuilder.DropIndex(
                name: "IX_Shipments_ArrivalId",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "ArrivalId",
                table: "Shipments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "de529523-01f7-4aa8-b7e9-c73f6b285930");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "33dc0898-33db-4d99-99dd-ebae483d9eee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "140bab50-604c-4edf-92c0-29f72892434d", "AQAAAAEAACcQAAAAECkH4sxEhy2SJOz+271ncCYqH/KPW0uDh77vc6EhHjfDlmM/aiKdgJOPtpoYQ5gIIQ==", "4ee4a732-1d39-42b8-b114-448bf9d892aa" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 521, DateTimeKind.Local).AddTicks(5911), new DateTime(2021, 12, 29, 11, 20, 38, 524, DateTimeKind.Local).AddTicks(1668) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(1779), new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(1875), new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(1878) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(5956), new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(5973) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(8013), new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(8036), new DateTime(2021, 12, 29, 11, 20, 38, 525, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(1611), new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(2938), new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(2960), new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(2962) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(6688), new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(6703) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(8776), new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(8798), new DateTime(2021, 12, 29, 11, 20, 38, 526, DateTimeKind.Local).AddTicks(8801) });
        }
    }
}
