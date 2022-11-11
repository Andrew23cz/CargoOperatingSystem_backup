using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedShcAndHandlingInfoPropertiesToAgentSubmitModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HandlingInformationA",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HandlingInformationB",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HandlingInformationC",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShcA",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShcB",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShcC",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "a7b69df6-220f-4b86-99d8-90570b5a87e1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "e0f51244-c466-4c4c-9f1e-6b3218a8ddac");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b809cf9b-7125-4c05-8546-c46d3b6e4711", "AQAAAAEAACcQAAAAEMkxb0cFE+SK3k3ikn1j33Ho4soJ2GsGX6/pEaZ9R/fUKr+5W2uQ7SpBB7IA9VJYAw==", "b0bff628-5884-4ad2-904d-f2afe6946600" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6a5e290-b305-4521-8fc7-ab9610af4930", "AQAAAAEAACcQAAAAEAX3j6t5ONgc+tXmZbba6uF3eYsdMjpSMPVsIBiOQ8vdwokYzgnyIuD7PB7OeJhdNA==", "7db0ea70-e659-411f-82e3-21dddd0cd6c1" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 16, 51, 32, 369, DateTimeKind.Local).AddTicks(1321), new DateTime(2022, 4, 21, 16, 51, 32, 372, DateTimeKind.Local).AddTicks(1976) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 16, 51, 32, 373, DateTimeKind.Local).AddTicks(2186), new DateTime(2022, 4, 21, 16, 51, 32, 373, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 16, 51, 32, 373, DateTimeKind.Local).AddTicks(2282), new DateTime(2022, 4, 21, 16, 51, 32, 373, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 16, 51, 32, 373, DateTimeKind.Local).AddTicks(6144), new DateTime(2022, 4, 21, 16, 51, 32, 373, DateTimeKind.Local).AddTicks(6161) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 16, 51, 32, 373, DateTimeKind.Local).AddTicks(8115), new DateTime(2022, 4, 21, 16, 51, 32, 373, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 16, 51, 32, 373, DateTimeKind.Local).AddTicks(8138), new DateTime(2022, 4, 21, 16, 51, 32, 373, DateTimeKind.Local).AddTicks(8141) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 16, 51, 32, 374, DateTimeKind.Local).AddTicks(1629), new DateTime(2022, 4, 21, 16, 51, 32, 374, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 16, 51, 32, 374, DateTimeKind.Local).AddTicks(2939), new DateTime(2022, 4, 21, 16, 51, 32, 374, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 16, 51, 32, 374, DateTimeKind.Local).AddTicks(2960), new DateTime(2022, 4, 21, 16, 51, 32, 374, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 16, 51, 32, 374, DateTimeKind.Local).AddTicks(6745), new DateTime(2022, 4, 21, 16, 51, 32, 374, DateTimeKind.Local).AddTicks(6760) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 16, 51, 32, 374, DateTimeKind.Local).AddTicks(8768), new DateTime(2022, 4, 21, 16, 51, 32, 374, DateTimeKind.Local).AddTicks(8781) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 16, 51, 32, 374, DateTimeKind.Local).AddTicks(8789), new DateTime(2022, 4, 21, 16, 51, 32, 374, DateTimeKind.Local).AddTicks(8791) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HandlingInformationA",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "HandlingInformationB",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "HandlingInformationC",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "ShcA",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "ShcB",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "ShcC",
                table: "AgentSubmitModel");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "aadd49fb-44c1-4f97-ba77-aa2e92a49d31");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "b154df40-493e-463d-b7d3-df956be718b6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d27f502-f41f-4b9c-9357-4fc841f65f92", "AQAAAAEAACcQAAAAELDncmri39BATusrdpr3fVlkN6+2FXXt12hp95mu8iFg+2BtfLy9W/72naameAc1Jg==", "6e62dd06-9723-498e-b71c-a0f5ffb2154f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "795f0ac7-ba00-493d-88e1-e28d1129cb8c", "AQAAAAEAACcQAAAAEGgY0Ee5faYtIUdKnYwTXyBvqu7e9KXeFt2kLo59RbiazisEHeLM2NUEQM4tS6ok9w==", "4b29fab4-324e-4060-8ce6-7d54435dbcdd" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 844, DateTimeKind.Local).AddTicks(7604), new DateTime(2022, 4, 21, 15, 14, 0, 847, DateTimeKind.Local).AddTicks(3481) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(3659), new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(3751), new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(3754) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(7659), new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(7676) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(9494), new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(9507) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(9515), new DateTime(2022, 4, 21, 15, 14, 0, 848, DateTimeKind.Local).AddTicks(9518) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 849, DateTimeKind.Local).AddTicks(3019), new DateTime(2022, 4, 21, 15, 14, 0, 849, DateTimeKind.Local).AddTicks(3035) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 849, DateTimeKind.Local).AddTicks(4322), new DateTime(2022, 4, 21, 15, 14, 0, 849, DateTimeKind.Local).AddTicks(4336) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 849, DateTimeKind.Local).AddTicks(4344), new DateTime(2022, 4, 21, 15, 14, 0, 849, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 849, DateTimeKind.Local).AddTicks(8144), new DateTime(2022, 4, 21, 15, 14, 0, 849, DateTimeKind.Local).AddTicks(8161) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 850, DateTimeKind.Local).AddTicks(438), new DateTime(2022, 4, 21, 15, 14, 0, 850, DateTimeKind.Local).AddTicks(451) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 21, 15, 14, 0, 850, DateTimeKind.Local).AddTicks(460), new DateTime(2022, 4, 21, 15, 14, 0, 850, DateTimeKind.Local).AddTicks(462) });
        }
    }
}
