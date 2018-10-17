using Microsoft.EntityFrameworkCore.Migrations;

namespace RentRoom.Migrations
{
    public partial class ZmianaModelu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsConfirm",
                table: "RoomRent");

            migrationBuilder.DropColumn(
                name: "IsSettement",
                table: "RoomRent");

            migrationBuilder.AlterColumn<string>(
                name: "SizeOfRoom",
                table: "RoomDescriptionModels",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameOfRoom",
                table: "RoomDescriptionModels",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "IsAvailable",
                table: "RoomDescriptionModels",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IsConfirm",
                table: "RoomRent",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsSettement",
                table: "RoomRent",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SizeOfRoom",
                table: "RoomDescriptionModels",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "NameOfRoom",
                table: "RoomDescriptionModels",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "IsAvailable",
                table: "RoomDescriptionModels",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
