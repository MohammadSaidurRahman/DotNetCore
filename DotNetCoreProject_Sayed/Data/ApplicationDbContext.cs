using System;
using System.Collections.Generic;
using System.Text;
using DotNetCoreProject_Sayed.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DotNetCoreProject_Sayed.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       public DbSet<Booking> Bookings { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Emloyee> Emloyees { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Stuff> Stuffs { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Tourist> Tourists { get; set; }




    }
}
