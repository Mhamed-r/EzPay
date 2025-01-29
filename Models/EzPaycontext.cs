using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzPay.Models
{
    public class EzPaycontext:DbContext
    {
    
        public DbSet<User> Users { get; set; }

        public DbSet<Payment> Payments { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Server=desktop-gtd3iip\\sqlexpress;Database=EzPay;Trusted_Connection=True; TrustServerCertificate=True;");
            // optionsBuilder.LogTo(Console.Write);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(b => b.Balance)
                .HasDefaultValueSql("0");
        }
    }
}
