using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class RemadeDimensionModelIntoPickupModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dimensions");

            migrationBuilder.AddColumn<int>(
                name: "MawbId",
                table: "Dimmension",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Pickups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PickupAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeliveryAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PickupDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShipmentId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pickups", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pickups_Shipments_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "7b0899d7-5f68-4f9e-a08f-4faf4b9a4cb5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "f4c5056f-37b0-4b1a-85d2-36c18e5f1bc7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4541f10-ce47-45bd-9e4d-c293ca4d0587", "AQAAAAEAACcQAAAAEG4XuNAafHhz+VwhT/2VCMdZXoLyfu74wIc1cHkrAbdBjMSRbEoCqIIxDrN7JPDUhA==", "205e0e42-eca3-404f-951c-d7942c4a6957" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc2f5945-77e1-45f1-8df9-81c703bac4c7", "AQAAAAEAACcQAAAAEBUJA7MDbFnMiwOe6RfA3qp0gYVziAsz+F/oDFj02V/L4aZwGcvbvRHJ56jgtQ+bTA==", "9b4dd1d1-7269-4834-97d3-70922a8b2b4d" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 225, DateTimeKind.Local).AddTicks(3498), new DateTime(2022, 3, 2, 22, 1, 55, 227, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(226), new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(243) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(321), new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(324) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(4480), new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(4496) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(6402), new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(6415) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(6422), new DateTime(2022, 3, 2, 22, 1, 55, 229, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(156), new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(1513), new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(1526) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(1533), new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(1536) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(6031), new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(6048) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(8465), new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(8489), new DateTime(2022, 3, 2, 22, 1, 55, 230, DateTimeKind.Local).AddTicks(8492) });

            migrationBuilder.CreateIndex(
                name: "IX_Dimmension_MawbId",
                table: "Dimmension",
                column: "MawbId");

            migrationBuilder.CreateIndex(
                name: "IX_Pickups_ShipmentId",
                table: "Pickups",
                column: "ShipmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dimmension_Mawbs_MawbId",
                table: "Dimmension",
                column: "MawbId",
                principalTable: "Mawbs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dimmension_Mawbs_MawbId",
                table: "Dimmension");

            migrationBuilder.DropTable(
                name: "Pickups");

            migrationBuilder.DropIndex(
                name: "IX_Dimmension_MawbId",
                table: "Dimmension");

            migrationBuilder.DropColumn(
                name: "MawbId",
                table: "Dimmension");

            migrationBuilder.CreateTable(
                name: "Dimensions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyIdentity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Height = table.Column<double>(type: "float", nullable: false),
                    Length = table.Column<double>(type: "float", nullable: false),
                    MawbId = table.Column<int>(type: "int", nullable: true),
                    Pieces = table.Column<int>(type: "int", nullable: false),
                    ShipmentId = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dimensions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dimensions_Mawbs_MawbId",
                        column: x => x.MawbId,
                        principalTable: "Mawbs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Dimensions_Shipments_ShipmentId",
                        column: x => x.ShipmentId,
                        principalTable: "Shipments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "c5951112-2bbf-47b4-bfbd-685b854e6ecc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "9651a44e-d830-4698-be14-1b49ef6faea3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c728fd48-6634-4c42-88e3-ba85e54f1df2", "AQAAAAEAACcQAAAAELQyZJB9XPmpg8nGS0N1kqCK/kpbVlnSCf24w2qDXfcW1q3ZSfSYaXX7EgmiGf8LqQ==", "1fe6d209-68a4-4264-94b2-0b55050eab21" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69a7e31f-945c-4349-b99c-94403577b409", "AQAAAAEAACcQAAAAEDezHwgBnDo7tH/lX2yBUEfxV3RLyOcuCprAlLmfClzL4QhUkJkTHquLUzrDw7H3eA==", "c4b0427f-5c4f-4bd3-a58e-267e7c48ff63" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 544, DateTimeKind.Local).AddTicks(5823), new DateTime(2022, 3, 1, 20, 44, 44, 547, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(2624), new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(2641) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(2718), new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(2722) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(6816), new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(8808), new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(8821) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(8829), new DateTime(2022, 3, 1, 20, 44, 44, 548, DateTimeKind.Local).AddTicks(8832) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 549, DateTimeKind.Local).AddTicks(2885), new DateTime(2022, 3, 1, 20, 44, 44, 549, DateTimeKind.Local).AddTicks(2901) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 549, DateTimeKind.Local).AddTicks(4174), new DateTime(2022, 3, 1, 20, 44, 44, 549, DateTimeKind.Local).AddTicks(4186) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 549, DateTimeKind.Local).AddTicks(4193), new DateTime(2022, 3, 1, 20, 44, 44, 549, DateTimeKind.Local).AddTicks(4196) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 549, DateTimeKind.Local).AddTicks(8162), new DateTime(2022, 3, 1, 20, 44, 44, 549, DateTimeKind.Local).AddTicks(8177) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 550, DateTimeKind.Local).AddTicks(570), new DateTime(2022, 3, 1, 20, 44, 44, 550, DateTimeKind.Local).AddTicks(587) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 3, 1, 20, 44, 44, 550, DateTimeKind.Local).AddTicks(600), new DateTime(2022, 3, 1, 20, 44, 44, 550, DateTimeKind.Local).AddTicks(604) });

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_MawbId",
                table: "Dimensions",
                column: "MawbId");

            migrationBuilder.CreateIndex(
                name: "IX_Dimensions_ShipmentId",
                table: "Dimensions",
                column: "ShipmentId");
        }
    }
}
