using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCX1.Migrations
{
    public partial class fourbar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserX",
                columns: new[] { "ID", "Defence", "Dribble", "Name", "Passing", "Shoot" },
                values: new object[] { 2, 60, 99, "Messi", 97, 99 });

            migrationBuilder.InsertData(
                table: "UserX",
                columns: new[] { "ID", "Defence", "Dribble", "Name", "Passing", "Shoot" },
                values: new object[] { 3, 93, 96, "XAVI", 99, 92 });

            migrationBuilder.InsertData(
                table: "UserX",
                columns: new[] { "ID", "Defence", "Dribble", "Name", "Passing", "Shoot" },
                values: new object[] { 4, 85, 98, "Iniesta", 98, 99 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserX",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserX",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserX",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
