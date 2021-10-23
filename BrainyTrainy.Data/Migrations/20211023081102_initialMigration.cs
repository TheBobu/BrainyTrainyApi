using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BrainyTrainy.Data.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "PersonInfos",
                columns: table => new
                {
                    PersonInfoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    ContactPersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactPersonNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonInfos", x => x.PersonInfoId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InfoPersonInfoId = table.Column<int>(type: "int", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_PersonInfos_InfoPersonInfoId",
                        column: x => x.InfoPersonInfoId,
                        principalTable: "PersonInfos",
                        principalColumn: "PersonInfoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GameHistories",
                columns: table => new
                {
                    GameHistoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    TimeCompleted = table.Column<TimeSpan>(type: "time", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameHistories", x => x.GameHistoryId);
                    table.ForeignKey(
                        name: "FK_GameHistories_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameHistories_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameProgresses",
                columns: table => new
                {
                    GameProgressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AverageScore = table.Column<int>(type: "int", nullable: false),
                    AverageTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Week = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameProgresses", x => x.GameProgressId);
                    table.ForeignKey(
                        name: "FK_GameProgresses_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "GameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameProgresses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameHistories_GameId",
                table: "GameHistories",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameHistories_UserId",
                table: "GameHistories",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_GameProgresses_GameId",
                table: "GameProgresses",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_GameProgresses_UserId",
                table: "GameProgresses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_InfoPersonInfoId",
                table: "Users",
                column: "InfoPersonInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameHistories");

            migrationBuilder.DropTable(
                name: "GameProgresses");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "PersonInfos");
        }
    }
}
