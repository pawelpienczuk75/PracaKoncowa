using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using RentRoom.Models;

namespace RentRoom.Context
{
    public class RentContext : DbContext
    {
        public RentContext(DbContextOptions opt) : base(opt)
        {

        }
        public DbSet<Customers> Customerses { get; set; }
        public DbSet<Employees> Employeeses { get; set; }
        public DbSet<RoomDescriptionModel> RoomDescriptionModels { get; set; }
        public DbSet<RoomRentModel> RoomRent { get; set; }
        public DbSet<RoomWeekSchedule>RoomWeekSchedules { get; set; }

    }
}
