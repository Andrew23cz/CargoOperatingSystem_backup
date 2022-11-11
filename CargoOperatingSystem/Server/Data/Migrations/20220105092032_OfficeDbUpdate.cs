using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class OfficeDbUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "de1ec467-9137-40de-bc42-c9201263d92a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "f5ca1da7-701f-4e8a-9b71-b6a5382ccc4f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae7a7863-1562-4355-a0db-2a7cde1a316f", "AQAAAAEAACcQAAAAECSql5tbT8SZ3qTci78zeZswVkZ2pkQaFB1eSlKa/8UsakFKEwadX5/o09C95sQcQA==", "4cf3235a-3dc7-41f6-a34e-3284c0b2933f" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 644, DateTimeKind.Local).AddTicks(6378), new DateTime(2022, 1, 5, 10, 20, 30, 657, DateTimeKind.Local).AddTicks(61) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 658, DateTimeKind.Local).AddTicks(6147), new DateTime(2022, 1, 5, 10, 20, 30, 658, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 658, DateTimeKind.Local).AddTicks(6332), new DateTime(2022, 1, 5, 10, 20, 30, 658, DateTimeKind.Local).AddTicks(6338) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(2724), new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(2777) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(5432), new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(5452) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(5462), new DateTime(2022, 1, 5, 10, 20, 30, 659, DateTimeKind.Local).AddTicks(5465) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(780), new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(2594), new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(2612) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(2622), new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(2626) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(9622), new DateTime(2022, 1, 5, 10, 20, 30, 660, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 661, DateTimeKind.Local).AddTicks(2508), new DateTime(2022, 1, 5, 10, 20, 30, 661, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 5, 10, 20, 30, 661, DateTimeKind.Local).AddTicks(2541), new DateTime(2022, 1, 5, 10, 20, 30, 661, DateTimeKind.Local).AddTicks(2545) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "35cbfb3f-2298-4d74-b271-faf383ad2d6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "5c2ecda0-a7ae-4b1f-a0b2-9ed80126d167");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "362b89ef-9157-4209-87eb-e7c89403986b", "AQAAAAEAACcQAAAAECxXF1P61L8IxtBBGIg79mVZyq0N+wtUAy+HMxbS2uGlHt4D4/H1maJTfBweJbzw3A==", "b173aa20-e3d8-41d9-a895-5d57720bc887" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 708, DateTimeKind.Local).AddTicks(8120), new DateTime(2022, 1, 4, 23, 10, 13, 711, DateTimeKind.Local).AddTicks(4735) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 712, DateTimeKind.Local).AddTicks(5487), new DateTime(2022, 1, 4, 23, 10, 13, 712, DateTimeKind.Local).AddTicks(5506) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 712, DateTimeKind.Local).AddTicks(5592), new DateTime(2022, 1, 4, 23, 10, 13, 712, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 712, DateTimeKind.Local).AddTicks(9792), new DateTime(2022, 1, 4, 23, 10, 13, 712, DateTimeKind.Local).AddTicks(9809) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(1750), new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(1773), new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(5421), new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(5438) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(6865), new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(6887), new DateTime(2022, 1, 4, 23, 10, 13, 713, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 714, DateTimeKind.Local).AddTicks(879), new DateTime(2022, 1, 4, 23, 10, 13, 714, DateTimeKind.Local).AddTicks(895) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 714, DateTimeKind.Local).AddTicks(2971), new DateTime(2022, 1, 4, 23, 10, 13, 714, DateTimeKind.Local).AddTicks(2985) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 4, 23, 10, 13, 714, DateTimeKind.Local).AddTicks(2993), new DateTime(2022, 1, 4, 23, 10, 13, 714, DateTimeKind.Local).AddTicks(2996) });
        }
    }
}
