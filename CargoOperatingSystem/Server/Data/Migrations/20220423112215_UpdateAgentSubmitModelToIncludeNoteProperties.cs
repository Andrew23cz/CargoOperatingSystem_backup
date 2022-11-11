using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdateAgentSubmitModelToIncludeNoteProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "WorkloadAcceptanceAssistDGNote",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkloadAcceptanceAssistNote",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkloadAwbIssuingNote",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkloadCargoLabelsNote",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkloadHawbIssuingNote",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkloadImportCgoProcessingNote",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkloadManualDataInsertionNote",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkloadPackingAssistNote",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkloadPickUpDocumentsNote",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkloadSecurityCheckAssistNote",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkloadSecurityCheckPrepareNote",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkloadSpecCargoLabelsNote",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "8c5f6eb1-783c-4a93-ab79-4f4fd9d83b58");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "f82602a9-d4e0-48a1-8160-2c86c702fa63");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfd73274-ebb7-40d9-bf36-01c43adab888", "AQAAAAEAACcQAAAAEIgNi2dpEZRU/98/vcAkD9u0XsJEaSlqvS74Ww0F9wuASvbo1Ap4sboLk5e5UksY3w==", "82ad811b-bd51-4ad3-9257-e9b88d9bcf74" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "898a1b1a-674f-461b-afee-f0960bfed523", "AQAAAAEAACcQAAAAEMykehggIYRsV6l/+NHxwmWwPBTYcRnqgKLiKvq8/Unpuaws6Q0YXJ3SGeTY2tGcmQ==", "e2e837da-9965-4c52-a7e2-4e3aff342e42" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 991, DateTimeKind.Local).AddTicks(5444), new DateTime(2022, 4, 23, 13, 22, 14, 994, DateTimeKind.Local).AddTicks(2054) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(1969), new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(1987) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(2062), new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(6101), new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(7855), new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(7868) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(7876), new DateTime(2022, 4, 23, 13, 22, 14, 995, DateTimeKind.Local).AddTicks(7879) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(1538), new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(2854), new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(2876), new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(2878) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(6714), new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(6730) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(8661), new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(8673) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(8682), new DateTime(2022, 4, 23, 13, 22, 14, 996, DateTimeKind.Local).AddTicks(8684) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WorkloadAcceptanceAssistDGNote",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadAcceptanceAssistNote",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadAwbIssuingNote",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadCargoLabelsNote",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadHawbIssuingNote",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadImportCgoProcessingNote",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadManualDataInsertionNote",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadPackingAssistNote",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadPickUpDocumentsNote",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadSecurityCheckAssistNote",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadSecurityCheckPrepareNote",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadSpecCargoLabelsNote",
                table: "AgentSubmitModel");

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
    }
}
