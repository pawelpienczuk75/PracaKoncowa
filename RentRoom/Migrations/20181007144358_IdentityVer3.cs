using Microsoft.EntityFrameworkCore.Migrations;

namespace RentRoom.Migrations
{
    public partial class IdentityVer3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "CustomersID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeesID",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CustomersID",
                table: "AspNetUsers",
                column: "CustomersID");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_EmployeesID",
                table: "AspNetUsers",
                column: "EmployeesID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Customerses_CustomersID",
                table: "AspNetUsers",
                column: "CustomersID",
                principalTable: "Customerses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Employeeses_EmployeesID",
                table: "AspNetUsers",
                column: "EmployeesID",
                principalTable: "Employeeses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Customerses_CustomersID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Employeeses_EmployeesID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CustomersID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_EmployeesID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "CustomersID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "EmployeesID",
                table: "AspNetUsers");
        }
    }
}
