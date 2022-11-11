using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedNotePropertiesForAdditionalSvcInWorkloadRateSheetModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdditionalServiceNoteA",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalServiceNoteB",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalServiceNoteC",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalServiceNoteD",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalServiceNoteE",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "67fbc65e-dac9-4e89-b7f4-18d6886505b4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "0eb3f483-7e88-44d8-9baf-e6cf9ae24696");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30d1d855-4557-4363-9465-02709505d24d", "AQAAAAEAACcQAAAAELqdnnVqBCPd05UiCvRxM7ZZAK9ITolWulbvVDWx0J8BrSzTUl2z/Kd/9w4mwaIlSg==", "b722bcdc-b2fd-441f-acc4-881c6ed38e6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da578119-fab9-450f-b5e2-38941fdc44aa", "AQAAAAEAACcQAAAAECdHkkLVsg/DzwI7l9O0HMxSlnaVc2KB/WC5hFMg0V1ppDvmk8HtcfoHaaC71f5+4w==", "2f40c4be-e191-4819-bad9-74823a8c72ff" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 58, 58, 732, DateTimeKind.Local).AddTicks(394), new DateTime(2022, 5, 9, 13, 58, 58, 734, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 58, 58, 735, DateTimeKind.Local).AddTicks(4077), new DateTime(2022, 5, 9, 13, 58, 58, 735, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 58, 58, 735, DateTimeKind.Local).AddTicks(4169), new DateTime(2022, 5, 9, 13, 58, 58, 735, DateTimeKind.Local).AddTicks(4173) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 58, 58, 735, DateTimeKind.Local).AddTicks(8143), new DateTime(2022, 5, 9, 13, 58, 58, 735, DateTimeKind.Local).AddTicks(8159) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 58, 58, 735, DateTimeKind.Local).AddTicks(9957), new DateTime(2022, 5, 9, 13, 58, 58, 735, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 58, 58, 735, DateTimeKind.Local).AddTicks(9979), new DateTime(2022, 5, 9, 13, 58, 58, 735, DateTimeKind.Local).AddTicks(9981) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 58, 58, 736, DateTimeKind.Local).AddTicks(3547), new DateTime(2022, 5, 9, 13, 58, 58, 736, DateTimeKind.Local).AddTicks(3563) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 58, 58, 736, DateTimeKind.Local).AddTicks(4800), new DateTime(2022, 5, 9, 13, 58, 58, 736, DateTimeKind.Local).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 58, 58, 736, DateTimeKind.Local).AddTicks(4819), new DateTime(2022, 5, 9, 13, 58, 58, 736, DateTimeKind.Local).AddTicks(4822) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 58, 58, 736, DateTimeKind.Local).AddTicks(8646), new DateTime(2022, 5, 9, 13, 58, 58, 736, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 58, 58, 737, DateTimeKind.Local).AddTicks(598), new DateTime(2022, 5, 9, 13, 58, 58, 737, DateTimeKind.Local).AddTicks(610) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 9, 13, 58, 58, 737, DateTimeKind.Local).AddTicks(618), new DateTime(2022, 5, 9, 13, 58, 58, 737, DateTimeKind.Local).AddTicks(620) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalServiceNoteA",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceNoteB",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceNoteC",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceNoteD",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceNoteE",
                table: "WorkloadRateSheet");

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
        }
    }
}
