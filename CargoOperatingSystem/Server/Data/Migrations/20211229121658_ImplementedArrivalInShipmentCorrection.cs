using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class ImplementedArrivalInShipmentCorrection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Workloads_WorkloadId",
                table: "Shipments");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadId",
                table: "Shipments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DriverPhone",
                table: "Arrival",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "746eb93e-0ef1-4df5-b1c4-2ad0ab91828a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "b1163da0-7a27-4925-b3a5-857317b9bc92");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "897a31ae-a103-4c2b-a247-91f09644aa10", "AQAAAAEAACcQAAAAEHZMXFAI+X0vP96V38c35KE+Eda7y7yNTIz9J8Hc1N5vWFNZL9TXwgtO/MUpYh+C5Q==", "caf9804b-f4de-47be-8925-9e5f6045d8e0" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 673, DateTimeKind.Local).AddTicks(8207), new DateTime(2021, 12, 29, 13, 16, 57, 676, DateTimeKind.Local).AddTicks(3795) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(3580), new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(3598) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(3672), new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(3675) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(7492), new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(7508) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(9397), new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(9418), new DateTime(2021, 12, 29, 13, 16, 57, 677, DateTimeKind.Local).AddTicks(9421) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(2925), new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(4173), new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(4185) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(4192), new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(4194) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(7919), new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(9961), new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(9974) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(9982), new DateTime(2021, 12, 29, 13, 16, 57, 678, DateTimeKind.Local).AddTicks(9984) });

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Workloads_WorkloadId",
                table: "Shipments",
                column: "WorkloadId",
                principalTable: "Workloads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shipments_Workloads_WorkloadId",
                table: "Shipments");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadId",
                table: "Shipments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DriverPhone",
                table: "Arrival",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Shipments_Workloads_WorkloadId",
                table: "Shipments",
                column: "WorkloadId",
                principalTable: "Workloads",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
