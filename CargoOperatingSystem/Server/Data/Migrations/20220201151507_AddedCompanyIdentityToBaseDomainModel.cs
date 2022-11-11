using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedCompanyIdentityToBaseDomainModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CompanyIdentity",
                table: "Workloads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyIdentity",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyIdentity",
                table: "Shippers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyIdentity",
                table: "Shipments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyIdentity",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyIdentity",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyIdentity",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyIdentity",
                table: "Hawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyIdentity",
                table: "Dimensions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyIdentity",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyIdentity",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyIdentity",
                table: "Consignees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyIdentity",
                table: "AwbStock",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyIdentity",
                table: "Arrival",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CompanyIdentity",
                table: "Airline",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "40843e43-0837-40f7-860b-5396610958e2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "b63ff633-e377-4791-80df-03e97d965882");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3404062-5a5b-4f56-a7b2-9bbff8c5efad", "AQAAAAEAACcQAAAAEKzQQn9GmlTcwgqJbkQcna8bA1pyk/9CiimH7l57vJEBHfts4tGhsXcl4qhE7HyiRA==", "741309c9-7617-4681-b3fc-275f67fdd7f3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d0f4341-ed9d-4e91-b294-1216d96f6aa5", "AQAAAAEAACcQAAAAEKdSye1rHmcPKBJnIr9vO6Hig+0LNcjGsPYgEdyu2IB1Dag0uKaY6HkFmGkQt/Blng==", "4bbe5542-3519-45c3-a9f7-1bb6a9b5b02e" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 136, DateTimeKind.Local).AddTicks(3955), new DateTime(2022, 2, 1, 16, 15, 6, 139, DateTimeKind.Local).AddTicks(1165) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(1390), new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(1407) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(1485), new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(1488) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(5467), new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(5483) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(7350), new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(7364) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(7372), new DateTime(2022, 2, 1, 16, 15, 6, 140, DateTimeKind.Local).AddTicks(7374) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(1054), new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(1071) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(2417), new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(2438), new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(6409), new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(6425) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(9721), new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(9742) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(9751), new DateTime(2022, 2, 1, 16, 15, 6, 141, DateTimeKind.Local).AddTicks(9754) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CompanyIdentity",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "CompanyIdentity",
                table: "Suppliers");

            migrationBuilder.DropColumn(
                name: "CompanyIdentity",
                table: "Shippers");

            migrationBuilder.DropColumn(
                name: "CompanyIdentity",
                table: "Shipments");

            migrationBuilder.DropColumn(
                name: "CompanyIdentity",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CompanyIdentity",
                table: "Mawbs");

            migrationBuilder.DropColumn(
                name: "CompanyIdentity",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "CompanyIdentity",
                table: "Hawbs");

            migrationBuilder.DropColumn(
                name: "CompanyIdentity",
                table: "Dimensions");

            migrationBuilder.DropColumn(
                name: "CompanyIdentity",
                table: "Deliveries");

            migrationBuilder.DropColumn(
                name: "CompanyIdentity",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CompanyIdentity",
                table: "Consignees");

            migrationBuilder.DropColumn(
                name: "CompanyIdentity",
                table: "AwbStock");

            migrationBuilder.DropColumn(
                name: "CompanyIdentity",
                table: "Arrival");

            migrationBuilder.DropColumn(
                name: "CompanyIdentity",
                table: "Airline");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "a653ffb3-b2d5-4dbe-8536-bf9b6e431ba7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "a6da3f34-502b-48da-81db-c77401207a4b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70fecd22-850a-4b27-a937-2cfa10c1d53c", "AQAAAAEAACcQAAAAELCtwQZUDOHTQ0i7p5OglgmdERgODRvJ/sKcy2XIb17ffoo7H63RLU9V4TMI2gmC3Q==", "78a303f6-215d-4fc9-b21c-f29be1c2afab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6936826-16b0-401e-a897-f984608c55c5", "AQAAAAEAACcQAAAAEFC0iJ46tkzJh+Jlb21QuYl/jkYXfOUIk+PNVGL3WTkk1Ly/J/7BZvAdcmEpFe/KGQ==", "b4d32ac3-4656-45d6-b3f9-38e35972ccf2" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 206, DateTimeKind.Local).AddTicks(9742), new DateTime(2022, 1, 30, 16, 55, 15, 209, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 210, DateTimeKind.Local).AddTicks(6598), new DateTime(2022, 1, 30, 16, 55, 15, 210, DateTimeKind.Local).AddTicks(6616) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 210, DateTimeKind.Local).AddTicks(6688), new DateTime(2022, 1, 30, 16, 55, 15, 210, DateTimeKind.Local).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(749), new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(766) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(2583), new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(2605), new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(6220), new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(6237) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(7626), new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(7640) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(7648), new DateTime(2022, 1, 30, 16, 55, 15, 211, DateTimeKind.Local).AddTicks(7650) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 212, DateTimeKind.Local).AddTicks(1635), new DateTime(2022, 1, 30, 16, 55, 15, 212, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 212, DateTimeKind.Local).AddTicks(3849), new DateTime(2022, 1, 30, 16, 55, 15, 212, DateTimeKind.Local).AddTicks(3864) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 30, 16, 55, 15, 212, DateTimeKind.Local).AddTicks(3873), new DateTime(2022, 1, 30, 16, 55, 15, 212, DateTimeKind.Local).AddTicks(3876) });
        }
    }
}
