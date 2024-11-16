using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SeverGame106.Migrations
{
    /// <inheritdoc />
    public partial class addDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LevelResults");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LevelResults",
                columns: table => new
                {
                    QuizResultId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompletionDate = table.Column<DateOnly>(type: "date", nullable: false),
                    LevelId = table.Column<int>(type: "int", nullable: false),
                    Score = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LevelResults", x => x.QuizResultId);
                });
        }
    }
}
