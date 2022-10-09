using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Models;
using SalesWebMVC.Models.Enums;

namespace SalesWebMVC.Data
{
    public class SalesWebMVCContext : DbContext
    {
        public SalesWebMVCContext (DbContextOptions<SalesWebMVCContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; } = default!;
        public DbSet<Seller> Seller { get; set; } = default!;
        public DbSet<SalesRecord> SalesRecord { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
            .HasData(new List<Department>{
                new Department(1, "Computers"),
                new Department(2, "Eletronics"),
                new Department(3, "Fashion"),
                new Department(4, "Books")
            });

            modelBuilder.Entity<Seller>()
                .HasData(new List<Seller>
                {
                    new Seller(1, "Bob T", "bob@gmail.com", new DateTime(1998, 4, 21),100.0, 1),
                    new Seller(2, "Angel R", "angel@gmail.com", new DateTime(1995, 5, 21), 300.0, 2),
                    new Seller(3, "Marcio Z", "marcio@gmail.com", new DateTime(1990, 6, 21), 150.0, 3),
                    new Seller(4, "Juan M", "juan@gmail.com", new DateTime(1992, 10, 21), 85.0, 4)  
            });

            modelBuilder.Entity<SalesRecord>()
                .HasData(new List<SalesRecord>
                {
                    new SalesRecord(1, new DateTime(2022, 10, 01), 1000.0, SaleStatus.Billed, 1),
                    new SalesRecord(2, new DateTime(2022, 10, 01), 5000.0, SaleStatus.Pending, 1),
                    new SalesRecord(3, new DateTime(2022, 10, 01), 750.0, SaleStatus.Billed, 2),
                    new SalesRecord(4, new DateTime(2022, 10, 02), 750.0, SaleStatus.Canceled, 3),
                    new SalesRecord(5, new DateTime(2022, 10, 02), 1550.0, SaleStatus.Billed, 4),
                    new SalesRecord(6, new DateTime(2022, 10, 02), 11001, SaleStatus.Pending, 4),
            });


        }
    }

   

}
