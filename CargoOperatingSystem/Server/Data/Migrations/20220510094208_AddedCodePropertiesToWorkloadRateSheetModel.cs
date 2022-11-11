using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedCodePropertiesToWorkloadRateSheetModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AcceptanceAssistCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AcceptanceAssistDGCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalServiceACode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalServiceBCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalServiceCCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalServiceDCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalServiceECode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AfterOpeningHoursServiceCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AwbIssuingCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CargoLabelsCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CosultingDGCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DocumentsCorrectionCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HawbIssuingCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImportCgoProcessingCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ManualDataInsertionCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PackingAssistCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PickUpDocumentsCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrintingCorrectedDocsCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityCheckAssistCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecurityCheckPrepareCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SpecCargoLabelsCode",
                table: "WorkloadRateSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AutoPopulateCode",
                table: "Charge",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "AutoPopulated",
                table: "Charge",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "822ec7ce-4b79-4e9e-bf59-144dc252c07a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "f7d23a17-d8ac-4d9f-9dea-a89515d5e396");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94f3a408-5cb3-43b8-be4c-167f20f3660f", "AQAAAAEAACcQAAAAEFrw8eeWykoHhU/0Zp6DR459Z1QN8oqeAlX8hQfpRsZ2nUwhBP9Vk6YqvpmecZzH9g==", "7daf30bc-e504-4627-8a02-8a298400a758" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48218393-d2d8-4348-bc71-f0bc63298ddd", "AQAAAAEAACcQAAAAEO9WgFNnvqE2GsliS+PrkAiR2moyvLvKixRh3eo6+pMVT9OwsPTBX2+PkyukE7Vcxg==", "864000c6-9b3e-4605-b27e-46cd320ab29b" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 92, DateTimeKind.Local).AddTicks(3563), new DateTime(2022, 5, 10, 11, 42, 7, 94, DateTimeKind.Local).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 95, DateTimeKind.Local).AddTicks(9083), new DateTime(2022, 5, 10, 11, 42, 7, 95, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 95, DateTimeKind.Local).AddTicks(9184), new DateTime(2022, 5, 10, 11, 42, 7, 95, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 96, DateTimeKind.Local).AddTicks(3335), new DateTime(2022, 5, 10, 11, 42, 7, 96, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 96, DateTimeKind.Local).AddTicks(5209), new DateTime(2022, 5, 10, 11, 42, 7, 96, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 96, DateTimeKind.Local).AddTicks(5229), new DateTime(2022, 5, 10, 11, 42, 7, 96, DateTimeKind.Local).AddTicks(5232) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 96, DateTimeKind.Local).AddTicks(9030), new DateTime(2022, 5, 10, 11, 42, 7, 96, DateTimeKind.Local).AddTicks(9047) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(402), new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(415) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(423), new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(4242), new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(4258) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(6206), new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(6227), new DateTime(2022, 5, 10, 11, 42, 7, 97, DateTimeKind.Local).AddTicks(6229) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcceptanceAssistCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "AcceptanceAssistDGCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceACode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceBCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceCCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceDCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceECode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "AfterOpeningHoursServiceCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "AwbIssuingCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "CargoLabelsCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "CosultingDGCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "DocumentsCorrectionCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "HawbIssuingCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "ImportCgoProcessingCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "ManualDataInsertionCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "PackingAssistCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "PickUpDocumentsCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "PrintingCorrectedDocsCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "SecurityCheckAssistCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "SecurityCheckPrepareCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "SpecCargoLabelsCode",
                table: "WorkloadRateSheet");

            migrationBuilder.DropColumn(
                name: "AutoPopulateCode",
                table: "Charge");

            migrationBuilder.DropColumn(
                name: "AutoPopulated",
                table: "Charge");

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
    }
}
