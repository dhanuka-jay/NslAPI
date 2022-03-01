using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NslAPI.Data.Migrations
{
    public partial class AddedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "87dbcf1e-1cc8-49cc-9120-945c41028af5", "7885486a-3f18-46d8-b415-14a9bfbccb25", "User", "USER" },
                    { "f9e7be73-d116-4f38-b108-0ac5dcb99337", "73a55caa-282d-4bba-b965-b72362b6cdce", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfPayment",
                value: new DateTime(2022, 2, 25, 10, 6, 38, 334, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfPayment",
                value: new DateTime(2022, 2, 25, 10, 6, 38, 341, DateTimeKind.Local).AddTicks(3664));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfPayment",
                value: new DateTime(2022, 2, 25, 10, 6, 38, 341, DateTimeKind.Local).AddTicks(3726));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87dbcf1e-1cc8-49cc-9120-945c41028af5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9e7be73-d116-4f38-b108-0ac5dcb99337");

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
    }
}
