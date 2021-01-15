using Microsoft.EntityFrameworkCore.Migrations;

namespace DayininCiftligiNetCore5.Migrations.Application
{
    public partial class AddProfilePhotoColumnForUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePhoto",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePhoto",
                table: "AspNetUsers");
        }
    }
}
