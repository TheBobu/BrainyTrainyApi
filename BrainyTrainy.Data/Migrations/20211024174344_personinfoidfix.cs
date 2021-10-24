using Microsoft.EntityFrameworkCore.Migrations;

namespace BrainyTrainy.Data.Migrations
{
    public partial class personinfoidfix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_PersonInfos_InfoPersonInfoId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_InfoPersonInfoId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "InfoPersonInfoId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "InfoId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Users_InfoId",
                table: "Users",
                column: "InfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_PersonInfos_InfoId",
                table: "Users",
                column: "InfoId",
                principalTable: "PersonInfos",
                principalColumn: "PersonInfoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_PersonInfos_InfoId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_InfoId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "InfoId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "InfoPersonInfoId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_InfoPersonInfoId",
                table: "Users",
                column: "InfoPersonInfoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_PersonInfos_InfoPersonInfoId",
                table: "Users",
                column: "InfoPersonInfoId",
                principalTable: "PersonInfos",
                principalColumn: "PersonInfoId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
