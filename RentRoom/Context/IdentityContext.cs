using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentRoom.Models;
using RentRoom.ViewModels;

namespace RentRoom.Context
{
    public class IdentityContext : IdentityDbContext
    {
        public IdentityContext(DbContextOptions<IdentityContext> opt) : base(opt)
        {

        }
        public DbSet<Customers> Customerses { get; set; }
        public DbSet<Employees> Employeeses { get; set; }
        public DbSet<RoomDescriptionModel> RoomDescriptionModels { get; set; }
        public DbSet<RoomRentModel> RoomRent { get; set; }
        public DbSet<RoomWeekSchedule> RoomWeekSchedules { get; set; }
        public DbSet<UserModel> UserModels{ get; set; }

    //  public DbSet<RentRoom.ViewModels.RegisterViewModel> RegisterViewModel { get; set; }
}
}
