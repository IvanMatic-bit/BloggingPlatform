using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BloggingPlatform.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TagId",
                table: "Blogposts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BlogPostId",
                table: "Comments",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogposts_TagId",
                table: "Blogposts",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_Blogposts_Tags_TagId",
                table: "Blogposts",
                column: "TagId",
                principalTable: "Tags",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Blogposts_BlogPostId",
                table: "Comments",
                column: "BlogPostId",
                principalTable: "Blogposts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Blogposts_Tags_TagId",
                table: "Blogposts");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Blogposts_BlogPostId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_BlogPostId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Blogposts_TagId",
                table: "Blogposts");

            migrationBuilder.DropColumn(
                name: "TagId",
                table: "Blogposts");
        }
    }
}
