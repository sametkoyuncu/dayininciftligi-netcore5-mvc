using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DayininCiftligiNetCore5.Migrations
{
    public partial class AddSocialMediaEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 1, 4, 21, 44, 52, 295, DateTimeKind.Local).AddTicks(4276),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 27, 23, 24, 27, 257, DateTimeKind.Local).AddTicks(7469));

            migrationBuilder.CreateTable(
                name: "SocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Url = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialMedias", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SocialMedias");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Blogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 27, 23, 24, 27, 257, DateTimeKind.Local).AddTicks(7469),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 1, 4, 21, 44, 52, 295, DateTimeKind.Local).AddTicks(4276));
        }
    }
}
