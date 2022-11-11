using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedCurrencyRelatedModelsAndDeleteBehaviour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Charge_Currency_CurrencyId",
                table: "Charge");

            migrationBuilder.DropForeignKey(
                name: "FK_ChargeTemplate_Currency_CurrencyId",
                table: "ChargeTemplate");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkloadRateSheet_Currency_CurrencyId",
                table: "WorkloadRateSheet");

            migrationBuilder.AddColumn<int>(
                name: "WorkloadRateSheetId",
                table: "Workloads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AirlineId",
                table: "AfRates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "AfRates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "49f2cefb-9796-425b-8d53-e652564c241a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "84954764-cb20-4ffb-8e73-595202e9b14b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cbfb0748-f75e-4ceb-9b20-5f34dfef1616", "AQAAAAEAACcQAAAAEG6gWUjoKEd52RFvyBJ0fHT0dEAniog0S2ZPNcd1K200+rmm+ZJMG709pXD3OmBBQQ==", "cf821f1b-6e01-4940-886e-3501ac397d9c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ca3170c-c1d4-49bb-8321-2bfe4b6c073a", "AQAAAAEAACcQAAAAEOw5SsCyQmCJLfmRPpt+82zrPuYpwgv4DjOXNRvKQ26vQPr5dM1AG16O8UZ3sQUdxg==", "84c57d44-bae1-4033-b23c-2ff1c7aeba36" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 5, 15, 21, 49, 932, DateTimeKind.Local).AddTicks(6262), new DateTime(2022, 5, 5, 15, 21, 49, 935, DateTimeKind.Local).AddTicks(1339) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 5, 15, 21, 49, 936, DateTimeKind.Local).AddTicks(2925), new DateTime(2022, 5, 5, 15, 21, 49, 936, DateTimeKind.Local).AddTicks(2943) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 5, 15, 21, 49, 936, DateTimeKind.Local).AddTicks(3019), new DateTime(2022, 5, 5, 15, 21, 49, 936, DateTimeKind.Local).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 5, 15, 21, 49, 936, DateTimeKind.Local).AddTicks(7552), new DateTime(2022, 5, 5, 15, 21, 49, 936, DateTimeKind.Local).AddTicks(7569) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 5, 15, 21, 49, 936, DateTimeKind.Local).AddTicks(9466), new DateTime(2022, 5, 5, 15, 21, 49, 936, DateTimeKind.Local).AddTicks(9479) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 5, 15, 21, 49, 936, DateTimeKind.Local).AddTicks(9486), new DateTime(2022, 5, 5, 15, 21, 49, 936, DateTimeKind.Local).AddTicks(9489) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 5, 15, 21, 49, 937, DateTimeKind.Local).AddTicks(3176), new DateTime(2022, 5, 5, 15, 21, 49, 937, DateTimeKind.Local).AddTicks(3192) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 5, 15, 21, 49, 937, DateTimeKind.Local).AddTicks(4450), new DateTime(2022, 5, 5, 15, 21, 49, 937, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 5, 15, 21, 49, 937, DateTimeKind.Local).AddTicks(4469), new DateTime(2022, 5, 5, 15, 21, 49, 937, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 5, 15, 21, 49, 937, DateTimeKind.Local).AddTicks(8306), new DateTime(2022, 5, 5, 15, 21, 49, 937, DateTimeKind.Local).AddTicks(8322) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 5, 15, 21, 49, 938, DateTimeKind.Local).AddTicks(305), new DateTime(2022, 5, 5, 15, 21, 49, 938, DateTimeKind.Local).AddTicks(318) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 5, 15, 21, 49, 938, DateTimeKind.Local).AddTicks(327), new DateTime(2022, 5, 5, 15, 21, 49, 938, DateTimeKind.Local).AddTicks(329) });

            migrationBuilder.CreateIndex(
                name: "IX_Workloads_WorkloadRateSheetId",
                table: "Workloads",
                column: "WorkloadRateSheetId");

            migrationBuilder.CreateIndex(
                name: "IX_AfRates_AirlineId",
                table: "AfRates",
                column: "AirlineId");

            migrationBuilder.CreateIndex(
                name: "IX_AfRates_CurrencyId",
                table: "AfRates",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_AfRates_Airline_AirlineId",
                table: "AfRates",
                column: "AirlineId",
                principalTable: "Airline",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AfRates_Currency_CurrencyId",
                table: "AfRates",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Charge_Currency_CurrencyId",
                table: "Charge",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ChargeTemplate_Currency_CurrencyId",
                table: "ChargeTemplate",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_WorkloadRateSheet_Currency_CurrencyId",
                table: "WorkloadRateSheet",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Workloads_WorkloadRateSheet_WorkloadRateSheetId",
                table: "Workloads",
                column: "WorkloadRateSheetId",
                principalTable: "WorkloadRateSheet",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AfRates_Airline_AirlineId",
                table: "AfRates");

            migrationBuilder.DropForeignKey(
                name: "FK_AfRates_Currency_CurrencyId",
                table: "AfRates");

            migrationBuilder.DropForeignKey(
                name: "FK_Charge_Currency_CurrencyId",
                table: "Charge");

            migrationBuilder.DropForeignKey(
                name: "FK_ChargeTemplate_Currency_CurrencyId",
                table: "ChargeTemplate");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkloadRateSheet_Currency_CurrencyId",
                table: "WorkloadRateSheet");

            migrationBuilder.DropForeignKey(
                name: "FK_Workloads_WorkloadRateSheet_WorkloadRateSheetId",
                table: "Workloads");

            migrationBuilder.DropIndex(
                name: "IX_Workloads_WorkloadRateSheetId",
                table: "Workloads");

            migrationBuilder.DropIndex(
                name: "IX_AfRates_AirlineId",
                table: "AfRates");

            migrationBuilder.DropIndex(
                name: "IX_AfRates_CurrencyId",
                table: "AfRates");

            migrationBuilder.DropColumn(
                name: "WorkloadRateSheetId",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "AirlineId",
                table: "AfRates");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "AfRates");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "f64c3626-ac0f-46ad-926d-fb13ede17fa8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "d3719408-86c2-4db5-a18b-2689e9d6514b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30b35d15-e889-490e-a83f-f482e55e54dc", "AQAAAAEAACcQAAAAEHARcFNIXHT67WdEpocVVYBZeTIZm2nr9km5Hl7Bn1V9Z1fb6TdDucDt2RAHEVT/Ag==", "08d0ff4e-9a34-43ee-866f-ad134f1d3c8a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e86d2058-c375-43b9-80b7-be5249c480ba", "AQAAAAEAACcQAAAAECfr21fAGyW67P/vDBJ8Bs/i6rhGnbTZBTRHapMSJWkD/wm1WYC/y1OZR0/FJ6AStw==", "25dccae1-27c4-43f4-b47c-7a822a518ac5" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 252, DateTimeKind.Local).AddTicks(7575), new DateTime(2022, 5, 4, 15, 57, 24, 255, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(2961), new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(3060), new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(7255), new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(7271) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(9004), new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(9017) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(9027), new DateTime(2022, 5, 4, 15, 57, 24, 256, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(2815), new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(2832) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(4092), new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(4105) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(4113), new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(4116) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(7828), new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(7844) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(9943), new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(9957) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(9965), new DateTime(2022, 5, 4, 15, 57, 24, 257, DateTimeKind.Local).AddTicks(9967) });

            migrationBuilder.AddForeignKey(
                name: "FK_Charge_Currency_CurrencyId",
                table: "Charge",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChargeTemplate_Currency_CurrencyId",
                table: "ChargeTemplate",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkloadRateSheet_Currency_CurrencyId",
                table: "WorkloadRateSheet",
                column: "CurrencyId",
                principalTable: "Currency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
