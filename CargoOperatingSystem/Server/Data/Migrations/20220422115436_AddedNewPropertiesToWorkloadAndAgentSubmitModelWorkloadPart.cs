using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedNewPropertiesToWorkloadAndAgentSubmitModelWorkloadPart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AdditionalServiceA",
                table: "Workloads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdditionalServiceB",
                table: "Workloads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdditionalServiceC",
                table: "Workloads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdditionalServiceD",
                table: "Workloads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AdditionalServiceE",
                table: "Workloads",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalServiceNoteA",
                table: "Workloads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalServiceNoteB",
                table: "Workloads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalServiceNoteC",
                table: "Workloads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalServiceNoteD",
                table: "Workloads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AdditionalServiceNoteE",
                table: "Workloads",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WorkloadAdditionalServiceA",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkloadAdditionalServiceB",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkloadAdditionalServiceC",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkloadAdditionalServiceD",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WorkloadAdditionalServiceE",
                table: "AgentSubmitModel",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "WorkloadAdditionalServiceNoteA",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkloadAdditionalServiceNoteB",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkloadAdditionalServiceNoteC",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkloadAdditionalServiceNoteD",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WorkloadAdditionalServiceNoteE",
                table: "AgentSubmitModel",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalServiceA",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceB",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceC",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceD",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceE",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceNoteA",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceNoteB",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceNoteC",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceNoteD",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "AdditionalServiceNoteE",
                table: "Workloads");

            migrationBuilder.DropColumn(
                name: "WorkloadAdditionalServiceA",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadAdditionalServiceB",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadAdditionalServiceC",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadAdditionalServiceD",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadAdditionalServiceE",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadAdditionalServiceNoteA",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadAdditionalServiceNoteB",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadAdditionalServiceNoteC",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadAdditionalServiceNoteD",
                table: "AgentSubmitModel");

            migrationBuilder.DropColumn(
                name: "WorkloadAdditionalServiceNoteE",
                table: "AgentSubmitModel");

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
    }
}
