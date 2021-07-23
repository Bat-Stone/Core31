using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCX1.Migrations
{
    public partial class InTo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserX",
                columns: new[] { "ID", "Defence", "Dribble", "Name", "Passing", "Shoot" },
                values: new object[] { 5, 85, 98, "Iniesta", 98, 99 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserX",
                keyColumn: "ID",
                keyValue: 5);
        }
    }
}
