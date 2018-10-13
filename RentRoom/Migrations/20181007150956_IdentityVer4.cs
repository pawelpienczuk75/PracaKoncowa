using Microsoft.EntityFrameworkCore.Migrations;

namespace RentRoom.Migrations
{
    public partial class IdentityVer4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Customerses_CustomersID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Employeeses_EmployeesID",
                table: "AspNetUsers");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Customerses_CustomersID",
                table: "AspNetUsers",
                column: "CustomersID",
                principalTable: "Customerses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Employeeses_EmployeesID",
                table: "AspNetUsers",
                column: "EmployeesID",
                principalTable: "Employeeses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Customerses_CustomersID",
                table: "AspNetUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Employeeses_EmployeesID",
                table: "AspNetUsers");

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
    }
}
