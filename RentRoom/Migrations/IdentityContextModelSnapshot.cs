﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RentRoom.Context;

namespace RentRoom.Migrations
{
    [DbContext(typeof(IdentityContext))]
    partial class IdentityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("RentRoom.Models.Customers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Citi");

                    b.Property<string>("EmailOfCustomer");

                    b.Property<string>("NIP");

                    b.Property<string>("NameOfComany");

                    b.Property<string>("NameOfCustomer");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.ToTable("Customerses");
                });

            modelBuilder.Entity("RentRoom.Models.Employees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NameOfEmploye");

                    b.Property<string>("SurnameOfEmploye");

                    b.HasKey("Id");

                    b.ToTable("Employeeses");
                });

            modelBuilder.Entity("RentRoom.Models.RoomDescriptionModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomersId");

                    b.Property<int?>("EmployeesId");

                    b.Property<decimal>("FeePerHour");

                    b.Property<string>("IsAvailable");

                    b.Property<string>("NameOfRoom");

                    b.Property<string>("SizeOfRoom");

                    b.HasKey("Id");

                    b.HasIndex("CustomersId");

                    b.HasIndex("EmployeesId");

                    b.ToTable("RoomDescriptionModels");
                });

            modelBuilder.Entity("RentRoom.Models.RoomRentModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedByChanel");

                    b.Property<string>("CreatedByUser");

                    b.Property<string>("CreatedDate");

                    b.Property<int?>("CustomersId");

                    b.Property<string>("DateOfEvent");

                    b.Property<int?>("EmployeesId");

                    b.Property<string>("HourOfBeginEvent");

                    b.Property<string>("HourOfEndEvent");

                    b.Property<string>("IsConfirm");

                    b.Property<string>("IsSettement");

                    b.Property<string>("NameOfEvent");

                    b.Property<string>("OwnerOfEvent");

                    b.Property<int?>("RoomDescriptionModelId");

                    b.Property<int?>("RoomWeekScheduleId");

                    b.Property<string>("StateOfReservation");

                    b.HasKey("Id");

                    b.HasIndex("CustomersId");

                    b.HasIndex("EmployeesId");

                    b.HasIndex("RoomDescriptionModelId");

                    b.HasIndex("RoomWeekScheduleId");

                    b.ToTable("RoomRent");
                });

            modelBuilder.Entity("RentRoom.Models.RoomWeekSchedule", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EmployeesId");

                    b.Property<string>("HourOfBeginEvent");

                    b.Property<string>("HourOfEndEvent");

                    b.Property<string>("NameOfDayWeek");

                    b.Property<string>("NameOfEvent");

                    b.Property<int?>("RoomDescriptionModelId");

                    b.Property<string>("ValidTo");

                    b.HasKey("Id");

                    b.HasIndex("EmployeesId");

                    b.HasIndex("RoomDescriptionModelId");

                    b.ToTable("RoomWeekSchedules");
                });

            modelBuilder.Entity("RentRoom.Models.UserModel", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<int?>("CustomersID");

                    b.Property<int?>("EmployeesID");

                    b.Property<string>("Name");

                    b.HasIndex("CustomersID");

                    b.HasIndex("EmployeesID");

                    b.ToTable("UserModel");

                    b.HasDiscriminator().HasValue("UserModel");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("RentRoom.Models.RoomDescriptionModel", b =>
                {
                    b.HasOne("RentRoom.Models.Customers", "Customers")
                        .WithMany("DepencyCollectionRoomDescriptionModels")
                        .HasForeignKey("CustomersId");

                    b.HasOne("RentRoom.Models.Employees")
                        .WithMany("DepencyCollectionRoomDescriptionModels")
                        .HasForeignKey("EmployeesId");
                });

            modelBuilder.Entity("RentRoom.Models.RoomRentModel", b =>
                {
                    b.HasOne("RentRoom.Models.Customers", "Customers")
                        .WithMany()
                        .HasForeignKey("CustomersId");

                    b.HasOne("RentRoom.Models.Employees", "Employees")
                        .WithMany("DepencyCollectionRoomRentModels")
                        .HasForeignKey("EmployeesId");

                    b.HasOne("RentRoom.Models.RoomDescriptionModel", "RoomDescriptionModel")
                        .WithMany("DepencyCollectionRoomDescriptionModels")
                        .HasForeignKey("RoomDescriptionModelId");

                    b.HasOne("RentRoom.Models.RoomWeekSchedule", "RoomWeekSchedule")
                        .WithMany()
                        .HasForeignKey("RoomWeekScheduleId");
                });

            modelBuilder.Entity("RentRoom.Models.RoomWeekSchedule", b =>
                {
                    b.HasOne("RentRoom.Models.Employees", "Employees")
                        .WithMany("DepencyCollectionRoomWeekSchedules")
                        .HasForeignKey("EmployeesId");

                    b.HasOne("RentRoom.Models.RoomDescriptionModel", "RoomDescriptionModel")
                        .WithMany("DepencyCollectionRoomWeekSchedules")
                        .HasForeignKey("RoomDescriptionModelId");
                });

            modelBuilder.Entity("RentRoom.Models.UserModel", b =>
                {
                    b.HasOne("RentRoom.Models.Customers", "Customers")
                        .WithMany()
                        .HasForeignKey("CustomersID");

                    b.HasOne("RentRoom.Models.Employees", "Employees")
                        .WithMany()
                        .HasForeignKey("EmployeesID");
                });
#pragma warning restore 612, 618
        }
    }
}
