using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedNamePropToPickupModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Pickups",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "9ddd5094-de71-43e0-8784-f6fe44abd63e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "545e4fb1-a943-40c2-af1c-637211f57f31");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9b99ffe0-6420-483a-a973-40e0ead55f88", "AQAAAAEAACcQAAAAEFzJe/eHfNmgip1soJ/rjqwal0UNEvmStNQ1x1uHSiarZaoAkpObBrTZil2zuNoRaA==", "e0b54343-12e2-490a-9012-816165bdc85b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ac3adeb-446a-45f3-954d-4752edce3a64", "AQAAAAEAACcQAAAAEKrD88X6LIrsqB8EJugSa+UZQnV+HXhy2F1ZYeOPjmVR7dc5uKcdowP3Ty+xRU+vUw==", "3cd0de83-1343-4c93-bc91-f68c7098ead6" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 959, DateTimeKind.Local).AddTicks(37), new DateTime(2022, 5, 25, 11, 36, 46, 961, DateTimeKind.Local).AddTicks(4180) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 962, DateTimeKind.Local).AddTicks(4688), new DateTime(2022, 5, 25, 11, 36, 46, 962, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 962, DateTimeKind.Local).AddTicks(4792), new DateTime(2022, 5, 25, 11, 36, 46, 962, DateTimeKind.Local).AddTicks(4795) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 962, DateTimeKind.Local).AddTicks(8729), new DateTime(2022, 5, 25, 11, 36, 46, 962, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(1549), new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(1571), new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(1574) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(5444), new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(5460) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(6798), new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(6818), new DateTime(2022, 5, 25, 11, 36, 46, 963, DateTimeKind.Local).AddTicks(6820) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 964, DateTimeKind.Local).AddTicks(919), new DateTime(2022, 5, 25, 11, 36, 46, 964, DateTimeKind.Local).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 964, DateTimeKind.Local).AddTicks(3161), new DateTime(2022, 5, 25, 11, 36, 46, 964, DateTimeKind.Local).AddTicks(3173) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 36, 46, 964, DateTimeKind.Local).AddTicks(3181), new DateTime(2022, 5, 25, 11, 36, 46, 964, DateTimeKind.Local).AddTicks(3184) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Pickups");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "e40ea091-1c54-4238-ac51-86b8b986571e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "36eb4f2e-57ec-4d4b-99ee-aae0fa2e35ea");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1bed2bb6-cfef-48f4-bdb5-b26a17a849e0", "AQAAAAEAACcQAAAAEK0YGGqB3YOOx2cErgGNVeKYVnMijwV+rOCBY5YKyDFxEzYvNjjIRIP0k7fxO75yCA==", "7ba16b03-a219-4a50-b006-a22d1233eff4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36527b7b-325d-4e95-afff-17308d938e89", "AQAAAAEAACcQAAAAEGhyo1TLA3QJf+5N3w0HnIkX9ZbVK/gtgThZvL4O5D+48QH6DcoQvp0FUZp2NkDqmg==", "ce1b35f6-7371-461f-bf5f-89e49ccb2ab3" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 38, DateTimeKind.Local).AddTicks(8103), new DateTime(2022, 5, 25, 11, 31, 32, 41, DateTimeKind.Local).AddTicks(8343) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 42, DateTimeKind.Local).AddTicks(8490), new DateTime(2022, 5, 25, 11, 31, 32, 42, DateTimeKind.Local).AddTicks(8508) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 42, DateTimeKind.Local).AddTicks(8585), new DateTime(2022, 5, 25, 11, 31, 32, 42, DateTimeKind.Local).AddTicks(8588) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(2577), new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(4403), new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(4425), new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(4428) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(8187), new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(9553), new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(9567) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(9584), new DateTime(2022, 5, 25, 11, 31, 32, 43, DateTimeKind.Local).AddTicks(9586) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 44, DateTimeKind.Local).AddTicks(3435), new DateTime(2022, 5, 25, 11, 31, 32, 44, DateTimeKind.Local).AddTicks(3452) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 44, DateTimeKind.Local).AddTicks(5454), new DateTime(2022, 5, 25, 11, 31, 32, 44, DateTimeKind.Local).AddTicks(5468) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 5, 25, 11, 31, 32, 44, DateTimeKind.Local).AddTicks(5476), new DateTime(2022, 5, 25, 11, 31, 32, 44, DateTimeKind.Local).AddTicks(5478) });
        }
    }
}
