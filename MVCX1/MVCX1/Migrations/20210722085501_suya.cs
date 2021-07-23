using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCX1.Migrations
{
    public partial class suya : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserX",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Defence", "Dribble", "Name", "Passing" },
                values: new object[] { 75, 97, "Suarez", 90 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserX",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "Defence", "Dribble", "Name", "Passing" },
                values: new object[] { 85, 98, "Iniesta", 98 });
        }
    }
}
