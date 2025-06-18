using Microsoft.EntityFrameworkCore;
using Mini_Inventory_Management_System.Models;
using System;


namespace Mini_Inventory_Management_System.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
