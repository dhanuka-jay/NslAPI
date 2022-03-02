using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NslAPI.Data.Migrations
{
    public partial class AddedModeratorRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87dbcf1e-1cc8-49cc-9120-945c41028af5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9e7be73-d116-4f38-b108-0ac5dcb99337");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ae6c7e26-a201-41f7-89b2-25dee26fd23f", "68c4cddc-233e-4843-bcd5-8553b5818172", "User", "USER" },
                    { "dac33ce2-3971-4d9e-ae96-6574455de0c7", "de97f054-ca66-43d8-921f-bf70e0cf8188", "Moderator", "MODERATOR" },
                    { "a309a153-98f9-401c-9dd9-155234494816", "d7885112-1a58-4127-95c7-b8cfe3b67bc9", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateOfPayment",
                value: new DateTime(2022, 3, 1, 21, 20, 2, 931, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateOfPayment",
                value: new DateTime(2022, 3, 1, 21, 20, 2, 941, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "Fees",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateOfPayment",
                value: new DateTime(2022, 3, 1, 21, 20, 2, 941, DateTimeKind.Local).AddTicks(6340));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a309a153-98f9-401c-9dd9-155234494816");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ae6c7e26-a201-41f7-89b2-25dee26fd23f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dac33ce2-3971-4d9e-ae96-6574455de0c7");

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
    }
}
