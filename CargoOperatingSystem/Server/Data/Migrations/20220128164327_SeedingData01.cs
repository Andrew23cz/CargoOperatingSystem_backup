using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class SeedingData01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "4a8a3126-f9d3-4153-ae29-79993b432805");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "54c0dd9e-7487-4c39-a708-df61620bed4c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0bcef6bf-1f88-408c-9217-7b839b671957", "AQAAAAEAACcQAAAAEAD9qt9IyWqlJ1fWfgqmC6iRNyIsG1oUSEKhf7HxIds5QaFeQeUD8Jz3EoPElqeUFQ==", "63663dc5-5596-45e6-abe8-6fa8d991c372" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Company", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b3bc7e01-778b-400a-a7f6-3289c681d405", 0, null, "39347697-c750-4062-a6dc-a85010d04850", "test@test.cz", false, "TestFirstName", "TestLastName", false, null, "TEST@TEST.CZ", "TEST@TEST.CZ", "AQAAAAEAACcQAAAAEOjzIIEEjO1RG1c6Ot++Hfl+O06ENlQ3SMlNgWteIw/+xxTSAvWwnbV3rbsN7YXsCA==", null, false, "1de6d2db-a2e1-44a4-b447-d8652072ed09", false, "test@test.cz" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 104, DateTimeKind.Local).AddTicks(1211), new DateTime(2022, 1, 28, 17, 43, 27, 106, DateTimeKind.Local).AddTicks(6110) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 107, DateTimeKind.Local).AddTicks(7246), new DateTime(2022, 1, 28, 17, 43, 27, 107, DateTimeKind.Local).AddTicks(7266) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 107, DateTimeKind.Local).AddTicks(7344), new DateTime(2022, 1, 28, 17, 43, 27, 107, DateTimeKind.Local).AddTicks(7347) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(1422), new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(1438) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(3174), new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(3186) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(3195), new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(3198) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(6698), new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(6713) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(8195), new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(8208) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(8216), new DateTime(2022, 1, 28, 17, 43, 27, 108, DateTimeKind.Local).AddTicks(8218) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 109, DateTimeKind.Local).AddTicks(1974), new DateTime(2022, 1, 28, 17, 43, 27, 109, DateTimeKind.Local).AddTicks(1989) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 109, DateTimeKind.Local).AddTicks(3923), new DateTime(2022, 1, 28, 17, 43, 27, 109, DateTimeKind.Local).AddTicks(3936) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 28, 17, 43, 27, 109, DateTimeKind.Local).AddTicks(3944), new DateTime(2022, 1, 28, 17, 43, 27, 109, DateTimeKind.Local).AddTicks(3947) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6bef2159-5dd7-4924-b8b3-95386f8cc6ef", "b3bc7e01-778b-400a-a7f6-3289c681d405" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6bef2159-5dd7-4924-b8b3-95386f8cc6ef", "b3bc7e01-778b-400a-a7f6-3289c681d405" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "c1e39714-00f2-4c9a-9aae-a21dd8b76fc1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "8a1b964e-837d-48b0-95a2-dad2b2017597");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46527a6d-1722-4747-a505-c832fcae2558", "AQAAAAEAACcQAAAAEMxq4YZAGmoj78OOSmZ8wh/lFHRHTD3eVKKVCTPa/ozlul/L7mv2GsZdnOdYzx17zQ==", "9824b872-0245-4016-8f8d-356f333fb596" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 964, DateTimeKind.Local).AddTicks(2530), new DateTime(2022, 1, 27, 13, 24, 21, 966, DateTimeKind.Local).AddTicks(8662) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 967, DateTimeKind.Local).AddTicks(8901), new DateTime(2022, 1, 27, 13, 24, 21, 967, DateTimeKind.Local).AddTicks(8917) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 967, DateTimeKind.Local).AddTicks(8992), new DateTime(2022, 1, 27, 13, 24, 21, 967, DateTimeKind.Local).AddTicks(8996) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(2957), new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(2972) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(4901), new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(4922), new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(4925) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(8433), new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(9713), new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(9726) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(9733), new DateTime(2022, 1, 27, 13, 24, 21, 968, DateTimeKind.Local).AddTicks(9735) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 969, DateTimeKind.Local).AddTicks(3579), new DateTime(2022, 1, 27, 13, 24, 21, 969, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 969, DateTimeKind.Local).AddTicks(5597), new DateTime(2022, 1, 27, 13, 24, 21, 969, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 27, 13, 24, 21, 969, DateTimeKind.Local).AddTicks(5618), new DateTime(2022, 1, 27, 13, 24, 21, 969, DateTimeKind.Local).AddTicks(5621) });
        }
    }
}
