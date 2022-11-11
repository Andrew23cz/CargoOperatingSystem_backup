using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class ChangingArrivalAndPickupModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Pickup",
                table: "Arrival",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "PickupAddress",
                table: "Arrival",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PickupDate",
                table: "Arrival",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "39b078e4-bb11-4323-8034-5a1313304689");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "cbe5a6fe-581e-4c12-8e3d-72f5ba82270d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad141c58-be42-4dbb-81f7-0d760091a6c9", "AQAAAAEAACcQAAAAEPLy5aBu2WS9Um4k3DjAEbySwVR80lafO2F4ir1j8wE+V9CcMU9srD5jpgHbzplbQg==", "9e5362a3-1561-41d6-af59-f058f4af797b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37ca0db5-4e51-430c-bb40-95b157f344a0", "AQAAAAEAACcQAAAAEHzABrDdfZGuCxPpoFc72WPbUIh+hQsZ9JHnohsjANF06pkzk1j4ap15vpx/aUa91A==", "552e306f-5751-4c4a-9f30-b9c96097b811" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 888, DateTimeKind.Local).AddTicks(4620), new DateTime(2022, 5, 24, 15, 23, 2, 891, DateTimeKind.Local).AddTicks(301) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(2952), new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(2973) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(3046), new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(3049) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(7523), new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(7541) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(9374), new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(9387) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(9395), new DateTime(2022, 5, 24, 15, 23, 2, 892, DateTimeKind.Local).AddTicks(9397) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 893, DateTimeKind.Local).AddTicks(3699), new DateTime(2022, 5, 24, 15, 23, 2, 893, DateTimeKind.Local).AddTicks(3716) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 893, DateTimeKind.Local).AddTicks(4983), new DateTime(2022, 5, 24, 15, 23, 2, 893, DateTimeKind.Local).AddTicks(4995) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 893, DateTimeKind.Local).AddTicks(5003), new DateTime(2022, 5, 24, 15, 23, 2, 893, DateTimeKind.Local).AddTicks(5005) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 894, DateTimeKind.Local).AddTicks(560), new DateTime(2022, 5, 24, 15, 23, 2, 894, DateTimeKind.Local).AddTicks(580) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 894, DateTimeKind.Local).AddTicks(3796), new DateTime(2022, 5, 24, 15, 23, 2, 894, DateTimeKind.Local).AddTicks(3815) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 24, 15, 23, 2, 894, DateTimeKind.Local).AddTicks(3830), new DateTime(2022, 5, 24, 15, 23, 2, 894, DateTimeKind.Local).AddTicks(3835) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pickup",
                table: "Arrival");

            migrationBuilder.DropColumn(
                name: "PickupAddress",
                table: "Arrival");

            migrationBuilder.DropColumn(
                name: "PickupDate",
                table: "Arrival");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "cfcd864a-1b16-4ea3-bc0f-793d05d62594");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "201e5af5-e26a-43a1-9152-9e09a65e0b4a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45f1ff49-b2c0-4086-8c68-922f80eccce7", "AQAAAAEAACcQAAAAEOPezOhAHEZ9ngdMC/c5D5wo2y/tuvdXZg5nepefYfw2DJG0D5wPfghfNm/trmiSLA==", "c6ac8e49-8da6-47fd-8fc6-4fcbaf1ca06c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7e49f77a-e500-4398-8395-6f1616b31de7", "AQAAAAEAACcQAAAAEPy8GgB8At03Sc7SnYezf6ETAhHUP3eyGdJ4+w/YSNP7yx+zJeDM6dS0NuzqcGbxwg==", "103c22ab-4d78-4370-9763-53fc17086d1a" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 27, DateTimeKind.Local).AddTicks(8618), new DateTime(2022, 5, 12, 13, 48, 23, 30, DateTimeKind.Local).AddTicks(3669) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(3619), new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(3712), new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(3715) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(7731), new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(9600), new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(9615) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(9623), new DateTime(2022, 5, 12, 13, 48, 23, 31, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 32, DateTimeKind.Local).AddTicks(3279), new DateTime(2022, 5, 12, 13, 48, 23, 32, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 32, DateTimeKind.Local).AddTicks(4569), new DateTime(2022, 5, 12, 13, 48, 23, 32, DateTimeKind.Local).AddTicks(4582) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 32, DateTimeKind.Local).AddTicks(4589), new DateTime(2022, 5, 12, 13, 48, 23, 32, DateTimeKind.Local).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 32, DateTimeKind.Local).AddTicks(8602), new DateTime(2022, 5, 12, 13, 48, 23, 32, DateTimeKind.Local).AddTicks(8618) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 33, DateTimeKind.Local).AddTicks(611), new DateTime(2022, 5, 12, 13, 48, 23, 33, DateTimeKind.Local).AddTicks(624) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 12, 13, 48, 23, 33, DateTimeKind.Local).AddTicks(633), new DateTime(2022, 5, 12, 13, 48, 23, 33, DateTimeKind.Local).AddTicks(635) });
        }
    }
}
