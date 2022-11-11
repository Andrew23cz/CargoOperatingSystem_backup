using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AgentSubmitModelWorkloadPartChangedIntoBools : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkloadAmount",
                table: "AgentSubmitModel");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadSpecCargoLabels",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadSecurityCheckPrepare",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadSecurityCheckAssist",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadPrintingCorrectedDocs",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadPickUpDocuments",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadPackingAssist",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadManualDataInsertion",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadImportCgoProcessing",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadHawbIssuing",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadDocumentsCorrection",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadConsultingDG",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadCargoLabels",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadAwbIssuing",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadAfterOpeningHoursService",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadAdditionalServiceE",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadAdditionalServiceD",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadAdditionalServiceC",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadAdditionalServiceB",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadAdditionalServiceA",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadAcceptanceAssistDG",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "WorkloadAcceptanceAssist",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "1886817a-d43f-4d4e-acd5-c1d4d183dbbe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "37468405-fef8-4da0-b074-d277605de7df");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dfc43c0-0d2e-464d-a480-1c7d34f700d5", "AQAAAAEAACcQAAAAEFkri++owuLi5cXrjapRsvCFsXyhH87CnVvvqlbRuBtcdUlm/8S6TOxjwEwoyQqEAg==", "65ae7fc6-0e62-4e3c-8c23-c6b0adb5ad6d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b2d7e5fc-1e32-4cda-885d-7afca5670770", "AQAAAAEAACcQAAAAEJIfGazsyBYiIVHuCQMdHofVwqiumvpQqrTCMhjplO+4c7ML8/iqzeYELdDCkfUW+w==", "4d2d2398-403c-47a4-9411-f4a698598812" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 8, 8, 9, 758, DateTimeKind.Local).AddTicks(9910), new DateTime(2022, 4, 23, 8, 8, 9, 761, DateTimeKind.Local).AddTicks(6731) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 8, 8, 9, 762, DateTimeKind.Local).AddTicks(6750), new DateTime(2022, 4, 23, 8, 8, 9, 762, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 8, 8, 9, 762, DateTimeKind.Local).AddTicks(6859), new DateTime(2022, 4, 23, 8, 8, 9, 762, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 8, 8, 9, 763, DateTimeKind.Local).AddTicks(915), new DateTime(2022, 4, 23, 8, 8, 9, 763, DateTimeKind.Local).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 8, 8, 9, 763, DateTimeKind.Local).AddTicks(2770), new DateTime(2022, 4, 23, 8, 8, 9, 763, DateTimeKind.Local).AddTicks(2784) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 8, 8, 9, 763, DateTimeKind.Local).AddTicks(2793), new DateTime(2022, 4, 23, 8, 8, 9, 763, DateTimeKind.Local).AddTicks(2796) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 8, 8, 9, 763, DateTimeKind.Local).AddTicks(6374), new DateTime(2022, 4, 23, 8, 8, 9, 763, DateTimeKind.Local).AddTicks(6390) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 8, 8, 9, 763, DateTimeKind.Local).AddTicks(7672), new DateTime(2022, 4, 23, 8, 8, 9, 763, DateTimeKind.Local).AddTicks(7686) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 8, 8, 9, 763, DateTimeKind.Local).AddTicks(7694), new DateTime(2022, 4, 23, 8, 8, 9, 763, DateTimeKind.Local).AddTicks(7697) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 8, 8, 9, 764, DateTimeKind.Local).AddTicks(1568), new DateTime(2022, 4, 23, 8, 8, 9, 764, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 8, 8, 9, 764, DateTimeKind.Local).AddTicks(3591), new DateTime(2022, 4, 23, 8, 8, 9, 764, DateTimeKind.Local).AddTicks(3604) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 8, 8, 9, 764, DateTimeKind.Local).AddTicks(3613), new DateTime(2022, 4, 23, 8, 8, 9, 764, DateTimeKind.Local).AddTicks(3615) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "WorkloadSpecCargoLabels",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadSecurityCheckPrepare",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadSecurityCheckAssist",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadPrintingCorrectedDocs",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadPickUpDocuments",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadPackingAssist",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadManualDataInsertion",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadImportCgoProcessing",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadHawbIssuing",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadDocumentsCorrection",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadConsultingDG",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadCargoLabels",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadAwbIssuing",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadAfterOpeningHoursService",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadAdditionalServiceE",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadAdditionalServiceD",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadAdditionalServiceC",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadAdditionalServiceB",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadAdditionalServiceA",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadAcceptanceAssistDG",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "WorkloadAcceptanceAssist",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AddColumn<decimal>(
                name: "WorkloadAmount",
                table: "AgentSubmitModel",
                type: "decimal(12,2)",
                precision: 12,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "5fac518c-6f35-41ce-aa8b-8ef52c87d1ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "adfb3736-0994-4170-8f9e-f5be01e04c2d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7af202ca-5c8e-4cc3-92b8-7768906f7576", "AQAAAAEAACcQAAAAEM++q0EdIke1KdCebiH7B84S+jgeiD1KkB+ikXfHLp+yibCncTzcojpY634PbEOEPw==", "5d7865b9-f9c5-4f91-a6aa-fbeba82bc73d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f74f36c0-edcd-4c54-aec3-b5877c660d86", "AQAAAAEAACcQAAAAEDIfvMJKA9h9KT5PTVkNwoS/eCHX6NgomQUsMEIVcs3nvXx0FG3wzYPB1kl5iXPadA==", "4d4fc56b-16d6-4ec0-9ae3-54edf0254bac" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 13, 54, 35, 393, DateTimeKind.Local).AddTicks(6819), new DateTime(2022, 4, 22, 13, 54, 35, 396, DateTimeKind.Local).AddTicks(4094) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 13, 54, 35, 397, DateTimeKind.Local).AddTicks(4644), new DateTime(2022, 4, 22, 13, 54, 35, 397, DateTimeKind.Local).AddTicks(4661) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 13, 54, 35, 397, DateTimeKind.Local).AddTicks(4741), new DateTime(2022, 4, 22, 13, 54, 35, 397, DateTimeKind.Local).AddTicks(4745) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 13, 54, 35, 397, DateTimeKind.Local).AddTicks(8960), new DateTime(2022, 4, 22, 13, 54, 35, 397, DateTimeKind.Local).AddTicks(8976) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 13, 54, 35, 398, DateTimeKind.Local).AddTicks(867), new DateTime(2022, 4, 22, 13, 54, 35, 398, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 13, 54, 35, 398, DateTimeKind.Local).AddTicks(889), new DateTime(2022, 4, 22, 13, 54, 35, 398, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 13, 54, 35, 398, DateTimeKind.Local).AddTicks(4509), new DateTime(2022, 4, 22, 13, 54, 35, 398, DateTimeKind.Local).AddTicks(4525) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 13, 54, 35, 398, DateTimeKind.Local).AddTicks(5831), new DateTime(2022, 4, 22, 13, 54, 35, 398, DateTimeKind.Local).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 13, 54, 35, 398, DateTimeKind.Local).AddTicks(5851), new DateTime(2022, 4, 22, 13, 54, 35, 398, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 13, 54, 35, 398, DateTimeKind.Local).AddTicks(9732), new DateTime(2022, 4, 22, 13, 54, 35, 398, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 13, 54, 35, 399, DateTimeKind.Local).AddTicks(1895), new DateTime(2022, 4, 22, 13, 54, 35, 399, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 13, 54, 35, 399, DateTimeKind.Local).AddTicks(1916), new DateTime(2022, 4, 22, 13, 54, 35, 399, DateTimeKind.Local).AddTicks(1919) });
        }
    }
}
