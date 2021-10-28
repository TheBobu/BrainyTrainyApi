using Microsoft.EntityFrameworkCore.Migrations;

namespace BrainyTrainy.Data.Migrations
{
    public partial class changedTheGameTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameHistories_Games_GameId",
                table: "GameHistories");

            migrationBuilder.DropForeignKey(
                name: "FK_GameProgresses_Games_GameId",
                table: "GameProgresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_GameProgresses_GameId",
                table: "GameProgresses");

            migrationBuilder.DropIndex(
                name: "IX_GameHistories_GameId",
                table: "GameHistories");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "GameHistories");

            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Games",
                newName: "Id");

            migrationBuilder.AddColumn<int>(
                name: "GameId1",
                table: "GameProgresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Math" },
                    { 2, "Quiz" },
                    { 3, "Puzzle" },
                    { 4, "FillTheGaps" },
                    { 5, "Matching" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameProgresses_GameId1",
                table: "GameProgresses",
                column: "GameId1");

            migrationBuilder.AddForeignKey(
                name: "FK_GameProgresses_Games_GameId1",
                table: "GameProgresses",
                column: "GameId1",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameProgresses_Games_GameId1",
                table: "GameProgresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_GameProgresses_GameId1",
                table: "GameProgresses");

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "GameId1",
                table: "GameProgresses");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Games",
                newName: "Type");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "GameHistories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameProgresses_GameId",
                table: "GameProgresses",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameHistories_GameId",
                table: "GameHistories",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameHistories_Games_GameId",
                table: "GameHistories",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameProgresses_Games_GameId",
                table: "GameProgresses",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
