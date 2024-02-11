using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuperDigito.Migrations
{
    /// <inheritdoc />
    public partial class MigraciónID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_History_Login_UserId",
                table: "History");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Login",
                table: "Login");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "History",
                newName: "HistoryId");

            migrationBuilder.AlterColumn<string>(
                name: "User",
                table: "Login",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Login",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "History",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Login",
                table: "Login",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_History_Login_UserId",
                table: "History",
                column: "UserId",
                principalTable: "Login",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_History_Login_UserId",
                table: "History");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Login",
                table: "Login");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Login");

            migrationBuilder.RenameColumn(
                name: "HistoryId",
                table: "History",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "User",
                table: "Login",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "History",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Login",
                table: "Login",
                column: "User");

            migrationBuilder.AddForeignKey(
                name: "FK_History_Login_UserId",
                table: "History",
                column: "UserId",
                principalTable: "Login",
                principalColumn: "User",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
