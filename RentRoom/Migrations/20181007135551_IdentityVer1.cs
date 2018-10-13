using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RentRoom.Migrations
{
    public partial class IdentityVer1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customerses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameOfCustomer = table.Column<string>(nullable: true),
                    EmailOfCustomer = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    NameOfComany = table.Column<string>(nullable: true),
                    Citi = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    NIP = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customerses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employeeses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameOfEmploye = table.Column<string>(nullable: true),
                    SurnameOfEmploye = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employeeses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoomDescriptionModels",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameOfRoom = table.Column<string>(nullable: true),
                    IsAvailable = table.Column<string>(nullable: true),
                    SizeOfRoom = table.Column<string>(nullable: true),
                    FeePerHour = table.Column<decimal>(nullable: false),
                    CustomersId = table.Column<int>(nullable: true),
                    EmployeesId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomDescriptionModels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomDescriptionModels_Customerses_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customerses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomDescriptionModels_Employeeses_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employeeses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomWeekSchedules",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameOfEvent = table.Column<string>(nullable: true),
                    NameOfDayWeek = table.Column<string>(nullable: true),
                    HourOfBeginEvent = table.Column<string>(nullable: true),
                    HourOfEndEvent = table.Column<string>(nullable: true),
                    ValidTo = table.Column<string>(nullable: true),
                    EmployeesId = table.Column<int>(nullable: true),
                    RoomDescriptionModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomWeekSchedules", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomWeekSchedules_Employeeses_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employeeses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomWeekSchedules_RoomDescriptionModels_RoomDescriptionModelId",
                        column: x => x.RoomDescriptionModelId,
                        principalTable: "RoomDescriptionModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoomRent",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameOfEvent = table.Column<string>(nullable: true),
                    DateOfEvent = table.Column<string>(nullable: true),
                    HourOfBeginEvent = table.Column<string>(nullable: true),
                    HourOfEndEvent = table.Column<string>(nullable: true),
                    CreatedByUser = table.Column<string>(nullable: true),
                    CreatedByChanel = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<string>(nullable: true),
                    OwnerOfEvent = table.Column<string>(nullable: true),
                    IsConfirm = table.Column<string>(nullable: true),
                    StateOfReservation = table.Column<string>(nullable: true),
                    IsSettement = table.Column<string>(nullable: true),
                    CustomersId = table.Column<int>(nullable: true),
                    EmployeesId = table.Column<int>(nullable: true),
                    RoomWeekScheduleId = table.Column<int>(nullable: true),
                    RoomDescriptionModelId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoomRent", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoomRent_Customerses_CustomersId",
                        column: x => x.CustomersId,
                        principalTable: "Customerses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomRent_Employeeses_EmployeesId",
                        column: x => x.EmployeesId,
                        principalTable: "Employeeses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomRent_RoomDescriptionModels_RoomDescriptionModelId",
                        column: x => x.RoomDescriptionModelId,
                        principalTable: "RoomDescriptionModels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoomRent_RoomWeekSchedules_RoomWeekScheduleId",
                        column: x => x.RoomWeekScheduleId,
                        principalTable: "RoomWeekSchedules",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_RoomDescriptionModels_CustomersId",
                table: "RoomDescriptionModels",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomDescriptionModels_EmployeesId",
                table: "RoomDescriptionModels",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomRent_CustomersId",
                table: "RoomRent",
                column: "CustomersId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomRent_EmployeesId",
                table: "RoomRent",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomRent_RoomDescriptionModelId",
                table: "RoomRent",
                column: "RoomDescriptionModelId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomRent_RoomWeekScheduleId",
                table: "RoomRent",
                column: "RoomWeekScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomWeekSchedules_EmployeesId",
                table: "RoomWeekSchedules",
                column: "EmployeesId");

            migrationBuilder.CreateIndex(
                name: "IX_RoomWeekSchedules_RoomDescriptionModelId",
                table: "RoomWeekSchedules",
                column: "RoomDescriptionModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "RoomRent");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "RoomWeekSchedules");

            migrationBuilder.DropTable(
                name: "RoomDescriptionModels");

            migrationBuilder.DropTable(
                name: "Customerses");

            migrationBuilder.DropTable(
                name: "Employeeses");
        }
    }
}
