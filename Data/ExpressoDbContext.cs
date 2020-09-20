using System;
using ExpressoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpressoAPI.Data
{
    public class ExpressoDbContext : DbContext
    {
        public ExpressoDbContext(DbContextOptions<ExpressoDbContext> options) : base(options)
        {
            
        }

        public DbSet<Menu> MyProperty { get; set; }
        public DbSet<SubMenu> SubMenus { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}