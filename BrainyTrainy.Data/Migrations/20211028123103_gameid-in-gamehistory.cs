using Microsoft.EntityFrameworkCore.Migrations;

namespace BrainyTrainy.Data.Migrations
{
    public partial class gameidingamehistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "GameHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GameId",
                table: "GameHistories");
        }
    }
}
