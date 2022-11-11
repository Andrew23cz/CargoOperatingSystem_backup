using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class UpdatedIssuingDataInMawbModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "placeOfSignature",
                table: "Mawbs",
                newName: "IssuingPlace");

            migrationBuilder.RenameColumn(
                name: "DateOfSignature",
                table: "Mawbs",
                newName: "IssuingDate");

            migrationBuilder.AddColumn<string>(
                name: "IssuingPersonFullName",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "5bee3432-e144-49ef-9348-2455e966e65c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "6ce8b6f7-9af4-4560-869b-b1795b8f6e2c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f8828f3e-93f9-401d-aa71-45da1c5b0469", "AQAAAAEAACcQAAAAEJnvtUVnF3R36lyEXybOmi2zeEQyPe2S1rojh837xnE21s6m2+lG0FNVnDjQD2pxtQ==", "e94c55f3-bd9d-4786-bb8a-4e05bd1a4f9d" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 326, DateTimeKind.Local).AddTicks(9543), new DateTime(2022, 1, 22, 15, 19, 15, 329, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(3891), new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(3908) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(3982), new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(3986) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(7821), new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(7838) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(9625), new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(9640) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(9703), new DateTime(2022, 1, 22, 15, 19, 15, 330, DateTimeKind.Local).AddTicks(9706) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(3157), new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(3174) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(4550), new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(4571), new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(4574) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(8415), new DateTime(2022, 1, 22, 15, 19, 15, 331, DateTimeKind.Local).AddTicks(8431) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 332, DateTimeKind.Local).AddTicks(405), new DateTime(2022, 1, 22, 15, 19, 15, 332, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 22, 15, 19, 15, 332, DateTimeKind.Local).AddTicks(428), new DateTime(2022, 1, 22, 15, 19, 15, 332, DateTimeKind.Local).AddTicks(430) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IssuingPersonFullName",
                table: "Mawbs");

            migrationBuilder.RenameColumn(
                name: "IssuingPlace",
                table: "Mawbs",
                newName: "placeOfSignature");

            migrationBuilder.RenameColumn(
                name: "IssuingDate",
                table: "Mawbs",
                newName: "DateOfSignature");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "6507a919-e976-478f-a295-fd1e53ecdaf0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "ce254708-ca6b-49f6-8cd3-92529ec5a576");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95b220a9-c728-4b51-94d8-c2570cdc6cfc", "AQAAAAEAACcQAAAAEB4Dd9Ka2VD0UUyXnfE+IQQ8A5P95up189AyYOlUnLbVUMawQWbPcmPoFXDp/kJWcA==", "40f51a12-a3ce-4508-9ecc-be3cbce75f00" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 567, DateTimeKind.Local).AddTicks(9756), new DateTime(2022, 1, 21, 19, 55, 36, 571, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(1547), new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(1641), new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(5595), new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(5610) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(7503), new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(7525), new DateTime(2022, 1, 21, 19, 55, 36, 572, DateTimeKind.Local).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(1432), new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(1447) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(2794), new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(2815), new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(2817) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(6663), new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(6678) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(8773), new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(8787) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(8796), new DateTime(2022, 1, 21, 19, 55, 36, 573, DateTimeKind.Local).AddTicks(8798) });
        }
    }
}
