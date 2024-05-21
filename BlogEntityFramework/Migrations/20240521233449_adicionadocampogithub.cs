using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogEntityFramework.Migrations
{
    public partial class adicionadocampogithub : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Github",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Github",
                table: "User");
        }
    }
}
