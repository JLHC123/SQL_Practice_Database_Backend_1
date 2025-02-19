using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using SQLBackEndPracticeDatabase1.Models;

namespace SQLBackEndPracticeDatabase1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
