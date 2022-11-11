using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class AddedMawbIssuingDateToShipment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "MawbIssuingDate",
                table: "Shipments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "c8ec71ea-9e60-4ce8-a13c-8d72468d36af");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "ee3720c9-9d3f-46ce-8d87-f552a7ad040e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bfec5ae-f276-45c5-b019-904f6fb1a960", "AQAAAAEAACcQAAAAEOzzG3hklfdyLj6uqq6Sd6WFsuVgJXFMiBzMuoSIlIzYVtYGxY2KkCDVbzHYYuKkwQ==", "ac98684b-0205-4ca3-85f2-f3aebec867d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92b6218e-4a39-42e9-85aa-6decab1e7e99", "AQAAAAEAACcQAAAAEPWQ7FBwt5UmX9+Uzm4vR3V992p7ffDbWUP37Lns/oF+5/bgX2T66nZ8nihQzmnoyQ==", "396c2bc4-aa12-41bd-8534-31d06baa439f" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 536, DateTimeKind.Local).AddTicks(7849), new DateTime(2022, 4, 29, 19, 56, 2, 539, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(3970), new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(3987) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(4062), new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(4065) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(8017), new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(9898), new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(9911) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(9920), new DateTime(2022, 4, 29, 19, 56, 2, 540, DateTimeKind.Local).AddTicks(9922) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 541, DateTimeKind.Local).AddTicks(3497), new DateTime(2022, 4, 29, 19, 56, 2, 541, DateTimeKind.Local).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 541, DateTimeKind.Local).AddTicks(4841), new DateTime(2022, 4, 29, 19, 56, 2, 541, DateTimeKind.Local).AddTicks(4853) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 541, DateTimeKind.Local).AddTicks(4861), new DateTime(2022, 4, 29, 19, 56, 2, 541, DateTimeKind.Local).AddTicks(4864) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 541, DateTimeKind.Local).AddTicks(8616), new DateTime(2022, 4, 29, 19, 56, 2, 541, DateTimeKind.Local).AddTicks(8631) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 542, DateTimeKind.Local).AddTicks(856), new DateTime(2022, 4, 29, 19, 56, 2, 542, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 19, 56, 2, 542, DateTimeKind.Local).AddTicks(878), new DateTime(2022, 4, 29, 19, 56, 2, 542, DateTimeKind.Local).AddTicks(880) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MawbIssuingDate",
                table: "Shipments");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bef2159-5dd7-4924-b8b3-95386f8cc6ef",
                column: "ConcurrencyStamp",
                value: "ebd51080-19ca-49fa-8108-27b64be118c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ccb2e70-33cd-43d6-90c8-ddfe47f462ac",
                column: "ConcurrencyStamp",
                value: "1fa01f8f-01c8-49ec-9c4f-60ceeea7c5c6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d304",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "49b61ff2-863f-4272-875d-5052d7d8dd01", "AQAAAAEAACcQAAAAEIOe8de69g1NHyOv+KzcNTKOwf6kYAHaefRwsyIkrr7ZZSf64wGT+PCQf+JMZi9LHw==", "3f0d6437-1bab-4222-aeed-90e56aeea3e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3bc7e01-778b-400a-a7f6-3289c681d405",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f6f56aa-fc79-4ff6-a1f2-aafa9ead683d", "AQAAAAEAACcQAAAAEGzGmtf76JvsQUv99dJsj+C6FbNqGCoCw9yooMzlPw5GTbrthfAchVhwgbKViA5f0g==", "be09fd30-646c-416c-b183-fd8d5987f5e9" });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 934, DateTimeKind.Local).AddTicks(984), new DateTime(2022, 4, 29, 13, 29, 26, 936, DateTimeKind.Local).AddTicks(6173) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 937, DateTimeKind.Local).AddTicks(6088), new DateTime(2022, 4, 29, 13, 29, 26, 937, DateTimeKind.Local).AddTicks(6105) });

            migrationBuilder.UpdateData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 937, DateTimeKind.Local).AddTicks(6178), new DateTime(2022, 4, 29, 13, 29, 26, 937, DateTimeKind.Local).AddTicks(6181) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 937, DateTimeKind.Local).AddTicks(9948), new DateTime(2022, 4, 29, 13, 29, 26, 937, DateTimeKind.Local).AddTicks(9965) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(1708), new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(1729), new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(5369), new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(6664), new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(6677) });

            migrationBuilder.UpdateData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(6685), new DateTime(2022, 4, 29, 13, 29, 26, 938, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 939, DateTimeKind.Local).AddTicks(653), new DateTime(2022, 4, 29, 13, 29, 26, 939, DateTimeKind.Local).AddTicks(670) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 939, DateTimeKind.Local).AddTicks(2782), new DateTime(2022, 4, 29, 13, 29, 26, 939, DateTimeKind.Local).AddTicks(2795) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2022, 4, 29, 13, 29, 26, 939, DateTimeKind.Local).AddTicks(2803), new DateTime(2022, 4, 29, 13, 29, 26, 939, DateTimeKind.Local).AddTicks(2806) });
        }
    }
}
