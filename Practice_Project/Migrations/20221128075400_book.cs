using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PracticeProject.Migrations
{
    /// <inheritdoc />
    public partial class book : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Student_studentId",
                table: "Book");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Book",
                table: "Book");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Book",
                newName: "Books");

            migrationBuilder.RenameIndex(
                name: "IX_Book_studentId",
                table: "Books",
                newName: "IX_Books_studentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Books",
                table: "Books",
                column: "bookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Students_studentId",
                table: "Books",
                column: "studentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Students_studentId",
                table: "Books");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Books",
                table: "Books");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "Books",
                newName: "Book");

            migrationBuilder.RenameIndex(
                name: "IX_Books_studentId",
                table: "Book",
                newName: "IX_Book_studentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Book",
                table: "Book",
                column: "bookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Student_studentId",
                table: "Book",
                column: "studentId",
                principalTable: "Student",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
