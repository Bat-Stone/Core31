using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCX1.Migrations
{
    public partial class SeedPlayerSTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserX",
                columns: new[] { "ID", "Defence", "Dribble", "Name", "Passing", "Shoot" },
                values: new object[] { 1, 99, 96, "Alves", 98, 90 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserX",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
