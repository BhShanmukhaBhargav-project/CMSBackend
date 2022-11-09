using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMSWebApi.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "claim",
                columns: table => new
                {
                    cId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    ClaimDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_claim", x => x.cId);
                });

            migrationBuilder.CreateTable(
                name: "members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Key = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_members", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "plans",
                columns: table => new
                {
                    pId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EndDate = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plans", x => x.pId);
                });

            migrationBuilder.CreateTable(
                name: "memberPlans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MId = table.Column<int>(type: "int", nullable: false),
                    PId = table.Column<int>(type: "int", nullable: false),
                    CId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_memberPlans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_memberPlans_claim_CId",
                        column: x => x.CId,
                        principalTable: "claim",
                        principalColumn: "cId");
                    table.ForeignKey(
                        name: "FK_memberPlans_members_MId",
                        column: x => x.MId,
                        principalTable: "members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_memberPlans_plans_PId",
                        column: x => x.PId,
                        principalTable: "plans",
                        principalColumn: "pId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "claim",
                columns: new[] { "cId", "Amount", "ClaimDate" },
                values: new object[,]
                {
                    { 1, 20000.0, "22-10-2022" },
                    { 2, 30000.0, "23-10-2022" }
                });

            migrationBuilder.InsertData(
                table: "members",
                columns: new[] { "Id", "Address", "Country", "Dob", "EmailId", "Key", "Password", "PasswordHash", "PhoneNumber", "Role", "State", "Status", "UserName" },
                values: new object[,]
                {
                    { 101, "Ahmedabad", "India", "2-10-1869", "Babita@123", new byte[] { 132, 219, 95, 149, 108, 35, 48, 127, 64, 9, 103, 196, 218, 246, 162, 247, 57, 46, 161, 92, 229, 139, 70, 142, 146, 165, 59, 88, 187, 131, 94, 83, 136, 247, 41, 40, 87, 180, 1, 75, 125, 86, 72, 208, 93, 103, 50, 151, 227, 57, 86, 247, 11, 131, 31, 195, 70, 172, 199, 26, 150, 168, 122, 146, 188, 61, 106, 117, 78, 33, 91, 173, 77, 60, 37, 78, 122, 167, 5, 91, 163, 199, 224, 66, 71, 27, 74, 108, 229, 5, 208, 196, 161, 174, 122, 31, 236, 187, 35, 148, 155, 203, 23, 99, 125, 192, 99, 59, 14, 133, 220, 29, 213, 46, 221, 198, 214, 174, 100, 97, 41, 146, 29, 227, 187, 166, 84, 56 }, "Babita", new byte[] { 135, 100, 47, 176, 242, 162, 33, 20, 139, 129, 99, 66, 14, 218, 74, 240, 226, 69, 59, 15, 207, 253, 52, 78, 250, 70, 16, 222, 113, 213, 177, 195, 186, 10, 88, 235, 211, 198, 155, 23, 45, 183, 118, 75, 12, 164, 3, 171, 106, 208, 23, 63, 201, 238, 34, 39, 100, 42, 208, 183, 120, 93, 239, 124 }, "66666666", null, "Gujrat", null, "Jethalal" },
                    { 102, "Mumbai", "India", "3-10-1868", "Madhavi@123", new byte[] { 132, 219, 95, 149, 108, 35, 48, 127, 64, 9, 103, 196, 218, 246, 162, 247, 57, 46, 161, 92, 229, 139, 70, 142, 146, 165, 59, 88, 187, 131, 94, 83, 136, 247, 41, 40, 87, 180, 1, 75, 125, 86, 72, 208, 93, 103, 50, 151, 227, 57, 86, 247, 11, 131, 31, 195, 70, 172, 199, 26, 150, 168, 122, 146, 188, 61, 106, 117, 78, 33, 91, 173, 77, 60, 37, 78, 122, 167, 5, 91, 163, 199, 224, 66, 71, 27, 74, 108, 229, 5, 208, 196, 161, 174, 122, 31, 236, 187, 35, 148, 155, 203, 23, 99, 125, 192, 99, 59, 14, 133, 220, 29, 213, 46, 221, 198, 214, 174, 100, 97, 41, 146, 29, 227, 187, 166, 84, 56 }, "Madhavi", new byte[] { 39, 109, 147, 80, 217, 91, 167, 219, 155, 246, 13, 90, 118, 223, 230, 23, 144, 129, 64, 95, 190, 123, 203, 203, 79, 175, 230, 107, 130, 120, 41, 4, 30, 254, 144, 164, 162, 82, 64, 107, 161, 67, 43, 56, 219, 185, 179, 222, 101, 15, 124, 81, 138, 46, 186, 68, 209, 212, 89, 113, 144, 60, 2, 46 }, "66666667", null, "Maharashtra", null, "Bhide" },
                    { 103, "Begusarai", "India", "27-09-2000", "krantdarshi1999@gmail.com", new byte[] { 132, 219, 95, 149, 108, 35, 48, 127, 64, 9, 103, 196, 218, 246, 162, 247, 57, 46, 161, 92, 229, 139, 70, 142, 146, 165, 59, 88, 187, 131, 94, 83, 136, 247, 41, 40, 87, 180, 1, 75, 125, 86, 72, 208, 93, 103, 50, 151, 227, 57, 86, 247, 11, 131, 31, 195, 70, 172, 199, 26, 150, 168, 122, 146, 188, 61, 106, 117, 78, 33, 91, 173, 77, 60, 37, 78, 122, 167, 5, 91, 163, 199, 224, 66, 71, 27, 74, 108, 229, 5, 208, 196, 161, 174, 122, 31, 236, 187, 35, 148, 155, 203, 23, 99, 125, 192, 99, 59, 14, 133, 220, 29, 213, 46, 221, 198, 214, 174, 100, 97, 41, 146, 29, 227, 187, 166, 84, 56 }, "Krant@1999", new byte[] { 186, 219, 90, 37, 148, 24, 2, 227, 223, 59, 51, 225, 27, 140, 48, 193, 141, 10, 171, 13, 41, 138, 90, 233, 21, 219, 18, 184, 123, 80, 58, 214, 85, 2, 149, 45, 171, 112, 231, 160, 178, 215, 99, 103, 215, 145, 57, 213, 121, 60, 127, 198, 28, 69, 116, 103, 95, 216, 96, 171, 42, 97, 139, 124 }, "6205629235", "Admin", "Bihar", "Active", "Krantdarshi" }
                });

            migrationBuilder.InsertData(
                table: "plans",
                columns: new[] { "pId", "Amount", "Duration", "EndDate", "StartDate", "pName" },
                values: new object[,]
                {
                    { 1, "1000000", "1 years", null, null, "Jeevan Raksha Yojna" },
                    { 2, "200000", "5 years", null, null, "Health Security Plan " }
                });

            migrationBuilder.InsertData(
                table: "memberPlans",
                columns: new[] { "Id", "CId", "MId", "PId" },
                values: new object[] { 1, 1, 101, 1 });

            migrationBuilder.InsertData(
                table: "memberPlans",
                columns: new[] { "Id", "CId", "MId", "PId" },
                values: new object[] { 2, 1, 102, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_memberPlans_CId",
                table: "memberPlans",
                column: "CId");

            migrationBuilder.CreateIndex(
                name: "IX_memberPlans_MId",
                table: "memberPlans",
                column: "MId");

            migrationBuilder.CreateIndex(
                name: "IX_memberPlans_PId",
                table: "memberPlans",
                column: "PId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "memberPlans");

            migrationBuilder.DropTable(
                name: "claim");

            migrationBuilder.DropTable(
                name: "members");

            migrationBuilder.DropTable(
                name: "plans");
        }
    }
}
