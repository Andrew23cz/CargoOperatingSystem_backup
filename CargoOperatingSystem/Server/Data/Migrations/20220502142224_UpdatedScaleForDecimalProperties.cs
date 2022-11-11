using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedScaleForDecimalProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "WorkloadAmount",
                table: "Workloads",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "OrderAmount",
                table: "Orders",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "InvoiceAmount",
                table: "Invoices",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "ChargeTemplate",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Charge",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "DeliveryAmount",
                table: "Deliveries",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "ExchangeRate",
                table: "Currency",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2);

            migrationBuilder.AlterColumn<decimal>(
                name: "RateWeightBreak500",
                table: "AfRates",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RateWeightBreak45",
                table: "AfRates",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RateWeightBreak300",
                table: "AfRates",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RateWeightBreak250",
                table: "AfRates",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RateWeightBreak1000",
                table: "AfRates",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RateWeightBreak100",
                table: "AfRates",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PivotWeight",
                table: "AfRates",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PivotRate",
                table: "AfRates",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OverPivotRate",
                table: "AfRates",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NormalFlatRate",
                table: "AfRates",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MinimumRate",
                table: "AfRates",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FlatPrice",
                table: "AfRates",
                type: "decimal(12,4)",
                precision: 12,
                scale: 4,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,2)",
                oldPrecision: 12,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "dd249c2d-b315-4b6c-9e97-80e4f0727ef9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "8f6e919b-e66f-49ab-958e-9b9f2d7edf50");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9da127e5-ae2d-4f07-a47b-e21cea64b472", "AQAAAAEAACcQAAAAEBVm8HK3XL/sUnpIfygk28GkyufV7fIBWYrP6MNMqfNwxu8P4+ieFpBcqJee09HDgA==", "7695b089-30c9-48fa-a8c4-d02b96469392" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dcc7d13b-2b21-455a-939d-386948c062bb", "AQAAAAEAACcQAAAAEF851oxtWLDugWxsPkeLmIuYe+9GPMUoKer8viPD4qfduaoR/8SYGqGqf1aHUlIzSA==", "cf23b2bd-1a44-47dd-a9d4-c140f567a9b7" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 374, DateTimeKind.Local).AddTicks(281), new DateTime(2022, 5, 2, 16, 22, 23, 376, DateTimeKind.Local).AddTicks(6474) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 377, DateTimeKind.Local).AddTicks(6306), new DateTime(2022, 5, 2, 16, 22, 23, 377, DateTimeKind.Local).AddTicks(6323) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 377, DateTimeKind.Local).AddTicks(6397), new DateTime(2022, 5, 2, 16, 22, 23, 377, DateTimeKind.Local).AddTicks(6400) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(413), new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(430) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(2184), new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(2206), new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(5692), new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(5708) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(6964), new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(6984), new DateTime(2022, 5, 2, 16, 22, 23, 378, DateTimeKind.Local).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 379, DateTimeKind.Local).AddTicks(684), new DateTime(2022, 5, 2, 16, 22, 23, 379, DateTimeKind.Local).AddTicks(700) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 379, DateTimeKind.Local).AddTicks(2873), new DateTime(2022, 5, 2, 16, 22, 23, 379, DateTimeKind.Local).AddTicks(2887) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 16, 22, 23, 379, DateTimeKind.Local).AddTicks(2896), new DateTime(2022, 5, 2, 16, 22, 23, 379, DateTimeKind.Local).AddTicks(2898) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "WorkloadAmount",
                table: "Workloads",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "OrderAmount",
                table: "Orders",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "InvoiceAmount",
                table: "Invoices",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "ChargeTemplate",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "Amount",
                table: "Charge",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "DeliveryAmount",
                table: "Deliveries",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "ExchangeRate",
                table: "Currency",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4);

            migrationBuilder.AlterColumn<decimal>(
                name: "RateWeightBreak500",
                table: "AfRates",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RateWeightBreak45",
                table: "AfRates",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RateWeightBreak300",
                table: "AfRates",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RateWeightBreak250",
                table: "AfRates",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RateWeightBreak1000",
                table: "AfRates",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "RateWeightBreak100",
                table: "AfRates",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PivotWeight",
                table: "AfRates",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "PivotRate",
                table: "AfRates",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "OverPivotRate",
                table: "AfRates",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "NormalFlatRate",
                table: "AfRates",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "MinimumRate",
                table: "AfRates",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "FlatPrice",
                table: "AfRates",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(12,4)",
                oldPrecision: 12,
                oldScale: 4,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "b1522e29-0bb6-4b35-89cd-d124698d8094");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "105939ed-9abb-40f8-b755-8fe0d2ead0df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7e52e50-cd08-4526-85fa-cc6071d0333b", "AQAAAAEAACcQAAAAEO8eBb6ztyCMfKIRLu6UPKyBRvMsmUHyMMReHllC9LU23NaPjL9mKGf+8IJO0DvRbw==", "f2b9e2aa-341d-4583-9f20-adea81949e95" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38f65b5e-266b-4ad3-9dac-3b0d8fa40a43", "AQAAAAEAACcQAAAAEEnkrdFfiL9AQ6nyzDXY8CkYDn+eOR4vQ5t5viMfs4+GOn3Ma6AXpU1esvnlSJiXeg==", "eaca0b6e-c1e4-4696-b995-0fb35d2a4f10" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 849, DateTimeKind.Local).AddTicks(8207), new DateTime(2022, 5, 2, 15, 32, 8, 852, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(2705), new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(2721) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(2802), new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(6666), new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(6681) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(8556), new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(8579), new DateTime(2022, 5, 2, 15, 32, 8, 853, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(2174), new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(3606), new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(3628), new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(3631) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(7509), new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(7525) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(9669), new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(9691), new DateTime(2022, 5, 2, 15, 32, 8, 854, DateTimeKind.Local).AddTicks(9694) });
        }
    }
}
