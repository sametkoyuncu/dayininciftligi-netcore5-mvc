using Microsoft.EntityFrameworkCore.Migrations;

namespace DayininCiftligiNetCore5.Migrations
{
    public partial class ChangeSomeColumnNameAndDefaultValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Header",
                table: "Messages",
                newName: "Subject");

            migrationBuilder.RenameColumn(
                name: "Body",
                table: "Messages",
                newName: "Text");

            migrationBuilder.RenameColumn(
                name: "GoogleMapUrl",
                table: "Contacts",
                newName: "GoogleMapsUrl");

            migrationBuilder.AlterColumn<bool>(
                name: "IsRead",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Text",
                table: "Messages",
                newName: "Body");

            migrationBuilder.RenameColumn(
                name: "Subject",
                table: "Messages",
                newName: "Header");

            migrationBuilder.RenameColumn(
                name: "GoogleMapsUrl",
                table: "Contacts",
                newName: "GoogleMapUrl");

            migrationBuilder.AlterColumn<bool>(
                name: "IsRead",
                table: "Messages",
                type: "bit",
                nullable: false,
                defaultValue: true,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldDefaultValue: false);
        }
    }
}
