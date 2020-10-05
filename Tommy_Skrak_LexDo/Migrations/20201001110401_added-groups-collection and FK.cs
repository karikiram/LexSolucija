using Microsoft.EntityFrameworkCore.Migrations;

namespace Tommy_Skrak_LexDo.Migrations
{
    public partial class addedgroupscollectionandFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Group",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Group_UserId",
                table: "Group",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Group_AspNetUsers_UserId",
                table: "Group",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Group_AspNetUsers_UserId",
                table: "Group");

            migrationBuilder.DropIndex(
                name: "IX_Group_UserId",
                table: "Group");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Group");
        }
    }
}
