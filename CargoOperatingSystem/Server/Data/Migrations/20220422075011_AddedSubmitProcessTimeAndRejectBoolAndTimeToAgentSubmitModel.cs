using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedSubmitProcessTimeAndRejectBoolAndTimeToAgentSubmitModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ProcessedTime",
                table: "AgentSubmitModel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RejectTime",
                table: "AgentSubmitModel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Rejected",
                table: "AgentSubmitModel",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "SubmitTime",
                table: "AgentSubmitModel",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "9402b03c-8773-473d-b9e3-17c8717c8d1a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "ef6dc785-285d-41fd-bb34-ddcbc9c84a15");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d83ce9c-f6b2-4e41-aeeb-2994b85b41f1", "AQAAAAEAACcQAAAAEPJFgvHFL9yWjXmynvSlqn5DVeHAHoLYlyKhzmD11G042eIbgVLddarCaXMDHmAPqQ==", "006bb4c7-3854-4f1e-b0c3-79809f9e45d6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24c40fed-1670-4cfe-b1dc-1c475ce09418", "AQAAAAEAACcQAAAAEPS6lFTVIBXnzhbqVo3e0gwIJfFO1zzD/6v9SYSX71c8vylFfXIYC2pdUR7aM0f5zw==", "4bd2a836-66e6-419a-abd5-fa7b5d9c34c3" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 9, 50, 10, 407, DateTimeKind.Local).AddTicks(7004), new DateTime(2022, 4, 22, 9, 50, 10, 410, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 9, 50, 10, 411, DateTimeKind.Local).AddTicks(5868), new DateTime(2022, 4, 22, 9, 50, 10, 411, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 9, 50, 10, 411, DateTimeKind.Local).AddTicks(5968), new DateTime(2022, 4, 22, 9, 50, 10, 411, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 9, 50, 10, 411, DateTimeKind.Local).AddTicks(9961), new DateTime(2022, 4, 22, 9, 50, 10, 411, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 9, 50, 10, 412, DateTimeKind.Local).AddTicks(1952), new DateTime(2022, 4, 22, 9, 50, 10, 412, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 9, 50, 10, 412, DateTimeKind.Local).AddTicks(1974), new DateTime(2022, 4, 22, 9, 50, 10, 412, DateTimeKind.Local).AddTicks(1977) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 9, 50, 10, 412, DateTimeKind.Local).AddTicks(5532), new DateTime(2022, 4, 22, 9, 50, 10, 412, DateTimeKind.Local).AddTicks(5547) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 9, 50, 10, 412, DateTimeKind.Local).AddTicks(6857), new DateTime(2022, 4, 22, 9, 50, 10, 412, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 9, 50, 10, 412, DateTimeKind.Local).AddTicks(6878), new DateTime(2022, 4, 22, 9, 50, 10, 412, DateTimeKind.Local).AddTicks(6881) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 9, 50, 10, 413, DateTimeKind.Local).AddTicks(791), new DateTime(2022, 4, 22, 9, 50, 10, 413, DateTimeKind.Local).AddTicks(808) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 9, 50, 10, 413, DateTimeKind.Local).AddTicks(2876), new DateTime(2022, 4, 22, 9, 50, 10, 413, DateTimeKind.Local).AddTicks(2889) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 22, 9, 50, 10, 413, DateTimeKind.Local).AddTicks(2898), new DateTime(2022, 4, 22, 9, 50, 10, 413, DateTimeKind.Local).AddTicks(2901) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProcessedTime",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "RejectTime",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "Rejected",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "SubmitTime",
                table: "AgentSubmitModel");

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
    }
}
