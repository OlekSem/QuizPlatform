using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Quizzy.Migrations
{
    /// <inheritdoc />
    public partial class db_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestSessions_AspNetUsers_UserId",
                table: "TestSessions");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "TestSessions",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_TestSessions_AspNetUsers_UserId",
                table: "TestSessions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestSessions_AspNetUsers_UserId",
                table: "TestSessions");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "TestSessions",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TestSessions_AspNetUsers_UserId",
                table: "TestSessions",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
