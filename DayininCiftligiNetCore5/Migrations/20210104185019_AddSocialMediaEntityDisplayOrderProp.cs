using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DayininCiftligiNetCore5.Migrations
{
    public partial class AddSocialMediaEntityDisplayOrderProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DisplayOrder",
                table: "SocialMedias",
                type: "int",
                maxLength: 2,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 4, 21, 50, 18, 449, DateTimeKind.Local).AddTicks(97),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 1, 4, 21, 44, 52, 295, DateTimeKind.Local).AddTicks(4276));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DisplayOrder",
                table: "SocialMedias");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 4, 21, 44, 52, 295, DateTimeKind.Local).AddTicks(4276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 1, 4, 21, 50, 18, 449, DateTimeKind.Local).AddTicks(97));
        }
    }
}
