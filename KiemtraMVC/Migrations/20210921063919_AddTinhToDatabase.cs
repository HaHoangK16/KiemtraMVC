using Microsoft.EntityFrameworkCore.Migrations;

namespace KiemtraMVC.Migrations
{
    public partial class AddTinhToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Huyens",
                columns: table => new
                {
                    IdHuyen = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenHuyen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdTinh = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Huyens", x => x.IdHuyen);
                });

            migrationBuilder.CreateTable(
                name: "Tinhs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenTinh = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tinhs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Huyens");

            migrationBuilder.DropTable(
                name: "Tinhs");
        }
    }
}
