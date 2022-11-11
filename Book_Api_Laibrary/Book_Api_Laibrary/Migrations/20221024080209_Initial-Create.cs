using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Book_Api_Laibrary.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "bookNo",
                table: "Books",
                newName: "bookno");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "bookno",
                table: "Books",
                newName: "bookNo");
        }
    }
}
