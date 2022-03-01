using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NslAPI.Data.Migrations
{
    public partial class apiuseradded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfPayment",
                value: new DateTime(2022, 2, 25, 9, 34, 20, 760, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfPayment",
                value: new DateTime(2022, 2, 25, 9, 34, 20, 765, DateTimeKind.Local).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfPayment",
                value: new DateTime(2022, 2, 25, 9, 34, 20, 765, DateTimeKind.Local).AddTicks(2585));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfPayment",
                value: new DateTime(2022, 2, 25, 1, 11, 24, 313, DateTimeKind.Local).AddTicks(5904));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfPayment",
                value: new DateTime(2022, 2, 25, 1, 11, 24, 318, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfPayment",
                value: new DateTime(2022, 2, 25, 1, 11, 24, 318, DateTimeKind.Local).AddTicks(4926));
        }
    }
}
