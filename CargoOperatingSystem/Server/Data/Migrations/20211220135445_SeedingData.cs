using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CargoOperatingSystem.Server.Data.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AwbNumber",
                table: "Mawbs",
                newName: "Origin");

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Suppliers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Destination",
                table: "Mawbs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DriverPhone",
                table: "Deliveries",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Consignees",
                columns: new[] { "Id", "Address", "CreatedBy", "DateCreate", "DateUpdated", "Email", "Name", "PhoneNumber", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "La Palma 1566, Mexico City", "System", new DateTime(2021, 12, 20, 14, 54, 44, 592, DateTimeKind.Local).AddTicks(2309), new DateTime(2021, 12, 20, 14, 54, 44, 595, DateTimeKind.Local).AddTicks(4769), "pedro@gmail.com", "Pedro Alvarez", 250350450, "System" },
                    { 2, "ShangriLa 255, Shanghai", "System", new DateTime(2021, 12, 20, 14, 54, 44, 596, DateTimeKind.Local).AddTicks(4807), new DateTime(2021, 12, 20, 14, 54, 44, 596, DateTimeKind.Local).AddTicks(4824), "liu.chong@gmail.com", "Liu Chong", 111222555, "System" },
                    { 3, "Na Kopci 15, Hradec Kralove", "System", new DateTime(2021, 12, 20, 14, 54, 44, 596, DateTimeKind.Local).AddTicks(4899), new DateTime(2021, 12, 20, 14, 54, 44, 596, DateTimeKind.Local).AddTicks(4902), "petr.a@seznam.cz", "Petr Adamec", 111222555, "System" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CompanyName", "ContactPersonName", "CreatedBy", "DateCreate", "DateUpdated", "Email", "HqAddress", "InvoicingAddress", "PhoneNumber", "TaxNumber", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Fiege", null, "System", new DateTime(2021, 12, 20, 14, 54, 44, 596, DateTimeKind.Local).AddTicks(9049), new DateTime(2021, 12, 20, 14, 54, 44, 596, DateTimeKind.Local).AddTicks(9066), "fiege.export@gmail.com", "K letisti 15, Praha 6", "K letisti 15, Praha 6", 123456789, "CZ12345678", "System" },
                    { 2, "Agility", null, "System", new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(795), new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(809), "air.export@agility.cz", "U Zlicina 25, Praha 6", "U Zlicina 25, Praha 6", 222333666, "CZ11145678", "System" },
                    { 3, "ATS", null, "System", new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(818), new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(820), "export@ats.com", "Laglerove 4, Praha 6", "Laglerove 4, Praha 6", 444666888, "CZ22245678", "System" }
                });

            migrationBuilder.InsertData(
                table: "Shippers",
                columns: new[] { "Id", "Address", "CreatedBy", "DateCreate", "DateUpdated", "Email", "Name", "PhoneNumber", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Aviaticka 55, Praha 6, 16000", "System", new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(4379), new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(4394), "export@dhl.cz", "DHL Forwarding", 555666999, "System" },
                    { 2, "Industrialni 256, Ostrava, 354442", "System", new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(5634), new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(5647), "expedice@foxcon.cz", "Foxcon cz", 332266448, "System" },
                    { 3, "K sidlist 25, Praha 6, 16200", "System", new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(5655), new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(5658), "prdel@starosta.cz", "Pavel Novotny", 604225336, "System" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "CompanyName", "ContactPersonName", "CreatedBy", "DateCreate", "DateUpdated", "Email", "HqAddress", "InvoicingAddress", "PhoneNumber", "TaxNumber", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "Arrow Mobile", "Petr Pallat", "System", new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(9331), new DateTime(2021, 12, 20, 14, 54, 44, 597, DateTimeKind.Local).AddTicks(9347), "info@arrow.cz", "K letisti 25, Praha 6, 16000", "K letisti 25, Praha 6, 16000", 603236639, "CZ12345678", "System" },
                    { 2, "Mayer", "Metr Ojtik", "System", new DateTime(2021, 12, 20, 14, 54, 44, 598, DateTimeKind.Local).AddTicks(1269), new DateTime(2021, 12, 20, 14, 54, 44, 598, DateTimeKind.Local).AddTicks(1282), "info@mayer.sk", "Na Radosti 256, Bratislava, 11100", "Na Radosti 256, Bratislava, 11100", 555666789, "SK12345678", "System" },
                    { 3, "Skyport", "Jan Fero", "System", new DateTime(2021, 12, 20, 14, 54, 44, 598, DateTimeKind.Local).AddTicks(1291), new DateTime(2021, 12, 20, 14, 54, 44, 598, DateTimeKind.Local).AddTicks(1294), "info@skyport.cz", "Laglerove 4, Praha 6, 16100", "Laglerove 4, Praha 6, 16100", 606485926, "CZ12345600", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Consignees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shippers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Destination",
                table: "Mawbs");

            migrationBuilder.RenameColumn(
                name: "Origin",
                table: "Mawbs",
                newName: "AwbNumber");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Suppliers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "DriverPhone",
                table: "Deliveries",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
