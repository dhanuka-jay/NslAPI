using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NslAPI.Data.Migrations
{
    public partial class feeddata2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<int>(type: "int", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomePhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NextOfKin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Relationship = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NOKPhone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeeType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AmountPaid = table.Column<int>(type: "int", nullable: false),
                    DateOfPayment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fees_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JerseyName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JerseyNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    JerseySize = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BattingStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BowlingStyle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayingRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "City", "DOB", "Email", "FName", "HomePhone", "IsActive", "LName", "MName", "Mobile", "NOKPhone", "NextOfKin", "Postcode", "ProfilePicture", "Relationship", "State", "Street" },
                values: new object[] { 1, "Ngunnawal", new DateTime(1984, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "dhanuka.singhe@gmail.com", "Dhanuka", "", 1, "Ilandarage", "Sudheera", "0432009680", "0432000222", "Ryan", 2913, "", "Son", "ACT", "7 Igera Place" });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "City", "DOB", "Email", "FName", "HomePhone", "IsActive", "LName", "MName", "Mobile", "NOKPhone", "NextOfKin", "Postcode", "ProfilePicture", "Relationship", "State", "Street" },
                values: new object[] { 2, "Ngunnawal", new DateTime(2014, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "ryan.singhe@gmail.com", "Ryan", "", 1, "Ilandarage", "Harindu", "0432222000", "0432333999", "Pavithri", 2913, "", "Mom", "ACT", "7 Igera Place" });

            migrationBuilder.InsertData(
                table: "Fees",
                columns: new[] { "Id", "AmountPaid", "DateOfPayment", "FeeType", "MemberId" },
                values: new object[,]
                {
                    { 1, 200, new DateTime(2022, 2, 23, 15, 21, 2, 164, DateTimeKind.Local).AddTicks(2605), "Member", 1 },
                    { 2, 200, new DateTime(2022, 2, 23, 15, 21, 2, 167, DateTimeKind.Local).AddTicks(6528), "Member", 2 },
                    { 3, 100, new DateTime(2022, 2, 23, 15, 21, 2, 167, DateTimeKind.Local).AddTicks(6577), "Jersey", 2 }
                });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "BattingStyle", "BowlingStyle", "JerseyName", "JerseyNumber", "JerseySize", "MemberId", "PlayingRole" },
                values: new object[] { 1, "Left", "Right arm Medium Pace", "Sudeera", "23", "M", 1, "Allrounder" });

            migrationBuilder.CreateIndex(
                name: "IX_Fees_MemberId",
                table: "Fees",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_MemberId",
                table: "Players",
                column: "MemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fees");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Members");
        }
    }
}
