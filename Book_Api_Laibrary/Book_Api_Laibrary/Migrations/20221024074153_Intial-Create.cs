using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_Api_Laibrary.Migrations
{
    public partial class IntialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Books",
                newName: "title");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Books",
                newName: "subject");

            migrationBuilder.RenameColumn(
                name: "AuthorName",
                table: "Books",
                newName: "authorname");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title",
                table: "Books",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "subject",
                table: "Books",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "authorname",
                table: "Books",
                newName: "AuthorName");
        }
    }
}
