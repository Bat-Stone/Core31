using Microsoft.EntityFrameworkCore.Migrations;

namespace MVCX1.Migrations
{
    public partial class SqlMigraton : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserX",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Shoot = table.Column<int>(nullable: false),
                    Dribble = table.Column<int>(nullable: false),
                    Passing = table.Column<int>(nullable: false),
                    Defence = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserX", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserX");
        }
    }
}
