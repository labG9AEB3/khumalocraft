using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KhumaloCraft.Migrations
{
    /// <inheritdoc />
    public partial class DBCraft : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CraftDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CraftName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CraftData = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CraftCost = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CraftDetails", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CraftDetails");
        }
    }
}
