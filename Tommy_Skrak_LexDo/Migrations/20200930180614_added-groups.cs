using Microsoft.EntityFrameworkCore.Migrations;

namespace Tommy_Skrak_LexDo.Migrations
{
    public partial class addedgroups : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Group",
                table: "Reminder");

            migrationBuilder.AddColumn<int>(
                name: "GroupId",
                table: "Reminder",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Reminder_GroupId",
                table: "Reminder",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Reminder_Group_GroupId",
                table: "Reminder",
                column: "GroupId",
                principalTable: "Group",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reminder_Group_GroupId",
                table: "Reminder");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropIndex(
                name: "IX_Reminder_GroupId",
                table: "Reminder");

            migrationBuilder.DropColumn(
                name: "GroupId",
                table: "Reminder");

            migrationBuilder.AddColumn<string>(
                name: "Group",
                table: "Reminder",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
