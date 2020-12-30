using Microsoft.EntityFrameworkCore.Migrations;

namespace DayininCiftligiNetCore5.Migrations
{
    public partial class AddImageTableToDatabaseAndAddDisplayOrderDefaultValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DisplayOrder",
                table: "Products",
                type: "int",
                maxLength: 2,
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<int>(
                name: "DisplayOrder",
                table: "NavItems",
                type: "int",
                maxLength: 2,
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 2);

            migrationBuilder.AlterColumn<int>(
                name: "DisplayOrder",
                table: "Images",
                type: "int",
                maxLength: 2,
                nullable: false,
                defaultValue: 1,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 2);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "DisplayOrder",
                table: "Products",
                type: "int",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 2,
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "DisplayOrder",
                table: "NavItems",
                type: "int",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 2,
                oldDefaultValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "DisplayOrder",
                table: "Images",
                type: "int",
                maxLength: 2,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 2,
                oldDefaultValue: 1);
        }
    }
}
